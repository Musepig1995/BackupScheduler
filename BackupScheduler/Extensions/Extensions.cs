using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupScheduler.Extensions
{
    public static class Extensions
    {
        public static string[] GetRange(this string[] data, int index, int length)
        {
            var result = new string[length];
            Array.Copy(data, index, result, 0, length);

            return result;
        }
    }
}
