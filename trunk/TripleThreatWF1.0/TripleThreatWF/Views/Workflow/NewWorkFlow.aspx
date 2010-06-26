<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	NewWorkFlow
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>NewWorkFlow</h2>
    <div>Folders:</div><div style="display:inline"><select><option id="unassigned">Unassigned</option></select></div>
    <div><input id="submit" type="button" value="submit" /></div>

</asp:Content>
