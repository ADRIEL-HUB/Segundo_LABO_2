using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LABO_2
{
    public partial class index_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
               
            }

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {

            Func<double, double > doble= Funcion.multiplicacion;
            double numero = Convert.ToDouble(txtPrimerNumero.Text);
            double respuesta = doble(numero);
            txtResultado.Text = respuesta.ToString();

            Action<String> backup = Funcion.Bitacora;
            string backup_1 = String.Format("EL RESULTADO OBTENIDO CON LA MULTIPLICACION REALIZADA AL NUMERO {0} POR 2 DA COMO RESULTADO {1}", numero, respuesta);
            backup(backup_1);     
            
            
            
            

         }
    }
}