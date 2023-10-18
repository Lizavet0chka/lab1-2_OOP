using System;

namespace lab1_2
{
    public class TTrianglePrizm:TTriangle
    {
        public double height { get; set; }

        public TTrianglePrizm() : base()
        {
            height = 5.0;
        }
        public TTrianglePrizm(double heightPrizm, double a, double b, double c) : base(a, b, c)
        {
            if (!IsHeightPositive(heightPrizm))
            {
                throw new ArgumentException("Не додатня висота неможлива в призмі");
            }
            height = heightPrizm;
        }
        public TTrianglePrizm(TTrianglePrizm other) : base(other)
        {
            height = other.height;
        }
        public override string ToString()
        {
            return $"призму зі сторонами основи {side_a}, {side_b}, {side_c} та висотою {height}";
        }
        static bool IsHeightPositive(double height)
        {
            if (height > 0) return true;
            return false;
        }
        public new double FindPerimeter()
        {
            return 2*(side_a + side_b + side_c) + 3*height;
        }
        public new double FindArea()
        {
            return 2 * base.FindArea() + base.FindPerimeter() * height;
        }
        public double FindVolume()
        {
            return height * base.FindArea();
        }
        public static bool ComparePrizmas(TTrianglePrizm pr1, TTrianglePrizm pr2)
        {
            if (CompareTriangles(new TTriangle(pr1.side_a, pr1.side_b, pr1.side_c), new TTriangle(pr2.side_a, pr2.side_b, pr2.side_c)))
            {
                if (pr1.height == pr2.height)
                {
                    return true;
                }
            }
            return false;
        }
        public new void Input()
        {
            base.Input();
            Console.Write("Введіть висоту: ");
            height = double.Parse(Console.ReadLine());
            if (!IsHeightPositive(height))
            {
                throw new ArgumentException("З такими сторонами неможливо утворити трикутник.");
            }
        }
        public new void Output()
        {
            Console.WriteLine($"Призма зі сторонами основи {side_a}, {side_b}, {side_c} та висотою {height}");
        }
        public static TTrianglePrizm operator *(double k, TTrianglePrizm pr1)
        {
            double newHeight = k * pr1.height;
            double new_a = k * pr1.side_a;
            double new_b = k * pr1.side_b;
            double new_c = k * pr1.side_c;
            return new TTrianglePrizm(newHeight, new_a, new_b, new_c);
        }
        public static TTrianglePrizm operator *(TTrianglePrizm pr1, double k)
        {
            return k * pr1;
        }
    }
}