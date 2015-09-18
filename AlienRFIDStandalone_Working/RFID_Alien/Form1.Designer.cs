namespace RFID_Alien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_IPAddress3 = new System.Windows.Forms.TextBox();
            this.textBox_IPAddress1 = new System.Windows.Forms.TextBox();
            this.textBox_IPAddress2 = new System.Windows.Forms.TextBox();
            this.textBox_IPAddress4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox_Devices = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ListeningPort = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button_FileChoose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBox_Monitor = new System.Windows.Forms.CheckBox();
            this.radioButton_Combined = new System.Windows.Forms.RadioButton();
            this.radioButton_Individual = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_IPAddress3);
            this.groupBox5.Controls.Add(this.textBox_IPAddress1);
            this.groupBox5.Controls.Add(this.textBox_IPAddress2);
            this.groupBox5.Controls.Add(this.textBox_IPAddress4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBox_Port);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(409, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 107);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reader Details";
            // 
            // textBox_IPAddress3
            // 
            this.textBox_IPAddress3.Enabled = false;
            this.textBox_IPAddress3.Location = new System.Drawing.Point(112, 47);
            this.textBox_IPAddress3.Multiline = true;
            this.textBox_IPAddress3.Name = "textBox_IPAddress3";
            this.textBox_IPAddress3.Size = new System.Drawing.Size(36, 20);
            this.textBox_IPAddress3.TabIndex = 5;
            // 
            // textBox_IPAddress1
            // 
            this.textBox_IPAddress1.Enabled = false;
            this.textBox_IPAddress1.Location = new System.Drawing.Point(112, 21);
            this.textBox_IPAddress1.Multiline = true;
            this.textBox_IPAddress1.Name = "textBox_IPAddress1";
            this.textBox_IPAddress1.Size = new System.Drawing.Size(36, 20);
            this.textBox_IPAddress1.TabIndex = 3;
            // 
            // textBox_IPAddress2
            // 
            this.textBox_IPAddress2.Enabled = false;
            this.textBox_IPAddress2.Location = new System.Drawing.Point(153, 21);
            this.textBox_IPAddress2.Multiline = true;
            this.textBox_IPAddress2.Name = "textBox_IPAddress2";
            this.textBox_IPAddress2.Size = new System.Drawing.Size(36, 20);
            this.textBox_IPAddress2.TabIndex = 4;
            // 
            // textBox_IPAddress4
            // 
            this.textBox_IPAddress4.Enabled = false;
            this.textBox_IPAddress4.Location = new System.Drawing.Point(154, 47);
            this.textBox_IPAddress4.Multiline = true;
            this.textBox_IPAddress4.Name = "textBox_IPAddress4";
            this.textBox_IPAddress4.Size = new System.Drawing.Size(36, 20);
            this.textBox_IPAddress4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Port";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Enabled = false;
            this.textBox_Port.Location = new System.Drawing.Point(112, 72);
            this.textBox_Port.Multiline = true;
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(77, 20);
            this.textBox_Port.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP Address";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox_Devices);
            this.groupBox4.Location = new System.Drawing.Point(219, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 107);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Readers List";
            // 
            // listBox_Devices
            // 
            this.listBox_Devices.FormattingEnabled = true;
            this.listBox_Devices.Location = new System.Drawing.Point(7, 16);
            this.listBox_Devices.Name = "listBox_Devices";
            this.listBox_Devices.Size = new System.Drawing.Size(170, 82);
            this.listBox_Devices.TabIndex = 0;
            this.listBox_Devices.SelectedIndexChanged += new System.EventHandler(this.listBox_Devices_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Stop);
            this.groupBox2.Controls.Add(this.button_Start);
            this.groupBox2.Location = new System.Drawing.Point(6, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 40);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(110, 11);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(96, 23);
            this.button_Stop.TabIndex = 1;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(7, 11);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(96, 23);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox_ListeningPort);
            this.groupBox3.Location = new System.Drawing.Point(6, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listening Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listening Port";
            // 
            // textBox_ListeningPort
            // 
            this.textBox_ListeningPort.Location = new System.Drawing.Point(108, 27);
            this.textBox_ListeningPort.Multiline = true;
            this.textBox_ListeningPort.Name = "textBox_ListeningPort";
            this.textBox_ListeningPort.Size = new System.Drawing.Size(76, 20);
            this.textBox_ListeningPort.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Location = new System.Drawing.Point(10, 131);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(622, 120);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button_FileChoose);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.textBox_FileName);
            this.groupBox7.Location = new System.Drawing.Point(164, 14);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(447, 95);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "File Paths";
            // 
            // button_FileChoose
            // 
            this.button_FileChoose.Location = new System.Drawing.Point(356, 39);
            this.button_FileChoose.Name = "button_FileChoose";
            this.button_FileChoose.Size = new System.Drawing.Size(77, 23);
            this.button_FileChoose.TabIndex = 12;
            this.button_FileChoose.Text = "Browse...";
            this.button_FileChoose.UseVisualStyleBackColor = true;
            this.button_FileChoose.Click += new System.EventHandler(this.button_FileChoose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "File Path";
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Location = new System.Drawing.Point(110, 41);
            this.textBox_FileName.Multiline = true;
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.Size = new System.Drawing.Size(241, 20);
            this.textBox_FileName.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBox_Monitor);
            this.groupBox8.Controls.Add(this.radioButton_Combined);
            this.groupBox8.Controls.Add(this.radioButton_Individual);
            this.groupBox8.Location = new System.Drawing.Point(8, 14);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Size = new System.Drawing.Size(148, 95);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Storing Type";
            // 
            // checkBox_Monitor
            // 
            this.checkBox_Monitor.AutoSize = true;
            this.checkBox_Monitor.Location = new System.Drawing.Point(40, 68);
            this.checkBox_Monitor.Name = "checkBox_Monitor";
            this.checkBox_Monitor.Size = new System.Drawing.Size(61, 17);
            this.checkBox_Monitor.TabIndex = 2;
            this.checkBox_Monitor.Text = "Monitor";
            this.checkBox_Monitor.UseVisualStyleBackColor = true;
            // 
            // radioButton_Combined
            // 
            this.radioButton_Combined.AutoSize = true;
            this.radioButton_Combined.Location = new System.Drawing.Point(20, 46);
            this.radioButton_Combined.Name = "radioButton_Combined";
            this.radioButton_Combined.Size = new System.Drawing.Size(104, 17);
            this.radioButton_Combined.TabIndex = 1;
            this.radioButton_Combined.TabStop = true;
            this.radioButton_Combined.Text = "Append to Same";
            this.radioButton_Combined.UseVisualStyleBackColor = true;
            this.radioButton_Combined.CheckedChanged += new System.EventHandler(this.radioButton_Combined_CheckedChanged);
            // 
            // radioButton_Individual
            // 
            this.radioButton_Individual.AutoSize = true;
            this.radioButton_Individual.Location = new System.Drawing.Point(19, 21);
            this.radioButton_Individual.Name = "radioButton_Individual";
            this.radioButton_Individual.Size = new System.Drawing.Size(70, 17);
            this.radioButton_Individual.TabIndex = 0;
            this.radioButton_Individual.TabStop = true;
            this.radioButton_Individual.Text = "Individual";
            this.radioButton_Individual.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox_status);
            this.groupBox10.Location = new System.Drawing.Point(9, 251);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Size = new System.Drawing.Size(481, 131);
            this.groupBox10.TabIndex = 18;
            this.groupBox10.TabStop = false;
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(9, 20);
            this.textBox_status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_status.Multiline = true;
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(464, 99);
            this.textBox_status.TabIndex = 0;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(12, 17);
            this.button_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(112, 49);
            this.button_connect.TabIndex = 13;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(12, 71);
            this.button_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(112, 49);
            this.button_close.TabIndex = 14;
            this.button_close.Text = "Disconnect";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button_connect);
            this.groupBox9.Controls.Add(this.button_close);
            this.groupBox9.Location = new System.Drawing.Point(497, 251);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Size = new System.Drawing.Size(135, 131);
            this.groupBox9.TabIndex = 19;
            this.groupBox9.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 389);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ListeningPort;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_FileChoose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_FileName;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox checkBox_Monitor;
        private System.Windows.Forms.RadioButton radioButton_Combined;
        private System.Windows.Forms.RadioButton radioButton_Individual;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.ListBox listBox_Devices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_IPAddress4;
        private System.Windows.Forms.TextBox textBox_IPAddress3;
        private System.Windows.Forms.TextBox textBox_IPAddress2;
        private System.Windows.Forms.TextBox textBox_IPAddress1;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Timer timer1;

    }
}

