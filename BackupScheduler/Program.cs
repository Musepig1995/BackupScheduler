using BackupScheduler.Controllers;
using BackupScheduler.DAL;
using BackupScheduler.Jobs;
using BackupScheduler.Model;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using BackupScheduler.Extensions;

namespace BackupScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<BackupJobContext>(new DropCreateDatabaseIfModelChanges<BackupJobContext>());

            using (var context = new BackupJobContext())
            {
                // Welcome the user
                Console.WriteLine(ConfigurationManager.AppSettings["WelcomeMessage"]);

                string userEntry = string.Empty;
                do
                {
                    // Await the user's command
                    userEntry = Console.ReadLine();

                    var splitEntry = userEntry.Split(' ');

                    // Command was given
                    if (splitEntry.Length > 0)
                    {
                        string command = splitEntry[0];
                        string[] arguments = null;

                        // Arguments were given
                        if (splitEntry.Length > 1)
                        {
                            arguments = splitEntry.GetRange(1, splitEntry.Length - 1);

                        }

                        BackupJobController.RunCommand(context, command, arguments);
                    }
                    
                } while (!userEntry.Equals("exit", StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}
