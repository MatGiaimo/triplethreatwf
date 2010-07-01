<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<TripleThreatWF.Models.CustomerModel>" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Customers
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<%= Html.MvcSiteMap().SiteMapPath() %> 

    <h2>Customers</h2>
<%--    <div style="display:inline"><a href="#">Add Customer</a></div>--%>
     <p>
       <%: Html.ActionLink("Add Customer", "AddCustomer", "Customer")%>
    </p>
    
    <p>
       <%: Html.ActionLink("AddGroup", "ManageGroupID", "Customer")%>
    </p>
    <table>
    

    </table>
    <div>&nbsp;</div>
    <table>
    <thead>
    <th>SSN</th>
    <th>FirstName</th>
    <th>LastName</th>
    <th>Address</th>
    <th>Lender</th>
    </thead>
    <tbody>
    <% foreach (Customer customer in this.Model.Customers)
       { %>
       <tr>
       <td><%= customer.SSN %></td>
       <td><%= customer.FirstName %></td>
       <td><%= customer.LastName %></td>
       <td><%= string.Format("{0} {1}, {2} {3}",customer.Address.Street,customer.Address.City,customer.Address.State, customer.Address.Zip)%></td>
       <td><%= string.Format("{0}", customer.Lender.Name) %></td>
      
       </tr>
       <% } %>

    </tbody>
    </table>

</asp:Content>
