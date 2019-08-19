using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterface
{
    class CourseProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public int Hours { get; set; }

        public void ShipItem(CustomerModel customer)
        {
            if(!HasOrderBeenCompleted)
            {
                Console.WriteLine($"Added the {Title} course to {customer.LastName}'s account");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
