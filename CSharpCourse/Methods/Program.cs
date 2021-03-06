﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metotlar -> Bizim için en temelinde dry prensibinin en iyi implementasyonlarında biridir.
            // Proje isimleri büyük harfle başlar. Best Practise Doğru yapma standartı .net uygulamarındaki klasik standartımızdır. PascalCase ikinci kelimede başlar.

            //Add(); // Metodun çağırımı sağladık.
            //Add();
            //Add(); // dry felsefesi için yaparız.
            //var result = Add2(20);
            //Console.WriteLine(result);

            //int number1 = 20; // Değer tip 
            //int number1;
            //int number2 = 100;

            ////var result2 = Add3(ref number1, number2);
            //var result2 = Add3(out number1, number2);

            //Console.WriteLine(result2);
            //Console.WriteLine(number1); // Sonuç 20'dir. Neden çünkü biz burada değer tipler için çalışıyoruz. Değer tipler ile referans tiplerin farkını öğrenmeliyiz. Değer tiplerde tamamen değişkenin tipleri ile ilgilenir. Değer tipler için geçerli

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4,5));

            Console.WriteLine(Add4(1,2,3,4,5,6));

            Console.ReadLine(); // Konsol dursun diye yazdık.

        }

        // Metotları ne için yapıyoruz. Veri tabanına bir kullanıcının verilerini kayetme ihityacınız var. Bir işlemi tekrardan yapmak yerine 1 kere yapıp tek bir merkezden kontrol edebilme imkanı  sağlar.

        // static içinde kullanacağımız için static yazmamız gerekiyor.
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        //static void Add2(int number1, int number2) // Benim buraya toplama yapabilmek için parametre göndermem gerekir. 2 tane değişken yani parametreyi buraya göndermesi lazım.
        //{
        //    var result = number1 + number2;
        //    return result; // altı çiziliyor. Bu bir void değil 
        //    // void -> Git şunu yap demek bir işlem yap bir yere bir şey yaz yada kayıt yap demek.
        //}

        //static int Add2(int number1, int number2) // ne tipte bir veri döndürmek istiyorsak o tipte bir veri yazıyoruz.
        //{
        //    var result = number1 + number2;
        //    return result; // Sonuç döndürdük.
        //}

        // Son dönemlerde gelen default parametrelerle çalşma
        static int
            Add2(int x, int number1 = 30,
                int number2 = 30) // Eğer number 2 verilmezse o zaman default değer olarak 30 kullan
            // Default değerler herzaman metodun en son tarafında olması lazım.
        {
            var result = number1 + number2;
            return result;
        }
        // kdv hesaplama mesla 0.18 kdv 

        // Challenge Sorusu ->

        // Eğer yukarıdaki number1 değerininde değerini değişmesini istiyorsak ref keywordi ile yani  referans tip gibi
        //static int Add3(ref int number1, int number2) // int döndüren bir metot
        //{
        //    number1 = 30;
        //    return number1 + number2;
        //}

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        // ref ile bellekte 2 tane veri dönderdiğinizde metodda alsında 2 tane değişken tanımlanıyor. Bunu yapma yukarıdaki number1'in referansını kullan.

        // ref keywordü çok önemlidir. Değer tiplerinin referans tip gibi kullanılmasını sağlar. 

        // ref bide bir alternatifi var out dediğimiz keyword idir.
        // Değer tipi referans tipi gibi gönderme
        // farkı ref de number1 set mutlaka set etmeniz gerekiyor. Yani bir değerin olması gerekiyor. Ama outta böyle bir zorunluluk yok.
        // out ta bir kere fonk içinde set etmemiz gerkiyor.

        // Method Overloading -> 
        static int Multiply(int number1, int number2) // Bazı yerlerde 3 tane sayıyı çarpmak gibi bir ihtiyacım varsa // Buraya ayrıca methodun imzası deniyor. int den itibaren int döndüren vb.
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3) // Bazı yerlerde 3 tane sayıyı çarpmak gibi bir ihtiyacım varsa
        // Siz yukarıda aynı ismi kullanıyoranız farklı parametreler kullanıyorsunuz hiçbir sıkıntı yok buna methodların methodların overload yani aşırı yüklenmesi deniyor 
        {
            return number1 * number2 * number3;
        }

        // Challenge Params Keyword İle -> 

        static int Add4(int number, params int[] numbers) // Dizi notasyonu ile yazıyorsunuz. Ben dizi formatında parametreyi yollayabiliriz. Aynı parametre olması lazım
        // Önce bir sayıda yolluyabilirsiniz.
        // paramsdan sonra yazamayız parametre
        {
            return numbers.Sum() + number; // Bu bir fonk hazır methodlardan biri daha doğrusu dizi sayısal olduğu için dizideki bütün sayıları topla
        }
      

    }

}
