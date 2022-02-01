using System;

public class OOP
{
	public static void Main()
    {
        // Object-oriented programming

        /*
         * Classes - Think of them as templates/blueprints
         * Objects - Are the instances of the class
         * 
         * When an object is created, it inherits all the properties/fields/methods from the class as it's own.
         * 
         * Each instance has it's own copy of the class. (Abstraction), no other instance can alter anothers'
         *  unless allowed to do so (Encapsulation). If I change the value of a field in
         *   one instance it does't change it in all the other instances.
         *   
         *   Examples of Classes - 
         *      - Objects of the class should have common properties/fields/behaviours
         *      - There should be the possibility of having multiple instances of the class.
         *      - When we need to be able to reuse the code.
         *        
         *    Car
         *    House
         *    Person
         * 
         * Objects:
         *  Car Objects - Ferrari, Ford, Chevy, Tesla
         *  Person Objects - Ethan, Alex, Jamie
         *  House Objects - MyHouse, YourHouse, OurHouse
         *  
         *  
         */

        Student ethan = new Student(42314231, 4.5f);
        Student jamie = new Student(32433243, 3.5f); // makes them non-equivalent in the WriteLine
        //Student jamie = ethan; // makes them equivalent in the Console.WriteLine 

        ethan.id = 1234;
        jamie.id = 4342;
        ethan.name = "Ethan";
        jamie.name = "Jamie";

        Console.WriteLine($"The students names are: {ethan.name} and {jamie.name}");
        Console.WriteLine($"The students gpas are: {ethan.gpa} and {jamie.gpa}");

        SportsCar ferrari = new SportsCar(3492, 2020, 999999999);
    }
}

public class Student
{
    // these below are fields/data members - instance variables
    public int id;
    public string name;
    private int ssn;
    public float gpa;

    public int Id { get; set; }
    public int Name { get; set; }
    public int Ssn { get; set; }
    public int Gpa { get; set; }


    // Constructor - initializes values when the class is insantiated into an object;
    // Is usually uesd to initialize the fields or setup the object
    public Student(int ssn, float gpa)
    {
        this.ssn = ssn;
        this.gpa = gpa;
    }
}

public enum FuelType
{
    Gasoline,
    Diesel,
    Electric,
    Oxygen // muscles, think bike
}


// Base Class - Top-Most Class.
public class Vehicle // Base class for all vehicle types;
{
    public int? numWheels;
    public string color;
    public FuelType fuel;

    public void Go()
    {
        Console.WriteLine("vrrrooooom!");
    }

    public void Stop()
    {
        Console.WriteLine("skiirrrrt");
    }
}

public class Car : Vehicle
{
    private int carID;
    public string model;
    public string make;
    public int year;
    private string owner;

    public int CarID
    {
        get { return carID; }
        set { carID = value; }
    }

    public string Owner { get; set; }

    public Car(int carID, int year)
    {
        this.carID = carID;
        this.year = year;
    }

    public int Year { get { return year; } set { year = value; } }
    //public int Year { get; set; }

}


public class SportsCar : Car
{
    // Fields
    public int horsepower;
    public float quarterMileTime;
    public float zeroToSixty;

    // Constructor
    public SportsCar(int carID, int year, int horsepower) : base(carID, year)
    {
        Console.WriteLine($"Created a car with id: {CarID} and year: {Year}");
    }
}