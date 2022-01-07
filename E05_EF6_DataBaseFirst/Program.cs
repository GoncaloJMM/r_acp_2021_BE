using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_EF6_DataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindEntities()) // Classe que herda de DbContext
            {
                #region Nova região
                Region region = new Region();
                region.RegionID = 6; // Não é identity
                region.RegionDescription = "Sul";
                db.Region.Add(region);
                var count1 = db.SaveChanges();
                Console.WriteLine($"{count1} nova região gravada.\n\n");
                var query1 = db.Region.Select(r => r).OrderBy(r => r.RegionID);
                foreach (var item in query1)
                {
                    Console.WriteLine($"{item.RegionID}: {item.RegionDescription}");
                }
                #endregion
                #region Novo território da nova região
                Territories territories = new Territories();
                territories.TerritoryID = "00001"; // Não é identity
                territories.TerritoryDescription = "Porto";
                territories.RegionID = 5;
                db.Territories.Add(territories);
                var count2 = db.SaveChanges();
                Console.WriteLine($"\n\n\n{count2} novo território gravado.\n\n");
                var query2 = db.Territories.Select(r => r).OrderBy(r => r.TerritoryID);
                foreach (var item in query2)
                {
                    Console.WriteLine($"{item.TerritoryID}: {item.TerritoryDescription}");
                }
                #endregion
                Console.ReadKey();
            }
        }    
    }   
}
