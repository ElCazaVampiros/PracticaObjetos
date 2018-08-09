using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaObjetos
{
    class Persona
    {
        // Atributos
        // Definidos a través de variables
        string nombre;
        string apellidos;
        string fechaNacimiento;
        int edad;
        float altura;

        // Métodos
        // Definidos a través de funciones
        void cumplirAños()
        {
            edad += 1;
        }

        void crecer(float cantidadCrecimiento)
        {
            altura += cantidadCrecimiento;
        }

    }
}
