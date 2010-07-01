<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<TripleThreatWF.Models.CustomerModel>" %>
<%@ Import Namespace="TripleThreat.Framework.Core" %>
<%@ Import Namespace="System.Data.Entity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ManageGroupID
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>ManageGroupID</h2>
        <% using (Html.BeginForm("SaveGroupID","Customer")) { %>
        <div>
            <fieldset>
                <legend>GroupID Information</legend>
                
                <div class="editor-label">
                    <%: Html.LabelFor(cm => cm.GroupName) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(cm => cm.GroupName) %>
                    <%: Html.ValidationMessageFor(cm => cm.GroupName) %>
                </div>
                
                <div style="display:inline">WokFlow:</div><div style="display:inline"><%: Html.DropDownListFor(m => m.WorkFlow.Id, new SelectList(Model.WorkFlows, "Id", "Name", Model.WorkFlow), "-- Select Group --")%></div> 
                  
                <p>
                    <input type="submit" value="Save" />
                </p>
            </fieldset>
        </div>
    <% } %>
</asp:Content>
