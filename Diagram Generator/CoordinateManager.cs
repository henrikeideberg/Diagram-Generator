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
		int startY;
		int endX;
		int endY;
		float scalingfactorX;
		float mX;
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

		private float GetTotalRangeOfY()
		{
			return Utility.GetDelta(GetGreatestY(), GetSmallestY());
		}

		private float GetTotalRangeOfX()
		{
			return Utility.GetDelta(GetGreatestX(), GetSmallestX());
		}

		private float GetGreatestY()
		{
			float greatest = base.GetAt(0).yCoord;
			for (int i=0; i<base.Count; i++)
			{
				if (base.GetAt(i).yCoord > greatest) greatest = base.GetAt(i).yCoord;
			}
			return greatest;
		}

		private float GetGreatestX()
		{
			float greatest = base.GetAt(0).xCoord;
			for (int i=0; i<base.Count; i++)
			{
				if (base.GetAt(i).xCoord > greatest) greatest = base.GetAt(i).xCoord;
			}
			return greatest;
		}

		private float GetSmallestY()
		{
			float smallest = base.GetAt(0).yCoord;
			for (int i=0; i<base.Count; i++)
			{
				if (base.GetAt(i).yCoord < smallest) smallest = base.GetAt(i).yCoord;
			}
			return smallest;
		}

		private float GetSmallestX()
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
			int smallestY = (int)GetSmallestY();
			if(smallestY < 0) return Utility.RoundUpToBase((int)GetSmallestY() - Utility.RoundDownToBase(GetIntervalY()));
			else return Utility.RoundDownToBase((int)GetSmallestY() - Utility.RoundDownToBase(GetIntervalY()));
		}

		private int GetEndY()
		{
			return Utility.RoundUpToBase((int)GetGreatestY() + Utility.RoundDownToBase(GetIntervalY()));
		}

		public int GetStartX()
		{
			int smallestX = (int)GetSmallestX();
			if(smallestX < 0) return Utility.RoundUpToBase((int)GetSmallestX() - Utility.RoundDownToBase(GetIntervalX()));
			else return Utility.RoundDownToBase((int)GetSmallestX() - Utility.RoundDownToBase(GetIntervalX()));
		}

		private int GetEndX()
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

		private PointF GetOrigo(float drawingAreaX,
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

		public PointF GetCoordinatesForOrigo(float drawingAreaX,
											 float drawingAreaY,
											 int offSetX,
											 int offSetY)
		{
			return GetOrigo(drawingAreaX, drawingAreaY, offSetX, offSetY);
		}

		public float GetXIntervalAsPoints(float drawingAreaX, int offSetX, int intervalX)
		{
			CalculateXCoordinatesAsPoints(drawingAreaX, offSetX);
			return intervalX * scalingfactorX;
		}

		public float GetXIntervalAsPoints(float drawingAreaX, int offSetX)
		{
			CalculateXCoordinatesAsPoints(drawingAreaX, offSetX);
			return GetIntervalX() * scalingfactorX;
		}

		public float GetYIntervalAsPoints(float drawingAreaY, int offSetY, int intervalY)
		{
			CalculateYCoordinatesAsPoints(drawingAreaY, offSetY);
			return intervalY * scalingfactorY;
		}

		public float GetYIntervalAsPoints(float drawingAreaY, int offSetY)
		{
			CalculateYCoordinatesAsPoints(drawingAreaY, offSetY);
			return GetIntervalY() * scalingfactorY;
		}

		public void SetStartAndEnd()
		{
			this.startX = GetStartX();
			this.startY = GetStartY();
			this.endX = GetEndX();
			this.endY = GetEndY();
		}

		public void SetStartAndEnd(int startXUser, int startYUser,
								   int endXUser, int endYUser)
		{
			this.startX = startXUser;
			this.startY = startYUser;
			this.endX = endXUser;
			this.endY = endYUser;
		}
	}
}
