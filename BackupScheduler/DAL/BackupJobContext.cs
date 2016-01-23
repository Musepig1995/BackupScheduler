using BackupScheduler.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupScheduler.DAL
{
    /// <summary>
    /// The database connection used in the program for creating back-ups
    /// </summary>
    public class BackupJobContext : DbContext
    {
        /// <summary>
        /// The back-up job data set
        /// </summary>
        public DbSet<BackupJob> BackupJobs { get; set; }
    }
}
