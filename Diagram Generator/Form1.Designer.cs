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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonAddNewCoord = new System.Windows.Forms.Button();
			this.textBoxNewYCoord = new System.Windows.Forms.TextBox();
			this.textBoxNewXCoord = new System.Windows.Forms.TextBox();
			this.labelNewYCoord = new System.Windows.Forms.Label();
			this.labelNewXCoord = new System.Windows.Forms.Label();
			this.listBoxCoordinates = new System.Windows.Forms.ListBox();
			this.buttonReDraw = new System.Windows.Forms.Button();
			this.labelDiagramTitle = new System.Windows.Forms.Label();
			this.textBoxDiagramTitle = new System.Windows.Forms.TextBox();
			this.labelDivY = new System.Windows.Forms.Label();
			this.textBoxStartY = new System.Windows.Forms.TextBox();
			this.textBoxStartX = new System.Windows.Forms.TextBox();
			this.labelDivX = new System.Windows.Forms.Label();
			this.labelStartValue = new System.Windows.Forms.Label();
			this.labelInterval = new System.Windows.Forms.Label();
			this.textBoxIntervalX = new System.Windows.Forms.TextBox();
			this.textBoxIntervalY = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.labelEndValue = new System.Windows.Forms.Label();
			this.textBoxEndX = new System.Windows.Forms.TextBox();
			this.textBoxEndY = new System.Windows.Forms.TextBox();
			this.checkBoxManualSettings = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxInfo = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
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
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.buttonDelete);
			this.groupBox3.Location = new System.Drawing.Point(12, 164);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(236, 86);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Modify coordinate";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(6, 19);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(110, 23);
			this.buttonDelete.TabIndex = 0;
			this.buttonDelete.Text = "Delete Coordinate";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
			// textBoxNewYCoord
			// 
			this.textBoxNewYCoord.Location = new System.Drawing.Point(116, 49);
			this.textBoxNewYCoord.Name = "textBoxNewYCoord";
			this.textBoxNewYCoord.Size = new System.Drawing.Size(100, 20);
			this.textBoxNewYCoord.TabIndex = 4;
			// 
			// textBoxNewXCoord
			// 
			this.textBoxNewXCoord.Location = new System.Drawing.Point(116, 22);
			this.textBoxNewXCoord.Name = "textBoxNewXCoord";
			this.textBoxNewXCoord.Size = new System.Drawing.Size(100, 20);
			this.textBoxNewXCoord.TabIndex = 3;
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
			// labelNewXCoord
			// 
			this.labelNewXCoord.AutoSize = true;
			this.labelNewXCoord.Location = new System.Drawing.Point(15, 25);
			this.labelNewXCoord.Name = "labelNewXCoord";
			this.labelNewXCoord.Size = new System.Drawing.Size(90, 13);
			this.labelNewXCoord.TabIndex = 1;
			this.labelNewXCoord.Text = "New x coordinate";
			// 
			// listBoxCoordinates
			// 
			this.listBoxCoordinates.FormattingEnabled = true;
			this.listBoxCoordinates.Location = new System.Drawing.Point(260, 13);
			this.listBoxCoordinates.Name = "listBoxCoordinates";
			this.listBoxCoordinates.Size = new System.Drawing.Size(120, 238);
			this.listBoxCoordinates.TabIndex = 0;
			// 
			// buttonReDraw
			// 
			this.buttonReDraw.Location = new System.Drawing.Point(299, 314);
			this.buttonReDraw.Name = "buttonReDraw";
			this.buttonReDraw.Size = new System.Drawing.Size(72, 34);
			this.buttonReDraw.TabIndex = 4;
			this.buttonReDraw.Text = "(Re)Draw Diagram";
			this.buttonReDraw.UseVisualStyleBackColor = true;
			this.buttonReDraw.Click += new System.EventHandler(this.buttonReDraw_Click);
			// 
			// labelDiagramTitle
			// 
			this.labelDiagramTitle.AutoSize = true;
			this.labelDiagramTitle.Location = new System.Drawing.Point(27, 38);
			this.labelDiagramTitle.Name = "labelDiagramTitle";
			this.labelDiagramTitle.Size = new System.Drawing.Size(65, 13);
			this.labelDiagramTitle.TabIndex = 5;
			this.labelDiagramTitle.Text = "Diagram title";
			// 
			// textBoxDiagramTitle
			// 
			this.textBoxDiagramTitle.Location = new System.Drawing.Point(103, 35);
			this.textBoxDiagramTitle.Name = "textBoxDiagramTitle";
			this.textBoxDiagramTitle.Size = new System.Drawing.Size(252, 20);
			this.textBoxDiagramTitle.TabIndex = 6;
			// 
			// labelDivY
			// 
			this.labelDivY.AutoSize = true;
			this.labelDivY.Location = new System.Drawing.Point(284, 67);
			this.labelDivY.Name = "labelDivY";
			this.labelDivY.Size = new System.Drawing.Size(33, 13);
			this.labelDivY.TabIndex = 7;
			this.labelDivY.Text = "y-axis";
			// 
			// textBoxStartY
			// 
			this.textBoxStartY.Location = new System.Drawing.Point(255, 83);
			this.textBoxStartY.Name = "textBoxStartY";
			this.textBoxStartY.Size = new System.Drawing.Size(100, 20);
			this.textBoxStartY.TabIndex = 8;
			// 
			// textBoxStartX
			// 
			this.textBoxStartX.Location = new System.Drawing.Point(103, 83);
			this.textBoxStartX.Name = "textBoxStartX";
			this.textBoxStartX.Size = new System.Drawing.Size(100, 20);
			this.textBoxStartX.TabIndex = 9;
			// 
			// labelDivX
			// 
			this.labelDivX.AutoSize = true;
			this.labelDivX.Location = new System.Drawing.Point(131, 67);
			this.labelDivX.Name = "labelDivX";
			this.labelDivX.Size = new System.Drawing.Size(33, 13);
			this.labelDivX.TabIndex = 10;
			this.labelDivX.Text = "x-axis";
			// 
			// labelStartValue
			// 
			this.labelStartValue.AutoSize = true;
			this.labelStartValue.Location = new System.Drawing.Point(34, 86);
			this.labelStartValue.Name = "labelStartValue";
			this.labelStartValue.Size = new System.Drawing.Size(58, 13);
			this.labelStartValue.TabIndex = 11;
			this.labelStartValue.Text = "Start value";
			// 
			// labelInterval
			// 
			this.labelInterval.AutoSize = true;
			this.labelInterval.Location = new System.Drawing.Point(21, 152);
			this.labelInterval.Name = "labelInterval";
			this.labelInterval.Size = new System.Drawing.Size(71, 13);
			this.labelInterval.TabIndex = 12;
			this.labelInterval.Text = "Interval value";
			// 
			// textBoxIntervalX
			// 
			this.textBoxIntervalX.Location = new System.Drawing.Point(103, 149);
			this.textBoxIntervalX.Name = "textBoxIntervalX";
			this.textBoxIntervalX.Size = new System.Drawing.Size(100, 20);
			this.textBoxIntervalX.TabIndex = 13;
			// 
			// textBoxIntervalY
			// 
			this.textBoxIntervalY.Location = new System.Drawing.Point(255, 149);
			this.textBoxIntervalY.Name = "textBoxIntervalY";
			this.textBoxIntervalY.Size = new System.Drawing.Size(100, 20);
			this.textBoxIntervalY.TabIndex = 14;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.labelEndValue);
			this.groupBox4.Controls.Add(this.textBoxEndX);
			this.groupBox4.Controls.Add(this.textBoxEndY);
			this.groupBox4.Controls.Add(this.checkBoxManualSettings);
			this.groupBox4.Controls.Add(this.textBoxIntervalY);
			this.groupBox4.Controls.Add(this.textBoxIntervalX);
			this.groupBox4.Controls.Add(this.labelInterval);
			this.groupBox4.Controls.Add(this.labelStartValue);
			this.groupBox4.Controls.Add(this.labelDivX);
			this.groupBox4.Controls.Add(this.textBoxStartX);
			this.groupBox4.Controls.Add(this.textBoxStartY);
			this.groupBox4.Controls.Add(this.labelDivY);
			this.groupBox4.Controls.Add(this.textBoxDiagramTitle);
			this.groupBox4.Controls.Add(this.labelDiagramTitle);
			this.groupBox4.Location = new System.Drawing.Point(12, 63);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(380, 222);
			this.groupBox4.TabIndex = 16;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Manual Settings";
			// 
			// labelEndValue
			// 
			this.labelEndValue.AutoSize = true;
			this.labelEndValue.Location = new System.Drawing.Point(34, 112);
			this.labelEndValue.Name = "labelEndValue";
			this.labelEndValue.Size = new System.Drawing.Size(55, 13);
			this.labelEndValue.TabIndex = 20;
			this.labelEndValue.Text = "End value";
			// 
			// textBoxEndX
			// 
			this.textBoxEndX.Location = new System.Drawing.Point(103, 109);
			this.textBoxEndX.Name = "textBoxEndX";
			this.textBoxEndX.Size = new System.Drawing.Size(100, 20);
			this.textBoxEndX.TabIndex = 19;
			// 
			// textBoxEndY
			// 
			this.textBoxEndY.Location = new System.Drawing.Point(255, 109);
			this.textBoxEndY.Name = "textBoxEndY";
			this.textBoxEndY.Size = new System.Drawing.Size(100, 20);
			this.textBoxEndY.TabIndex = 18;
			// 
			// checkBoxManualSettings
			// 
			this.checkBoxManualSettings.AutoSize = true;
			this.checkBoxManualSettings.Location = new System.Drawing.Point(103, 187);
			this.checkBoxManualSettings.Name = "checkBoxManualSettings";
			this.checkBoxManualSettings.Size = new System.Drawing.Size(121, 17);
			this.checkBoxManualSettings.TabIndex = 17;
			this.checkBoxManualSettings.Text = "Use manual settings";
			this.checkBoxManualSettings.UseVisualStyleBackColor = true;
			this.checkBoxManualSettings.CheckedChanged += new System.EventHandler(this.checkBoxManualSettings_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 48);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Delete All";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxInfo
			// 
			this.textBoxInfo.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxInfo.Enabled = false;
			this.textBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxInfo.Location = new System.Drawing.Point(12, 291);
			this.textBoxInfo.Multiline = true;
			this.textBoxInfo.Name = "textBoxInfo";
			this.textBoxInfo.Size = new System.Drawing.Size(249, 78);
			this.textBoxInfo.TabIndex = 17;
			// 
			// Diagram_Generator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1085, 704);
			this.Controls.Add(this.textBoxInfo);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.buttonReDraw);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.diagramPanel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Diagram_Generator";
			this.Text = "Diagram Generator";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
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
		private System.Windows.Forms.Label labelDiagramTitle;
		private System.Windows.Forms.TextBox textBoxDiagramTitle;
		private System.Windows.Forms.Label labelDivY;
		private System.Windows.Forms.TextBox textBoxStartY;
		private System.Windows.Forms.TextBox textBoxStartX;
		private System.Windows.Forms.Label labelDivX;
		private System.Windows.Forms.Label labelStartValue;
		private System.Windows.Forms.Label labelInterval;
		private System.Windows.Forms.TextBox textBoxIntervalX;
		private System.Windows.Forms.TextBox textBoxIntervalY;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox checkBoxManualSettings;
		private System.Windows.Forms.Label labelEndValue;
		private System.Windows.Forms.TextBox textBoxEndX;
		private System.Windows.Forms.TextBox textBoxEndY;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxInfo;
	}
}

