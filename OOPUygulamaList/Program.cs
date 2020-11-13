using OOPUygulamaList.Manager;
using OOPUygulamaList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUygulamaList
{
    class Program
    {
        static void Main(string[] args)
        {
            DataManager<Order> dtmanager = new DataManager<Order>();
            //DataManager<Student> dtmanager2 = new DataManager<Student>();


            //var data =  dtmanager.GetByID<Order>(3);


            //çok katmanlı bir proje aç ve tüm productları döndüren bir metot yaz
            //Bu metodu console da çağır


            //f12010 a birebir tüm kolonlarını alacağım bir class oluştur

            //Kullanıcı console dan round girdiğinde o round a  ait raceName ekrana yazdırılsın

            //Kullanıcı console dan season alacak ve o season url i ekrana yazacak

            //Kullanıcı console dan circuitName alacak ve o  circuitName in url ini ekrana yazdıracak

            //Kullanıcı console dan ay girecek ( ayı number olarak alacak. Örneğin 4) O aya ait raceName ekrana gelecek

            //Kullanıcı console dan ay girecek O ay dan sonraki racenameleri teker teker ekrana yazacak

            // Kullanıcı console dan racename search edecek ve o racename e ait url ekrana gelecek. (racename contains kullanılacak )

            //   Kullanıcı console dan circuitName search edece ve o circuitName e ait url ekrana gelecek. (circuit içerisindeki url. circuitName contains kullanılacak )

            // Races de kaç adet  yarış olduğunu getiren metot ( BASİT )

            //Kullanıcı console dan round girdiğinde o round a  ait circuitName ve url yanyana ekrana yazdırsın

            // Kullanıcı consoledan  dakika girsin (15 gibi girebilir. time propertyisi) o dakikanın altında yarışı bitiren raceName ekrana yazdırsın

            //Kullanıcı consoledan  country alsın o country deki raceName ekrana yazdırsın


            //Products sorular

            dynamic dstudent = new Student();
            var dstudent2 = new Student();

            dstudent.DisplayStudentInfo(333);

            dstudent.DisplayStudentInfo("imkansız");

            //Console.ReadLine();

            var urun = new
            {
                ad = "IPhone",
                fiyat = 33,
                detay = new
                {
                    camozellik = "Kırılmaz cam",
                    bataryasure= "29 saat"
                }
            };

            IDictionary<int, string> products = new Dictionary<int, string>(); 
            var products2 = new Dictionary<int, string>();

            products.Add(1, "IPhone");
            products.Add(2, "Samsung");


            products[22] = "Huawei";


        }
    }
}
