namespace Barcode_Keyence
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_dataport = new System.Windows.Forms.TextBox();
            this.textBox_communicationport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ipaddress4 = new System.Windows.Forms.TextBox();
            this.textBox_ipaddress3 = new System.Windows.Forms.TextBox();
            this.textBox_ipaddress2 = new System.Windows.Forms.TextBox();
            this.textBox_ipaddress1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.barcodeReaderControl1 = new Keyence.AutoID.BarcodeReaderControl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_close = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button_FolderChoose = new System.Windows.Forms.Button();
            this.button_FileChoose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ImagePath = new System.Windows.Forms.TextBox();
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox_Monitor = new System.Windows.Forms.CheckBox();
            this.radioButton_Combined = new System.Windows.Forms.RadioButton();
            this.radioButton_Individual = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_dataport);
            this.groupBox2.Controls.Add(this.textBox_communicationport);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_ipaddress4);
            this.groupBox2.Controls.Add(this.textBox_ipaddress3);
            this.groupBox2.Controls.Add(this.textBox_ipaddress2);
            this.groupBox2.Controls.Add(this.textBox_ipaddress1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(481, 103);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication Details";
            // 
            // textBox_dataport
            // 
            this.textBox_dataport.Location = new System.Drawing.Point(373, 58);
            this.textBox_dataport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_dataport.Multiline = true;
            this.textBox_dataport.Name = "textBox_dataport";
            this.textBox_dataport.Size = new System.Drawing.Size(81, 24);
            this.textBox_dataport.TabIndex = 16;
            // 
            // textBox_communicationport
            // 
            this.textBox_communicationport.Location = new System.Drawing.Point(266, 58);
            this.textBox_communicationport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_communicationport.Multiline = true;
            this.textBox_communicationport.Name = "textBox_communicationport";
            this.textBox_communicationport.Size = new System.Drawing.Size(81, 24);
            this.textBox_communicationport.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Communication and Data Port";
            // 
            // textBox_ipaddress4
            // 
            this.textBox_ipaddress4.Location = new System.Drawing.Point(164, 58);
            this.textBox_ipaddress4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_ipaddress4.Multiline = true;
            this.textBox_ipaddress4.Name = "textBox_ipaddress4";
            this.textBox_ipaddress4.Size = new System.Drawing.Size(42, 24);
            this.textBox_ipaddress4.TabIndex = 13;
            // 
            // textBox_ipaddress3
            // 
            this.textBox_ipaddress3.Location = new System.Drawing.Point(114, 58);
            this.textBox_ipaddress3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_ipaddress3.Multiline = true;
            this.textBox_ipaddress3.Name = "textBox_ipaddress3";
            this.textBox_ipaddress3.Size = new System.Drawing.Size(42, 24);
            this.textBox_ipaddress3.TabIndex = 12;
            // 
            // textBox_ipaddress2
            // 
            this.textBox_ipaddress2.Location = new System.Drawing.Point(64, 58);
            this.textBox_ipaddress2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_ipaddress2.Multiline = true;
            this.textBox_ipaddress2.Name = "textBox_ipaddress2";
            this.textBox_ipaddress2.Size = new System.Drawing.Size(42, 24);
            this.textBox_ipaddress2.TabIndex = 11;
            // 
            // textBox_ipaddress1
            // 
            this.textBox_ipaddress1.Location = new System.Drawing.Point(14, 58);
            this.textBox_ipaddress1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_ipaddress1.Multiline = true;
            this.textBox_ipaddress1.Name = "textBox_ipaddress1";
            this.textBox_ipaddress1.Size = new System.Drawing.Size(42, 24);
            this.textBox_ipaddress1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter IP Address";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_status);
            this.groupBox4.Location = new System.Drawing.Point(14, 226);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(481, 131);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
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
            // barcodeReaderControl1
            // 
            this.barcodeReaderControl1.BackColor = System.Drawing.Color.Black;
            this.barcodeReaderControl1.Location = new System.Drawing.Point(9, 17);
            this.barcodeReaderControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barcodeReaderControl1.Name = "barcodeReaderControl1";
            this.barcodeReaderControl1.Size = new System.Drawing.Size(117, 79);
            this.barcodeReaderControl1.TabIndex = 12;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_connect);
            this.groupBox1.Controls.Add(this.button_close);
            this.groupBox1.Location = new System.Drawing.Point(502, 227);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(135, 131);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.barcodeReaderControl1);
            this.groupBox3.Location = new System.Drawing.Point(503, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(135, 103);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Live View ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(15, 109);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(622, 120);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button_FolderChoose);
            this.groupBox7.Controls.Add(this.button_FileChoose);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.textBox_ImagePath);
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
            // button_FolderChoose
            // 
            this.button_FolderChoose.Location = new System.Drawing.Point(360, 51);
            this.button_FolderChoose.Name = "button_FolderChoose";
            this.button_FolderChoose.Size = new System.Drawing.Size(77, 23);
            this.button_FolderChoose.TabIndex = 13;
            this.button_FolderChoose.Text = "Browse...";
            this.button_FolderChoose.UseVisualStyleBackColor = true;
            this.button_FolderChoose.Click += new System.EventHandler(this.button_FolderChoose_Click);
            // 
            // button_FileChoose
            // 
            this.button_FileChoose.Location = new System.Drawing.Point(360, 25);
            this.button_FileChoose.Name = "button_FileChoose";
            this.button_FileChoose.Size = new System.Drawing.Size(77, 23);
            this.button_FileChoose.TabIndex = 12;
            this.button_FileChoose.Text = "Browse...";
            this.button_FileChoose.UseVisualStyleBackColor = true;
            this.button_FileChoose.Click += new System.EventHandler(this.button_FileChoose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Image Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "File Path";
            // 
            // textBox_ImagePath
            // 
            this.textBox_ImagePath.Location = new System.Drawing.Point(114, 53);
            this.textBox_ImagePath.Multiline = true;
            this.textBox_ImagePath.Name = "textBox_ImagePath";
            this.textBox_ImagePath.Size = new System.Drawing.Size(241, 20);
            this.textBox_ImagePath.TabIndex = 1;
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Location = new System.Drawing.Point(114, 27);
            this.textBox_FileName.Multiline = true;
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.Size = new System.Drawing.Size(241, 20);
            this.textBox_FileName.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox_Monitor);
            this.groupBox6.Controls.Add(this.radioButton_Combined);
            this.groupBox6.Controls.Add(this.radioButton_Individual);
            this.groupBox6.Location = new System.Drawing.Point(8, 14);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(148, 95);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Storing Type";
            // 
            // checkBox_Monitor
            // 
            this.checkBox_Monitor.AutoSize = true;
            this.checkBox_Monitor.Location = new System.Drawing.Point(40, 68);
            this.checkBox_Monitor.Name = "checkBox_Monitor";
            this.checkBox_Monitor.Size = new System.Drawing.Size(75, 20);
            this.checkBox_Monitor.TabIndex = 2;
            this.checkBox_Monitor.Text = "Day Limit";
            this.checkBox_Monitor.UseVisualStyleBackColor = true;
            // 
            // radioButton_Combined
            // 
            this.radioButton_Combined.AutoSize = true;
            this.radioButton_Combined.Location = new System.Drawing.Point(20, 46);
            this.radioButton_Combined.Name = "radioButton_Combined";
            this.radioButton_Combined.Size = new System.Drawing.Size(114, 20);
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
            this.radioButton_Individual.Size = new System.Drawing.Size(78, 20);
            this.radioButton_Individual.TabIndex = 0;
            this.radioButton_Individual.TabStop = true;
            this.radioButton_Individual.Text = "Individual";
            this.radioButton_Individual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 364);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_dataport;
        private System.Windows.Forms.TextBox textBox_communicationport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ipaddress4;
        private System.Windows.Forms.TextBox textBox_ipaddress3;
        private System.Windows.Forms.TextBox textBox_ipaddress2;
        private System.Windows.Forms.TextBox textBox_ipaddress1;
        private System.Windows.Forms.Label label1;
        private Keyence.AutoID.BarcodeReaderControl barcodeReaderControl1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ImagePath;
        private System.Windows.Forms.TextBox textBox_FileName;
        private System.Windows.Forms.RadioButton radioButton_Combined;
        private System.Windows.Forms.RadioButton radioButton_Individual;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_FolderChoose;
        private System.Windows.Forms.Button button_FileChoose;
        private System.Windows.Forms.CheckBox checkBox_Monitor;

    }
}

