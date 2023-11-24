using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{
    public class Calculator
    {    public int num()
        {
            return 10;
        } 

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Hello, World");
            //Task 2 Variables and User Input
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
            //Tast 3 Basic Arithmetic using Extension Method
            Console.WriteLine("Enter First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = int.Parse(Console.ReadLine());
            Calculator ob = new Calculator();
            Console.WriteLine($"Addition:{ob.add(num1, num2)}");
            Console.WriteLine($"Subtraction:{ob.sub(num1, num2)}");
            Console.WriteLine($"Multiplication{ob.mul(num1, num2)}");
            Console.WriteLine($"Division{ob.div(num1, num2)}");
            Console.WriteLine($"Modules{ob.mod(num1, num2)}");
            //Tast 4 Control Structure
            Console.WriteLine("Enter number To Find Even or Odd");
            int num3 = int.Parse(Console.ReadLine());
            if (num3 % 2 == 0)
            {
                Console.WriteLine($"Your Entered Number is {num3} and the Number is Even");
            }
            else
            {
                Console.WriteLine($"Your Entered Number is {num3} and the Number is Odd");
            }
            //Task 5 Loops
            Console.WriteLine("Number 1 to 10");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            // Task 6 Arrays
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int sum = 0;
            int count = 0;
            foreach (int arr in array)
            {
                sum += arr;
                count++;
            }
            int avg=sum/count;
            Console.WriteLine($"Sum of the Array{sum}");
            Console.WriteLine($"Average of the Array{avg}");

            //Task 7 Methods
            Console.WriteLine("Enter Positive Number to Calculate its Factorial");
            int num4 = int.Parse(Console.ReadLine());
            if (num4 < 0)
            {
                Console.WriteLine("Error: Enter only positive number ");
            }
            else
            {
                long factorial = CalculateFactorial(num4);
            }

            //Task 8 Exception Handling

            bool validInput = false;
            int age = 0;
            do
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid integer for your age.");
                }
            } while (!validInput);

            if (age < 18)
            {
                Console.WriteLine("You are considered a minor.");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are considered an adult.");
            }
            else
            {
                Console.WriteLine("You are considered a senior.");
            }





        }
                     public static long CalculateFactorial(int num)
                        {
                           if (num == 0)
                               {
                                 return 1;
                               }
                           else
                              {
                                return num*CalculateFactorial(num-1);
                                 }

                         }
    }
}
