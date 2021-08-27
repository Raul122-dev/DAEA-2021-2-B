using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjLab01_1
{
    class Program
    {
        //Funcion para calcular la suma de 2 numeros enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }
        //Funcion para calcular la resta de 2 numeros
        static int Resta(int a, int b)
        {
            return a - b;
        }
        //Funcion para calcular la multiplicacion de 2 numeros
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        //Funcion para calcular la division de 2 numeros
        static Decimal Division(int a, int b)
        {
            return Convert.ToDecimal(a) / Convert.ToDecimal(b);
        }
        //Funcion para mostrar los 10 primeros numeros primos
        static void NumerosPrimos()
        {
            int cont = 0;
            for (int i = 2; i <= 30; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }
                if (cont <= 2)
                {
                    Console.WriteLine("-  "+i+"  -");
                }
                cont = 0;
            }
        }
        //Procedimiento que imprime la raiz cuadrada de los 10 primero numeros
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("La raiz cuadrada de {0} es : {1}", i, Math.Sqrt(i));
            }
        }
        static void Main(string[] args)
        {
            //variables para los numeros
            int a;
            int b;

            Console.Title = "Procedimientos y Funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos numeros");
                Console.WriteLine("[2] Resta de dos numeros");
                Console.WriteLine("[3] Multiplicacion de dos numeros");
                Console.WriteLine("[4] Division de dos numeros");
                Console.WriteLine("[5] Imprimir la raiz cuadrada de los 10 primeros numeros enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros numero primos");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opcion y presion ENTER");
                opcion = Console.ReadLine();


                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer numero");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Ingrese el primer numero");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Resta de {0} y {1} es {2}", a, b, Resta(a, b));
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el primer numero");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Multiplicacion de {0} y {1} es {2}", a, b, Multiplicacion(a, b));
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el primer numero");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        b = Convert.ToInt32(Console.ReadLine());

                        if (b == 0)
                        {
                            Console.WriteLine("No se puede divir entre 0");
                        }
                        else { 
                            Console.WriteLine("La Division de {0} y {1} es {2}", a, b, Division(a, b));
                        }
                        
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando los 10 primeros numero primos...");
                        NumerosPrimos();
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
            
        }
    }
}
