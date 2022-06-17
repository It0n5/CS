using System;
    
namespace HeyEarth
{
    
class Program
    {
        static void Main(string[] args)
        {
            string vas = "Ello";
            Console.WriteLine(vas);
            Console.WriteLine(Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(vas)));
            
        }

    }




}