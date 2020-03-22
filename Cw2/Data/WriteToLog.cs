using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cw2.Data
{
    class WriteToLog
    {
        public static void WriteStudnetsToLog(string log)
        {
            using (var streamWriter = new StreamWriter("log.txt"))
            {
                streamWriter.WriteLine(log);
            } 
        }
    }
}
