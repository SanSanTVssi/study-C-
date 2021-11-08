using System;

namespace ConsoleAppLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 2
            Converter converter = new Converter(1/26.0, 1/0.3, 1/33.0);
            Console.WriteLine(converter.Convert(50, "usd"));
            Console.WriteLine(converter.Convert(50, "eur"));
            Console.WriteLine(converter.Convert(50, "rub"));
            Console.WriteLine(converter.Convert(50, "usd",true));
            Console.WriteLine(converter.Convert(50, "eur",true));
            Console.WriteLine(converter.Convert(50, "rub",true));
            
            // Task 3
            Employee Alexandr = new Employee("Alex", "Ilchuk");
            Alexandr.Experience = 1;
            Alexandr.Position = "Trainee Software Engineer";
            Employee Vasia = new Employee("Vasia", "Pupkin");
            Vasia.Experience = 5;
            Vasia.Position = "Senior Software Engineer";
            Console.WriteLine(Alexandr.GetSalary());
            Console.WriteLine(Vasia.GetSalary());
        }
    }
}