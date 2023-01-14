using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PasswordLenght = Convert.ToInt32(Console.ReadLine());
            string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%+-*/.,";

            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < PasswordLenght--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            Console.WriteLine(res);
        }
    }
}
