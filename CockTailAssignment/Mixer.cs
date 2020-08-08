using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CockTailAssignment
{
    public class Mixer : Iingredient
    {


        public string Name { get; set; }
        public IngredientType type { get; set; }

        public int ID { get; set; }

        public Mixer()
        {

        }

        // TODO: Make ctor

    }
}
