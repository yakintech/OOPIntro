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
    class OrderManager
    {
        static string data2 = File.ReadAllText(@"C:\Users\Cagatay\source\repos\OOPIntro\OOPIntro2\jsonfiles\orders.json");

        static List<OrderVM> orders = JsonConvert.DeserializeObject<List<OrderVM>>(data2);

        //Dışarıdan toplam satış tutarı alsın. O satış tutarından yüksek orderları döndüren metot
        public static List<OrderVM> GetOrders(decimal fiyat)
        {
            foreach (var item in orders)
            {
                decimal tprice = 0;
                foreach (var priceitem in item.details)
                {
                    tprice = tprice + priceitem.unitPrice;
                }
                item.TotalPrice = tprice;
            }

            List<OrderVM> model = orders.Where(q => q.TotalPrice > fiyat).ToList();

            return model;
        } 
    }
}
