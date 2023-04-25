

using OOPIntro.Helper;
using OOPIntro.Models;
using System.ComponentModel;

//instance almak
DateTimeHelper dateTimeHelper = new DateTimeHelper();
dateTimeHelper.GetYesterday();


DateTimeHelper.GetTomorrow();





Random random = new Random();
 int randomNumber = random.Next(1,100);


WebUser webUser = new WebUser();
webUser.Name = "Cagatay";

WebUser webUser2 = new WebUser();
webUser2.Name = "Ahmet";
webUser2.Surname = "Celik";

webUser = webUser2;

webUser2.Name = "Mert";






int x = 0;
int y = 10;

x = y;
y = 3;

Console.WriteLine(x);



Console.WriteLine(webUser.Name);




//public
//private
//internal*
//protected



//static
//const
//readonly

const decimal tax = 1.18M;












Category category = new Category();
category.Name = "Elektronik";















List<int> pointsList = new List<int>();
pointsList.Add(3);
pointsList.Add(2);
pointsList.Add(5);



//instance almak
//Product product = new Product();
//product.Name = "IPhone";
//product.Description = "Apple product";
//product.Stock = 20;
//product.AddDate = DateTime.Now;
//product.Category = category;
//product.Points = pointsList;


WebUser user = new WebUser();
user.Name = "Cagatay";
user.Surname = "Yildiz";

WebUser user2 = new WebUser();
user2.Name = "Aykut";
user2.Surname = "Arslan";



List<WebUser> users = new List<WebUser>();
users.Add(user);
users.Add(user2);



Console.WriteLine("");





