//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace piryamid
//{
//    internal class print1_5
//    {
//        //1
//        //12
//        //123
//        //1234
//        //12345
//        static void Main(string[] args)
//        {
//            for (int i = 1; i <= 5; i++)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write(j);
//                }
//                Console.WriteLine();
//            }
//        }

//        //12345
//        //1234
//        //123
//        //12
//        //1
//        static void Main(string[] args)
//        {
//            for (int i = 5; i >= 1; i--)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write(j);
//                }
//                Console.WriteLine();
//            }
//        }

//        //54321
//        //5432
//        //543
//        //54
//        //5
//        static void Main(string[] args)
//        {
//            for (int i = 1; i <= 5; i++)
//            {
//                for (int j = 5; j >= i; j--)
//                {
//                    Console.Write(j);
//                }
//                Console.WriteLine();
//            }
//        }



//        //*
//        //**
//        //***
//        //****
//        //*****

//        static void Main(string[] args)
//        {
//            for (int i = 1; i <= 5; i++)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//        }


//        //*****
//        //****
//        //***
//        //**
//        //*

//        static void Main(string[] args)
//        {
//            for (int i = 5; i >= 1; i--)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//        }

//            *
//           * *
//          * * *
//         * * * *
//        * * * * *

//        static void Main(string[] args)
//        {


//            for (int i = 0; i < 5; i++)
//            {
//                for (int j = 0; j < 5 - i; j++)
//                {
//                    //space sathi
//                    Console.Write(" ");
//                }
//                for (int k = 0; k <= i; k++)
//                {
//                    Console.Write("*");
//                }
//                for (int l = 0; l < i; l++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }

//        }
//    }
//}