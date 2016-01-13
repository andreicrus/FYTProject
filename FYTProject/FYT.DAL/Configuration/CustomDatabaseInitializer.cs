using FYT.Models;
using System;
using System.Data.Entity;

namespace FYT.DAL.Configuration
{
    public class CustomDatabaseInitializer :
           DropCreateDatabaseIfModelChanges<DataContext>
    //CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            ProjectInfo projectInfo = new ProjectInfo();

            projectInfo.AssemblyDescription = "Major Version 1.0.0.0";
            projectInfo.AssemblyTitle = "FeelYourTime";
            projectInfo.AssemblyVersion = "1.0.0.0";
            projectInfo.Company = "";
            string dateTime = "1/13/2016 8:57:16.55";
            projectInfo.CreatedOn = Convert.ToDateTime(dateTime);
            projectInfo.Guid = "00000000-0000-0000-0000-000000000000";
            projectInfo.ModifiedOn = DateTime.Now;
            projectInfo.Product = "FYT Project";

            context.ProjectInfo.Add(projectInfo);

            base.Seed(context);
        }
    }
}
