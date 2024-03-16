using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class NPaciente
    {
        public static string Insertar(string pacientecodigo,string pacientenombre, string pacienteapellido, string pacientedireccion, int pacientetelefono,    string pacientenacimiento, int eecccodigo, int generocodigo)
        {
            DPaciente ObjPaciente = new DPaciente();

            ObjPaciente.PacienteCodigo = pacientecodigo;
            ObjPaciente.PacienteNombre = pacientenombre;
            ObjPaciente.PacienteApellido = pacienteapellido;
            ObjPaciente.PacienteDireccion = pacientedireccion;
            ObjPaciente.PacienteTelefono=pacientetelefono;
            ObjPaciente.PacienteNacimiento=pacientenacimiento;
            ObjPaciente.EECCCodigo=eecccodigo;
            ObjPaciente.GeneroCCodigo= generocodigo;

            return ObjPaciente.Insertar(ObjPaciente);
        }

        public static string Actualizar(string pacientecodigo, string pacientenombre, string pacienteapellido, string pacientedireccion, int pacientetelefono, string pacientenacimiento, int eecccodigo, int generocodigo)
        {
            DPaciente ObjPaciente = new DPaciente();

            ObjPaciente.PacienteCodigo = pacientecodigo;
            ObjPaciente.PacienteNombre = pacientenombre;
            ObjPaciente.PacienteApellido = pacienteapellido;
            ObjPaciente.PacienteDireccion = pacientedireccion;
            ObjPaciente.PacienteTelefono = pacientetelefono;
            ObjPaciente.PacienteNacimiento = pacientenacimiento;
            ObjPaciente.EECCCodigo = eecccodigo;
            ObjPaciente.GeneroCCodigo = generocodigo;

            return ObjPaciente.Actualizar(ObjPaciente);
        }

        public static string Eliminar(string pacientecodigo)
        {
            DPaciente ObjPaciente = new DPaciente();

            ObjPaciente.PacienteCodigo = pacientecodigo;            

            return ObjPaciente.Eliminar(ObjPaciente);
        }

        public static DataTable ListarPaciente()
        {
            return new DPaciente().ListarPaciente();
        }

        public static DataTable ListarPacienteDNI(string pacientecodigo) 
        { 
            DPaciente ObjPaciente=new DPaciente();

            ObjPaciente.PacienteCodigo = pacientecodigo;

            return ObjPaciente.ListarPacienteDNI(ObjPaciente);
        }
    }
}
