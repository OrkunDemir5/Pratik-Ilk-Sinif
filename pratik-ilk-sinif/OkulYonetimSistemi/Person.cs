using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimSistemi
{
    public class Person
    {
        private string name;
        private string surname;
        //Tarih alacağımız için DateTime kullanıyorum.
        private DateTime birthday;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        // Ekrana yazdıran metod
        public void EkranaYazdir()
        {
            Console.WriteLine($"Ad: {Name}, Soyad: {Surname}, Doğum Tarihi: {Birthday.ToShortDateString()}");
        }
    }
}
