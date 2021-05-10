using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_02___POLIMORF.Entities {
    //------------------------------- START -------------------------------//
    class ImportedProduct : Product{
        public double CustomsFree { get; set; }

        //------------------------------- CONST -------------------------------//  
        public ImportedProduct() {
        }
        public ImportedProduct (string name, double price, double customsFree) : base(name, price) {
            CustomsFree = customsFree;
        }
        //------------------------------- MET --------------------------------//
        public double TotalPrice() {
            return Price + CustomsFree;
        }
        public override string PriceTag() {
            return Name +" $ " + TotalPrice().ToString("F2") + " (Customs fee: $ " + CustomsFree.ToString("F2") + ")";
        }

    }
    //-------------------------------- END -------------------------------//
}
