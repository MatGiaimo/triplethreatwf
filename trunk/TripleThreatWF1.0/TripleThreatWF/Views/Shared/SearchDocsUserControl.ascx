<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div>Document Name:</div><div style="display:inline"><%= Html.TextBox("DocName",string.Empty) %></div>
<div>Date Added:</div><div style="display:inline"><%= Html.TextBox("DateAdded",string.Empty) %></div>
<div>Customer Name:</div style="display:inline"><div><%= Html.TextBox("CustName",string.Empty) %></div>
<div>State:</div><div style="display:inline"><select><option id="unassigned">Unassigned</option></select></div>
<div><input id="submit" type="button" value="submit" /></div>
<h3>Search Results:</h3>
<table>
<thead>
<th>Customer Name</th>
<th>Document Name</th>
<th>State</th>
<th>Assigned Date</th>
<th>Assigned By</th>
</thead>
<tbody>
<tr>
<td>Eldon Tyrell</td>
<td>Loan Application</td>
<td>Assigned</td>
<td>6/3/2010 9:32AM</td>
<td>mgiaimo</td>
</tr>
<tr>
<td>Rick Deckard</td>
<td>Loan Application</td>
<td>Assigned</td>
<td>5/21/2010 4:16PM</td>
<td>mfotta</td>
</tr>
<tr>
<td>Roy Batty</td>
<td>Medical Application</td>
<td>On Hold</td>
<td>7/12/2100 3:33PM</td>
<td>epapp</td>
</tr>
</tbody>
</table>