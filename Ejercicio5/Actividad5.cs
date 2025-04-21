using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Actividad5
    {
        public static void Main5(string[] args)
        {
            Ambiente desarrollo = new Ambiente("linux", 4, "postgresql", "openjdk");
            Ambiente testing = new Ambiente("Linux", 4, "postgresql", "openjdk");
            Ambiente preProduccion = new Ambiente("Windows", 8, "mysql", "netframework");
            Ambiente produccion = new Ambiente("Linux", 16, "postgresql", "openjdk");
            desarrollo.verificarDespliegue();
            testing.verificarDespliegue();
            preProduccion.verificarDespliegue();
            produccion.verificarDespliegue();  
        }
        public class Ambiente
        {
            public string sistema_operativo;
            public int ram;
            public string base_datos;
            public string app;

            public Ambiente ( string sistema_operativo, int ram, string base_datos, string app)
            {
                this.sistema_operativo = sistema_operativo;
                this.ram = ram; 
                this.base_datos = base_datos;
                this.app = app;
            }
            public void verificarDespliegue()
            {
                if(sistema_operativo.Equals("linux") && ram == 4 && base_datos.Equals("postgresql") && app.Equals("openjdk"))
                {
                    Console.WriteLine("El despliegue se puede realizar");
                }
                else
                {
                    Console.WriteLine("El despliegue no se puede realizar");
                }
            }
        }
    }
}
/*5) Definir la clase Ambiente y generar los objetos: “Desarrollo”, “Testing”, “Preproduccion” y/+
“Produccion” que posea un método que sea verificarDespliegue y comprobar que la información
del Ambiente sea igual a: “sistema_operativo: linux, ram: 4, base_datos: postgresql, app: openjdk”,
si es correcto mostrar por pantalla que el despliegue se puede realizar, de lo contrario, mostrar que
no será posible realizar el despliegue.*/ 
