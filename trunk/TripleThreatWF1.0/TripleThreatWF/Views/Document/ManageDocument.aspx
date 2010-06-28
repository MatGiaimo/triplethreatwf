<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<TripleThreatWF.Models.DocumentModel>" %>
<%@ Import Namespace="TripleThreat.Framework.Core" %>
<%@ Import Namespace="System.Data.Entity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ManageDoc
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Manage Document</h2>

    <% using (Html.BeginForm("Save", "Document",FormMethod.Post, 
                  new {enctype = "multipart/form-data"}))
       {%>
    <div style="display:inline">Name:</div><div style="display:inline"><%: Html.TextBoxFor(m => m.Name) %></div>
    <div style="display:inline">Customer:</div><div style="display:inline"><%: Html.DropDownListFor( m => m.Customer.Id, new SelectList(Model.Customers,"Id","FullName",Model.Customer),"-- Select Customer --") %></div>
    <div style="display:inline">Folder:</div><div style="display:inline"><%: Html.DropDownListFor( m => m.Folder.Id, new SelectList(Model.Folders,"Id","Name",Model.Folder),"-- Select Folder --") %></div>
    <%--<div style="display:inline">State:</div><div style="display:inline"><select><option id="on hold">On Hold</option></select></div>--%>
    <div>
    <fieldset><legend>Image:</legend>
    <%--<a href="../../img/loandocpg2sm.jpg">Direct Link</a>--%>
    <% if (this.Model.Id > 0) { %>
    <div style="display:inline"><img src="/Document/GetDocumentImage/<%= this.Model.Id %>" alt="<%= this.Model.ImageName %>"/></div>
    <%} %>
    <div style="display:inline">Upload: <input type="file" id="Image" name="Image" /></div>
    </fieldset>
    <input type="submit" value="Save" />
    <%} %>
    </div>


</asp:Content>
