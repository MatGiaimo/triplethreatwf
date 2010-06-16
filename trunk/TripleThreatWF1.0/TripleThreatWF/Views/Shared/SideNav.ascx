<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div><%: Html.ActionLink("Open Items", "Index", "Home")%></div>
<div><%: Html.ActionLink("Search Documents", "SearchDocuments", "Search")%></div>
<div><%: Html.ActionLink("Manage Users", "ManageUsers", "Account")%></div>
<div><%: Html.ActionLink("Manage Customers", "ManageCustomers", "Customer")%></div>
<div><%: Html.ActionLink("Manage Folders", "ManageFolders", "Folder")%></div>
<div><%: Html.ActionLink("Manage Workflow", "ManageWorkflow", "Workflow")%></div>
<div><%: Html.ActionLink("Manage Document", "ManageDocument", "Document")%></div>