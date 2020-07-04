using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P04.Helper
{
    public class LogHelper
    {
        private static readonly object _lock = new object();
        private static readonly object _writeLock= new object();
        private static readonly object _infoLock = new object();

        //write to Console
        public static void WirteInfoLog(string message, ConsoleColor c = ConsoleColor.White)
        {
            lock (_writeLock)
            {
                Thread.Sleep(500);
                Console.ForegroundColor = c;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            // write to log file
            WriteInfo(message);
        }

        public static void WriteInfo(string msg)
        {
            try
            {
                string fileName = DateTime.Now.ToString("yyyy-MM-dd");
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "/logInfo";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                string virtualPath = filePath + "\\" + fileName + ".txt";
                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                msg = time + ", " + msg + System.Environment.NewLine;
                System.Threading.Tasks.Task.Factory.StartNew(() =>
                {
                    lock (_infoLock)
                    {
                        using (FileStream fs = new FileStream(virtualPath, FileMode.Append))
                        {
                            using (StreamWriter sw = new StreamWriter(fs))
                            {
                                sw.Write(msg);
                                sw.Flush();//remember to flush buffer
                            }
                        }

                    }
                });

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void WriteError(Exception ex, string message)
        {
            if (ex != null)
            {
                lock (_lock)
                {
                    string appendToLogFile = string.Format("{0}\r\n{1}\r\n{2}\r\n=====================\r\n",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm"),
                        message + "--" + ex.Message,
                        ex.StackTrace);


                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "/runerror.txt",
                        appendToLogFile
                        );
                }
            }
            else
            {
                lock (_lock)
                {
                    string appendToLogFile = string.Format("{0}\r\n{1}\r\n{2}\r\n=====================\r\n",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm"), message + "----", "");
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory+"/runerror.txt",
                        appendToLogFile);
                }
            }


        }





    }
}
