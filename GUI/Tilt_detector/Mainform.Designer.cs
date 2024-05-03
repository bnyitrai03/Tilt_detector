
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
            tbReceived = new TextBox();
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
            COM_settings.SuspendLayout();
            SuspendLayout();
            // 
            // tbReceived
            // 
            tbReceived.Location = new Point(433, 68);
            tbReceived.Multiline = true;
            tbReceived.Name = "tbReceived";
            tbReceived.Size = new Size(319, 337);
            tbReceived.TabIndex = 0;
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
            COM_settings.Location = new Point(33, 50);
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
            label1.Location = new Point(556, 50);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Received";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(COM_settings);
            Controls.Add(tbReceived);
            Name = "Mainform";
            Text = "Tilt detector";
            COM_settings.ResumeLayout(false);
            COM_settings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbReceived;
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
    }
}
