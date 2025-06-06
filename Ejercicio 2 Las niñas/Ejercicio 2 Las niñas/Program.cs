using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_Las_niñas
{
    internal class Program
    {

        #region Variables
        static int edad0=0;
        static int edad1=0;
        static int edad2=0;
        static int edad3=0;
        static double monto=0;
        static double porc0=0;
        static double porc1=0;
        static double porc2=0;
        static double porc3=0;
        static double mon0=0;
        static double mon1=0;
        static double mon2=0;
        static double mon3=0;
        #endregion

        #region RegistrarMontoARepatir 
        static void RegistrarMontoARepartir()
        {       
            monto = Convert.ToDouble(Console.ReadLine());
        }
        #endregion

        #region RegistrarEdad 
        static void RegistrarEdad()
        {
            edad0 = Convert.ToInt32(Console.ReadLine());
            edad1 = Convert.ToInt32(Console.ReadLine());
            edad2 = Convert.ToInt32(Console.ReadLine());
            edad3 = Convert.ToInt32(Console.ReadLine());

        }
        #endregion

        #region CalcularMontosYPorcentajes
        static void CalcularMontosYPorcentajes()
        {
            int totalEdad = edad0 + edad1 + edad2 + edad3;
           
            porc0 = (double)edad0 / totalEdad;
            porc1 = (double)edad1 / totalEdad;
            porc2 = (double)edad2 / totalEdad;
            porc3 = (double)edad3 / totalEdad;

            mon0 = porc0 * monto;
            mon1 = porc1 * monto;
            mon2 = porc2 * monto;
            mon3 = porc3 * monto;
        }
        #endregion

        #region MostrarPantallaSolicitarOpcionMenu 
        static void Menu()
        {
            Console.WriteLine("Menu (0 para salir)");
            Console.WriteLine("1- Iniciar Monto a repartir");
            Console.WriteLine("2- Solicitar Edad Por niña");
            Console.WriteLine("3- Mostrar monto y porcentajes que corresponde a cada niña");
        }
        #endregion

        #region MostrarPantallaSolicitarMontoARepartir
        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.WriteLine("Ingrese monto a repartir");
            RegistrarMontoARepartir();
        }
        #endregion 

        #region MostrarPantallaEdades
        static void MostrarEnPatanllaMostrarEdades()
        {
            Console.WriteLine("Ingrese edades de las niñas");
            
            RegistrarEdad();
        }
        #endregion

        #region MostrarPorcentajeYMonto
        static void MostrarPorcentajeYMonto()
        {
            CalcularMontosYPorcentajes();

            Console.WriteLine("Niña 1: Edad {0} // Porcentaje Segun Edad {1}% // Monto A Recibir {2} ", edad0, porc0, mon0);
            Console.WriteLine("Niña 1: Edad {0} // Porcentaje Segun Edad {1}% // Monto A Recibir {2} ", edad1, porc1, mon1);
            Console.WriteLine("Niña 1: Edad {0} // Porcentaje Segun Edad {1}% // Monto A Recibir {2} ", edad2, porc2, mon2);
            Console.WriteLine("Niña 1: Edad {0} // Porcentaje Segun Edad {1}% // Monto A Recibir {2} ", edad3, porc3, mon3);
        }
        #endregion 

        static void Main(string[] args)
        {
            Menu();
            Console.WriteLine("Ingrese opcion");
            int opc = Convert.ToInt32(Console.ReadLine());

            while (opc != 0)
            {

                switch (opc)
                {
                    case 1: MostrarPantallaSolicitarMontoARepartir(); break;

                    case 2: MostrarEnPatanllaMostrarEdades(); break;

                    case 3: MostrarPorcentajeYMonto(); break;

                    case 0: break;
                }

                Console.WriteLine("Ingrese opcion (0 para salir)");
                opc = Convert.ToInt32(Console.ReadLine());


            }


        }
    }
}
