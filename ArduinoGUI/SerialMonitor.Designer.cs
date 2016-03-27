namespace ArduinoGUI
{
    partial class SerialMonitor
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SerialTXT = new System.Windows.Forms.TextBox();
            this.consoleTXT = new System.Windows.Forms.TextBox();
            this.SendBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SerialTXT);
            this.groupBox2.Location = new System.Drawing.Point(7, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 201);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1";
            // 
            // SerialTXT
            // 
            this.SerialTXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SerialTXT.Enabled = false;
            this.SerialTXT.Location = new System.Drawing.Point(3, 16);
            this.SerialTXT.Multiline = true;
            this.SerialTXT.Name = "SerialTXT";
            this.SerialTXT.Size = new System.Drawing.Size(430, 182);
            this.SerialTXT.TabIndex = 0;
            // 
            // consoleTXT
            // 
            this.consoleTXT.Location = new System.Drawing.Point(1, 223);
            this.consoleTXT.Multiline = true;
            this.consoleTXT.Name = "consoleTXT";
            this.consoleTXT.Size = new System.Drawing.Size(364, 31);
            this.consoleTXT.TabIndex = 14;
            // 
            // SendBTN
            // 
            this.SendBTN.Location = new System.Drawing.Point(371, 223);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(66, 29);
            this.SendBTN.TabIndex = 13;
            this.SendBTN.Text = "Send";
            this.SendBTN.UseVisualStyleBackColor = true;
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SerialMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 266);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.consoleTXT);
            this.Controls.Add(this.SendBTN);
            this.Name = "SerialMonitor";
            this.Text = "SerialMonitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerialMonitor_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SerialTXT;
        private System.Windows.Forms.TextBox consoleTXT;
        private System.Windows.Forms.Button SendBTN;
        private System.Windows.Forms.Timer timer1;
    }
}