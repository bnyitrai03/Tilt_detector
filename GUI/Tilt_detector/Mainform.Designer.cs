
namespace Tilt_detector
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbTiltlog = new TextBox();
            COM_settings = new GroupBox();
            bStopCOM = new Button();
            cBoxStop = new ComboBox();
            cBoxParity = new ComboBox();
            cBoxBits = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cBoxBaudRate = new ComboBox();
            label3 = new Label();
            cBoxPorts = new ComboBox();
            label2 = new Label();
            bOpenCOM = new Button();
            label1 = new Label();
            tbMaxDegree = new TextBox();
            Limit = new Label();
            label7 = new Label();
            tbTilt = new TextBox();
            groupBox1 = new GroupBox();
            tbLow = new TextBox();
            tbHigh = new TextBox();
            DisplayLow = new SevenSegmentDisplay();
            DisplayHigh = new SevenSegmentDisplay();
            COM_settings.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbTiltlog
            // 
            tbTiltlog.Location = new Point(42, 227);
            tbTiltlog.Multiline = true;
            tbTiltlog.Name = "tbTiltlog";
            tbTiltlog.ReadOnly = true;
            tbTiltlog.ScrollBars = ScrollBars.Vertical;
            tbTiltlog.Size = new Size(319, 175);
            tbTiltlog.TabIndex = 0;
            // 
            // COM_settings
            // 
            COM_settings.Controls.Add(bStopCOM);
            COM_settings.Controls.Add(cBoxStop);
            COM_settings.Controls.Add(cBoxParity);
            COM_settings.Controls.Add(cBoxBits);
            COM_settings.Controls.Add(label6);
            COM_settings.Controls.Add(label5);
            COM_settings.Controls.Add(label4);
            COM_settings.Controls.Add(cBoxBaudRate);
            COM_settings.Controls.Add(label3);
            COM_settings.Controls.Add(cBoxPorts);
            COM_settings.Controls.Add(label2);
            COM_settings.Controls.Add(bOpenCOM);
            COM_settings.Location = new Point(28, 86);
            COM_settings.Name = "COM_settings";
            COM_settings.Size = new Size(264, 355);
            COM_settings.TabIndex = 1;
            COM_settings.TabStop = false;
            COM_settings.Text = "Settings";
            // 
            // bStopCOM
            // 
            bStopCOM.Location = new Point(166, 295);
            bStopCOM.Name = "bStopCOM";
            bStopCOM.Size = new Size(75, 23);
            bStopCOM.TabIndex = 13;
            bStopCOM.Text = "Stop";
            bStopCOM.UseVisualStyleBackColor = true;
            bStopCOM.Click += bStopCOM_Click;
            // 
            // cBoxStop
            // 
            cBoxStop.FormattingEnabled = true;
            cBoxStop.Items.AddRange(new object[] { "1", "2" });
            cBoxStop.Location = new Point(105, 230);
            cBoxStop.Name = "cBoxStop";
            cBoxStop.Size = new Size(82, 23);
            cBoxStop.TabIndex = 12;
            cBoxStop.Text = "1";
            // 
            // cBoxParity
            // 
            cBoxParity.FormattingEnabled = true;
            cBoxParity.Items.AddRange(new object[] { "none ", "odd", "even" });
            cBoxParity.Location = new Point(105, 180);
            cBoxParity.Name = "cBoxParity";
            cBoxParity.Size = new Size(82, 23);
            cBoxParity.TabIndex = 11;
            cBoxParity.Text = "none ";
            // 
            // cBoxBits
            // 
            cBoxBits.FormattingEnabled = true;
            cBoxBits.Items.AddRange(new object[] { "7", "8" });
            cBoxBits.Location = new Point(105, 133);
            cBoxBits.Name = "cBoxBits";
            cBoxBits.Size = new Size(82, 23);
            cBoxBits.TabIndex = 10;
            cBoxBits.Text = "8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 230);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 9;
            label6.Text = "Stop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 180);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 8;
            label5.Text = "Parity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 133);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 7;
            label4.Text = "Bits";
            // 
            // cBoxBaudRate
            // 
            cBoxBaudRate.FormattingEnabled = true;
            cBoxBaudRate.Items.AddRange(new object[] { "9600", "14400", "19200", "38400", "57600", "115200" });
            cBoxBaudRate.Location = new Point(105, 87);
            cBoxBaudRate.Name = "cBoxBaudRate";
            cBoxBaudRate.Size = new Size(82, 23);
            cBoxBaudRate.TabIndex = 6;
            cBoxBaudRate.Text = "115200";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 87);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Baud Rate";
            // 
            // cBoxPorts
            // 
            cBoxPorts.FormattingEnabled = true;
            cBoxPorts.Location = new Point(105, 37);
            cBoxPorts.Name = "cBoxPorts";
            cBoxPorts.Size = new Size(82, 23);
            cBoxPorts.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 37);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Ports";
            // 
            // bOpenCOM
            // 
            bOpenCOM.Location = new Point(24, 295);
            bOpenCOM.Name = "bOpenCOM";
            bOpenCOM.Size = new Size(75, 23);
            bOpenCOM.TabIndex = 2;
            bOpenCOM.Text = "Start";
            bOpenCOM.UseVisualStyleBackColor = true;
            bOpenCOM.Click += bOpenCOM_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 209);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Tilt log";
            // 
            // tbMaxDegree
            // 
            tbMaxDegree.Location = new Point(82, 156);
            tbMaxDegree.Margin = new Padding(3, 2, 3, 2);
            tbMaxDegree.Name = "tbMaxDegree";
            tbMaxDegree.ReadOnly = true;
            tbMaxDegree.Size = new Size(39, 23);
            tbMaxDegree.TabIndex = 3;
            // 
            // Limit
            // 
            Limit.AutoSize = true;
            Limit.Location = new Point(42, 159);
            Limit.Name = "Limit";
            Limit.Size = new Size(34, 15);
            Limit.TabIndex = 4;
            Limit.Text = "Limit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(295, 159);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 6;
            label7.Text = "Tilt";
            // 
            // tbTilt
            // 
            tbTilt.Location = new Point(324, 156);
            tbTilt.Margin = new Padding(3, 2, 3, 2);
            tbTilt.Name = "tbTilt";
            tbTilt.ReadOnly = true;
            tbTilt.Size = new Size(37, 23);
            tbTilt.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbLow);
            groupBox1.Controls.Add(tbHigh);
            groupBox1.Controls.Add(DisplayLow);
            groupBox1.Controls.Add(DisplayHigh);
            groupBox1.Controls.Add(tbMaxDegree);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbTilt);
            groupBox1.Controls.Add(Limit);
            groupBox1.Controls.Add(tbTiltlog);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(357, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 442);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dashboard";
            // 
            // tbLow
            // 
            tbLow.Location = new Point(231, 126);
            tbLow.Name = "tbLow";
            tbLow.ReadOnly = true;
            tbLow.Size = new Size(29, 23);
            tbLow.TabIndex = 11;
            // 
            // tbHigh
            // 
            tbHigh.Location = new Point(172, 126);
            tbHigh.Name = "tbHigh";
            tbHigh.ReadOnly = true;
            tbHigh.Size = new Size(30, 23);
            tbHigh.TabIndex = 10;
            // 
            // DisplayLow
            // 
            DisplayLow.Digit = 0;
            DisplayLow.Location = new Point(208, 22);
            DisplayLow.Name = "DisplayLow";
            DisplayLow.Size = new Size(81, 108);
            DisplayLow.TabIndex = 9;
            // 
            // DisplayHigh
            // 
            DisplayHigh.Digit = 0;
            DisplayHigh.Location = new Point(135, 22);
            DisplayHigh.Name = "DisplayHigh";
            DisplayHigh.Size = new Size(81, 108);
            DisplayHigh.TabIndex = 8;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 520);
            Controls.Add(groupBox1);
            Controls.Add(COM_settings);
            Name = "Mainform";
            Text = "Tilt detector";
            COM_settings.ResumeLayout(false);
            COM_settings.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbTiltlog;
        private GroupBox COM_settings;
        private Button bOpenCOM;
        private Label label1;
        private ComboBox cBoxPorts;
        private Label label2;
        private ComboBox cBoxBaudRate;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private ComboBox cBoxParity;
        private ComboBox cBoxBits;
        private Button bStopCOM;
        private ComboBox cBoxStop;
        private TextBox tbMaxDegree;
        private Label Limit;
        private Label label7;
        private TextBox tbTilt;
        private GroupBox groupBox1;
        private SevenSegmentDisplay DisplayHigh;
        private SevenSegmentDisplay DisplayLow;
        private TextBox tbHigh;
        private TextBox tbLow;
    }
}
