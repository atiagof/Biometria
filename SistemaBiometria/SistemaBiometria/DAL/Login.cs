using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaBiometria.MODEL;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SistemaBiometria.DAL
{
    public class Login
    {
        public List<MODEL.Usuario> LogarUsuario(MODEL.Usuario Usuario)
        {
            List<MODEL.Usuario> ListaUsuario = new List<MODEL.Usuario>();

            using (SqlConnection oConn = new SqlConnection(ConfigurationManager.ConnectionStrings["strConn"].ConnectionString))
            {
                SqlCommand oComm = new SqlCommand();

                oComm.CommandText = "SP_SEL_USUARIO_CPF";

                oComm.CommandType = CommandType.StoredProcedure;

                oComm.Connection = oConn;
                
                //Parametros para procedure 
                oComm.Parameters.Add("@CPF", SqlDbType.Text).Value = Usuario.cpf;

                oConn.Open();
                var reader = oComm.ExecuteReader();

                while (reader.Read())
                {
                    MODEL.Usuario ObjUsuario = new MODEL.Usuario();

                    ObjUsuario.id_usuario = Convert.ToInt32(reader.GetValue(0));
                    ObjUsuario.nome = reader.GetValue(1).ToString();
                    ObjUsuario.cpf = reader.GetValue(2).ToString();
                    ObjUsuario.codigo_biometria = Convert.ToInt32(reader.GetValue(3));

                    ListaUsuario.Add(ObjUsuario);
                }

                return ListaUsuario;
            }
        }

        public bool SalvarLogLoginUsuario(List<MODEL.Usuario> ListaRetornoUsuarioLogado)
        {
            using (SqlConnection oConn = new SqlConnection(ConfigurationManager.ConnectionStrings["strConn"].ConnectionString))
            {
                SqlCommand oComm = new SqlCommand();

                oComm.CommandText = "SP_INS_LOG_LOGIN";

                oComm.CommandType = CommandType.StoredProcedure;

                oComm.Connection = oConn;

                oComm.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = ListaRetornoUsuarioLogado[0].id_usuario;

                oConn.Open();

                return Convert.ToBoolean(oComm.ExecuteNonQuery());
            }
        }
    }
}