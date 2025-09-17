using System.Xml.Linq;

namespace FunctionAssigmentV1
{
    internal class Program
    {
        /// <summary>
        /// Kysyy käyttäjältä nimen, kunnes se ei ole tyhjä
        /// </summary>
        /// <returns>Antaa nimen</returns>
       
        static string KysyNimi()
        {
            string name;
            while (true)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    break;
                else
                    Console.WriteLine("Name cannot be empty.");
                
            }
            return name;
        }

        /// <summary>
        /// Kysyy ikää , kunnes se on positiivinen kokonaisluku
        /// </summary>
        /// <returns>Antaa iän</returns>
       
        static int KysyIka()
        {
            int age;
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out age) && age > 0)
                    break;
                else
                    Console.WriteLine("Please enter a positive integer.");
            }
            return age;
        }

        /// <summary>
        /// Tulostaa Nimen ja Iän
        /// </summary>
        /// <param name="name"></param>
        /// <param age="age"></param>

        static void TulostaNimiJaIka(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }

        /// <summary>
        /// Tarkistaa onko käyttäjä täysi-ikäinen
        /// </summary>
        /// <param name="age"></param>
        /// <returns>Antaa varmistuksen</returns>

        static bool TarkistaTaysiIkainen(int age)
        {
            return age >= 18;
        }

        /// <summary>
        /// Vertaa nimeä toiseen merkkijonoon
        /// </summary>
        /// <param name="name"></param>
        /// <param name="compareTo"></param>
        
        static void VertaaNimea(string name, string compareTo)
        {
            if (name.Equals(compareTo, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"Your name matches '{compareTo}' (case-insensitive).");
            if (name.Equals(compareTo))
                Console.WriteLine($"Your name is exactly '{compareTo}' (case-sensitive).");
        }

        static void Main(string[] args)
        {
        
            // Ask for name and ensure it is not empty
            string name = KysyNimi();
            // Ask for age and ensure it is a positive integer
            int age = KysyIka();
            // Print name and age
            TulostaNimiJaIka(name, age);
            // Check if the user is an adult         
            TarkistaTaysiIkainen(age);
            // Compare the name to another string (e.g., "Matti")
            VertaaNimea(name, "Matti");

           
        }
    }
}