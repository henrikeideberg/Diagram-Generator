using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagram_Generator
{
	public partial class Diagram_Generator : Form
	{
		private CoordinateManager coordinates;
		public Diagram_Generator()
		{
			InitializeComponent();

			//Create default paint event handler
			diagramPanel.Paint += new PaintEventHandler(diagramPanel_Paint);

			//For testing
			// - start with all positive coordinates
			coordinates = new CoordinateManager();
			coordinates.SetList(CoordinatesGenerator.PositiveCoordinates());
		}

		private void diagramPanel_Paint(object sender, PaintEventArgs e)
		{
			var p = sender as Panel;
			//Use below as reference when drawing
			//p.Height
			//p.Width

			var g = e.Graphics;

			//Set title
			string title = "Diagram"; //tbd get this from label
			Font titleFont = new Font("Verdana", 32);
			//Get size of the title we want to draw,
			// https://msdn.microsoft.com/en-us/library/6xe5hazb(v=vs.110).aspx
			SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
			Point titlePoint = new Point();
			titlePoint.X = (p.Width/2) - (int)(titleSize.Width/2);
			titlePoint.Y = 0;
			g.DrawString(title, titleFont, Brushes.Blue, titlePoint);
			titleFont.Dispose();

			//If there is more than one coordinate draw
			if(coordinates.DrawDiagram())
			{
				int offSetX = 50;//to not have graph at edges of label
				int offSetY = Utility.RoundUpToBase((int)titleSize.Height);
				float drawingAreaForX = diagramPanel.Width - 2 * offSetX;
				float drawingAreaForY = diagramPanel.Height - 2 * offSetY;

				Pen blackPen = new Pen(Color.Black, 3);
				g.DrawLines(blackPen, coordinates.GetCoordinatesAsPoints(drawingAreaForX, drawingAreaForY, offSetX, offSetY));

				PointF origo = coordinates.GetCoordinatesForOrigo(drawingAreaForX, drawingAreaForY, offSetX, offSetY);
				//Make sure coordinates of origo are not 'out of bounds'
				if (origo.X > drawingAreaForX + offSetX) origo.X = drawingAreaForX + offSetX;
				if (origo.X < offSetX) origo.X = offSetX;
				if (origo.Y > drawingAreaForY + offSetY) origo.Y = drawingAreaForY + offSetY;
				if (origo.Y < offSetY) origo.Y = offSetY;

				Font intervalTextFont = new Font("Verdana", 12);
				//Draw x-axis
				PointF startXAxis = new PointF(offSetX, origo.Y);
				PointF endXAxis = new PointF(offSetX+drawingAreaForX, origo.Y);
				g.DrawLine(blackPen, origo, startXAxis);
				g.DrawLine(blackPen, origo, endXAxis);
				//Draw the interval markers on the x-axis
				int xAxisInterval = coordinates.GetIntervalX();
				float xAxisIntervalInPoints = coordinates.GetXIntervalAsPoints(drawingAreaForX, offSetX);
				//Draw first one
				int intervalXText = coordinates.GetStartX();
				g.DrawString(intervalXText.ToString(), intervalTextFont, Brushes.Blue, startXAxis);
				startXAxis.X += xAxisIntervalInPoints;
				while (startXAxis.X < endXAxis.X)
				{
					intervalXText += xAxisInterval;
					g.DrawString(intervalXText.ToString(), intervalTextFont, Brushes.Blue, startXAxis);
					startXAxis.X += xAxisIntervalInPoints;
				}

				//Draw y-axis
				PointF startYAxis = new PointF(origo.X, offSetY);
				PointF endYAxis = new PointF(origo.X, offSetY+drawingAreaForY);
				g.DrawLine(blackPen, origo, startYAxis);
				g.DrawLine(blackPen, origo, endYAxis);

				//Draw the interval markers on the y-axis
				int yAxisInterval = coordinates.GetIntervalY();
				float yAxisIntervalInPoints = coordinates.GetYIntervalAsPoints(drawingAreaForY, offSetY);
				//Draw first one
				int intervalYText = coordinates.GetStartY();
				g.DrawString(intervalYText.ToString(), intervalTextFont, Brushes.Blue, endYAxis);
				endYAxis.Y -= yAxisIntervalInPoints;
				while (endYAxis.Y > startYAxis.Y)
				{
					intervalYText += yAxisInterval;
					g.DrawString(intervalYText.ToString(), intervalTextFont, Brushes.Blue, endYAxis);
					endYAxis.Y -= yAxisIntervalInPoints;
				}
				titleFont.Dispose();

				//Manual setting of scale
				//  ...tbd...
			}
		}
	}
}
