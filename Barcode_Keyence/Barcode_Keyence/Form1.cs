using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Keyence.AutoID;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Threading;

namespace Barcode_Keyence
{
    public partial class Form1 : Form
    {
        //Integer variable to store command port
        private int commandport;
        //Integer variable to store data port
        private int dataport;
        //StreamWriter variable to write data into file 
        private StreamWriter streamWriter = null;
        //StreamWriter variable to write log into log file
        private StreamWriter streamLogWriter = null;
        //String Variable to hold the file name and path where it will be stored
        private string filePath = string.Empty;
        //String variable to hold the location of the images store
        private string folderPath=string.Empty;
        //String variable to hold the file name and path choosen using FileDialog
        private string fileName=string.Empty;
        //String variable to hold the newly generated file name
        private string fileNameNew = string.Empty;
        //String variable to hold the location of image stored inside RAM
        private string imageString = string.Empty;
        //String variable to hold the new location of the image in local drives
        private string destinationString = string.Empty;
        //Boolean variable to hold the status whether the file name is choosen by the user to write data
        private bool fileStatus = false;
        //Boolean variable to hold the status whether the folder is choosen by the user to store images
        private bool folderStatus = false;
        //Timer variable to perform Day Timit Limit requirement
        private System.Threading.Timer myTimer;
        
        /// <summary>
        /// A default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method to create a StreamWriter object to write barcode data
        /// </summary>
        /// <param name="filePath">Location of the file</param>
        /// <returns></returns>
        private StreamWriter getWriter(string filePath)
        {
            //Checks whether object is null
            if (streamWriter == null)
            {
                streamWriter = new StreamWriter(filePath,true);
            }
            //Checks whether writer is closed
            if (streamWriter.BaseStream == null)
            {
                streamWriter = null;
                streamWriter = new StreamWriter(filePath, true);
            }
            return streamWriter;
        }
        /// <summary>
        /// Method to create a StreamWriter object to write log data
        /// </summary>
        /// <param name="filePath">Location of the file</param>
        /// <returns></returns>
        private StreamWriter getLogWriter(string filePath)
        {
            //Checks whether object is null
            if (streamLogWriter == null)
            {
                streamLogWriter = new StreamWriter(filePath, true);
            }
            //Checks whether writer is closed
            if (streamLogWriter.BaseStream == null)
            {
                streamLogWriter = null;
                streamLogWriter = new StreamWriter(filePath, true);
            }
            return streamLogWriter;
        }
        /// <summary>
        /// Method to write logs into log file
        /// </summary>
        /// <param name="status">Log Details</param>
        private void WriteLog(string status)
        {
            getLogWriter("log.log").WriteLine(status);
            getLogWriter("log.log").Flush();
        }
        private void CloseLog()
        {
            getLogWriter("log.log").Close();
        }
        /// <summary>
        /// Method to write data into data file
        /// </summary>
        /// <param name="data">Barcode Data</param>
        /// <param name="date">Date Time with TimeZone</param>
        private void WriteData(string data,string date)
        {
            getWriter(filePath).WriteLine(string.Format("{0},{1}", data, date));
            getWriter(filePath).Flush();
        }
        /// <summary>
        /// Method to close file writer
        /// </summary>
        private void CloseData()
        {
            getWriter(filePath).Close();
        }
        /// <summary>
        /// Method to execute when on focus listener triggered
        /// </summary>
        /// <param name="Sender">Textbox Object</param>
        /// <param name="e">Event Arguments</param>
        private void OnFocusCommunicationPort(object Sender,EventArgs e)
        {
            textBox_communicationport.Text = "";
        }
        /// <summary>
        /// Method to execute when lost focus listener triggered
        /// </summary>
        /// <param name="Sender">Textbox Object</param>
        /// <param name="e">Event Arguments</param>
        private void OnLostFocusCommunicationPort(object Sender, EventArgs e)
        {
            if (textBox_communicationport.Text.Equals(""))
            {
                textBox_communicationport.Text = "9003";
            }
        }
        /// <summary>
        /// Method to execute when on focus listener triggered
        /// </summary>
        /// <param name="Sender">Textbox Object</param>
        /// <param name="e">Event Arguments</param>
        private void OnFocusDataPort(object Sender, EventArgs e)
        {
            textBox_dataport.Text = "";
        }
        /// <summary>
        /// Method to execute when lost focus listener triggered
        /// </summary>
        /// <param name="Sender">Textbox Object</param>
        /// <param name="e">Event Arguments</param>
        private void OnLostFocusDataPort(object Sender, EventArgs e)
        {
            if (textBox_dataport.Text.Equals(""))
            {
                textBox_dataport.Text = "9004";
            }
        }
        /// <summary>
        /// Method to execute when on focus listener triggered
        /// </summary>
        /// <param name="Sender">Textbox Object</param>
        /// <param name="e">Event Arguments</param>
        private void OnFocusIPAddress1(object Sender, EventArgs e)
        {
            textBox_ipaddress1.Text = "";
        }
        /// <summary>
        /// Method to execute when lost focus listener triggered
        /// </summary>
        /// <param name="Sender">Textbox Object</param>
        /// <param name="e">Event Arguments</param>
        private void OnLostFocusIPAddress1(object Sender, EventArgs e)
        {
            if (textBox_ipaddress1.Text.Equals(""))
            {
                textBox_ipaddress1.Text = "192";
            }
            else if (Convert.ToInt32(textBox_ipaddress1.Text) > 255)
            {
                textBox_ipaddress1.Text = "192";
            }
        }
        /// <summary>
        /// Method to execute when on focus listener triggered
        /// </summary>
        /// <param name="Sender">Textbox Object</param>
        /// <param name="e">Event Arguments</param>
        private void OnFocusIPAddress2(object Sender, EventArgs e)
        {
            textBox_ipaddress2.Text = "";
        }
        /// <summary>
        /// Method to execute when lost focus listener triggered
        /// </summary>
        /// <param name="Sender">Textbox Object</param>
        /// <param name="e">Event Arguments</param>
        private void OnLostFocusIPAddress2(object Sender, EventArgs e)
        {
            if (textBox_ipaddress2.Text.Equals(""))
            {
                textBox_ipaddress2.Text = "168";
            }
            else if (Convert.ToInt32(textBox_ipaddress2.Text) > 255)
            {
                textBox_ipaddress2.Text = "168";
            }
        }
        /// <summary>
        /// Method to execute when on focus listener triggered
        /// </summary>
        /// <param name="Sender">Textbox Object</param>
        /// <param name="e">Event Arguments</param>
        private void OnFocusIPAddress3(object Sender, EventArgs e)
        {
            textBox_ipaddress3.Text = "";
        }
        /// <summary>
        /// Method to execute when lost focus listener triggered
        /// </summary>
        /// <param name="Sender">Textbox Object</param>
        /// <param name="e">Event Arguments</param>
        private void OnLostFocusIPAddress3(object Sender, EventArgs e)
        {
            if (textBox_ipaddress3.Text.Equals(""))
            {
                textBox_ipaddress3.Text = "1";
            }
            else if (Convert.ToInt32(textBox_ipaddress3.Text) > 255)
            {
                textBox_ipaddress3.Text = "1";
            }
        }
        /// <summary>
        /// Method to execute when on focus listener triggered
        /// </summary>
        /// <param name="Sender">Textbox Object</param>
        /// <param name="e">Event Arguments</param>
        private void OnFocusIPAddress4(object Sender, EventArgs e)
        {
            textBox_ipaddress4.Text = "";
        }
        /// <summary>
        /// Method to execute when lost focus listener triggered
        /// </summary>
        /// <param name="Sender">Textbox Object</param>
        /// <param name="e">Event Arguments</param>
        private void OnLostFocusIPAddress4(object Sender, EventArgs e)
        {
            if (textBox_ipaddress4.Text.Equals(""))
            {
                textBox_ipaddress4.Text = "1";
            }
            else if(Convert.ToInt32(textBox_ipaddress4.Text)>255)
            {
                textBox_ipaddress4.Text = "1";
            }
        }
        /// <summary>
        /// This is the method to initialize controls when form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_ipaddress1.Text = "192";
            textBox_ipaddress2.Text = "168";
            textBox_ipaddress3.Text = "1";
            textBox_ipaddress4.Text = "1";
            textBox_communicationport.Text = "9003";
            textBox_dataport.Text = "9004";
            checkBox_Monitor.Enabled = false;
            textBox_communicationport.GotFocus += OnFocusCommunicationPort;
            textBox_communicationport.LostFocus += OnLostFocusCommunicationPort;
            textBox_dataport.GotFocus += OnFocusDataPort;
            textBox_dataport.LostFocus += OnLostFocusDataPort;
            textBox_ipaddress1.GotFocus += OnFocusIPAddress1;
            textBox_ipaddress1.LostFocus += OnLostFocusIPAddress1;
            textBox_ipaddress2.GotFocus += OnFocusIPAddress2;
            textBox_ipaddress2.LostFocus += OnLostFocusIPAddress2;
            textBox_ipaddress3.GotFocus += OnFocusIPAddress3;
            textBox_ipaddress3.LostFocus += OnLostFocusIPAddress3;
            textBox_ipaddress4.GotFocus += OnFocusIPAddress4;
            textBox_ipaddress4.LostFocus += OnLostFocusIPAddress4;
            button_connect.Enabled = false;
            button_close.Enabled = false;
        }
        private void Connect()
        {
            try
            {
                if (checkBox_Monitor.Checked)
                {
                    SetTimerValue();
                    WriteLog("Date Time Monitor Started..." + "   at " + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                    textBox_status.AppendText("Date Time Monitor Started...\n");
                }
                Byte[] ipaddress = new byte[4];
                ipaddress[0] = Convert.ToByte(textBox_ipaddress1.Text.Trim());
                ipaddress[1] = Convert.ToByte(textBox_ipaddress2.Text.Trim());
                ipaddress[2] = Convert.ToByte(textBox_ipaddress3.Text.Trim());
                ipaddress[3] = Convert.ToByte(textBox_ipaddress4.Text.Trim());
                commandport = Convert.ToInt32(textBox_communicationport.Text.Trim());
                dataport = Convert.ToInt32(textBox_dataport.Text.Trim());
                IPAddress ip = new IPAddress(ipaddress);
                //Sets the ipaddress to the barcode reader control component
                this.barcodeReaderControl1.IpAddress = ip.ToString();
                //Sets the command port to the barcode reader control component
                this.barcodeReaderControl1.Ether.CommandPort = commandport;
                //Sets the data port to the barcode reader control component
                this.barcodeReaderControl1.Ether.DataPort = dataport;
                //Sets ethernet as interface to the barcode reader control component
                this.barcodeReaderControl1.Comm.Interface = Interface.Ethernet;
                //Sets the reader type to the barcode reader control component 
                this.barcodeReaderControl1.ReaderType = ReaderType.SR_1000;
                textBox_status.AppendText("Socket Connecting...\n");
                //Connecting to the barcode reader
                this.barcodeReaderControl1.Connect();
                textBox_status.AppendText("Socket Connected...\n");
                //Creating event listener when barcode reader sends data and when control component receives
                this.barcodeReaderControl1.OnDataReceived += dataReceived;
                textBox_status.AppendText("Live View Starting...\n");
                //Calling function of barcode reader control component to show live view of the reader readings
                this.barcodeReaderControl1.StartLiveView();
                textBox_status.AppendText("Live View Started...\n");
                button_connect.Enabled = false;
                button_close.Enabled = true;
            }
            catch (SocketException ex)
            {
                WriteLog(ex.ToString() + Environment.NewLine + "   at " + DateTime.Now.ToString("yyyyMMddHHmmssfff")+"Tz"+convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString())+"\n");
                textBox_status.AppendText("Socket Exception Occured. Please refer log file." + "\n");
                button_connect.Enabled = true;
                button_close.Enabled = false;
            }
            catch (Exception ex)
            {
                WriteLog(ex.ToString() + Environment.NewLine + "   at " + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString())+"\n");
                textBox_status.AppendText("Exception Occured. Please refer log file." + "\n");
                button_connect.Enabled = true;
                button_close.Enabled = false;
            }
            finally
            {
                CloseLog();
            }
        }
        /// <summary>
        /// This is the method to handle close button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_connect_Click(object sender, EventArgs e)
        {
            if (!groupBox6.Controls.OfType<RadioButton>().Any(x => x.Checked))
            {
                WriteLog("Choose File Storage Type..." + "   at " + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                textBox_status.AppendText("Choose One File Storage Type...\n");
                return;
            }
            //Method to connect to the barcode reader
            Connect();
        }
        /// <summary>
        /// Method to parse time zone into Tz*** format
        /// </summary>
        /// <param name="timeZone">Current Time Zone</param>
        /// <returns>Parsed Time Zone</returns>
        private string convertTimeZone(string timeZone)
        {
            string timeZoneParsed = string.Empty;
            if (!timeZone.Trim().Equals(string.Empty))
            {
                string[] timeZones = timeZone.Split(':');
                timeZoneParsed += Convert.ToInt64(timeZones[0]);
                if(Convert.ToInt64(timeZones[1])>0)
                {
                    timeZoneParsed += Convert.ToInt64(timeZones[1]);
                }
            }
            return timeZoneParsed.Trim();
        }
        //Delegate to create new file name when timer expires for day time limit feature
        private delegate void updateTimer(string timer);
        //Method to create new file name when timer expires for day time limit feature
        private void updateTimerValue(string timer)
        {
            textBox_status.AppendText("New File Name is "+timer+"\n");
            textBox_status.AppendText("New File Path is " + filePath + "\n");
        }
        //Delegate to write the newly received data into the file 
        private delegate void updateData(byte[] data);
        //Method to write the newly received data into the file 
        private void updateDataValue(byte[] data)
        {
            try
            {
                string dataString = Encoding.GetEncoding("Shift_JIS").GetString(data);
                //dataString = dataString.Substring(0,dataString.Length-2);
                dataString = dataString.TrimEnd('\r');
                string dateString = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff")+"Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString());
                if (radioButton_Individual.Checked)
                {
                    fileNameNew = fileName.Trim() + "_"+DateTime.Now.ToString("yyyyMMddHHmmssfff")+"Tz"+convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString())+".csv";
                    filePath = Path.Combine(Path.GetDirectoryName(filePath),fileNameNew);
                    WriteData("Barcode", "TimeStamp");
                    WriteLog("Date will be written to "+ filePath + "   at " + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                }
                if (radioButton_Combined.Checked)
                {
                    filePath = Path.Combine(Path.GetDirectoryName(filePath), fileNameNew);
                    WriteLog("Date will be written to " + filePath + "   at " + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                }
                //Called method to write data and date into the file
                WriteData(dataString, dateString);
                try
                {
                    if (!dataString.StartsWith("ERROR"))
                    {
                        //Method to fetch where image is stored inside RAM
                        imageString = barcodeReaderControl1.LSIMG();
                        string extension = Path.GetExtension(imageString);
                        destinationString = folderPath + dataString + "_" + dateString + extension;
                        //Method to copy image from RAM into local drive
                        barcodeReaderControl1.GetFile(imageString, destinationString);
                    }
                }
                catch (Exception ex)
                {
                    WriteLog(ex.ToString() + "   at" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                    textBox_status.AppendText("Exception Occured. Please refer log file." + "\n");
                }
                textBox_status.AppendText("Image Stored at "+destinationString+"\n");
            }
            catch (Exception ex)
            {
                WriteLog(ex.ToString() + "   at " + DateTime.Now.ToString("yyyyMMddHHmmssfff") +"Tz"+convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString())+ "\n");
                textBox_status.AppendText("Exception Occured. Please refer log file."+"\n");
            }
            finally
            {
                CloseData();
                CloseLog();
            }
        }
        /// <summary>
        /// This is the function to write barcode data into file and it is called whenever there is an OnDataReceived event occurs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataReceived(object sender,OnDataReceivedEventArgs e)
        {
                textBox_status.Invoke(new updateData(updateDataValue),e.data);
        }
        /// <summary>
        /// This is the method to handle close button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_close_Click(object sender, EventArgs e)
        {
            try
            {
                //Unregistering the data received event listener
                this.barcodeReaderControl1.OnDataReceived -= dataReceived;
                //Method to stop showing live view from the barcode reader 
                this.barcodeReaderControl1.StopLiveView();
                //Method called to disconnect from the barcode reader
                this.barcodeReaderControl1.Disconnect();
                CloseLog();
                CloseData();
                textBox_status.AppendText("Socked Closed...\n");
                button_close.Enabled = false;
                button_connect.Enabled = true;
            }
            catch (Exception ex)
            {
                WriteLog(ex.ToString() + Environment.NewLine + "   at " + DateTime.Now.ToString("yyyyMMddHHmmssfff")+"Tz"+convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()));
                textBox_status.AppendText("Exception Occured. Please refer log file." + "\n");
                button_close.Enabled = true;
                button_connect.Enabled = false;
            }
        }
        /// <summary>
        /// Method to perform checked changed event on radio button combined
        /// </summary>
        /// <param name="sender">Radio Button</param>
        /// <param name="e">Event Args</param>
        private void radioButton_Combined_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Monitor.Checked = false;
            if (radioButton_Combined.Checked)
            {
                checkBox_Monitor.Enabled = true;
            }
            else
            {
                checkBox_Monitor.Enabled = false;
            }
        }
        /// <summary>
        /// Method to execute when file choose button is clicked
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Event Args</param>
        private void button_FileChoose_Click(object sender, EventArgs e)
        {
            filePath = string.Empty;
            fileName = string.Empty;
            fileNameNew = string.Empty;
            textBox_FileName.Text = string.Empty;
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Enter File Name...";
            saveFileDialog1.Filter = "Comma Separated Values (*.csv)|*.csv";
            if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                filePath = saveFileDialog1.FileName;
                fileName = Path.GetFileNameWithoutExtension(filePath);
                fileNameNew = fileName + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff")+"Tz"+convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString())+".csv";
                filePath = Path.Combine(Path.GetDirectoryName(filePath), fileNameNew);
                WriteData("Barcode", "TimeStamp");
                textBox_FileName.Text = Path.GetDirectoryName(filePath);
                WriteLog("Data will be written to " + Path.GetDirectoryName(filePath) + "   at " + DateTime.Now.ToString("yyyyMMddHHmmssfff")+"Tz"+convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString())+ "\n");
                textBox_status.AppendText("Data will be written to " + Path.GetDirectoryName(filePath) + "\n");
                fileStatus = true;
                EnableButton();
            }
            else
            {
                fileStatus = false;
                EnableButton();
                return;
            }
        }
        /// <summary>
        /// Method to execute when folder choose button is clicked
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Event Args</param>
        private void button_FolderChoose_Click(object sender, EventArgs e)
        {
            folderPath = string.Empty;
            textBox_ImagePath.Text = string.Empty;
            folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                textBox_ImagePath.Text = folderPath;
                WriteLog("Images will be stored to " + folderPath + "   at " + DateTime.Now.ToString("yyyyMMddHHmmssfff")+"Tz"+convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                textBox_status.AppendText("Images will be stored to " + folderPath + "     \n");
                folderStatus = true;
                EnableButton();
            }
            else
            {
                folderStatus = false;
                EnableButton();
                return;
            }
        }
        /// <summary>
        /// Method to enable buttons
        /// </summary>
        private void EnableButton()
        {
            if (fileStatus && folderStatus)
            {
                button_connect.Enabled = true;
            }
            else
            {
                button_connect.Enabled = false;
            }
        }
        /// <summary>
        /// Method to start timer to perform day time limit
        /// </summary>
        private void SetTimerValue()
        {
            DateTime requiredTime = DateTime.Today.AddHours(00).AddMinutes(00);
            if (DateTime.Now > requiredTime)
            {
                requiredTime = requiredTime.AddDays(1);
            }
            myTimer = new System.Threading.Timer(new TimerCallback(TimerAction));
            myTimer.Change((int)(requiredTime - DateTime.Now).TotalMilliseconds, Timeout.Infinite);
        }
        /// <summary>
        /// Method to create new file when timer expires
        /// </summary>
        /// <param name="e"></param>
        private void TimerAction(object e)
        {
            fileNameNew = fileName + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff")+"Tz"+convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString())+".csv";
            filePath = Path.Combine(Path.GetDirectoryName(filePath), fileNameNew);
            WriteData("Barcode", "TimeStamp");
            textBox_status.Invoke(new updateTimer(updateTimerValue),fileNameNew);
            SetTimerValue();
        }
    }
}
