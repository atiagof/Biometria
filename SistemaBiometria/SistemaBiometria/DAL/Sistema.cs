using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaBiometria.MODEL;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SistemaBiometria.DAL
{
    public class Sistema
    {
        public bool CadSistema(MODEL.Sistema ObjSistema)
        {
            try
            {
                using (SqlConnection oConn = new SqlConnection(ConfigurationManager.ConnectionStrings["strConn"].ConnectionString))
                {
                    SqlCommand oComm = new SqlCommand();

                    oComm.CommandText = "SP_INS_SISTEMA";

                    oComm.CommandType = CommandType.StoredProcedure;

                    oComm.Connection = oConn;

                    oComm.Parameters.Add("@DESCRICAO", SqlDbType.Text).Value = ObjSistema.Descricao;

                    oConn.Open();

                    return Convert.ToBoolean(oComm.ExecuteNonQuery());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<MODEL.Sistema> ListaSistemas()
        {
            List<MODEL.Sistema> ListaSistema = new List<MODEL.Sistema>();

            using (SqlConnection oConn = new SqlConnection(ConfigurationManager.ConnectionStrings["strConn"].ConnectionString))
            {
                SqlCommand oComm = new SqlCommand();

                oComm.CommandText = "SP_SEL_SISTEMA";

                oComm.CommandType = CommandType.StoredProcedure;

                oComm.Connection = oConn;

                oConn.Open();
                var reader = oComm.ExecuteReader();

                while (reader.Read())
                {
                    MODEL.Sistema ObjSistema = new MODEL.Sistema();

                    ObjSistema.Id_Sistema = Convert.ToInt32(reader.GetValue(0));
                    ObjSistema.Descricao = reader.GetValue(1).ToString();
                    
                    ListaSistema.Add(ObjSistema);
                }

                return ListaSistema;
            }
        }
        public List<MODEL.Sistema> ListaSistemasPorUsuario(int Id_Usuario_Logado)
        {
            List<MODEL.Sistema> ListaSistema = new List<MODEL.Sistema>();

            using (SqlConnection oConn = new SqlConnection(ConfigurationManager.ConnectionStrings["strConn"].ConnectionString))
            {
                SqlCommand oComm = new SqlCommand();

                oComm.CommandText = "SP_SEL_SISTEMAS_POR_USUARIO";

                oComm.CommandType = CommandType.StoredProcedure;

                oComm.Connection = oConn;

                oComm.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = Id_Usuario_Logado;

                oConn.Open();
                var reader = oComm.ExecuteReader();

                while (reader.Read())
                {
                    MODEL.Sistema ObjSistema = new MODEL.Sistema();

                    ObjSistema.CheckBoxSelect = reader.GetValue(1).ToString();

                    ListaSistema.Add(ObjSistema);
                }

                return ListaSistema;
            }
        }
        public List<MODEL.Sistema> ListaDescricaoSistemasPorUsuario(string CheckBoxSelect)
        {
            List<MODEL.Sistema> ListaSistema = new List<MODEL.Sistema>();

            using (SqlConnection oConn = new SqlConnection(ConfigurationManager.ConnectionStrings["strConn"].ConnectionString))
            {
                SqlCommand oComm = new SqlCommand();

                oComm.CommandText = "SP_RETORNA_SISTEMAS_DESCRICAO";

                oComm.CommandType = CommandType.StoredProcedure;

                oComm.Connection = oConn;

                oComm.Parameters.Add("@LISTADESISTEMAS", SqlDbType.Text).Value = CheckBoxSelect;

                oConn.Open();
                var reader = oComm.ExecuteReader();

                while (reader.Read())
                {
                    MODEL.Sistema ObjSistema = new MODEL.Sistema();

                    ObjSistema.Id_Sistema = Convert.ToInt32(reader.GetValue(0));
                    ObjSistema.Descricao = reader.GetValue(1).ToString();

                    ListaSistema.Add(ObjSistema);
                }

                return ListaSistema;
            }
        }
    }
}