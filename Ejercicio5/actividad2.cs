using System;

namespace actividad1 {

    class Program
    {

        public static void Main1(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.basesita = 12;
            cuadrado.altura = 22;
            cuadrado.mostrarArea(); 

        }
        public class Figura
        {
            public double basesita;
            public double altura;
            public double radio; 
            public virtual void mostrarArea()
            {

            }
        }
        public class Cuadrado : Figura
        {
            
            public override void mostrarArea()
            {
                double  area = basesita * altura;
                Console.WriteLine("El area del cuadrado es de: " + area );
            }

        }
        public class Triangulo:Figura
        {

            public override void mostrarArea()
            {
                double area = basesita * altura / 2;
                Console.WriteLine("El area del triangulo es: " + area); 
            }
        }
        public class Circulo: Figura
        {

            public override void mostrarArea()
            {
               double area =Math.Round(  Math.PI * Math.Pow( radio  , 2), 2);
                Console.WriteLine("El area del circulo es de: " + area);        
            }
        }
       
    }
}
/*2) Se requiere un programa que nos ayude a calcular el área de un Triangulo, de un Cuadrado y de
un Circulo y que éstas clases dependan de la clase Figura, la cual debe tener un método que sea
mostrarArea, donde debe consulte el valor de la variable area y si no es nulo, mostrar por consola
el valor.*/