using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEPTHCHK.Models;
using System.IO.Ports;

namespace DEPTHCHK
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

        public static event Action<SerialPort> GlobalPortChanged;

        // NEW: second port
        public static SerialPort GlobalPort2 { get; private set; }
        public static bool IsPort2Open => GlobalPort2?.IsOpen ?? false;

        public static event Action<SerialPort> GlobalPort2Changed;

        public static void SetGlobalPort(SerialPort port)
        {
            // if there is an existing port, close it
            if (GlobalPort != null && GlobalPort.IsOpen)
            {
                try { GlobalPort.Close(); } catch { /* ignore */ }
            }
            GlobalPort = port;
            GlobalPortChanged?.Invoke(GlobalPort);
        }

        // NEW: Set / close second port
        public static void SetGlobalPort2(SerialPort port)
        {
            if (GlobalPort2 != null && GlobalPort2.IsOpen)
                try { GlobalPort2.Close(); } catch { }
            GlobalPort2 = port;
            GlobalPort2Changed?.Invoke(GlobalPort2);
        }
    }
}
