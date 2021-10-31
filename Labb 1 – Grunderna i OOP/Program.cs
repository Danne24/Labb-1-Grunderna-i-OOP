using System;

namespace Labb_1___Grunderna_i_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            Circle c2 = new Circle(6);
            Console.WriteLine("Om radien på en cirkel är 5 så är cirkelns area: {0} och cirkels omkrets: {1}. Om nu cirkeln i fråga är ett klot så kommer volymen att vara: {2}.", c1.GetArea(), c1.GetCircumference(), c1.GetVolume());
            Console.WriteLine("Om radien på en cirkel är 6 så är cirkelns area: {0} och cirkels omkrets: {1}. Om nu cirkeln i fråga är ett klot så kommer volymen att vara: {2}.", c2.GetArea(), c2.GetCircumference(), c2.GetVolume());

            Console.WriteLine(" ");

            Console.Write("Vänligen ange basen på din rätvinkliga triangel: ");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vänligen ange höjden på din rätvinkliga triangel: ");
            int höjd = Convert.ToInt32(Console.ReadLine());
            Triangle t = new Triangle(bas, höjd);
            Console.WriteLine("Om basen på din rätvinkliga triangel är {0} och om höjden är {1} så kommer arean att vara {2} och omkretsen att vara {3}. Om nu triangeln i fråga är en triangulär pyramid med en höjd på {4} så kommer volymen att vara: {5}.", bas, höjd, t.GetArea(), t.GetCircumference(), höjd, t.GetVolume());

            Console.ReadKey();
        }
    }
    public class Circle
    {
        int radius;
        public Circle(int radie)
        {
            this.radius = radie;
        }
        public double GetArea()
        {
            double area = this.radius * this.radius * Math.PI;
            return area;
        }
        public double GetCircumference()
        {
            double omkrets = 2 * Math.PI * this.radius;
            return omkrets;
        }
        public double GetVolume()
        {
            double volym = 4 * Math.PI * Math.Pow(this.radius, 3) / 3;
            return volym;
        }
    }
    public class Triangle
    {
        int _bas;
        int _höjd;
        public Triangle(int bas, int höjd)
        {
            this._bas = bas;
            this._höjd = höjd;
        }
        public double GetArea()
        {
            double area = this._bas * this._höjd / 2;
            return area;
        }
        public double GetCircumference()
        {
            double hypotenusanUpphöjtTill2 = Math.Pow(this._bas, 2) + Math.Pow(this._höjd, 2);
            double hypotenusan = Math.Sqrt(hypotenusanUpphöjtTill2);
            double omkrets = this._bas + this._höjd + hypotenusan;
            return omkrets;
        }
        public double GetVolume()
        {
            double area = GetArea();
            double volym = area * this._höjd / 3;
            return volym;
        }
    }
}