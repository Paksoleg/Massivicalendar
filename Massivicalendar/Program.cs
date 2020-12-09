
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Test1
            /*            int[,] calendar =
                          {
                            {1,2,3,4,5,6,7 }, //week
                            {8,9,10,11,12,13,14}, ///week1
                            {15,16,17,18,19,20,21 }, ///week2
                            {22,23,24,25,26,27,28, } ///week3
                        };
                        for (int i = 0; i < 4; i++) 
                        {
                            for (int j = 0; j < 7; j++) 
                            {
                                Console.Write(calendar[i,j] + " ");
                            }
                            Console.WriteLine();
                        }*/

            //Test2

            int[,] calendar =
   {
                {1,2,3,4,5,6,7 }, //week
                {8,9,10,11,12,13,14}, ///week1
                {15,16,17,18,19,20,21 }, ///week2
                {22,23,24,25,26,27,28 },
                {29,30,31,1,2,3,4 }///week3
            };
            for (int b = 0; b < 1; b++)
            {
                for (int c = 3; c < 7; c++)
                {
                    Console.Write("|" + calendar[b, c] + "|");
                }
                Console.WriteLine();
            }

            for (int i = 1; i < 4; i++)//Stroka
            {
                /*     Console.Write(calendar[2 , 0] +" ");
                     Console.Write(calendar[3, 0] + " ");
                     Console.Write(calendar[4, 0] + " ");
                     Console.Write(calendar[5, 0] + " ");
                     Console.Write(calendar[6, 0] + " ");*/

                for (int j = 0; j < 7; j++)//stolbec
                {
                    Console.Write("|" + calendar[i, j] + "|");
                }
                Console.WriteLine();
            }

            for (int u = 4; u < 5; u++)
            {
                for (int h = 0; h < 3; h++)
                {
                    Console.Write("|" + calendar[u, h] + "|");
                }
                Console.WriteLine();
            }

        }
    }
}
