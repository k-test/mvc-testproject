<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<List<System.Diagnostics.Process>>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">

    <h2>List</h2>

</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>List</h2>
        <ul>
    
    <% foreach (var process in this.Model) { %>
    
        <li><%= Html.ActionLink(process.ProcessName,"Details", new {id = process.Id}) %></li>     
               
    <% } %>
    </ul>
</asp:Content>

