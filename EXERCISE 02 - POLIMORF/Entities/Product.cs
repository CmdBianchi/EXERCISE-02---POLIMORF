using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_02___POLIMORF.Entities {
    //------------------------------- START -------------------------------//
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }
    
    //------------------------------- CONST -------------------------------//  
        public Product() {
        }
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }
    //------------------------------- MET --------------------------------//
        public virtual string PriceTag() {
            return Name + " $ " + Price.ToString("F2");
        }
    }
    //-------------------------------- END -------------------------------//
}
