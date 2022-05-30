# Overview

Anchor's API is REST-based and follows the [JSON:API specification](https://jsonapi.org/format/). This documentation should guide you from the basics (authentication, request structure) to how clients should be using and creating financial products (accounts, transfers etc.).

Ready to get started? First, you will need a Anchor account.

## Authentication

Anchor API uses API keys to authenticate requests. You can generate one after requesting your business to go live.

Requests are authenticated with an API (secret) key with the following request header:

<aside>
💡 "x-anchor-key: YOUR_API_KEY"

</aside>

```jsx
curl --request POST \
     --url 'https://api.getanchor.co/v1/customer' \
     --header 'Accept: application/json' \
     --header 'x-anchor-key: YOUR_API_KEY'
```

<aside>
💡 An invalid, missing, or expired token will result in *HTTP 401 Unauthorized* responses.

</aside>

## Status Codes

Anchor uses HTTP response Codes to indicate whether a request has been successfully processed or failed.

Any `2xx` response is successful. A `4xx` means that there was an error with the data provided (like an invalid account number). These errors can sometimes be handled programmatically by your application when we provide an error reason. A `5xx` error means we encountered an error in our software, which we will work to fix immediately.

A table of status codes and their meanings can be found below.

|  |  |
| --- | --- |
| 200 - Created | The request succeeded and the new resource was created. |
| 202 - Accepted | The request has been accepted for processing, but the processing has not been completed. |
| 400 - Bad Request | A parameter in the query given in the request does not match the valid queries for the endpoint |
| 401 - Unauthorized | Invalid or missing API key |
| 403 - Forbidden | The API key doesn't have permission to perform the request. |
| 404 - Not Found | The requested resource doesn't exist. |
| 429 - Too many Requests | Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |
| 500 - Internal Server Error | There was a processing error on the server-side. |
| 503 - Service Unavailable | There was a processing error on the server-side. |

## Organisation Accounts

When you sign up for Anchor, we will create organisation accounts to support your activities . The organisation account is different from deposit account because they exist on the org level and not under your customers

- Has capability to facilitate money movement
- Can be used as a source or destination in a transfer
- Can be credited by Anchor for interest and payment revenues.

## Required Field

Unless specified otherwise, all the fields in the request payload are required. Some fields are only required under specific circumstances - these fields are pointed out throughout the documentation.

## Getting started with the API

Examples are often the easiest way to explain. Feel free to head over to the next section though if you'd rather dive straight in!

Today, we are going to build a basic transfer workflow consisting of a deposit account, virtual nuban and an Interbank transfer. In this guide, we will perform the following steps to build our workflow:

1. Setup Webhook
2. Create a customer
3. Create a bank account for the customer
4. Transfer Funds to your Deposit Account
5. Create Counterparty
6. Create Interbank Transfer

First, you'll need to call the Get API Keys endpoint and copy your **`api-key`**. A sandbox key is infix with **`_test_`** and a live key is infix with `**_prod_**`.

### Set up webhooks

You can configure webhook endpoints via APIs or Dashboard in your organisation to be notified about events from.

Some resources happen from external sources and it might take a while for them to be processed successfully. The only way to know when some resource has been done and created is through webhooks.

### Create customer

Once you have a valid key, you'll create a `**customer**`. Customers represent Individuals or businesses that you may create financial products for. Each Customer represents a legal entity and has information describing the customer. In this example I'll use myself - an individual owner.

```json
curl --location --request POST 'https://api.getanchor.co/api/v1/customers' \
--header 'Content-Type: application/json' \
--header 'x-anchor-key: <YOUR API KEY>' \
--data-raw '{
    "data": {
        "type": "IndividualCustomer",
        "attributes": {
            "bvn": "17307301070",
            "fullName": {
                "firstName": "Kathryn",
                "lastName": "Bins",
                "middleName": "Gislason"
            },
            "dateOfBirth": "1994-06-25",
            "gender": "Male",
            "email": "Velva.Funk@hotmail.com",
            "phoneNumber": "07061106107",
            "address": {
                "addressLine_1": "93263 Hamill Creek",
                "addressLine_2": "517 Sheila Unions",
                "city": "West Jovanberg",
                "state": "Ogun",
                "postalCode": "123456",
                "country": "NG"
            }
        }
    }
```

### Create account

Next, you are going to create a **`depositaccount`** that will be attached to the **`customer`**. You'll receive a `**customer_id**` from the create customer response that will be used to create deposit accounts.

```json
curl --location --request POST 'https://api.getanchor.co/api/v1/accounts' \
--header 'Content-Type: application/json' \
--header 'x-anchor-key: <YOUR API KEY>' \
--data-raw '{
    "data": {
        "type": "DepositAccount",
        "attributes": {
            "productName": "SAVINGS"
        },
        "relationships": {
            "customer": {
                "data": {
                    "id": "1648209373471-1ind_16503605370680",
                    "type": "IndividualCustomer"
                }
            }
        }
    }
}
```

You’ll get a 202 Status Code. We’re working to create your deposit account. In the webhook event response to *create account* you'll receive an **`account_id`** and `**virtual_nuban_id`** you will use to fetch the `**account_number**` and **`virtual_account_number`** of your deposit account and virtual nuban respectively. These will be used to externally identify your account for transfers. Now, you have a deposit account that you can move money in an out of! 

> Every account is created with an **`account_number`**, however by default a **`virtual_account_number`** called Virtual Nuban is automatically created for you when you create a deposit account. You can also create your own multiple virtual account numbers that are associated with this account. You can view them as pointers to that deposit account - however, they are all valid account numbers that you can make bank transfer to. You can create and remove them without interfering with the underlying deposit account.
> 

### Transfer Funds to your Deposit Account

For technical reasons we’ve masked the **`account_number`** of your deposit account. You can fetch your virtual account number pointing to your deposit acount by using

```json
curl --location --request GET 'https://api.getanchor.co/api/v1/virtual-nubans/:virtualNubanId' \
--header 'x-anchor-key: <YOUR API KEY>'
```

Once you’ve retrieved the account details of the virtual nuban. You can make a transfer to your account successfully. 

You should now have a balance on your account. To confirm the balance on your account, feel free to send a **`GET`** request using your account_id as shown below.

```json
curl --location --request GET 'https://api.getanchor.co/api/v1/accounts/balance/:accountId' \
--header 'x-anchor-key: <YOUR API KEY>'
```

### Create counterparty

A **`counterparty`** is an external account that you can transfer money to and from. All Interbank transfers from Anchor take in a **`counterparty_id`** to identify the recipient. Let's create a **`counterparty`** we can transfer to with this 3 steps:

1. Verify Account Number
2. Create counterparty

You need to collect the customer's account details and confirm that it’s valid before adding as a counterparty. This is to ensure you don’t send money to the wrong or invalid account. 

When creating a counterparty, you need the bank of the counterparty. To get a list of supported banks you can transfer money to, send a **`GET`** request to List Banks.

```json
curl --location --request GET 'https://api.getanchor.co/api/v1/banks' \
--header 'x-anchor-key: <YOUR API KEY>'
```

Next is to verify the account number by sending another **`GET`** request with the bank_id of the counterparty destination bank you got from the List Banks and the counterparty account number

```json
curl --location --request GET 'https://api.getanchor.co/api/v1/payments/verify-account/:bankId/:accountNumber' \
--header 'x-anchor-key: <YOUR API KEY>'
```

To create a **`counterparty`,** account name(as returned from the verify account number), account number and bank id 

```json
curl --location --request POST 'https://api.getanchor.co/api/v1/counterparties' \
--header 'x-anchor-key: <YOUR API KEY>' \
--header 'Content-Type: application/json' \
--data-raw '{
    "data": {
        "type": "CounterParty",
        "attributes": {
            "accountName": "OLAMODE ADE SOBOKUNLE",
            "accountNumber": "0068970263"
        },
        "relationships": {
            "bank": {
                "data": {
                    "id": "1651680377788246-anc_bk",
                    "type": "Bank"
                }
            }
        }
    }
}'
```

Now that you created a **`counterparty`** - you can send money to it ! 

### Create Interbank transfer

Let's send NGN100 to our **`counterparty`** through a NIP outflow request. An outflow, is when you push money from your account to an external account. Insert the **`counterparty_id`** from the last request and the **`account_id`** of your account. 

```json
curl --location --request POST 'https://api.getanchor.co/api/v1/transfers' \
--header 'Content-Type: application/json' \
--header 'x-anchor-key: <YOUR API KEY>' \
--data-raw '{
    "data": {
        "type": "NIPTransfer",
        "attributes": {
            "amount": 10000,
            "currency": "NGN",
            "reason": "Olamide 3 again"
        },
        "relationships": {
            "account": {
                "data": {
                    "id": "16517725619924-anc_acc",
                    "type": "DepositAccount"
                }
            },
            "counterParty": {
                "data": {
                    "id": "16518495829780-anc_cp",
                    "type": "CounterParty"
                }
            }
        }
    }
}'
```

<aside>
💡 Amounts are always denominated in kobo.

</aside>

When you send this request, if there are no errors, the response comes back with a pending status, while the transfer is being processed.

Congrats on your first outgoing transfer! You'll receive a webhook to remain updated as the NIP transfer goes through every step of the process and finally settles in the destination account. Note that NIP transfers processing usually take between a few seconds and a few minutes.