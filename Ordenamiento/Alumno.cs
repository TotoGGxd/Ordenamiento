using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento
{
    class Alumno
    {
        string Nombre { get; set; }
        float Promedio { get; set;}
        int Faltas { get; set; }

        public Alumno(string nombre, float promedio, int faltas)
        {
            this.Nombre = nombre;
            this.Promedio = promedio;
            this.Faltas = faltas;
        }

        public override string ToString()
        {
            return this.Nombre + " (" + this.Promedio + ")";
        }
    }
}
