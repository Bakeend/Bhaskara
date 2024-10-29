using System;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Indentifique os valores da questão. \nexemplo:");
            Console.WriteLine("a = x² \nb = 10x \nc = 10");
            Thread.Sleep(7000);
            Console.Clear();
            Console.Write("Insire os valores:");
            string[] vet = Console.ReadLine().Split(' ');
            double x = Convert.ToDouble(vet[0]);
            double y = Convert.ToDouble(vet[1]);
            double z = Convert.ToDouble(vet[2]);

            double delta = Math.Pow(y, 2) - 4*x*z;
            
            Console.WriteLine("Valor de delta é " + delta);
            delta =  Math.Sqrt(delta);
            double x1, x2;

            x1 = (-y + delta) / (2 * x);
            x2 = (-y - delta) / (2 * x);

            Console.WriteLine("x1 = " + x1 + "\nx2 = " + x2); 
        
        }
    }
}