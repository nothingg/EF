using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF.Models
{

    public class Car
    {
        public int CarID { get; set; }
        public string CarName { get; set; }

    }
    public class Brand
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
    }
}