using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Actividad6
    {
        public static void Main1(string[] args)
        {
            Persona persona1 = new Persona("Sofia", 80);
            Persona persona2 = new Persona("Tobias" ,30);
            persona1.compararEdad(persona1.nombre,persona1.edad, persona2.nombre,persona2.edad);

        }
        public class Persona
        {
            public string nombre; 
            public int edad;

            public Persona(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }

            public void compararEdad(string nombre1,int edad1, string nombre2, int edad2) {

                if (edad1 > edad2)
                {
                    Console.WriteLine($"{nombre1} tiene {edad1} y es mayor que {nombre2} que tiene {edad2}");


                }
                else
                {
                    Console.WriteLine($"{nombre2} tiene {edad2} y es  mayor que {nombre1} que tiene {edad1}");
                }
            }
        } 
    }
}
