# MailChimpWrapper
This project wraps around the basic MailChimp API, and gives you an easier and more readable solution for requesting data.

## Currently includes:
- Ping
- Root
- Lists (Audiences)
- List Members
- MemberTags

## Usage
### Initialize the client:
```
MailChimpWrapper.MailChimpClient client = new MailChimpWrapper.MailChimpClient("APIKEY", "SERVER");
```
### Ping
```
PingResponse pingResult = await client.GetRequest<PingResponse>(Endpoints.Ping);
```
### Root
```
RootResponse rootresp = await client.GetRequest<RootResponse>(Endpoints.Root);
```
### Lists (Audiences)
#### Get multiple
```
ListsResponse listsResult = await client.GetRequest<ListsResponse>(Endpoints.Lists);
```
#### Get by id
```
ListResponse listResult = await client.Request<ListGetRequest, ListResponse>(new ListGetRequest("ID"));
```
### List Members
#### Post
```
var listMembers = new List<Member>() { new Member(){
            EmailAddress="emailaddress",
            EmailClient="Outlook",
            Language="En",
            Status="subscribed",
            EmailType="html"
        }
    };
ListMembersResponse listMembersResponse = await client.Request<ListMembersPostRequest, ListMembersResponse>(new ListMembersPostRequest("listId", listMembers));

```
### Member Tags
#### Get
```
MemberTagsResponse memberTagsResponse = await client.Request<MemberTagsGetRequest, MemberTagsResponse>(new MemberTagsGetRequest("listId", "emailaddress"));
```
#### Post
Note: Because the Api doesn't return any content there is no response.
```
await client.Request(new MemberTagsPostRequest("listId", "emailaddress", new List<Tag>() { new Tag() { Name = "tagName", Status = "active/inactive" } }));
```

<br/>
<br/>
<br/>
<b>Note this project is in a very early stage!</b>
