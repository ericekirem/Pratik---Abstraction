using System;

namespace Company
{
    // Abstract sınıf
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        // Abstract metot (her çalışan kendine göre bunu dolduracak)
        public abstract void Gorev();
    }

    // Yazılım Geliştirici sınıfı
    class SoftwareDeveloper : Employee
    {
        public override void Gorev()
        {
            Console.WriteLine($"{FirstName} {LastName} bir Yazılım Geliştirici olarak çalışıyorum.");
        }
    }

    // Proje Yöneticisi sınıfı
    class ProjectManager : Employee
    {
        public override void Gorev()
        {
            Console.WriteLine($"{FirstName} {LastName} bir Proje Yöneticisi olarak çalışıyorum.");
        }
    }

    // Satış Temsilcisi sınıfı
    class SalesRepresentative : Employee
    {
        public override void Gorev()
        {
            Console.WriteLine($"{FirstName} {LastName} bir Satış Temsilcisi olarak çalışıyorum.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Çalışan nesnelerini oluştur
            Employee developer = new SoftwareDeveloper
            {
                FirstName = "İrem",
                LastName = "Eriçek",
                Department = "Yazılım"
            };

            Employee manager = new ProjectManager
            {
                FirstName = "Hasan",
                LastName = "Çıldırmış",
                Department = "Proje Yönetimi"
            };

            Employee sales = new SalesRepresentative
            {
                FirstName = "Ali",
                LastName = "Yılmaz",
                Department = "Satış"
            };

            // Her çalışanın görevini yazdır
            developer.Gorev();
            manager.Gorev();
            sales.Gorev();
        }
    }
}
