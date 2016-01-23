using BackupScheduler.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupScheduler.Controllers
{
    /// <summary>
    /// The linking functionality between the back-up job data and the commands given
    /// </summary>
    public static class BackupJobController
    {
        public static void RunCommand(BackupJobContext context, string command, string[] args)
        {
            switch (command.ToLower())
            {
                case "create":

                    break;
                case "list":
                    List(context, args);
                    break;

                case "select":

                    break;

                case "delete":

                    break;

                case "edit":

                    break;

                case "run":

                    break;

                case "help":
                    Help();
                    break;

                default:
                    Console.WriteLine("Command not found please try again, type help for a list of available commands");
                    break;
            }
        }

        private static void Help()
        {
            Console.WriteLine(ConfigurationManager.AppSettings["ListInfo"]);
            Console.WriteLine(ConfigurationManager.AppSettings["SelectInfo"]);
            Console.WriteLine(ConfigurationManager.AppSettings["CreateInfo"]);
            Console.WriteLine(ConfigurationManager.AppSettings["DeleteInfo"]);
            Console.WriteLine(ConfigurationManager.AppSettings["EditInfo"]);
            Console.WriteLine(ConfigurationManager.AppSettings["RunInfo"]);
        }

        private static void List(BackupJobContext context, string[] args)
        {
            var function = new ListFunction(context);

            if (args != null && args.Length > 0)
            {
                if (args[0].Equals("help", StringComparison.CurrentCultureIgnoreCase))
                {
                    function.Help();
                }
            }
            else
            {
                function.Execute();
            }
        }
    }
}
