using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Problema_de_introducción
{
    internal class Program
    {

        #region Variables 
        static int acumulador = 0;
        static int contador = 0;
        static int maximo = 0;
        static int minimo = 0;
        #endregion

        #region Registrar Valores
        static void RegistrarValor(int n)
        {
            acumulador += n;
            contador++;

            if (maximo == 0 && minimo == 0)
            {
                maximo = n;
                minimo = n;

            }
            else
            {

                if (n > maximo)
                    maximo = n;

                if (n < minimo)
                    minimo = n;
            }                    
        }
        #endregion

        #region Mostrar Numero
        private static void  MostrarSolicitarNumero()
        {
            //1
            Console.WriteLine("Ingrese un numero");
            int n =Convert.ToInt32(Console.ReadLine());
            RegistrarValor(n);
            
           
        }
        #endregion

        #region MostrarVariosNMumeros
        private static void MostrarSolictarVariosNums()
        {
            //2
            Console.WriteLine("Ingrese cantidad de ingresos");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese numero");
                int n = Convert.ToInt32(Console.ReadLine());
                RegistrarValor(n);
            }

        }
        #endregion

        #region Mostrar MinYMax
        private static void MostrarMinMax()
        {
            //3
           Console.WriteLine("MAXIMO: {0} // MINIMO: {1}",maximo,minimo);
        }
        #endregion

        #region Mostrar Promedio
        static double MostrarYCalcularPromedio(double acumulador, int contador)
        {
            //4
            if (acumulador == 0)
            {
                Console.WriteLine("Divison por 0");
                return 0;
            }

            double promedio = acumulador / contador;

            Console.WriteLine("Promedio: " + promedio);
            return promedio;
        }
        #endregion

        #region Mostrar Cantidad Numeros
        private static void MostrarCantidadNumeros ()
        {
            //5
            Console.WriteLine("Cantidad de numeros ingresados: " + contador);
        }
        #endregion

        #region Inciar Variables
        private static void IniciarVariables()
        {
            //6
            
            acumulador = 0;
            contador = 0;
            maximo = 0;
            minimo = 0;
            Console.WriteLine("Aprete Enter");
            Console.ReadKey();
        }
        #endregion



        static void Main(string[] args)
        {
            Console.WriteLine("1- Procesar un solo número\r\n2- Procesar varios números\r\n3- Mostrar máximo y mínimo.\r\n4- Mostrar promedio.\r\n5- Mostrar cantidad de números ingresados.\r\n6- Reiniciar variables.\r\n");
            Console.WriteLine("Ingrese opcion (0 para salir)");
            int opc = Convert.ToInt32(Console.ReadLine());
            

            while (opc != 0)
            {
                               

                switch (opc)
                {
                    case 1: MostrarSolicitarNumero(); break;

                    case 2: MostrarSolictarVariosNums(); break;

                    case 3: MostrarMinMax(); break;

                    case 4: MostrarYCalcularPromedio(acumulador, contador); break;

                    case 5: MostrarCantidadNumeros(); break;

                    case 6: IniciarVariables(); break;

                    default: break;
                }

                Console.WriteLine("Ingrese opcion (0 para salir)");
                opc = Convert.ToInt32(Console.ReadLine());

            } 

        }
    }
}
