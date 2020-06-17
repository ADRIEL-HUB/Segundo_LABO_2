using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LABO_2
{
    public partial class index : System.Web.UI.Page
    {
        UsuarioNom objUsuario = new UsuarioNom();       

        protected void Page_Load(object sender, EventArgs e)
        {

            
                objUsuario.Usuario = "ADRIEL_2604";
                objUsuario.Contrasena = "54321";
                objUsuario.NombreCom = "Adriel Calderon Acuña";
            

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == objUsuario.Usuario && txtContrasena.Text == objUsuario.Contrasena) 
            {
                Response.Redirect("index_2.aspx"); 
            }
            else
            {
                txtUsuario.Text = " ";
                txtContrasena.Text = " "; 
            }


        }
    }
}