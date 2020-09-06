using Capa.Entidad;
using Capa.LogicaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDsMateriales
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        UsuarioEntidad usuario = new UsuarioEntidad();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlSucursal.DataSource = SucursalLN.ObtenerTodosSucursal();
                ddlSucursal.DataTextField = "NombreProvincia";
                ddlSucursal.DataValueField = "IdSucursal";
                ddlSucursal.DataBind();
            }
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            SucursalEntidad sucursal = new SucursalEntidad();
            TipoUsuarioEntidad tipoUsuario = new TipoUsuarioEntidad();
            Boolean puede = true;
            Boolean puede2 = true;
            foreach (UsuarioEntidad user in UsuarioLN.ObtenerTodosUsuario())
            {
                SucursalEntidad sucursalP = SucursalLN.Obtener(Convert.ToInt32(ddlSucursal.SelectedValue));
                if (user.CorreoElectronico.Equals(txtCorreo.Text) && user.sucursalEntidad.IdSucursal == sucursalP.IdSucursal) 
                { 
                    lblErrorCorreo.Text = "El correo que ingresó ya se encuentra registrado en la sucursal seleccionada";
                    puede2 = false;
                }
            }
            if (txtCorreo.Text.Equals(""))
            {

                puede = false;
                lblErrorCorreo.Text = "Se debe ingresar el correo electrónico";
            }         
            else
            {
                puede = true;
                lblErrorCorreo.Text = "";
            }
            if (puede2 == true)
            {
                lblErrorCorreo.Text = "El correo que ingresó ya se encuentra registrado en la sucursal seleccionada";
            }
            else
            {
                lblErrorCorreo.Text = "";
            }
            if (txtNombre.Text.Equals(""))
            {
                lblErrorNombre.Text = "El nombre es requerido";
                puede = false;
            }
            else
            {
                lblErrorNombre.Text = "";
                puede = true;
            }
            if (txtApellidos.Text.Equals(""))
            {
                lblErrorApellidos.Text = "El Apellido es requerido";
                puede = false;
            }
            else
            {
                lblErrorApellidos.Text = "";
                puede = true;
            }
            if (txtTelefono.Text.Equals(""))
            {
                lblErrorTelefono.Text = "El Teléfono es requerido";
                puede = false;
            }
            else
            {
                lblErrorTelefono.Text = "";
                puede = true;
            }
            if (txtContrasena.Text.Length < 7)
            {
                lblErrorContrasenna.Text = "La contraseña debe contener minimo 7 digitos";
                puede = false;
            }
            else
            {
                puede = true;
            }
            if (!txtContrasena.Text.Equals(txtContrasena2.Text) || txtContrasena.Text.Equals("") && txtContrasena2.Text.Equals(""))
            {
                lblErrorContrasenna.Text = "Las contraseñas no coinciden";
                lblErrorContrasenna.Text = "Las contraseñas no coinciden";
                puede = false;
            }
            else
            {
                lblErrorContrasenna.Text = "";
                lblErrorContrasenna.Text = "";
                puede = true;
            }
            
            if(puede == true && puede2 == true)
            {
                usuario.NombreUsuario = txtNombre.Text;
                usuario.ApellidoUsuario = txtApellidos.Text;
                usuario.CorreoElectronico = txtCorreo.Text;
                usuario.Telefono = Convert.ToInt32(txtTelefono.Text);
                usuario.Password = txtContrasena.Text;
                //Obtener Tipo de Usuario
                tipoUsuario = TipoUsuarioLN.Obtener(3);
                usuario.tipoUsuarioEntidad = tipoUsuario;
                usuario.tipoUsuarioEntidad.IdTipoUsuario = tipoUsuario.IdTipoUsuario;
                //Obtener Sucursal
                usuario.sucursalEntidad = SucursalLN.Obtener(Convert.ToInt32(ddlSucursal.SelectedValue));
                Session["Sucursal"] = usuario.sucursalEntidad;
                usuario.sucursalEntidad = (SucursalEntidad)Session["Sucursal"];
                usuario.sucursalEntidad.IdSucursal = usuario.sucursalEntidad.IdSucursal;
                usuario.Estado = true;
                usuario.Genero = "";
                usuario.Edad = 0;
                usuario.Identificacion = 0;
                UsuarioLN.Nuevo(usuario);
                System.Web.SessionState.HttpSessionState session = Session;
                session["Usuario"] = usuario;
                ClientScript.RegisterStartupScript(
                    this.GetType(),
                    "Login",
                    "mensajeRedirect('Registro de Usuario', 'Registro Correcto', 'success', 'IndexCliente.aspx')",
                    true
                    );
            } 
        }
        protected void ddlSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}