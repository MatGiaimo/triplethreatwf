<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<TripleThreatWF.Models.CustomerModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	AddCustomer
</asp:Content>

<asp:Content ID="registerContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Create a New Customer</h2>
    <p>
        Use the form below to create a new customer. 
    </p>

    <% using (Html.BeginForm("SaveCustomer","Customer")) { %>
        <%--<%: Html.ValidationSummary(true, "Account creation was unsuccessful. Please correct the errors and try again.") %>--%>
        <div>
            <fieldset>
                <legend>Customer Information</legend>
                
                <div class="editor-label">
                    <%: Html.LabelFor(cm => cm.FirstName) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(cm => cm.FirstName) %>
                    <%: Html.ValidationMessageFor(cm => cm.FirstName) %>
                </div>
                <div class="editor-label">
                    <%: Html.LabelFor(cm => cm.LastName) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(cm => cm.LastName) %>
                    <%: Html.ValidationMessageFor(cm => cm.LastName) %>
                </div>
                <div class="editor-label">
                    <%: Html.LabelFor(cm => cm.SSN) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(cm => cm.SSN) %>
                    <%: Html.ValidationMessageFor(cm => cm.SSN) %>
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
                <div style="display:inline">LenderID:</div><div style="display:inline"><%: Html.DropDownListFor(m => m.Lender.Id, new SelectList(Model.Lenders,"Id","Name", Model.Lender),"-- Select Lender --")%></div> 
                <div style="display:inline">GroupID:</div><div style="display:inline"><%: Html.DropDownListFor(m => m.CustomerGroup.Id, new SelectList(Model.CustomerGroups,"Id","Name", Model.CustomerGroup),"-- Select Group --")%></div> 
    
                <p>
                    <input type="submit" value="Save" />
                </p>
            </fieldset>
        </div>
    <% } %>
</asp:Content>