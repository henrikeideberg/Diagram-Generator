using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Diagram_Generator
{
	public class CoordinateManager : ListManager<Coordinate>
	{
		public CoordinateManager()
		{
			ResetListOfCoordinates();
		}

		private void ResetListOfCoordinates()
		{
			base.Reset();
		}

		public bool DrawDiagram()
		{
			return base.Count > 1;
		}

		public void AddCoordinate(Coordinate coordinate)
		{
			base.Add(coordinate);
		}

		public void AddListOfCoordinates(List<Coordinate> coordinates)
		{
			base.SetList(coordinates);
		}

		private float GetDelta(float nrOne, float nrTwo)
		{
			return Math.Abs(nrOne-nrTwo);
		}

		public float GetTotalRangeOfY()
		{
			return GetDelta(GetGreatestY(), GetSmallestY());
		}

		public float GetTotalRangeOfX()
		{
			return GetDelta(GetGreatestX(), GetSmallestX());
		}

		public float GetGreatestY()
		{
			float greatest = base.GetAt(0).yCoord;
			for (int i=0; i<base.Count; i++)
			{
				if (base.GetAt(i).yCoord > greatest) greatest = base.GetAt(i).yCoord;
			}
			return greatest;
		}

		public float GetGreatestX()
		{
			float greatest = base.GetAt(0).xCoord;
			for (int i=0; i<base.Count; i++)
			{
				if (base.GetAt(i).xCoord > greatest) greatest = base.GetAt(i).xCoord;
			}
			return greatest;
		}

		public float GetSmallestY()
		{
			float smallest = base.GetAt(0).yCoord;
			for (int i=0; i<base.Count; i++)
			{
				if (base.GetAt(i).yCoord < smallest) smallest = base.GetAt(i).yCoord;
			}
			return smallest;
		}

		public float GetSmallestX()
		{
			float smallest = base.GetAt(0).xCoord;
			for(int i=0; i<base.Count; i++)
			{
				if (base.GetAt(i).xCoord < smallest) smallest = base.GetAt(i).xCoord;
			}
			return smallest;
		}

		public int GetIntervalX()
		{
			int interval = 0;
			if (base.Count > 0)
			{
				interval = (int)GetTotalRangeOfX() / base.Count;
			}
			return RoundDownToBase(interval);
		}

		public int GetIntervalY()
		{
			int interval = 0;
			if (base.Count > 0)
			{
				interval = (int)GetTotalRangeOfY() / base.Count;
			}
			return RoundDownToBase(interval);
		}

		private int RoundDownToBase(int number)
		{
			int mod = 10;
			while ((number%mod != number) && (number%mod != 0))
			{
				number = number - (number % mod);
				mod = mod * 10;
			}
			return number;
		}

		public int RoundUpToBase(int number)
		{
			int mod = 10;
			while ((number % mod != number) && (number % mod != 0))
			{
				number = number + (mod - (number % mod));
				mod = mod * 10;
			}
			return number;
		}

		public int GetStartY()
		{
			return RoundDownToBase((int)GetSmallestY() - RoundDownToBase(GetIntervalY()));
		}

		public int GetEndY()
		{
			return RoundUpToBase((int)GetGreatestY() + RoundDownToBase(GetIntervalY()));
		}

		public int GetStartX()
		{
			return RoundDownToBase((int)GetSmallestX() - RoundDownToBase(GetIntervalX()));
		}

		public int GetEndX()
		{
			return RoundUpToBase((int)GetGreatestX() + RoundUpToBase(GetIntervalX()));
		}

		public PointF[] GetCoordinatesAsPoints(float drawingAreaX,
											   float drawingAreaY,
											   int offSetX,
											   int offSetY)
		{
			PointF[] coordinatesAsPoints = null;
			if (base.Count > 0)
			{
				coordinatesAsPoints = new PointF[base.Count];
				//Calculate scalefactor and m for x
				int startX = GetStartX();
				int endX = GetEndX();
				float scalingfactorX = drawingAreaX / GetDelta(endX, startX);
				float mStartX = offSetX - startX * scalingfactorX;
				float mEndX = drawingAreaX + offSetX - endX * scalingfactorX;
				if (mStartX != mEndX)
				{
					string errorString = String.Format("Something went wrong when calculating scaling for x-axis.\n" +
						"mStartX: {0}\n" +
						"mEndX: {1}",
						mStartX, mEndX);
					MessageBox.Show(errorString, "Error", MessageBoxButtons.OK);
				}

				//Calculate scalefactor and m for y
				int startY = GetStartY();
				int endY = GetEndY();
				float scalingfactorY = drawingAreaY / GetDelta(endY, startY);
				float mStartY = offSetY - startY * scalingfactorY;
				float mEndY = drawingAreaY + offSetY - endY * scalingfactorY;
				if (mStartY != mEndY)
				{
					string errorString = String.Format("Something went wrong when calculating scaling for y-axis.\n" +
						"mStartY: {0}\n" +
						"mEndY: {1}",
						mStartY, mEndY);
					MessageBox.Show(errorString, "Error", MessageBoxButtons.OK);
				}

				for (int i = 0; i < base.Count; i++)
				{
					coordinatesAsPoints[i] = new PointF(base.GetAt(i).xCoord*scalingfactorX + (mStartX+mEndX)/2,
														(drawingAreaY+2*offSetY) - (base.GetAt(i).yCoord*scalingfactorY + (mStartY+mEndY)/2));
				}
			}
			return coordinatesAsPoints;
		}

		public PointF GetCoordinatesForOrigo(float drawingAreaX,
											 float drawingAreaY,
											 int offSetX,
											 int offSetY)
		{
			PointF origo;
			if (base.Count > 0)
			{
				//Calculate scalefactor and m for x
				int startX = GetStartX();
				int endX = GetEndX();
				float scalingfactorX = drawingAreaX / GetDelta(endX, startX);
				float mStartX = offSetX - startX * scalingfactorX;
				float mEndX = drawingAreaX + offSetX - endX * scalingfactorX;
				if (mStartX != mEndX)
				{
					string errorString = String.Format("Something went wrong when calculating scaling for x-axis.\n" +
						"mStartX: {0}\n" +
						"mEndX: {1}",
						mStartX, mEndX);
					MessageBox.Show(errorString, "Error", MessageBoxButtons.OK);
				}

				//Calculate scalefactor and m for y
				int startY = GetStartY();
				int endY = GetEndY();
				float scalingfactorY = drawingAreaY / GetDelta(endY, startY);
				float mStartY = offSetY - startY * scalingfactorY;
				float mEndY = drawingAreaY + offSetY - endY * scalingfactorY;
				if (mStartY != mEndY)
				{
					string errorString = String.Format("Something went wrong when calculating scaling for y-axis.\n" +
						"mStartY: {0}\n" +
						"mEndY: {1}",
						mStartY, mEndY);
					MessageBox.Show(errorString, "Error", MessageBoxButtons.OK);
				}
				origo = new PointF(0 * scalingfactorX + (mStartX + mEndX) / 2,
								   (drawingAreaY + 2 * offSetY) - (0 * scalingfactorY + (mStartY + mEndY) / 2));
			}
			else
			{
				origo = new PointF(0, drawingAreaY + 2 * offSetY);
			}
			return origo;
		}
	}
}
