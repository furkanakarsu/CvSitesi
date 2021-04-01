<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminYetenekler.aspx.cs" Inherits="Web_CV.AdminYetenekler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form id="Form" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>Yetenek</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th><%# Eval("ID") %></th>
                        <td><%# Eval("Yetenek") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "AdminYetenekSil.Aspx?ID="+ Eval("ID") %>' ID="btnSil" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "AdminYetenekGuncelle.aspx?ID=" + Eval("ID") %>' ID="btnGuncelle" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
                    </tr>
            
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
         <asp:HyperLink NavigateUrl="~/AdminYetenekEkle.aspx" ID="HyperLink1" runat="server" CssClass="btn btn-info">Yetenek Ekle</asp:HyperLink>
         </form>

</asp:Content>
