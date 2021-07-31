using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 07, 31, 16, 27, 00);
            Console.WriteLine(dt.ElapsedTime());//Extended method for DateTime

            string texto = "This text is way too long, it might need to be cut.";
            Console.WriteLine(texto.Cut(30));//Extended method for string
           
        }
    }
}
