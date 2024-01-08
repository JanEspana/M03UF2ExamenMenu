using System;
namespace M03UF2Examen
{
    public class Menu
    {
        public static void Main()
        {
            const string MSG = "Què vols fer?\n1. Validar si un nombre és senar\n2. Calcular la potència d'un nombre\n" +
                "3. Retornar un valor aleatori\n4. Comptar el nombre de vocals o consonants en un text\n5. Sortir";
            int option;
            do
            {
                do
                {
                    Console.WriteLine(MSG);
                    option = Convert.ToInt32(Console.ReadLine());
                }
                while (option < 1 || option > 5);
                if (option == 1)
                {
                    OddNum();
                }
                else if (option == 2)
                {
                    PowerOfNum();
                }
                else if (option == 3)
                {
                    RandNum();
                }
                else if (option == 4)
                {
                    CountLetter();
                }
            }
            while (option < 5);
        }
        public static void OddNum()
        {
            const string MSG = "Escriu un nombre: ", IsOdd = "El nombre és senar.", notOdd = "El nombre no és senar.";
            int input;
            Console.Write(MSG);
            input = Convert.ToInt32(Console.ReadLine());
            if (input%2 == 1)
            {
                Console.WriteLine(IsOdd);
            }
            else
            {
                Console.WriteLine(notOdd);
            }
        }
        public static void PowerOfNum()
        {
            const string BASE = "Escriu una base: ", EXP = "Escriu l'exponent: ";
            int input, exp, output = 1;
            Console.Write(BASE);
            input = Convert.ToInt32(Console.ReadLine());
            Console.Write(EXP);
            exp = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < exp; i++)
            {
                output = output * input;
            }
            Console.WriteLine(output);
        }
        public static void RandNum()
        {
            const string MIN = "Escriu el nombre mínim que por sortir: ", MAX = "Escriu el nombre màxim que por sortir: ";
            int min, max;
            Console.Write(MIN);
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write(MAX);
            max = Convert.ToInt32(Console.ReadLine()) + 1;
            Random random = new Random();
            Console.WriteLine(random.Next(min, max));
        }
        public static void CountLetter()
        {
            const string MSG = "Escriu una frase: ";
            string input;
            int vowelCount = 0, consCount = 0, blankSpace = 0;
            Console.Write(MSG);
            input = Console.ReadLine();
            input = input.ToUpper();
            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] == 'A') || (input[i] == 'E') || (input[i] == 'I') || (input[i] == 'O') || (input[i] == 'U'))
                {
                    vowelCount++;
                }
                else
                {
                    consCount++;
                }
                if (input[i] == ' ')
                {
                    blankSpace++;
                }
            }
            Console.Write("Vocals: {0}, consonants: {1}", vowelCount, (consCount - blankSpace));
        }
    }
}
