using System;
namespace ClassCar
{
    class Program
    {
         class Vehicle
        {
            public static int VehiclesInGarageCount { get; set; }
            public string Name { get; set; }
            private int capacity;
            public int Capacity
            {
                get
                {
                    return capacity;
                }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("the capacity must be greater than 0");
                    }
                    else
                    {
                        capacity = value;
                    }
                }
            }
            public Engine engine { get; set; }
            public enum Engine
            {
                InteranalCombustionEngine,
                ElectricEngine
            }
            public Vehicle() : this("Noname")
            {

            }
            public Vehicle(string name) : this(name, 0)
            {

            }
            public Vehicle(string name, int capacity)
            {
                this.capacity = capacity;
                this.Name = name;
                ++VehiclesInGarageCount;
            }
            public void GetInfo()
            {
                Console.WriteLine($"Name: {Name}  Capacity: {capacity} Engine: {engine}");
            }
        }
        class Car : Vehicle
        {

        }
        static void Main()
        {
            Vehicle test = new();
            test.engine = Vehicle.Engine.InteranalCombustionEngine;
            test.Name = "test_vehicle";
            Console.WriteLine(test.Name);
            Console.WriteLine(test.Capacity);
            Console.WriteLine(test.engine);
            test.GetInfo();
            
        }
    }
}