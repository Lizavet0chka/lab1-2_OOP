using System;

namespace lab1_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TTriangle firstTriangle = new TTriangle();
            firstTriangle.Input();
            Console.Write("Ви ввели ");  
            Console.WriteLine(firstTriangle.ToString());
            Console.WriteLine($"Периметр вашого трикутника: {firstTriangle.FindPerimeter()}");
            Console.WriteLine($"Площа вашого трикутника: {firstTriangle.FindArea()}");
            Console.WriteLine("Введіть другий трикутник з яким будемо порівнювати:");
            TTriangle secondTriangle = new TTriangle();  
            secondTriangle.Input();
            Console.Write("Ви ввели ");  
            Console.WriteLine(secondTriangle.ToString());
            if (TTriangle.CompareTriangles(firstTriangle, secondTriangle))
            {
                Console.WriteLine("Трикутники рівні");
            }
            else
            {
                Console.WriteLine("Трикутники не рівні");
            }
            Console.WriteLine("Введіть коефіцієнт, на який бажаєте помножити трикутник");
            try
            {
                double k = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Результат множення трикутника на {0}:", k);
                Console.WriteLine((firstTriangle*k).ToString()); 
                Console.WriteLine("Результат множення {0} на трикутник:", k);
                Console.WriteLine((k * firstTriangle).ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Створення трикутної призми:");  
            TTrianglePrizm firstPrizm = new TTrianglePrizm();
            firstPrizm.Input();
            Console.Write("Ви ввели "); 
            Console.WriteLine(firstPrizm.ToString());
            Console.WriteLine($"Периметр призми: {firstPrizm.FindPerimeter()}");
            Console.WriteLine($"Площа поверхні призми: {firstPrizm.FindArea()}");
            Console.WriteLine($"Об'єм призми: {firstPrizm.FindVolume()}");
            Console.WriteLine("Введіть другу призму з якою будемо порівнювати:");
            TTrianglePrizm secondPrizm = new TTrianglePrizm();
            secondPrizm.Input();  
            Console.Write("Ви ввели "); ;
            Console.WriteLine(secondPrizm.ToString());
            if (TTrianglePrizm.ComparePrizmas(firstPrizm, secondPrizm))
            {
                Console.WriteLine("Призми рівні");
            }
            else
            {
                Console.WriteLine("Призми не рівні");
            }
            Console.WriteLine("Введіть коефіцієнт, на який бажаєте помножити призму");
            try
            {
                double n = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Результат множення призми на {0}:", n);
                Console.WriteLine((firstPrizm*n).ToString()); 
                Console.WriteLine("Результат множення {0} на призму:", n);
                Console.WriteLine((n * firstPrizm).ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}