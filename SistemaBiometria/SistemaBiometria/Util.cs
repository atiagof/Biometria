using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaBiometria.MODEL;

namespace SistemaBiometria
{
    public class Util
    {
        /// <summary>
        /// ListaDadosUsuario
        /// </summary>
        /// <param name="Id_Ususario"></param>
        /// <returns>Retorna uma lista com os dados do usuário logado no sistema</returns>
        public List<MODEL.Usuario> ListaDadosUsuario(int Id_Ususario)
        {
            //Lista para armazenar os dados de retorno do banco de dados
            List<MODEL.Usuario> ListaRetornoUsuarioLogado = new List<Usuario>();

            //Instancia Facade de Usuário
            FACADE.Usuario FacadeUsuario = new FACADE.Usuario();

            ListaRetornoUsuarioLogado = FacadeUsuario.ListaUsuario(Id_Ususario);
            
            return ListaRetornoUsuarioLogado;
        }
    }
}