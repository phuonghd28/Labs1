using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sin = "193456787";
            if (sin.Length != 9)
            {
                Console.WriteLine("sin phải là chuỗi 9 chữ số");
                return;
            }
            var splittedSin = sin.ToCharArray();
            var sinInNumber = new int[9];
            for (int i = 0; i < splittedSin.Length; i++)
            {
                sinInNumber[i] = int.Parse(splittedSin[i].ToString());
            }

            var tongSoHangChan = 0;
            var tongSoHangLe = 0;
            for (int i = 0; i < sinInNumber.Length - 1; i++)
            {
                if (i%2 == 0)
                {
                    tongSoHangLe += sinInNumber[i];
                }
                else
                {
                    var temp = (sinInNumber[i] * 2).ToString().ToCharArray();
                    for (int j = 0; j < temp.Length; j++)
                    {
                        tongSoHangChan += Convert.ToInt32(temp[j].ToString());
                    }
                }
            }

            Console.WriteLine(tongSoHangLe);
            Console.WriteLine(tongSoHangChan);
        
        }
    }
}