<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebLogin.aspx.vb" Inherits="Sistema.WebLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!-- Bootstrap 3.3.7 -->
  <link rel="stylesheet" href="../../bower_components/bootstrap/dist/css/bootstrap.min.css">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="../../bower_components/font-awesome/css/font-awesome.min.css">
</head>
<body>

    <div class="container">
        <form id="form1" runat="server" class="form-signin">
        <h2 class="form-signin-heading">Please sign in</h2>
        <label for="inputEmail" class="sr-only">Email address</label>
        <asp:TextBox ID="TextBox1" CssClass="form-control"  runat="server" placeholder="Email address"></asp:TextBox>

        <asp:TextBox ID="TextBox2"  CssClass="form-control"  runat="server" placeholder="password" TextMode="Password"></asp:TextBox>
            
        <asp:Button CssClass="btn-primary" ID="Button1" runat="server" Text="Ingresar" />
        
           
      </form>
    </div> 
    

    
<!-- jQuery 3 -->
<script src="../../bower_components/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap 3.3.7 -->
<script src="../../bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
</body>
</html>
