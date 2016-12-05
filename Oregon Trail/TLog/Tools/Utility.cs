using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TLog.Log;

namespace TLog.Tools
{
    public static class Utility
    {
        public static string ToFileName(string Filename)
        {
            string result = $@"{Directory.GetCurrentDirectory()}\Oregonlog.log";

            try
            {
                result = $@"{Directory.GetCurrentDirectory()}\{Filename}.log";
            }
            catch (Exception e)
            {
                Log.Log log = new Log.Log($"Error-{GetFileTime()}");
                log.WriteLogLine(e.ToString());
            }

            return result;
        }

        public static string GetEntryText()
        {
            string Currentdat = DateTime.Today.ToShortDateString();
            string currenttime = DateTime.Now.ToShortTimeString();
            string Result = String.Format(@"** {0} :: {1} **", Currentdat, currenttime);
            return Result;
        }

        public static void GetLineReturn(string filepath)
        {
            string log = "\n\r";
            var stream = File.AppendText(filepath);
            stream.Write(log);
        }

        public static string GetFileTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}
