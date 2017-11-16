using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram_Generator
{
	/// <summary>
	/// Class to generate list of coordinates.
	/// Only used during development for testing purposes.
	/// </summary>
	public class CoordinatesGenerator
	{
		public static List<Coordinate> PositiveCoordinates()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = 1,
				yCoord = 205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 3,
				yCoord = 315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 4,
				yCoord = 273
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 7,
				yCoord = 528
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 9,
				yCoord = 544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)11.5,
				yCoord = 469
			});
			return coordinates;
		}

		public static List<Coordinate> NegativeCoordinates()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = -1,
				yCoord = -205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -3,
				yCoord = -315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -4,
				yCoord = -273
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -7,
				yCoord = -528
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -9,
				yCoord = -544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)-11.5,
				yCoord = -469
			});
			return coordinates;
		}

		public static List<Coordinate> NegativeXPositiveYCoordinates()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = -1,
				yCoord = 205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -3,
				yCoord = 315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -4,
				yCoord = 273
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -7,
				yCoord = 528
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -9,
				yCoord = 544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)-11.5,
				yCoord = 469
			});
			return coordinates;
		}

		public static List<Coordinate> NegativeYPositiveXCoordinates()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = 1,
				yCoord = -205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 3,
				yCoord = -315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 4,
				yCoord = -273
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 7,
				yCoord = -528
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 9,
				yCoord = -544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)11.5,
				yCoord = -469
			});
			return coordinates;
		}

		public static List<Coordinate> QuadrantOneTwoThreeFour()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = 13,
				yCoord = 196
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)11.5,
				yCoord = 74
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 3,
				yCoord = -315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 1,
				yCoord = -205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -4,
				yCoord = -34
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -7,
				yCoord = -100
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -9,
				yCoord = 544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -11,
				yCoord = 469
			});
			return coordinates;
		}

		public static List<Coordinate> QuadrantOneTwoThree()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = 3,
				yCoord = 315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 1,
				yCoord = 205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -4,
				yCoord = 273
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -7,
				yCoord = 528
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -9,
				yCoord = -544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)-11.5,
				yCoord = -469
			});
			return coordinates;
		}

		public static List<Coordinate> QuadrantOneTwoFour()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = 7,
				yCoord = -528
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 4,
				yCoord = -273
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 3,
				yCoord = 315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 1,
				yCoord = 205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -9,
				yCoord = 544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)-11.5,
				yCoord = 469
			});
			return coordinates;
		}

		public static List<Coordinate> QuadrantTwoThreeFour()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = 7,
				yCoord = 528
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 4,
				yCoord = 273
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 3,
				yCoord = -315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 1,
				yCoord = -205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -9,
				yCoord = -544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)-11.5,
				yCoord = -469
			});
			return coordinates;
		}

		public static List<Coordinate> QuadrantOneThreeFour()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = 3,
				yCoord = -315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 1,
				yCoord = -205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -4,
				yCoord = -273
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -7,
				yCoord = -528
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -9,
				yCoord = 544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)-11.5,
				yCoord = 469
			});
			return coordinates;
		}

		public static List<Coordinate> QuadrantOneTwo()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = 4,
				yCoord = 273
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 3,
				yCoord = 315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 1,
				yCoord = 205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -7,
				yCoord = 528
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -9,
				yCoord = 544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)-11.5,
				yCoord = 469
			});
			return coordinates;
		}

		public static List<Coordinate> QuadrantOneThree()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = -1,
				yCoord = -205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -3,
				yCoord = -315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -4,
				yCoord = -273
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -7,
				yCoord = 528
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -9,
				yCoord = 544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)-11.5,
				yCoord = 469
			});
			return coordinates;
		}

		public static List<Coordinate> QuadrantOneFour()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = 4,
				yCoord = -273
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 3,
				yCoord = -315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 1,
				yCoord = -205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 0,
				yCoord = 0
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -7,
				yCoord = 528
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -9,
				yCoord = 544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)-11.5,
				yCoord = 469
			});
			return coordinates;
		}

		public static List<Coordinate> QuadrantTwoThree()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = 4,
				yCoord = 273
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 3,
				yCoord = 315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 1,
				yCoord = 205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 0,
				yCoord = 0
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -7,
				yCoord = -528
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -9,
				yCoord = -544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)-11.5,
				yCoord = -469
			});
			return coordinates;
		}

		public static List<Coordinate> QuadrantThreeFour()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = 4,
				yCoord = -273
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 3,
				yCoord = -315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 1,
				yCoord = -205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -7,
				yCoord = -528
			});
			coordinates.Add(new Coordinate
			{
				xCoord = -9,
				yCoord = -544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)-11.5,
				yCoord = -469
			});
			return coordinates;
		}

		public static List<Coordinate> QuadrantTwoFour()
		{
			List<Coordinate> coordinates = new List<Coordinate>();
			coordinates.Add(new Coordinate
			{
				xCoord = 1,
				yCoord = -205
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 3,
				yCoord = -315
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 4,
				yCoord = -273
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 7,
				yCoord = 528
			});
			coordinates.Add(new Coordinate
			{
				xCoord = 9,
				yCoord = 544
			});
			coordinates.Add(new Coordinate
			{
				xCoord = (float)11.5,
				yCoord = 469
			});
			return coordinates;
		}
	}
}
