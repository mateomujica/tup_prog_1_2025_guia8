using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Lista_Ordenada
{
    internal class Program
    {

        #region Variables
        static string nombre0;
        static int numeroLibreta0;
        static string nombre1;
        static int numeroLibreta1;
        static string nombre2;
        static int numeroLibreta2;

        #endregion

        #region RegistrarNombreYNumero
        static void RegistrarNombreYNumero(string nombre, int numLibreta, int orden)
        {
            switch (orden)
            {
                case 1:
                    nombre0 = nombre;
                    numeroLibreta0 = numLibreta;
                    break;
                case 2:
                    nombre1 = nombre;
                    numeroLibreta1 = numLibreta;
                    break;
                case 3:
                    nombre2 = nombre;
                    numeroLibreta2 = numLibreta;
                    break;
            }

        }
        #endregion

        #region MostrarPantallaSolicitarOpcionMenu
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();

            Console.WriteLine("Menu");
            Console.WriteLine("1- Registrar las notas de los tres alumnos");
            Console.WriteLine("2- Mostrar lista ordenada");
            Console.WriteLine("3- Salir");

            Console.WriteLine("Seleccione Opcion: ");
            int opc = Convert.ToInt32(Console.ReadLine());

            return opc;
        }
        #endregion 

        #region MostrarPantallaSolicitarAlumno

        static void MostrarPantallaSolicitarAlumno()
        {
            Console.Clear();

            for (int orden = 1; orden < 4; orden++)
            {

                Console.WriteLine("Ingrese nombre alumno {0}", orden);
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese nota alumno{0}", orden);
                int numLibreta = Convert.ToInt32(Console.ReadLine());
                RegistrarNombreYNumero(nombre, numLibreta, orden);
            }


        }

        #endregion

        #region MostrarPantallaMostrarListaOrdenada

        static void MostrarPantallaMostrarListaOrdenada()
        {          

            if (numeroLibreta0 > numeroLibreta1 && numeroLibreta1 > numeroLibreta2)
            {
                Console.WriteLine($"{nombre0} {numeroLibreta0}");
                Console.WriteLine($"{nombre1} {numeroLibreta1}");
                Console.WriteLine($"{nombre2} {numeroLibreta2}");
            }
            else if (numeroLibreta0 > numeroLibreta2 && numeroLibreta2 > numeroLibreta1)
            {
                Console.WriteLine($"{nombre0} {numeroLibreta0}");
                Console.WriteLine($"{nombre2} {numeroLibreta2}");
                Console.WriteLine($"{nombre1} {numeroLibreta1}");
            }
            else if (numeroLibreta1 > numeroLibreta0 && numeroLibreta0 > numeroLibreta2)
            {
                Console.WriteLine($"{nombre1} {numeroLibreta1}");
                Console.WriteLine($"{nombre0} {numeroLibreta0}");
                Console.WriteLine($"{nombre2} {numeroLibreta2}");
            }
            else if (numeroLibreta1 > numeroLibreta2 && numeroLibreta2 > numeroLibreta0)
            {
                Console.WriteLine($"{nombre1} {numeroLibreta1}");
                Console.WriteLine($"{nombre2} {numeroLibreta2}");
                Console.WriteLine($"{nombre0} {numeroLibreta0}");
            }
            else if (numeroLibreta2 > numeroLibreta0 && numeroLibreta0 > numeroLibreta1)
            {
                Console.WriteLine($"{nombre2} {numeroLibreta2}");
                Console.WriteLine($"{nombre0} {numeroLibreta0}");
                Console.WriteLine($"{nombre1} {numeroLibreta1}");
            }
            else if (numeroLibreta2 > numeroLibreta1 && numeroLibreta1 > numeroLibreta0)
            {
                Console.WriteLine($"{nombre2} {numeroLibreta2}");
                Console.WriteLine($"{nombre1} {numeroLibreta1}");
                Console.WriteLine($"{nombre0} {numeroLibreta0}");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        #endregion
        static void Main(string[] args)
        {
            int opc = MostrarPantallaSolicitarOpcionMenu();
            while (opc != 3)
            {
                switch (opc)
                {
                    case 1:
                        MostrarPantallaSolicitarAlumno();
                        break;
                    case 2:
                        MostrarPantallaMostrarListaOrdenada();
                        Console.WriteLine("Presione cualquier tecla para voler al Menu");
                        Console.ReadKey();
                        break;
                    default:
                        opc = 3;
                        break;
                }

                opc = MostrarPantallaSolicitarOpcionMenu();
            }





        }
    }
}




