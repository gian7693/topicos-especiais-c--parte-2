using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EXEMPLO 1
            //DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            //Console.WriteLine(dt.ElapsedTime());
            #endregion

            #region EXEMPLO 2 
            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
            #endregion
        }
    }
}