using FYT.DAL.SpecificRepository;
using FYT.Models;
using System;

namespace FYT.DAL
{
    public class ApplicationUnit : IDisposable
    {   
        private DataContext _context = new DataContext(); 

        public void SaveChanges()
        {
            this._context.SaveChanges();
        }

        public void Dispose()
        {
            if (this._context != null)
            {
                this._context.Dispose();
            }
        }

        private IRepository<ProjectInfo> projectInfo = null;

        public IRepository<ProjectInfo> ProjectInfo
        {
            get
            {
                if (this.projectInfo == null)
                {
                    this.projectInfo = new ProjectInfoRepository(this._context);
                }
                return this.projectInfo;
            }
        }
    }
}
