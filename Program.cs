using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rekursi ~Öz yinelemeli
            //3^4=3*3*3*3
            int result=1;
            for (int i = 1; i < 5; i++)
            {
                result*=3;
            }
            Islemler instance=new Islemler();
            Console.WriteLine(instance.Expo(3,4));
            
            //extension Metotlar
            string ifade="ali kızıldaş c# ile code yazıyor";
            bool sonuc=ifade.checkSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi={9,3,6,2,1,5,0};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi=5;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstchar());
        }
    }

    public class Islemler
    {
        public int Expo(int sayi,int us)
        {
            if (us<2)
                return sayi;
            return Expo(sayi, us-1)*sayi;         
        }
    }
    public static class Extension
    {
        public static bool checkSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi=param.Split(" ");
            return string.Join(" * ",dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
            Console.WriteLine(item);
        }
        public static bool IsEvenNumber(this int param)
        {
            return param%2==0;
        }
        public static string GetFirstchar(this string param)
        {
            return param.Substring(0,1);
        }

    }

}
