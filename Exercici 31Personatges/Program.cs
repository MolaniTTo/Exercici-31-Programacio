using System;
using System.Reflection.Metadata.Ecma335;
namespace Exercici31
{
    public class Exercici31Proj
    {
        public static void Main()
        {
            string personatge;
            int nombre; 
            const string MsgIntroPersonatge = "Amb quin personatge vols jugar?";
            const string MsgIntroNombre = "Introdueix un nombre entre l'1 i 500:";

            Console.WriteLine(MsgIntroPersonatge);
            personatge = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(ValidarPersonatge(personatge));

            Console.WriteLine(MsgIntroNombre);
            nombre=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ValidarNombre(nombre, MsgIntroNombre));

            Console.Write("Numero Random:" + RandomNumber());
            

        }

        public static bool ValidarPersonatge(string personatge)
        {
           int suma = 0;
           
           foreach (char c in personatge.ToCharArray())
           { suma++;}

           if (suma< 10) { Console.WriteLine("Personatge validat");return true; }
           else { Console.WriteLine("Personatge no validat, no pot superar 10 caracters");return false; }
        }

        public static bool ValidarNombre(int nombre, string MsgIntroNombre)
        {
            bool sortida=false;
            if(nombre <=500 && nombre>=1) { Console.WriteLine("Nombre validat");  return true; }
            else 
            {
                do
                {
                    Console.WriteLine(MsgIntroNombre);
                    nombre = Convert.ToInt32(Console.ReadLine());
                    if (nombre <= 500 && nombre >= 1) { sortida = true; return true; }

                } while (sortida != true);
                return true;
            }
            
        }
        public static int RandomNumber()
        {
            Random rnd = new Random();
            int number = 0;
            number = rnd.Next(1, 100);
            return number;
        }


    }
}

