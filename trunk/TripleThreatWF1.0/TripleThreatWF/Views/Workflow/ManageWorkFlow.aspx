<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ManageWorkflow
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>ManageWorkflow</h2>    
    <p>
       <%: Html.ActionLink("New WorkFlow", "NewWorkFlow", "Workflow")%>
    </p>
     <p>
       <%: Html.ActionLink("WorkFlow Step", "WorkFlowStep", "Workflow")%>
    </p>

</asp:Content>
