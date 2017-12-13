using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaBiometria.MODEL;
using SistemaBiometria.DAL;

namespace SistemaBiometria.BUSSINES
{
    public class Sistema
    {
        public bool CadSistema(MODEL.Sistema ObjSistema)
        {
            bool Retorno = false;


            DAL.Sistema Dal = new DAL.Sistema();

            Retorno = Dal.CadSistema(ObjSistema);
            
            return Retorno;
        }
        public List<MODEL.Sistema> ListaSistemas()
        {
            List<MODEL.Sistema> LstSistema = new List<MODEL.Sistema>();

            DAL.Sistema DalSistema = new DAL.Sistema();

            LstSistema = DalSistema.ListaSistemas();

            return LstSistema;
        }
        public List<MODEL.Sistema> ListaSistemasPorUsuario(int Id_Usuario_Logado)
        {
            List<MODEL.Sistema> LstSistema = new List<MODEL.Sistema>();
            
            DAL.Sistema DalSistema = new DAL.Sistema();

            LstSistema = DalSistema.ListaSistemasPorUsuario(Id_Usuario_Logado);

            return LstSistema;
        }

        public List<MODEL.Sistema> ListaDescricaoSistemasPorUsuario(string CheckBoxSelect)
        {
            List<MODEL.Sistema> ListSistemaDescricao = new List<MODEL.Sistema>();

            DAL.Sistema DalSistema = new DAL.Sistema();

            ListSistemaDescricao = DalSistema.ListaDescricaoSistemasPorUsuario(CheckBoxSelect);

            return ListSistemaDescricao;
        }
    }
}