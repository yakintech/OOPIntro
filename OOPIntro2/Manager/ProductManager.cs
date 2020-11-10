using Newtonsoft.Json;
using OOPIntro2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro2.Manager
{
    class ProductManager
    {
        static string data = File.ReadAllText(@"C:\Users\Cagatay\source\repos\OOPIntro\OOPIntro2\jsonfiles\products.json");

        //Ürünün listesinin çekilmesi, id ye göre ürün getirme, search vb. işlemleri kapsayan class

        public static List<ProductVM> GetAllProducts()
        {
            List<ProductVM> products = JsonConvert.DeserializeObject<List<ProductVM>>(data);

            return products;
        }

        //Dışarıdan aldığı id ye göre listedeki o ÜRÜNÜ döndüren metot
        public static ProductVM GetProductByID(int id)
        {
            List<ProductVM> products = JsonConvert.DeserializeObject<List<ProductVM>>(data);

            ProductVM model = products.FirstOrDefault(q => q.id == id);

            return model;

        }

        //Dışarıdan aldığı string name e göre içerisinde o name geçen ÜRÜNLERİ döndüren metot
        public static List<ProductVM> GetProductsByName(string productname)
        {
            List<ProductVM> products = JsonConvert.DeserializeObject<List<ProductVM>>(data);

            List<ProductVM> model = products.Where(q => q.name.Contains(productname)).ToList();

            return model;

        }

        //Dışarıdan aldığı string name ile biten ÜRÜNLERİ döndüren metot
        public static List<ProductVM> GetProductsByEndName(string productname)
        {
            List<ProductVM> products = JsonConvert.DeserializeObject<List<ProductVM>>(data);

            List<ProductVM> model = products.Where(q => q.name.EndsWith(productname)).ToList();

            return model;
        }

        //Dışarıdan categoryid ve supplierid alan buna uygun ÜRÜNLERİ döndüren metot
        public static List<ProductVM> GetProductsBySCID(int categoryid, int supplierid)
        {
            List<ProductVM> products = JsonConvert.DeserializeObject<List<ProductVM>>(data);

            List<ProductVM> model = products.Where(q => q.categoryId == categoryid && q.supplierId == supplierid).ToList();

            return model;
        }

        //Dışarıdan aldığı fiyattan büyük olan ürünüleri getiren ve bu ürünleri sıralayan metot
        public static List<ProductVM>  GetProductsByPrice(double price)
        {
            List<ProductVM> products = JsonConvert.DeserializeObject<List<ProductVM>>(data);

            List<ProductVM> model = products.Where(q => q.unitPrice > price).OrderByDescending(w => w.unitPrice).ToList();

            return model;
        }

        //Dışarıdan aldığı sayıya göre o kadar ürün döndüren ve bunları ada göre sıralayan metot
         public static List<ProductVM> GetProductsByCount(int count)
        {
            List<ProductVM> products = JsonConvert.DeserializeObject<List<ProductVM>>(data);

            List<ProductVM> model = products.Take(count).OrderBy(q => q.name).ToList();

            return model;
        }

         //Dışarıdan aldığı kategori adına göre ürünleri döndüren metot
         public static List<ProductVM> GetProductsByCategoryName(string categoryname)
        {
            List<ProductVM> products = JsonConvert.DeserializeObject<List<ProductVM>>(data);

            List<ProductVM> model = products.Where(q => q.category?.name == categoryname).ToList();
            return model;

        }

        //Dışarıdan bir ürün adı alan ve bu ürün listede varsa true yoksa false döndüren metot
        public static bool AnyProduct(string productname)
        {
            List<ProductVM> products = JsonConvert.DeserializeObject<List<ProductVM>>(data);

            List<ProductVM> model = products.Where(q => q.name == productname).ToList();

            if(model.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Dışarıdan aldığı fiyattan büyük kaç adet ürün olduğunu bana söyleyen metot
        public static int GetProductsCountByPrice(double price)
        {
            List<ProductVM> products = JsonConvert.DeserializeObject<List<ProductVM>>(data);

            int pcount = products.Where(q => q.unitPrice > price).Count();

            return pcount;
        }

        //Dışarıdan aldığı productvm yi listeye ekleyen metot
        public static void AddProduct(ProductVM model)
        {
            List<ProductVM> products = JsonConvert.DeserializeObject<List<ProductVM>>(data);
            products.Add(model);
        }



    }
}
