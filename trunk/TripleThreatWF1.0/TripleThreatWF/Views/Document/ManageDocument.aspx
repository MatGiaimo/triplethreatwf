<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ManageDoc
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Manage Document</h2>

    <div style="display:inline">Name:</div><div style="display:inline"><%= Html.TextBox("DocName","Loan Application") %></div>
    <div style="display:inline">Customer:</div><div style="display:inline"><select><option id="1234">Robert Vila</option></select></div>
    <div style="display:inline">State:</div><div style="display:inline"><select><option id="on hold">On Hold</option></select></div>
    <div>
    <fieldset><legend>Image:</legend>
    <a href="../../img/loandocpg2sm.jpg">Direct Link</a>
    <img src="../../img/loandocpg2sm.jpg" alt="loan doc pg 2"/>
    </fieldset>
    </div>


</asp:Content>
