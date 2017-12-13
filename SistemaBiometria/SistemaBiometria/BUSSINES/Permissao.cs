using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBiometria.BUSSINES
{
    public class Permissao
    {
        public bool CadPermissao(List<MODEL.Usuario> ListaPermissao)
        {
            bool Retorno = false;

            DAL.Permissao DalPermissao = new DAL.Permissao();

            Retorno = DalPermissao.CadPermissao(ListaPermissao);

            return Retorno;
        }
    }
}