using System.Collections.Generic;
namespace CheeseMVC.Models
{
    public class Cheese
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }//foreign key *** connects Cheese to CheeseCatagory
        public CheeseCategory Category { get; set; }//navigation property
        public IList<CheeseMenu> CheeseMenus { get; set; } // defines 1 to many relationship

    }
}
