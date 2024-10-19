using Microsoft.AspNetCore.SignalR;
using Realtime.ChatSystem.Models;

namespace Realtime.ChatSystem.Hubs;

public class ChatHub:Hub
{
    public async Task JoinChat(UserConnection conn)
    {
        await Clients.All.SendAsync("ReceiveMessages", "admin", $"{conn.UserName} has joined the chat");
    }

    public async Task JoinGroupChat(UserConnection conn)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, conn.ChatRoom);
        await Clients.Groups(conn.ChatRoom)
            .SendAsync("ReceiveMessages", "admin", $"{conn.UserName} has joined the {conn.ChatRoom}");
    }
    
}