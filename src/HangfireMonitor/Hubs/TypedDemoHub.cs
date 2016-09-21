using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace HangfireMonitor.Hubs.DemoHub
{
    public class TypedDemoHub : Hub<IClient>
    {
        private static int _invokeCount = 0;

        public async Task Echo(string message)
        {
            await Clients.Caller.Echo(message, Interlocked.Increment(ref _invokeCount));
        }
    }

    public interface IClient
    {
        Task Echo(string message, int invokeCount);
        void MethodB(int arg1, int arg2);
    }
}