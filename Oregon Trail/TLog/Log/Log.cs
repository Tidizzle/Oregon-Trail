using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLog.Tools;
using System.IO;
using System.Threading;

namespace TLog.Log
{
    public class Log
    {
        #region Private Member Variables

        private string filename;
        private string filepath;

        #endregion

        #region Properties

        public string Filename
        {
            get
            {
                return filename;
            }

            set
            {
                filename = value;
            }
        }

        public string Filepath
        {
            get
            {
                return filepath;
            }

            set
            {
                filepath = value;
            }
        }

        #endregion

        #region Methods

        public Log(string filename)
        {
            Filename = filename;
            Filepath = Utility.ToFileName(filename);
            if (File.Exists(Filepath))
            {
                var stream = File.AppendText(Filepath);
                stream.Write(String.Format(" -- {0} --", Utility.GetEntryText()));
                stream.Close();
            }
            else
            {
                using (File.Create(Filepath))
                {
                    
                    var stream = File.AppendText(Filepath);
                    stream.Write(String.Format(" -- {0} --", Utility.GetEntryText()));
                    stream.Close();
                }
            }
        }

        public void WriteLogLine(string text)
        {
            using (var stream = File.AppendText(this.Filepath))
            {
                string time = Utility.GetEntryText();
                string Log = String.Format("@{0} :: {1}", time, text);
                Log = Log.Replace("@", Environment.NewLine);
                stream.Write(Log);
                stream.Close();
            }

        }

        public void WriteLine(string text)
        {
            string log = String.Format("@ {0}", text);
            log = log.Replace("@", Environment.NewLine);
            using (var stream = File.AppendText(this.Filepath))
            {
                stream.Write(log);
                stream.Close();
            }

        }

        public void DeleteLog()
        {
            File.Delete(this.Filepath);
        }

        public async void ClearLog()
        {
            await Task.Factory.StartNew(() =>
           {
               var path = Filepath;
               File.Delete(path);
               Thread.Sleep(200);
               File.Create(path);
           });
        }

        public static void CreateErrorLog(string filename, string text)
        {
            string filepath = Utility.ToFileName(filename);
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
            File.Create(filepath);
            var stream = File.AppendText(filepath);

            stream.Write(String.Format("ERROR :: {0}", text));
        }
        #endregion


    }
}
