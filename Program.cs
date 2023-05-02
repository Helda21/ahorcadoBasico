using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static string letras;
        static int puntosTotales = 0;
        static string nombre;
        static void Main(string[] args)
        {
            datosUsuario();
            juego();
            puntaje();
        }



        public static void datosUsuario()
        {
            Console.WriteLine("Por favor digite su nombre: ");
            nombre = Console.ReadLine();

        }

        public static void juego()
        {
            string letra1 = "a";
            string letra2 = "u";
            string letra3 = "t";
            string letra4 = "o";
            string letra5 = "m";
            string letra6 = "o";
            string letra7 = "v";
            string letra8 = "i";
            string letra9 = "l";

            Console.WriteLine("Juego del ahorcado!!!");
            Console.WriteLine("---------------------");
            Console.WriteLine("AHORCADO HELIO ESPINOSA");
            Console.WriteLine("¡¡EMPECEMOS!!");


            Console.WriteLine("Pista: tiene 9 letras... y es muy conocido ");
            
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Escribe una letra: ");
                letras = Console.ReadLine();
                if (letras == letra1)
                {
                    Console.WriteLine("Excelente: " + letra1);
                    puntosTotales =+ 1;

                }else if (letras == letra2)
                {
                    Console.WriteLine("Excelente: "+ letra2);
                    puntosTotales =+ 1;

                }
                else if(letras == letra3)
                {
                    Console.WriteLine("Excelente: "+ letra3);
                    puntosTotales =+ 1;
                }
                else if(letras == letra4)
                {
                    Console.WriteLine("Excelente: " + letra4);
                    puntosTotales =+ 1;

                }
                else if(letras == letra5)
                {
                    Console.WriteLine("Excelente: "+ letra5);
                    puntosTotales =+ 1;
                }
                else if(letras == letra6)
                {
                    Console.WriteLine("Excelente: " + letra6);
                    puntosTotales =+ 1;

                }
                else if(letras == letra7)
                {
                    Console.WriteLine("Excelente: "+ letra7);
                    puntosTotales =+ 1;

                }
                else if(letras == letra8)
                {
                    Console.WriteLine("Excelente: "+ letra8);
                    puntosTotales =+ 1;
                }
                else if(letras == letra9){
                    Console.WriteLine("Excelente: "+ letra9);
                    puntosTotales =+ 1;
                }
                else if(letras != letra1)
                {
                    Console.WriteLine("Ups!! la palabra no es... ");
                    puntosTotales =- 1;

                }else if(letras != letra2)
                {
                    Console.WriteLine("Ups!! la palabra no es... ");
                    puntosTotales =- 1;
                }else if (letras != letra3)
                {
                    Console.WriteLine("Ups!! la palabra no es... ");
                    puntosTotales =- 1;
                }else if(letras!= letra4)
                {
                    Console.WriteLine("Ups!! la palabra no es... ");
                    puntosTotales =- 1;
                }else if(letras != letra5)
                {
                    Console.WriteLine("Ups!! la palabra no es... ");
                    puntosTotales =- 1;
                }else if(letras != letra6)
                {
                    Console.WriteLine("Ups!! la palabra no es... ");
                    puntosTotales =- 1;
                }else if(letras != letra7)
                {
                    Console.WriteLine("Ups!! la palabra no es... ");
                    puntosTotales =- 1;
                }else if(letras != letra8)
                {
                    Console.WriteLine("Ups!! la palabra no es... ");
                    puntosTotales =- 1;
                }else if (letras!= letra9)
                {
                    Console.WriteLine("Ups!! la palabra no es... ");
                    puntosTotales =- 1;
                }

            }
        
        }

        public static void puntaje()
        {
            Console.WriteLine("Sus puntos totales son: "+ puntosTotales);
        }


    }
}
