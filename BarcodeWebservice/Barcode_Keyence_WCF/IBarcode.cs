using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.Xml;

namespace Barcode_Keyence_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDataService" in both code and config file together.
    [ServiceContract]
    public interface IBarcode
    {
        [OperationContract]
        [WebGet(UriTemplate = "/input?ip={ipAddress}&cport={cport}&dport={dport}",ResponseFormat=WebMessageFormat.Xml)]
        XmlElement GetData(string ipAddress,string cport,string dport);
    }
}
