//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace logic_program
//{
//    internal class armstrong
//    {
//        static void Main(string[] args)
//        {
//            int rem, sum = 0, temp;
//            int num = Convert.ToInt32(Console.ReadLine());
//            temp = num;
//            while (num > 0)
//            {
//                rem = num % 10;
//                sum = sum + (rem * rem * rem);
//                num = num / 10;
//            }
//            num = temp;
//            if (num == sum)
//            {
//                Console.WriteLine("armstrong");
//            }
//            else
//            {
//                Console.WriteLine("not armstrong");
//            }
//        }
//}
