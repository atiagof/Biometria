using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaBiometria.FACADE;
using SistemaBiometria.MODEL;

namespace SistemaBiometria
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Recupera o id do usuário logado
            var id_usuario = Convert.ToInt32(Request["U"]);

            if (!IsPostBack)
            {
                if (id_usuario == 1 )
                {
                    //Recupera todos sistemas cadastrados
                    // O usuario 1 é o admin do sistema e visualiza toda a lista de sistemas cadastrado e visualiza todos os menus de gerenciamento do sistema.
                    FACADE.Sistema FacadeSistema = new FACADE.Sistema();

                    List<MODEL.Sistema> LstSistemas = new List<MODEL.Sistema>();

                    LstSistemas = FacadeSistema.ListaSistemas();

                    Gdw_Sistema.DataSource = LstSistemas;
                    Gdw_Sistema.DataBind();

                }
                else
                {
                    //Recupera os sistemas que o usuário tem permissão de acesso
                    FACADE.Sistema FacadeSistema = new FACADE.Sistema();

                    List<MODEL.Sistema> LstSistemas = new List<MODEL.Sistema>();

                    // Retorna os sitemas que o usuário logado tem acesso relação dos sistemas selecionados pelo adm
                    LstSistemas = FacadeSistema.ListaSistemasPorUsuario(id_usuario);

                    //Retorna a descrição dos sistemas que o usuário tem acesso na tabela de permissão e monta o grid apenas com os sistemas permitidos!!
                    //Recupera os sistemas que o usuário tem permissão de acesso
                    FACADE.Sistema FacadeSistemaPermitidosDesc = new FACADE.Sistema();

                    List<MODEL.Sistema> ListaSistemasPermitidosDesc = new List<MODEL.Sistema>();
                    
                    // Retorna os sitemas que o usuário logado tem acesso

                    if (LstSistemas.Count == 1)
                    {
                        ListaSistemasPermitidosDesc = FacadeSistemaPermitidosDesc.ListaDescricaoSistemasPorUsuario(LstSistemas[0].CheckBoxSelect);

                        Gdw_Sistema.DataSource = ListaSistemasPermitidosDesc;
                        Gdw_Sistema.DataBind();  
                    }else
                    {
                        Lbl_Aviso.Visible = true;
                        Response.Write("<script>alert('Não existe sistema cadastrados para esse usuário!');</script>");
                    }
                }
            }
        }
    }
}