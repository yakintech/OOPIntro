using Newtonsoft.Json;
using OOPIntro2.Interfaces;
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

            OrderManager.GetOrders(200);


       

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


            //Ürünün kategorisinin adı Confections olan kaç adet ürün var?
            int count = products.Where(q => q.category?.name == "Confections").Count();


            List<string> isimler = new List<string>();
            isimler.Add("Berk");
            isimler.Add("Çağatay");
            isimler.Add("Şokobons");

            List<ProductVM> model = ProductManager.GetAllProducts();
            ProductVM model2 = ProductManager.GetProductByID(20);

            List<ProductVM> model3 = ProductManager.GetProductsByName("q");


            List<ProductVM> model4 = ProductManager.GetProductsByCategoryName("Confections");


           



            Word wm = new Word();
            wm.PageSize = 200;
            wm.PageContent = "bla bula bla";
            PrintDeneme(wm);


            PDF pdf = new PDF();
            pdf.PageSize = 100;
            pdf.PageContent = "pdf content";
            PrintDeneme(pdf);



            Product pr = new Product();
            pr.Name = "IPhone";
            pr.LogAddDate = DateTime.Now;
            pr.Status = 1;

            Log(pr);



            Category cat = new Category();
            cat.Name = "Elektronik";
            cat.Status = 2;
            cat.LogAddDate = DateTime.Now;

            Log(cat);



        }



        static void PrintDeneme(IPrint model)
        {
            //gelen pagesize ve content e göre print işlemi yapıyor
            string printmodel = "Lenovo-0101";
            string key = "Isf341^^123a";

            Console.Write(model.PageContent + " print edildi...");
        }



        static void Log(ILogger logdata)
        {
            string path = @"C:\Users\Cagatay\source\repos\OOPIntro\OOPIntro2\Files\logfile.txt";

            File.AppendAllText(path, "Data loglandı. Tarihi:" + logdata.LogAddDate + "Status: " + logdata.Status);
        }

    }
}
