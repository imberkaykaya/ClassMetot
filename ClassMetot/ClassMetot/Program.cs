namespace ClassMetot;
class Program
{
    static void Main(string[] args)
    {
        Musteri musteri1 = new Musteri();
        musteri1.Ad = "Muhittin";
        musteri1.Soyad = "Karaca";
        musteri1.Sehir = "İzmir";

        Musteri musteri2 = new Musteri();
        musteri2.Ad = "Neşet";
        musteri2.Soyad = "Ertaş";
        musteri2.Sehir = "Niğde";

        Musteri musteri3 = new Musteri();
        musteri3.Ad = "Oğuz";
        musteri3.Soyad = "Atay";
        musteri3.Sehir = "LA";

        Musteri[] musteriEkle = new Musteri[] { musteri1, musteri2};

        Musteri[] musteriListele = new Musteri[] { musteri1, musteri3 };

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Add(musteriEkle);
        musteriManager.Delete(musteri2);
        musteriManager.Listele(musteriListele);
    }
}