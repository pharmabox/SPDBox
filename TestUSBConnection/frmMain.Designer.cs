namespace USBCon
{
    partial class frmMain
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnSend = new System.Windows.Forms.Button();
            this.btnGetPortNames = new System.Windows.Forms.Button();
            this.lbPorts = new System.Windows.Forms.ListBox();
            this.btnComPortInfo = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM3";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(966, 570);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(216, 78);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send arduino Command";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnGetPortNames
            // 
            this.btnGetPortNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetPortNames.Location = new System.Drawing.Point(18, 485);
            this.btnGetPortNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetPortNames.Name = "btnGetPortNames";
            this.btnGetPortNames.Size = new System.Drawing.Size(216, 78);
            this.btnGetPortNames.TabIndex = 1;
            this.btnGetPortNames.Text = " GetPortNames";
            this.btnGetPortNames.UseVisualStyleBackColor = true;
            this.btnGetPortNames.Click += new System.EventHandler(this.btnGetPortNames_Click);
            // 
            // lbPorts
            // 
            this.lbPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPorts.FormattingEnabled = true;
            this.lbPorts.ItemHeight = 18;
            this.lbPorts.Location = new System.Drawing.Point(18, 53);
            this.lbPorts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPorts.Name = "lbPorts";
            this.lbPorts.Size = new System.Drawing.Size(214, 418);
            this.lbPorts.TabIndex = 2;
            // 
            // btnComPortInfo
            // 
            this.btnComPortInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnComPortInfo.Location = new System.Drawing.Point(18, 570);
            this.btnComPortInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComPortInfo.Name = "btnComPortInfo";
            this.btnComPortInfo.Size = new System.Drawing.Size(216, 78);
            this.btnComPortInfo.TabIndex = 3;
            this.btnComPortInfo.Text = "ComPortInfo";
            this.btnComPortInfo.UseVisualStyleBackColor = true;
            this.btnComPortInfo.Click += new System.EventHandler(this.btnComPortInfo_Click);
            // 
            // lbData
            // 
            this.lbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbData.FormattingEnabled = true;
            this.lbData.ItemHeight = 18;
            this.lbData.Location = new System.Drawing.Point(243, 53);
            this.lbData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(937, 508);
            this.lbData.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Coms";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1200, 665);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.btnComPortInfo);
            this.Controls.Add(this.lbPorts);
            this.Controls.Add(this.btnGetPortNames);
            this.Controls.Add(this.btnSend);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnGetPortNames;
        private System.Windows.Forms.ListBox lbPorts;
        private System.Windows.Forms.Button btnComPortInfo;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

