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
		PointF[] coordinatesAsPoints; //Coordinates stored as Points
		int startX;				//Start of x-axis
		int startY;				//Start of y-axis
		int endX;				//End of x-axis
		int endY;				//End of y-axis
		float scalingfactorX;	//Scalingfactor for coordinates in x-axis
		float mX;				//m (offset) for coordinates in x-axis
		float scalingfactorY;	//Scalingfactor for coordinates in y-axis
		float mY;				//m (offset) for coordinates in y-axis

		public CoordinateManager()
		{
			//Init all variables
			coordinatesAsPoints = null;
			startX = 0;
			startY = 0;
			endX = 0;
			endY = 0;
			scalingfactorX = 0;
			mX = 0;
			scalingfactorY = 0;
			mY = 0;
		}

		/// <summary>
		/// Method returns true if there are enough coordinates in
		/// list to draw a graph/diagram.
		/// </summary>
		/// <returns></returns>
		public bool DrawDiagram()
		{
			return base.Count > 1;
		}

		/// <summary>
		/// Method to return interval setting for x-axis.
		/// Used when graph is drawn with automatic settings.
		/// </summary>
		/// <returns></returns>
		public int GetIntervalX()
		{
			int interval = 0;
			if (base.Count > 0)
			{
				interval = (int)GetTotalRangeOfX() / base.Count;
			}
			return Utility.RoundDownToBase(interval);
		}

		/// <summary>
		/// Method to return interval setting for y-axis.
		/// Used when graoh is drawn with automatic settings.
		/// </summary>
		/// <returns></returns>
		public int GetIntervalY()
		{
			int interval = 0;
			if (base.Count > 0)
			{
				interval = (int)GetTotalRangeOfY() / base.Count;
			}
			return Utility.RoundDownToBase(interval);
		}

		/// <summary>
		/// Method to return start of y-axis.
		/// </summary>
		/// <returns></returns>
		public int GetStartY()
		{
			int smallestY = (int)GetSmallestY();
			if(smallestY < 0) return Utility.RoundUpToBase((int)GetSmallestY() - Utility.RoundDownToBase(GetIntervalY()));
			else return Utility.RoundDownToBase((int)GetSmallestY() - Utility.RoundDownToBase(GetIntervalY()));
		}

		/// <summary>
		/// Method to return start of x-axis.
		/// </summary>
		/// <returns></returns>
		public int GetStartX()
		{
			int smallestX = (int)GetSmallestX();
			if (smallestX < 0) return Utility.RoundUpToBase((int)GetSmallestX() - Utility.RoundDownToBase(GetIntervalX()));
			else return Utility.RoundDownToBase((int)GetSmallestX() - Utility.RoundDownToBase(GetIntervalX()));
		}

		/// <summary>
		/// Method to calculate and return coordinates as Points.
		/// The method returns the variable coordinatesAsPoints.
		/// </summary>
		/// <param name="drawingAreaX"></param>
		/// <param name="drawingAreaY"></param>
		/// <param name="offSetX"></param>
		/// <param name="offSetY"></param>
		/// <returns></returns>
		public PointF[] GetCoordinatesAsPoints(float drawingAreaX,
											   float drawingAreaY,
											   int offSetX,
											   int offSetY)
		{
			CalculateCoordinatesAsPoints(drawingAreaX, drawingAreaY, offSetX, offSetY);
			return coordinatesAsPoints;
		}

		/// <summary>
		/// Method to return coordinates (as PointF) for origo.
		/// </summary>
		/// <param name="drawingAreaX"></param>
		/// <param name="drawingAreaY"></param>
		/// <param name="offSetX"></param>
		/// <param name="offSetY"></param>
		/// <returns></returns>
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

		/// <summary>
		/// Calculate and returns the user inputted x-axis interval as Points.
		/// This method is used when graph is drawn using manual settings,
		/// where interval is set by the user.
		/// </summary>
		/// <param name="drawingAreaX"></param>
		/// <param name="offSetX"></param>
		/// <param name="intervalX"></param>
		/// <returns></returns>
		public float GetXIntervalAsPoints(float drawingAreaX, int offSetX, int intervalX)
		{
			CalculateXCoordinatesAsPoints(drawingAreaX, offSetX);
			return intervalX * scalingfactorX;
		}

		/// <summary>
		/// Calculate and return the x-axis interval as Points.
		/// This method is used when graph is drawn using automatic
		/// settings.
		/// </summary>
		/// <param name="drawingAreaX"></param>
		/// <param name="offSetX"></param>
		/// <returns></returns>
		public float GetXIntervalAsPoints(float drawingAreaX, int offSetX)
		{
			CalculateXCoordinatesAsPoints(drawingAreaX, offSetX);
			return GetIntervalX() * scalingfactorX;
		}

		/// <summary>
		/// Calculate and return the user inputted y-axis interval as Points.
		/// This method is used when graph is drawn using manual settings,
		/// where inerval is set by the user.
		/// </summary>
		/// <param name="drawingAreaY"></param>
		/// <param name="offSetY"></param>
		/// <param name="intervalY"></param>
		/// <returns></returns>
		public float GetYIntervalAsPoints(float drawingAreaY, int offSetY, int intervalY)
		{
			CalculateYCoordinatesAsPoints(drawingAreaY, offSetY);
			return intervalY * scalingfactorY;
		}

		/// <summary>
		/// Calculate and return the y-axis interval as Points.
		/// This method is used when graph is drawn using automatic
		/// settings.
		/// </summary>
		/// <param name="drawingAreaY"></param>
		/// <param name="offSetY"></param>
		/// <returns></returns>
		public float GetYIntervalAsPoints(float drawingAreaY, int offSetY)
		{
			CalculateYCoordinatesAsPoints(drawingAreaY, offSetY);
			return GetIntervalY() * scalingfactorY;
		}

		/// <summary>
		/// Method to set x-axis and y-axis start and end values.
		/// Method must be run before any other calculations are done.
		/// Method used when graph is drawn using automatic settings.
		/// </summary>
		public void SetStartAndEnd()
		{
			this.startX = GetStartX();
			this.startY = GetStartY();
			this.endX = GetEndX();
			this.endY = GetEndY();
		}

		/// <summary>
		/// Method to set x-axis and y-axis start and end values.
		/// Method must be run before any other calculations are done.
		/// Method used when graph is dranw using manual settings.
		/// </summary>
		/// <param name="startXUser"></param>
		/// <param name="startYUser"></param>
		/// <param name="endXUser"></param>
		/// <param name="endYUser"></param>
		public void SetStartAndEnd(int startXUser, int startYUser,
								   int endXUser, int endYUser)
		{
			this.startX = startXUser;
			this.startY = startYUser;
			this.endX = endXUser;
			this.endY = endYUser;
		}

		public Coordinate GetCoordinateFromPoints(float xCoordPoints, float yCoordPoints)
		{
			// graphX = x*ScaleFactorX + m => (graphX - m)/newScaleFactorX = x
			// graphY = y*ScaleFactorY + m => (graphY - m)/newScaleFactorY = y
			float xNewCoord = (xCoordPoints - mX) / scalingfactorX;
			float yNewCoord = (yCoordPoints - mY) / scalingfactorY;
			return new Coordinate
			{
				xCoord = xNewCoord,
				yCoord = yNewCoord
			};
		}

		/**********************************************************************
		 * 
		 *		private helper functions
		 *		
		 *********************************************************************/
		/// <summary>
		/// Method to calculate and return range of the y-values.
		/// </summary>
		/// <returns></returns>
		private float GetTotalRangeOfY()
		{
			return Utility.GetDelta(GetGreatestY(), GetSmallestY());
		}

		/// <summary>
		/// Method to calculate and return range of the x-values.
		/// </summary>
		/// <returns></returns>
		private float GetTotalRangeOfX()
		{
			return Utility.GetDelta(GetGreatestX(), GetSmallestX());
		}

		/// <summary>
		/// Method which returns the greatest y-coordinate.
		/// </summary>
		/// <returns></returns>
		private float GetGreatestY()
		{
			float greatest = base.GetAt(0).yCoord;
			for (int i = 0; i < base.Count; i++)
			{
				if (base.GetAt(i).yCoord > greatest) greatest = base.GetAt(i).yCoord;
			}
			return greatest;
		}

		/// <summary>
		/// Method which returns the greatest x-coordinate.
		/// </summary>
		/// <returns></returns>
		private float GetGreatestX()
		{
			float greatest = base.GetAt(0).xCoord;
			for (int i = 0; i < base.Count; i++)
			{
				if (base.GetAt(i).xCoord > greatest) greatest = base.GetAt(i).xCoord;
			}
			return greatest;
		}

		/// <summary>
		/// Method which returns the smallest y-coordinate.
		/// </summary>
		/// <returns></returns>
		private float GetSmallestY()
		{
			float smallest = base.GetAt(0).yCoord;
			for (int i = 0; i < base.Count; i++)
			{
				if (base.GetAt(i).yCoord < smallest) smallest = base.GetAt(i).yCoord;
			}
			return smallest;
		}

		/// <summary>
		/// Method which returns the smallest x-coordinate.
		/// </summary>
		/// <returns></returns>
		private float GetSmallestX()
		{
			float smallest = base.GetAt(0).xCoord;
			for (int i = 0; i < base.Count; i++)
			{
				if (base.GetAt(i).xCoord < smallest) smallest = base.GetAt(i).xCoord;
			}
			return smallest;
		}

		/// <summary>
		/// Method to calculate the x and y coordinates as Points.
		/// </summary>
		/// <param name="drawingAreaX"></param>
		/// <param name="drawingAreaY"></param>
		/// <param name="offSetX"></param>
		/// <param name="offSetY"></param>
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

		/// <summary>
		/// Method to calculate the x coordinates as Points.
		/// </summary>
		/// <param name="drawingAreaX"></param>
		/// <param name="offSetX"></param>
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

		/// <summary>
		/// Method to calculate the y coordinates as Points.
		/// </summary>
		/// <param name="drawingAreaY"></param>
		/// <param name="offSetY"></param>
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

		/// <summary>
		/// Calculate and return x-axis end value.
		/// </summary>
		/// <returns></returns>
		private int GetEndY()
		{
			return Utility.RoundUpToBase((int)GetGreatestY() + Utility.RoundDownToBase(GetIntervalY()));
		}

		/// <summary>
		/// Calculate and return y-axis end value.
		/// </summary>
		/// <returns></returns>
		private int GetEndX()
		{
			return Utility.RoundUpToBase((int)GetGreatestX() + Utility.RoundUpToBase(GetIntervalX()));
		}
	}
}
