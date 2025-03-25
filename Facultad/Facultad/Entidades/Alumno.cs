using Facultad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Alumno : Persona
    {
        //Atributo
        int _codigo;

        //Propiedades
        int Codigo { get => _codigo; set => _codigo = value;}

        //Metodos
        protected override void GetCredencial()
        {

        }

    }
}
