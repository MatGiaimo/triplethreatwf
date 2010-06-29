<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div><%: Html.ActionLink("Open Items", "Index", "Home")%></div>
<div><%: Html.ActionLink("Search Documents", "SearchDocuments", "Search")%></div>
<% if (HttpContext.Current.User.IsInRole("Manager") || HttpContext.Current.User.IsInRole("Supervisor")) { %>
<div><%: Html.ActionLink("Manage Users", "ManageUsers", "User")%></div>
<%} %>
<% if (HttpContext.Current.User.IsInRole("Manager") || HttpContext.Current.User.IsInRole("Supervisor")) { %>
<div><%: Html.ActionLink("Manage Customers", "ManageCustomer", "Customer")%></div>
<%} %>
<div><%: Html.ActionLink("Manage Folders", "ManageFolder", "Folder")%></div>
<div><%: Html.ActionLink("Manage Workflow", "ManageWorkflow", "Workflow")%></div>
<div><%: Html.ActionLink("Create Document", "CreateDocument", "Document")%></div>
<div><%: Html.ActionLink("Create Lender", "Lenders", "Lender")%></div>
