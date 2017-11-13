using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram_Generator
{
	public class CoordinatesGenerator
	{
		public static List<Coordinate> PositiveCoordinates()
		{
			List<Coordinate> coordinates = new List<Coordinate>();

			//TBD - this must be updated to use the new method AddCoordinate
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

			//TBD - this must be updated to use the new method AddCoordinate
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
	}
}
