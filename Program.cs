using System;

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
    		};

			foreach (var format in formats)
        		for (var date = firstDate; date <= lastDate; date = date.AddDays(1))        		
            		Console.WriteLine(date.ToString(format));
        }
    }
}
