using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaBiometria.FACADE;
namespace SistemaBiometria
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            // Declaração de variaveis
            string Nome = string.Empty;
            string Cpf = string.Empty;
            int Codigo = 0;
            bool Retorno = false;

            //Recupera os parametros enviados para cadastro
            Nome = txt_Nome.Text;
            Cpf = txt_Cpf.Text;
            Codigo = txt_Codigo.Text == string.Empty ? 0 : Convert.ToInt32(txt_Codigo.Text);

            // Envia o parametro para facade
            FACADE.Usuario Cadastrar = new FACADE.Usuario();
            Retorno = Cadastrar.CadUsuario(Nome, Cpf, Codigo);

            if (Retorno)
            {
                Response.Redirect("login.aspx?C=1");
            }
        }
    }
}