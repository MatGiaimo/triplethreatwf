<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="TripleThreat.Framework.Core" %>
<%@ Import Namespace="System.Data.Entity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	NewWorkFlow
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%: Html.ActionLink("<-- Manage WorkFlows", "ManageWorkflow", "Workflow")%>
    <h2>Create New WorkFlow</h2>

    <br /><br />
    <% using (Html.BeginForm("CreateWorkFlow", "Workflow")) %>
    <% { %>
        Enter WorkFlow name: <%= Html.TextBox("name") %>
        <br /><br />
        Select Folder: <%= Html.DropDownList("FolderList")%>   <%: Html.ActionLink("new", "ManageFolder", "Folder")%>
        <br /><br />
        Select WorkFlow Steps:<br />
        <table>
        <thead>
        <th></th>
        <th>Name</th>
        <th>Description</th>
        </thead>
        <tbody>
            <tr>
            <td><%= Html.CheckBox("stepone") %></td>
            <td>stepone</td>
            <td>some step description</td>
            </tr>
            <tr>
            <td><%= Html.CheckBox("steptwo") %></td>
            <td>steptwo</td>
            <td>some step description</td>
            </tr>
            <tr>
            <td><%= Html.CheckBox("stepthree") %></td>
            <td>stepthree</td>
            <td>some step description</td>
            </tr>
            <tr>
            <td><%= Html.CheckBox("stepfour") %></td>
            <td>stepfour</td>
            <td>some step description</td>
            </tr>
        </tbody>
        </table>
        <br />
        <input type="submit" value="Create" />
    <% } %>

    
</asp:Content>
