using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace FYT.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProjectInfo" in both code and config file together.
    [ServiceContract]
    public interface IProjectInfo
    {
        [OperationContract]
        [WebInvoke(Method ="GET",
            ResponseFormat =WebMessageFormat.Xml,
            BodyStyle =WebMessageBodyStyle.Wrapped,
            UriTemplate ="xml/{id}")]
        string XMLData(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/{id}")]
        string JSONData(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "proj")]
        List<FYT.Models.ProjectInfo> ProjectInfoList();
    }
}
