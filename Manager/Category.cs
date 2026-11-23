using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }


        public Category()
        {
            CategoryID = 0;
            CategoryName = "";

        }

        public Category(int id, string name)
        {
            CategoryID = id;
            CategoryName = name;

        }

        public string getCategoryInfo()
        {
            string info = "";
            info = info + "Category ID: " + CategoryID;
            info = info + "\n";
            info = info + "Category Name: " + CategoryName;
            info = info + "\n";

            return info;
        }

        public bool isEmpty()
        {
            if (CategoryName == "" || CategoryName == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void printCategory()
        {
            Console.WriteLine(getCategoryInfo());
        }
    }
}