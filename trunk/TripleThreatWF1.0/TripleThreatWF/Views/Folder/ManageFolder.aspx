<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Folder
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%: Html.ActionLink("<-- Go Back", "NewWorkFlow", "Workflow")%>
    <h2>Manage Folders</h2>

    <% using (Html.BeginForm("Save", "Folder"))
       { %>
    <div>Folder Name:</div><div display="inline"><input type="text" name="FolderName" id="FolderName" /></div>
    <input type="submit" value="Create" />
    <% } %>
    <br /><br />

    <% using(Html.BeginForm("HandleRadio", "Folder")) %>
    <% { %>
            <div>&nbsp;</div>
            Current Folders:
            <table>
            <thead>
            <th></th>
            <th>ID</th>
            <th>Name</th>
            </thead>
            <tbody>
            <% foreach (Folder folder in (IList<Folder>)this.ViewData["Folders"])
               { %>
               <tr>
               <td><%= Html.RadioButton("SelectedFolder", folder.Id, false)%></td>
               <td><%= folder.Id %></td>
               <td><%= folder.Name %></td>
               </tr>
               <% } %>
            </tbody>
            </table>
            <input type="submit" value="Open Folder" />
    <% } %>

</asp:Content>
