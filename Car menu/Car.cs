using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Car_menu
{

    public class Car : Vehicle
    {
        public string amountOfSeats { get; set; }

        //public override int _price { get => base._price; set => base._price = value; }
        public Car(string Amount_Of_Seats, string type, string model, string color, string price, string id)
        {
            this.amountOfSeats = Amount_Of_Seats;
            this._type = type;
            this._model = model;
            this._color = color;
            this._price = price;
            this.LicensePlate = id;
        }
        public Car() { }
       
       
        public List<Car> m_list=new List<Car>();
        public virtual void mylist()
        {
            string text = @"C:\Users\IMOE001\Dropbox\PC\Desktop\carsProject\temp\car.txt";
            string textcar = @"C:\Users\IMOE001\Dropbox\PC\Desktop\carsProject\temp\allcars.txt";
            List<string> lines = File.ReadAllLines(text).ToList();
            List<string> output = new List<string>();
            foreach (var line in lines)
            {
                string[] x = line.Split(',');
                Car mycar = new Car();
                mycar.amountOfSeats = x[0];
                mycar._type = x[1];
                mycar._model = x[2];
                mycar._color = x[3];
                mycar._price = x[4];
                mycar.LicensePlate = x[5];
                m_list.Add(mycar);
            }
            foreach (var car1 in m_list)
                {
                    output.Add($"{car1.amountOfSeats} , {car1._type} , {car1._model} , {car1._color} , {car1._price} , {car1.LicensePlate}");
                File.WriteAllLines(textcar, output);
                }
        }
       
    }
       
}
