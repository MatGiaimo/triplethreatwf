<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="TripleThreat.Framework.Core" %>
<%@ Import Namespace="System.Data.Entity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	User
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create a New User</h2>
    <p>
        Use the form below to create a new user. 
    </p>
    <p>
       <%: Html.ActionLink("Add Users", "Register", "Account")%>
    </p>
    <table>
    <tr><td>Name</td></tr>
    <% foreach (aspnet_Membership name in (IList<aspnet_Membership>)this.ViewData["UserId"])
       { %>
       <tr><td><%= name.UserId%></td></tr>
       <% } %>
    </table>

</asp:Content>
