<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="BlogSite._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="BlogId" DataSourceID="SqlDataSource1" AllowSorting="True">
    <Columns>
        <asp:BoundField DataField="BlogId" HeaderText="BlogId" InsertVisible="False" ReadOnly="True" SortExpression="BlogId" Visible="False" />
        <asp:BoundField DataField="BlogTitle" HeaderText="BlogTitle" SortExpression="BlogTitle" />
        <asp:BoundField DataField="BlogDescription" HeaderText="BlogDescription" SortExpression="BlogDescription" />
        <asp:BoundField DataField="BlogType" HeaderText="BlogType" SortExpression="BlogType" />
        <asp:ButtonField Text="View" />
    </Columns>
    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
    <RowStyle BackColor="White" ForeColor="#003399" />
    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
    <SortedAscendingCellStyle BackColor="#EDF6F6" />
    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
    <SortedDescendingCellStyle BackColor="#D6DFDF" />
    <SortedDescendingHeaderStyle BackColor="#002876" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [BlogId], [BlogTitle], [BlogDescription], [BlogType] FROM [BlogAttribute]"></asp:SqlDataSource>
&nbsp;
</asp:Content>
