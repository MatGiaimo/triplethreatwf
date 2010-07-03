<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	OpenDocument
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<%= Html.MvcSiteMap().SiteMapPath() %> 

    <h2>OpenDocument</h2>

     <% using (Html.BeginForm("Save", "Document",FormMethod.Post, 
                  new {enctype = "multipart/form-data"}))
       {%>
        
        <fieldset><legend>Image:</legend>
        <% if (this.Model.Id > 0) { %>
        <div><img src="/Document/GetDocumentImage/<%= this.Model.Id %>" alt="<%= this.Model.ImageName %>"/></div>
        <%} %>
        <div style="display:inline">Upload: <input type="file" id="Image" name="Image" /></div>
        </fieldset>
        <input type="submit" value="Save" />
    <%} %>

</asp:Content>
