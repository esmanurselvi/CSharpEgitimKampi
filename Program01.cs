using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");


            #endregion

            #region String Değişkenler

            //string
            //Değişken_Türü değişken_adı;

            //string name;
            //name = "Esmanur";


            //Console.Write(name); //" olmamalı

            //string passengerName;  //ilk kelimenin ilk harf küçük ikinci kelimenin ilk harfi büyük
            //string passengerSurname;
            //string passengerPhone;
            //string passengerEmail, district, city; //bir satıra birden fazla değişken tanımlanabiliyor

            //passengerName = "Ali";
            //passengerSurname = "Çınar";
            //passengerPhone = "+90 500 400 30 20";
            //passengerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------- ");
            //Console.WriteLine("Müşteri: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("İletişim:" + passengerPhone);
            //Console.WriteLine("Email Adresi:" + passengerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("------------------------------------------------- ");


            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
       
            Console.WriteLine("----Hamburger: " + hamburgerPrice + " TL ");
            Console.WriteLine("----Kola: " + cokePrice + " TL ");
            Console.WriteLine("----Su: " + waterPrice + " TL ");
            Console.WriteLine("----Kızartma: " + friesPrice + " TL ");
            Console.WriteLine("----Pizza: " + pizzaPrice + " TL ");
            Console.WriteLine("----Limonata: " + lemonadePrice + "TL ");
            Console.WriteLine();

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0; //hepsi için ayrı ayrı yazılır.
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;
            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;


            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Hamburger Tutarı:"+totalHamburgerPrice + "TL"); //hepsi için ayrı ayrı yapılır.
            Console.WriteLine("Kola Tutarı:"+totalCokePrice + "TL"); 
            Console.WriteLine("Su Tutarı:"+totalWaterPrice + "TL"); 
            Console.WriteLine("Kızartma Tutarı:"+totalFriesPrice + "TL"); 
            Console.WriteLine("Pizza Tutarı:"+totalPizzaPrice + "TL"); 
            Console.WriteLine("Limonata Tutarı:"+totalLemonadePrice + "TL");
            Console.WriteLine("Toplam Tutar:"+totalPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");

         



            #endregion

            Console.Read(); //açılan sayfayı enter'a basana kadar korur

        }
    }
}








