using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class MenuItem
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public bool IsAvailable { get; set; }

        public MenuItem(int i, string n, decimal p, int c, string d, bool isAvailable)
        {
            ItemID = i;
            ItemName = n;
            Price = p;
            CategoryID = c;
            Description = d;
            IsAvailable = isAvailable;
        
        
        }
        public MenuItem() { }
    }
}
