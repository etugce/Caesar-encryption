<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN">

<html>
<head runat="server">
<link rel="Stylesheet" href="Imparator.css" />
<title>Sezar</title>
    <style type="text/css">
        .kutu {}
        #form1 {
            height: 930px;
            width: 893px;
            margin-right: 0px;
        }
        .auto-style1 {
            width: 176px;
        }
        .auto-style3 {
            width: 176px;
            height: 42px;
        }
        .auto-style5 {
            height: 42px;
        }
        .auto-style8 {
            height: 40px;
        }
        .auto-style11 {
            width: 176px;
            height: 40px;
        }
        .auto-style12 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
<asp:Label ID="Label_kullanici" runat="server" Visible="False"></asp:Label>
    <br />
    <br />
    <table style="width: 100%; height: 262px;">
        <tr>
            <td colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Enabled="False" Font-Size="Small" Text="Metin:" Font-Bold="False"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="T_metin" runat="server" Height="97px" TextMode="MultiLine" Width="688px" OnTextChanged="T_metin_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" Text="Sayı" Font-Bold="False" Font-Size="Small"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="T_oteleme_sayisi" runat="server" OnTextChanged="T_oteleme_sayisi_TextChanged" AutoPostBack="True"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:Button ID="B_sifrele" runat="server" CssClass="auto-style12" Text="Hesapla" OnClick="B_sifrele_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8" colspan="3"></td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label3" runat="server" Font-Size="Small" Text="Şifreli Metin" Font-Bold="False"></asp:Label>
            </td>
            <td class="auto-style8" colspan="2">
                <asp:TextBox ID="T_sonuc_metin" runat="server" Height="96px" TextMode="MultiLine" Width="692px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8" colspan="3"></td>
        </tr>
    </table>
</form>
</body>
</html>
