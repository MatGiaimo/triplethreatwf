<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<TripleThreatWF.Models.SearchModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Search Documents
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<script type="text/javascript">
    $(function () {
        $("#DateAdded").datepicker();
    });
	</script>

    <h2>Search Documents</h2>

    <% using(Html.BeginForm("SearchDocuments","Search")) { %>
    <div>Document Name:</div><div style="display:inline"><%: Html.TextBoxFor(m => m.Name) %></div>
    <div>Date Added:</div><div style="display:inline"><%: Html.TextBoxFor(m => m.DateAdded) %></div>
    <div>Customer Name:</div><div style="display:inline"><%: Html.TextBoxFor(m => m.CustName) %></div>
    <div>State:</div><div style="display:inline"><%: Html.TextBoxFor(m => m.State) %></div>
    <div><input type="submit" value="Search" /></div>
    <%} %>
    
    <h3>Search Results:</h3>

    <%if (this.Model.SearchResults.Count > 0)
      { %>
    <table>
    <thead>
    <th>Customer Name</th>
    <th>Document Name</th>
    <th>State</th>
    <th>Assigned Date</th>
    <th>Assigned By</th>
    </thead>
    <tbody>
    <%foreach (Document doc in this.Model.SearchResults)
      { %>
      <tr style="cursor:pointer" onclick="location.href = '/Document/ManageDocument/<%= doc.Id %>';">
      <td><%= doc.Customer.FullName%></td>
      <td><%= doc.Name%></td>
      <td><%= doc.State%></td>
      <td><%= doc.CreatedDate.ToShortDateString()%></td>
      <td><%= doc.AddedBy%></td>
      </tr>
    <%} %>
    </tbody>
    </table>
    <%}
      else
      {%>
      <div>No documents found.</div>
      <%} %>

</asp:Content>
