using System;

namespace ConsoleApp1
{
    // Task 4
    public class Figure
    {
        private byte _type;
        private Point _point1; 
        private Point _point2; 
        private Point _point3; 
        private Point _point4; 
        private Point _point5;

        public Figure()
        {
            _point1 = new Point(0, 0, "point 1");
            _point2 = new Point(0, 1, "point 2");
            _point3 = new Point(1, 0, "point 3");
        }

        public Figure(Point A, Point B, Point C)
        {
            _point1 = new Point(A.X, A.Y, "point 1");
            _point1 = new Point(B.X, B.Y, "point 2");
            _point1 = new Point(C.X, C.Y, "point 3");
            _type = 3;
            _point4 = new Point();
            _point5 = new Point();
        }

        public Figure(Point A, Point B, Point C, Point D): this(A, B, C)
        {
            _point4 = new Point(D.X, D.Y, "point 4");
            _type = 4;
            _point5 = new Point();
        }
        
        public Figure(Point A, Point B, Point C, Point D, Point E): this(A, B, C, D)
        {
            _point5 = new Point(E.X, E.Y, "point 5");
            _type = 5;
        }

        public Figure(double xA, double yA,
            double xB, double yB, 
            double xC, double yC)
        {
            _point1 = new Point(xA, yA, "point 1");
            _point2 = new Point(xB, yB, "point 2");
            _point3 = new Point(xC, yC, "point 3");
            _type = 3;
            _point4 = new Point();
            _point5 = new Point();
        }
        
        public Figure(double xA, double yA,
            double xB, double yB, 
            double xC, double yC, 
            double xD, double yD): this(xA, yA, xB, yB, xC, yC)
        {
            _point4 = new Point(xD, yD, "point 4");
            _type = 4;
            _point5 = new Point();
        }
        
        public Figure(double xA, double yA,
            double xB, double yB, 
            double xC, double yC, 
            double xD, double yD, 
            double xE, double yE): this(xA, yA, xB, yB, xC, yC, xD, yD)
        {
            _point5 = new Point(xE, yE, "point 5");
            _type = 5;
        }

        public static double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(
                Math.Pow(B.X-A.X, 2) + Math.Pow(B.Y-A.Y,2)
                );
        }

        public double PerimeterCalculator()
        {
            return LengthSide(_point1, _point2) + LengthSide(_point2, _point3) + LengthSide(_point3, _point4) +
                   LengthSide(_point4, _point5) + LengthSide(_point5, _point1);
        }
    }

    public class Point
    {
        private double _x;
        private double _y;
        private string _title;

        public double X
        {
            get => _x;
            set => _x = value;
        }

        public double Y
        {
            get => _y;
            set => _y = value;
        }
        public string Title => _title;
        

        public Point()
        {
            _x = 0;
            _y = 0;
        }
        
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Point(double x, double y, string title) : this(x, y)
        {
            _title = title;
        }

    }
}