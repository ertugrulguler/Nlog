using NLog.Tools.Entity;
using NLogProject.DataAccessLayer.Initializer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogProject.DataAccessLayer.Context
{
    public class ProjectContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["LogDB"].ConnectionString;
            Database.SetInitializer(new ProjectInitializer());
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<LogEntry> LogEntries { get; set; }
    }
}
