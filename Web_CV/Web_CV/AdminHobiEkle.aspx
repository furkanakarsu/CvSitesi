<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHobiEkle.aspx.cs" Inherits="Web_CV.AdminHobiEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form" runat="server">
        <div class="form-group">
          
            <div>
                <asp:Label ID="Label1" runat="server" Text="Hobi:"></asp:Label>
                <asp:TextBox ID="txtHobi" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
          
            <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Kaydet" OnClick="Button1_Click" />
        </div>
    </form>

</asp:Content>
