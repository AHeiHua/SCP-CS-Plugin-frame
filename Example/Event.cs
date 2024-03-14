using HeiHua;

public class EventTest
{
    public void example()
    {
        HeiHua.Debug debug = new HeiHua.Debug();
        HeiHua.Event @event = new HeiHua.Event();
        @event.SupportRequest = (object obj) => { debug.Log("SupportRequest","Test"); };
        @event.SupportSpawned = (object obj) => { debug.Log("SupportSpawned", "Test"); };
        @event.RoundStart = (object obj) => { debug.Log("RoundStart", "Test"); };
        @event.PlayerSetClass = (object obj) => { debug.Log("PlayerSetClass", "Test"); };
        // Use Init()!!!
        // 不要重复调用init()!!!
        @event.init();
    }
}