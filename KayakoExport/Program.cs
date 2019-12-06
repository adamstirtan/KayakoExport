using System.Threading.Tasks;

namespace KayakoExport
{
    internal class Program
    {
        private static void Main(string[] args) =>
            MainAsync(args).GetAwaiter().GetResult();

        private static async Task MainAsync(string[] args)
        {
            var exporter = new Exporter();

            await exporter.StartAsync();
        }
    }
}