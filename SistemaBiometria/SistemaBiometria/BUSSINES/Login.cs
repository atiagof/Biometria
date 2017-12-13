using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaBiometria.DAL;
using SistemaBiometria.MODEL;

namespace SistemaBiometria.BUSSINES
{
    public class Login
    {
        public List<MODEL.Usuario> LogarUsuario(MODEL.Usuario Usuario)
        {
            try
            {
                // Declara retorno
                List<MODEL.Usuario> ListRetornoUsuario = new List<MODEL.Usuario>();

                // Valida o valor enviado


                // Após preencher o objeto enviar para DAL.
                DAL.Login DLogin = new DAL.Login();

                ListRetornoUsuario = DLogin.LogarUsuario(Usuario);

                return ListRetornoUsuario;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool SalvarLogLoginUsuario(List<MODEL.Usuario> ListaRetornoUsuarioLogado)
        {
            bool Retorno = false;

            DAL.Login DalLogAcesso = new DAL.Login();

            Retorno = DalLogAcesso.SalvarLogLoginUsuario(ListaRetornoUsuarioLogado);

            return Retorno;
        }
    }
}