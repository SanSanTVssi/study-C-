using System;

namespace ConsoleApp3_inheritance
{
    public class Vehicle
    {
        public int x { get; set; }
        public int y { get; set; }
        private string parameters;

        public Vehicle(string parameters)
        {
            this.parameters = parameters;
            x = 0;
            y = 0;
        }

        public virtual void ParametetsShow()
        {
            Console.WriteLine($"{x}, {y}, {parameters}");
        }
    }

    public class Plane : Vehicle
    {
        private string parameters2;

        public Plane(string parameters,string parameters2): base(parameters)
        {
            this.parameters2 = parameters2;
        }
        
        public override void ParametetsShow()
        {
            base.ParametetsShow();
            Console.WriteLine($"{parameters2}");
        }
    }
    
    public class Car : Vehicle
    {
        private string parameters3;
        
        public Car(string parameters,string parameters3): base(parameters)
        {
            this.parameters3 = parameters3;
        }
        
        public override void ParametetsShow()
        {
            base.ParametetsShow();
            Console.WriteLine($"{parameters3}");
        }
    }
}