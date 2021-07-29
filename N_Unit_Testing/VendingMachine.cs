using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class VendingMachine
    {
        public void Withdrawal()
		{
			int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] withdrawalNotes = new int[10]; 
		    int changeRs , i , numberOfNotes = 0 ;
			Console.WriteLine("Enter the Change you want to Withdraw ");
			changeRs = Convert.ToInt32(Console.ReadLine());
            Console.Write("You Withdrew ");

            for (i = 0; i < notes.Length ; i++)
            {
                if (changeRs / notes[i] > 0)
                {
                    Console.Write( "Rs "+ notes[i]+ " ");

                    numberOfNotes = changeRs / notes[i];
                    Console.WriteLine(+numberOfNotes+  " Notes ");
                    changeRs %= notes[i];
                }
            }
        }
    }
}
