using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBPOS.Models;
using Master;
using Master.Controller;
using System.Data.SqlClient;
using System.Data;
using Login.Models;

namespace Login.Controller
{
    public class ControllerSlocs
    {
        #region properties

        public string query;
        public DataTable dt;
        public DataTable othr;
        public DataRow dr;
        public ClsSloc clsSloc = new ClsSloc();
        public ClsSlocBin clsSlocBin = new ClsSlocBin();
        public List<ClsSlocBin> listSlocBIn = new List<ClsSlocBin>();

        #endregion

        #region function

        public DataTable getSloc ()
        {
            query = "Select * from WareHouseMS.dbo.Sloc";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataTable getSlocBin(string SlocID)
        {
            if(SlocID == "ALL")
            {
                query = "Select * from WareHouseMS.dbo.SlocBin";
                return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            }
            else
            {
                query = "Select * from WareHouseMS.dbo.SlocBin where Sloc = " + ClsFungsi.C2Q(SlocID);
                return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            }
        }

        public ClsSlocBin getOneSlocBin (string SlocBinID)
        {
            query = "Select * from WareHouseMS.dbo.SlocBin where SlocBin = " + ClsFungsi.C2Q(SlocBinID);
            dt = ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            this.clsSlocBin = new ClsSlocBin(dt.Rows[0]["SlocBin"].ToString(), dt.Rows[0]["Sloc"].ToString(), Convert.ToBoolean(dt.Rows[0]["Is_Full"].ToString()), Convert.ToBoolean(dt.Rows[0]["Still_Available"].ToString()), Convert.ToBoolean(dt.Rows[0]["Is_Empty"].ToString()));
            return clsSlocBin;
        }

        public DataTable getSlocBinEachGUD(string GUDID)
        {
            query = "Select * from WareHouseMS.dbo.SlocBin where SlocBin like " + ClsFungsi.C2Q(GUDID + "%");
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public void getOneSloc(string SlocID)
        {
            query = "Select * from WareHouseMS.dbo.SlocBin where SlocBin = " + ClsFungsi.C2Q(SlocID);
            dt = ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            clsSlocBin = new ClsSlocBin(dt.Rows[0]["SlocBin"].ToString(), dt.Rows[0]["Sloc"].ToString(),Convert.ToBoolean(dt.Rows[0]["Is_Full"]), Convert.ToBoolean(dt.Rows[0]["Still_Available"]), Convert.ToBoolean(dt.Rows[0]["Is_Empty"]));
        }

        // Insert Into Sloc

        public string InsertDataSloc(ClsSloc objSloc)
        {
            query = "Insert Into WareHouseMS.dbo.Sloc " + 
                " (Sloc, Sloc_Type, Sloc_Addresses) " + 
                " values " + 
                $" ({ClsFungsi.C2Q(objSloc.Sloc)}, {ClsFungsi.C2Q(objSloc.Sloc_Type)})";
            try
            {
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                return "Data Sloc Berhasil ditambah !";
            }

            catch(Exception e)
            {
                return "Data Sloc Gagal ditambah , error message = " + e.Message;
            }
        }

        // Insert Data SlocBin 

        public string InsertDataSLocBin (List<ClsSlocBin> listslocbin)
        {
            try
            {
                foreach(ClsSlocBin objslocbin in listslocbin)
                {
                    query = "Insert Into WareHouseMS.dbo.SlocBin " +
                            " (SlocBin, Sloc, Is_Full, Still_Available, Is_Empty) " +
                            " values " +
                            $" ({ClsFungsi.C2Q(objslocbin.SlocBin)}, {ClsFungsi.C2Q(objslocbin.Sloc)}, {ClsFungsi.C2Q(objslocbin.Is_Full)}, {ClsFungsi.C2Q(objslocbin.still_available)} , {ClsFungsi.C2Q(objslocbin.Is_Empty)})";
                    ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                }
                return "Data SlocBin berhasil ditambah !";
            }
            catch(Exception e)
            {
                //Delete All Sloc
                this.DeleteFailSloc(listslocbin[0].Sloc);
                return "Data Sloc Bin gagal ditambah , error message = " + e.Message;
            }
        }

        // Delete Sloc Also Delete SlocBin 

        public void DeleteFailSloc (string SlocID)
        {
            query = "Delete WareHouseMS.dbo.Sloc where Sloc = " + ClsFungsi.C2Q(SlocID);
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        } 

        public void DeleteAllSlocBin (string SlocID)
        {
            query = "Delete WareHouseMS.dbo.SlocBin where Sloc = " + ClsFungsi.C2Q(SlocID);
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public string DeleteOneSloc (string SlocID)
        {
            query = "Delete WareHouseMS.dbo.SlocBin where SlocBin = " + ClsFungsi.C2Q(SlocID);
            try
            {
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                return "Data SlocBin " + SlocID + " berhasil dihapus !";
            }
            catch(Exception e)
            {
                return "Data Sloc Gagal untuk dihapus, error Message = " + e.Message;
            }
        }

        public string UpdateSlocSlocBin (ClsSlocBin objSlocBin)
        {
            try
            {
                //this.DeleteAllSlocBin(objSloc.Sloc);
                //this.InsertDataSLocBin(listSlocBIn);
                query = "Update WareHouseMS.dbo.SlocBin " +
                        $" set SlocBin = {ClsFungsi.C2Q(objSlocBin.SlocBin)}, Sloc = {ClsFungsi.C2Q(objSlocBin.Sloc)}, Is_Full = {ClsFungsi.C2Q(objSlocBin.Is_Full)}, Still_Available = {ClsFungsi.C2Q(objSlocBin.still_available)}, Is_Empty = {ClsFungsi.C2Q(objSlocBin.Is_Empty)} " +
                        $" where SlocBin = {ClsFungsi.C2Q(objSlocBin.SlocBin)}";
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                return "Data Sloc & SlocBin Berhasil di ubah !";
            }

            catch(Exception e)
            {
                return "Data Sloc & SlocBin gagal diubah , error message = " + e.Message;
            }
        }
        #endregion

        #region SlocBinDetails
        
        public DataTable getSlocBinDetails (string SlocBinID)
        {
            query = "Select * from WareHouseMS.dbo.SlocBinDetail where SlocBin = " + ClsFungsi.C2Q(SlocBinID);
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }
         
        #endregion


    }
}
