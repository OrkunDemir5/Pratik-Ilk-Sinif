//Class'ı çağırıyoruz
namespace OkulYonetimSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ogrenci1 = new Person();
            Person ogrenci2 = new Person();

            Person ogretmen1 = new Person();
            Person ogretmen2 = new Person();
            //Öğrenci Bilgileri
            ogrenci1.Name = "Orkun";
            ogrenci1.Surname = "Demir";
            ogrenci1.Birthday = new DateTime(1999, 8, 9);

            ogrenci2.Name = "Umur";
            ogrenci2.Surname = "Demir";
            ogrenci2.Birthday = new DateTime(1999, 9, 22);
            //Öğretmen Bilgileri
            ogretmen1.Name = "İsmail";
            ogretmen1.Surname = "Sağıroğlu";
            ogretmen1.Birthday = new DateTime(1974, 5, 14);

            ogretmen2.Name = "Murat";
            ogretmen2.Surname = "Algül";
            ogretmen2.Birthday = new DateTime(1973, 3, 30);

            //Öğrenci bilgileri ekrana yazdır
            Console.WriteLine("Öğrenci Bilgileri: ");
            ogrenci1.EkranaYazdir();
            ogrenci2.EkranaYazdir();

            // Öğretmen bilgileri ekrana yazdır
            Console.WriteLine("Öğretmen Bilgileri: ");
            ogretmen1.EkranaYazdir();
            ogretmen2.EkranaYazdir();

        }
    }
}
