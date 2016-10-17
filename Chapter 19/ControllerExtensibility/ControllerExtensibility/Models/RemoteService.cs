using System.Threading;
using System.Threading.Tasks;

namespace ControllerExtensibility.Models {
    public class RemoteService {

        public string GetRemoteData() {
            Thread.Sleep(2000);
            return "Hello from the other side of the world";
        }

        public async Task<string> GetRemoteDataAsync() {
            return await Task<string>.Factory.StartNew(() => {
                Thread.Sleep(2000);
                return "Hello from the other side of the world";
            });
        }
    }
}
