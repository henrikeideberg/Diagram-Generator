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
		PointF[] coordinatesAsPoints;
		int startX;
		int endX;
		float scalingfactorX;
		float mX;
		int startY;
		int endY;
		float scalingfactorY;
		float mY;

		public CoordinateManager()
		{
			coordinatesAsPoints = null;
		}

		public bool DrawDiagram()
		{
			return base.Count > 1;
		}

		public float GetTotalRangeOfY()
		{
			return Utility.GetDelta(GetGreatestY(), GetSmallestY());
		}

		public float GetTotalRangeOfX()
		{
			return Utility.GetDelta(GetGreatestX(), GetSmallestX());
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
			return Utility.RoundDownToBase(interval);
		}

		public int GetIntervalY()
		{
			int interval = 0;
			if (base.Count > 0)
			{
				interval = (int)GetTotalRangeOfY() / base.Count;
			}
			return Utility.RoundDownToBase(interval);
		}

		public int GetStartY()
		{
			return Utility.RoundDownToBase((int)GetSmallestY() - Utility.RoundDownToBase(GetIntervalY()));
		}

		public int GetEndY()
		{
			return Utility.RoundUpToBase((int)GetGreatestY() + Utility.RoundDownToBase(GetIntervalY()));
		}

		public int GetStartX()
		{
			return Utility.RoundDownToBase((int)GetSmallestX() - Utility.RoundDownToBase(GetIntervalX()));
		}

		public int GetEndX()
		{
			return Utility.RoundUpToBase((int)GetGreatestX() + Utility.RoundUpToBase(GetIntervalX()));
		}

		private void CalculateCoordinatesAsPoints(float drawingAreaX,
											      float drawingAreaY,
											      int offSetX,
											      int offSetY)
		{
			if (base.Count > 0)
			{
				//Calculate scalefactor and m for x
				CalculateXCoordinatesAsPoints(drawingAreaX, offSetX);

				//Calculate scalefactor and m for y
				CalculateYCoordinatesAsPoints(drawingAreaY, offSetY);

				coordinatesAsPoints = new PointF[base.Count];
				for (int i = 0; i < base.Count; i++)
				{
					coordinatesAsPoints[i] = new PointF(base.GetAt(i).xCoord * scalingfactorX + mX,
														(drawingAreaY + 2 * offSetY) - (base.GetAt(i).yCoord * scalingfactorY + mY));
				}
			}
		}

		private void CalculateXCoordinatesAsPoints(float drawingAreaX, int offSetX)
		{
			if (base.Count > 0)
			{
				//Calculate scalefactor and m for x
				startX = GetStartX();
				endX = GetEndX();
				scalingfactorX = drawingAreaX / Utility.GetDelta(endX, startX);
				float mStartX = offSetX - startX * scalingfactorX;
				float mEndX = drawingAreaX + offSetX - endX * scalingfactorX;
				mX = (mStartX + mEndX) / 2;
			}
		}

		private void CalculateYCoordinatesAsPoints(float drawingAreaY, int offSetY)
		{
			if (base.Count > 0)
			{
				//Calculate scalefactor and m for y
				startY = GetStartY();
				endY = GetEndY();
				scalingfactorY = drawingAreaY / Utility.GetDelta(endY, startY);
				float mStartY = offSetY - startY * scalingfactorY;
				float mEndY = drawingAreaY + offSetY - endY * scalingfactorY;
				mY = (mStartY + mEndY) / 2;
			}
		}

		public PointF[] GetCoordinatesAsPoints(float drawingAreaX,
											   float drawingAreaY,
											   int offSetX,
											   int offSetY)
		{
			CalculateCoordinatesAsPoints(drawingAreaX, drawingAreaY, offSetX, offSetY);
			return coordinatesAsPoints;
		}

		public PointF GetCoordinatesForOrigo(float drawingAreaX,
											 float drawingAreaY,
											 int offSetX,
											 int offSetY)
		{
			PointF origo;
			CalculateCoordinatesAsPoints(drawingAreaX, drawingAreaY, offSetX, offSetY);
			if (base.Count > 0)
			{
				origo = new PointF(0 * scalingfactorX + mX,
								   (drawingAreaY + 2 * offSetY) - (0 * scalingfactorY + mY));
			}
			else
			{
				origo = new PointF(0, drawingAreaY + 2 * offSetY);
			}
			return origo;
		}

		public float GetXIntervalAsPoints(float drawingAreaX, int offSetX)
		{
			CalculateXCoordinatesAsPoints(drawingAreaX, offSetX);
			return GetIntervalX() * scalingfactorX;
		}

		public float GetYIntervalAsPoints(float drawingAreaY, int offSetY)
		{
			CalculateYCoordinatesAsPoints(drawingAreaY, offSetY);
			return GetIntervalY() * scalingfactorY;
		}


		/*
		string msgstring;
		msgstring = string.Format(
			"drawingAreaForX: {0}\n" +
			"drawingStartX: {1}\n" +
			"drawingEndX: {2}\n" +
			"rangeOfX: {3}\n" +
			"scalefactorX: {4}\n" +
			"smallestX: {5}\n" +
			"greatestX: {6}\n" +
			"intervalX: {7}\n" +
			"startX: {8}\n" +
			"endX: {9}",
			drawingAreaForX,
			offSetX,
			offSetX + drawingAreaForX,
			coordinates.GetTotalRangeOfX(),
			scaleFactorX,
			coordinates.GetSmallestX(),
			coordinates.GetGreatestX(),
			coordinates.GetIntervalX(),
			coordinates.GetStartX(),
			coordinates.GetEndX());
		MessageBox.Show(msgstring, "Title", MessageBoxButtons.OK);

		msgstring = string.Format(
			"drawingAreaForY: {0}\n" +
			"drawingStartY: {1}\n" +
			"drawingEndY: {2}\n" +
			"rangeOfY: {3}\n" +
			"scalefactorY: {4}\n" +
			"smallestY: {5}\n" +
			"greatestY: {6}\n" +
			"intervalY: {7}\n" +
			"startY: {8}\n" +
			"endY: {9}",
			drawingAreaForY,
			offSetY,
			offSetY + drawingAreaForY,
			coordinates.GetTotalRangeOfY(),
			scaleFactorY,
			coordinates.GetSmallestY(),
			coordinates.GetGreatestY(),
			coordinates.GetIntervalY(),
			coordinates.GetStartY(),
			coordinates.GetEndY());
		MessageBox.Show(msgstring, "Title", MessageBoxButtons.OK);
		*/
	}
}
