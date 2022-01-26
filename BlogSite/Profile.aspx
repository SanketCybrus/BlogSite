<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="BlogSite.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" runat="server" class="table table-active table-responsive table-hover" OnDataBound="GridView1_DataBound" OnRowDataBound="GridView1_RowDataBound">

    </asp:GridView>

</asp:Content>
