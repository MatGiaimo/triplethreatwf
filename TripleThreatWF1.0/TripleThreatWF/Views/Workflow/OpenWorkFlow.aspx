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

    <p>
    Selected WorkFlow: <%=((WorkFlow)ViewData["SelectedWorkFlow"]).Name %>
    </p>

    <% using (Html.BeginForm("HandleWFStep", "WorkFlow")) %>
    <% { %>
            <div>&nbsp;</div>
            WorkFlow Steps:
            <table>
            <thead>
            <th></th>
            <th>ID</th>
            <th>Name</th>
            </thead>
            <tbody>
            <% foreach (WorkFlowStep step in ((WorkFlow)ViewData["SelectedWorkFlow"]).WorkFlowSteps)
               { %>
               <tr>
               <td><%= Html.RadioButton("SelectedWorkFlowStep", step.Id, false)%></td>
               <td><%= step.Id %></td>
               <td><%= step.Name %></td>
               </tr>
               <% } %>
            </tbody>
            </table>
            <input type="submit" value="Submit" />
    <% } %>

    <% using (Html.BeginForm("HandleWFFolder", "WorkFlow", new { Id = ((WorkFlow)ViewData["SelectedWorkFlow"]).Id }))%>
    <% { %>
            <div>&nbsp;</div>
            WorkFlow Folder:
            <table>
            <thead>
            <th></th>
            <th>ID</th>
            <th>Name</th>
            </thead>
            <tbody>
            <tr>
            <td><%= ((WorkFlow)ViewData["SelectedWorkFlow"]).Folder.Id%></td>
            <td><%= ((WorkFlow)ViewData["SelectedWorkFlow"]).Folder.Name%></td>
            </tr>
            </tbody>
            </table>
            <input type="submit" value="Open Folder" />
    <% } %>

</asp:Content>
