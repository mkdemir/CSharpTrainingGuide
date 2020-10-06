# CSharpTrainingGuide
![alt text](https://github.com/mkdemir/CSharpTrainingGuide/blob/main/banner.jpeg?raw=true)

## Yazılım
İnsanların gündelik hayattaki aktivitelerinin bilgisayar destekli sistemlerle kolaylaştırılmasıdır.
* Sürecin kendisi olduğudur. Ve ürün kendisidir.
* Udemy.com bir yazılımdır. (Bir web arayüzü izliyoruz.)
* Yazılımın kalitesi müşteriyi ne kadar tatmin ettiğidir.
* Nesnelerin interneti, mikro işlemci programlama gibi eylemler sonucu ortaya çıkan ürünlerde birer yazılım olarak dünüşünebiliriz.
* Günümüzde yazılım insanın merkezinde olduğunu söyleyebiliriz.
* Yazılım bir süreçtir.
* Analizde başlar, modelleme, geliştirme, test ve yayına kadar deva eder.

## Programlama 
Yazılımın teknik tarafıdır. Yazılımın araksındaki kodlardır. Bu bakımdan program dediğiniz şey aslına bakarsanız. Ortaya çıkmış ürünü kasıt ederiz. Arkasında kodlar vardır o kodlar derlenir makina dilinden makine diline çevrilir. Bizin için görsel hale getirilir ve biz kullanıcılar bunu kullanırız.
* Örneğin bir udemy.com bir web programlama programlama aktivitesi sonucunda ortaya çıkmıştır.
* Örneğin udemy'inin mobil uygulaması veya kullandığınız whatsapp appi bunlar ise mobil programlamadır. Ardunio programlama iot programalamadır. İşin kodsal sürecidir.

### Programlama Mantığını Anlamak 
Örnek siz windows işletim sistemi kullanmaktasınız mouse ile sağ tık yağtığınızda karşınıza bir menü çıkar bu menün alt menüleride mevvuttur. Bunu işletim sistemi nasıl çalıştırır. İlk önce siz sağ tıkladığınızda bir komut gönderiyorsunuz işletim sistemine o komutun arka planda  ne yapacağına dair bir sonuç dönüyor. Ve çıkan sonuç ise menüdür.
* Bilgisayarlar bilmediği şeyi yapamaz.
* Biz bilgisayarın tanmımasını istedğimiz bir yapı var veri var bunlardan onu tanımlamasını istiyoruz. Programın belleğini silmediğimiz sürece değişkenin değerleri hatırlayacaktır.
* Programcı hem node içerisinde node bildiği yapınları kullanılır. Hem de node öğrenme sisteminin  ne olduğunu anlayıp ona göre davranır.
* Siz bir dilin söz dizimine hakimseniz siz o dilin programcısınızdır.
*  ''' beden = 50 '''-> Buna değer atama işlemi denir. 
* Programlama dilleri ingilizce söz dizimine uygun olarak kodlanırlar.
* Değişkeni tanımlarken, değişken isimleri bitişik yazılır. deneme-bir gibide olabilir. Büyük harfle başlamaz değişken isimleri ondan sonraki kelimler büyük harfle devam eder. Buna pascalcase deniyor.

**Node =**  Uygulamalarımızı çalıştırıp yayına alabiliyoruz. Onların paket yönetiminizi yapabiliyoruz. Node bir js motorudur. Node içinde yazdığımız kodlar javascript kodlarıdır. Node bir programalama motorudur.

## C# Çalışmama Başlarken 
**C# Üzerinde Geliştirme Yapmak İçin Bize Gerekli Olan Araçlarlar->**
	1. Universal Windows
	2. WPF Console App 
	3. Asp.net deveploment 
	4. .Net core-cross -> .net uygulamalar geliştirmek için --> modify diyoruz.

* Resharper diye bir eklenti var 
* Solution olarak başlayacağız. -> Blank Solution(Solution içerisinde birden fazla projeyi barındıran mimaridir.) Boş bir çözüm projesi oluşturuyoruz.
* 2017 sürümünde add to source control mevcut -> TFS ve SVN(Subversion) gibi ortamalara projemizi atmak için kullanılır. Bu ortamalar takım çalışmasının oldğuğu yerlerde kodların paylaşılması tek bir yerde yönetilmesi amacı ile kullanılır.
* View menüsünden solution explorer açabilirsiniz.
* Ben her bir konu için bir proje oluşturacam sizin için bir kütüphane görevi görecek
* Biz C# şablonları ile çalışacağız herhangi bir şablonu tercih edebiliriz. (WCF, Test) -> Uygulama hayatımızda 2 veya 3 tane projede çalışıyor olacağız.
* İlk projem veri tipleri üzerinde olacak dolayısıyla  Console app .net core -> Yeni nesil .net mimarisi açık kaynak .net mimarisi için farklı platformalarda çalışabilen ortamlar için tercih edebileceğimiz uygulamalardır.
* .net core ile ilk yapılandırmalarla uğraşmak yerine (Piyasadaki çoğu uygulamada .net framework ile elde edilmiştir.) .net core ciddi bir kullanım olgunluğuna gelmemiştir. Zamanla gelecektir.
* Console app -> Bu bir konsol uygulamasıdır. Consol uygulaması aslına baksanız profesyonel iş hayatında kullanım alanları var örnek bir servisin host edilmesi aslında bir siyah ekran kodlarımızı gerçekleştirip orada görebiliyoruz. Genellikle eğitimizde amacımız dili anlatmaksa rahat ve hızlıca uygulama yapabiliriz.
* Resharper diye bir eklenti var 
* Solution olarak başlayacağız. -> Blank Solution(Solution içerisinde birden fazla projeyi barındıran mimaridir.) Boş bir çözüm projesi oluşturuyoruz.
* 2017 sürümünde add to source control mevcut -> TFS ve SVN(Subversion) gibi ortamalara projemizi atmak için kullanılır. Bu ortamalar takım çalışmasının oldğuğu yerlerde kodların paylaşılması tek bir yerde yönetilmesi amacı ile kullanılır.
* View menüsünden solution explorer açabilirsiniz.
* Ben her bir konu için bir proje oluşturacam sizin için bir kütüphane görevi görecek
* Biz C# şablonları ile çalışacağız herhangi bir şablonu tercih edebiliriz. (WCF, Test) -> Uygulama hayatımızda 2 veya 3 tane projede çalışıyor olacağız.
* İlk projem veri tipleri üzerinde olacak dolayısıyla  Console app .net core -> Yeni nesil .net mimarisi açık kaynak .net mimarisi için farklı platformalarda çalışabilen ortamlar için tercih edebileceğimiz uygulamalardır.
* .Net Core ile ilk yapılandırmalarla uğraşmak yerine (Piyasadaki çoğu uygulamada .net framework ile elde edilmiştir.) .net core ciddi bir kullanım olgunluğuna gelmemiştir. Zamanla gelecektir.
* Console App: Bu bir konsol uygulamasıdır. Consol uygulaması aslına baksanız profesyonel iş hayatında kullanım alanları var örnek bir servisin host edilmesi aslında bir siyah ekran kodlarımızı gerçekleştirip orada görebiliyoruz. Genellikle eğitimizde amacımız dili anlatmaksa rahat ve hızlıca uygulama yapabiliriz.
