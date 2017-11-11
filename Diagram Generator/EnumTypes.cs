using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram_Generator
{
	public class EnumTypes
	{
		public enum diagramPanelDrawAction
		{
			INIT,
			USERRESET,
			AUTODRAW,
			USERDRAW
		}

		public diagramPanelDrawAction GetDiagramPanelDrawAction()
		{
			return diagramPanelDrawAction.INIT;
		}

		public enum posOfOrigo
		{
			TOPLEFT,
			TOP,
			TOPRIGHT,
			LEFT,
			CENTER,
			RIGTH,
			BOTTOMLEFT,
			BOTTOM,
			BOTTOMRIGHT
		}
	}
}
