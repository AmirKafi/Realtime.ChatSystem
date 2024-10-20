using Microsoft.AspNetCore.SignalR;
using Realtime.ChatSystem.DataServices;
using Realtime.ChatSystem.Models;

namespace Realtime.ChatSystem.Hubs;

public class ChatHub:Hub
{
    private readonly SharedDB _db;

    public ChatHub(SharedDB db)
    {
        _db = db;
    }

    public async Task JoinChat(UserConnection conn)
    {
        if (_db.connections.TryGetValue(Context.ConnectionId, out conn))
        {
            await Clients.All.SendAsync("ReceiveMessages", "admin", $"{conn.UserName} has joined the chat");
        }
    }

    public async Task JoinGroupChat(UserConnection conn)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, conn.ChatRoom);

        _db.connections[Context.ConnectionId] = conn;

        await Clients.Groups(conn.ChatRoom)
            .SendAsync("JoinGroupChat", "admin", $"{conn.UserName} has joined the {conn.ChatRoom}");
    }
    
    public async Task SendMessage(string message)
    {
        if (_db.connections.TryGetValue(Context.ConnectionId, out UserConnection conn)) {
            await Clients.Group(conn.ChatRoom).SendAsync("ReceiveMessageInGroup", conn.UserName, message);
        }
    }
}