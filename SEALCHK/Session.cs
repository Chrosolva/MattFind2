using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEALCHK.Model;
using System.IO.Ports;

namespace SEALCHK
{
    public static class Session
    {
        public static TblUser CurrentUser { get; private set; }
        public static string SERVERADDRESS;
        public static TimeZoneInfo tzi;
        public static TblUser VerifiedAdmin { get; set; }
        public static void SetUser(TblUser user)
        {
            CurrentUser = user;
        }

        public static void SetServerAddress(string Server)
        {
            SERVERADDRESS = Server;
        }

        public static void Settzi(TimeZoneInfo tzii)
        {
            tzi = tzii;
        }

        public static void SetVerifiedUser(TblUser user)
        {
            VerifiedAdmin = user;
        }

        public static SerialPort GlobalPort { get; private set; }

        public static bool IsPortOpen => GlobalPort?.IsOpen ?? false;

        public static void SetGlobalPort(SerialPort port)
        {
            // if there is an existing port, close it
            if (GlobalPort != null && GlobalPort.IsOpen)
            {
                try { GlobalPort.Close(); } catch { /* ignore */ }
            }
            GlobalPort = port;
        }
    }
}
