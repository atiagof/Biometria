using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaBiometria.FACADE;

namespace SistemaBiometria
{
    public partial class Login_Biometria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_login_Click(object sender, EventArgs e)
        {
            // Declaração de variaveis
            string cpf = string.Empty;
            bool retorno = false;
            //var cod;

            //Recupera os parametros enviados
            cpf = Request["Txt_Cpf"];

            // Envia o parametro para facade
            FACADE.Login login = new FACADE.Login();
            

            //Response.Redirect("home.aspx");


        }
    }
}