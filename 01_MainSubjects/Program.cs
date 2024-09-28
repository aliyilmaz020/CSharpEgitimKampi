using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Hi");
            //Console.Write("Selam");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            #endregion

            #region Değişkenler
            string name;
            name = "Ali";
            Console.WriteLine(name);

            string customerName;
            string customerSurname;
            string customerEmail;
            
            customerName = "Ali";
            customerSurname = "Veli";
            customerEmail = "aaa@gmail.com";

            Console.WriteLine("*** Rezervasyon Kartı ***");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("E-Posta: " + customerEmail);
            Console.WriteLine("-----------------------");

            #endregion


            Console.Read();
        }
    }
}
