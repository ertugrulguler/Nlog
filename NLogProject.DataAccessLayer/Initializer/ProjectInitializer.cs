using NLog.Tools.Entity;
using NLogProject.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogProject.DataAccessLayer.Initializer
{
    public class ProjectInitializer:CreateDatabaseIfNotExists<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {
            LogEntry log = new LogEntry();
            context.LogEntries.Add(log);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
