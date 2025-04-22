using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Actividad1
    {
        public static void Main1(string[] args)
        {
            Bebida bebida = new Bebida();
            bebida.marca = "pepsi";
            bebida.stock = 20;
            bebida.precioPorUnidad = 10;
            bebida.ventaDeProducto(5);
            Alimento alimento = new Alimento();
            alimento.marca = "Don satur";
            alimento.stock = 1000;
            alimento.precioPorUnidad = 20;
            alimento.ventaDeProducto(30); 
        }
        public class Producto
        {
            public int stock;
            public string marca;
            public int precioPorUnidad; 
            public virtual void ventaDeProducto(int cantidad)
            {  
                this.stock = stock - cantidad;
            }
        }
        public class Bebida: Producto
        {
            public override void ventaDeProducto(int cantidad)
            {
                base.ventaDeProducto(cantidad);

                Console.WriteLine($"El precio de la bebida {marca}, es de {precioPorUnidad}, y seria en total {precioPorUnidad*cantidad} ");
            }
        }
        public class Alimento : Producto
        {
            public override void ventaDeProducto(int cantidad)
            {
                base.ventaDeProducto(cantidad);
                Console.WriteLine($"El precio de la bebida {marca}, es de {precioPorUnidad}, y seria en total {precioPorUnidad * cantidad} ");
            }
        }
    }
}
