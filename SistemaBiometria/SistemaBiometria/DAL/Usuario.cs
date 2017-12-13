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
    public class Usuario
    {
        public bool CadUsuario(MODEL.Usuario Usuario)
        {
            try
            {
                using (SqlConnection oConn = new SqlConnection(ConfigurationManager.ConnectionStrings["strConn"].ConnectionString))
                {
                    SqlCommand oComm = new SqlCommand();

                    oComm.CommandText = "SP_INS_USUARIO";

                    oComm.CommandType = CommandType.StoredProcedure;

                    oComm.Connection = oConn;

                    oComm.Parameters.Add("@NOME", SqlDbType.Text).Value = Usuario.nome;
                    oComm.Parameters.Add("@CPF", SqlDbType.Text).Value = Usuario.cpf;
                    oComm.Parameters.Add("@CODIGO_BIOMETRIA", SqlDbType.Int).Value = Usuario.codigo_biometria;

                    oConn.Open();

                    return Convert.ToBoolean(oComm.ExecuteNonQuery());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<MODEL.Usuario> ListaUsuarios()
        {
            List<MODEL.Usuario> ListaUsuario = new List<MODEL.Usuario>();

            using (SqlConnection oConn = new SqlConnection(ConfigurationManager.ConnectionStrings["strConn"].ConnectionString))
            {
                SqlCommand oComm = new SqlCommand();

                oComm.CommandText = "SP_SEL_USUARIO";

                oComm.CommandType = CommandType.StoredProcedure;

                oComm.Connection = oConn;

                oConn.Open();
                var reader = oComm.ExecuteReader();

                while (reader.Read())
                {
                    MODEL.Usuario ObjUsuario = new MODEL.Usuario();

                    ObjUsuario.id_usuario = Convert.ToInt32(reader.GetValue(0));
                    ObjUsuario.nome = reader.GetValue(1).ToString();

                    ListaUsuario.Add(ObjUsuario);
                }

                return ListaUsuario;
            }
        }

        public List<MODEL.Usuario> ListaUsuarios(int Id_UsuarioLogado)
        {
            List<MODEL.Usuario> ListaUsuario = new List<MODEL.Usuario>();

            using (SqlConnection oConn = new SqlConnection(ConfigurationManager.ConnectionStrings["strConn"].ConnectionString))
            {
                SqlCommand oComm = new SqlCommand();

                oComm.CommandText = "SP_SEL_USUARIO_ID";

                oComm.CommandType = CommandType.StoredProcedure;

                oComm.Connection = oConn;

                oComm.Parameters.Add("@ID_USUARIO_LOGADO", SqlDbType.Int).Value = Id_UsuarioLogado;

                oConn.Open();

                var reader = oComm.ExecuteReader();

                while (reader.Read())
                {
                    MODEL.Usuario ObjUsuario = new MODEL.Usuario();

                    ObjUsuario.id_usuario = Convert.ToInt32(reader.GetValue(0));
                    ObjUsuario.nome = reader.GetValue(1).ToString();
                    ObjUsuario.cpf = reader.GetValue(2).ToString();
                    ObjUsuario.codigo_biometria = Convert.ToInt32(reader.GetValue(3));
                    ObjUsuario.data_cadastro = Convert.ToDateTime(reader.GetValue(4));

                    ListaUsuario.Add(ObjUsuario);
                }

                return ListaUsuario;
            }
        }
    }
}