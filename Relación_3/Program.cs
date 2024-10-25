using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relación_3

    internal class Program
    {
        static void Main(string[] args)
        {
            ej9();
        }

        static void ej1()
        {
            Console.Write("Introduzca el tamaño del array: ");
            int size;
            int valor = 0;
            int[] list = new int[0];

            if (int.TryParse(Console.ReadLine(), out size))
            {
                list = new int[size];
                Console.WriteLine("Introduzca los valores del array: ");
                for (int i = 0; i < list.Length; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out valor))
                    {
                        list[i] = valor; 
                    }
                    else
                    {
                        Console.WriteLine("Valor no válido. Intente nuevamente.");
                        i--;
                    }
                }
            }

            int suma = 0;

            for (int i = 0; i < list.Length; i++)
            {
                suma += list[i];
            }

            Console.WriteLine("La suma total de los valores es: " + suma);

            if (list.Length > 0)
            {
                double media = (double)suma / list.Length;
                Console.WriteLine("La media total de los valores es: " + media);
            }
            else
            {
                Console.WriteLine("No se puede calcular la media porque no hay valores en el array.");
            }
        }

        static int ej2()
        {
            Console.WriteLine("Introduzca una cadena de texto:");
            String cadena = Console.ReadLine();

            int espaciosTotales = 0;

            for (int i = 0;i < cadena.Length; i++)
            {
                if (cadena[i] == ' ') espaciosTotales++;
            }
            return espaciosTotales;
        }

        static void ej3()
        {
            Console.Write("Introduzca un número: ");
            int num = Convert.ToInt16(Console.ReadLine());

            int fact = factorial(num);

            Console.WriteLine(fact);


        }

        static int factorial(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            else
                return num * factorial(num - 1);
        }

        static void ej4()
        {
            Console.WriteLine("Introduce un número: ");
            int num = Convert.ToInt16(Console.ReadLine());

            if (esPrimo(num))
                Console.WriteLine("Es primo");
            else
                Console.WriteLine("No es primo");


        }

        static bool esPrimo(int num) 
        {
            for (int i = 2; i <= num / 2; i++) {
                if (num % i == 0) {
                    return false;
                }
            }
            return true;
        }

        static void ej5()
        {
            Console.WriteLine("Introduzca base: ");
            int baseNum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Introduzca exponente: ");
            int expNum = Convert.ToInt16(Console.ReadLine());
            
            int recursiva = potenciaRecursiva(baseNum, expNum);
            Console.WriteLine("Potencia iterativa: " + potenciaIterativa(baseNum, expNum));
            Console.WriteLine("Potencia Recursiva: " + recursiva);

        }

        static int potenciaIterativa(int baseExpo, int expNum)
        {
            int asd = 0;
            for (int i = 2; i <= expNum; i++)
            {
                asd = (baseExpo * baseExpo);
            }
            return asd;
        }

        static int potenciaRecursiva(int baseExpo, int expNum)
        {
            if (expNum == 0)
            {
                return 1;
            }

            return baseExpo * potenciaRecursiva(baseExpo, expNum - 1);
        }


        static void ej6()
        {
           

            for(int i = 2; i >= 0; i--)
            {
                Console.Write("Nombre de usuario: ");
                String user = Console.ReadLine();
                Console.Write("Constraseña: ");
                String pass = Console.ReadLine();

                if (login(user, pass))
                {
                    Console.WriteLine("Login completado.");
                } else
                {
                    Console.WriteLine("Credenciales incorrectas.");
                    Console.WriteLine($"Le quedan {i} intentos.");
                }
            }
        }

        static bool login(string user, string pass)
        {
            if (user=="usuario2DAM" && pass == "pass2DAM")
            {
                return true;
            }
            return false;
        }

        static void ej7()
        {
            Console.WriteLine("Introduzca num1: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Introduzca num2: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            if (esMultiplo(num1, num2))
                Console.WriteLine($"El {num1} es múltiplo de {num2}.");
            else
                Console.WriteLine($"El {num1} no es múltiplo de {num2}.");
        }
        
        static bool esMultiplo(int num1, int num2)
        {
            if (num1 % num2 == 0)
                return true;

            return false;
        }

        static void ej8()
        {
            Console.WriteLine("Introduzca número: ");
            String num = Console.ReadLine();

            int[] numPartido = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                numPartido[i] = Convert.ToInt32(num[i].ToString());
            }
            Console.WriteLine("La suma de los dígitos del número es: " + calculaSuma(numPartido));
        }

        static int calculaSuma(int[] numPartido)
        {
            int suma = 0;
            for (int i = 0; i < numPartido.Length; i++)
            {
                suma += numPartido[i];
                Console.WriteLine(numPartido[i]);
            }
            return suma;
        }

        static void ej9()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

            int menor = 99;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < menor) menor = numbers[i];
            }

            Console.WriteLine("El número menor del array es " + menor);
            
        }

        class Cliente
        {
            private string nombre;
            private int cantidadTotal;

            public Cliente(string nombre, int cantidadTotal) { 
                this.nombre = nombre;
                this.cantidadTotal = cantidadTotal;
            }



    }
}
