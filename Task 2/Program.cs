using System;
using System.Globalization;
using System.Linq;


namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string letters = "abcdefghijklmnopqrstuvwxyz";
            string incor="";
            for (int i = 0; i < s1.Length; i++)
            {
                if (!letters.Contains(Convert.ToString(s1[i])))
                {
                    incor += $"{s1[i]} ";
                }
            }
            if (s1 != null && incor=="")
            {
                string s4 = "";
                int a = s1.Length - 1;
                if (s1.Length % 2 == 0)
                {
                    a = a / 2;
                    string s2 = s1.Substring(0, a + 1);
                    string s3 = s1.Substring(a + 1);
                    for (int i = 0; i <= a; i++)
                    {
                        s4 = s4 + s2[a - i];
                    }
                    for (int i = 0; i <= a; i++)
                    {
                        s4 = s4 + s3[a - i];
                    }
                }
                else
                {
                    for (int i = 0; i <= a; i++)
                    {
                        s4 = s4 + s1[a - i];
                    }
                    s4 = s4 + s1;
                }
                Console.WriteLine(s4);
            }
            else if (s1 == null)
            {
                Console.WriteLine("Empty line.");
            }
            else
            {
                Console.WriteLine($"Incorrect input: {incor}");
                
            }
            Console.ReadLine();
        }
        
    }
}