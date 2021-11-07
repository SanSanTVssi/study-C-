using System;
// Task 2
namespace ConsoleApp1
{
    class Recrangle
    {
        private double Width { set; get;  }
        private double Height { set; get; }


        public Recrangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        private double AreaCalculator()
        {
            return Width * Height;
        }
        
        private double PerimeterCalculator()
        {
            return 2 * Width + 2 * Height;
        }

        public double Area
        {
            get => AreaCalculator();
        }
        
        public double Perimeter
        {
            get => PerimeterCalculator();
        }

        public void PrintAreaAndPerimeter()
        {
            Console.WriteLine($"Area == {Area}");
            Console.WriteLine($"Perimeter == {Perimeter}");
        }
    }
}