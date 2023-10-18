using System;

namespace lab1_2
{
    public class TTriangle
    {
        public double side_a;
        public double side_b;
        public double side_c;

        public TTriangle()
        {
            side_a = side_b = side_c = 4.0;
        }

        public TTriangle(double a, double b, double c)
        {
            if (IsTrianglePossible(a, b, c))
            {
                side_a = a;
                side_b = b;
                side_c = c;
            }
            else throw new ArgumentException("Неможливо створити трикутник з такими сторонами.");
        }

        public bool IsTrianglePossible(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0 || a + b < c || b + c < a || a + c < b) return false;
            return true;
        }

        public TTriangle(TTriangle otherSides)
        {
            side_a = otherSides.side_a;
            side_b = otherSides.side_b;
            side_c = otherSides.side_c;
        }

        public override string ToString()
        {
            return $"трикутник зі сторонами {side_a}, {side_b} та {side_c}";
        }

        public double FindPerimeter()
        {
            return side_a + side_b + side_c;
        }
        public double FindArea()
        {
            double p = FindPerimeter() / 2;
            return Math.Sqrt(p*(p-side_a)*(p-side_b)*(p-side_c));
        }
        public static TTriangle operator *(double k, TTriangle tr1)
        {
            double new_a = k * tr1.side_a;
            double new_b = k * tr1.side_b;
            double new_c = k * tr1.side_c;
            return new TTriangle(new_a, new_b, new_c);
        }
        public static TTriangle operator *(TTriangle tr1, double k)
        {
            return k * tr1;
        }

        public static bool CompareTriangles(TTriangle tr1, TTriangle tr2)
        {
            if (tr1.side_a == tr2.side_b || tr1.side_a == tr2.side_c || tr1.side_a == tr2.side_a)
            {
                if (tr1.side_b == tr2.side_a || tr1.side_b == tr2.side_b || tr1.side_b == tr2.side_c)
                {
                    if (tr1.side_c == tr2.side_a || tr1.side_c == tr2.side_b || tr1.side_c == tr2.side_c)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void Input()
        {
            Console.Write("Введіть довжину сторони A: ");
            side_a = double.Parse(Console.ReadLine());

            Console.Write("Введіть довжину сторони B: ");
            side_b = double.Parse(Console.ReadLine());

            Console.Write("Введіть довжину сторони C: ");
            side_c = double.Parse(Console.ReadLine());
            
            if (!IsTrianglePossible(side_a, side_b, side_c))
            {
                throw new ArgumentException("З такими сторонами неможливо утворити трикутник.");
            }
        }
        public void Output()
        {
            Console.WriteLine($"Сторона a: {side_a}");
            Console.WriteLine($"Сторона b: {side_b}");
            Console.WriteLine($"Сторона c: {side_c}");
            Console.WriteLine($"Периметр: {FindPerimeter()}");
            Console.WriteLine($"Площа: {FindArea()}");
        }
    }
}