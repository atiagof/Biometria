using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaBiometria.MODEL;
using SistemaBiometria.BUSSINES;

namespace SistemaBiometria.FACADE
{
    public class Usuario
    {
        public bool CadUsuario(string nome, string cpf, int codigo)
        {
            //Declaração de variaveis
            bool Retorno = false;

            //Monta o objeto Usuario com os dados enviados
            MODEL.Usuario usuario = new MODEL.Usuario();
            usuario.nome = nome;
            usuario.cpf = cpf;
            usuario.codigo_biometria = codigo;

            //Envia o objeto montado para validações na camada bussines
            BUSSINES.Usuario ValidaUsuario = new BUSSINES.Usuario();

            // Recupera o retorno
            Retorno = ValidaUsuario.CadUsuario(usuario);

            return Retorno;
        }
        
        public List<MODEL.Usuario> ListaUsuario()
        {
            List<MODEL.Usuario> LstUsuario = new List<MODEL.Usuario>();

            BUSSINES.Usuario BussinesSistema = new BUSSINES.Usuario();

            LstUsuario = BussinesSistema.LstUsuario();

            return LstUsuario;
        }
        
        /// <summary>
        /// ListaUsuario pelo id_Usuario
        /// </summary>
        /// <param name="Id_UsuarioLogado"></param>
        /// <returns>Retorna os dados do usuário logado</returns>
        public List<MODEL.Usuario> ListaUsuario(int Id_UsuarioLogado)
        {
            List<MODEL.Usuario> LstUsuario = new List<MODEL.Usuario>();

            BUSSINES.Usuario BussinesSistema = new BUSSINES.Usuario();

            LstUsuario = BussinesSistema.LstUsuario(Id_UsuarioLogado);

            return LstUsuario;
        }

    }
}