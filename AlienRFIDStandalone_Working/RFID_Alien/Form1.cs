using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using nsAlienRFID2;
using System.Threading;

namespace RFID_Alien
{
    public partial class Form1 : Form
    {
        //StreamWriter variable to write data into data file
        private StreamWriter streamWriter = null;
        //StreamWriter variable to write log into log file
        private StreamWriter streamLogWriter = null;
        //String variable to hold the file name of the data file
        private string filePath = string.Empty;
        //String variable to hold the file name chosen using FileDialog
        private string fileName = string.Empty;
        //String variable to hold the newly created file name
        private string fileNameNew = string.Empty;
        //Arraylist to hold the readers list connected
        private ArrayList list = null;
        //Reader Monitor Variable to listen for the readers
        private clsReaderMonitor monitor = null;
        //Reader variable to connect and read the data from the Alien Sensor
        private clsReader reader = null;
        //Bolean variable to know whether file name has been choosen using file dialog
        bool fileStatus = false; 
        //Timer variable to perform Day Time Limit Feature
        private System.Threading.Timer myTimer = null;
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
            if (streamWriter == null)
            {
                streamWriter = new StreamWriter(filePath, true);
            }
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
            if (streamLogWriter == null)
            {
                streamLogWriter = new StreamWriter(filePath, true);
            }
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
        /// <summary>
        /// Method to write data into data file
        /// </summary>
        /// <param name="data">Barcode data</param>
        /// <param name="date">Time Stamp</param>
        private void WriteData(string data, string date)
        {
            getWriter(filePath).WriteLine(string.Format("{0},{1}", data, date));
            getWriter(filePath).Flush();
        }
        /// <summary>
        /// Method to write text into text status text box
        /// </summary>
        /// <param name="status">Status</param>
        private void WriteText(string status)
        {
            textBox_status.Invoke(new updateTextStatusDelegate(updateTextStatus),status);
        }
        /// <summary>
        /// Method to close the data stream writer
        /// </summary>
        private void CloseData()
        {
            getWriter(filePath).Close();
        }
        /// <summary>
        /// Method to close the log stream writer
        /// </summary>
        private void CloseLog()
        {
            getLogWriter("log.log").Close();
        }
        /// <summary>
        /// Delegate to update status in text status textbox
        /// </summary>
        /// <param name="message">Status Message</param>
        private delegate void updateTextStatusDelegate(string message);
        /// <summary>
        /// Method to update status in text status textbox
        /// </summary>
        /// <param name="message">Status Message</param>
        private void updateTextStatus(string message)
        {
            textBox_status.AppendText(message + "\n");
        }
        /// <summary>
        /// Delegate to update list box by adding item
        /// </summary>
        /// <param name="message">Name</param>
        private delegate void UpdateListBoxDelegate(string name);
        /// <summary>
        /// Method to update list box by adding items
        /// </summary>
        /// <param name="message">Name</param>
        private void UpdateListBox(string name)
        {
            listBox_Devices.Items.Add(name);
        }
        /// <summary>
        /// Delegate to update list box by removing item
        /// </summary>
        /// <param name="message">Name</param>
        private delegate void RemoveListBoxDelegate(string name);
        /// <summary>
        /// Method to update list box by removing item
        /// </summary>
        /// <param name="message">Name</param>
        private void RemoveListBox(string name)
        {
            listBox_Devices.Items.Remove(name);
        }
        /// <summary>
        /// Method executes when form loads
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">Event Args</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_ListeningPort.GotFocus+= new System.EventHandler(OnFocusListeningPort);
            textBox_ListeningPort.LostFocus += new System.EventHandler(OnLostListeningPort);
            //creates a reader monitor object
            monitor = new clsReaderMonitor();
            //sets com ports monitoring to be false
            monitor.ComPortsMonitoring = false;
            //Sets network monitoring to be true
            monitor.NetworkMonitoring = true;
            //Event handler for when reader adds
            monitor.ReaderAdded +=
                new clsReaderMonitor.ReaderAddedEventHandler(ReaderAdded);
            //Event handler for when reader renews
            monitor.ReaderRenewed +=
                new clsReaderMonitor.ReaderRenewedEventHandler(ReaderRenewed);
            //Event handler for when reader removes
            monitor.ReaderRemoved +=
                new clsReaderMonitor.ReaderRemovedEventHandler(ReaderRemoved);
            //Creates a reader object connects to rfid sensor
            reader = new clsReader();
            list = new ArrayList();
            radioButton_Individual.Checked = true;
            button_connect.Enabled = false;
            button_close.Enabled = false;
            checkBox_Monitor.Enabled = false;
        }
        /// <summary>
        /// Method to execute when text box on focus event occurs
        /// </summary>
        /// <param name="Sender">Object</param>
        /// <param name="e">Event Args</param>
        private void OnFocusListeningPort(object Sender, EventArgs e)
        {
            textBox_ListeningPort.Text = "";
        }
        /// <summary>
        /// Method to execute when text box lost focus event occurs
        /// </summary>
        /// <param name="Sender">Object</param>
        /// <param name="e">Event Args</param>
        private void OnLostListeningPort(object Sender, EventArgs e)
        {
            if (textBox_ListeningPort.Text.Equals(""))
            {
                textBox_ListeningPort.Text = "3988";
            }
        }
        /// <summary>
        /// Method to execute when reader added
        /// </summary>
        /// <param name="readerInfo">ReaderInfo</param>
        private void ReaderAdded(IReaderInfo readerInfo)
        {
            ReaderInfo info = (ReaderInfo)readerInfo;
            try
            {
                if (!list.Contains(info))
                {
                    list.Add(info);
                    listBox_Devices.Invoke(new UpdateListBoxDelegate(UpdateListBox),info.Name);
                    WriteLog(info.Name + " is Added\n");
                    WriteText(info.Name + " is Added\n");
                }
            }
            catch (Exception ex)
            {
                WriteLog(ex.ToString());
                WriteText("Exception Occured. See the Log File...\n");
            }
        }
        /// <summary>
        /// Method to execute when reader renewed
        /// </summary>
        /// <param name="readerInfo">ReaderInfo</param>
        private void ReaderRenewed(IReaderInfo readerInfo)
        {
            ReaderInfo info = (ReaderInfo)readerInfo;
            try
            {
                if (list.Contains(info))
                {
                    WriteLog(info.Name + " is Renewed\n");
                   // WriteText(info.Name + " is Renewed\n");
                }
            }
            catch (Exception ex)
            {
                WriteLog(ex.ToString());
                WriteText("Exception Occured. See the Log File...\n");
            }
        }
        /// <summary>
        /// Method to execute when reader removed
        /// </summary>
        /// <param name="readerInfo">ReaderInfo</param>
        private void ReaderRemoved(IReaderInfo readerInfo)
        {
            ReaderInfo info = (ReaderInfo)readerInfo;
            try
            {
                if (list.Contains(info))
                {
                    list.Remove(info);
                    listBox_Devices.Invoke(new RemoveListBoxDelegate(RemoveListBox),info.Name);
                    WriteLog(info.Name + " is Removed\n");
                    WriteText(info.Name + " is Removed\n");
                    setDetails();
                }
            }
            catch (Exception ex)
            {
                WriteLog(ex.ToString());
                WriteText("Exception Occured. See the Log File...\n");
            }
        }
        /// <summary>
        /// Method executes when stop listening button clicked
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">Event Args</param>
        private void button_Stop_Click(object sender, EventArgs e)
        {
            monitor.StopListening();
            textBox_status.AppendText("Stopped Listening...\n");
            button_Start.Enabled = true;
            button_Stop.Enabled = false;
        }
        /// <summary>
        /// Method executes when start listening button clicked
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">Event Args</param>
        private void button_Start_Click(object sender, EventArgs e)
        {
            monitor.Port = Convert.ToInt16(textBox_ListeningPort.Text);
            textBox_status.AppendText("Starting Listening...\n");
            monitor.StartListening();
            textBox_status.AppendText("Started Listening...\n");
            button_Start.Enabled = false;
            button_Stop.Enabled = true;
        }
        /// <summary>
        /// Method to parse the timezone in the format Tz***
        /// </summary>
        /// <param name="timeZone">Time Zone</param>
        /// <returns></returns>
        private string convertTimeZone(string timeZone)
        {
            string timeZoneParsed = string.Empty;
            if (!timeZone.Trim().Equals(string.Empty))
            {
                string[] timeZones = timeZone.Split(':');
                timeZoneParsed += Convert.ToInt64(timeZones[0]);
                if (Convert.ToInt64(timeZones[1]) > 0)
                {
                    timeZoneParsed += Convert.ToInt64(timeZones[1]);
                }
            }
            return timeZoneParsed.Trim();
        }
        /// <summary>
        /// Method executes when file choose button clicked
        /// </summary>
        /// <param name="sender">Object</param>
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
                fileNameNew = fileName + "_" + DateTime.UtcNow.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + ".csv";
                filePath = Path.Combine(Path.GetDirectoryName(filePath), fileNameNew);
                WriteData("Tag","TimeStamp");
                textBox_FileName.Text = Path.GetDirectoryName(filePath);
                WriteLog("Data will be written to " + Path.GetDirectoryName(filePath) + "   at " + DateTime.UtcNow.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
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
        /// Method to enable button
        /// </summary>
        private void EnableButton()
        {
            if (fileStatus)
            {
                button_connect.Enabled = true;
            }
            else
            {
                button_connect.Enabled = false;
            }
        }
        /// <summary>
        /// Method executes when radio button combined checked event occurs
        /// </summary>
        /// <param name="sender">Object</param>
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
        /// Method executes when connect button is clicked
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">Event Args</param>
        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox_Monitor.Checked)
                {
                    SetTimerValue();
                    WriteLog("Date Time Monitor Started..." + "   at " + DateTime.UtcNow.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                    WriteData("Tag", "TimeStamp");
                    textBox_status.AppendText("Date Time Monitor Started...\n");
                }
                if (reader != null)
                {
                    WriteText("Reader Connecting...\n");
                    reader.Connect();
                    if (reader.IsConnected)
                    {
                        WriteText("Reader Connected...\n");
                        WriteText("Reader Login Started...\n");
                        if (!reader.Login("alien", "password"))
                        {
                            WriteText("Reader Login Failed...\n");
                            return;
                        }
                        WriteText("Reader Login Success...\n");
                        button_connect.Enabled = false;
                        button_close.Enabled = true;
                        timer1.Start();       
                    }
                }
            }
            catch (Exception ex)
            {
                if (myTimer != null)
                    myTimer.Change(Timeout.Infinite,Timeout.Infinite);
                button_connect.Enabled = true;
                button_close.Enabled = false;
                WriteLog(ex.ToString());
                WriteText("Exception Occured. See the Log File...\n");
            }
        }
        /// <summary>
        /// Method executes when device list box selected index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_Devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                setDetails();
            }
            catch (Exception ex)
            {
                WriteLog(ex.ToString());
                WriteText("Exception Occured. See the Log File...\n");
            }
        }
        /// <summary>
        /// Method to fetch details of the reader and updates the textbox
        /// </summary>
        private void setDetails()
        {
            if (listBox_Devices.Items.Count < 1)
            {
                textBox_IPAddress1.Text = "";
                textBox_IPAddress2.Text = "";
                textBox_IPAddress3.Text = "";
                textBox_IPAddress4.Text = "";
                textBox_Port.Text = "";
                reader.ReaderSettings = null;
                WriteText("No Readers...\n");
                return;
            }
            ReaderInfo info = null;
            string name = listBox_Devices.SelectedItem.ToString();
            foreach (ReaderInfo readerInfo in list)
            {
                if (readerInfo.Name.Equals(name))
                {
                    info = readerInfo;
                    break;
                }
            }
            byte[] ip = IPAddress.Parse(info.IPAddress).GetAddressBytes();
            textBox_IPAddress1.Text = ip[0].ToString();
            textBox_IPAddress2.Text = ip[1].ToString();
            textBox_IPAddress3.Text = ip[2].ToString();
            textBox_IPAddress4.Text = ip[3].ToString();
            textBox_Port.Text = info.TelnetPort.ToString();
            reader.ReaderSettings = info;
        }
        /// <summary>
        /// Method executes when disconnect button is clicked
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">Event Args</param>
        private void button_close_Click(object sender, EventArgs e)
        {
            try
            {
                if (reader.IsConnected)
                {
                    reader.Disconnect();
                    WriteText("Reader Connected...\n");
                }
                if (timer1.Enabled)
                {
                    timer1.Stop();
                }
                button_connect.Enabled = true;
                button_close.Enabled = false;
            }
            catch (Exception ex)
            {
                button_connect.Enabled = false;
                button_close.Enabled = true;
                WriteLog(ex.ToString());
                WriteText("Exception Occured. See the Log File...\n");
            }
        }
        /// <summary>
        /// Method to execute Day Time Limit feature needed
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
        private void TimerAction(object e)
        {
            fileNameNew = fileName + "_" + DateTime.UtcNow.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + ".csv";
            filePath = Path.Combine(Path.GetDirectoryName(filePath), fileNameNew);
            WriteData("Tag","TimeStamp");
            WriteText("New File Name is "+filePath+"...\n");
            SetTimerValue();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TagInfo[] tagInfo = null;
            try
            {
                int count = 0;
                reader.TagListFormat = "Text";
                string result = reader.TagList;
                //                if(result!=null && result.Length > 0 && result.IndexOf("No Tags")==-1)
                if ((result != null) && (result.Length > 0) && (result.IndexOf("No Tags") == -1))
                {
                    try
                    {
                        count = AlienUtils.ParseTagList(reader.TagList, out tagInfo);
                    }
                    catch (Exception ex)
                    {
                        //WriteText("Error\n");
                    }
                    if (count > 0)
                    {
                        foreach (TagInfo info in tagInfo)
                        {
                            string dataString = info.TagID;
                            string dateString = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString());
                            if (radioButton_Individual.Checked)
                            {
                                fileNameNew = fileName.Trim() + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + ".csv";
                                filePath = Path.Combine(Path.GetDirectoryName(filePath), fileNameNew);
                                WriteData("Tag", "TimeStamp");
                                WriteLog("Date will be written to " + filePath + "   at " + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                            }
                            if (radioButton_Combined.Checked)
                            {
                                filePath = Path.Combine(Path.GetDirectoryName(filePath), fileNameNew);
                                WriteLog("Date will be written to " + filePath + "   at " + DateTime.UtcNow.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                            }
                            WriteData(dataString, dateString);
                            WriteText(dataString);
                            CloseData();
                        }
                    }
                    reader.ClearTagList();
                }
            }
            catch (Exception ex)
            {
                WriteLog(ex.ToString());
                WriteText("Exception Occured. See the Log File...\n");
            }
            finally
            {
                CloseData();
                CloseLog();
            }
        }
       
    }
}
