using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._04ADO
{
    public class CityInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.Cities.AddRange(new List<City>
      {
          new City
         {
            Name = "Астана",
            Number = 87172
         },
          new City
         {
            Name = "Шымкент" ,
            Number = 87252
         },
           new City
         {
            Name = "Кокшетау",
            Number = 87162
         },
           new City
         {
            Name = "Петропавловск",
            Number = 87152
         }
      });
            context.SaveChanges();
        }
    }
}