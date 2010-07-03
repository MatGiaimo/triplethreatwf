<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div><%: Html.ActionLink("Open Items", "Index", "Home")%></div>
<br />
<div><%: Html.ActionLink("Add Document", "CreateDocument", "Document")%></div>
<br />
<div><%: Html.ActionLink("Search", "SearchDocuments", "Search")%></div>
<br />
<% if (HttpContext.Current.User.IsInRole("Manager") || HttpContext.Current.User.IsInRole("Supervisor")) { %>
<div><%: Html.ActionLink("Users", "ManageUsers", "User")%></div>
<br />
<%} %>
<% if (HttpContext.Current.User.IsInRole("Manager") || HttpContext.Current.User.IsInRole("Supervisor")) { %>
<div><%: Html.ActionLink("Customers", "ManageCustomer", "Customer")%></div>
<br />
<%} %>
<div><%: Html.ActionLink("Lenders", "Lenders", "Lender")%></div>
<br />
<div><%: Html.ActionLink("Workflows", "ManageWorkflow", "Workflow")%></div>
<br />
<div><%: Html.ActionLink("Workflow Builder", "NewWorkFlow", "Workflow")%></div>
<br />
