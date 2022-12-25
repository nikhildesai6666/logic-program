//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace logic_program
//{
//    internal class findMAXandMIN
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter arrray size");
//            int num = Convert.ToInt32(Console.ReadLine());
//            int[] numbers = new int[num];
//            Console.WriteLine("enter numbers");
//            for (int i = 0; i < num; i++)
//            {

//                int data = Convert.ToInt32(Console.ReadLine());
//                numbers[i] = data;
//            }
//            int min = numbers[0];
//            int max = numbers[0];
//            for (int i = 0; i < num; i++)
//            {
//                if (min > numbers[i])
//                {
//                    min = numbers[i];
//                }
//                if (max < numbers[i])
//                {
//                    max = numbers[i];
//                }
//            }
//            int temp = min;
//            min = max;
//            max = temp;
//            Console.WriteLine("min no is" + min);
//            Console.WriteLine("max no is" + max);
//        }
//    }
//}
