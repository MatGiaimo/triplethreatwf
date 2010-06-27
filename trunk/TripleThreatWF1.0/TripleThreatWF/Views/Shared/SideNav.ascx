<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div><%: Html.ActionLink("Open Items", "Index", "Home")%></div>
<div><%: Html.ActionLink("Search Documents", "SearchDocuments", "Search")%></div>
<div><%: Html.ActionLink("Manage Users", "ManageUsers", "User")%></div>
<div><%: Html.ActionLink("Manage Customers", "ManageCustomer", "Customer")%></div>
<div><%: Html.ActionLink("Manage Folders", "ManageFolder", "Folder")%></div>
<div><%: Html.ActionLink("Manage Workflow", "ManageWorkflow", "Workflow")%></div>
<div><%: Html.ActionLink("Manage Document", "ManageDocument", "Document")%></div>
