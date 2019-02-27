using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_Nahorna
{
    class Program
    {
        static int[] arr = new int[5];

        static void PutMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void InputMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                arr[i] *= 10;
                Console.Write(arr[i]+" ");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            PutMethod();
            Console.WriteLine("User input finished. Processing...");
            InputMethod();
            Console.ReadKey();
        }
    }
}



