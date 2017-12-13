using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaBiometria;

namespace SistemaBiometria
{
    public partial class BiometriaSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var Id_Usuario = Convert.ToInt32(Request["U"]);

            // Recupera o nome do usuario
            List<MODEL.Usuario> ListaUsuario = new List<MODEL.Usuario>();

            Util ClasseUtil = new Util();

            if (Id_Usuario != 0)
            {
                ListaUsuario = ClasseUtil.ListaDadosUsuario(Id_Usuario);
            }

            // Se estiver logado como adm visualiza todos os menus do sistema
            if (Id_Usuario == 1)
            {
                ListaUsuario[0].nome = "Administrador";

                Hpk_Home.NavigateUrl = "home.aspx?U=" + Id_Usuario;
                Hpk_Sistema.NavigateUrl = "Sistema.aspx?U=" + Id_Usuario;
                Hpk_Permissao.NavigateUrl = "Permissao.aspx?U=" + Id_Usuario;
            }
            else
            {
                Hpk_Home.NavigateUrl = "home.aspx?U=" + Id_Usuario;
                Hpk_Sistema.Visible = false;
                Hpk_Permissao.Visible = false;
            }

            if (ListaUsuario.Count == 1)
            {
                // Exibe o nome do usuário logado na tela
                Lbl_BemVindo.Text = "Seja Bem vindo(a)! " + ListaUsuario[0].nome;
            }

            // Retorna para a tela de login de usuários
            Hpk_Sair.NavigateUrl = "login.aspx";
        }
    }
}