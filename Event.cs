using System;

namespace HeiHua
{
    public class Event
    {
        public Action<object> RoundStart { get; set; } = null;
        public Action<object> PlayerSetClass { get; set; } = null;
        public Action<object> SupportSpawned { get; set; } = null;
        public Action<object> SupportRequest { get; set; } = null;


        public void init()
        {
            HookManager.Add("onRoundStart", RoundStart);
            HookManager.Add("onPlayerSetClass", PlayerSetClass);
            HookManager.Add("SupportSpawned", SupportSpawned);
            HookManager.Add("SupportRequest", SupportRequest);
        }
    }
}