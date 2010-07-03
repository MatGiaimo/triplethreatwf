<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Workflow Builder
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <%= Html.MvcSiteMap().SiteMapPath() %> 

    <h2>Workflows</h2>   

    <%: Html.ActionLink("Create New WorkFlow", "NewWorkFlow", "Workflow")%>
    <% using(Html.BeginForm("HandleRadio", "WorkFlow")) %>
    <% { %>
            <div>&nbsp;</div>
            In Progress WorkFlows:
            <table>
            <thead>
            <th></th>
            <th>ID</th>
            <th>Name</th>
            <th>Lender</th>
            <th>Percent Complete</th>
            </thead>
            <tbody>
            <% foreach (WorkFlow workflow in (List<WorkFlow>)ViewData["WorkFlows"])
               { %>

               <% int numSteps = 0;
                  int numComplete = 0;
                  foreach (WorkFlowStep s in workflow.WorkFlowSteps)
                  {
                      ++numSteps;
                      if (s.IsComplete) ++numComplete;
                   %>

                <% }
                  if (numSteps != 0 && numSteps != numComplete)
                  {%>
                    <tr>
                    <td><%= Html.RadioButton("SelectedWorkFlow", workflow.Id, true)%></td>
                    <td><%= workflow.Id%></td>
                    <td><%= workflow.Name%></td>
                    <td><%= workflow.Lender.Name%></td>
                    <td><%=((100 * numComplete) / (numSteps)).ToString() + "%"%></td>
                    </tr>
                   <%}
               }%>

            </tbody>
            </table>
            <input type="submit" value="Open" />
    <% } %>

    <% using(Html.BeginForm("HandleRadio", "WorkFlow")) %>
    <% { %>
            <div>&nbsp;</div>
            <div>&nbsp;</div>
            Completed WorkFlows:
            <table>
            <thead>
            <th></th>
            <th>ID</th>
            <th>Name</th>
            <th>Lender</th>
            <th>Percent Complete</th>
            </thead>
            <tbody>
            <% foreach (WorkFlow workflow in (List<WorkFlow>)ViewData["WorkFlows"])
               { %>

               <% int numSteps = 0;
                  int numComplete = 0;
                  foreach (WorkFlowStep s in workflow.WorkFlowSteps)
                  {
                      ++numSteps;
                      if (s.IsComplete) ++numComplete;
                   %>

                <% }
                  if (numSteps == 0 || numSteps == numComplete)
                  {%>
                    <tr>
                    <td><%= Html.RadioButton("SelectedWorkFlow", workflow.Id, true)%></td>
                    <td><%= workflow.Id%></td>
                    <td><%= workflow.Name%></td>
                    <td><%= workflow.Lender.Name%></td>
                    <td>100%</td>
                    </tr>
                   <%}
               }%>

            </tbody>
            </table>
            <input type="submit" value="View" />
    <% } %>

</asp:Content>
