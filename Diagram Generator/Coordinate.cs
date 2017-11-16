using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram_Generator
{
	/// <summary>
	/// Class which represents a coordinate in a diagram/graph.
	/// </summary>
	public class Coordinate : IComparable
	{
		public float xCoord { get; set; }
		public float yCoord { get; set; }

		public override string ToString()
		{
			string strOut = string.Format("({0}, {1})", xCoord, yCoord);
			return strOut;
		}

		/// <summary>
		/// Method implementation of the interface definition CompareTo.
		/// This implementation is mandatory and can be used to Sort the
		/// list by coordinates,
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		int IComparable.CompareTo(object obj)
		{
			Coordinate coordinate2 = (Coordinate)obj;
			if (this.xCoord > coordinate2.xCoord)
				return (1);
			if (this.xCoord < coordinate2.xCoord)
				return (-1);
			else
				return (0);
		}

		/// <summary>
		/// Method to compare xCoord of one coordinate against another.
		/// Useful when coordinates are in a list and one wants to sort the list
		/// based on the x-coordnate.
		/// </summary>
		public class SortByXCoord : IComparer<Coordinate>
		{
			public int Compare(Coordinate coordinate1, Coordinate coordinate2)
			{
				return (((IComparable)coordinate1).CompareTo(coordinate2));
			}
		}

		/// <summary>
		/// Method to compare yCoord of one coordinate against another.
		/// Useful when coordinates are in a list and one wants to sort the list
		/// based on the y-coordinate.
		/// </summary>
		public class SortByYCoord : IComparer<Coordinate>
		{
			public int Compare(Coordinate coordinate1, Coordinate coordinate2)
			{
				if (coordinate1.yCoord > coordinate2.yCoord)
					return (1);
				if (coordinate1.yCoord < coordinate2.yCoord)
					return (-1);
				else
					return (0);
			}
		}
	}
}
