using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            tapsiriq 7

            int[] n = { 100, 50, 20, 10, 5, 1 };
            int mebleg, say, i;
            Console.Write("meblegi daxil edin:");
            mebleg = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= 5; i++)
            {
                say = mebleg / n[i];
                if (say != 0)
                    Console.WriteLine(say + " eded - " + n[i] + "AZN ");
                mebleg %= n[i];
            }

            tapsiriq 6
            string a = "tenbel";

            string cumle = Console.ReadLine();


            bool axtarilan = cumle.Contains(a);

            if (axtarilan == true)
            {
                string c = cumle.Replace("tenbel", "loser");
                Console.WriteLine(c);

            }

            tapsiriq 5
            List<string> keywords = new List<string>() { "Tenbel", "Kod yazmayan", "Yola Veren", "Esneyen", "Bekar" };
            string cumle = Console.ReadLine();
            for (int i = 0; i < keywords.Count; i++)
            {
                bool axtarilan = cumle.Contains(keywords[i]);

                if (axtarilan == true)
                {
                    Console.WriteLine("siz loser'siniz");
                }
            }

            tapsiriq 4

            string cumle = Console.ReadLine();

            string[] ifadeler = cumle.Split(' ', ',', ';');
            foreach (string soz in ifadeler)
            {
                Console.WriteLine(soz);
            }

            tapsiriq 3

            string soz;
            soz = Console.ReadLine();
            for (int i = 0; i < soz.Length; i++)
            {
                if (soz[i] == 'a' || soz[i] == 'A' || soz[i] == 'e' || soz[i] == 'E' || soz[i] == 'I' || soz[i] == 'i' || soz[i] == 'o' || soz[i] == 'O' || soz[i] == 'u' || soz[i] == 'U')
                {

                    Console.WriteLine("{0}-saitdir", soz[i]);
                }
                else
                {
                    Console.WriteLine("{0}-samitdir", soz[i]);
                }
            }

            tapsiriq 2
            int n, sum = 0;
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {

                sum = sum + (n % 10);
                n = n / 10;
            }
            Console.WriteLine(sum);

            tapsiriq 1

            int n, i = 1;
            n = Convert.ToInt32(Console.ReadLine());
            1.i = n.ToString().Length;
            Console.WriteLine(i);
            2.while ((n /= 10) >= 1)
            {
                i++;
            }
            Console.WriteLine(i);


        }
    }
}
