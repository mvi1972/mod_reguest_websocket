using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace mod_reguest_websocket
{
    
    public class ClientWebSocket : System.Net.WebSockets.WebSocket
    {
        public override WebSocketCloseStatus? CloseStatus => throw new NotImplementedException();

        public override string CloseStatusDescription => throw new NotImplementedException();

        public override string SubProtocol => throw new NotImplementedException();

        public override WebSocketState State => throw new NotImplementedException();

        public override void Abort()
        {
            throw new NotImplementedException();
        }

        public override Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
