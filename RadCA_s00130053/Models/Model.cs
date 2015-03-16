using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RadCA_s00130053.Models
{
    public class LocationSeed : DropCreateDatabaseAlways<CountryDb>
    {
        protected override void Seed(CountryDb context)
        {

            var lstCountreis = new List<Countries>()
            {
                new Countries(){ CountryName = "Ireland", City = "Dublin"},
                new Countries(){ CountryName = "UK", City = "London"},
                new Countries(){ CountryName = "USA", City = "New York"},
                new Countries(){ CountryName = "France", City = "Paris"},
                new Countries(){ CountryName = "Ukraine", City = "Kiev"}
                
            };
            lstCountreis.ForEach(c => context.Countries.Add(c));
            context.SaveChanges();
            base.Seed(context);
        }
    }

    public class CountryDb : DbContext
    {
        public DbSet<Countries> Countries { get; set; }
        public CountryDb() : base("CountryConnString") { }
    }

    public class Countries
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string City { get; set; }
    }


}