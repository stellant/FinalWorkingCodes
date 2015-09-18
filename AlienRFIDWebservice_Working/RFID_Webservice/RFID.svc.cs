using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;
using nsAlienRFID2;
namespace RFID_Webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RFID" in code, svc and config file together.
    public class RFID : IRFID
    {
        private XmlElement _result = null;
        private clsReader _reader = null;
        public XmlElement GetTag(string ipAddress, string port)
        {
            try
            {
                _reader = new clsReader();
                _reader.InitOnNetwork(ipAddress,Convert.ToInt16(port));
                _reader.Connect();
                if (_reader.IsConnected)
                {
                    if (!_reader.Login("alien", "password"))
                    {
                        throw new Exception("Cannot Login...");
                    }
                    string result = _reader.TagList;
                    if (result != null && result.Length > 0)
                    {
                        _result = GetXML(result);
                    }
                    _reader.Disconnect();
                }
                else
                {
                    throw new Exception("Cannot Connect...");
                }
            }
            catch (Exception ex)
            {
                _result = GetExceptionXML(ex.ToString());
            }
            return _result;
        }
        private XmlElement GetXML(string s)
        {
            XmlDocument document = new XmlDocument();
            XmlNode root = document.CreateElement("RFID");
            document.AppendChild(root);
            XmlNode dataNode = document.CreateElement("RFIDTag");
            dataNode.InnerText = s;
            root.AppendChild(dataNode);
            XmlNode dateNode = document.CreateElement("RFIDDataDateTime");
            dateNode.InnerText = DateTime.Now.ToString("yyyyMMddHHmmssfff") + "Tz" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString());
            root.AppendChild(dateNode);
            return document.DocumentElement;
        }
        private XmlElement GetExceptionXML(string ex)
        {
            XmlDocument document = new XmlDocument();
            XmlNode root = document.CreateElement("RFID");
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
