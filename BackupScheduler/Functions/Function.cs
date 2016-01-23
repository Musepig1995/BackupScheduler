using BackupScheduler.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupScheduler.Controllers
{
    public abstract class Function
    {
        /// <summary>
        /// The name of the function
        /// </summary>
        public string Name { get; set; }

        public BackupJobContext Context { get; set; }

        public Function(string name, BackupJobContext context)
        {
            this.Name = name;
            this.Context = context;
        }
        
        public abstract void Execute(params string[] args);
        public abstract void Help();
    }
}
