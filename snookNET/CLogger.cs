using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Serilog.Configuration;

namespace snookNET
{
    internal static  class CLogger
    {
        private static readonly LoggerConfiguration Configuration = new LoggerConfiguration();
        public static Serilog.Core.Logger serilogLogger;
        public static string NombreLog = "SnookNet.log";
        static CLogger()
        {
            //if (!System.IO.File.Exists(NombreLog))
            //{
            //    NombreLog += "SnookNet_" + Guid.NewGuid().ToString() + ".log";
            //}
            serilogLogger = new LoggerConfiguration().WriteTo.File(NombreLog).CreateLogger();
        }

    }
}
