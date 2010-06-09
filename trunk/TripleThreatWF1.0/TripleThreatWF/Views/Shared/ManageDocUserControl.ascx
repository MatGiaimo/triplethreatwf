<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div style="display:inline">Name:</div><div style="display:inline"><%= Html.TextBox("DocName","Loan Application") %></div>
<div style="display:inline">Customer:</div><div style="display:inline"><select><option id="1234">Robert Vila</option></select></div>
<div style="display:inline">State:</div><div style="display:inline"><select><option id="on hold">On Hold</option></select></div>
<div>
<fieldset><legend>Image:</legend>
<a href="../../img/loandocpg2sm.jpg">Direct Link</a>
<img src="../../img/loandocpg2sm.jpg" alt="loan doc pg 2"/>
</fieldset>
</div>
