using NLogProject.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogProject.DataAccessLayer
{
    public class Test
    {
        ProjectContext db = new ProjectContext();
        public Test()
        {
            db.LogEntries.ToList();
        }
    }
}
