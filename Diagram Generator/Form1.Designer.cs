namespace Diagram_Generator
{
	partial class Diagram_Generator
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.diagramPanel = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sortXdirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sortYdirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnClearDiagram = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listBoxCoordinates = new System.Windows.Forms.ListBox();
			this.labelNewXCoord = new System.Windows.Forms.Label();
			this.labelNewYCoord = new System.Windows.Forms.Label();
			this.textBoxNewXCoord = new System.Windows.Forms.TextBox();
			this.textBoxNewYCoord = new System.Windows.Forms.TextBox();
			this.buttonAddNewCoord = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buttonReDraw = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// diagramPanel
			// 
			this.diagramPanel.BackColor = System.Drawing.Color.White;
			this.diagramPanel.Location = new System.Drawing.Point(404, 63);
			this.diagramPanel.Name = "diagramPanel";
			this.diagramPanel.Size = new System.Drawing.Size(669, 569);
			this.diagramPanel.TabIndex = 0;
			this.diagramPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.diagramPanel_Paint);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1085, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportXMLToolStripMenuItem,
            this.importXMLToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exportXMLToolStripMenuItem
			// 
			this.exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
			this.exportXMLToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.exportXMLToolStripMenuItem.Text = "Export XML";
			this.exportXMLToolStripMenuItem.Click += new System.EventHandler(this.exportXMLToolStripMenuItem_Click);
			// 
			// importXMLToolStripMenuItem
			// 
			this.importXMLToolStripMenuItem.Name = "importXMLToolStripMenuItem";
			this.importXMLToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.importXMLToolStripMenuItem.Text = "Import XML";
			this.importXMLToolStripMenuItem.Click += new System.EventHandler(this.importXMLToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// dataToolStripMenuItem
			// 
			this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortXdirToolStripMenuItem,
            this.sortYdirToolStripMenuItem});
			this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
			this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.dataToolStripMenuItem.Text = "Data";
			// 
			// sortXdirToolStripMenuItem
			// 
			this.sortXdirToolStripMenuItem.Name = "sortXdirToolStripMenuItem";
			this.sortXdirToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.sortXdirToolStripMenuItem.Text = "Sort x-dir";
			this.sortXdirToolStripMenuItem.Click += new System.EventHandler(this.sortXdirToolStripMenuItem_Click);
			// 
			// sortYdirToolStripMenuItem
			// 
			this.sortYdirToolStripMenuItem.Name = "sortYdirToolStripMenuItem";
			this.sortYdirToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.sortYdirToolStripMenuItem.Text = "Sort y-dir";
			this.sortYdirToolStripMenuItem.Click += new System.EventHandler(this.sortYdirToolStripMenuItem_Click);
			// 
			// btnClearDiagram
			// 
			this.btnClearDiagram.Location = new System.Drawing.Point(884, 658);
			this.btnClearDiagram.Name = "btnClearDiagram";
			this.btnClearDiagram.Size = new System.Drawing.Size(189, 34);
			this.btnClearDiagram.TabIndex = 2;
			this.btnClearDiagram.Text = "Clear Diagram";
			this.btnClearDiagram.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.listBoxCoordinates);
			this.groupBox1.Location = new System.Drawing.Point(12, 375);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(386, 257);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Coordinates";
			// 
			// listBoxCoordinates
			// 
			this.listBoxCoordinates.FormattingEnabled = true;
			this.listBoxCoordinates.Location = new System.Drawing.Point(260, 13);
			this.listBoxCoordinates.Name = "listBoxCoordinates";
			this.listBoxCoordinates.Size = new System.Drawing.Size(120, 238);
			this.listBoxCoordinates.TabIndex = 0;
			// 
			// labelNewXCoord
			// 
			this.labelNewXCoord.AutoSize = true;
			this.labelNewXCoord.Location = new System.Drawing.Point(15, 25);
			this.labelNewXCoord.Name = "labelNewXCoord";
			this.labelNewXCoord.Size = new System.Drawing.Size(90, 13);
			this.labelNewXCoord.TabIndex = 1;
			this.labelNewXCoord.Text = "New x coordinate";
			// 
			// labelNewYCoord
			// 
			this.labelNewYCoord.AutoSize = true;
			this.labelNewYCoord.Location = new System.Drawing.Point(15, 52);
			this.labelNewYCoord.Name = "labelNewYCoord";
			this.labelNewYCoord.Size = new System.Drawing.Size(90, 13);
			this.labelNewYCoord.TabIndex = 2;
			this.labelNewYCoord.Text = "New y coordinate";
			// 
			// textBoxNewXCoord
			// 
			this.textBoxNewXCoord.Location = new System.Drawing.Point(116, 22);
			this.textBoxNewXCoord.Name = "textBoxNewXCoord";
			this.textBoxNewXCoord.Size = new System.Drawing.Size(100, 20);
			this.textBoxNewXCoord.TabIndex = 3;
			// 
			// textBoxNewYCoord
			// 
			this.textBoxNewYCoord.Location = new System.Drawing.Point(116, 49);
			this.textBoxNewYCoord.Name = "textBoxNewYCoord";
			this.textBoxNewYCoord.Size = new System.Drawing.Size(100, 20);
			this.textBoxNewYCoord.TabIndex = 4;
			// 
			// buttonAddNewCoord
			// 
			this.buttonAddNewCoord.Location = new System.Drawing.Point(18, 75);
			this.buttonAddNewCoord.Name = "buttonAddNewCoord";
			this.buttonAddNewCoord.Size = new System.Drawing.Size(198, 34);
			this.buttonAddNewCoord.TabIndex = 5;
			this.buttonAddNewCoord.Text = "Add new coordinate";
			this.buttonAddNewCoord.UseVisualStyleBackColor = true;
			this.buttonAddNewCoord.Click += new System.EventHandler(this.buttonAddNewCoord_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonAddNewCoord);
			this.groupBox2.Controls.Add(this.textBoxNewYCoord);
			this.groupBox2.Controls.Add(this.textBoxNewXCoord);
			this.groupBox2.Controls.Add(this.labelNewYCoord);
			this.groupBox2.Controls.Add(this.labelNewXCoord);
			this.groupBox2.Location = new System.Drawing.Point(12, 33);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(237, 125);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add new coordinate";
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(12, 164);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(236, 86);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Modify coordinate";
			// 
			// buttonReDraw
			// 
			this.buttonReDraw.Location = new System.Drawing.Point(404, 658);
			this.buttonReDraw.Name = "buttonReDraw";
			this.buttonReDraw.Size = new System.Drawing.Size(189, 34);
			this.buttonReDraw.TabIndex = 4;
			this.buttonReDraw.Text = "ReDraw Diagram";
			this.buttonReDraw.UseVisualStyleBackColor = true;
			this.buttonReDraw.Click += new System.EventHandler(this.buttonReDraw_Click);
			// 
			// Diagram_Generator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1085, 704);
			this.Controls.Add(this.buttonReDraw);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnClearDiagram);
			this.Controls.Add(this.diagramPanel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Diagram_Generator";
			this.Text = "Diagram Generator";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel diagramPanel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortXdirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortYdirToolStripMenuItem;
		private System.Windows.Forms.Button btnClearDiagram;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBoxCoordinates;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button buttonAddNewCoord;
		private System.Windows.Forms.TextBox textBoxNewYCoord;
		private System.Windows.Forms.TextBox textBoxNewXCoord;
		private System.Windows.Forms.Label labelNewYCoord;
		private System.Windows.Forms.Label labelNewXCoord;
		private System.Windows.Forms.Button buttonReDraw;
	}
}

