using System;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main()
        {
            // Task 2
            Recrangle recrangle1 = new Recrangle(5, 5);
            recrangle1.PrintAreaAndPerimeter();
            // Task 3
            Book book1 = new Book();
            book1.Content = "Konoplia gondon ebaniy. Sob on zdoh!";
            book1.Author = "I";
            book1.Title = "KONOPLIA GONDON EBANIY";
            book1.PrintInfo();
            // Task 4
            Figure trFigure = new Figure(0, 0, 1, 0, 1, 0);
            Console.WriteLine(trFigure.PerimeterCalculator());
        }
    }
}