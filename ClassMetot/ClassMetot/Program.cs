namespace ClassMetot;
class Program
{
    static void Main(string[] args)
    {
        Musteri musteri1 = new Musteri();
        musteri1.Ad = "Aziz";
        musteri1.Soyad = "Sancar";
        musteri1.Sehir = "Mardin";

        Musteri musteri2 = new Musteri();
        musteri2.Ad = "Neşet";
        musteri2.Soyad = "Ertaş";
        musteri2.Sehir = "Kırşehir";

        Musteri musteri3 = new Musteri();
        musteri3.Ad = "Oğuz";
        musteri3.Soyad = "Atay";
        musteri3.Sehir = "Kastamonu";

        Musteri[] musteriEkle = new Musteri[] { musteri1, musteri2};

        Musteri[] musteriListele = new Musteri[] { musteri1, musteri3 };

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Add(musteriEkle);
        musteriManager.Delete(musteri2);
        musteriManager.Listele(musteriListele);
    }
}