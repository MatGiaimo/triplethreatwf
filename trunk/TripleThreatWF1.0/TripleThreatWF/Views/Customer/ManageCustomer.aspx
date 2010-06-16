<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ManageCustomer
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>ManageCustomer</h2>
    <div style="display:inline"><a href="#">Add Customer</a></div>
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
