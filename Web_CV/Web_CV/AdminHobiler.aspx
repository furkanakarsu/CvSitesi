<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHobiler.aspx.cs" Inherits="Web_CV.AdminHobiler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

       <form id="Form" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>Hobiler</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th><%# Eval("ID") %></th>
                        <td><%# Eval("Hobi") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "AdminHobiSil.Aspx?ID="+ Eval("ID") %>' ID="btnSil" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "AdminHobiGuncelle.aspx?ID=" + Eval("ID") %>' ID="btnGuncelle" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
                    </tr>
            
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
         <asp:HyperLink NavigateUrl="~/AdminHobiEkle.aspx" ID="HyperLink1" runat="server" CssClass="btn btn-info">Hobi Ekle</asp:HyperLink>
         </form>

</asp:Content>
