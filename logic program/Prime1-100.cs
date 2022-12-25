//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace logic_program
//{
//    internal class Prime1_100
//    {
//        static void Main(string[] args)
//        {
//            int n;
//            for (int i = 1; i <= 100; i++)
//            {
//                n = 0;
//                for (int j = 2; j <= i / 2; j++)
//                {
//                    if (i % j == 0)
//                    {
//                        n++;
//                        break;
//                    }
//                }
//                if (n == 0 && i != 1)
//                {
//                    Console.Write(i + " ");
//                }
//            }
//        }
//    }
//}
