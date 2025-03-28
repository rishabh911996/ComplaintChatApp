using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ComplaintChatApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string firstName, string lastName, string category, string message, DateTime date)
        {
            await Clients.All.SendAsync("ReceiveMessage", firstName, lastName, category, message, date);
        }
    }
}
