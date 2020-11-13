using Newtonsoft.Json;
using OOPUygulamaList.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUygulamaList.Manager
{
    public class DataManager<T> where T : Base 
    {
        T entity;

        public DataManager()
        {

        }
        string data = File.ReadAllText(@"C:\Users\Cagatay\source\repos\OOPIntro\OOPUygulamaList\Files\user.json");
        string data2 = File.ReadAllText(@"C:\Users\Cagatay\source\repos\OOPIntro\OOPUygulamaList\Files\orders.json");

        //public Base GetByID<T>(int id)
        //{
        //    Type typeParameterType = typeof(T);
        //    if (typeParameterType.Name == "User")
        //    {

        //        List<User> users = JsonConvert.DeserializeObject<List<User>>(data);
        //        var model = users.FirstOrDefault(q => q.id == id);
        //        return model;
        //    }
        //    else
        //    {
        //        List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(data2);
        //        var model = orders.FirstOrDefault(q => q.id == id);
        //        return model;
        //    }
        //}


        //public T GetByID<T>(int id)
        //{
        //    Type typeParameterType = typeof(T);
        //    if (typeParameterType.Name == "User")
        //    {

        //        List<User> users = JsonConvert.DeserializeObject<List<User>>(data);
        //        var model = users.FirstOrDefault(q => q.id == id);
        //        return (T)Convert.ChangeType(model, typeof(T));
        //    }
        //    else
        //    {
        //        List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(data2);
        //        var model = orders.FirstOrDefault(q => q.id == id);
        //        return (T)Convert.ChangeType(model, typeof(T));
        //    }

        //}


    }
}
