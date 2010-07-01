<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Open WorkFlow
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<%= Html.MvcSiteMap().SiteMapPath() %> 

    <h2>Selected WorkFlow: <%=((WorkFlow)ViewData["SelectedWorkFlow"]).Name %></h2>

    <% using (Html.BeginForm("HandleWFStep", "WorkFlow", new { Id = ((WorkFlow)ViewData["SelectedWorkFlow"]).Id })) %>
    <% { %>
            <div>&nbsp;</div>
            WorkFlow Steps:
            <table>
            <thead>
            <th></th>
            <th>State</th>
            <th>Name</th>
            <th>Is Automatic Step</th>
            <th>Automatic Processing Time (for auto steps only)</th>
            </thead>
            <tbody>
            <% if (((WorkFlow)this.ViewData["SelectedWorkFlow"]).WorkFlowSteps.Count == 0)
            { %>
                <tr>
                <td>--</td>
                <td>--no steps--</td>
                <td>--</td>
                </tr>
                </tbody>
                </table>
            <% } %>
            <%else
                {
                    bool identifiedCurrent = false;
                    bool isCurrentAutoStep = false;%>
                <% foreach (WorkFlowStep step in ((WorkFlow)ViewData["SelectedWorkFlow"]).WorkFlowSteps)
                { %>
                    <tr>
                    <% if(step.IsComplete)
                    { %>
                        <td> </td>
                        <td>Complete</td>
                    <% }else
                       {
                           if (!identifiedCurrent)
                           {
                               identifiedCurrent = true;
                               if( step.IsAuto) isCurrentAutoStep = true;%>
                               <td><%= Html.RadioButton("SelectedWorkFlowStep", step.Id, true)%></td>
                               <td>InComplete</td>
                           <%}
                           else
                           {%>
                            <td> </td>
                            <td>InComplete</td>
                           <%}%>
                    <% } %>
                    <td><%= step.Name %></td>
                    <td><%= step.IsAuto %></td>
                    <td><%= step.AutoExecTime %></td>
                    </tr>
                <% } %>
                </tbody>
                </table>
                <%if(!isCurrentAutoStep){ %>
                <input type="submit" value="Complete Step" />
                <%} %>
             <% } %>
            
    <% } %>

    <% using (Html.BeginForm("HandleWFFolder", "WorkFlow", new { Id = ((WorkFlow)ViewData["SelectedWorkFlow"]).Id }))%>
    <% { %>
            <div>&nbsp;</div>
            WorkFlow Folder:
            <table>
            <thead>
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
