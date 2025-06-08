using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Tenis
{
    internal class Program
    {

        //Variables
        
            static string jugador1;
            static string jugador2;
            static int setG1=0;
            static int setG2=0;
        static int s1j1, s1j2, s2j1, s2j2, s3j1, s3j2;

        static int Menu()
        {
            Console.Clear();
            int opc;
            Console.WriteLine("Menu");
            Console.WriteLine("1- Registrar los nombres de los dos jugadores");
            Console.WriteLine("2- Registrar los resultados de cada set de los jugadores");
            Console.WriteLine("3- Mostrar el ganador");
            Console.WriteLine("4- Mostrar resultados cada set");

            Console.WriteLine("Ingrese opcion: ");
            opc = Convert.ToInt32(Console.ReadLine());

            return opc;
        }
        static void SolicitarNombres()
        {
            Console.WriteLine("Ingrese nombre del Jugador 1: ");
            string nom1=Console.ReadLine(); 

            Console.WriteLine("Ingrese nombre del Jugador 2: ");
            string nom2=Console.ReadLine();

            RegistrarJugadores(nom1,nom2);
        }

        static void ResultadosSet ()
        {          

            Console.WriteLine("Jugador 1: {0} Jugador 2: {1}", jugador1, jugador2);
            Console.WriteLine("Set 1:     {0} // {1}", s1j1, s1j2);
            Console.WriteLine("Set 2:     {0} // {1}", s2j1, s2j2);
            Console.WriteLine("Set 3:     {0} // {1}", s3j1, s3j2);
        
        }
        static void RegistrarJugadores(string nom1, string nom2)
        {
            jugador1= nom1;
            jugador2= nom2; 
           
        }

        static void RegistrarResultados()
        {
           
            double wins1, wins2, wins3;

            Console.WriteLine("Ingrese puntaje del primer set (jug1 y jug2)");
            s1j1 = Convert.ToInt32(Console.ReadLine());
            s1j2 = Convert.ToInt32(Console.ReadLine());
            wins1 = (s1j1 - s1j2);

            if (wins1 > 0)
            {
                setG1++;
            }
            else
            {
                setG2++;
            }

            Console.WriteLine("Ingrese puntaje del segundo set (jug1 y jug2)");
            s2j1 = Convert.ToInt32(Console.ReadLine());
            s2j2 = Convert.ToInt32(Console.ReadLine());

            wins2 = (s2j1 - s2j2);

            if (wins2 > 0)
            {
                setG1++;
            }
            else
            {
                setG2++;
            }

            Console.WriteLine("Ingrese puntaje del tercer set (jug1 y jug2)");
            s3j1 = Convert.ToInt32(Console.ReadLine());
            s3j2 = Convert.ToInt32(Console.ReadLine());

            wins3 = (s3j1 - s3j2);

            if (wins3 > 0)
            {
                setG1++;
            }
            else
            {
                setG2++;
            }

            
        }

        static void DeterminarGanador()
        {
            
            if (setG1 > setG2)
            {
                Console.WriteLine("Ganador: {0}", jugador1);
            }
            else
            {
                Console.WriteLine("Ganador: {0}", jugador2);
            }
        }

        static void Main(string[] args)
        {
            int opc = Menu();

          
            while (opc!=5)
            {
                

                switch (opc)
                {
                    
                    case 1: SolicitarNombres(); break;

                    case 2: RegistrarResultados(); break;

                    case 3: DeterminarGanador();  break;

                    case 4: ResultadosSet(); break;

                    case 5: Console.WriteLine("Fin"); 
                    break;

                    default: Console.WriteLine("Opcion Incorrecta"); break;
                }

                Console.WriteLine("Presione cualquier tecla");
                Console.ReadKey();
                opc = Menu();
            }

                   

        }
    }
}
