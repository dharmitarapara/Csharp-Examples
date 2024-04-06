using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Examples
{
    // Declare a delegate type that matches the signature of the methods we want to reference
    delegate int MathOperation(int a, int b);

    public class Calculator
    {
        // Define methods that match the signature of the delegate
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Create delegate instances that point to the methods
            MathOperation addDelegate = Calculator.Add;
            MathOperation subtractDelegate = Calculator.Subtract;

            // Use the delegates to perform operations
            int resultAdd = addDelegate(5, 3);       // Calling Add method through the delegate
            int resultSubtract = subtractDelegate(8, 4);  // Calling Subtract method through the delegate

            Console.WriteLine($"Addition Result: {resultAdd}");
            Console.WriteLine($"Subtraction Result: {resultSubtract}");
        }
    }

}
