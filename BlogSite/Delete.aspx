<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="BlogSite.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" class="table table-responsive table-info" runat="server" AutoGenerateColumns="False" DataKeyNames="BlogId" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="BlogTitle" HeaderText="BlogTitle" SortExpression="BlogTitle" />
            <asp:BoundField DataField="BlogContent" HeaderText="BlogContent" SortExpression="BlogContent" />
            <asp:BoundField DataField="BlogDescription" HeaderText="BlogDescription" SortExpression="BlogDescription" />
            <asp:BoundField DataField="BlogType" HeaderText="BlogType" SortExpression="BlogType" />
            <asp:BoundField DataField="BlogId" HeaderText="BlogId" InsertVisible="False" ReadOnly="True" SortExpression="BlogId" Visible="False" />
        </Columns>
        <EmptyDataRowStyle VerticalAlign="Middle" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [BlogTitle], [BlogContent], [BlogDescription], [BlogType], [BlogId] FROM [BlogAttribute] WHERE ([BlogId] = @BlogId)">
        <SelectParameters>
            <asp:QueryStringParameter Name="BlogId" QueryStringField="id" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <asp:Button ID="btnDelete" CssClass="btn btn-danger" runat="server" Text="Delete" OnClick="btnDelete_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="txtMsg" runat="server"></asp:Label>
</asp:Content>
