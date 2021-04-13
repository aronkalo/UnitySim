using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using System;

namespace UnitySim.Server.Hubs
{
    public class DepthHub : Hub
    {
        public DepthHub(){
            
        }

        public async Task PostDepthComputationAsync(){
            throw new Exception();
        }
    }
}