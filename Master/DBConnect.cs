using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Master.Interfaces;

namespace Master
{
    public class DBConnect : IConnection
    {
        #region properties 

        public SqlConnection con = new SqlConnection();
        public string connectionstring;
        public SqlServerClass objsqlconnection;
        public SqlServerIUDClass objSqlServerIUDClass;
        public string DataBase;
        public string Server;


        #endregion

        #region function
        /// <summary>
        /// Membuat connection string database
        /// </summary>
        /// <param name="database"></param>
        /// <param name="server"></param>
        public void setConnectionString(string database, string server)
        {
            connectionstring = @"User ID=sa;Password=Numero1;Database=" + database + ";Server=" + server;
            //connectionstring = @"User ID=sa;Password=pertamina1406;Database=" + database + ";Server=" + server;
            con.ConnectionString = connectionstring;
        }

        /// <summary>
        /// Membuka Koneksi ke database
        /// </summary>
        /// <param name="dBConnection"></param>
        public void OpenConnection()
        {
            try
            {
                con.ConnectionString = connectionstring;
                con.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Menutup Koneksi Database
        /// </summary>
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor Kosong
        /// </summary>
        public DBConnect() { }

        /// <summary>
        /// Mengisi connection string untuk database dan server melalui constructor
        /// </summary>
        /// <param name="Database"></param>
        /// <param name="Server"></param>
        public DBConnect(string Database, string Server)
        {
            this.DataBase = Database;
            this.Server = Server;
            this.setConnectionString(Database, Server);
            objsqlconnection = new SqlServerClass(this);
            objSqlServerIUDClass = new SqlServerIUDClass(this);
            this.con = new SqlConnection();
        }

        #endregion
    }
}
