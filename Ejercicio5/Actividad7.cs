using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Actividad7
    {
        public static void Main1(string[] args)
        {
            Vagon vagon = new Vagon();
            vagon.ascelerar(1000);
            vagon.frenar();
            vagon.vagonLleno();
        }
        public class Tren
        {
            public void ascelerar(int velocidad)
            {
                int numero = 0;
                while (numero != velocidad)
                {
                    
                    Console.WriteLine($"La velociadad es de {numero++} km");
                }
                Console.WriteLine($"La velociadad es de {numero} km ");
                velocidad = numero;
            }
            public void frenar()
            {
                Console.WriteLine($"la velocidad esta disminuyendo porque esta frenando");

            }

        }
        public class Vagon: Tren
        {
            public void vagonLleno()
            {
                Console.WriteLine("El vango esta lleno");
            }
        }
    }
}
/*7) Definir la clase Tren y su hija, Vagón. Se deben crear los métodos vagonLleno, ascelerar(int
velocidad) y frenar*/