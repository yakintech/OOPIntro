using Newtonsoft.Json;
using OOPIntro3.config;
using OOPIntro3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro3.Service
{
    class SupplierService
    {
        static string data = File.ReadAllText(Env.fileurl + "suppliers.json");
        static List<Supplier> suppliers = JsonConvert.DeserializeObject<List<Supplier>>(data);

        public static List<Supplier> GetSuppliers()
        {
            return suppliers;
        }

        //Dışarıdan aldığı city e göre supplierları getiren ve ada göre sıralayan metot
        public static List<Supplier> GetSuppliersByCity(string cityname)
        {
            List<Supplier> model = suppliers.Where(q => q.address.city == cityname).OrderBy(w => w.companyName).ToList();

            return model;

        }


        //   ID ye göre supplier getiren metot
        //   Dışarıdan aldığı companyname e göre contains olan supplierlar
        //   Dışarıdan aldığı city e göre supplierları getiren ve ada göre sıralayan metot
        //   Datayı çektiğinde telefonların soluna +90 eklesin ( supplierdaki get set manipüle edilecek) 



    }
}
