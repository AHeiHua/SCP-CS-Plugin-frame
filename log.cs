using System;
using System.Timers;
using UnityEngine;

namespace HeiHua
{
    public class Debug
    {
        public string Name { get { return "HeiHua"; } set { Name = value; } }
        public string Format { get { return "[%H %N %F] %MSG"; } set { Format = value; } }
        public void Log(string msg, string format)
        {
            string message = Format.Replace("%H", DateTime.Now.ToString()).
                Replace("%N", Name).Replace("%F", format).Replace("%MSG", msg);
            UnityEngine.Debug.Log(message);
        }
    }
}