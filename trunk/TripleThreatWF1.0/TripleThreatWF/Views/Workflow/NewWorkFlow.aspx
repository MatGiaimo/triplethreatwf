<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="TripleThreat.Framework.Core" %>
<%@ Import Namespace="System.Data.Entity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	NewWorkFlow
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>NewWorkFlow</h2>
    

    <% using (Html.BeginForm("HandleForm", "Workflow")) %>
    <% { %>
        Folders: <%= Html.DropDownList("FolderList")%>
        <br /><br />
        WorkFlowSteps: <%= Html.DropDownList("StepsList")%>
        <br /><br />
        <input type="submit" value="Submit" />
    <% } %>

</asp:Content>
