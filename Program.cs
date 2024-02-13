using System;
using System.Drawing;

namespace myProject
{
    class Garage
    {
        private static int _entries = 0;
        private int _ItemNumber;
        private string _Type;
        private string _Size;

        public Garage()
        {
            _ItemNumber = 0;
            _Size = "";
            _Type = "";
        }
        public Garage(int item, string type, string size)
        {
            _ItemNumber = item;
            _Type = type;
            _Size = size;
        }
        public int GetEnt()
        {
            return _entries;
        }
        public int GetItemNumber()
        {
            return _ItemNumber;
        }
        public string GetType(string type)
        {
            return _Type;
        }
        public string GetSize(string size)
        {
            return _Size;
        }
        public void SetEnt()
        {
            _entries++;
        }
        public void SetItemNumber(int item)
        {
            _ItemNumber = item;
        }
        public void SetType(string type)
        {
            _Type = type;
        }
        public void SetSize(string size)
        {
            _Size = size;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage item10 = new Garage();
            item10.SetEnt();
            item10.SetItemNumber(10);
            item10.SetType("Canoe");
            item10.SetSize("17'");
            Console.WriteLine($"Item Number = {item10.GetItemNumber()}, Type = {item10.GetType(" ")}, Name = {item10.GetSize(" ")}");


           Garage item20 = new Garage();
            item20.SetEnt();
            Console.WriteLine("Please enter the garage Item Number: ");
            item20.SetItemNumber(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the Type: ");
            item20.SetType(Console.ReadLine());
            Console.WriteLine("Please enter the item Size: ");
            item20.SetSize(Console.ReadLine());

            Garage item30 = new Garage(30, "Snowboard", "155cm");
            item30.SetEnt();
            Console.WriteLine($"Item Number = {item30.GetItemNumber()}, Type = {item30.GetType(" ")}, Size = {item30.GetSize(" ")}");

            Console.WriteLine("Please enter the garage Item Number: ");
            int item = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the item Type: ");
            string title = Console.ReadLine();
            Console.WriteLine("Please enter the item Size: ");
            string size = Console.ReadLine();
            Garage item40 = new Garage(item, title, size);
            item40.SetEnt();

            Console.WriteLine($"The garage has {item10.GetEnt()} new entries");
            displayBooks(item10);
            displayBooks(item20);
            displayBooks(item30);
            displayBooks(item40);
        }
        static void displayBooks(Garage item)
        {
            Console.WriteLine("Here's your garage information");
            Console.WriteLine($"Item Number: {item.GetItemNumber()}");
            Console.WriteLine($"Type: {item.GetType(" ")}");
            Console.WriteLine($"Size: {item.GetSize(" ")}");

        }
    }
}