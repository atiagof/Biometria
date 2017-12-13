using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaBiometria.DAL
{
    public class Permissao
    {
        public bool CadPermissao(List<MODEL.Usuario> ListaPermissao)
        {
            try
            {
                using (SqlConnection oConn = new SqlConnection(ConfigurationManager.ConnectionStrings["strConn"].ConnectionString))
                {
                    SqlCommand oComm = new SqlCommand();

                    oComm.CommandText = "SP_INS_PERMISSAO_SISTEMA";

                    oComm.CommandType = CommandType.StoredProcedure;

                    oComm.Connection = oConn;

                    oComm.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = ListaPermissao[0].id_usuario;
                    oComm.Parameters.Add("@CHECK_SISTEMAS", SqlDbType.Text).Value = ListaPermissao[0].CheckBoxSelect;
                    
                    oConn.Open();

                    return Convert.ToBoolean(oComm.ExecuteNonQuery());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}