<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	AddDocuments
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Add Document to Folder</h2>

    <div>&nbsp;</div>
    Documents in Folder:<br />
    <div>&nbsp;</div>
    <table>
    <thead>
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
            <td><%= doc.Name %></td>
            </tr>
            <% } %>
    <% } %>
    </tbody>
    </table>

    <br /><br />
    
    <% using (Html.BeginForm("AddDocumentRadio", "Folder", new { Id = ((Folder)ViewData["CurrentFolder"]).Id })) %>
    <% { %>
            <div>&nbsp;</div>
            Other Documents:<%: Html.ActionLink("Create New", "CreateDocument", "Document")%><br />
            <div>&nbsp;</div>
            <table>
            <thead>
            <th></th>
            <th>Name</th>
            </thead>
            <tbody>
            <% foreach (Document doc in (IList<Document>)this.ViewData["Documents"])
               { %>
               <tr>
               <td><%= Html.RadioButton("SelectedDocument", doc.Id, true)%></td>
               <td><%= doc.Name %></td>
               </tr>
               <% } %>
            </tbody>
            </table>
            <div>&nbsp;</div>
            <input type="submit" value="Add to Folder" />
    <% } %>

    <br /><br />
    <% using (Html.BeginForm("AddDocumentDone", "Folder", new { Id = ((Folder)ViewData["CurrentFolder"]).Id })) %>
    <% { %>
            <input type="submit" value="Finished" />
    <% } %>

</asp:Content>
