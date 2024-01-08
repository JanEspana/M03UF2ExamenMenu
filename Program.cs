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
    }
}
