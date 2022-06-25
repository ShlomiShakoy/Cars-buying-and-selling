using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_menu
{
    public class Truck: Vehicle
    {
        public string _lever{ get; set; }
        public string _manually { get; set; }
        
        public Truck(string type, string model, string color, string lever, string manually , string price , string id)
        {
            this._lever = lever;
            this._manually = manually;
            this.LicensePlate = id;
            this._type = type;
            this._model = model;
            this._color = color;
            this._price = price;
        }
        public Truck() { }
    }
}
