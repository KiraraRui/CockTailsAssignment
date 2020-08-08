using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CockTailAssignment
{
    public class Bartender
    {
        List<Drink> drinks = new List<Drink>();

        DrinkContext drinkContext = new DrinkContext();

        public void AddDrinkName(string name, List<DrinkIngredient> ingredients)
        {

            drinkContext.Drinks.Add(new Drink(name, ingredients));  

            drinkContext.SaveChanges();
        }

        public void RemoveDrink(Drink drink)
        {
            drinkContext.Drinks.Remove(drinkContext.Drinks.Find(drink.DrinkID));
            drinkContext.SaveChanges();
        }

        public void UpdateDrink()
        {

        }

        
        public void GenerateIngredient()
        {
            // den har alchohol klasse og en ingredienttype, eftersom jeg kan fraskille hvad der er hvad når der tilføjes nye typer i stedet for at kende typen på klassen ( eks kunne alchohol klassen være kaldt noget andet).
            drinkContext.Alcohol.Add(new Alcohol(1, "Tequila", IngredientType.Alcohol)); 
            drinkContext.Alcohol.Add(new Alcohol(2, "Rum white", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(3, "Rum Dark", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(4, "Kahlua", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(5, "Cachaça", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(6, "Vodka", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(7, "Bourbon", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(8, "Vermouth Italia sweet", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(9, "Vermouth French dry", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(10, "Cointreau", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(11, "Gin International Style", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(12, "Gin Sloe", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(13, "Prosecco", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(14, "Orange Curacao", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(15, "Brandy cherry", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(16, "Triple sec", IngredientType.Alcohol));
            drinkContext.Alcohol.Add(new Alcohol(17, "Angrostura bitters", IngredientType.Alcohol));

            // TODO: ret ingredients til Mixer
            drinkContext.Mixers.Add(new Mixer(18, "Lime juice", IngredientType.Mixer));
            drinkContext.Ingredients.Add(new Ingredient(19, "Tomato juice", IngredientType.Mixer));
            drinkContext.Ingredients.Add(new Ingredient(20, "Orange juice", IngredientType.Mixer));
            drinkContext.Ingredients.Add(new Ingredient(21, "Cranberry juice", IngredientType.Mixer));
            drinkContext.Ingredients.Add(new Ingredient(22, "Lemon juice", IngredientType.Mixer));
            drinkContext.Ingredients.Add(new Ingredient(23, "Pineapple juice", IngredientType.Mixer));
            drinkContext.Ingredients.Add(new Ingredient(24, "Grapefruit juice", IngredientType.Mixer));
            drinkContext.Ingredients.Add(new Ingredient(25, "Grapefruit juice pink", IngredientType.Mixer));
            drinkContext.Ingredients.Add(new Ingredient(26, "Peach puree", IngredientType.Mixer));
            drinkContext.Ingredients.Add(new Ingredient(27, "Almond syrup", IngredientType.Mixer));
            drinkContext.Ingredients.Add(new Ingredient(28, "Water", IngredientType.Mixer));
            drinkContext.Ingredients.Add(new Ingredient(29, "Cola", IngredientType.Mixer));
            drinkContext.Ingredients.Add(new Ingredient(30, "Soda", IngredientType.Mixer));

            // TODO: ret ingredients til fruit
            drinkContext.Ingredients.Add(new Ingredient(31, "Lime", IngredientType.Fruit));
            drinkContext.Ingredients.Add(new Ingredient(32, "Orange", IngredientType.Fruit));
            drinkContext.Ingredients.Add(new Ingredient(33, "Cherry", IngredientType.Fruit));
            drinkContext.Ingredients.Add(new Ingredient(34, "Olive", IngredientType.Fruit));
            drinkContext.Ingredients.Add(new Ingredient(35, "Pineapple", IngredientType.Fruit));

            // TODO: ret ingredients til Other
            drinkContext.Ingredients.Add(new Ingredient(36, "Brown sugar", IngredientType.Other));
            drinkContext.Ingredients.Add(new Ingredient(37, "Celery stick", IngredientType.Other));
            drinkContext.Ingredients.Add(new Ingredient(38, "Mint", IngredientType.Other));
            drinkContext.Ingredients.Add(new Ingredient(39, "Coconut cream", IngredientType.Other));
            drinkContext.Ingredients.Add(new Ingredient(40, "Fresh cream", IngredientType.Other));
            drinkContext.Ingredients.Add(new Ingredient(41, "Ice cubes", IngredientType.Other));
            drinkContext.Ingredients.Add(new Ingredient(42, "Worcestershire sauce", IngredientType.Other));
            drinkContext.Ingredients.Add(new Ingredient(43, "Caster sugar", IngredientType.Other));
            drinkContext.Ingredients.Add(new Ingredient(44, "Salt", IngredientType.Other));

            drinkContext.SaveChanges();

        }

        // TODO: ret ingredients til drinkingredient

        // missing addables like example ice cubes and such, as i was lacking time for it.
        public void GenerateDrink()
        {
            drinkContext.Drinks.Add(new Drink(1, "Margarita", new List<Mixer>() { new Mixer(1, drinkContext.Ingredients.Find(18), 60, "ml"), new Mixer(2, drinkContext.Ingredients.Find(16), 30, "ml"), new Mixer(3, drinkContext.Ingredients.Find(1), 60, "ml") }));
            drinkContext.Drinks.Add(new Drink(2, "Mai tai", new List<Mixer>() { new Mixer(4, drinkContext.Ingredients.Find(3), 50, "ml"), new Mixer(5, drinkContext.Ingredients.Find(14), 15, "ml"), new Mixer(6, drinkContext.Ingredients.Find(18), 10, "ml"), new Mixer(7, drinkContext.Ingredients.Find(27), 60, "ml") }));
            drinkContext.Drinks.Add(new Drink(3, "White russian", new List<Mixer>() { new Mixer(8, drinkContext.Ingredients.Find(40), 30, "ml"), new Mixer(9, drinkContext.Ingredients.Find(4), 30, "ml"), new Mixer(10, drinkContext.Ingredients.Find(6), 90, "ml") }));
            drinkContext.Drinks.Add(new Drink(4, "Caipirinha", new List<Mixer>() { new Mixer(11, drinkContext.Ingredients.Find(5), 50, "ml"), new Mixer(12, drinkContext.Ingredients.Find(31), 5, "segments") }));
            drinkContext.Drinks.Add(new Drink(5, "screwdriver", new List<Mixer>() { new Mixer(13, drinkContext.Ingredients.Find(20), 135, "ml"), new Mixer(14, drinkContext.Ingredients.Find(6), 45, "ml") }));
            drinkContext.Drinks.Add(new Drink(6, "Bloody mary", new List<Mixer>() { new Mixer(15, drinkContext.Ingredients.Find(19), 135, "ml"), new Mixer(16, drinkContext.Ingredients.Find(6), 45, "ml"), new Mixer(17, drinkContext.Ingredients.Find(37), 1, "pcs") }));
            drinkContext.Drinks.Add(new Drink(7, "Whiskey sour", new List<Mixer>() { new Mixer(18, drinkContext.Ingredients.Find(7), 90, "ml"), new Mixer(19, drinkContext.Ingredients.Find(18), 40, "ml") }));
            drinkContext.Drinks.Add(new Drink(8, "Old fashioned", new List<Mixer>() { new Mixer(20, drinkContext.Ingredients.Find(7), 50, "ml"), new Mixer(21, drinkContext.Ingredients.Find(28), 5, "ml"), new Mixer(22, drinkContext.Ingredients.Find(17), 1, "dash"), new Mixer(23, drinkContext.Ingredients.Find(43), 1, "cube") }));
            drinkContext.Drinks.Add(new Drink(9, "Manhattan", new List<Mixer>() { new Mixer(24, drinkContext.Ingredients.Find(8), 25, "ml"), new Mixer(25, drinkContext.Ingredients.Find(7), 45, "ml") }));
            drinkContext.Drinks.Add(new Drink(10, "Martini", new List<Mixer>() { new Mixer(26, drinkContext.Ingredients.Find(9), 25, "ml"), new Mixer(27, drinkContext.Ingredients.Find(11), 45, "ml") }));
            drinkContext.Drinks.Add(new Drink(11, "Daiquiri", new List<Mixer>() { new Mixer(28, drinkContext.Ingredients.Find(18), 25, "ml"), new Mixer(29, drinkContext.Ingredients.Find(2), 45, "ml") }));
            drinkContext.Drinks.Add(new Drink(12, "Cosmopolitan", new List<Mixer>() { new Mixer(30, drinkContext.Ingredients.Find(18), 15, "ml"), new Mixer(31, drinkContext.Ingredients.Find(25), 15, "ml"), new Mixer(32, drinkContext.Ingredients.Find(21), 15, "ml"), new Mixer(33, drinkContext.Ingredients.Find(10), 15, "ml"), new Mixer(34, drinkContext.Ingredients.Find(6), 50, "ml") }));
            drinkContext.Drinks.Add(new Drink(13, "Singapore sling", new List<Mixer>() { new Mixer(35, drinkContext.Ingredients.Find(30), 250, "ml"), new Mixer(36, drinkContext.Ingredients.Find(15), 20, "ml"), new Mixer(37, drinkContext.Ingredients.Find(22), 20, "ml"), new Mixer(38, drinkContext.Ingredients.Find(12), 20, "ml"), new Mixer(39, drinkContext.Ingredients.Find(11), 45, "ml") }));
            drinkContext.Drinks.Add(new Drink(14, "Mojito", new List<Mixer>() { new Mixer(40, drinkContext.Ingredients.Find(18), 20, "ml"), new Mixer(41, drinkContext.Ingredients.Find(2), 50, "ml"), new Mixer(42, drinkContext.Ingredients.Find(38), 10, "leaves"), new Mixer(43, drinkContext.Ingredients.Find(43), 2, "tsp") }));
            drinkContext.Drinks.Add(new Drink(15, "Mint julep", new List<Mixer>() { new Mixer(44, drinkContext.Ingredients.Find(28), 300, "ml"), new Mixer(45, drinkContext.Ingredients.Find(7), 60, "ml"), new Mixer(46, drinkContext.Ingredients.Find(38), 4, "leaves"), new Mixer(47, drinkContext.Ingredients.Find(36), 2, "tsp") }));
            drinkContext.Drinks.Add(new Drink(16, "Tom collins", new List<Mixer>() { new Mixer(48, drinkContext.Ingredients.Find(30), 220, "ml"), new Mixer(49, drinkContext.Ingredients.Find(11), 50, "ml"), new Mixer(50, drinkContext.Ingredients.Find(22), 25, "ml") }));
            drinkContext.Drinks.Add(new Drink(17, "Pina colada", new List<Mixer>() { new Mixer(51, drinkContext.Ingredients.Find(23), 70, "ml"), new Mixer(52, drinkContext.Ingredients.Find(2), 30, "ml"), new Mixer(53, drinkContext.Ingredients.Find(39), 60, "ml") }));
            drinkContext.Drinks.Add(new Drink(18, "Sea breeze", new List<Mixer>() { new Mixer(54, drinkContext.Ingredients.Find(24), 50, "ml"), new Mixer(55, drinkContext.Ingredients.Find(21), 120, "ml"), new Mixer(56, drinkContext.Ingredients.Find(6), 40, "ml") }));
            drinkContext.Drinks.Add(new Drink(19, "Cuba libre", new List<Mixer>() { new Mixer(57, drinkContext.Ingredients.Find(29), 80, "ml"), new Mixer(58, drinkContext.Ingredients.Find(18), 25, "ml"), new Mixer(59, drinkContext.Ingredients.Find(2), 50, "ml") }));
            drinkContext.Drinks.Add(new Drink(20, "Bellini", new List<Mixer>() { new Mixer(60, drinkContext.Ingredients.Find(26), 50, "ml"), new Mixer(61, drinkContext.Ingredients.Find(13), 100, "ml") }));

            drinkContext.SaveChanges();

  
        }
    }

       