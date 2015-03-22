using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF.Models
{

    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string Author { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }

    public class Comment
    {
        public int CommentID { get; set; }
        public string Content { get; set; }
    }

    //public class Car
    //{
    //    public int CarID { get; set; }
    //    public string CarName { get; set; }

    //    public ICollection<Brand> Brands { get; set; }
    //}
    //public class Brand
    //{
    //    public int BrandID { get; set; }
    //    public string BrandName { get; set; }
    //}
}