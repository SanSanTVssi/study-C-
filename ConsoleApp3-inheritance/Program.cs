using System;

namespace ConsoleApp3_inheritance
{
    class Program
    {
        private static void ShowInfoTask2(Vehicle vehicle)
        {
            vehicle.ParametetsShow();
        }

        private static DocumentWorker GetDoc(string key = "")
        {
            switch (key)
            {
                case "pro": return new ProDocumentWorker();
                case "exp": return new ExpertDocumentWorker();
                default: return new DocumentWorker();
            }
        }
        
        static void Main(string[] args)
        {
            // Task 2
            new ClassRoom(
                new ExcelentPupil("Alex"), 
                new BadPupil("Konoplinskyj"),  
                new BadPupil("Konoplinskyj"), 
                new GoodPupil("Cobol")).PrintStatistics();
            
            // Task 3
            ShowInfoTask2(new Plane("Plane0", "Plane1"));
            ShowInfoTask2(new Plane("car0", "car1"));
            
            // Task 4
            GetDoc("pro").SaveDocument();
            GetDoc("exp").SaveDocument();
        }
    }
}