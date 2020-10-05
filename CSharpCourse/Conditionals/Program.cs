using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // var number = 11; // Ben sayının geliş değerine göre bir karar bloğu oluşturabiliriz.

            //if (number == 10) // Burada mantıksal bir karşılaştırma kapılıyor ve   karşılaştırma yapmamız gerekiyor burada mantıksal operatörleri kullanıyoruz.Örnek ==
            //{
            //   Console.WriteLine("Number is 10");
            //}
            //else if(number == 20){
            //    Console.WriteLine("Number is 20");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10 or 20");
            //}

            // Single Line if dediğimiz bir yazım tekniğine karşılık gelir.
            //Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            // Yeni nesil programlamada kullanılan bir syntax resharper diye bir eklenti var

            // switch -> Çok yoğun olarak kullandığımız bir blok türü değildir.

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break; // Burada olayı kes demektir.
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break; // Burada olayı kes demektir.
            //    //  Bunların dışında bir durum olursa
            //    default:// keywordünden yararlanıyoruz.
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //}
            // ctrl + k + d -> Indentesiyon dediğimiz kodu doğru kodu içerikleme yani kodu daha okunaklı hale getirme.
            //ctrl + k  c -> Comment bloğu oluşşur veya ctrl + k + u

            // Demo -> Bir sayının yüzlük dilimlerde nereye geldiğini bulma
            //number = 201;
            //if (number >= 0 && number <= 100) // && and 
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 101-200");
            //}
            //else if (number > 200 || number < 0) // || veya pipe boru anlamına gelir.
            //{
            //    Console.WriteLine("Number is less then 0 or greator than 200");
            //}
            // Int çevçevisinde 3 üç bloğa girmeyen bir sayı olmayacağı için şart sınırlama yaptık buna conditional boundary denir.
            // // Else yazmamıza gerek kalmadı.

            // Nested If -> İç içe ifler

            int number = 201;

            if (number < 100)
            {
                if (number >= 90 && number<95)
                {
                    Console.WriteLine("Number is less then 0 or greator than 95");
                }
                else
                {
                    
                }

            }

            

            Console.ReadLine();
        }
    }
}
