namespace ConsoleAppLesson2
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Experience { get; set; }
        public string Position { get; set; }
        private readonly double NDS = 0.2;

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        private double GetCoeficient()
        {
            switch (Position)
            {
                case "Trainee Software Engineer": return 0.05 * Experience;
                case "Junior Software Engineer": return 0.075 * Experience;
                case "Middle Software Engineer": return 0.1 * Experience;
                case "Senior Software Engineer": return 0.2 * Experience;
                default: return -1;
            }
        }
        
        public double GetSalary()
        {
            double coeficient = GetCoeficient();
            if (coeficient == -1)
            {
                return -1;
            }
            else
            {
                return new Converter(1 / 26.0, 1 / 0.3, 1 / 33.0).Convert(10000 * coeficient, "usd", true);
            }
            
        }
        
    }
}