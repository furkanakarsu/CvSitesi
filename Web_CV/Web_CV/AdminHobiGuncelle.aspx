﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHobiGuncelle.aspx.cs" Inherits="Web_CV.AdminHobiGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

      <form id="Form" runat="server">
        <div class="form-group">
            <div>
                <asp:Label ID="Label" runat="server" Text="ID:"></asp:Label>
                <asp:TextBox ID="txtID" runat="server" CssClass="form-control"  ></asp:TextBox>
            </div>
            <br />
             <div>
                <asp:Label ID="Label1" runat="server" Text="Hobi:"></asp:Label>
                <asp:TextBox ID="txtHobi" runat="server" MinLength="1" CssClass="form-control"  ></asp:TextBox>

                 
            </div>
            <br />
             <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Güncelle" OnClick="Button1_Click"  />
        </div>

    </form>

</asp:Content>
