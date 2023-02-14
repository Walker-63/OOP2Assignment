using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;


using System;

Classes_and_Inheritance.FileReader readerBoi = new Classes_and_Inheritance.FileReader();

string files = readerBoi.fileToString("C:\\Users\\cyril\\Downloads\\appliances.txt");

Console.WriteLine(files);
List<string> tester = readerBoi.CreateListFromString(files);
Console.WriteLine(tester[0]);


namespace ApplianceStore
{
    // Base class for Appliances
    abstract class Appliance
    {
        public int ItemNumber { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Wattage { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

        public Appliance(int itemNumber, string brand, int quantity, int wattage, string color, decimal price)
        {
            ItemNumber = itemNumber;
            Brand = brand;
            Quantity = quantity;
            Wattage = wattage;
            Color = color;
            Price = price;
        }

        protected Appliance(int itemNumber, string brand, int quantity)
        {
            ItemNumber = itemNumber;
            Brand = brand;
            Quantity = quantity;
        }

        public abstract override string ToString();
    }


    // Refrigerator class inherits from Appliance class
    class Refrigerator : Appliance
    {
        public int NumberOfDoors { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Refrigerator(int itemNumber, string brand, int quantity, int wattage, string color, decimal price,
            int numberOfDoors, int height, int width)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            NumberOfDoors = numberOfDoors;
            Height = height;
            Width = width;
        }

        public override string ToString()
        {
            return $"Item Number: {ItemNumber}\nBrand: {Brand}\nQuantity: {Quantity}\nWattage: {Wattage}\nColor: {Color}\nPrice: {Price}\nNumber of Doors: {NumberOfDoors}\nHeight: {Height} in.\nWidth: {Width} in.";
        }
    }

    // Vacuum class inherits from Appliance class
    class Vacuum : Appliance
    {
        public string Grade { get; set; }
        public int BatteryVoltage { get; set; }

        public Vacuum(int itemNumber, string brand, int quantity, int wattage, string color, decimal price,
            string grade, int batteryVoltage)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            Grade = grade;
            BatteryVoltage = batteryVoltage;
        }

        public override string ToString()
        {
            return $"Item Number: {ItemNumber}\nBrand: {Brand}\nQuantity: {Quantity}\nWattage: {Wattage}\nColor: {Color}\nPrice: {Price}\nGrade: {Grade}\nBattery Voltage: {BatteryVoltage} V";
        }
    }

    // Microwave class inherits from Appliance class
    class Microwave : Appliance
    {
        public decimal Capacity { get; set; }
        public string RoomType { get; set; }

        public Microwave(int itemNumber, string brand, int quantity, int wattage, string color, decimal price,
            decimal capacity, string roomType)
            : base(itemNumber, brand, quantity) { }

    public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
