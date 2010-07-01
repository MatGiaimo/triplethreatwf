<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<TripleThreatWF.Models.LenderModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Lenders
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<%= Html.MvcSiteMap().SiteMapPath() %> 
    <h2>Lenders</h2>
    <% using (Html.BeginForm("SaveLender","Lender")) { %>
    <div>
            <fieldset>
                <legend>Lender Information</legend>
                
                <div class="editor-label">
                    <%: Html.LabelFor(cm => cm.LenderName) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(cm => cm.LenderName) %>
                    <%: Html.ValidationMessageFor(cm => cm.LenderName) %>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(cm => cm.Street) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(cm => cm.Street) %>
                    <%: Html.ValidationMessageFor(cm => cm.Street) %>
                </div>                
                <div class="editor-label">
                    <%: Html.LabelFor(cm => cm.City) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(cm => cm.City) %>
                    <%: Html.ValidationMessageFor(cm => cm.City) %>
                </div>
                <div class="editor-label">
                    <%: Html.LabelFor(cm => cm.State) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(cm => cm.State) %>
                    <%: Html.ValidationMessageFor(cm => cm.State) %>
                </div>
                <div class="editor-label">
                    <%: Html.LabelFor(cm => cm.ZipCode) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(cm => cm.ZipCode) %>
                    <%: Html.ValidationMessageFor(cm => cm.ZipCode) %>
                </div>
<%--                <div style="display:inline">LenderID:</div><div style="display:inline"><%: Html.DropDownListFor(m => m.Lender.Id, new SelectList(Model.Lenders,"Id","Name", Model.Lender),"")%></div> 
                <div style="display:inline">GroupID:</div><div style="display:inline"><%: Html.DropDownListFor(n => n.CustomerGroup.Id, new SelectList(Model.CustomerGroups,"Id","Name", Model.CustomerGroup),"")%></div> 
    --%>
                <p>
                    <input type="submit" value="Save" />
                </p>
            </fieldset>
        </div>
    <% } %>
</asp:Content>
