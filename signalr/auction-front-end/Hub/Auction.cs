// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.AspNetCore.SignalR;

namespace Microsoft.Azure.SignalR.Samples.AuctionFE
{
    public class Auction : Hub
    {
        public void BroadcastMessage(string name, string message)
        {
            Clients.All.SendAsync("broadcastMessage", name, message);
        }

        public void BroadcastMessageGroup(string name, string message, string auctionId)
        {
           Clients.Group(auctionId).SendAsync("broadcastMessage", name, message);
           
        }

        public void AuctionEvent(string name, string message)
        {
            Clients.All.SendAsync("auctionevent", name, message);
        }

        public void Echo(string name, string message)
        {
            Clients.Client(Context.ConnectionId).SendAsync("echo", name, message + " (echo from server)");
        }

        public void JoinAuction(string auctionId)
        {
           Groups.AddToGroupAsync(Context.ConnectionId, auctionId);
        }

        public void LeaveAuction(string auctionId)
        {
            Groups.RemoveFromGroupAsync(Context.ConnectionId, auctionId);
        }
        
    }
}
