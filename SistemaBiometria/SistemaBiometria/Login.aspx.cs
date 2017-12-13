using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaBiometria.FACADE;

namespace SistemaBiometria
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var Cadastro_Ok = 0;

            Cadastro_Ok = Convert.ToInt32(Request["C"]);

            if (Cadastro_Ok == 1)
            {
                //Exibe mensagem caso o usuario que está tentando se logar não esteja cadastrado.
                Response.Write("<script>alert('Usuário cadastrado com sucesso!');</script>");
            }

        }
        protected void Btn_login_Click(object sender, EventArgs e)
        {
            // Declaração de variaveis
            string cpf = string.Empty;
            List<MODEL.Usuario> ListRetornoUsuario = new List<MODEL.Usuario>();
            //var cod;

            //Recupera os parametros enviados
            cpf = txt_Cpf.Text;

            // Envia o parametro para facade
            FACADE.Login login = new FACADE.Login();
            ListRetornoUsuario = login.LogarUsuario(cpf);

            if (ListRetornoUsuario.Count == 1)
            {
                bool Retorno = false;
                
                // Armazena os dados do usuário logado
                FACADE.Login FacadeLogin = new FACADE.Login();

                Retorno = FacadeLogin.SalvarLogLoginUsuario(ListRetornoUsuario);

                //Caso esteja cadastrado redireciona o usuário pra a home
                Response.Redirect("home.aspx?U=" + ListRetornoUsuario[0].id_usuario);
            }

            //Exibe mensagem caso o usuario que está tentando se logar não esteja cadastrado.
            Response.Write("<script>alert('Usuário não cadastrado');</script>");
        }
    }
}