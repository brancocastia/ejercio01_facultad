using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    public abstract class Persona
    {

        // ATRIBUTOS
        private string _nombre;
        private string _apellido;
        protected DateTime _fechaNac;

        // Propiedades 
        protected string Apellido { get => _apellido; set => _apellido = value; }
        protected string Nombre { get => _apellido; set => _apellido = value; }
        protected DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }

        //Metodos
        protected abstract void GetCredencial();

        protected virtual void GetNombreCompleto()
        {

        }
        protected void GetSaludoInformal()
        {

        }

    }
}
