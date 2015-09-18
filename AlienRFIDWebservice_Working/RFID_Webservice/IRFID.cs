using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.Xml;

namespace RFID_Webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRFID" in both code and config file together.
    [ServiceContract]
    public interface IRFID
    {
        [OperationContract]
        [WebGet(UriTemplate = "/input?ipAddress={ipAddress}&port={port}")]
        XmlElement GetTag(string ipAddress, string port);
    }
}
