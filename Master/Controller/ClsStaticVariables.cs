using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Master.Controller;


namespace Master.Controller
{
    public static class ClsStaticVariables
    {
        #region properties

        //public static string DataBase = "WBPOS";
        //public static string server = "localhost";
        public static string DataBase = "WareHouseMS";
        public static string server = "localhost";
        public static DBConnect objConnection = new DBConnect();
        public static ControllerUser controllerUser = new ControllerUser();

        public static string SlocID = "";
        public static string SlocType = "";
        public static string SlocBinID = "";

        // Material 
        public static string ManagementID = "";
        public static string MaterialNumber = "";
        public static string MaterialDescription = "";
        public static decimal Qty = 0;
        public static decimal QtyAlokasi = 0;
        public static string BaseUnit = "";
        public static decimal Value = 0;
        public static string Sloc = "";

        // Sloc
        public static string status = "";
        public static string statusMM = "";

        //Gudang
        public static string GudangInit = "";
        public static string GudangID = "";
        public static string GudangDesc = "";
        public static string HeaderID = "";

        //Titipan 
        public static string TitipanID = "";
        public static string Reference = "";
        public static string Equipment = "";
        public static string Area = "";
        public static string NamaPenanggungJawab = "";
        public static int tahun = DateTime.Today.Year;
        public static bool tambah = false;


        #endregion

        #region OldWBPOS
        public static string NOPC = "0"; //0
        public static string PCID = "COM - 0";
        //public static string NOPC = "1"; //1
        //public static string PCID = "COM - 1";
        //public static string NOPC = "2"; //2
        //public static string PCID = "COM - 2";
        //public static string NOPC = "3"; //3
        //public static string PCID = "COM - 3";

        public static decimal ticketprice = 0;
        public static string ticketformat = "TC" + ClsStaticVariables.NOPC + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString();
        public static decimal ticketpricedisc = 0;
        public static decimal ticketpricetotal = 0;
        public static string idtanggal = "";
        public static int ProductDisc = 0;
        public static decimal ProductPriceInc = 0;
        public static int prvrnd = 0;
        public static decimal Total = 0;
        public static string OrderID = "";
        public static string Note = "";
        public static decimal TotalHargaTicket = 0;
        public static int JumlahTicket = 0;
        public static Double divider = 1.5;

        #endregion

        #region function

        public static void setNewConnection (string Database, string Server)
        {
            objConnection.setConnectionString(Database, Server);
            objConnection = new DBConnect(Database, Server);
        }

        #endregion
    }
}
