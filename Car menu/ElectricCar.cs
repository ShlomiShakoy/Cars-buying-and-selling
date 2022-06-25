using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Car_menu
{
    public class ElectricCar : Car
    {
        public string selfCharging{get;set;}
       
        public ElectricCar(string Amount_Of_Seats, string type, string model, string color , string selfcharging , string price , string id)
        {
            this.selfCharging = selfcharging;
            this._type = type;
            this._model = model;
            this._color = color;
            this.amountOfSeats = Amount_Of_Seats;
            this._price = price;
            this.LicensePlate = id;
        }
        public ElectricCar() { }
       
        public override void mylist()
        {
            string text = @"C:\Users\IMOE001\Dropbox\PC\Desktop\carsProject\temp\electriccar.txt";
            string text1 = @"C:\Users\IMOE001\Dropbox\PC\Desktop\carsProject\temp\Luxurycar.txt";
            List<string> lines = File.ReadAllLines(text).ToList();
            List<string> lines1 = File.ReadAllLines(text1).ToList();
            foreach (var line in lines)
            {
                string[] x = line.Split(',');
                Car mycar = new Car();
                mycar.amountOfSeats = x[0];
                mycar._type = x[1];
                mycar._model = x[2];
                mycar._color = x[3];
                mycar._price = x[5];
                mycar.LicensePlate = x[6];
                m_list.Add(mycar);
            }
            foreach (var line in lines1)
            {
                string[] x = line.Split(',');
                Car mycar = new Car();
                mycar.amountOfSeats = x[0];
                mycar._type = x[1];
                mycar._model = x[2];
                mycar._color = x[3];
                mycar._price = x[6];
                mycar.LicensePlate = x[7];
                m_list.Add(mycar);
            }
            base.mylist();
            //LuxuryCar mypcar = new LuxuryCar();
            //mypcar.mylist();
        }   

    }
}
