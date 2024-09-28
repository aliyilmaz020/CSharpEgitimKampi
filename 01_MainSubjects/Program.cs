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

            #region StringDeğişkenler
            //string name;
            //name = "Ali";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail;

            //customerName = "Ali";
            //customerSurname = "Veli";
            //customerEmail = "aaa@gmail.com";

            //Console.WriteLine("*** Rezervasyon Kartı ***");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("E-Posta: " + customerEmail);
            //Console.WriteLine("-----------------------");

            #endregion

            #region IntDeğişkinler

            //int number = 23;
            //Console.WriteLine(number);

            int hamburgerPrice = 234;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 300;
            int lemonadePrice = 10;

            Console.WriteLine("*** Menü Fiyatı ***");
            Console.WriteLine();
            Console.WriteLine("---Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("---Kola: " + cokePrice + " TL");
            Console.WriteLine("---Su: " + waterPrice + " TL");
            Console.WriteLine("---Kızartma: " + friesPrice + " TL");
            Console.WriteLine("---Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("---Limonata: " + lemonadePrice + " TL");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount; 
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;


            hamburgerCount = 4;
            cokeCount = 2;
            waterCount = 3;
            friesCount = 9;
            pizzaCount = 10;
            lemonadeCount = 5;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("-------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice+ " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice+ " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice+ " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice+ " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice+ " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice+ " TL");

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice+totalPizzaPrice+totalLemonadePrice;
            Console.WriteLine();
            Console.WriteLine("Toplam: " + totalPrice + " TL");
            #endregion


            Console.Read();
        }
    }
}
