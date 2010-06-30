<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="TripleThreat.Framework.Core" %>
<%@ Import Namespace="System.Data.Entity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	OpenDocument
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>OpenDocument</h2>

    <%= ((Document)this.ViewData["CurrentDocument"]).Name%>

</asp:Content>
