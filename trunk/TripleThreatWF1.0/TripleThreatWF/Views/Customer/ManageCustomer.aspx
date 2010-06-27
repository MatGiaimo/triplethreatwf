<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="TripleThreat.Framework.Core" %>
<%@ Import Namespace="System.Data.Entity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ManageCustomer
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>ManageCustomer</h2>
<%--    <div style="display:inline"><a href="#">Add Customer</a></div>--%>
     <p>
       <%: Html.ActionLink("Add Customer", "ManageCustomer", "customer")%>
    </p>
    <table>
    <tr><td>Name</td></tr>
    <% foreach (Customer customer in (IList<Customer>)this.ViewData["Customers"])
       { %>
       <tr><td><%= customer.FirstName %></td></tr>
       <% } %>
    </table>
    <div>&nbsp;</div>
    <table>
    <thead>
    <th>SSN</th>
    <th>Customer Name</th>
    </thead>
    <tbody>
    <tr>
    <td>12345678</td>
    <td>Eldon Tyrell</td>
    </tr>
    <tr>
    <td>12345672</td>
    <td>Rick Deckard</td>
    </tr>
    <tr>
    <td>12345674</td>
    <td>Roy Batty</td>
    </tr>
    </tbody>
    </table>

</asp:Content>
