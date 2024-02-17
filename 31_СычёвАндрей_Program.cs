namespace Самостоятельная_2
{
    internal class Program // Сычёв Андрей, МОСИП12, вариант 31
    {
        static void Main(string[] args)
        {
            double X0End = 0, Y0End = 0, hxEnd = 0, hyEnd = 0;
            int NEnd = 0;
            Console.WriteLine("Введите первое значение X0");
            bool successX0 = Double.TryParse(Console.ReadLine(), out double X0);
            X0End = X0;
            while (!successX0)
            {
                Console.WriteLine("Значение введено некорректно, повторите ввод");
                successX0 = Double.TryParse(Console.ReadLine(), out double X0True);
                X0End = X0True;
            }
            Console.WriteLine("Введите первое значение Y0");
            bool successY0 = Double.TryParse(Console.ReadLine(), out double Y0);
            Y0End = Y0;
            while (!successY0)
            {
                Console.WriteLine("Значение введено некорректно, повторите ввод");
                successY0 = Double.TryParse(Console.ReadLine(), out double Y0True);
                Y0End = Y0True;
            }
            Console.WriteLine("Введите шаг по X");
            bool successHx = Double.TryParse(Console.ReadLine(), out double hx);
            hxEnd= hx;
            while (!successHx || hxEnd < 0)
            {
                Console.WriteLine("Значение введено некорректно, повторите ввод");
                successHx = Double.TryParse(Console.ReadLine(), out double hxTrue);
                hxEnd= hxTrue;
            }
            Console.WriteLine("Введите шаг по Y");
            bool successHy = Double.TryParse(Console.ReadLine(), out double hy);
            hyEnd= hy;
            while (!successHy || hyEnd < 0)
            {
                Console.WriteLine("Значение введено некорректно, повторите ввод");
                successHy = Double.TryParse(Console.ReadLine(), out double hyTrue);
                hyEnd= hyTrue;
            }
            Console.WriteLine("Введите Количество шагов");
            bool successN = Int32.TryParse(Console.ReadLine(), out int N);
            NEnd = N;
            while (!successN)
            {
                Console.WriteLine("Значение введено некорректно, повторите ввод");
                successN = Int32.TryParse(Console.ReadLine(), out int NTrue);
                NEnd = NTrue;
            }
            Console.WriteLine($"{X0End} {Y0End} {hxEnd} {hyEnd} {NEnd}");
            for (int i = 0; i < NEnd; i++)
            {
                Console.WriteLine((Math.Sqrt(X0End+Y0End)*Math.Log(Y0End))+(Math.Abs(Math.Log(Y0End)))/(Math.Sqrt(X0End*X0End-Y0End*Y0End+3.2)));
                X0End= X0End + hxEnd;
                Y0End= Y0End + hyEnd;
            }
        }
    }
}