﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Folder
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <%= Html.MvcSiteMap().SiteMapPath() %> 
    <%: Html.ActionLink("<<- Go Back", "ManageWorkFlow", "Workflow")%>
    <h2>Folder: <%=((Folder)ViewData["CurrentFolder"]).Name%></h2>

    <% using (Html.BeginForm("HandleDocumentRadio", "Folder", new { Id = ((Folder)ViewData["CurrentFolder"]).Id })) %>
    <% { %>
            <div>&nbsp;</div>
            Current Documents:
            <table>
            <thead>
            <th></th>
            <th>Document Name</th>
            <th>Customer Name</th>
            <th>Date Created</th>
            <th>Added By</th>
            </thead>
            <tbody>
             <% if(((Folder)this.ViewData["CurrentFolder"]).Documents.Count == 0)
            { %>
                <tr>
                <td></td>
                <td>--</td>
                <td>Folder Empty</td>
                <td>--</td>
                <td>--</td>
                </tr>
                </tbody>
                </table>
            <% } %>
            <%else { %>
                <% foreach (Document doc in ((Folder)this.ViewData["CurrentFolder"]).Documents)
                   { %>
                   <tr>
                   <td><%= Html.RadioButton("SelectedDocument", doc.Id, true)%></td>
                   <td><%= doc.Name %></td>
                    <td><%=doc.Customer.FullName%></td>
                    <td><%=doc.CreatedDate%></td>
                    <td><%=doc.AddedBy%></td>
                   </tr>
                   <% } %>
                   </tbody>
                   </table>
                   <input type="submit" value="Open Document" />
            <% } %>
    <% } %>
    <div>&nbsp;</div>
    <div>&nbsp;</div>
    <% using (Html.BeginForm("AddDocument", "Folder", new { Id = ((Folder)ViewData["CurrentFolder"]).Id })) %>
    <% { %>
            <input type="submit" value="Add Documents" />
    <% } %>

</asp:Content>
