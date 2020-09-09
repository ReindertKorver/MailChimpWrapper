# MailChimpWrapper
This project wraps around the basic MailChimp API, and gives you an easier and more readable solution for requesting data.

## Currently includes:
- Ping
- Lists
- List

## Usage
### Initialize the client:
```
MailChimpWrapper.MailChimpClient client = new MailChimpWrapper.MailChimpClient("APIKEY", "SERVER");
```
### Ping
```
PingResponse pingResult = await client.GetRequest<PingResponse>(Endpoints.Ping);
```
### Lists
```
ListsResponse listsResult = await client.GetRequest<ListsResponse>(Endpoints.Lists);
```
```
ListResponse listResult = await client.Request<ListGetRequest, ListResponse>(new ListGetRequest("ID"));
```

<b>Note this project is in a very early stage!</b>
