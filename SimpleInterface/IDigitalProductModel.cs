using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterface
{
    //to IDigitalProductModel ylopoiei to IProductModel
    interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}
