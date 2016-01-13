using FYT.Models;
using System.Data.Entity;

namespace FYT.DAL.SpecificRepository
{
    class ProjectInfoRepository: GenericRepository<ProjectInfo>
    {
        public ProjectInfoRepository(DbContext context) : base(context) { }
    }
}