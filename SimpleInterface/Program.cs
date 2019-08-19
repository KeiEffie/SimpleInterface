using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<PhysicalProductModel> cart = AddSampleData();
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach(IProductModel product in cart)
            {
                product.ShipItem(customer);
                if (product is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the {digital.Title}, you have {digital.TotalDownloadsLeft} downloads left!");
                }
                
            }
            Console.ReadLine();
        }
        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Effie",
                LastName = "Koutsoff",
                City = "Athens",
                EmailAddress = "effie@gmail.com",
                StreetAddress = "Pesmatzoglou 37",
                PhoneNumber = "768654373"
            };
        }

        
        public static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title= "Vinyl"});
            output.Add(new PhysicalProductModel { Title= "CD"});
            output.Add(new PhysicalProductModel { Title= "Tape"});
            output.Add(new DigitalProductModel { Title = "Digital1" });
            output.Add(new DigitalProductModel { Title = "Digital2" });
            output.Add(new CourseProductModel { Title = "Lesson C#" });

            return output;
        }
        //public static List<DigitalProductModel> AddDigitalData()
        //{
        //    List<DigitalProductModel> output1 = new List<DigitalProductModel>();
        //    output1.Add(new DigitalProductModel { Title = "test" });
        //    return output1;
        //}


    }
}
