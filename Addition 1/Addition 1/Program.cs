using System;

namespace Addition_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Calculator
            Console.WriteLine("Welcome , Calculator!");
            Console.WriteLine("ededleri daxil et;");
            string input1 = Console.ReadLine();
            double eded1 = double.Parse(input1);
            string input2 = Console.ReadLine();
            double eded2 = double.Parse(input2);

            Console.WriteLine("emeliyyati secin;");

            Console.WriteLine("1-vurma");

            Console.WriteLine("2-bolme");
            Console.WriteLine("3-toplama");
            Console.WriteLine("4-cixma");
            string emel = Console.ReadLine();
            double emeliyyat = double.Parse(emel);
            switch (emeliyyat)
            {
                case 1:
                    Console.WriteLine(eded1 + "*" + eded2 + "=" + eded1 * eded2);
                    break;
                case 2:
                    Console.WriteLine(eded1 + "/" + eded2 + "=" + eded1 / eded2);
                    break;
                case 3:
                    Console.WriteLine(eded1 + "+" + eded2 + "=" + eded1 + eded2);
                    break;
                case 4:
                    Console.WriteLine(eded1 + "-" + eded2 + "=" + (eded1 - eded2));
                    break;
            }
            #endregion
            #region Vurmacedveli
            for (int a = 1; a <= 10; a++)
            {
                Console.WriteLine(a + "-nin vurma cedveli;");
                for (int b = 1; b <= 10; b++)
                {
                    Console.WriteLine(a + "*" + b + "=" + a * b);
                } }
            #endregion
            
        }
    }
}
