using System;

public enum Operation
{
	Accelerate,
	Decelerate
}

public class Character
{
	public static void Main()
	{
		Character fox = new Character("cheese", 5);

		Console.WriteLine(fox.MaxSpeed);
		fox.Speed = 3;
		Console.WriteLine(fox.Speed);

		Console.WriteLine(fox.changeSpeed(Operation.Decelerate, 1));
		Console.WriteLine(fox.Speed);

	}

	private float speed;
	private float maxSpeed;
	private string name;

	public float Speed { get { return this.speed; } set { this.speed = value; } }
	public string Name { get { return this.name; } }
	public float MaxSpeed { get { return this.maxSpeed; } }

	public Character(string name, float maxSpeed)
	{
		this.name = name;
		this.maxSpeed = maxSpeed;
	}

	public float changeSpeed(Operation choice, float change)
	{
		float newSpeed;

		switch (choice)
		{
			case Operation.Accelerate:
				Console.WriteLine("accelerate");
				this.Speed += change;
				newSpeed = this.Speed;
				break;

			case Operation.Decelerate:
				Console.WriteLine("decelerate");
				this.Speed -= change;
				newSpeed = this.Speed;
				break;

			default:
				newSpeed = this.Speed;
				Console.WriteLine("sorry, invalid operation");
				break;
		}

		return newSpeed;
	}
}