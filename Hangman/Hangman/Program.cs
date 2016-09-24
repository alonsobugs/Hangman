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

            string PalabraAdivinar = "";
            string PalabaAdivinarUppercase = PalabraAdivinar.ToUpper();
            char Letra = ' ';
            int Intentos = 10;
            bool gano = false;
            int LetrasReveladas = 0;

            StringBuilder Despliegue = new StringBuilder(PalabraAdivinar.Length);
            for (int i = 0; i < PalabraAdivinar.Length; i++)
                Despliegue.Append('_');

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

                if (PalabaAdivinarUppercase.Contains(guess))
                {
                    LetrasAdivinadas.Add(guess);

                    for (int i = 0; i < PalabraAdivinar.Length; i++)
                    {
                        if (PalabaAdivinarUppercase[i] == guess)
                        {
                            Despliegue[i] = PalabraAdivinar[i];
                            LetrasReveladas++;
                        }
                    }

                    if (LetrasReveladas == PalabraAdivinar.Length)
                        gano = true;
                }
                else
                {
                    LetrasErroneas.Add(guess);

                    Console.WriteLine("No existe '{0}' ", guess);
                    Intentos--;
                }

                Console.WriteLine(Despliegue.ToString());
            }

            if (gano)
                Console.WriteLine("Ud gano!");
            else
                Console.WriteLine("Ud perdio! La palabra era '{0}'", PalabraAdivinar);

            Console.Write("Presiona ENTER para salir...");
            Console.ReadLine();

        }
    }

}
       