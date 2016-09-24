using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {

            string PalabraAdivinar = ;
            string PalabaAdivinarUppercase = PalabraAdivinar.ToUpper();
            char Letra = ;
            int Intentos = 10;
            bool gano = false;
            int LetrasReveladas = 0;

            StringBuilder displayToPlayer = new StringBuilder(PalabraAdivinar.Length);
            for (int i = 0; i < PalabraAdivinar.Length; i++)
                displayToPlayer.Append('_');

            List<char> LetrasAdivinadas = new List<char>();
            List<char> LetrasErroneas = new List<char>();

            string input;
            char guess;

            while (!gano && Intentos > 0)
            {
                Console.Write("adivinar letra: ");

                input = Console.ReadLine().ToUpper();
                guess = input[0];

                if (LetrasAdivinadas.Contains(guess))
                {
                    Console.WriteLine("Ya intento con esta letra '{0}', y era correcta", guess);
                    continue;
                }
                else if (LetrasErroneas.Contains(guess))
                {
                    Console.WriteLine(" Ya intento con esta letra '{0}', y era erronea", guess);
                    continue;
                }


            }
        }
        
    }
}
