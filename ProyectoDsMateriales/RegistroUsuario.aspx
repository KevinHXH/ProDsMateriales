<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="ProyectoDsMateriales.RegistroUsuario" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro de Usuario</title>
    <link href="css/registro.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       <div id="login-box">
  <div class="left">
    <h1>Registro de Usuario</h1>
    
   <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre "></asp:TextBox>
   <asp:TextBox ID="txtApellidos" runat="server" placeholder="Apellidos"></asp:TextBox>
   <asp:TextBox ID="txtCorreo" runat="server" placeholder="Correo Electrónico"></asp:TextBox>
   <asp:TextBox ID="txtTelefono" runat="server" placeholder="Teléfono"></asp:TextBox>
   <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
   <asp:TextBox ID="txtContrasena2" runat="server" TextMode="Password" placeholder="Confirmar contraseña"></asp:TextBox>
   <asp:DropDownList ID="ddlSucursal" DataTextField="Sucursal" class="form-control" runat="server" OnSelectedIndexChanged="ddlSucursal_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
      
    <br />
      <br />
      <br />
    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar"  OnClick="btnRegistrar_Click" />
  </div>
  
  <div class="right">
   
    
    
      <img src="img/Fondo/Logo2.PNG" style="margin-left:-160px;margin-top:50px;" />
    
</div>
           </div>
    </form>
</body>
</html>
