using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class Payment
    {
        public static void MonthlyPayment()
        {
			int P , R , Y ;
			double monthlyPayment , n , r ;
			Console.WriteLine("Enter Principal ");
			P = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Year");
			Y = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Rate of Interest");
			R = Convert.ToInt32(Console.ReadLine());
			n = 12 * Y;
			r = R / 12 * 100;
			monthlyPayment = (P * Math.Pow(( 1 + r ) , n ))/n ;
			Console.Write("Monthly Payment is " + monthlyPayment);
		}
    }
}
