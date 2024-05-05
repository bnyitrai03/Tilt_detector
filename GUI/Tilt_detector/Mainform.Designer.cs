
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
            tbDegree = new TextBox();
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
            tb7seg = new TextBox();
            label7 = new Label();
            COM_settings.SuspendLayout();
            SuspendLayout();
            // 
            // tbDegree
            // 
            tbDegree.Location = new Point(495, 307);
            tbDegree.Margin = new Padding(3, 4, 3, 4);
            tbDegree.Multiline = true;
            tbDegree.Name = "tbDegree";
            tbDegree.ReadOnly = true;
            tbDegree.ScrollBars = ScrollBars.Vertical;
            tbDegree.Size = new Size(364, 232);
            tbDegree.TabIndex = 0;
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
            COM_settings.Location = new Point(38, 67);
            COM_settings.Margin = new Padding(3, 4, 3, 4);
            COM_settings.Name = "COM_settings";
            COM_settings.Padding = new Padding(3, 4, 3, 4);
            COM_settings.Size = new Size(302, 473);
            COM_settings.TabIndex = 1;
            COM_settings.TabStop = false;
            COM_settings.Text = "Settings";
            // 
            // bStopCOM
            // 
            bStopCOM.Location = new Point(190, 393);
            bStopCOM.Margin = new Padding(3, 4, 3, 4);
            bStopCOM.Name = "bStopCOM";
            bStopCOM.Size = new Size(86, 31);
            bStopCOM.TabIndex = 13;
            bStopCOM.Text = "Stop";
            bStopCOM.UseVisualStyleBackColor = true;
            bStopCOM.Click += bStopCOM_Click;
            // 
            // cBoxStop
            // 
            cBoxStop.FormattingEnabled = true;
            cBoxStop.Items.AddRange(new object[] { "1", "2" });
            cBoxStop.Location = new Point(120, 307);
            cBoxStop.Margin = new Padding(3, 4, 3, 4);
            cBoxStop.Name = "cBoxStop";
            cBoxStop.Size = new Size(93, 28);
            cBoxStop.TabIndex = 12;
            cBoxStop.Text = "1";
            // 
            // cBoxParity
            // 
            cBoxParity.FormattingEnabled = true;
            cBoxParity.Items.AddRange(new object[] { "none ", "odd", "even" });
            cBoxParity.Location = new Point(120, 240);
            cBoxParity.Margin = new Padding(3, 4, 3, 4);
            cBoxParity.Name = "cBoxParity";
            cBoxParity.Size = new Size(93, 28);
            cBoxParity.TabIndex = 11;
            cBoxParity.Text = "none ";
            // 
            // cBoxBits
            // 
            cBoxBits.FormattingEnabled = true;
            cBoxBits.Items.AddRange(new object[] { "7", "8" });
            cBoxBits.Location = new Point(120, 177);
            cBoxBits.Margin = new Padding(3, 4, 3, 4);
            cBoxBits.Name = "cBoxBits";
            cBoxBits.Size = new Size(93, 28);
            cBoxBits.TabIndex = 10;
            cBoxBits.Text = "8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 307);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 9;
            label6.Text = "Stop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 240);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 8;
            label5.Text = "Parity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 177);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 7;
            label4.Text = "Bits";
            // 
            // cBoxBaudRate
            // 
            cBoxBaudRate.FormattingEnabled = true;
            cBoxBaudRate.Items.AddRange(new object[] { "9600", "14400", "19200", "38400", "57600", "115200" });
            cBoxBaudRate.Location = new Point(120, 116);
            cBoxBaudRate.Margin = new Padding(3, 4, 3, 4);
            cBoxBaudRate.Name = "cBoxBaudRate";
            cBoxBaudRate.Size = new Size(93, 28);
            cBoxBaudRate.TabIndex = 6;
            cBoxBaudRate.Text = "115200";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 116);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 5;
            label3.Text = "Baud Rate";
            // 
            // cBoxPorts
            // 
            cBoxPorts.FormattingEnabled = true;
            cBoxPorts.Location = new Point(120, 49);
            cBoxPorts.Margin = new Padding(3, 4, 3, 4);
            cBoxPorts.Name = "cBoxPorts";
            cBoxPorts.Size = new Size(93, 28);
            cBoxPorts.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 49);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Ports";
            // 
            // bOpenCOM
            // 
            bOpenCOM.Location = new Point(27, 393);
            bOpenCOM.Margin = new Padding(3, 4, 3, 4);
            bOpenCOM.Name = "bOpenCOM";
            bOpenCOM.Size = new Size(86, 31);
            bOpenCOM.TabIndex = 2;
            bOpenCOM.Text = "Start";
            bOpenCOM.UseVisualStyleBackColor = true;
            bOpenCOM.Click += bOpenCOM_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(499, 283);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "Degree";
            // 
            // tbMaxDegree
            // 
            tbMaxDegree.Location = new Point(597, 216);
            tbMaxDegree.Name = "tbMaxDegree";
            tbMaxDegree.ReadOnly = true;
            tbMaxDegree.Size = new Size(48, 27);
            tbMaxDegree.TabIndex = 3;
            // 
            // Limit
            // 
            Limit.AutoSize = true;
            Limit.Location = new Point(495, 216);
            Limit.Name = "Limit";
            Limit.Size = new Size(62, 20);
            Limit.TabIndex = 4;
            Limit.Text = "Max Tilt";
            // 
            // tb7seg
            // 
            tb7seg.Font = new Font("DSEG7 Modern", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb7seg.ForeColor = SystemColors.Window;
            tb7seg.Location = new Point(585, 85);
            tb7seg.Name = "tb7seg";
            tb7seg.ReadOnly = true;
            tb7seg.Size = new Size(157, 73);
            tb7seg.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(495, 107);
            label7.Name = "label7";
            label7.Size = new Size(30, 20);
            label7.TabIndex = 6;
            label7.Text = "Tilt";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label7);
            Controls.Add(tb7seg);
            Controls.Add(Limit);
            Controls.Add(tbMaxDegree);
            Controls.Add(label1);
            Controls.Add(COM_settings);
            Controls.Add(tbDegree);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Mainform";
            Text = "Tilt detector";
            COM_settings.ResumeLayout(false);
            COM_settings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDegree;
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
        private TextBox tb7seg;
        private Label label7;
    }
}
