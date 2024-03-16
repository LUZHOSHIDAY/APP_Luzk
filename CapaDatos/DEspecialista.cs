using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CapaDatos
{
    public class DEspecialista
    {

        private int _EspecialistaCMP;

        /// <summary>
        /// Metodo get, set del codigo del paciente
        /// </summary>
        public int EspecialistaCMP
        {
            get { return _EspecialistaCMP; }
            set { _EspecialistaCMP = value; }
        }

        private string _EspecialistaNombre;
        public string EspecialistaNombre
        {
            get { return _EspecialistaNombre; }
            set { _EspecialistaNombre = value; }
        }
        private string _EspecialistaApellido;
        public string EspecialistaApellido
        {
            get { return _EspecialistaApellido; }
            set { _EspecialistaApellido = value; }
        }
        private int _EspecialistaCodigo;
        public int EspecialistaCodigo
        {
            get { return _EspecialistaCodigo; }
            set { _EspecialistaCodigo = value; }
        }
        /// <summary>
        /// Constructor vacio
        /// </summary>
        public DEspecialista() { }

          public DEspecialista(int especialistaCMP,
            string especialistaNombre,
            string especialistaApellido, int especialidadCodigo)
        {
            this.EspecialistaCMP = especialistaCMP;
            this.EspecialistaNombre = especialistaNombre;
            this.EspecialistaApellido = especialistaApellido;
           // this.EspecialidadCodigo = especialidadCodigo;

        }

        /// <summary>
        /// Metodo Insertar Especialista
        /// </summary>
        /// <param name="Especialista"></param>
        /// <returns></returns>
        public string Insertar(DEspecialista Especialista)
        {
            string rpta = "";

            using (SqlConnection SqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand SqlCmd = new SqlCommand("usp_InsertarEspecialista", SqlCon))
            {
                try
                {
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlCmd.Parameters.Add("@EspecialistaCMP", SqlDbType.Int).Value = Especialista.EspecialistaCMP;
                    SqlCmd.Parameters.Add("@EspecialistaNombre", SqlDbType.VarChar, 30).Value = Especialista.EspecialistaNombre;
                    SqlCmd.Parameters.Add("@EspecialistaApellido", SqlDbType.VarChar, 50).Value = Especialista.EspecialistaApellido;
                    //SqlCmd.Parameters.Add("@EspecialidadCodigo", SqlDbType.Int).Value = Especialista.EspecialidadCodigo;
                    

                    SqlCon.Open();
                    rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se Ingreso el Registro";

                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                finally
                {
                    if (SqlCon.State == ConnectionState.Open) { SqlCon.Close(); }
                }

                return rpta;
            }
        }

        /// <summary>
        /// Metodo Actualizar Pacientes
        /// </summary>
        /// <param name="Especialista"></param>
        /// <returns></returns>
        public string Actualizar(DEspecialista Especialista)
        {
            string rpta = "";

            using (SqlConnection SqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand SqlCmd = new SqlCommand("usp_ActualizarEspecialista", SqlCon))
            {
                try
                {
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlCmd.Parameters.Add("@EspecialistaCMP", SqlDbType.Int).Value = Especialista.EspecialistaCMP;
                    SqlCmd.Parameters.Add("@EspecialistaNombre", SqlDbType.VarChar, 30).Value = Especialista.EspecialistaNombre;
                    SqlCmd.Parameters.Add("@EspecialistaApellido", SqlDbType.VarChar, 50).Value = Especialista.EspecialistaApellido;
                   // SqlCmd.Parameters.Add("@EspecialidadCodigo", SqlDbType.Int).Value = Especialista.EspecialidadCodigo;


                    SqlCon.Open();
                    rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se Actualizo el Registro";

                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                finally
                {
                    if (SqlCon.State == ConnectionState.Open) { SqlCon.Close(); }
                }

                return rpta;
            }
        }

        /// <summary>
        /// Metodo eliminar pacientes
        /// </summary>
        /// <param name="Especialista"></param>
        /// <returns></returns>
        public string Eliminar(DEspecialista Especialista)
        {
            string rpta = "";

            using (SqlConnection SqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand SqlCmd = new SqlCommand("usp_EliminarEspecialista", SqlCon))
            {
                try
                {
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlCmd.Parameters.Add("@EspecialistaCMP", SqlDbType.Int).Value = Especialista.EspecialistaCMP;

                    SqlCon.Open();
                    rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se Elimino el Registro";

                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                finally
                {
                    if (SqlCon.State == ConnectionState.Open) { SqlCon.Close(); }
                }

                return rpta;
            }
        }

        /// <summary>
        /// Metodo para listar Especialista
        /// </summary>
        /// <returns></returns>
        public DataTable ListarEspecialista()
        {
            DataTable dtResultado = new DataTable("Especialista");

            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand("usp_ListarEspecialista", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                    sqlDat.Fill(dtResultado);
                }
                catch (Exception ex)
                {
                    // Log the exception for further investigation
                    Console.WriteLine("Error al obtener lista de Especialista: " + ex.Message);
                    dtResultado = null;
                }
            }

            return dtResultado;
        }

        /// <summary>
        /// Metodo para buscar pacientes por DNI
        /// </summary>
        /// <returns></returns>
        public DataTable ListarEspecialistaCMP(DEspecialista Especialista)
        {
            DataTable dtResultado = new DataTable("Especialista");

            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand("usp_ListarEspecialistaCMP", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParam = new SqlParameter("@EspecialistaCMP", SqlDbType.Int)
                    {
                        Value = Especialista.EspecialistaCMP
                    };
                    sqlCmd.Parameters.Add(sqlParam);

                    SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                    sqlDat.Fill(dtResultado);
                }
                catch (Exception ex)
                {
                    // Log the exception for further investigation
                    Console.WriteLine("Error al obtener EspecialistaCMP: " + ex.Message);
                    dtResultado = null;
                }
            }

            return dtResultado;
        }

    }
}


    }
}
