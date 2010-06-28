<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<TripleThreatWF.Models.SearchModel>" %>
<%@ Import Namespace="TripleThreat.Framework.Core" %>
<%@ Import Namespace="System.Data.Entity" %>

<h3>Open Items:</h3>

<% using (Html.BeginForm("OpenItems", "Search"))
       { %>
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
       }%>