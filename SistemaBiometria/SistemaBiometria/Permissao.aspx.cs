using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaBiometria.MODEL;
using SistemaBiometria.FACADE;

namespace SistemaBiometria
{
    public partial class Permissao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Recupera todos sistemas cadastrados
                List<MODEL.Sistema> LstSistema = new List<MODEL.Sistema>();

                FACADE.Sistema FacadeSistema = new FACADE.Sistema();

                LstSistema = FacadeSistema.ListaSistemas();

                // Preenche o CheckBoxList com os dados de retorno
                PopularCheckBoxList(LstSistema);

                //Recupera os usuarios cadastrados e preenche o combo
                List<MODEL.Usuario> LstUsuario = new List<MODEL.Usuario>();

                FACADE.Usuario FacadeUsuario = new FACADE.Usuario();

                LstUsuario = FacadeUsuario.ListaUsuario();

                //Preenche o combo com os usuarios cadastrados
                PopularComboBoxList(LstUsuario);                
            }

        }

        private void PopularCheckBoxList(List<MODEL.Sistema> ListaSistema)
        {
            foreach (MODEL.Sistema s in ListaSistema)
            {
                ListItem item = new ListItem(s.Descricao, s.Id_Sistema.ToString());
                //item.Selected = s.IsActive;
                CBL_Sistemas.Items.Add(item);
            }
        }
        private void PopularComboBoxList(List<MODEL.Usuario> ListaUsuario)
        {
            foreach (MODEL.Usuario s in ListaUsuario)
            {
                ListItem item = new ListItem(s.nome, s.id_usuario.ToString());
                DDL_Usuarios.Items.Add(item);
            }
        }
        protected void Btn_Cadastro_Click(object sender, EventArgs e)
        {

            //Recupera os itens selecionados
            var id_usuario = DDL_Usuarios.SelectedItem.Value;

            List<MODEL.Usuario> ListPermissaoUsuario = new List<MODEL.Usuario>();
            
            string ChkSelecionados = string.Empty;

            MODEL.Usuario ObjUsuario = new MODEL.Usuario();
            ObjUsuario.id_usuario = Convert.ToInt32(id_usuario);
            for (int i = 0; i < CBL_Sistemas.Items.Count; ++i)
            {
                if (CBL_Sistemas.Items[i].Selected)
                {
                    ChkSelecionados += CBL_Sistemas.Items[i].Value + ",";
                }
            }

            //Retira a ultima virgula dos itens selecionados para armazenar no bd
            var ChkBox = ChkSelecionados.Remove(ChkSelecionados.Length - 1);

            // Adiciona os selecionados no objeto
            ObjUsuario.CheckBoxSelect = ChkBox;
            
            // Adiciona os selecionados na lista
            ListPermissaoUsuario.Add(ObjUsuario);

            //Envia os dados para a facade
            FACADE.Permissao FacadePermissao = new FACADE.Permissao();
            FacadePermissao.CadPermissao(ListPermissaoUsuario);
        }
    }
}