using System;
namespace ClassMetot
{
	public class MusteriManager
	{
		public void Add(Musteri[] musteri)
		{
			foreach (var musteriler in musteri)
			{
                Console.WriteLine("Müşteri Kaydı Eklendi"+ ": "+ musteriler.Ad);
            }
		}
		public void Delete(Musteri musteri)
		{
			Console.WriteLine("Müşteri Kaydı Silindi: " + musteri.Ad);
		}
		public void Listele(Musteri[] musteri)
		{
			foreach (var musteriList in musteri)
			{
				Console.WriteLine("Müsteri Listesi:" + musteriList.Ad);
			}
		}
	}
}

