using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class Ingredient
    {
        public int IngredientID { get; set; }
        public string IngredientName { get; set; }
        public string Unit { get; set; }
        public decimal QuantityInStock { get; set; }

        public Ingredient()
        {
            IngredientID = 0;
            IngredientName = "";
            Unit = "";
            QuantityInStock = 0;
        }

        public Ingredient(int id, string name, string unit, decimal qty)
        {
            IngredientID = id;
            IngredientName = name;
            Unit = unit;
            QuantityInStock = qty;
        }



        public string getStatus()
        {
            string result = "";
            if ( Unit == "g" && QuantityInStock <= 500)
            {
                result = "Low Stock";
            }
            else if (Unit == "g" && QuantityInStock > 500)
            {
                result = "In Stock";
            }

            else if (Unit == "kg" && QuantityInStock <= 2)
            {
                result = "Low Stock";
            }

            else if (Unit == "kg" && QuantityInStock > 2)
            {
                result = "In Stock";
            }
            else if (Unit == "l" && QuantityInStock <= 3)
            {
                result = "Low Stock";
            }
            else if (Unit == "l" && QuantityInStock > 3)
            {
                result = "In Stock";
            }
            else if (Unit == "ml" && QuantityInStock <= 500)
            {
                result = "Low Stock";
            }
            else if (Unit == "ml" && QuantityInStock > 500)
            {
                result = "In Stock";
            }
            else
            {
                result = "Unknown Unit";
            }
            return result;
        }

        public void printInfo()
        {
            Console.WriteLine("ID: " + IngredientID);
            Console.WriteLine("Name: " + IngredientName);
            Console.WriteLine("Qty: " + QuantityInStock);
            Console.WriteLine("Unit: " + Unit);
        }

        public string getunit()
        {
            if (Unit == "g")
            {
                return "grams";
            }
            else if (Unit == "kg")
            {
                return "kilograms";
            }
            else if (Unit == "l")
            {
                return "liters";
            }
            else if (Unit == "ml")
            {
                return "milliliters";
            }
            return Unit;
        }
    }
}
