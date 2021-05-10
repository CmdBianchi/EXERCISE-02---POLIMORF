using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------- START -------------------------------//
namespace EXERCISE_02___POLIMORF.Entities {
    class UsedProduct : Product {
        public DateTime ManufacturesDate { get; set; }

        public UsedProduct() {
        }

        //------------------------------- CONST -------------------------------//  
        public UsedProduct(string name, double price, DateTime manufacturesDate) {
            ManufacturesDate = manufacturesDate;
        }
        //------------------------------- MET --------------------------------//
        public override string PriceTag() {
            return Name + " (used) $ " + Price.ToString("F2") + " Manufacture date: " + ManufacturesDate.ToString("dd/MM/yyyy") + ")";
        }

    }
    //-------------------------------- END -------------------------------//
}
