using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CockTailAssignment
{
    public class DrinkIngredient
    {

        [Key]
        public int ID { get; set; }

        public int Amount { get; set; }

        public UnitType Unit { get; set; }


        public Iingredient Ingredient { get; set; }

        public DrinkIngredient()
        {

        }

        public DrinkIngredient(int id, Iingredient ingredient, int amount, UnitType unit)
        {
            ID = id;
            Ingredient = ingredient;
            Amount = amount;
            Unit = unit;
        }


    }
}
