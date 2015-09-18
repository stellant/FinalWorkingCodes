using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Xml;

namespace Barcode_Keyence_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DataService" in code, svc and config file together.
    public class Barcode : IBarcode
    {
        private IPEndPoint _commandEndPoint = null;
        private IPEndPoint _dataEndPoint = null;
        private Socket _commandSocket = null;
        private Socket _dataSocket = null;
        private XmlElement _result = null; 
        public XmlElement GetData(string ipAddress,string cPort,string dPort)
        {
            try
            {
                _commandEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), Convert.ToInt16(cPort));
                _dataEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), Convert.ToInt16(dPort));
                _commandSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _dataSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IAsyncResult resultCommand = _commandSocket.BeginConnect(_commandEndPoint, null, null);
                bool successCommand = resultCommand.AsyncWaitHandle.WaitOne(15000, true);
                if (!successCommand)
                {
                    _commandSocket.Close();
                    throw new Exception("Cannot Connect to Barcode Sensor");
                }
                //_commandSocket.Connect(_commandEndPoint);
               // _dataSocket.ReceiveTimeout = 15000;
                //_dataSocket.Connect(_dataEndPoint);
                IAsyncResult resultData = _dataSocket.BeginConnect(_dataEndPoint, null, null);
                bool successData = resultData.AsyncWaitHandle.WaitOne(15000, true);
                if (!successData)
                {
                    _dataSocket.Close();
                    throw new Exception("Cannot Connect to Barcode Sensor");
                }
                _commandSocket.Send(ASCIIEncoding.ASCII.GetBytes("LON\r"));
                Byte[] byteData = new Byte[1024];
                int count = _dataSocket.Receive(byteData);
                StringBuilder s = new StringBuilder();
                for (int i = 0; i < count; i++)
                    s.Append(Convert.ToChar(byteData[i]));
                _result = GetXML(s.ToString());
                _commandSocket.Send(ASCIIEncoding.ASCII.GetBytes("LOFF\r"));
                _commandSocket.Close();
                _dataSocket.Close();
            }
            catch(Exception ex)
            {
                _result = GetExceptionXML(ex.ToString()); 
            }
            return _result;
        }

        private XmlElement GetXML(string s)
        {
            XmlDocument document = new XmlDocument();
            XmlNode root = document.CreateElement("Barcode");
            document.AppendChild(root);
            XmlNode dataNode = document.CreateElement("BarcodeData");
            dataNode.InnerText = s;
            root.AppendChild(dataNode);
            XmlNode dateNode = document.CreateElement("BarcodeDataDateTime");
            dateNode.InnerText = DateTime.Now.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString());
            root.AppendChild(dateNode);
            return document.DocumentElement;
        }
        private XmlElement GetExceptionXML(string ex)
        {
            XmlDocument document = new XmlDocument();
            XmlNode root = document.CreateElement("Barcode");
            document.AppendChild(root);
            XmlNode dataNode = document.CreateElement("ExceptionData");
            dataNode.InnerText = ex;
            root.AppendChild(dataNode);
            XmlNode dateNode = document.CreateElement("ExceptionDateTime");
            dateNode.InnerText = DateTime.Now.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString());
            root.AppendChild(dateNode);
            return document.DocumentElement;
        }
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
    }
}
