﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" &country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}

            //int number;
            //Console.Write("Sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1+exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if(average > 70 & average <= 84)
            //{
            //    result = " Sonuç İyi";
            //}
            //if(average > 85 & average <= 100)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}
            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine(result);


            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}
            #endregion

            #region Char ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team =='G' |team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if(team == 'F' | team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if(team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("****** C# Eğitim Kampı Restorant ******");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------------------");


            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1") {

            //   Console.WriteLine();
            //   Console.WriteLine("----------------Ana Yemekler------------------");
            //   Console.WriteLine();
            //   Console.WriteLine("1-Köri Soslu Tavuk");
            //   Console.WriteLine("2-Kızartma Tabağı");
            //   Console.WriteLine("3-Fasulye Pilav");
            //   Console.WriteLine("4-Fırında Somon");
            //   Console.WriteLine("5-Patlıcan Musakka");
            //   Console.WriteLine("----------------Ana Yemekler------------------");
            //   Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("----------------Çorbalar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("----------------Çorbalar------------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "3")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("----------------Pizzalar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Tavuklu Pizza");
            //    Console.WriteLine("3-Margaritha");
            //    Console.WriteLine("----------------Pizzalar------------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("----------------İçecekler------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Su");
            //    Console.WriteLine("3-Gazoz");
            //    Console.WriteLine("----------------İçecekler------------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("----------------Tatlılar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Triliçe");
            //    Console.WriteLine("3-Kek");
            //    Console.WriteLine("----------------Tatlılar------------------");
            //    Console.WriteLine();

            //}
            #endregion
            Console.Read();

        }
    }
}
