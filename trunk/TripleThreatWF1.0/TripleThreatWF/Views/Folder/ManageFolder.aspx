<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="TripleThreat.Framework.Core" %>
<%@ Import Namespace="System.Data.Entity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ManageFolder
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Manage Folder</h2>

    <% using (Html.BeginForm("Save", "Folder"))
       { %>
    <div>Folder Name:</div><div display="inline"><input type="text" name="FolderName" id="FolderName" /></div>
    <input type="submit" value="Save" />
    <% } %>

    <table>
    <tr><td>Name</td></tr>
    <% foreach (Folder folder in (IList<Folder>)this.ViewData["Folders"])
       { %>
       <tr><td><%= folder.Name %></td></tr>
       <% } %>
    </table>
</asp:Content>
