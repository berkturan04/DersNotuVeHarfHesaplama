namespace DersNotuVeHarfHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ders adını giriniz: ");
            string dersAdi = Console.ReadLine();

        NotGirisi:
            Console.Write("Vize notunu giriniz (0-100): ");
            bool vizeOk = int.TryParse(Console.ReadLine(), out int vize);

            Console.Write("Final notunu giriniz (0-100): ");
            bool finalOk = int.TryParse(Console.ReadLine(), out int final);

            //tryparse metodu ile kullanıcıdan alınan değerin gerçekten sayı olup olmadığı kontrol ediliyor.

            //Böylelikle kullanıcı 99.5 gibi sayılar veya abc gibi sözel ifadeler girerse kabul edilmiyor.

            if (!vizeOk || !finalOk || vize < 0 || vize > 100 || final < 0 || final > 100)
            {
                Console.WriteLine("Hatalı giriş yaptınız. Lütfen 0-100 arasında geçerli bir not giriniz.");
                goto NotGirisi;
            }

            double ortalama = (vize * 0.4) + (final * 0.6);
            string harfNotu;

            if (ortalama <= 50)
                harfNotu = "D";
            else if (ortalama <= 60)
                harfNotu = "C2";
            else if (ortalama <= 65)
                harfNotu = "C1";
            else if (ortalama <= 70)
                harfNotu = "B2";
            else if (ortalama <= 75)
                harfNotu = "B1";
            else if (ortalama <= 85)
                harfNotu = "A2";
            else
                harfNotu = "A1";

            Console.WriteLine($"{dersAdi} dersi dönem sonu puanınız: {ortalama}, ders harf notunuz: {harfNotu}");
            Console.WriteLine(ortalama < 50 ? "Kaldınız" : "Geçtiniz");
        }
    }
}
