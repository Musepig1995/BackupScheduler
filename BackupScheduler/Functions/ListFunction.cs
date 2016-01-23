using BackupScheduler.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupScheduler.Controllers
{
    public class ListFunction : Function
    {

        public ListFunction(BackupJobContext context)
            : base("list", context)
        {
        }

        public override void Execute(params string[] args)
        {
            if (this.Context.BackupJobs.LongCount() > 0)
            {
                Console.WriteLine("Name \t Source Location \t Target Location \t Frequency");

                foreach (var job in this.Context.BackupJobs)
                {
                    Console.WriteLine("{0} \t {1} \t {2} \t {3}", job.name, job.sourceDirectoryPath, job.targetDirectoryPath, job.frequency);
                }
            }
        }

        public override void Help()
        {
            Console.WriteLine("'{0}' is used to display every backup job that has been created.", this.Name);
        }
    }
}
