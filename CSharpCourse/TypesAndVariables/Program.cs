using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program // Basit bir classtan oluşur.
    {
        static void Main(string[] args) //Main diye Static bir metotdan oluşur.
        {
            //// f5 ile yada start butonu ile uygulamanızı çalıştırabilirsiniz.
            //Console.WriteLine("Hello World!");
            //// main metodu çalıştı
            //Console.ReadLine(); // Kullanıcın bir şey yazmasını bekliyor.

            // Veri tipleri -> 
            //integer -> Tam sayı veri tipidir. int 
            // Not -> Adıda üstüne olduğu gibi tam sayılarımızı ondalıklı olmayan sayılarımızı int ile tutuyoruz.
            //Not -> Aslına bakarsanız int veri tipinin dahil olduğu değer tipleri ile  referans tiplerinin nasıl çalıştığı konusunda yanlış bilgiye sahiptir.

            //int veri tipi Değer Tiplerinden bir tanesidir. Value Types
            //Value Types -> 
            int number1 = 2147483647; // Bütün veri tiplerinin bir sınırı vardır. int sınırları -2.147.483.648 ila 2.147.483.647
            Console.WriteLine("Numbe1 is {0}", number1); // Biz burada parametre alacağız.
            // 4.nesil programlama dillerinde java ve c# gibi dillerde biz bunlara index diyoruz. Sayma sayıları 0 dan başlıyor diyebiliriz.

            // int'ten daha büyük bir sayıyı tutmak istesek ne yapmamız gerekiyor long veri tipi giriyor. Normal int 2 katı kadar bellekte yer kaplıyor. Long kapsar int
            // Long tanımlayın int ne gerek var diyebilirsiniz bu dememeniz lazım çünkü bellekte 2 katı kadar yer kapladınız veri tipinze  göre static bir yer tanımlanıyor.

            // longun sınırı 19 karakterden oluşuyor.
            // int 32 bitlik yer kaplar long ise 64 bitlik yer kaplar.
            long number2 = -9223372036854775800;
            Console.WriteLine("Numbe1 is {0}", number2);

            //short veri tipi 16 bitlik yer tutar.
            short number3 = -32767;
            Console.WriteLine("Numbe1 is {0}", number3);

            // byte veri tipi -> Bellekte 8 bit yani 1 byte veri kaplayan veri tipi 0 ile 255  arasında int veri tutar.
            UInt64 number4 = 0xffffffffffffffff; // 0-255 arasında bir değişken değeriniz olduğunda emin olmalısınız. Int32, Int16
            Console.WriteLine("Numbe1 is {0}", number4);

            //boolean - Bool -> Mantıksal bir veri tipidir. Tutuğu değer true yada false dur. If gibi karşılaştırma bloklarında sıklıkla kullaınırız.
            // Buda bir değer tipi
            bool condition = true; // yada false ŞART anlamı
            Console.WriteLine("bool is {0}", condition);

            // char veri tipi buda değer tiplerinden bir tanesidir.
            // char veri tipi rahatlıkla int gibi bir veri tipine çevrilebilir.
            char character = 'A'; // Atama yapmak için tek tırnak kullanıyoruz. Genellikle ASCII dediğimiz klavyenizde kullanabileceğiniz bütün karakterleri tutmak adına kullanabilir.
                                  // char veri tipi rahatlıkla int gibi bir veri tipine çevrilebilir.
            
            Console.WriteLine("Character is : {0} \nHex is: 0x{1:X}",(int)character, (int)Convert.ToUInt32(character));
            Console.WriteLine("Character is : {0} ",(int)character);// 65 Değerini aslında ascii dediğimiz klavyenizdeki bütün kullanabileceğiniz karakterleri aslında bir karşılığı var sayısal bir karşılığı SWAPLAMA

            // Not-> İleride öğreneceğimiz string veri tipi aslında bir karkater dizisidir.
            string city = "Ankara"; // 6 Tane karakterden oluşan bir dizi diyebiliriz.
            Console.WriteLine("Character is : {0}", character);


            //Değer tiplerinden önemli bir veri tipi ise double veri tipidir. Bu veri tipinde tam sayılardan, yani int,short,byte,long'dan farklı olarak ondalıklı sayıları tutabiliyoruz. Bu bağlamda double diye bir değişken tanımladığınızda  ve  double veri tipi ondalıklı sayıları tutmak için kullanılıyor 64 bitlik veri tutuşu bellekte mevcuttur.
            double number5 = 10; // int gibi bir değer atabiliyoruz.
            number5 = 10.4;
            // int number1 = 21.4 yapsak double bir değeri bu şekilde  atayamayız.
            Console.WriteLine("Number5 is {0}", number5);

            // int için long neyse double içinde decimal odur diyebiliriz.
            // Genel olarak aslında sayısal verilerinizi ondalıklı olan daha çok  hesaplamalar için yapacağınız sayısal verilerinizi kullanırken birazda hassasiyet gösteren değerler için örneğin para tutarı için decimal veri tipinden yaralanabiliyoruz.

            //double veri türü ,'den sora 15 16 tane karakter tutabiliyorken decimal ise ,'den sonra 28 29 tane değer tutabiliyor.
            decimal number6 = 10.4M; // Decimaldede double gibi ondalıklı tutarlar sergileyemiyorsunuz. Değerin sonuna m harfni koymaktan geçiyor Küçük yada büyük olabiliyor. Eğer ondalık olmasaydı decimal için ->  decimal number6= 10; gibi direk bir atama yapabilirdik. Aslında burada implicit conversion denilen bir olayın olduğunu söyleyebiliriz. 

            // Veri tiplerine değer tipleri ile ilgili son olarak enumlardır.

            //enum-> En temel amaç programlamada magic string denilen değerler tutmak için yerine örneğin fakat enum ile programlaama yaparken merkezi bir noktadan biz bir enum sabiti vasıtasıyla değerleri tek  string gibi yazmamızı engelliyor.
            //string metinsel veri tipi tutar.
            string days = "Monday";

            Console.WriteLine("Number6 is {0}", number6);

            //if (Days.Friday == ) // Magic string "friday"
            //{

            //}
            // enum ile ilgili tip dönüşümleri önemlidir.
            Console.WriteLine((int)Days.Friday); // friday için 4 dedi 4 indexi aldı enum sabitleri

            // var Keywordü aslına bakarsanız bir değişken değildir. Fakat değişken tutmak için kullanılır.
            var number7 = 10; // Bizim atadığımız değeri tipi neyse artık varın tanımladığı veri tipi int olmuş olur.
            number7 = 'A'; // A'nın karşılığı 65 olacaktır.
            //number7 = "A"; // Bunu yapamayız.
            Console.WriteLine("Number7 is {0}", number7);

            Console.ReadLine();
        }

    }
    // 2 kere tab basıldığında gelir 

    enum Days // classımızın dışında yazdık.
    {
        Monday = 10, Tuesday = 5, Wednesday, Thursday, Friday, Saturday, Sunday
        // Başlangıç değeri verebiliriz.
    }

}
