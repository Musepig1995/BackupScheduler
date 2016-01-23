using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackupScheduler.Model
{
    /// <summary>
    /// A specified back-up to take place at certain interval
    /// </summary>
    public class BackupJob
    {
        /// <summary>
        /// The unique identifier of the back-up job
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid backupId { get; set; }

        /// <summary>
        /// The name of the back-up job
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The directory in which to find all files to be backed up
        /// </summary>
        public string sourceDirectoryPath { get; set; }

        /// <summary>
        /// The directory in which to create the backups 
        /// </summary>
        public string targetDirectoryPath { get; set; }

        /// <summary>
        /// Cron-based frequency string
        /// </summary>
        public string frequency { get; set; }
    }
}
