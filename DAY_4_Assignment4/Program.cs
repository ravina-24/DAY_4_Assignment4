using System;

namespace DAY_4_Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Enter input \n" +
                "1.Temperature Conversion \n" +
                "2.Square root of a non -negative c\n" +
                "3.Harmoic series \n" +
                "4.Trignometric function");

            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            switch (input)
            {

                case 1:
                    TemperatureConversion t = new TemperatureConversion();
                    t.convertTemperature();
                    break;

                case 2:
                    Sqrt s = new Sqrt();
                    s.caculateSquareRoot();
                    break;

                case 3:
                    HarmonicSeries h = new HarmonicSeries();
                    h.findHarmonicSeries();
                    break;

                case 4:
                    Trig T = new Trig();
                    T.TrignometricFunctions();
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.ReadLine();
        }
    }
}
