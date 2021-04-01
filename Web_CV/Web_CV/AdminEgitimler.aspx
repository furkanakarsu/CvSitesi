<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimler.aspx.cs" Inherits="Web_CV.AdminEgitimler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>Başlık</th>
            <th>Alt Başlık</th>
            <th>Açıklama</th>
            <th>Genel Not</th>
            <th>Tarih</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th><%# Eval("ID") %></th>
                        <td><%# Eval("Baslik") %></td>
                        <td><%# Eval("AltBaslik") %></td>
                        <td><%# Eval("Aciklama") %></td>
                        <td><%# Eval("GenelNot") %></td>
                        <td><%# Eval("Tarih") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "AdminEgitimSil.Aspx?ID="+ Eval("ID") %>' ID="btnSil" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "AdminEgitimGuncelle.aspx?ID=" + Eval("ID") %>' ID="btnGuncelle" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
                    </tr>
            
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
         <asp:HyperLink NavigateUrl="~/AdminEgitimEkle.aspx" ID="HyperLink1" runat="server" CssClass="btn btn-info">Eğitim Ekle</asp:HyperLink>
         </form>

</asp:Content>
