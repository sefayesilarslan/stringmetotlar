namespace StringMetotlar
{
    class stringler
    {

        public static void Main(string[] args)
        {
            string degisken = "Dersimiz C#, Hoşgeldiniz!";

            string degisken2 = "Dersimiz";

            Console.WriteLine(degisken.Length);

            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            Console.WriteLine(string.Concat(degisken, " Merhaba"));


            Console.WriteLine(degisken.CompareTo(degisken2));//Birinci değişken ikinci değişkenden büyükse 1 eşitse 0 küçükse -1 döndürür.
            Console.WriteLine(string.Compare(degisken, degisken2, true)); //iki değişkeni karşılaştır ve büyük küçük harf önemli.

            Console.WriteLine(string.Compare(degisken, degisken2, false)); //iki değişkeni karşılaştır ve büyük küçük harf önemseme



            Console.WriteLine(degisken.Contains(degisken2)); // Değişkenin içerisinde değiken2 var mı true false döner


            Console.WriteLine("*********************");
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            Console.WriteLine("*********************");


            Console.WriteLine(degisken.IndexOf("C#")); // IndexOf degişkenin içinde verilen ifadeyi arar varsa kaçıncı indexteyse onu verir yoksa -1 verir.
            Console.WriteLine(degisken.IndexOf("Sefa"));


            Console.WriteLine(degisken.Insert(0, "Merhaba! ")); // 0. indexten başlayarak metne verilen ifadeyi ekler.


            Console.WriteLine(degisken.LastIndexOf("i")); //Verilen ifadeyi değişken içerisinde arar ve buldugu indexi yazar.

            Console.WriteLine("*********************");

            Console.WriteLine(degisken + degisken2.PadLeft(30)); //Degişken ile değişken2 yi birleştirdik ve  değişken2 yi 30 karaktere tamamlayacak kadar Boşluk ekledik.

            Console.WriteLine(degisken + degisken2.PadLeft(30, '*')); //Degişken ile değişken2 yi birleştirdik ve  değişken2 yi 30 karaktere tamamlayacak kadar * ekledik.


            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);



            Console.WriteLine(degisken.Remove(10));// 10. karakterden sonrasını siler.

            Console.WriteLine(degisken.Remove(5, 3)); // 5. karakterden başla 3 karakter sil



            Console.WriteLine(degisken.Replace("C#","Csharp")); //Değiştirir
            Console.WriteLine(degisken.Replace(" ","*"));


            Console.WriteLine(degisken.Split(' ')[1]); // Boşluklara göre parçalar ve bir diziye atar ve bize 1. indisi verir


            Console.WriteLine(degisken.Substring(4)); // 4. indexten başlayarak bize getirir.
            Console.WriteLine(degisken.Substring(4,10)); // 4. indexten başlayarak 10 karakteri bize getirir.

            

        }

    }
}