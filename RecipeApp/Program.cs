using System;
using System.Collections.Generic;

namespace RecipeManagementApp
{
    class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
    }

    class Recipe
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var recipe = new Recipe();

            Console.WriteLine("Welcome to Recipe Management App!");
            // ... (Same input prompts for ingredients and steps)

            // Display the recipe
            Console.WriteLine("\nRecipe Details:");
            // ... (Same display logic for ingredients and steps)

            // Scaling and resetting (optional)
            // ... (Implement scaling and reset logic here)

            // Clear data
            Console.Write("\nDo you want to clear all data? (yes/no): ");
            string clearChoice = Console.ReadLine().ToLower();
            if (clearChoice == "yes")
            {
                recipe.Ingredients.Clear();
                recipe.Steps.Clear();
                Console.WriteLine("All data cleared. You can now enter a new recipe.");
            }
            else
            {
                Console.WriteLine("Data remains unchanged.");
            }

            Console.WriteLine("\nThank you for using Recipe Management App!");
        }
    }
}
