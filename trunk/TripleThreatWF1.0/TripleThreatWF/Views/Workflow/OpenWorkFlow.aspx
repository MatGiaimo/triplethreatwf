<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="TripleThreat.Framework.Core" %>
<%@ Import Namespace="System.Data.Entity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	OpenWorkFlow
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>WorkFlow</h2>

    <p>
       <%: Html.ActionLink("<<- Go Back", "ManageWorkFlow", "Workflow")%>
    </p>

    <% using (Html.BeginForm("HandleWF", "Workflow")) %>
    <% { %>
        WorkFlow: <%= Html.DropDownList("WorkFlowList")%>
        <br /><br />
        Selected WorkFlow: <%= Html.DisplayText("SelectedWorkFlow") %>
        <input type="submit" value="Submit" />
    <% } %>

</asp:Content>
