using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
//using System;
//using System.Runtime.InteropServices;

namespace Eventures.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            
        }

        //[DllImport("rpcrt4.dll", SetLastError = true)]
        //static extern int UuidCreateSequential(out System.Guid guid);

        //static Guid UuidCreateSequential()
        //{
        //    const int RPC_S_OK = 0;
        //    Guid g;
        //    int hr = UuidCreateSequential(out g);
        //    if (hr != RPC_S_OK)
        //        throw new ApplicationException
        //            ("UuidCreateSequential failed: " + hr);
        //    return g;
        //}

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
