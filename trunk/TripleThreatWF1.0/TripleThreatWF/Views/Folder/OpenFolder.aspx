<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="TripleThreat.Framework.Core" %>
<%@ Import Namespace="System.Data.Entity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	OpenFolder
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Folder</h2>

    <% using (Html.BeginForm("HandleDocumentRadio", "Folder", new { Id = ((Folder)ViewData["CurrentFolder"]).Id })) %>
    <% { %>
            <div>&nbsp;</div>
            Current Documents:
            <table>
            <thead>
            <th></th>
            <th>ID</th>
            <th>Name</th>
            </thead>
            <tbody>
             <% if(((Folder)this.ViewData["CurrentFolder"]).Documents.Count == 0)
            { %>
                <tr>
                <td>--folder empty--</td>
                </tr>
            <% } %>
            <%else { %>
                <% foreach (Document doc in ((Folder)this.ViewData["CurrentFolder"]).Documents)
                   { %>
                   <tr>
                   <td><%= Html.RadioButton("SelectedDocument", doc.Id, false)%></td>
                   <td><%= doc.Name %></td>
                   </tr>
                   <% } %>
            <% } %>
            </tbody>
            </table>
            <input type="submit" value="Open" />
    <% } %>
    <% using (Html.BeginForm("AddDocument", "Folder", new { Id = ((Folder)ViewData["CurrentFolder"]).Id })) %>
    <% { %>
            <input type="submit" value="Add" />
    <% } %>

</asp:Content>
