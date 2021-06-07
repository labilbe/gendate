using System;
using System.Collections.Generic;

namespace gendate
{
    class Program
    {
        static void Main(string[] args)
        {
        	var firstDate = new DateTime(1900, 1, 1);
        	var lastDate = new DateTime(2020, 03, 09);

    		var formats = new[] 
    		{ 
    			"ddMMyyyy",
    			"ddMMyy",    			
    			"dd/MM/yyyy",
    			"dd/MM/yy",
    			"dd-MM-yyyy",
    			"dd-MM-yy",
				"d/M/yy",
				"d/M/yyyy",
    		};

			var dates = new List<string>();
			foreach (var format in formats)
			{
				for (var date = firstDate; date <= lastDate; date = date.AddDays(1))
					dates.Add(date.ToString(format));

			}
			dates.Sort();

			foreach (var date in dates)
				Console.WriteLine(date);
        }
    }
}
