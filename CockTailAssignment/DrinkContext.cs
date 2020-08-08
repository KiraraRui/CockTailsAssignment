using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Text;

namespace CockTailAssignment
{
    class DrinkContext : DbContext
    {
        public DrinkContext() : base("Cocktail assignment")
        {

            Database.SetInitializer<DrinkContext>(new CreateDatabaseIfNotExists<DrinkContext>());

            //Database.SetInitializer<DrinkContext>(new DropCreateDatabaseIfModelChanges<DrinkContext>());
            //Database.SetInitializer<DrinkContext>(new DropCreateDatabaseAlways<DrinkContext>());
            //Database.SetInitializer<DrinkContext>(new DrinkContext());
        }

        public DbSet<Drink> Drinks { get; set; }

        public DbSet<DrinkIngredient> DrinkIngredients { get; set; }

        public DbSet<Alcohol> Alcohols { get; set; }

        public DbSet<Fruit> Fruits { get; set; }

        public DbSet<Mixer> Mixers { get; set; }

        public DbSet<Other> Others { get; set; }



    }
}

