using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram_Generator
{
	public class Utility
	{
		public static int RoundDownToBase(int number)
		{
			int mod = 10;
			while ((number % mod != number) && (number % mod != 0))
			{
				number = number - (number % mod);
				mod = mod * 10;
			}
			return number;
		}

		public static int RoundUpToBase(int number)
		{
			int mod = 10;
			while ((number % mod != number) && (number % mod != 0))
			{
				number = number + (mod - (number % mod));
				mod = mod * 10;
			}
			return number;
		}

		public static float GetDelta(float nrOne, float nrTwo)
		{
			return Math.Abs(nrOne - nrTwo);
		}
	}
}
