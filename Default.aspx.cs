using System;
using System.Threading;
using System.Globalization;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Drawing;
using System.Net.Mail;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Net;
using System.Design;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text;
using System.Web.SessionState;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Net.Sockets;
using System.Collections.Generic;
using Telerik.Web.UI;
using OfficeOpenXml;
using System.Drawing.Text;
using System.Drawing.Design;
using BarcodeLib.Barcode;
using DataMatrix.net;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using KeepAutomation.Barcode;
using KeepAutomation.Barcode.Bean;
using KeepAutomation.Barcode.Web;
using System.Drawing.Printing;
public partial class _Default : System.Web.UI.Page
{
    Test_DataClassesDataContext vt_test = new Test_DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Buffer = true;
        Response.CacheControl = "no-cache";
        if (Label_kullanici.Text == "")
        {
            Label_kullanici.Text = "Mirror";
            Label_kullanici.Visible = false;
        }
    }
    string metin = "";
    int oteleme_sayisi;
    string sifreli_metin;
    string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
    void sifrele()
    {
        metin = T_metin.Text.ToLower();
        oteleme_sayisi = Convert.ToInt32(T_oteleme_sayisi.Text);
        if (oteleme_sayisi > 0)
        {
            for (int i = 0; i < metin.Length; i++)
            {
                bool sonuc = false;
                for (int j = 0; j < alfabe.Length; j++)
                {
                    if (metin[i] == alfabe[j])
                    {
                        sonuc = true;
                        char karakter = alfabe[(j + oteleme_sayisi) % 29];
                        sifreli_metin += karakter;
                    }
                }
                if (!sonuc)
                {
                    sifreli_metin += metin[i];
                }
            }
        }
        T_sonuc_metin.Text = "";
        T_sonuc_metin.Text = sifreli_metin;
    }
    protected void T_metin_TextChanged(object sender, EventArgs e)
    {
    }
    protected void T_oteleme_sayisi_TextChanged(object sender, EventArgs e)
    {
        try
        {
            int kontrol = Convert.ToInt32(T_oteleme_sayisi.Text);
        }
        catch
        {
            T_oteleme_sayisi.Text = "0";
        }
    }
    protected void B_sifrele_Click(object sender, EventArgs e)
    {
        sifrele();
    }
}