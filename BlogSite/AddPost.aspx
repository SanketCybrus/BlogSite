<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="AddPost.aspx.cs" Inherits="BlogSite.AddPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4 style="font-size: medium"><span style="font-weight: normal"><strong>Create your post:</strong></span></h4>
<table style="width: 48%; height: 257px" class="table table-active table-responsive">
    <tr>
        <td style="width: 4px">Title</td>
        <td>
            <asp:TextBox ID="txtBoxTitle" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 4px">Description</td>
        <td>
            <asp:TextBox ID="txtBoxDescription" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 4px">Content</td>
        <td>
            <asp:TextBox ID="txtContent" runat="server" Height="121px" TextMode="MultiLine" Width="254px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 4px">Type</td>
        <td>
            <asp:TextBox ID="txtBoxType" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 4px">Category</td>
        <td>
            <asp:DropDownList ID="DDLCategory" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="btnPost" runat="server" Text="Post" Width="58px" OnClick="btnPost_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblStatus" runat="server"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
