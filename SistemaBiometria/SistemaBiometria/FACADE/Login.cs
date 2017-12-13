using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaBiometria.MODEL;
using SistemaBiometria.BUSSINES;

namespace SistemaBiometria.FACADE
{
    public class Login
    {
        public List<MODEL.Usuario> LogarUsuario(string cpf)
        {
            // Declara retorno
            List<MODEL.Usuario> ListRetornoUsuario = new List<MODEL.Usuario>();

            // Monta um objeto do tipo Usuario
            MODEL.Usuario ObjUsuario = new MODEL.Usuario();
            ObjUsuario.cpf = cpf;

            // Após preencher o objeto enviar para validação da bussine caso existir.
            BUSSINES.Login BLogin = new BUSSINES.Login();

            ListRetornoUsuario = BLogin.LogarUsuario(ObjUsuario);

            return ListRetornoUsuario;
        }

        public bool SalvarLogLoginUsuario(List<MODEL.Usuario> ListaRetornoUsuarioLogado)
        {
            bool Retorno = false;

            //Recebe a lista com os dados do usuario logado e envia para salvar na tabela de log de acesso
            BUSSINES.Login BussinesLogAcesso = new BUSSINES.Login();

            Retorno = BussinesLogAcesso.SalvarLogLoginUsuario(ListaRetornoUsuarioLogado);

            return Retorno;
        }
    }
}