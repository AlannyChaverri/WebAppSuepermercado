<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormLogin.aspx.cs" Inherits="WebAppSupermercadoPatitosSA.WebFormLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="CSS/StyleLogin.css" rel="stylesheet" />

    </head>
    <body>
        <div class="wrapper fadeInDown">
            <div id="formContent">
    <!-- Tabs Titles -->

    <!-- Icon -->
    <div class="fadeIn first">
      <img src="IMG/log_login.png" id="icon" alt="User Icon" />
    </div>

    <!-- Login Form -->
        <form id="form1" runat="server">

            <div class="col text-center">

                <div class="form-group">
                    <asp:TextBox ID="txtusuario" class="form-control" placeholder="Ingrese su usuario" runat="server" ></asp:TextBox>
                    <asp:TextBox ID="txtclave" class="form-control" placeholder="Ingrese su contraseña" type="password" runat="server" ></asp:TextBox>
                </div>
                <asp:Button ID="btniniciar" class="btn btn-primary"  runat="server" Text="Iniciar Sesion" OnClick="btniniciar_Click" />
            
            </div>
        </form>

             <!-- Remind Passowrd -->
            <div id="formFooter">
            <asp:Label ID="LabelMsgbox1" runat="server"></asp:Label>
            </div>

    </div>
</div>

    
    </body>
    </html>
