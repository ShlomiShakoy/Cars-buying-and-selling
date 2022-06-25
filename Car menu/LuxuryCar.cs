using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Car_menu
{
    public class LuxuryCar:Car
    {
        public string leathersSeats { get; set; }
        public string turboEngine { get; set; }

        public LuxuryCar(string Amount_Of_Seats, string type, string model, string color , string Leatherseats , string Turboengine , string price , string id)
        { 
            this.leathersSeats = Leatherseats;
            this.turboEngine = Turboengine;
            this.amountOfSeats = Amount_Of_Seats;
            this._type = type;
            this._model = model;
            this._color = color;
            this.LicensePlate = id;
            this._price = price;
        }
        public LuxuryCar() { }
    }
}

