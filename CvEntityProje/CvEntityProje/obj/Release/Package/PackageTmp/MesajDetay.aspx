<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MesajDetay.aspx.cs" Inherits="CvEntityProje.MesajDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h4>MESAJ DETAY SAYFASI</h4>
    <br />  

    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="AdSoyad" Enabled="false"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Mail" Enabled="false"></asp:TextBox>
   <br />
    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Konu" Enabled="false"></asp:TextBox>
    <br />
     <asp:TextBox ID="TextBox4" TextMode="MultiLine" Height="100" runat="server" CssClass="form-control"  placeholder="Mesaj" Enabled="false"></asp:TextBox>
   <br />
    
   
   

</asp:Content>
