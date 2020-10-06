using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir öğretmenin 10 tane öğrencisi olsun 
            string student1 = "Engin";// string veri tipi -> Metinsel veri tiplerini kullanırız ve referans tiptir kendisi
            string student2 = "Derin";
            string student3 = "Salih";
            // Arrayler -> Aynı tipteki değerleri tek bir noktada yönetme hızlıca ulaşmak için arraylarden yaralarnır.
            string[] students = new string[3];
            //string[] students = new string[3] { "Derin","Ali","Ayşe"};
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = { "Engin", "Salih", "Derin" }; // new []{} desekte çalışır no problem



            foreach (var student in students) // arrayi gezmek için foreach föngüsü kullanılır.
            {
                Console.WriteLine(student);
            }
            // Yayına geçmeden hata almaya compile time error denir. Derleme zamanı hatası

            // Veri tabanında bir çok kaydı çekip oraya atmak için kullanıyoruz Ama  genelde koleksiyonlar kullanılır. Koleksiyonlar arraylerin iyileştirilmiş arraydir kendileri ama arraylerin daha kolay kullanımı için tasarlanmış.

            // Kısıt arrayin belleğini aştın. student[3] = "Ahmet";
            // Çok boyutlu diziler -> multi dimensional

            //string[,] regions = new string[7, 3]; // Türkiyede 7 bölge 3 şehir 7 satır 3 sutun
            //regions[0, 0] = "İstanbul";

            string[,] regi





            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
