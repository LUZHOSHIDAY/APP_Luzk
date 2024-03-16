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
    /// <summary>
    /// Creacion del objeto Paciente
    /// </summary>
    public class DPaciente
    {
        private string _PacienteCodigo;

        /// <summary>
        /// Metodo get, set del codigo del paciente
        /// </summary>
        public string PacienteCodigo
        {
            get { return _PacienteCodigo; }
            set { _PacienteCodigo = value; }
        }

        private string _PacienteNombre;
        public string PacienteNombre
        {
            get { return _PacienteNombre; }
            set { _PacienteNombre = value; }
        }

        private string _PacienteApellido;
        public string PacienteApellido
        {
            get { return _PacienteApellido; }
            set { _PacienteApellido = value; }
        }

        private string _PacienteDireccion;
        public string PacienteDireccion
        {
            get { return _PacienteDireccion; }
            set { _PacienteDireccion = value; }
        }

        private int _PacienteTelefono;
        public int PacienteTelefono
        {
            get { return _PacienteTelefono; }
            set { _PacienteTelefono = value; }
        }

        private string _PacienteNacimiento;
        public string PacienteNacimiento
        {
            get { return _PacienteNacimiento; }
            set { _PacienteNacimiento = value; }
        }

        private int _EECCCodigo;
        public int EECCCodigo
        {
            get { return _EECCCodigo; }
            set { _EECCCodigo = value; }
        }

        private int _GeneroCCodigo;
        public int GeneroCCodigo
        {
            get { return _GeneroCCodigo; }
            set { _GeneroCCodigo = value; }
        }

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public DPaciente() { }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="pacienteCodigo"></param>
        /// <param name="pacienteNombre"></param>
        /// <param name="pacienteApellido"></param>
        /// <param name="pacienteDireccion"></param>
        /// <param name="pacienteTelefono"></param>
        /// <param name="pacienteNacimiento"></param>
        /// <param name="eECCCodigo"></param>
        /// <param name="generoCCodigo"></param>
        public DPaciente(string pacienteCodigo,
            string pacienteNombre,
            string pacienteApellido, string pacienteDireccion, int pacienteTelefono,
            string pacienteNacimiento, int eECCCodigo, int generoCCodigo)
        {
            this.PacienteCodigo = pacienteCodigo;
            this.PacienteNombre = pacienteNombre;
            this.PacienteApellido = pacienteApellido;
            this.PacienteDireccion = pacienteDireccion;
            this.PacienteTelefono = pacienteTelefono;
            this.PacienteNacimiento = pacienteNacimiento;
            this.EECCCodigo = eECCCodigo;
            this.GeneroCCodigo = generoCCodigo;
        }

        /// <summary>
        /// Metodo Insertar Pacientes
        /// </summary>
        /// <param name="Paciente"></param>
        /// <returns></returns>
        public string Insertar(DPaciente Paciente)
        {
            string rpta = "";

            using (SqlConnection SqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand SqlCmd = new SqlCommand("usp_InsertarPaciente", SqlCon))
            {
                try
                {
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    
                    SqlCmd.Parameters.Add("@PacienteCodigo", SqlDbType.VarChar, 8).Value = Paciente.PacienteCodigo;
                    SqlCmd.Parameters.Add("@PacienteNombre", SqlDbType.VarChar, 30).Value = Paciente.PacienteNombre;
                    SqlCmd.Parameters.Add("@PacienteApellido", SqlDbType.VarChar, 50).Value = Paciente.PacienteApellido;
                    SqlCmd.Parameters.Add("@PacienteDireccion", SqlDbType.VarChar, 150).Value = Paciente.PacienteDireccion;
                    SqlCmd.Parameters.Add("@PacienteTelefono", SqlDbType.Int).Value = Paciente.PacienteTelefono;
                    SqlCmd.Parameters.Add("@PacienteNacimiento", SqlDbType.Date).Value = Paciente.PacienteNacimiento;
                    SqlCmd.Parameters.Add("@EECCCodigo", SqlDbType.TinyInt).Value = Paciente.EECCCodigo;
                    SqlCmd.Parameters.Add("@GeneroCCodigo", SqlDbType.TinyInt).Value = Paciente.GeneroCCodigo;

                    SqlCon.Open();
                    rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok":"No se Ingreso el Registro";  
                     
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                finally { 
                    if (SqlCon.State==ConnectionState.Open) { SqlCon.Close(); }
                }

                return rpta;
            }
        }

        /// <summary>
        /// Metodo Actualizar Pacientes
        /// </summary>
        /// <param name="Paciente"></param>
        /// <returns></returns>
        public string Actualizar(DPaciente Paciente)
        {
            string rpta = "";

            using (SqlConnection SqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand SqlCmd = new SqlCommand("usp_ActualizarPaciente", SqlCon))
            {
                try
                {
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlCmd.Parameters.Add("@PacienteCodigo", SqlDbType.VarChar, 8).Value = Paciente.PacienteCodigo;
                    SqlCmd.Parameters.Add("@PacienteNombre", SqlDbType.VarChar, 30).Value = Paciente.PacienteNombre;
                    SqlCmd.Parameters.Add("@PacienteApellido", SqlDbType.VarChar, 50).Value = Paciente.PacienteApellido;
                    SqlCmd.Parameters.Add("@PacienteDireccion", SqlDbType.VarChar, 150).Value = Paciente.PacienteDireccion;
                    SqlCmd.Parameters.Add("@PacienteTelefono", SqlDbType.Int).Value = Paciente.PacienteTelefono;
                    SqlCmd.Parameters.Add("@PacienteNacimiento", SqlDbType.Date).Value = Paciente.PacienteNacimiento;
                    SqlCmd.Parameters.Add("@EECCCodigo", SqlDbType.TinyInt).Value = Paciente.EECCCodigo;
                    SqlCmd.Parameters.Add("@GeneroCCodigo", SqlDbType.TinyInt).Value = Paciente.GeneroCCodigo;

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
        /// <param name="Paciente"></param>
        /// <returns></returns>
        public string Eliminar(DPaciente Paciente)
        {
            string rpta = "";

            using (SqlConnection SqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand SqlCmd = new SqlCommand("usp_EliminarPaciente", SqlCon))
            {
                try
                {
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlCmd.Parameters.Add("@PacienteCodigo", SqlDbType.VarChar, 8).Value = Paciente.PacienteCodigo;
                    
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
        /// Metodo para listar pacientes
        /// </summary>
        /// <returns></returns>
        public DataTable ListarPaciente()
        {
            DataTable dtResultado = new DataTable("paciente");

            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand("usp_ListarPaciente", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                    sqlDat.Fill(dtResultado);
                }
                catch (Exception ex)
                {
                    // Log the exception for further investigation
                    Console.WriteLine("Error al obtener lista de pacientes: " + ex.Message);
                    dtResultado = null;
                }
            }

            return dtResultado;
        }

        /// <summary>
        /// Metodo para buscar pacientes por DNI
        /// </summary>
        /// <returns></returns>
        public DataTable ListarPacienteDNI(DPaciente Paciente)
        {
            DataTable dtResultado = new DataTable("paciente");

            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand("usp_ListarPacienteDNI", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParam = new SqlParameter("@PacienteCodigo", SqlDbType.VarChar, 8)
                    {
                        Value = Paciente.PacienteCodigo
                    };
                    sqlCmd.Parameters.Add(sqlParam);

                    SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                    sqlDat.Fill(dtResultado);
                }
                catch (Exception ex)
                {
                    // Log the exception for further investigation
                    Console.WriteLine("Error al obtener paciente por DNI: " + ex.Message);
                    dtResultado = null;
                }
            }

            return dtResultado;
        }

    }
}
