using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class NEspecialista
    {
        public static string Insertar(int especialistaCMP, string especialistaNombre, string especialistaApellido, int especialidadCodigo)
        {
            DEspecialista ObjEspecialista = new DEspecialista();

            ObjEspecialista.EspecialistaCMP = especialistaCMP;
            ObjEspecialista.EspecialistaNombre = especialistaNombre;
            ObjEspecialista.EspecialistaApellido = especialistaApellido;
            //ObjEspecialista.EspecialidadCodigo = especialidadCodigo;

            return ObjEspecialista.Insertar(ObjEspecialista);
        }
        public static string Actualizar(int especialistaCMP, string especialistaNombre, string especialistaApellido, int especialidadCodigo)
        {
            DEspecialista ObjEspecialista = new DEspecialista();

            ObjEspecialista.EspecialistaCMP = especialistaCMP;
            ObjEspecialista.EspecialistaNombre = especialistaNombre;
            ObjEspecialista.EspecialistaApellido = especialistaApellido;
            //ObjEspecialista.EspecialidadCodigo = especialidadCodigo;

            return ObjEspecialista.Actualizar(ObjEspecialista);
        }

        public static string Eliminar(int especialistaCMP)
        {
            DEspecialista ObjEspecialista = new DEspecialista();

            ObjEspecialista.EspecialistaCMP = especialistaCMP;

            return ObjEspecialista.Eliminar(ObjEspecialista);
        }

        public static DataTable ListarEspecialista()
        {
            return new DEspecialista().ListarEspecialista();
        }

        public static DataTable ListarEspecialistaCMP(int especialistaCMP)
        {
            DEspecialista ObjEspecialista = new DEspecialista();

            ObjEspecialista.EspecialistaCMP = especialistaCMP;

            return ObjEspecialista.ListarEspecialistaCMP(ObjEspecialista);
        }





    }
}


