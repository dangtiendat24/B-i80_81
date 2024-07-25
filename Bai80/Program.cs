using System.Net.WebSockets;
using System.Text;

namespace Bai80
{
    internal class Program
    {
        public static void ff()
        {
            Random random = new Random();
            while(true)
            {
                int value = random.Next(1, int.MaxValue);
                if(value % 2025 == 0)
                {
                    Console.WriteLine(value);
                    break;
                }
                Console.WriteLine($"Số ngẫu nhiên: {value}");
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread thread = new Thread(new ThreadStart(ff));
            thread.Start();
            thread.Join();
            Console.WriteLine("Đã thực hiện xong");
        }
    }
}
