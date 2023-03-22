using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Calculator
{
    public class Calculator
    {
        private const int DEFAULT_VALUE = 0;
        private List<string> DELIMETER = new List<string>() { ",", "\n", ";" };
        private const string DELIMITER_CHANGER = "//";

        public int Add(string numbers)
        {
            //For an empty string return 0
            if (String.IsNullOrWhiteSpace(numbers))
            {
                return DEFAULT_VALUE;
            }

            string[] customDelimiters = { DELIMITER_CHANGER };

            //Default delimiter ; along with other delimiters
            var customDelimiter = numbers.Split(new string[] { "\n", ";" }, StringSplitOptions.RemoveEmptyEntries).First();

            //Check for the default delimiter and change it
            if (numbers.StartsWith(DELIMITER_CHANGER))
            {
                numbers = numbers.Substring(customDelimiter.Length, numbers.Length - customDelimiter.Length);
                var allCustomSeperators = customDelimiter.Split(customDelimiters, StringSplitOptions.RemoveEmptyEntries);

                //Add all values between delimiters
                foreach (var sep in allCustomSeperators)
                {
                    DELIMETER.Add(sep);
                }
            }

            var nums = numbers.Split(DELIMETER.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            var total = new List<int>();

            foreach (var num in nums)
            {
                var separatedValues = Convert.ToInt32(num);

                if (separatedValues < 0)
                {
                    //Print out the Negative number exception and those negative values
                    Console.WriteLine("Negatives not allowed!");
                    nums.ToList().ForEach(i => Console.WriteLine(i.ToString()));

                    //Throw the Negative number exception
                    throw new ApplicationException("Negatives not allowed!");
                }
                total.Add(separatedValues);
            }
            return total.Sum();   //Return the sum of the separated number values
        }
    }
}
