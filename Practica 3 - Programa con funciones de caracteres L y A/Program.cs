using System;
using System.Linq;
using System.Threading;

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
            //Presentacion del programa
            Presentacion();
            //Se carga el menu principal
            Menu.MenuPrincipal();
        }

        /// <summary>
        /// Esta parte del programa unicamente muestra los datos del programa, asi como
        /// sus integrantes y datos agregados de la materia.
        /// </summary>
        static public void Presentacion()
        {
            Console.Clear();
            Console.Title = "PRACTICA 3 PROGRAMA CON FUNCIONES DE CARACTERES";
            Console.WriteLine($" Instituto Tecnológico Superior de Lerdo");
            Console.WriteLine($" Sexto Semestre Enero - Junio 2022");
            Console.WriteLine($" Lenguajes y Automatas I 1X6A");
            Console.WriteLine($" Docente: Lic. Roberto Garcia");
            Console.WriteLine($" Alumno: Arguijo Vazquez Edgar Eduardo - No. Control: 192310252");
            Console.WriteLine($" Alumno: Carreon Pulido Victor Hugo - No. Control: 192310436");
            Console.WriteLine($" Alumno: Mejia Rubio Andrea Evelyn - No. Control: 192310177");
            Console.Write("\n Presione cualquier tecla para continuar: ");
            Console.ReadKey();
        }


        /// <summary>
        /// Este apartado solicita la cadena la cual se va almacenar un una variable
        /// </summary>
        /// <param name="cadena">Variable donde se va almacenar la cadena</param>
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

        /// <summary>
        /// Este apartado realiza todas las funciones solicitadas
        /// </summary>
        /// <param name="cad1">cadena 1</param>
        /// <param name="cad2">cadena 2</param>
        internal static void Funciones(string cad1, string cad2)
        {
            Console.Clear();
            Console.Title = "Funciones";

            //Imprime la longitud de la cadena 1
            Console.WriteLine($"La cadena 1 tiene {cad1.Length} caracteres");
            //Imprime la longitud de la cadena 2
            Console.WriteLine($"La cadena 2 tiene {cad2.Length} caracteres");

            //Concatena en orden 1 y 2 las cadenas
            Console.Write("La concatenación de cadena 1 y cadena 2 queda así: ");
            Escribir(cad1, cad2);

            Console.WriteLine("");

            //Concatena en orden 2 y 1 las cadenas
            Console.Write("La concatenación de cadena 2 y cadena 1 queda así: ");
            Escribir(cad2, cad1);

            Console.WriteLine("");

            //Imprime la primer y ultimo caracter de la cadena 1
            Console.WriteLine($"La primera y última letras de la cadena 1 son {cad1.FirstOrDefault()} y {cad1.LastOrDefault()}");
            //Imprime la primer y ultimo caracter de la cadena 2
            Console.WriteLine($"La primera y última letras de la cadena 2 son {cad2.FirstOrDefault()} y {cad2.LastOrDefault()}");

            //Combina ambas cadenas
            Console.WriteLine($"La mezcla de la cadena 1 y 2 queda así: {CombinarCadenas(cad1, cad2)}");

            Console.ReadKey();
        }

        /// <summary>
        /// Combina las cadenas de tal forma que no se exceda la longitud de ambas.
        /// </summary>
        /// <param name="cad1">Cadena 1</param>
        /// <param name="cad2">Cadena 2</param>
        /// <returns>Cadena combinada</returns>
        private static object CombinarCadenas(string cad1, string cad2)
        {
            //Cadena auxiliar
            string auxiliar = string.Empty;

            //Ciclo for, en caso de que cadena1>cadena2 entonces limite = longitud de cadena 1
            //si no limite = longitud de cadena 2
            for (int i = 0; i < (cad1.Length > cad2.Length ? cad1.Length : cad2.Length); i++)
            {
                //Si contador menor que longitud de cadena1
                //Entonces auxiliar = auxiliar + cadena1[i]
                if (i < cad1.Length)
                    auxiliar += cad1[i];

                //Si contador menor que longitud de cadena1
                //Entonces auxiliar = auxiliar + cadena2[i]
                if (i < cad2.Length)
                    auxiliar += cad2[i];
            }
            //Devuelve la cadena auxiliar
            return auxiliar;
        }

        /// <summary>
        /// Escribe 2 cadenas en orden 1,2
        /// </summary>
        /// <param name="cad1">Cadena 1</param>
        /// <param name="cad2">Cadena 2</param>
        private static void Escribir(string cad1, string cad2)
        {
            Console.Write(cad1);
            Console.Write(cad2);
        }
    }

    internal class Menu
    {
        /// <summary>
        /// Imprime el menu principal, e interactua con el usuario segun la opcion a elegir
        /// </summary>
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

                        //Numero "1" en teclado o teclado numerico
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            Programa.Presentacion();
                            break;

                        //Numero "2" en teclado o teclado numerico
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            Programa.SolicitarCadena(ref cadena1);
                            break;

                        //Numero "3" en teclado o teclado numerico
                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            Programa.SolicitarCadena(ref cadena2);
                            break;

                        //Numero "4" en teclado o teclado numerico
                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            Programa.Funciones(cadena1, cadena2);
                            break;

                        //Numero "5" en teclado o teclado numerico
                        case ConsoleKey.D5:
                        case ConsoleKey.NumPad5:
                            Environment.Exit(0);
                            break;

                        //En caso de no elegir una opcion valida
                        default:
                            MsmError();
                            Thread.Sleep(1000);
                            break;
                    }
                }
                catch (FormatException)
                {
                    //En caso de tener un error de formato
                    MsmError();
                }
            } while (true);
        }

        /// <summary>
        /// Mensaje en caso de existir un erreor de formato
        /// </summary>
        private static void MsmError()
        {
            Console.Clear();
            Console.Write("Por favor ingresa una opcion valida");
        }
    }
}
