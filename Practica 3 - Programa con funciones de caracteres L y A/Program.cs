using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practica_3___Programa_con_funciones_de_caracteres_L_y_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programa obj = new Programa();
            obj.Main();
        }
    }

    internal class Programa
    {
        

        public void Main()
        {
            Presentacion();
            Menu.MenuPrincipal();
        }

        static public void Presentacion()
        {
            Console.Clear();
            Console.Title = "PRACTICA 3 PROGRAMA CON FUNCIONES DE CARACTERES";
            Console.WriteLine($" Instituto Tecnológico Superior de Lerdo");
            Console.WriteLine($" Sexto Semestre Enero - Junio 2022");
            Console.WriteLine($" Lenguajes y Automatas I 1X6A");
            Console.WriteLine($" Docente: Lic. Roberto Garcia");
            Console.WriteLine($" Alumno: Carreon Pulido Victor Hugo - No. Control: 192310436");
            Console.Write("\n Presione cualquier tecla para continuar: ");
            Console.ReadKey();
        }

        internal static void SolicitarCadena(ref string cadena)
        {
            Console.Clear();
            Console.Title = "Ingrese una cadena";


            if (cadena == null | cadena == "")
            {
                Console.Write("Ingrese cadena: ");
                cadena = Console.ReadLine();
            }
            else
            {
                Console.Write($"Cadena actual: {cadena.ToString()}\n");
                Console.Write($"Nueva cadena: ");
                cadena = Console.ReadLine();
            }
        }

        internal static void Funciones(string cad1, string cad2)
        {
            Console.Clear();
            Console.Title = "Funciones";

            Console.WriteLine($"La cadena 1 tiene {cad1.Length} caracteres");
            Console.WriteLine($"La cadena 2 tiene {cad2.Length} caracteres");

            Console.Write("La concatenación de cadena 1 y cadena 2 queda así: ");
            Escribir(cad1, cad2);

            Console.WriteLine("");

            Console.Write("La concatenación de cadena 2 y cadena 1 queda así: ");
            Escribir(cad2, cad1);

            Console.WriteLine("");

            Console.WriteLine($"La primera y última letras de la cadena 1 son {cad1.FirstOrDefault()} y {cad1.LastOrDefault()}");
            Console.WriteLine($"La primera y última letras de la cadena 2 son {cad2.FirstOrDefault()} y {cad2.LastOrDefault()}");

            Console.WriteLine($"La mezcla de la cadena 1 y 2 queda así: {CombinarCadenas(cad1, cad2)}");

            Console.ReadKey();
        }

        private static object CombinarCadenas(string cad1, string cad2)
        {
            string mixedWord = string.Empty;

            for (int i = 0; i < (cad1.Length > cad2.Length ? cad1.Length : cad2.Length); i++)
            {
                if (i < cad1.Length)
                    mixedWord += cad1[i];

                if (i < cad2.Length)
                    mixedWord += cad2[i];
            }

            return mixedWord;
        }

        private static void Escribir(string cad1, string cad2)
        {
            Console.Write(cad1);
            Console.Write(cad2);
        }
    }

    internal class Menu
    {
        internal static void MenuPrincipal()
        {
            string cadena1 = "";
            string cadena2 = "";

            do
            {
                try
                {
                    Console.Title = "Menu Principal";
                    Console.Clear();
                    Console.WriteLine("**************************** Menú Principal *****************************");
                    Console.WriteLine("* 1.-Informacion del Programa\t\t\t\t\t\t*");
                    Console.WriteLine("* 2.-Ingresar primer cadena\t\t\t\t\t\t*");
                    Console.WriteLine("* 3.-Ingresar segunda cadena\t\t\t\t\t\t*");
                    Console.WriteLine("* 4.-Ejecutar funciones\t\t\t\t\t\t\t*");
                    Console.WriteLine("* 5.-Salir del programa\t\t\t\t\t\t\t*");
                    Console.WriteLine("*************************************************************************");

                    Console.Write("\n Porfavor ingrese una opcion: ");

                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            Programa.Presentacion();
                            break;

                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            Programa.SolicitarCadena(ref cadena1);
                            break;

                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            Programa.SolicitarCadena(ref cadena2);
                            break;

                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            Programa.Funciones(cadena1, cadena2);
                            break;

                        case ConsoleKey.D5:
                        case ConsoleKey.NumPad5:
                            Environment.Exit(0);
                            break;

                        default:
                            MsmError();
                            Thread.Sleep(1000);
                            break;
                    }
                }
                catch (FormatException)
                {
                    MsmError();
                }

            } while (true);

        }

        private static void MsmError()
        {
            Console.Clear();
            Console.Write("Por favor ingresa una opcion valida");
        }
    }
}
