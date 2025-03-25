using Facultad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public abstract class Empleado : Persona
    {
        //Atributos
        int _legajo;
        DateTime _fechaIngreso;

        //Propiedades
        public int Legajo { get => _legajo; set => _legajo = value; }
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }

        // PROPERTIES HEREDADAS
        public DateTime FechaNacimiento { get => FechaNac; set => FechaNac = value; }

        //Metodos
        protected override void GetCredencial()
        {

        }

        // PROPERTIES CUSTOM
        public int Antiguedad { get => (DateTime.Now - _fechaIngreso).Days / 365; }
        //protected abstract string ListarEmpleados(bool ListarConID);
    }
}
