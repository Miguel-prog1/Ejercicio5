using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Actividad3
    {
        public static void Main3(string[] args)
        {
            CuentaMayor cuentita = new CuentaMayor(222, "tobias", 1000, "activa", 8);
            cuentita.mostrarCuenta();
            cuentita.ingresarMonto(20);
            cuentita.retirarMonto(10);
            cuentita.esMayor();
            cuentita.mostrarCuenta();
        }
        public class Cuenta
        {
            public int nro_cuenta;
            public string? nombre;
            public int saldo;
            public string? estado_cuenta;

            public Cuenta(int nro_cuenta, string? nombre, int saldo, string? estado_cuenta)
            {
                this.nro_cuenta = nro_cuenta;
                this.nombre = nombre;
                this.saldo = saldo;
                this.estado_cuenta = estado_cuenta;
            }

            public int ingresarMonto(int monto)
            {
                saldo = monto + saldo;
                return saldo;
            }
            public void retirarMonto(int monto)
            {
                if (monto <= saldo)
                {
                    saldo = saldo - monto;
                }
                else
                {
                    Console.WriteLine("No cuenta con esa cantidad de plata en su cuenta");
                }

            }
            public void mostrarCuenta()
            {
                Console.WriteLine("El numero de la cuenta es: " + nro_cuenta);
                Console.WriteLine("El nombre del propietario de la cuenta es: " + nombre);
                Console.WriteLine("El saldo que tiene la cuenta es: " + saldo);
                Console.WriteLine("El estado de la cuenta es: " + estado_cuenta);
            }
        }
        public class CuentaMayor:Cuenta
        {
            public int edad ;
            public CuentaMayor(int nro_cuenta, string nombre, int saldo, string estado_cuenta, int edad) : base(nro_cuenta, nombre, saldo, estado_cuenta)
            {
                this.edad = edad; 
            }
            public void esMayor()
             {
                if (edad > 18)
                   {
                    Console.WriteLine("Eres mayor de edad"); 
                   }
                else
                {
                    Console.WriteLine("No eres mayor de edad");
                }
                   
             }
        }
        public class CuentaMenor :Cuenta
         {
            public CuentaMenor (int nro_cuenta, string nombre, int saldo, string estado_cuenta): base(nro_cuenta, nombre, saldo, estado_cuenta)
                {

                }
         }
        public class CuentaEstudiante:Cuenta
         {
            public CuentaEstudiante(int nro_cuenta, string nombre, int saldo, string estado_cuenta):base(nro_cuenta,nombre,saldo, estado_cuenta)
            {

            }
         }
        

    }
    
}


/*3)Se requiere que se defina la clase Cuenta con métodos que permitan ingresarMonto(int
montoASumar), retirarMonto(int montoARestar) mostrar información de la cuenta
(nro_cuenta, nombre, saldo, estado_cuenta) de la cuenta y definir las clases CuentaMayor,
CuentaMenor y CuentaEstudiante que puedan ejecutar estos métodos.
En el caso de CuentaMayor, crear un método que consulte si la persona es mayor de 18 años.*/
