using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Actividad4
    {
        public static void Main2(string[] args)
        {

        }
        public class Empleado
        {
            public string? nombre;
            public string? telefono;
            public string? email;
            public int dni;
            public int sueldo;

            public Empleado(string? nombre, string? telefono, string? email, int dni, int sueldo)
            {
                this.nombre = nombre;
                this.telefono = telefono;
                this.email = email;
                this.dni = dni;
                this.sueldo = sueldo;
            }
        }
        public class Programador: Empleado
        {
            public string? lenguaje;
            public string? tipoDesarrollador;
            public int produccion;

            public Programador(string? nombre, string? telefono, string? email, int dni, int sueldo, string? lenguaje, string? tipoDesarrollador, int produccion) : base(nombre, telefono, email, dni,sueldo)
            {
                this.lenguaje = lenguaje;
                this.tipoDesarrollador = tipoDesarrollador ;
                this.produccion = produccion;

            }
            public void mostrarInfo()
            {
                Console.WriteLine($"El nombre del empleadoes: {nombre}");
                Console.WriteLine($"El telefonor del empleado es: {telefono}");
                Console.WriteLine($"El email del empleado es: {email}");
                Console.WriteLine($"El dnai del empleado es: {dni}");
                Console.WriteLine($"El sueldo del empleado es: {sueldo}");
                Console.WriteLine($"El lenguaje es: {lenguaje}");
                Console.WriteLine($"El tipo de desarrollador es: {tipoDesarrollador}");
                Console.WriteLine($"Está en producción: {produccion}");
            }
        }
        public class DptoSistema
        {
            public string? areaDeTrabajo;
            public string? tituloDeTrabajo;
            public string? computadoraLboral;
            public int cantidadDeGente; 
        }

    }
}
/*4) Definir la clase Empleado, con nombre, apellido, telefono, email, dni y sueldo.
Definir la clase DptoSistemas (para el Departamento de Sistemas) que posea el área en la
que trabaja de Sistemas, si posee titulo relacionado a su trabajo, si posee una computadora laboral a
su cargo y cantidad de gente a cargo.
Definir la clase Programador donde se almacene en que lenguaje de programación trabaja, si
es senior, semisenior o junior y la cantidad de veces que tumbó producción.
Crear un método mostrar información del empleado en la clase Programador donde muestre
toda la información requerida.*/
