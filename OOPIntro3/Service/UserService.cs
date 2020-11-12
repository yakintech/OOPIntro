
using Newtonsoft.Json;
using OOPIntro3.config;
using OOPIntro3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro3.Service
{
    class UserService
    {
        static string data = Env.fileurl + "users.json";
        static List<User> users = JsonConvert.DeserializeObject<List<User>>(data);

        public void Deneme()
        {
            //User user = new User();
            //user.name = "Korhan";
            //user.age = 12;
            //user.city = "Edirne";
            //users.Add(user);

            //List<User> newusers = new List<User>();
            //users.AddRange(newusers);

            List<User> users2 = users.Where(q => q.age == 19 && q.city == "Tokyo").ToList();

            User user = users.FirstOrDefault(q => q.name == "Somon Delivar");

            List<User> users3 = users.Where(q => q.city == "Liverpul").OrderBy(q => q.name).ToList();


            List<User> users4 = users
                .Take(10)
                .Where(q => q.city == "CANNES")
                .OrderByDescending(q => q.name)
                .ToList();

            List<User> users5 = users.Where(q => q.name.StartsWith("a")).ToList();
            List<User> users6 = users.Where(q => q.name.Contains("ce")).ToList();

            bool varMi = users.Any(q => q.name == "Çağatay");



        }

    }
}
