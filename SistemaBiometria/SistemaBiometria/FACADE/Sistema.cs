using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaBiometria.MODEL;
using SistemaBiometria.BUSSINES;

namespace SistemaBiometria.FACADE
{
    public class Sistema
    {
        public bool CadSistema(string descricao)
        {
            bool Retorno = false;

            MODEL.Sistema ObjSistema = new MODEL.Sistema();

            ObjSistema.Descricao = descricao;

            BUSSINES.Sistema Bussines = new BUSSINES.Sistema();

            Retorno = Bussines.CadSistema(ObjSistema);

            return Retorno;
        }

        public List<MODEL.Sistema> ListaSistemas()
        {
            List<MODEL.Sistema> LstSistema = new List<MODEL.Sistema>();

            BUSSINES.Sistema BussinesSistema = new BUSSINES.Sistema();

            LstSistema = BussinesSistema.ListaSistemas();

            return LstSistema;
        }
        public List<MODEL.Sistema> ListaSistemasPorUsuario(int Id_UsuarioLogado)
        {
            List<MODEL.Sistema> LstSistema = new List<MODEL.Sistema>();

            BUSSINES.Sistema BussinesSistema = new BUSSINES.Sistema();

            LstSistema = BussinesSistema.ListaSistemasPorUsuario(Id_UsuarioLogado);

            return LstSistema;
        }

        public List<MODEL.Sistema> ListaDescricaoSistemasPorUsuario(string CheckBoxSelect)
        {
            List<MODEL.Sistema> ListSistemaDescricao = new List<MODEL.Sistema>();

            BUSSINES.Sistema BussinesSistema = new BUSSINES.Sistema();

            ListSistemaDescricao = BussinesSistema.ListaDescricaoSistemasPorUsuario(CheckBoxSelect);

            return ListSistemaDescricao;
        }
    }
}