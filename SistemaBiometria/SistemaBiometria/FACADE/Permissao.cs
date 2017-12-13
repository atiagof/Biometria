using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaBiometria.MODEL;
using SistemaBiometria.BUSSINES;

namespace SistemaBiometria.FACADE
{
    public class Permissao
    {
        public bool CadPermissao(List<MODEL.Usuario> ListaPermissao)
        {
            bool Retorno = false;

            BUSSINES.Permissao BussinesPermissao = new BUSSINES.Permissao();

            Retorno = BussinesPermissao.CadPermissao(ListaPermissao);

            return Retorno;

        }
    }
}