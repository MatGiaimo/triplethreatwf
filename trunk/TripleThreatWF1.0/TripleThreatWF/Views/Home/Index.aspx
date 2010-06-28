<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="TripleThreatWF.Models" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
    <%
        if (!Request.IsAuthenticated)
        {
            Html.RenderPartial("LogOn");
        }
        else
        {
            SearchModel sm = (SearchModel)ViewData["PartialSM"];      
            Html.RenderPartial("OpenItems",sm);
        }
    %>
    </p>
</asp:Content>
