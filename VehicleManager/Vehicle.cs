using System;

namespace VehicleManager
{
	public class Vehicle
	{
		public enum type { Car = 0, Truck = 1, Bike = 2 };

		public String Make { get; set; }
		public int Speed { get; set; }
		public DateTime Date { get; set; }
		public type Type { get; set; }

		public Vehicle(String make, int speed, DateTime date, type type)
		{
			Make = make;
			Speed = speed;
			Date = date;
			Type = type;
		}
	}
}
