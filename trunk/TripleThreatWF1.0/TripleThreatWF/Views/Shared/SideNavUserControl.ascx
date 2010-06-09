<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div><%: Html.ActionLink("Open Items", "Register", "Account")%></div>
<div><%: Html.ActionLink("Search Documents", "SearchDocs", "Home")%></div>
<div><%: Html.ActionLink("Manage Users", "ManageUsers", "Account")%></div>
<div><%: Html.ActionLink("Manage Customers", "ManageCustomers", "Account")%></div>
<div><%: Html.ActionLink("Manage Folders", "ManageFolders", "Account")%></div>
<div><%: Html.ActionLink("Manage Workflow", "ManageWorkflow", "Account")%></div>
<div><%: Html.ActionLink("Manage Document", "ManageDoc", "Home")%></div>