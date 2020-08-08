using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CockTailAssignment
{
    public class Drink
    {

        [Key]
        public int DrinkID { get; set; }

        [Column("Name", TypeName = "VarChar")]
        [MaxLength(32)]
        public string Name { get; set; }

        public Drink(int drinkID, string name, List<DrinkIngredient> drinkIngredients)
        {
            DrinkID = drinkID;
            Name = name;
            DrinkIngredients = drinkIngredients; 
        }

        public List<DrinkIngredient> DrinkIngredients { get; set; } = new List<DrinkIngredient>();

        public Drink()
        {

        }

        public Drink(string name, List<DrinkIngredient> drinkIngredients)
        {
            Name = name;
            DrinkIngredients = drinkIngredients;
        }
         
    }
}
