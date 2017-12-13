using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaBiometria.MODEL;
using SistemaBiometria.DAL;

namespace SistemaBiometria.BUSSINES
{
    public class Usuario
    {
        public bool CadUsuario(MODEL.Usuario Usuario)
        {
            //Declaração de variaveis
            bool Retorno = false;

            //Valida os dados do usuário

            //Envia para inserir na DAL
            DAL.Usuario NovoUsuario = new DAL.Usuario();

            Retorno = NovoUsuario.CadUsuario(Usuario);

            return Retorno;
        }
        public List<MODEL.Usuario> LstUsuario()
        {
            List<MODEL.Usuario> LstUsuario = new List<MODEL.Usuario>();

            DAL.Usuario DalUsuario = new DAL.Usuario();

            LstUsuario = DalUsuario.ListaUsuarios();

            return LstUsuario;
        }

        /// <summary>
        /// LstUsuario os dados pelo Id do usuario logado no sistema
        /// </summary>s
        /// <param name="Id_UsuarioLogado"></param>
        /// <returns>Retorna os dados do usuraio logado no sistema</returns>
        public List<MODEL.Usuario> LstUsuario(int Id_UsuarioLogado)
        {
            List<MODEL.Usuario> LstUsuario = new List<MODEL.Usuario>();

            DAL.Usuario DalUsuario = new DAL.Usuario();

            LstUsuario = DalUsuario.ListaUsuarios(Id_UsuarioLogado);

            return LstUsuario;
        }

    }
}