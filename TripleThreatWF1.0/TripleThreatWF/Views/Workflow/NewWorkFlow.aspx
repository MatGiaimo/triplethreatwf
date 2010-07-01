<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	New WorkFlow
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<%--    <%: Html.ActionLink("<-- Manage WorkFlows", "ManageWorkflow", "Workflow")%>--%>

    <%= Html.MvcSiteMap().SiteMapPath() %> 

    <h2>Create New WorkFlow</h2>

    <br /><br />
    <% using (Html.BeginForm("CreateWorkFlow", "Workflow")) %>
    <% { %>
        Enter WorkFlow name:<br /><%= Html.TextBox("name") %>
        <br /><br />

        Select Folder:<%: Html.ActionLink("create new folder", "ManageFolder", "Folder")%><div>&nbsp;</div>
        <table>
        <thead>
        <th></th>
        <th>ID</th>
        <th>Folder Name</th>
        </thead>
        <tbody>
        <% if (((List<Folder>)this.ViewData["FolderList"]).Count == 0)
        { %>
            <tr>
            <td>--</td>
            <td>--No Folders--</td>
            <td>--</td>
            </tr>
        <% } %>
        <%else { %>
            <% foreach (Folder folder in ((List<Folder>)this.ViewData["FolderList"]))
                { %>
                <tr>
                <td><%= Html.RadioButton("SelectedFolder", folder.Id, true)%></td>
                <td><%= folder.Id %></td>
                <td><%= folder.Name %></td>
                </tr>
                <% } %>
        <% } %>
        </tbody>
        </table>

        Select Lender:<div>&nbsp;</div>
        <table>
        <thead>
        <th></th>
        <th>ID</th>
        <th>Lender Name</th>
        </thead>
        <tbody>
        <% if (((List<Lender>)this.ViewData["LenderList"]).Count == 0)
        { %>
            <tr>
            <td>--</td>
            <td>--No Lenders--</td>
            <td>--</td>
            </tr>
        <% } %>
        <%else { %>
            <% foreach (Lender lender in ((List<Lender>)this.ViewData["LenderList"]))
                { %>
                <tr>
                <td><%= Html.RadioButton("SelectedLender", lender.Id, true)%></td>
                <td><%= lender.Id %></td>
                <td><%= lender.Name %></td>
                </tr>
                <% } %>
        <% } %>
        </tbody>
        </table>

        <br /><br />
        Select WorkFlow Steps:<br /><div>&nbsp;</div>
        <table>
        <thead>
        <th></th>
        <th>Name</th>
        <th>Description</th>
        </thead>
        <tbody>
            <tr>
            <td><%= Html.CheckBox("scanning") %></td>
            <td>Scanning</td>
            <td>some step description</td>
            </tr>
            <tr>
            <td><%= Html.CheckBox("verifying") %></td>
            <td>Verifying</td>
            <td>some step description</td>
            </tr>
            <tr>
            <td><%= Html.CheckBox("creditcheck") %></td>
            <td>Credit Check</td>
            <td>some step description</td>
            </tr>
            <tr>
            <td><%= Html.CheckBox("stepfour") %></td>
            <td>stepfour</td>
            <td>some step description</td>
            </tr>
        </tbody>
        </table>
        <br /><div>&nbsp;</div>
        <input type="submit" value="Create WorkFlow" />
    <% } %>

    
</asp:Content>
