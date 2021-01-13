# MailChimpWrapper
This project wraps around the basic MailChimp API, and gives you an easier and more readable solution for requesting data.
Nuget package: [MailChimpWrapper](https://www.nuget.org/packages/MailChimpWrapper/)
# Usage
## Initialize the client:
```cs
MailChimpWrapper.MailChimpClient client = new MailChimpWrapper.MailChimpClient("APIKEY", "SERVER");
```
## Ping
```cs
PingResponse pingResult = await client.GetRequest<PingResponse>(Endpoints.Ping);
```
## Root
```cs
RootResponse rootresp = await client.GetRequest<RootResponse>(Endpoints.Root);
```
## Lists (Audiences)
### Get multiple
```cs
ListsResponse listsResult = await client.GetRequest<ListsResponse>(Endpoints.Lists);
```
### Get by id
```cs
ListResponse listResult = await client.Request<ListGetRequest, ListResponse>(new ListGetRequest("ID"));
```
## List Members
### Post 
```cs
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
## Member Tags
### Get
```cs
MemberTagsResponse memberTagsResponse = await client.Request<MemberTagsGetRequest, MemberTagsResponse>(new MemberTagsGetRequest("listId", "emailaddress"));
```
### Add tag to member in list
> Note: Because the Api doesn't return any content there is no response.
```cs
await client.Request(new MemberTagsPostRequest("listId", "emailaddress", new List<Tag>() { new Tag() { Name = "tagName", Status = "active/inactive" } }));
```
## Campaigns
### Get all 
```cs
var listCampaigns = await client.GetRequest<CampaignsResponse>(Endpoints.Campaigns);
```
### Get by id
```cs
CampaignResponse campaign = await client.Request<CampaignGetRequest, CampaignResponse>(new CampaignGetRequest("campaignId"));
```
### Post new
```cs
var newCampaign = await client.Request<CampaignNewPostRequest, CampaignResponse>(new CampaignNewPostRequest(CampaignType.regular));
```
### Send/Resend
```cs
await client.Request(new CampaignSendRequest(campaign.Id));
```
```cs
await client.Request(new CampaignResendRequest(campaign.Id));
```
### Delete campaign
```cs
await client.Request(new CampaignDeleteRequest(campaign.Id));

```
# Guides
## Batch Subscribe/Unsubscribe Member to List(Audience)
This guide will show you how to subscribe and also unsubscribe batches of members.
1. Create a list of members:
```cs
List<Member> members = new List<Member>();
```
2. Add a member to the list, change `newMember.Status` to one of the possible values: "subscribed", "unsubscribed", "cleaned", or "pending".
```cs
Member newMember = new Member();
newMember.Status = "subscribed";
newMember.MergeFields = new Dictionary<string, object>();
newMember.EmailAddress = "Emailaddress";
newMember.MergeFields = new Dictionary<string, object>()
{
    {"FNAME","FirstName"},
    {"LNAME","LastName"},
};
members.Add(newMember);
```
3. Create the batch subscribe request
```cs
var response = await MailChimpService.Client.Request<BatchSubscribeUnsubscribeRequest, BatchSubscribeUnsubscribeResponse>(
    new BatchSubscribeUnsubscribeRequest("YOUR LISTID")
    {
        Members = members,
        UpdateExisting = true,
    });

```
4. Check the amount of created members
```cs
var amountOfNewMembers = response.NewMembers;
```

## Add List(Audience) to campaign
This guide will explain how to edit a campaign and add you existing audience to it.
1. Get the campaign by id:
```cs
CampaignResponse campaign = await client.Request<CampaignGetRequest, CampaignResponse>(new CampaignGetRequest("YOUR CAMPAIGNID"));
```
2. Edit their Recipients:
```cs
Recipients recipients = campaign.Recipients;
recipients.ListId = "YOUR LISTID";
```
3. Create a campaign edit request, inside the new request add the new recipients:
```cs
CampaignEditRequest campaignEditRequest = new CampaignEditRequest(campaign.Id) { Recipients = recipients };
```
4. Now request the edit of the campaign using the client:
```cs
CampaignResponse updatedCampaign = await client.Request<CampaignEditRequest, CampaignResponse>(campaignEditRequest);
```


# Error handling:
```cs
try
{
    //request
}
catch (ResponseException responseException)
{
    var message = responseException.ErrorResponse.Detail;
}
catch (UnknownResponseException unknownException)
{
    var response = unknownException.ResponseMessage;
}
```

> Note: This project is in a very early stage!
