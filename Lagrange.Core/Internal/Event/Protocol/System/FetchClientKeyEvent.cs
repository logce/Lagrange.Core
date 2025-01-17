namespace Lagrange.Core.Internal.Event.Protocol.System;

internal class FetchClientKeyEvent : ProtocolEvent
{
    public string ClientKey { get; }

    private FetchClientKeyEvent() : base(true)
    {
        ClientKey = "";
    }
    
    private FetchClientKeyEvent(int resultCode, string clientKey) : base(resultCode)
    {
        ClientKey = clientKey;
    }

    public static FetchClientKeyEvent Create() => new();
    
    public static FetchClientKeyEvent Result(int resultCode, string clientKey) => new(resultCode, clientKey);
}