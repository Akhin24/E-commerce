<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Productedit.aspx.cs" Inherits="twolayer2.Productedit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 271px;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 144px;
        }
        .auto-style4 {
            width: 144px;
            height: 26px;
        }
        .auto-style5 {
            width: 271px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 325px;
        }
        .auto-style8 {
            height: 26px;
            width: 325px;
        }
        .auto-style9 {
            width: 220px;
        }
        .auto-style10 {
            width: 220px;
            height: 26px;
        }
        .auto-style12 {
            width: 144px;
            height: 9px;
        }
        .auto-style13 {
            width: 220px;
            height: 9px;
        }
        .auto-style14 {
            width: 271px;
            height: 9px;
        }
        .auto-style15 {
            width: 325px;
            height: 9px;
        }
        .auto-style16 {
            height: 9px;
        }
        .auto-style17 {
            width: 144px;
            height: 42px;
        }
        .auto-style18 {
            width: 220px;
            height: 42px;
        }
        .auto-style19 {
            width: 271px;
            height: 42px;
        }
        .auto-style20 {
            width: 325px;
            height: 42px;
        }
        .auto-style21 {
            height: 42px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td></td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style10"></td>
            <td class="auto-style5"></td>
            <td class="auto-style8"></td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">
                <asp:GridView ID="GridView1" runat="server" Width="377px" AllowPaging="True" AutoGenerateColumns="False" CssClass="auto-style2" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" PageSize="5">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="pid" HeaderText="PRODUCT ID" />
                        <asp:BoundField DataField="cat_id" HeaderText="CATEGORY ID" />
                        <asp:BoundField DataField="pname" HeaderText="PRODUCT NAME" />
                        <asp:BoundField DataField="pprize" HeaderText="PRODUCT PRICE" />
                        <asp:ImageField DataImageUrlField="pimage" HeaderText="PRODUCT IMAGE">
                        </asp:ImageField>
                        <asp:BoundField DataField="pdescription" HeaderText="PRODUCT DESCRIPTION" />
                        <asp:BoundField DataField="stock" HeaderText="STOCK" />
                        <asp:BoundField DataField="status" HeaderText="STATUS" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Font-Underline="True" ForeColor="Blue" Text="EDIT PRODUCT"></asp:Label>
            </td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style13"></td>
            <td class="auto-style14">Product name</td>
            <td class="auto-style15">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style16"></td>
            <td class="auto-style16"></td>
            <td class="auto-style16"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">Product prise</td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">Product Image</td>
            <td class="auto-style7">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17"></td>
            <td class="auto-style18"></td>
            <td class="auto-style19">Product Description</td>
            <td class="auto-style20">
                <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">stock</td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">
                <asp:Button ID="Button1" runat="server" Text="UPDATE" OnClick="Button1_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
