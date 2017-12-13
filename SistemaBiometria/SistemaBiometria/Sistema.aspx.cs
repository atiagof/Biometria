using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaBiometria.DAL;
using SistemaBiometria.FACADE;

namespace SistemaBiometria
{
    public partial class Sistema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            // Declaração de variaveis
            string sistema = string.Empty;
            bool retorno = false;
            //var cod;

            //Recupera os parametros enviados
            sistema = Txt_Nome_Sistema.Text;

            // Envia o parametro para facade
            FACADE.Sistema Sistema = new FACADE.Sistema();
            retorno = Sistema.CadSistema(sistema);

            //Exibe mensagem caso o usuario que está tentando se logar não esteja cadastrado.
            Response.Write("<script>alert('Sistema cadastrado com sucesso!');</script>");
        }
    }
}