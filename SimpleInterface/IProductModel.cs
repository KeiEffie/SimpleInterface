using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterface       //ta Interfaces einai PUBLIC
{
    public interface IProductModel
    {
        //Vgazo ta public apo ta properties giati einai public by default 
        //einai public logo Interface
        string Title { get; set; }


        //public bool HasOrderBeenCompleted { get; private set; }
        bool HasOrderBeenCompleted { get; }  //to private set fevgei apo to Interface!!!


        //gia na doulepsei i methodos thelei public sto CustomerModel
        void ShipItem(CustomerModel customer);


    }
}
