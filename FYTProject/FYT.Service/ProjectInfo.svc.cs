using FYT.DAL;
using System.Linq;
using System;
using System.Collections.Generic;

namespace FYT.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProjectInfo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProjectInfo.svc or ProjectInfo.svc.cs at the Solution Explorer and start debugging.
    public class ProjectInfo : IProjectInfo
    {
        ApplicationUnit myContext = new ApplicationUnit();

        public string JSONData(string id)
        {
            return "String in JSON format";
        }

        public List<FYT.Models.ProjectInfo> ProjectInfoList()
        {
            var projectInfo = myContext.ProjectInfo.GetAll();
            return projectInfo.ToList();
        }

        public string XMLData(string id)
        {
            return "String in XML format";
        }
    }
}
