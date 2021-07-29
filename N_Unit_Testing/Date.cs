using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class Date
	{
		public static void DayOfWeek()
		{
			String day = "";
			String month = "";
			int m = 0;
			int y = 0;
			int d = 0;
			Console.WriteLine("Enter Day");
			d = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Month");
			month = Console.ReadLine().ToLower();
			Console.WriteLine("Enter Year");
			y = Convert.ToInt32(Console.ReadLine());
			switch (month)
			{
				case "january":
					m = 1;
					break;

				case "february":
					m = 2;
					break;

				case "march":
					m = 3;
					break;

				case "april":
					m = 4;
					break;

				case "may":
					m = 5;
					break;

				case "june":
					m = 6;
					break;

				case "july":
					m = 7;
					break;

				case "august":
					m = 8;
					break;

				case "september":
					m = 9;
					break;

				case "october":
					m = 10;
					break;

				case "november":
					m = 11;
					break;

				case "december":
					m = 12;
					break;

				default:
					Console.WriteLine("Incorrect Month , Please Enter the correct spelling of particular Month");
					break;
			}
			int y0 = (y - (14 - m)) / 12;
			int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
			int m0 = (m + 12) * (((14 - m) / 12) - 2);
			int d0 = (d + x + ((31 * m0) / 12)) % 7;
			switch (d0)
			{
				case 0:
					day = "Saturday";
					break;
				case 1:
					day = "Sunday";
					break;
				case 2:
					day = "Monday";
					break;
				case 3:
					day = "Tuesday";
					break;
				case 4:
					day = "Wednesday";
					break;
				case 5:
					day = "Thursday";
					break;
				case 6:
					day = "Friday";
					break;
			}
			Console.WriteLine("The Day of Week is " + day);
		}
	}
}
