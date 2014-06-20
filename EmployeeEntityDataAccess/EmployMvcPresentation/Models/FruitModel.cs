using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployMvcPresentation.Models {
    public class FruitModel{
        [Key]
        public int Id { get; set; }
        public System.Drawing.Color Color { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
    }

    public class BowlModel{
        [Key]
        public int Id { get; set; }
        public System.Drawing.Color Color { get; set; }
        public ICollection<FruitModel> Fruits { get; set; }
    }

    public class FruitContext : DbContext{
        public DbSet<FruitModel> Fruits { get; set; }
        public DbSet<BowlModel> Bowls { get; set; }
    }
}