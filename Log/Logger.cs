using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JungFranco.Helpers.Log
{
    public static class Logger
    {
        public static Queue<string> Logs { get; set; }
        static Logger()
            => Logs = new Queue<string>();

        public static string Time { get; set; } = DateTime.Now.ToShortDateString();

        public static void Push(string message)
        {
            Logs.Enqueue($"[{Time}]: {message}");
        }
    }
}
