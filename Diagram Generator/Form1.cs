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
		private CoordinateManager coordinates;	//Manages the coordinates
		int offSetX = 50; //to not have graph at edges of panel
		int offSetY = 50; //to not have graph at edges of panel
		public Diagram_Generator()
		{
			InitializeComponent();

			//Create default paint event handler for the diagramPanel
			diagramPanel.Paint += new PaintEventHandler(diagramPanel_Paint);
			//Create a MouseDown event hhandler for the diagramPanel
			diagramPanel.MouseDown += new MouseEventHandler(diagramPanel_MouseDown);

			//Start up a new coordinateManager
			coordinates = new CoordinateManager();
			coordinates.SetList(CoordinatesGenerator.QuadrantOneTwoThreeFour()); //To start with something

			//Show the coordinates in the listbox listBoxCoordinates
			UpdatelistBoxCoordinates();
		}

		/// <summary>
		/// Refresh the data in the listbox.
		/// </summary>
		private void UpdatelistBoxCoordinates()
		{
			listBoxCoordinates.DataSource = null;
			listBoxCoordinates.DataSource = coordinates.ToStringArray();
		}

		/// <summary>
		/// Method to add a new coordinate to the data set and the graph, by clicking in the diagramPanel.
		/// https://msdn.microsoft.com/en-us/library/system.windows.forms.control.mousedown(v=vs.110).aspx
		/// https://www.daniweb.com/programming/software-development/threads/258894/identify-mouseclick-location-in-panel
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void diagramPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			var p = sender as Panel;
			if ( e.X >= offSetX &&
				 e.X <= p.Width-offSetX &&
				 e.Y >= offSetY &&
				 e.Y <= p.Height-offSetY)
			{
				Coordinate coordinate = coordinates.GetCoordinateFromPoints(e.X, p.Height - e.Y);
				string insertPoint = String.Format("Insert new coordinates at ({0},{1})", (int)coordinate.xCoord, (int)coordinate.yCoord);
				if(Utility.AskUserYesNo(insertPoint, "Add Coordinate?"))
				{
					coordinates.Add(coordinate);
					UpdatelistBoxCoordinates();
					diagramPanel.Invalidate();
				}
			}

		}

		/// <summary>
		/// Method to repaint the diagramPanel.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void diagramPanel_Paint(object sender, PaintEventArgs e)
		{
			var p = sender as Panel; //diagramPanel
			//Use below as reference when drawing
			//p.Height
			//p.Width

			var g = e.Graphics;

			//Set title
			string title = "Diagram";
			int fontSize = 32;
			Font titleFont;
			SizeF titleSize;
			if (Utility.ValidateString(textBoxDiagramTitle.Text, 1)) title = textBoxDiagramTitle.Text;
			//Do a loop to fit the title within the panels width.
			//If the title-width exeeds the panel-width, reduce the fontsize and try again.
			do
			{
				titleFont = null;
				titleFont = new Font("Verdana", fontSize);
				//Get size of the title we want to draw,
				// https://msdn.microsoft.com/en-us/library/6xe5hazb(v=vs.110).aspx
				titleSize = e.Graphics.MeasureString(title, titleFont);
				fontSize -= 2;
				if(fontSize == 2)
				{
					titleSize = e.Graphics.MeasureString(title, titleFont);
					break; //In case it is smallest possible font, just break here and print the long title
				}
			} while (titleSize.Width > p.Width);

			Point titlePoint = new Point //Get the coordinates to where we shall draw our title.
			{
				X = (p.Width / 2) - (int)(titleSize.Width / 2),
				Y = 0
			};
			g.DrawString(title, titleFont, Brushes.Blue, titlePoint);
			titleFont.Dispose();

			//If there is more than one coordinate available in the list/data set - draw
			if(coordinates.DrawDiagram())
			{
				offSetY = Utility.RoundUpToBase((int)titleSize.Height);
				float drawingAreaForX = p.Width - 2 * offSetX;
				float drawingAreaForY = p.Height - 2 * offSetY;
				Pen blackPen = new Pen(Color.Black, 3);
				PointF[] graphCoordinatesAsPoints;
				PointF origo;
				int xAxisInterval;
				int yAxisInterval;
				float xAxisIntervalInPoints;
				float yAxisIntervalInPoints;
				int intervalXText;
				int intervalYText;
				if (checkBoxManualSettings.Checked &&
				   Utility.ConvertStringToInteger(textBoxStartX.Text, out int startX) &&
				   Utility.ConvertStringToInteger(textBoxStartY.Text, out int startY) &&
				   Utility.ConvertStringToInteger(textBoxEndX.Text, out int endX) &&
				   Utility.ConvertStringToInteger(textBoxEndY.Text, out int endY) &&
				   Utility.ConvertStringToInteger(textBoxIntervalX.Text, out int intervalX) &&
				   Utility.ConvertStringToInteger(textBoxIntervalY.Text, out int intervalY))
				{ //Manual settings of scale and intervals
					//Set start and end values
					//All future calculations depend on these values
					coordinates.SetStartAndEnd(startX, startY, endX, endY);

					//Get coordinates and text for the interval markers on the x-axis
					xAxisInterval = intervalX;
					xAxisIntervalInPoints = coordinates.GetXIntervalAsPoints(drawingAreaForX, offSetX, intervalX);
					intervalXText = startX;

					//Get coordinates and text for the interval markers on the y-axis
					yAxisInterval = intervalY;
					yAxisIntervalInPoints = coordinates.GetYIntervalAsPoints(drawingAreaForY, offSetY, intervalY);
					intervalYText = startY;
				}
				else //Automatic settings of scale and intervals
				{
					//Set start and end values
					//All future calculations depend on these values
					coordinates.SetStartAndEnd();

					//Get coordinates and text for the interval markers on the x-axis
					xAxisInterval = coordinates.GetIntervalX();
					xAxisIntervalInPoints = coordinates.GetXIntervalAsPoints(drawingAreaForX, offSetX);
					intervalXText = coordinates.GetStartX();

					//Get coordinates and text for the interval markers on the y-axis
					yAxisInterval = coordinates.GetIntervalY();
					yAxisIntervalInPoints = coordinates.GetYIntervalAsPoints(drawingAreaForY, offSetY);
					intervalYText = coordinates.GetStartY();
				}

				//Get panel coordinates for graph line
				graphCoordinatesAsPoints = coordinates.GetCoordinatesAsPoints(drawingAreaForX, drawingAreaForY, offSetX, offSetY);
				
				//Draw the graph line
				g.DrawLines(blackPen, graphCoordinatesAsPoints);

				//Get panel coordinates for origo
				origo = coordinates.GetCoordinatesForOrigo(drawingAreaForX, drawingAreaForY, offSetX, offSetY);
				//Make sure coordinates of origo are not 'out of bounds'
				if (origo.X > drawingAreaForX + offSetX) origo.X = drawingAreaForX + offSetX;
				if (origo.X < offSetX) origo.X = offSetX;
				if (origo.Y > drawingAreaForY + offSetY) origo.Y = drawingAreaForY + offSetY;
				if (origo.Y < offSetY) origo.Y = offSetY;

				Font intervalTextFont = new Font("Verdana", 12);
				//Draw x-axis
				PointF startXAxis = new PointF(offSetX, origo.Y);
				PointF endXAxis = new PointF(offSetX + drawingAreaForX, origo.Y);
				g.DrawLine(blackPen, origo, startXAxis);
				g.DrawLine(blackPen, origo, endXAxis);
				//Draw the interval text for the x-axis
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
				PointF endYAxis = new PointF(origo.X, offSetY + drawingAreaForY);
				g.DrawLine(blackPen, origo, startYAxis);
				g.DrawLine(blackPen, origo, endYAxis);
				//Draw the interval text for the y-axis
				g.DrawString(intervalYText.ToString(), intervalTextFont, Brushes.Blue, endYAxis);
				endYAxis.Y -= yAxisIntervalInPoints;
				while (endYAxis.Y > startYAxis.Y)
				{
					intervalYText += yAxisInterval;
					g.DrawString(intervalYText.ToString(), intervalTextFont, Brushes.Blue, endYAxis);
					endYAxis.Y -= yAxisIntervalInPoints;
				}
			}
		}

		/// <summary>
		/// Method to export list of coordinates to XML.
		/// The outcome of the operation is presented to the use via messageboxes.
		/// </summary>
		private void ExportRecipeManagerToXml(string fileName)
		{
			try
			{
				coordinates.XMLSerialize(fileName);
				string strMessage = string.Format("Reciperegistry is saved on disk at {0}", fileName);
				Utility.DisplaySuccesfulMsgBox(strMessage);
			}
			catch (Exception e)
			{
				Utility.DisplayErrorMsgBox(e.Message);
			}
		}

		/// <summary>
		/// Method to read/deserialise a xml file specified by the user
		/// in to list of coordinates.
		/// </summary>
		private void ImportRecipeManagerFromXml(string fileName)
		{
			try
			{
				coordinates.XMLDeSerialize(fileName);
				string strMessage = string.Format("{0} is deserialized successfully! ", fileName);
				Utility.DisplaySuccesfulMsgBox(strMessage);
			}
			catch (Exception e)
			{
				Utility.DisplayErrorMsgBox(e.Message);
			}
		}

		/// <summary>
		/// Menu action to export the list of coordinate to XML.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog xmlExport = new SaveFileDialog();
			xmlExport.Filter = "XML Files|*.xml";

			//Show XML export dialog box
			if (xmlExport.ShowDialog() == DialogResult.OK)
			{
				ExportRecipeManagerToXml(xmlExport.FileName);
			}
		}

		/// <summary>
		/// Menu action to import XML-file to list of coordinates.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void importXMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog xmlImport = new OpenFileDialog();
			xmlImport.Filter = "XML Files|*.xml";

			//Show XML import/open dialog box
			if (xmlImport.ShowDialog() == DialogResult.OK)
			{
				//Maybe I could all a check on the filenema?
				ImportRecipeManagerFromXml(xmlImport.FileName);
				UpdatelistBoxCoordinates();
			}
			xmlImport.Dispose();
			diagramPanel.Invalidate();
		}

		/// <summary>
		/// Menu action to exit the application.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Utility.AskUserYesNo("Do you want to save the data to XML", "Save?"))
			{
				exportXMLToolStripMenuItem_Click(sender, e);
			}
			Application.Exit();
		}

		/// <summary>
		/// Menu item to sort the list of coordinates based on the x-coordintare (ascending)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void sortXdirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			coordinates.Sort(new Coordinate.SortByXCoord());
			UpdatelistBoxCoordinates();
		}

		/// <summary>
		/// Menu item to sort the list of coordinates based on the y-coordintare (ascending)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void sortYdirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			coordinates.Sort(new Coordinate.SortByYCoord());
			UpdatelistBoxCoordinates();
		}

		/// <summary>
		/// Button action to add new coordinate.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonAddNewCoord_Click(object sender, EventArgs e)
		{
			if(Utility.ValidateString(textBoxNewXCoord.Text) && Utility.ValidateString(textBoxNewYCoord.Text))
			{
				if(Utility.ConvertStringToFloat(textBoxNewXCoord.Text, out float newXCoord) &&
				   Utility.ConvertStringToFloat(textBoxNewYCoord.Text, out float newYCoord))
				{
					coordinates.Add(new Coordinate
					{
						xCoord = newXCoord,
						yCoord = newYCoord
					});
					UpdatelistBoxCoordinates();
				}
			}
		}

		/// <summary>
		/// Button action to redraw the graph. Useful when for example user has added a new coordinate through the
		/// button or when user has rearranged the order in the list.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonReDraw_Click(object sender, EventArgs e)
		{
			diagramPanel.Invalidate();
		}
	}
}
