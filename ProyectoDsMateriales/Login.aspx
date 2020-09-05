<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoDsMateriales.Login" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<title>Inicio de sesión</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">	
	<link rel="stylesheet" type="text/css" href="css/util.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
</head>
<body>
    <form id="form1" runat="server">
       
		<div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100">
				
					<span class="login100-form-title p-b-26">
						Inicio de sesión
					</span>
					<span class="login100-form-title p-b-48">
						<i class="zmdi zmdi-font"></i>
                        <img src="img/Fondo/Logo2.PNG" style="width:140px;" />
					</span>

					<div class="wrap-input100 validate-input" data-validate = "Valid email is: a@b.c">
				<asp:TextBox ID="txtEmail" runat="server" placeholder="Correo Electrónico"></asp:TextBox>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Enter password">
				<asp:TextBox ID="txtContrasena" runat="server" TextMode="Password" placeholder="Contraseña"></asp:TextBox>

					</div>
					          <div class="botonDSMateriales" style="text-align:center">
								<asp:Button ID="btnIngresar" runat="server" Text="Ingresar" BackColor="Transparent" Font-Bold="true" ForeColor="White" Font-Size="Large"  OnClick="btnIngresar_Click" />
                             </div>
				
				    <div class="text-center p-t-115" style="padding-top: 50px;">
						<span class="txt1">
							Olvidaste la contraseña / usuario
						</span>

						<a class="txt2" href="#">
							Ingreasar aqui
						</a>
						<br />
						<span class="txt1">
							¿No tienes una cuenta?
						</span>

						<a class="txt2" href="#">
							Registrarse
						</a>
					</div>

					
						

					
				
			</div>
	
	</div>
	

	<div id="dropDownSelect1"></div>
	
    </form>
</body>
</html>
