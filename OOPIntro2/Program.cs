using Newtonsoft.Json;
using OOPIntro2.Manager;
using OOPIntro2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            //AdminUser adminuser = new AdminUser();
            //adminuser.Name = "Çağatay";
            //adminuser.SurName = "Yıldız";
            //adminuser.Phone = "5437331470";
            //adminuser.EMail = "cagatay.yildiz@bilgeadam.com";

            //AdminUserManager.Add(adminuser);
            string data = File.ReadAllText(@"C:\Users\Cagatay\source\repos\OOPIntro\OOPIntro2\jsonfiles\products.json");

            //ProductVM[] products = JsonConvert.DeserializeObject<ProductVM[]>(data);

            //Çektiğimiz json datayo Generic List e dönüştürüyoruz
            List<ProductVM> products = JsonConvert.DeserializeObject<List<ProductVM>>(data);

            //id si 7 olan ürünü getir
            ProductVM product = products.FirstOrDefault(q => q.id == 7);

            //Adı Ikura olan ürünü getir
            ProductVM product2 = products.FirstOrDefault(q => q.name == "Ikura");

            //Listeyi name e göre sıralar
            List<ProductVM> products2 = products.OrderBy(q => q.name).ToList();

            //Listeyi name e göre tersten sıralar
            List<ProductVM> products3 = products.OrderByDescending(q => q.name).ToList();

            //Stoğu 0 olan ÜRÜNLERİ getir
            List<ProductVM> products4 = products.Where(q => q.unitsInStock == 0).ToList();

            //category id si 4 olan ve fiyatı 20 den büyük olan ÜRÜNLERİ getir
            List<ProductVM> products5 = products.Where(q => q.categoryId == 4 && q.unitPrice > 20).ToList();


            //ürün adı a harfi ile BAŞLAYANLAR
            List<ProductVM> products6 = products.Where(q => q.name.StartsWith("A")).ToList();

            //Ürün adı içerisinde x geçen ÜRÜNLER
            List<ProductVM> products7 = products.Where(q => q.name.Contains("x")).ToList();


            //Maksimum fiyatı getirir. select işlemi içerisinden o kolonu seçmemizi sağlar
            double maxfiyat = products.Select(x => x.unitPrice).Max();




            Console.ReadLine();


            List<string> isimler = new List<string>();
            isimler.Add("Berk");
            isimler.Add("Çağatay");
            isimler.Add("Şokobons");


        }
    }
}
