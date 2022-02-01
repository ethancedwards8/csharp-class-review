using System;

public class ProductProject
{
	/*
	 * Base Class: Produce
	 * - Place all known shared fields of produce here
	 * - Place all known methods of produce here: expires(), restock()
	 * 
	 * Other classes:
	 * - Fruits
	 *	- Berry
	 *	- Nut
	 * - Vegetables:
	 *  - Root
	 *  - Leafy Greens
	 *
	 *
	 * Create an instance of a few of these classes. Make sure to create constructors inside of Product for any fields.
	 *  for required fields and any other classes that need a constructor
	 */
	public static void Main()
    {
		Fruit blueberry = new Fruit("blueberry", new DateTime(2022, 1, 22), new TimeSpan(24*8, 0, 0), true, true);
		Console.WriteLine(blueberry.harvestDate);
		Console.WriteLine(blueberry.expirationDate);
		Console.WriteLine(blueberry.Ripe + " ripe\n");
		Console.WriteLine(blueberry.isExpired() + " expired\n");

		Console.WriteLine(DateTime.Compare(DateTime.Today, blueberry.harvestDate.Add(blueberry.expirationTime.Divide(2))));
    }
}

// TODO: Remove expiration from constructor and calculate it based off harvesting date.
public class Produce
{
	public object name; // object so that I can shove a string or maybe an enum in it. Lazy? Probably. 
	public TimeSpan expirationTime; // time to expiration
	public DateTime harvestDate; // date harvested
	public DateTime expirationDate; // final calculated date that the food expires on
	public bool needsRefigeration;

	public Produce(object name, DateTime harvestDate, TimeSpan expirationTime, bool needsRefigeration)
    {
		this.name = name;
		this.harvestDate = harvestDate;
		this.expirationTime = expirationTime;
		this.needsRefigeration = needsRefigeration;

		this.expirationDate = CalculateExpirationDate(harvestDate, expirationTime);
    }

	public static DateTime CalculateExpirationDate(DateTime harvestDate, TimeSpan expirationTime)
    {
		// is better to pass the values in through the function or to use this? Not sure. Passing through allows for it to be used across any classes with static.
		return harvestDate.Add(expirationTime); // https://stackoverflow.com/questions/2146296/adding-a-time-to-a-datetime-in-c-sharp thanks.
	}

	public bool isExpired()
    {
		return DateTime.Compare(DateTime.Today, expirationDate) >= 0;
    }
}

public class Fruit : Produce
{
	public bool ripe; // takes half the expirationTime to ripen.

	public Fruit(object name, DateTime harvestDate, TimeSpan expirationTime, bool needsRefigeration, bool ripe) : base(name, harvestDate, expirationTime, needsRefigeration)
    {
		this.ripe = DateTime.Compare(DateTime.Today, harvestDate.Add(expirationTime.Divide(2))) >= 0;
    }

	public bool Ripe { get; set; }
}

public class Vegetable : Produce
{
	public bool needsSkinning;

	public Vegetable(string name, DateTime harvestDate, TimeSpan expirationTime, bool needsRefigeration, bool needsSkinning) : base(name, harvestDate, expirationTime, needsRefigeration)
	{

    }

	public bool NeedsCuting { get; set; }
}

public class Meat : Produce
{
	public bool redMeat;

	public Meat(string name, DateTime harvestDate, TimeSpan expirationTime, bool needsRefigeration, bool redMeat) : base(name, harvestDate, expirationTime, needsRefigeration)
	{

    }

	public bool RedMeat { get; set; }
}