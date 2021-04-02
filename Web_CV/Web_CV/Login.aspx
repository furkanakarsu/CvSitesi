<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web_CV.Login" %>

<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

<!DOCTYPE html>
<html>
<head>
    <title>Login Page</title>
    <!--Made with love by Mutiullah Samim -->

    <!--Bootsrap 4 CDN-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

    <!--Fontawesome CDN-->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">

    <!--Custom styles-->
    <link href="LoginCSS.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <div class="d-flex justify-content-center h-100">
            <div class="card">
                <div class="card-header">
                    <h3>Oturum Aç</h3>
                    <div class="d-flex justify-content-end social_icon">
                        <span><i class="fab fa-instagram"></i></span>
                        <span><i class="fab fa-facebook-square"></i></span>
                        <span><i class="fab fa-youtube-square"></i></span>
                        <span><i class="fab fa-twitter-square"></i></span>
                    </div>
                </div>
                <div class="card-body">
                    <form runat="server">
                        <div class="input-group form-group">
                            <div class="input-group-prepend">
                                <span class="input-group-text"><i class="fas fa-user"></i></span>
                            </div>
                            <%--<input type="text" class="form-control" placeholder="kullanıcı adı">--%>
                            <asp:TextBox ID="txtKullaniciAdi" runat="server" CssClass="form-control" placeholder="Kullanıcı Adınız"></asp:TextBox>

                        </div>
                        <div class="input-group form-group">
                            <div class="input-group-prepend">
                                <span class="input-group-text"><i class="fas fa-key"></i></span>
                            </div>
                            <%--<input type="password" class="form-control" placeholder="şifre">--%>
                            <asp:TextBox ID="txtSifre" TextMode="Password" MinLength="4" runat="server" CssClass="form-control" placeholder="Şifreniz"></asp:TextBox>

                        </div>
                        <div class="row align-items-center remember">
                            <input type="checkbox">Beni Hatırla
                        </div>
                        <div class="form-group">
                           <%-- <input type="submit" value="Login" class="btn float-right login_btn">--%>
                            <asp:Button ID="btnGiris" runat="server" Text="Giriş Yap" CssClass="btn float-right login_btn" OnClick="btnGiris_Click" />
                        </div>
                    </form>
                </div>
                <div class="card-footer">
                    <div class="d-flex justify-content-center links">
                        Hesabın var mı? | <a href="#">Kayıt Ol</a>
                    </div>
                    <div class="d-flex justify-content-center">
                        <a href="#">Şifremi unuttum?</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
