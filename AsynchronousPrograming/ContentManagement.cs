using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousPrograming
{
    public class ContentManagement
    {
        //synchronous method
        public string GetContent()
        {
            Thread.Sleep(5000);
            return "content";
        }

        public int GetNumber()
        {
            Thread.Sleep(3000);
            return 3;
        }

        //asynchronous method
        public async Task<string> GetContentAsync()
        {
            await Task.Delay(5000);
            return "content async";
        }

        public async Task<int> GetNumbreAsync()
        {
            await Task.Delay(3000);
            return 3;
        }
    }
}