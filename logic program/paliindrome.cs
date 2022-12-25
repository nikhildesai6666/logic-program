//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace logic_program
//{
//    internal class paliindrome
//    {
//        static void Main(string[] args)
//        {
//            int rem, result = 0;

//            int num = Convert.ToInt32(Console.ReadLine());
//            int temp = num;
//            while (num > 0)
//            {
//                rem = num % 10;
//                result = result * 10 + rem;
//                num = num / 10;

//            }
//            num = temp;
//            if (num == result)
//            {
//                Console.WriteLine("palindrome");
//            }
//            else
//            {
//                Console.WriteLine("not palindrome");
//            }
//        }
//    }
//}
