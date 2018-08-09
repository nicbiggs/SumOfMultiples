using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultiples
{
	static class ParseIntegers
	{
		public static List<int> GetIntegers(string integersInString)
		{
			List<int> ints = new List<int>();
			string[] parsedFactors = integersInString.Split(',', ' ');

			foreach (string factor in parsedFactors)
			{
				if (factor.All(c => char.IsDigit(c)))
				{
					ints.Add(int.Parse(factor));
				}
			}
			return ints;
		}
	}
}
