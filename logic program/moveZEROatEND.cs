//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace logic_program
//{
//    internal class moveZEROatEND
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = new int[8] { 1, 2, 0, 0, 3, 4, 5, 6 };

//            int count = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] != 0)
//                {
//                    arr[count] = arr[i];
//                    count++;
//                }
//            }
//            while (count < arr.Length)
//            {
//                arr[count] = 0;
//                count++;
//            }
//            foreach (int r in arr)
//            {
//                Console.WriteLine(r);
//            }
//        }
//    }
//}
