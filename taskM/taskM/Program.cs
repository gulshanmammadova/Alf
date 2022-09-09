using System;

namespace taskM
{
    class Program
    {
        static void Main(string[] args)
        {
        #region Task1 
            //Arrayin butun elementlerini musbet edede cevirmek;
            int[] arr = { 1, -2, 3, 0, -12, -234, 78, 4354 };


            Console.WriteLine("yeni Array elemetleri;");
            int[] NEWARR = NewArr(arr);
            foreach (int ITEM in NEWARR)
            {
                Console.WriteLine(ITEM);
            }
            #endregion
        #region Task2
            //Daxil edilmis stringin icinde reqem olub olmadigini yoxlayan metod yazin;
            Console.WriteLine("stringi daxil edin;");
            string text = Console.ReadLine();
            SearchDigitInString(text);

            #endregion
        #region Task3
            //Ardicil l, a ve s diger charlarin ardicil yerlesmesini yoxlayan metod.eger iki char ardicil yerleserse vardir yazir

                Console.WriteLine("ilk char i daxil edin;");
            string herf4 = Console.ReadLine();
            char herf1 = char.Parse(herf4);
            Console.WriteLine("ikinci char i daxil edin;");
            string herf3 = Console.ReadLine();
            char herf2 = char.Parse(herf3);
            Console.WriteLine("string arrayi  daxil edin;");
            string metn = Console.ReadLine();
            int count = Ardicil(metn,herf1,herf2);
            Console.WriteLine(count);
            
          

            #endregion
        }
        #region Task1
        static int[] NewArr(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i] * -1;
                }
            } return arr;
        }
        #endregion
        #region Task2
        static void SearchDigitInString(string text)
        { int countdigit = 0;
            int countUNdigit = 0;
            for (int i = 0; i < text.Length; i++)
            {

                char a = text[i];
                if (char.IsDigit(a))
                {
                    countdigit++;
                }
                else
                    countUNdigit++;
            }
            if (countdigit == 0)
            {
                Console.WriteLine("text-de ancaq herf var.");

            }
            else if (countUNdigit == 0)
            {
                Console.WriteLine("text-de ancaq reqem var.");

            } else
                Console.WriteLine("text-dehem reqem hem herf vae");
        }

    
    #endregion
        #region Task3
    static int Ardicil(string metn, char herf1, char herf2)
         {

        int count = 0;
        for (int i = 0; i < metn.Length; i++)
        {
            if (metn[i] == herf1 && metn[i + 1] == herf2)
            {
                count++;
            }
        }
        return count;
         }
    }
    #endregion


}
