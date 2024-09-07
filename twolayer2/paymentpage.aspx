<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="paymentpage.aspx.cs" Inherits="twolayer2.accountpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 195px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            width: 195px;
            height: 26px;
        }
    .auto-style4 {
            width: 240px;
        }
    .auto-style5 {
            width: 240px;
            height: 26px;
        }
        .auto-style6 {
            width: 208px;
        }
        .auto-style7 {
            height: 26px;
            width: 208px;
        }
        .auto-style8 {
            width: 8px;
        }
        .auto-style9 {
            height: 26px;
            width: 8px;
        }
        .auto-style10 {
            width: 151px;
        }
        .auto-style11 {
            height: 26px;
            width: 151px;
        }
        .auto-style12 {
            width: 235px;
        }
        .auto-style13 {
            height: 26px;
            width: 235px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style3">Account number</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox1" runat="server" BorderColor="Black" BorderStyle="Outset" CssClass="form-check-label"></asp:TextBox>
            </td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                <asp:Button ID="Button1" runat="server" Text="PAY NOW" OnClick="Button1_Click" Width="152px" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style5"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                <asp:Panel ID="Panel1" runat="server" Visible="False" Width="597px">
                    <table class="w-100">
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td class="auto-style6">&nbsp;</td>
                            <td class="auto-style12">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td class="auto-style6">
                                <asp:Label ID="Label2" runat="server" Text="PAYMENT SUCCESSFULL"></asp:Label>
                            </td>
                            <td class="auto-style12">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td class="auto-style6">
                                <asp:Label ID="Label3" runat="server" Text="Your Order Has been Placed"></asp:Label>
                            </td>
                            <td class="auto-style12">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style9"></td>
                            <td class="auto-style7"></td>
                            <td class="auto-style13"></td>
                            <td class="auto-style2"></td>
                            <td class="auto-style11"></td>
                        </tr>
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td class="auto-style6">FEEDBACK</td>
                            <td class="auto-style12">
                                <asp:TextBox ID="TextBox2" runat="server" Width="315px"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td class="auto-style6">&nbsp;</td>
                            <td class="auto-style12">
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Send " />
                            </td>
                            <td>&nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td class="auto-style6">&nbsp;</td>
                            <td class="auto-style12">
                                <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td class="auto-style6">&nbsp;</td>
                            <td class="auto-style12">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td class="auto-style6">&nbsp;</td>
                            <td class="auto-style12">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td class="auto-style6">&nbsp;</td>
                            <td class="auto-style12">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td class="auto-style6">&nbsp;</td>
                            <td class="auto-style12">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td class="auto-style6">
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Userhome.aspx">Back To Home Page</asp:HyperLink>
                            </td>
                            <td class="auto-style12">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td class="auto-style6">&nbsp;</td>
                            <td class="auto-style12">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
