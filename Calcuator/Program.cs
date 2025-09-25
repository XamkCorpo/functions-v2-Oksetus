namespace Calcuator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string? operation;

                ValitseLaskutoimitus(out operation);

                if (operation != "1" && operation != "2" && operation != "3" && operation != "4")
                {
                    Console.WriteLine("Invalid operation. Please try again.");
                    continue;
                }

                double num1 = KysyLuku1();
                double num2 = KysyLuku2();

                double result;

                switch (operation)
                {
                    case "1":
                        result = PlusLasku(num1, num2);
                        TulostaTulos(num1, num2, "+", result);
                        break;
                    case "2":
                        result = MiinusLasku(num1, num2);
                        TulostaTulos(num1, num2, "-", result);
                        break;
                    case "3":
                        result = KertoLasku(num1, num2);
                        TulostaTulos(num1, num2, "*", result);
                        break;
                    case "4":
                        result = JakoLasku(num1, num2);
                        if (double.IsNaN(result))
                        {
                            continue;
                        }
                        TulostaTulos(num1, num2, "/", result);
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected.");
                        continue;        
                }
                break;  
            }
            
        }

        /// <summary>
        /// Outputs the result to the console. 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operation"></param>
        /// <param name="result"></param>
        private static void TulostaTulos(double num1, double num2, string operation, double result)
        {
            Console.WriteLine($"{num1} {operation} {num2} = {result}");
        }

        /// <summary>
        /// Divides 1st number by 2nd number and returns the result. Handles division by zero.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Result</returns>
        /// 

        // Tämä JakoLasku funktio oli hankala saada toimimaan koska tein tämän alunperin eri tavalla ja se ei toimunut millään ja vahdoin sen tähän tyyliin. Yritin alussa saada funktion sillä tyylillä että 0 != num2 mutta en saanut sitä toimimaan.
        private static double JakoLasku(double num1, double num2)
        
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return double.NaN; // Return NaN.
            }
            return num1 / num2;
        }


        /// <summary>
        /// Multiplies 1st and 2nd number and returns the result.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Result</returns>
        private static double KertoLasku(double num1, double num2)
        {
            return num1 * num2;
        }


        /// <summary>
        /// It Subtracts 1st number from 2nd number and returns the result.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>result</returns>
        private static double MiinusLasku(double num1, double num2)
        {
            return num1 - num2;
        }
        /// <summary>
        /// Adds two double-precision floating-point numbers and returns the result.
        /// </summary>
        /// <param name="num1">The first number to add.</param>
        /// <param name="num2">The second number to add.</param>
        /// <returns>The sum of <paramref name="num1"/> and <paramref name="num2"/>.</returns>
        private static double PlusLasku(double num1, double num2)
        {
            return num1 + num2;
        }


        /// <summary>
        /// Asks the user for the second number.
        /// </summary>
        /// <returns>Second number</returns>
        private static double KysyLuku2()
        {
            Console.WriteLine("Give second number.");
            double num2 = Convert.ToDouble(Console.ReadLine());
            return num2;
        }
        /// <summary>
        /// Asks the user for the first number.
        /// </summary>
        /// <returns>First number</returns>
        private static double KysyLuku1()
        {
            Console.WriteLine("Give first number.");
            double num1 = Convert.ToDouble(Console.ReadLine());
            return num1;
        }


        /// <summary>
        /// Chooses the operation for the calculator.
        /// </summary>
        /// <param>Gives the operation back in it's number place="operation"</param>
        private static void ValitseLaskutoimitus(out string? operation)
        {
            Console.WriteLine("Choose operation:");
            Console.WriteLine("1. Add (+)");
            Console.WriteLine("2. Subtract (-)");
            Console.WriteLine("3. Multiply (*)");
            Console.WriteLine("4. Divide (/)");

            operation = Console.ReadLine();
            Console.WriteLine($"You chose {operation}.");
            return;

        }
    }
}
