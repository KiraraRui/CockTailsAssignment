using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CockTailAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Bartender bartender = new Bartender();

            bartender.GenerateIngredient();
            bartender.GenerateDrink();

            Console.WriteLine("drink done");
            Console.ReadKey();

        }
    }
}

// TODO: Make cw Menu, make drink, delete drink, update drink, make normal drink, search for drink
// TODO: Ascii art drink make it fancy
