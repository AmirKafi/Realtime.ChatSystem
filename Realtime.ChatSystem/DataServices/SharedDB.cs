using Realtime.ChatSystem.Models;
using System.Collections.Concurrent;

namespace Realtime.ChatSystem.DataServices
{
    public class SharedDB
    {
        private readonly ConcurrentDictionary<string, UserConnection> _connections = new();

        public ConcurrentDictionary<string, UserConnection> connections => _connections;
    }
}
