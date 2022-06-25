using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_menu
{
    public class Vehicle
    {
        public string _type { get; set; }
        public string _model { get; set; }
        public string _color { get; set; }
        public string _price { get; set; }
        public string LicensePlate { get; set; }
        public Vehicle(string type, string model, string color, string price , string licensplate )
        {
            this._type = type;
            this._model = model;
            this._color = color;
            this._price = price;
            this.LicensePlate = licensplate;
        }
        public Vehicle() { }  
    }
}
