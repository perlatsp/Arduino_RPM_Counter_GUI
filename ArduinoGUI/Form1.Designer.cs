namespace ArduinoGUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.AGaugeLabel aGaugeLabel1 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange2 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange3 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange4 = new System.Windows.Forms.AGaugeRange();
            this.PortNamesCMB = new System.Windows.Forms.ComboBox();
            this.BaudRatesCMB = new System.Windows.Forms.ComboBox();
            this.openBTN = new System.Windows.Forms.Button();
            this.SendBTN = new System.Windows.Forms.Button();
            this.consoleTXT = new System.Windows.Forms.TextBox();
            this.SerialMonitorBOX = new System.Windows.Forms.GroupBox();
            this.readTXT = new System.Windows.Forms.TextBox();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.Speedometer = new System.Windows.Forms.AGauge();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPlotter = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowSerialMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoPanelMENU = new System.Windows.Forms.ToolStripMenuItem();
            this.rpmTXT = new System.Windows.Forms.TextBox();
            this.InfoBOX = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.maxRPMLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rpmInfoLBL = new System.Windows.Forms.Label();
            this.conditionLBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SerialMonitorBOX.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.InfoBOX.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortNamesCMB
            // 
            this.PortNamesCMB.FormattingEnabled = true;
            this.PortNamesCMB.Location = new System.Drawing.Point(168, 44);
            this.PortNamesCMB.Name = "PortNamesCMB";
            this.PortNamesCMB.Size = new System.Drawing.Size(121, 21);
            this.PortNamesCMB.TabIndex = 2;
            this.PortNamesCMB.Text = "PortName";
            // 
            // BaudRatesCMB
            // 
            this.BaudRatesCMB.Location = new System.Drawing.Point(305, 44);
            this.BaudRatesCMB.Name = "BaudRatesCMB";
            this.BaudRatesCMB.Size = new System.Drawing.Size(121, 21);
            this.BaudRatesCMB.TabIndex = 6;
            this.BaudRatesCMB.Text = "BaudRate";
            // 
            // openBTN
            // 
            this.openBTN.Location = new System.Drawing.Point(13, 44);
            this.openBTN.Name = "openBTN";
            this.openBTN.Size = new System.Drawing.Size(93, 23);
            this.openBTN.TabIndex = 7;
            this.openBTN.Text = "Connect";
            this.openBTN.UseVisualStyleBackColor = true;
            this.openBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendBTN
            // 
            this.SendBTN.Location = new System.Drawing.Point(383, 326);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(66, 29);
            this.SendBTN.TabIndex = 9;
            this.SendBTN.Text = "Send";
            this.SendBTN.UseVisualStyleBackColor = true;
            // 
            // consoleTXT
            // 
            this.consoleTXT.Location = new System.Drawing.Point(12, 326);
            this.consoleTXT.Multiline = true;
            this.consoleTXT.Name = "consoleTXT";
            this.consoleTXT.Size = new System.Drawing.Size(364, 26);
            this.consoleTXT.TabIndex = 10;
            this.consoleTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.consoleTXT_KeyPress);
            // 
            // SerialMonitorBOX
            // 
            this.SerialMonitorBOX.Controls.Add(this.readTXT);
            this.SerialMonitorBOX.Location = new System.Drawing.Point(13, 153);
            this.SerialMonitorBOX.Name = "SerialMonitorBOX";
            this.SerialMonitorBOX.Size = new System.Drawing.Size(436, 168);
            this.SerialMonitorBOX.TabIndex = 12;
            this.SerialMonitorBOX.TabStop = false;
            this.SerialMonitorBOX.Text = "Not Connected";
            // 
            // readTXT
            // 
            this.readTXT.Enabled = false;
            this.readTXT.Location = new System.Drawing.Point(6, 19);
            this.readTXT.Multiline = true;
            this.readTXT.Name = "readTXT";
            this.readTXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readTXT.Size = new System.Drawing.Size(424, 143);
            this.readTXT.TabIndex = 0;
            // 
            // delay
            // 
            this.delay.Interval = 150;
            this.delay.Tick += new System.EventHandler(this.delay_Tick);
            // 
            // Speedometer
            // 
            this.Speedometer.BaseArcColor = System.Drawing.Color.Gray;
            this.Speedometer.BaseArcRadius = 82;
            this.Speedometer.BaseArcStart = 135;
            this.Speedometer.BaseArcSweep = 270;
            this.Speedometer.BaseArcWidth = 2;
            this.Speedometer.Center = new System.Drawing.Point(110, 110);
            aGaugeLabel1.Color = System.Drawing.SystemColors.Highlight;
            aGaugeLabel1.Name = "GaugeLabel1";
            aGaugeLabel1.Position = new System.Drawing.Point(90, 150);
            aGaugeLabel1.Text = "RPM";
            this.Speedometer.GaugeLabels.Add(aGaugeLabel1);
            aGaugeRange1.Color = System.Drawing.Color.Red;
            aGaugeRange1.EndValue = 4000F;
            aGaugeRange1.InnerRadius = 70;
            aGaugeRange1.InRange = false;
            aGaugeRange1.Name = "Danger";
            aGaugeRange1.OuterRadius = 80;
            aGaugeRange1.StartValue = 3000F;
            aGaugeRange2.Color = System.Drawing.Color.Lime;
            aGaugeRange2.EndValue = 2500F;
            aGaugeRange2.InnerRadius = 70;
            aGaugeRange2.InRange = true;
            aGaugeRange2.Name = "Good";
            aGaugeRange2.OuterRadius = 80;
            aGaugeRange2.StartValue = 501F;
            aGaugeRange3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            aGaugeRange3.EndValue = 3000F;
            aGaugeRange3.InnerRadius = 70;
            aGaugeRange3.InRange = false;
            aGaugeRange3.Name = "Warning";
            aGaugeRange3.OuterRadius = 80;
            aGaugeRange3.StartValue = 2500F;
            aGaugeRange4.Color = System.Drawing.Color.Empty;
            aGaugeRange4.EndValue = 500F;
            aGaugeRange4.InnerRadius = 1;
            aGaugeRange4.InRange = false;
            aGaugeRange4.Name = "LOW";
            aGaugeRange4.OuterRadius = 2;
            aGaugeRange4.StartValue = 0F;
            this.Speedometer.GaugeRanges.Add(aGaugeRange1);
            this.Speedometer.GaugeRanges.Add(aGaugeRange2);
            this.Speedometer.GaugeRanges.Add(aGaugeRange3);
            this.Speedometer.GaugeRanges.Add(aGaugeRange4);
            this.Speedometer.Location = new System.Drawing.Point(17, 9);
            this.Speedometer.MaxValue = 4000F;
            this.Speedometer.MinValue = 0F;
            this.Speedometer.Name = "Speedometer";
            this.Speedometer.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.Speedometer.NeedleColor2 = System.Drawing.Color.Maroon;
            this.Speedometer.NeedleRadius = 80;
            this.Speedometer.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.Speedometer.NeedleWidth = 2;
            this.Speedometer.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.Speedometer.ScaleLinesInterInnerRadius = 73;
            this.Speedometer.ScaleLinesInterOuterRadius = 80;
            this.Speedometer.ScaleLinesInterWidth = 1;
            this.Speedometer.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.Speedometer.ScaleLinesMajorInnerRadius = 70;
            this.Speedometer.ScaleLinesMajorOuterRadius = 80;
            this.Speedometer.ScaleLinesMajorStepValue = 500F;
            this.Speedometer.ScaleLinesMajorWidth = 2;
            this.Speedometer.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.Speedometer.ScaleLinesMinorInnerRadius = 75;
            this.Speedometer.ScaleLinesMinorOuterRadius = 80;
            this.Speedometer.ScaleLinesMinorTicks = 4;
            this.Speedometer.ScaleLinesMinorWidth = 1;
            this.Speedometer.ScaleNumbersColor = System.Drawing.Color.Black;
            this.Speedometer.ScaleNumbersFormat = null;
            this.Speedometer.ScaleNumbersRadius = 95;
            this.Speedometer.ScaleNumbersRotation = 0;
            this.Speedometer.ScaleNumbersStartScaleLine = 1;
            this.Speedometer.ScaleNumbersStepScaleLines = 1;
            this.Speedometer.Size = new System.Drawing.Size(227, 198);
            this.Speedometer.TabIndex = 13;
            this.Speedometer.Text = "aGauge1";
            this.Speedometer.Value = 0F;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPlotter,
            this.ShowSerialMonitor,
            this.InfoPanelMENU});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // ShowPlotter
            // 
            this.ShowPlotter.Enabled = false;
            this.ShowPlotter.Name = "ShowPlotter";
            this.ShowPlotter.Size = new System.Drawing.Size(169, 22);
            this.ShowPlotter.Text = "Serial Plotter";
            this.ShowPlotter.Click += new System.EventHandler(this.ShowPlotter_Click);
            // 
            // ShowSerialMonitor
            // 
            this.ShowSerialMonitor.Enabled = false;
            this.ShowSerialMonitor.Name = "ShowSerialMonitor";
            this.ShowSerialMonitor.Size = new System.Drawing.Size(169, 22);
            this.ShowSerialMonitor.Text = "Serial Monitor";
            this.ShowSerialMonitor.Click += new System.EventHandler(this.ShowSerialMonitor_Click);
            // 
            // InfoPanelMENU
            // 
            this.InfoPanelMENU.Name = "InfoPanelMENU";
            this.InfoPanelMENU.Size = new System.Drawing.Size(169, 22);
            this.InfoPanelMENU.Text = "Information Panel";
            this.InfoPanelMENU.Click += new System.EventHandler(this.InfoPanelMENU_Click);
            // 
            // rpmTXT
            // 
            this.rpmTXT.Enabled = false;
            this.rpmTXT.Font = new System.Drawing.Font("Digital-7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmTXT.Location = new System.Drawing.Point(82, 176);
            this.rpmTXT.Multiline = true;
            this.rpmTXT.Name = "rpmTXT";
            this.rpmTXT.Size = new System.Drawing.Size(85, 25);
            this.rpmTXT.TabIndex = 17;
            this.rpmTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InfoBOX
            // 
            this.InfoBOX.Controls.Add(this.tableLayoutPanel1);
            this.InfoBOX.Location = new System.Drawing.Point(519, 264);
            this.InfoBOX.Name = "InfoBOX";
            this.InfoBOX.Size = new System.Drawing.Size(216, 171);
            this.InfoBOX.TabIndex = 20;
            this.InfoBOX.TabStop = false;
            this.InfoBOX.Text = "Information";
            this.InfoBOX.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.maxRPMLBL, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rpmInfoLBL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.conditionLBL, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 152);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maximum RPM Achieved";
             // 
            // maxRPMLBL
            // 
            this.maxRPMLBL.AutoSize = true;
            this.maxRPMLBL.Location = new System.Drawing.Point(137, 29);
            this.maxRPMLBL.Name = "maxRPMLBL";
            this.maxRPMLBL.Size = new System.Drawing.Size(27, 13);
            this.maxRPMLBL.TabIndex = 21;
            this.maxRPMLBL.Text = "N/A"; 
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Condition";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RPM";
            // 
            // rpmInfoLBL
            // 
            this.rpmInfoLBL.AutoSize = true;
            this.rpmInfoLBL.Location = new System.Drawing.Point(137, 1);
            this.rpmInfoLBL.Name = "rpmInfoLBL";
            this.rpmInfoLBL.Size = new System.Drawing.Size(27, 13);
            this.rpmInfoLBL.TabIndex = 1;
            this.rpmInfoLBL.Text = "N/A";
            // 
            // conditionLBL
            // 
            this.conditionLBL.AutoSize = true;
            this.conditionLBL.Location = new System.Drawing.Point(137, 15);
            this.conditionLBL.Name = "conditionLBL";
            this.conditionLBL.Size = new System.Drawing.Size(27, 13);
            this.conditionLBL.TabIndex = 1;
            this.conditionLBL.Text = "N/A";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rpmTXT);
            this.panel1.Controls.Add(this.Speedometer);
            this.panel1.Location = new System.Drawing.Point(485, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 210);
            this.panel1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoBOX);
            this.Controls.Add(this.SerialMonitorBOX);
            this.Controls.Add(this.consoleTXT);
            this.Controls.Add(this.SendBTN);
            this.Controls.Add(this.openBTN);
            this.Controls.Add(this.BaudRatesCMB);
            this.Controls.Add(this.PortNamesCMB);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Zombie-o-meter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SerialMonitorBOX.ResumeLayout(false);
            this.SerialMonitorBOX.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.InfoBOX.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortNamesCMB;
        private System.Windows.Forms.ComboBox BaudRatesCMB;
        private System.Windows.Forms.Button openBTN;
        private System.Windows.Forms.Button SendBTN;
        private System.Windows.Forms.TextBox consoleTXT;
        private System.Windows.Forms.GroupBox SerialMonitorBOX;
        private System.Windows.Forms.TextBox readTXT;
        private System.Windows.Forms.Timer delay;
        private System.Windows.Forms.AGauge Speedometer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPlotter;
        private System.Windows.Forms.TextBox rpmTXT;
        private System.Windows.Forms.ToolStripMenuItem ShowSerialMonitor;
        private System.Windows.Forms.GroupBox InfoBOX;
        private System.Windows.Forms.Label conditionLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rpmInfoLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maxRPMLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem InfoPanelMENU;
        private System.Windows.Forms.Panel panel1;
    }
}

