using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
	class TemperatureConversion
	{
		public static void Conversion()
		{
			double temperature, fahrenheitTemperature, celsiusTemperature;
			Console.WriteLine("Enter 1 for Celsius to Fahrenheit Conversion or 2 for Fareheit to Celsius");
			int choice = Convert.ToInt32(Console.ReadLine());
			switch (choice)
			{
				case 1:
					Console.WriteLine("Enter Temparature in Celsius");
					temperature = Convert.ToDouble(Console.ReadLine());
					fahrenheitTemperature = (temperature * 9) / 5 + 32;
					Console.Write("Temperature in Fahrenheit : " + fahrenheitTemperature);
					break;
				case 2:

					Console.WriteLine("Enter Temparature in Fahrenheit ");
					temperature = Convert.ToDouble(Console.ReadLine());
					celsiusTemperature = (temperature - 32) * 5 / 9;
					Console.Write("Temperature in Celsius  : " + celsiusTemperature);
					break;
				default:
					Console.WriteLine("Incorrect Choice");
					break;
			}
		}
	}
}
