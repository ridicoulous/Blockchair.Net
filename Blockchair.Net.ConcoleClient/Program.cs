using System.IO;
using System.Linq;
using System.Threading;

namespace Blockchair.Net.ConcoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new BlockchairClient();
            int count = 0;
            foreach (var address in File.ReadAllLines("C:\\blockzi\\kunabtc.txt").Skip(665))
            {
                var result = client.GetAddressDashboard(address);
                if(result?.Data?.FirstOrDefault().Value?.Transactions!=null)
                {
                    File.AppendAllLines("C:\\blockzi\\kunaothertxs.txt", result.Data.First().Value.Transactions);
                }
            
                Thread.Sleep(2002);
                System.Console.WriteLine($"{count}: {address}");
                count++;
                
            }
        }
    }
}
