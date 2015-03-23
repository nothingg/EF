using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using EF.Models;
using System.Data.EntityClient;

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

    public class CarRespository
    {

        public static AllContext db = new AllContext();
        public static List<Car> GetCar()
        {
            //List<Car> result =  db.Cars.ToList();
            //return result;
            List<Car> result = new List<Car>();


            var rs = db.Database.SqlQuery<string>("SELECT * FROM cars").ToList();
            
            foreach(var row in rs)
            {
         
            }
           

            using (var con = new EntityConnection())
            {
                con.Open();
                EntityCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT carname FROM cars";
                using(EntityDataReader edr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
                {
                    while (edr.Read())
                    {
                        Car row = new Car();
                        row.CarID = Convert.ToInt16(edr["CarID"]);
                        row.CarName = Convert.ToString(edr["CarName"]);
                        result.Add(row);
                    }
                }
                //con.Open();
                //EntityCommand cmd = con.CreateCommand();
                //cmd.CommandText = "SELECT VALUE st FROM SchoolDBEntities.Students as st where st.StudentName='Bill'";
                //Dictionary<int, string> dict = new Dictionary<int, string>();
                //using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
                //{
                //    while (rdr.Read())
                //    {
                //        int a = rdr.GetInt32(0);
                //        var b = rdr.GetString(1);
                //        dict.Add(a, b);
                //    }
                //}
            }
            return result;
            
        }
    }
}