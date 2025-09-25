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
using System.Windows.Forms;

namespace Login.Controller
{
    public class ControllerManagement
    {
        #region properties

        public ControllerSlocs controllerSloc = new ControllerSlocs();
        public ClsKartuRayon ClsKartuRayon = new ClsKartuRayon();
        public ClsManagementMaterial clsMM = new ClsManagementMaterial();
        public ClsMMaterialDetail clsMMDetail = new ClsMMaterialDetail();
        public List<ClsSlocBinDetail> listSlocBinDetail = new List<ClsSlocBinDetail>();
        public ClsSlocBin objSlocBin = new ClsSlocBin();
        public ClsSlocBinDetail objSlocBInDetail = new ClsSlocBinDetail();
        public List<ClsKartuRayon> listKartuRayon = new List<ClsKartuRayon>();
        public ClsMaterial clsMaterial = new ClsMaterial();
        public DataTable dt = new DataTable();
        public string query = "";
        public ClsTitipan objTitip = new ClsTitipan();
        public CLsTitipanDetail objTitipdetail = new CLsTitipanDetail();
        public ClsMaterialAllocation obMMAlloc = new ClsMaterialAllocation();
        public List<ClsMaterialAllocation> listMMalloc = new List<ClsMaterialAllocation>(); 

        #endregion

        // AutoGenerate ManagementID 
        public string AutoGenerateManagemetID (string SearchType)
        {
            // M.EN Entry , M.RQ Request, M.DE Deposit Entry , M.DR Deposit Request 
            query = $" Select top 1 SUBSTRING(Management_ID, 9,5) as LastIndex from WareHouseMS.dbo.Material_Management where Management_ID like {ClsFungsi.C2Q(SearchType+"%")} Order By Management_ID desc ";
            int index = Convert.ToInt32(ClsStaticVariables.objConnection.objsqlconnection.ExecuteScalar2(query));
            if(SearchType == "M.EN")
            {
                if(index == 0)
                {
                    string tmp = DateTime.Now.ToString("yy");
                    return SearchType + "." + tmp + "-" + 1.ToString("D5");
                }
                else
                {
                    string tmp = DateTime.Now.ToString("yy");
                    return SearchType + "." + tmp + "-" + (index+1).ToString("D5");
                }
            }
            else if(SearchType == "M.RQ")
            {
                if (index == 0)
                {
                    string tmp = DateTime.Now.ToString("yy");
                    return SearchType + "." + tmp + "-" + 1.ToString("D5");
                }
                else
                {
                    string tmp = DateTime.Now.ToString("yy");
                    return SearchType + "." + tmp + "-" + (index + 1).ToString("D5");
                }
            }
            else if(SearchType =="M.DE")
            {
                if (index == 0)
                {
                    string tmp = DateTime.Now.ToString("yy");
                    return SearchType + "." + tmp + "-" + 1.ToString("D5");
                }
                else
                {
                    string tmp = DateTime.Now.ToString("yy");
                    return SearchType + "." + tmp + "-" + (index + 1).ToString("D5");
                }
            }
            else if(SearchType == "M.DR")
            {
                if (index == 0)
                {
                    string tmp = DateTime.Now.ToString("yy");
                    return SearchType + "." + tmp + "-" + 1.ToString("D5");
                }
                else
                {
                    string tmp = DateTime.Now.ToString("yy");
                    return SearchType + "." + tmp + "-" + (index + 1).ToString("D5");
                }
            }

            return "";
        }

        public string AutoGenerateTitipanID(string SearchType)
        {
            // M.EN Entry , M.RQ Request, M.DE Deposit Entry , M.DR Deposit Request 
            query = $" Select top 1 SUBSTRING(Titipan_ID, 9,5) as LastIndex from WareHouseMS.dbo.TblTitipan where Titipan_ID like {ClsFungsi.C2Q(SearchType + "%")} Order By Titipan_ID desc ";
            int index = Convert.ToInt32(ClsStaticVariables.objConnection.objsqlconnection.ExecuteScalar2(query));
            if (SearchType == "M.TT")
            {
                if (index == 0)
                {
                    string tmp = DateTime.Now.ToString("yy");
                    return SearchType + "." + tmp + "-" + 1.ToString("D5");
                }
                else
                {
                    string tmp = DateTime.Now.ToString("yy");
                    return SearchType + "." + tmp + "-" + (index + 1).ToString("D5");
                }
            }

            return "";
        }



        #region ForManagement

        // getTable Management
        public DataTable getManagement(string option, DateTime start, DateTime End) {
            query = $" Select * from WareHouseMS.dbo.Material_Management where Tgl_Dibuat between {ClsFungsi.C2QTime(start)} and {ClsFungsi.C2QTime(End)} Order By Tgl_Dibuat desc";
            if (option == "ALL")
            {
                return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            }
            else
            {
                query = $" Select * from WareHouseMS.dbo.Material_Management where Management_Type = {ClsFungsi.C2Q(option)} and Tgl_Dibuat between {ClsFungsi.C2QTime(start)} and {ClsFungsi.C2QTime(End)} Order By Tgl_Dibuat desc";
                return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            }
        }

        // getTable Management
        public DataTable getManagement2(string option, string option2)
        {
            query = "Select * from WareHouseMS.dbo.Material_Management Order By Tgl_Dibuat desc";
            if (option == "ALL" && option2 == "ALL")
            {
                return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            }
            else if(option == "ALL" && option2 != "ALL")
            {
                query = $" Select * from WareHouseMS.dbo.Material_Management where  Status = {ClsFungsi.C2Q(option2)} Order By Tgl_Dibuat desc";
                return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            }
            else if (option != "ALL" && option2 == "ALL")
            {
                query = $" Select * from WareHouseMS.dbo.Material_Management where Management_Type = {ClsFungsi.C2Q(option)} Order By Tgl_Dibuat desc";
                return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            }
            else
            {
                query = $" Select * from WareHouseMS.dbo.Material_Management where Management_Type = {ClsFungsi.C2Q(option)} and Status = {ClsFungsi.C2Q(option2)} Order By Tgl_Dibuat desc";
                return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            }
        }

        // getAll managementDetail

        public DataTable getManagementDetail(string ManagementID)
        {
            query = "Select ISNULL(SBD.SlocBin, '-') as SlocBin, MMD.Management_ID, MMD.Material_Number, M.Material_Description, " +
                    " MMD.Qty, MMD.Base_Unit, MMD.Status, MMD.Sloc, ISNULL(SBD.Qty, 0) as Qty_SlocBin, MMD.Reference, SBD.Sloc from WareHouseMS.dbo.MManagement_Detail MMD " +
                    " left join WareHouseMS.dbo.SlocBinDetail SBD on MMD.Management_ID = SBD.Management_ID and MMD.Material_Number = SBD.Material_Number and MMD.Sloc = SBD.Sloc left join WareHouseMS.dbo.Material M " +
                    $" on MMD.Material_Number = M.Material_Number Where MMD.Management_ID = {ClsFungsi.C2Q(ManagementID)} " +
                    " group by SBD.SlocBin, MMD.Management_ID, MMD.Material_Number, M.Material_Description," +
                    " MMD.Qty, MMD.Base_Unit, MMD.Status, MMD.Sloc, SBD.Qty, MMD.Reference, SBD.Sloc";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataTable getManagementAllocation(string ManagementID)
        {
            query = "Select MM.Management_ID,  MA.Material_Number, M.Material_Description, MA.Reference, MA.Qty , MA.Sloc" + 
                    " from WareHouseMS.dbo.Material_Management MM left " + 
                    " join WareHouseMS.dbo.Material_Alocation MA " + 
                    " on MM.Management_ID = MA.Management_ID left " + 
                    " join WareHouseMS.dbo.Material M on " + 
                    $" MA.Material_Number = M.Material_Number where MM.Management_Type = 'Entry' and MM.Management_ID = {ClsFungsi.C2Q(ManagementID)}";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataTable GetAllMaterialRequest ()
        {
            query = "Select * from WareHouseMS.dbo.Material_Management where Management_Type = 'Request' Order By Tgl_Dibuat desc";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataTable GetAllMaterialEntry()
        {
            query = "Select * from WareHouseMS.dbo.Material_Management where Management_Type = 'Entry' Order By Tgl_Dibuat desc";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }


        // Cek last transaction 
        public bool cekLastTransaction (string ManagementID)
        {
            query = "Select top 1 * from Material_Management where Management_Type = 'Entry' and Status is null Order By Tgl_Dibuat desc";
            dt = ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            if(dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                if(dt.Rows[0]["Management_ID"].ToString().Equals(ManagementID))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // InsertManagement
        public string InsertManagement(ClsManagementMaterial objManagement)
        {
            query = "Insert Into WareHouseMS.dbo.Material_Management " + 
                    " (Management_ID, Management_Type, Tgl_Dibuat, Reservation_Code, PO_RO, WorkOrder, Nama_PenanggungJawab, UserID) " + 
                    " Values " + 
                    $" ({ClsFungsi.C2Q(objManagement.ManagementID)}, {ClsFungsi.C2Q(objManagement.ManagementType)}, {ClsFungsi.C2QTime(objManagement.TglDibuat)}, {ClsFungsi.C2Q(objManagement.ReservationCode)}, {ClsFungsi.C2Q(objManagement.PORO)}, {ClsFungsi.C2Q(objManagement.WorkOrder)}, {ClsFungsi.C2Q(objManagement.NamaPenganggungJawab)}, {ClsFungsi.C2Q(objManagement.UserID)})";
            try
            {
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                return "Penambahan Data Material management Berhasil Dilakukan !";
            }
            catch (Exception e)
            {
                //Delete Management ID
                string tmp = this.DeleteManagement(objManagement.ManagementID);
                return "Penambahan Data Material Management gagal dilakukan ! , error Message = " + e.Message;
            }
        }

        public string InsertManagementWithStatus(ClsManagementMaterial objManagement)
        {
            query = "Insert Into WareHouseMS.dbo.Material_Management " +
                    " (Management_ID, Management_Type, Tgl_Dibuat, Reservation_Code, PO_RO, WorkOrder, Nama_PenanggungJawab, UserID, Status) " +
                    " Values " +
                    $" ({ClsFungsi.C2Q(objManagement.ManagementID)}, {ClsFungsi.C2Q(objManagement.ManagementType)}, {ClsFungsi.C2QTime(objManagement.TglDibuat)}, {ClsFungsi.C2Q(objManagement.ReservationCode)}, {ClsFungsi.C2Q(objManagement.PORO)}, {ClsFungsi.C2Q(objManagement.WorkOrder)}, {ClsFungsi.C2Q(objManagement.NamaPenganggungJawab)}, {ClsFungsi.C2Q(objManagement.UserID)}, {ClsFungsi.C2Q(objManagement.Status)})";
            try
            {
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                return "Penambahan Data Material management Berhasil Dilakukan !";
            }
            catch (Exception e)
            {
                //Delete Management ID
                string tmp = this.DeleteManagement(objManagement.ManagementID);
                return "Penambahan Data Material Management gagal dilakukan ! , error Message = " + e.Message;
            }
        }

        public string insertManagementDetail(List<ClsMMaterialDetail> listMMDetail)
        {
            try
            {
                foreach (ClsMMaterialDetail MMdetail in listMMDetail)
                {
                    query = "Insert Into WareHouseMS.dbo.MManagement_Detail (Management_ID, No_Urut, Material_Number, Qty , Base_Unit, Status, Sloc, Reference) " +
                        " values " +
                        $" ({ClsFungsi.C2Q(MMdetail.ManagementID)}, {ClsFungsi.C2Q(MMdetail.NoUrut)}, {ClsFungsi.C2Q(MMdetail.MaterialNumber)}, {ClsFungsi.C2Q(MMdetail.Qty)}, {ClsFungsi.C2Q(MMdetail.BaseUnit)}, {ClsFungsi.C2Q(MMdetail.Status)}, {ClsFungsi.C2Q(MMdetail.Sloc)}, {ClsFungsi.C2Q(MMdetail.Reference ?? " ")})";
                    ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                }
                return "Data Management Detai Berhasil Ditambah !"; 
            }
            catch (Exception e)
            {
                return "Data Management Detail Gagal untuk ditambah !, error Message = " + e.Message;
            }
        }

        // Insert Material Allocation 
        public string InsertManagementAllocation(List<ClsMaterialAllocation> listalloc)
        {
            try
            {
                foreach (ClsMaterialAllocation MMAlloc in listalloc)
                {
                    query = "Insert Into WareHouseMS.dbo.Material_Alocation (Management_ID, Material_Number, Reference , Qty, Sloc) " +
                        " values " +
                        $" ({ClsFungsi.C2Q(MMAlloc.ManagementID)}, {ClsFungsi.C2Q(MMAlloc.MaterialNumber)}, {ClsFungsi.C2Q(MMAlloc.Reference)}, {ClsFungsi.C2Q(MMAlloc.Qty)}, {ClsFungsi.C2Q(MMAlloc.Sloc)})";
                    ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                }
                return "Data Management Allocation Berhasil Ditambah !";
            }
            catch (Exception e)
            {
                return "Data Management Allocation Gagal untuk ditambah !, error Message = " + e.Message;
            }
        }

        public void DeleteAllocationPerMID (string Management_ID)
        {
            query = "Delete WareHouseMS.dbo.Material_Alocation " +
                    $" where Management_ID = {ClsFungsi.C2Q(Management_ID)}";
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public string insertManagementDetailWithStatus(List<ClsMMaterialDetail> listMMDetail)
        {
            try
            {
                foreach (ClsMMaterialDetail MMdetail in listMMDetail)
                {
                    query = "Insert Into WareHouseMS.dbo.MManagement_Detail (Management_ID, No_Urut, Material_Number, Qty , Base_Unit, Status) " +
                        " values " +
                        $" ({ClsFungsi.C2Q(MMdetail.ManagementID)}, {ClsFungsi.C2Q(MMdetail.NoUrut)}, {ClsFungsi.C2Q(MMdetail.MaterialNumber)}, {ClsFungsi.C2Q(MMdetail.Qty)}, {ClsFungsi.C2Q(MMdetail.BaseUnit)}, {ClsFungsi.C2Q(MMdetail.Status)})";
                    ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                }
                return "Data Management Detai Berhasil Ditambah !";
            }
            catch (Exception e)
            {
                return "Data Management Detail Gagal untuk ditambah !, error Message = " + e.Message;
            }
        }

        // Update All material Entry and Its Details
        public void UpdateAllMaterialEntryStatus (DataGridView dgv)
        {
            foreach(DataGridViewRow row in dgv.Rows)
            {
                query = $" Update WareHouseMS.dbo.Material_Management set Status = 'Cancelled' where Management_ID = {ClsFungsi.C2Q(row.Cells["Management_ID"].Value.ToString())} ";
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                query = $" Update WareHouseMS.dbo.MManagement_Detail set Status = 'Cancelled' where Management_ID = {ClsFungsi.C2Q(row.Cells["Management_ID"].Value.ToString())} ";
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
            }
        }

        public void UpdateQtyMaterial (DataGridView dgv)
        {
            foreach(DataGridViewRow row in dgv.Rows)
            {
                if(!row.IsNewRow)
                {
                    query = "Select * from WareHouseMS.dbo.Material where Material_Number = " + ClsFungsi.C2Q(row.Cells["Material_Number"].Value.ToString());
                    dt = ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
                    decimal Selisih = (Convert.ToDecimal(dt.Rows[0]["Qty"]) - Convert.ToDecimal(row.Cells["Qty"].Value));
                    query = $" Update WareHouseMS.dbo.Material set Qty = {ClsFungsi.C2Q(Selisih)}  where Material_Number = {ClsFungsi.C2Q(row.Cells["Material_Number"].Value.ToString())}";
                    ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                }
            }
        }


        // InsertManagementDetail
        // Update Managemetn
        // Update ManagementDetail

        // Delete Management
        public string DeleteManagement( string ManagementID)
        {
            query = "Delete WareHouseMS.dbo.Material_Management where Management_ID = " + ClsFungsi.C2Q(ManagementID);
            try
            {
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                return "Data Management Berhasil dihapus !";
            }
            catch(Exception e)
            {
                return "Data Management Gagal Untuk Dihapus ! , error Message = " + e.Message;
            }
        }
        // Delete ManagementDetail 

        // Update Material Request Status 
        public string UpdateStatusMaterialRequest(string Status, string ManagementID)
        {
            query = "  Update WareHouseMS.dbo.Material_Management " +
                    $" set Status = {ClsFungsi.C2Q(Status)} where Management_ID = {ClsFungsi.C2Q(ManagementID)} and Management_Type = 'Request'";
            try
            {
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                return "Perubahan Status Material Request Berhasil";
            }
            catch(Exception e)
            {
                return "Terjadi Kesalahan perubahan status material request , pesan error = " + e.Message;
            }
        }

        #endregion

        #region ForKartuRayon

        //getKartu Rayon
        //getLast Saldo Material / Kartu Rayon
        // InsertKartuRayon 
        public string InsertDataKartuRayon (List<ClsKartuRayon> listKartURayon)
        {
            try
            {
                int n = 1;
                foreach(ClsKartuRayon objKartuRayon in listKartURayon)
                {
                    objKartuRayon.Tgl = objKartuRayon.Tgl.AddSeconds(n);
                    query = "Insert Into WareHouseMS.dbo.TblKartuRayon " +
                            " (Material_Number, Tgl, Management_ID, Management_Type, Reservation_Code, PO_RO, WorkOrder, Terima, Keluar, Stock, Deposit_Masuk, Deposit_Keluar, Stock_Titipan, Note, Sloc) " +
                            " values " +
                            $" ({ClsFungsi.C2Q(objKartuRayon.MaterialNumber)}, {ClsFungsi.C2QTime(objKartuRayon.Tgl)}, {ClsFungsi.C2Q(objKartuRayon.ManagementId)}, {ClsFungsi.C2Q(objKartuRayon.ManagementType)}, {ClsFungsi.C2Q(objKartuRayon.ReservationCode)}, {ClsFungsi.C2Q(objKartuRayon.PO_RO)}, {ClsFungsi.C2Q(objKartuRayon.WorkOrder)}, {ClsFungsi.C2Q(objKartuRayon.Terima)}, {ClsFungsi.C2Q(objKartuRayon.Keluar)}, {ClsFungsi.C2Q(this.getLastQtyofaMaterial(objKartuRayon.MaterialNumber) + objKartuRayon.Stokc)}, {ClsFungsi.C2Q(objKartuRayon.DepositMasuk)}, {ClsFungsi.C2Q(objKartuRayon.DepositKeluar)}, {ClsFungsi.C2Q(objKartuRayon.StokcTitipan)}, {ClsFungsi.C2Q(objKartuRayon.Note)}, {ClsFungsi.C2Q(objKartuRayon.Sloc)}) ";
                    ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                    query = "Update WareHouseMS.dbo.Material " +
                            $" set Qty = {ClsFungsi.C2Q(this.getLastQtyofaMaterial(objKartuRayon.MaterialNumber) + objKartuRayon.Stokc)}, Value = {ClsFungsi.C2Q(objKartuRayon.Value)} " +
                            $" where Material_Number = {ClsFungsi.C2Q(objKartuRayon.MaterialNumber)}";
                    ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                    n++;
                }
                return "Data Kartu Rayon Berhasil untuk ditambah ! ";
            }
            catch(Exception e)
            {
                return "Data Kartu Rayon Gagal untuk ditambah ! error Message = " + e.Message; 
            }
        }

        public void DeleteKartuRayon (string Management_ID)
        {
            query = $" Delete WareHouseMS.dbo.TblKartuRayon where Management_ID = {ClsFungsi.C2Q(Management_ID)}";
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        // get Last Qty of a Material 
        public decimal getLastQtyofaMaterial( string MaterialNumber)
        {
            query = "Select Qty from WareHouseMS.dbo.Material where Material_Number = " + ClsFungsi.C2Q(MaterialNumber);
            return Convert.ToDecimal(ClsStaticVariables.objConnection.objsqlconnection.ExecuteScalar2(query));
        }

        public decimal getLastQtyofDeposit (string MaterialNumber )
        {
            query = $" Select top 1 Stock_Titipan from WareHouseMS.dbo.TblKartuRayon where Material_Number = {ClsFungsi.C2Q(MaterialNumber)} Order By Tgl desc  ";
            return Convert.ToDecimal(ClsStaticVariables.objConnection.objsqlconnection.ExecuteScalar2(query));
        }

        public DataTable GetKartuRayon (string Material_Number)
        {
            query = $"Select KR.Material_Number, M.Material_Description, KR.Tgl, KR.Management_ID, KR.Management_Type, KR.Terima, KR.Keluar, KR.Stock, MMD.Sloc, " + 
                    " KR.Reservation_Code, KR.PO_RO, KR.WorkOrder from WareHouseMS.dbo.TblKartuRayon KR left join WareHouseMS.dbo.MManagement_Detail MMD " +
                    " on KR.Management_ID = MMD.Management_ID and KR.Material_Number = MMD.Material_Number and KR.Sloc = MMD.Sloc left join WareHouseMS.dbo.Material M " + 
                    " on KR.Material_Number = M.Material_Number and MMD.Material_Number = M.Material_Number " + 
                    $" Where KR.Material_Number = {ClsFungsi.C2Q(Material_Number)} GROUP BY KR.Material_Number, M.Material_Description, KR.Tgl, KR.Management_ID, KR.Management_Type, KR.Terima, KR.Keluar, KR.Stock, MMD.Sloc, " + 
                    " KR.Reservation_Code, KR.PO_RO, KR.WorkOrder " + 
                    " Order By KR.Material_Number asc, KR.Tgl desc ";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataTable GetALLKartuRayon()
        {
            query = $"Select KR.Material_Number, M.Material_Description, KR.Tgl, KR.Management_ID, KR.Management_Type, KR.Terima, KR.Keluar, KR.Stock, MMD.Sloc, " +
                    " KR.Reservation_Code, KR.PO_RO, KR.WorkOrder from WareHouseMS.dbo.TblKartuRayon KR left join WareHouseMS.dbo.MManagement_Detail MMD " +
                    " on KR.Management_ID = MMD.Management_ID and KR.Material_Number = MMD.Material_Number and KR.Sloc = MMD.Sloc left join WareHouseMS.dbo.Material M " +
                    " on KR.Material_Number = M.Material_Number and MMD.Material_Number = M.Material_Number " +
                    $" GROUP BY KR.Material_Number, M.Material_Description, KR.Tgl, KR.Management_ID, KR.Management_Type, KR.Terima, KR.Keluar, KR.Stock, MMD.Sloc, " +
                    " KR.Reservation_Code, KR.PO_RO, KR.WorkOrder " +
                    " Order By KR.Material_Number asc, KR.Tgl desc";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        //public DataTable GetALLKartuRayon(DateTime start, DateTime End)
        //{
        //    query = $"Select KR.Material_Number, M.Material_Description, KR.Tgl, KR.Management_ID, KR.Management_Type, KR.Terima, KR.Keluar, KR.Stock, MMD.Sloc, " +
        //            " KR.Reservation_Code, KR.PO_RO, KR.WorkOrder from WareHouseMS.dbo.TblKartuRayon KR left join WareHouseMS.dbo.MManagement_Detail MMD " +
        //            " on KR.Management_ID = MMD.Management_ID and KR.Material_Number = MMD.Material_Number left join WareHouseMS.dbo.Material M " +
        //            $" on KR.Material_Number = M.Material_Number and MMD.Material_Number = M.Material_Number Where KR.Tgl >= {ClsFungsi.C2Q()}" +
        //            $" GROUP BY KR.Material_Number, M.Material_Description, KR.Tgl, KR.Management_ID, KR.Management_Type, KR.Terima, KR.Keluar, KR.Stock, MMD.Sloc, " +
        //            " KR.Reservation_Code, KR.PO_RO, KR.WorkOrder " +
        //            " Order By KR.Material_Number asc, KR.Tgl desc";
        //    return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        //}

        #endregion

        #region forSlocBin
        // getSlocBinDetails
        // InsertSlocBinDetails 
        public string InsertSlocBinDetails(List<ClsSlocBinDetail> listSlocBinDetail)
        {
            try
            {
                foreach(ClsSlocBinDetail SlocBinDetail in listSlocBinDetail)
                {
                    query = "Insert Into WareHouseMS.dbo.SlocBinDetail  " + 
                            " (SlocBin, Management_ID, Management_Type, Tgl, Material_Number, Qty, Base_Unit, Area, Equipment, Sloc) " + 
                            " values " + 
                            $" ({ClsFungsi.C2Q(SlocBinDetail.SlocBin)}, {ClsFungsi.C2Q(SlocBinDetail.ManagementID)}, {ClsFungsi.C2Q(SlocBinDetail.ManagementType)}, {ClsFungsi.C2QTime(SlocBinDetail.tgl)}, {ClsFungsi.C2Q(SlocBinDetail.MaterialNumber)}, {ClsFungsi.C2Q(SlocBinDetail.Qty)}, {ClsFungsi.C2Q(SlocBinDetail.BaseUnit)}, {ClsFungsi.C2Q(SlocBinDetail.Area)}, {ClsFungsi.C2Q(SlocBinDetail.Equipment)}, {ClsFungsi.C2Q(SlocBinDetail.Sloc)})";
                    ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                }
                return "Data SlocBinDetail Berhasil ditambah !";
            }
            catch (Exception e)
            {
                return "Data SlocBinDetail gagal untuk ditambah ! , error Message = " + e.Message; 
            }
        }

        public string UpdateorDeleteSlocBinDetails(List<ClsSlocBinDetail> listSlocBinDetail)
        {
            try
            {
                foreach (ClsSlocBinDetail SlocBinDetail in listSlocBinDetail)
                {
                    if(SlocBinDetail.Qty != 0) {
                        if (this.checkStokSpecially(SlocBinDetail) == "Update")
                        {
                            query = "Update WareHouseMS.dbo.SlocBinDetail " +
                                    $" set Qty = { ClsFungsi.C2Q(this.getOriQtyofaSlocBinDetail(SlocBinDetail.SlocBin, SlocBinDetail.MaterialNumber, SlocBinDetail.ManagementID, SlocBinDetail.Sloc) - SlocBinDetail.Qty)} where Material_Number = {ClsFungsi.C2Q(SlocBinDetail.MaterialNumber)} and SlocBin = {ClsFungsi.C2Q(SlocBinDetail.SlocBin)} and Management_ID = {ClsFungsi.C2Q(SlocBinDetail.ManagementID)} and Sloc = {ClsFungsi.C2Q(SlocBinDetail.Sloc)}" ;
                            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                        }
                        else if (this.checkStokSpecially(SlocBinDetail) == "Delete")
                        {
                            query = $"Delete WareHouseMS.dbo.SlocBinDetail where Material_Number = {ClsFungsi.C2Q(SlocBinDetail.MaterialNumber)} and SlocBin = {ClsFungsi.C2Q(SlocBinDetail.SlocBin)} and Management_ID = {ClsFungsi.C2Q(SlocBinDetail.ManagementID)} and Sloc = {ClsFungsi.C2Q(SlocBinDetail.Sloc)}";
                            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                            //query = $"Delete WareHouseMS.dbo.Material_Alocation  where Management_ID = {ClsFungsi.C2Q(SlocBinDetail.ManagementID)} and Material_Number = {ClsFungsi.C2Q(SlocBinDetail.MaterialNumber)} and SlocBin = {ClsFungsi.C2Q(SlocBinDetail.SlocBin)}";
                            //ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                        }
                    }

                }
                return "Data SlocBinDetail Berhasil diubah / dihapus !";
            }
            catch (Exception e)
            {
                return "Data SlocBinDetail gagal untuk diubah / dihapus ! , error Message = " + e.Message;
            }
        }

        public void DeleteAllSlocBinDetails (string ManagementID)
        {
            query = $" Delete WareHouseMS.dbo.SlocBinDetail where Management_ID = {ClsFungsi.C2Q(ManagementID)} ";
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public string UpdateorDeleteAllocation(DataGridView dgv)
        {
            try
            {
                foreach(DataGridViewRow row in dgv.Rows)
                {
                    if (Convert.ToDecimal(row.Cells["QtyAlokasi"].Value) - Convert.ToDecimal(row.Cells["Qty"].Value) > 0)
                    {
                        // Update
                        decimal sisa = Convert.ToDecimal(row.Cells["QtyAlokasi"].Value.ToString()) - Convert.ToDecimal(row.Cells["Qty"].Value.ToString());
                        UpdateMaterialAllocation(row.Cells["Management_ID"].Value.ToString(), row.Cells["MaterialNumber"].Value.ToString(), row.Cells["Reference"].Value.ToString(), sisa, row.Cells["Sloc"].Value.ToString());
                    }
                    else if (Convert.ToDecimal(row.Cells["QtyAlokasi"].Value) - Convert.ToDecimal(row.Cells["Qty"].Value) == 0)
                    {
                        // Delete 
                        this.DeleteMaterialAllocation(row.Cells["Management_ID"].Value.ToString(), row.Cells["MaterialNumber"].Value.ToString(), row.Cells["Reference"].Value.ToString(), row.Cells["Sloc"].Value.ToString());
                    }
                }
                return "Data Alokasi Berhasil diubah / dihapus !";
            }
            catch (Exception e)
            {
                return "Data Alokasi gagal untuk diubah / dihapus ! , error Message = " + e.Message;
            }
        }

        public void UpdateMaterialAllocation (string ManagementID, string MaterialNumber, string Reference, decimal Qty, string Sloc)
        {
            query = "Update WareHouseMS.dbo.Material_Alocation " +
                    $" set Qty = {ClsFungsi.C2Q(Qty)} where Management_ID = {ClsFungsi.C2Q(ManagementID)} and Material_Number = {ClsFungsi.C2Q(MaterialNumber)} and Reference = {ClsFungsi.C2Q(Reference)} and Sloc = {ClsFungsi.C2Q(Sloc)}";
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public void DeleteMaterialAllocation (string ManagementID, string MaterialNumber, string Reference, string Sloc)
        {
            query = "Delete WareHouseMS.dbo.Material_Alocation " +
                    $" where Management_ID = {ClsFungsi.C2Q(ManagementID)} and Material_Number = {ClsFungsi.C2Q(MaterialNumber)} and Reference = {ClsFungsi.C2Q(Reference)} and Sloc = {ClsFungsi.C2Q(Sloc)}";
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public void DeleteMaterialAllocation(string ManagementID)
        {
            query = "Delete WareHouseMS.dbo.Material_Alocation " +
                    $" where Management_ID = {ClsFungsi.C2Q(ManagementID)}";
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public decimal getOriQtyofaSlocBinDetail (string SlocBin, string Material_Number, string ManagementID, string Sloc)
        {
            query = $"Select Qty from WareHouseMS.dbo.SlocBinDetail where SlocBin = {ClsFungsi.C2Q(SlocBin)} and Material_Number = {ClsFungsi.C2Q(Material_Number)} and Management_ID = {ClsFungsi.C2Q(ManagementID)} and Sloc = {ClsFungsi.C2Q(Sloc)}";
            return Convert.ToDecimal(ClsStaticVariables.objConnection.objsqlconnection.ExecuteScalar2(query));
        }

        public string checkStokSpecially(ClsSlocBinDetail objSlocBinDetail)
        {
            string next = "";
            decimal qtySlocBin = this.getSlocbinDetailQtyofaMaterial(objSlocBinDetail.SlocBin, objSlocBinDetail.MaterialNumber, objSlocBinDetail.ManagementID, objSlocBinDetail.Sloc);
            if (qtySlocBin - objSlocBinDetail.Qty > 0)
            {
                next = "Update";
                return next;
            }
            else if(qtySlocBin - objSlocBinDetail.Qty == 0)
            {
                next = "Delete";
                return next;
            }
            return "";
        }

        public DataTable SearchMaterial (string MaterialNumber)
        {
            query = " Select SBD.SlocBin, SBD.Tgl, SBD.Material_Number, M.Material_Description, SBD.Qty, SBD.Base_Unit," + 
                    " SBD.Area, SBD.Equipment, SBD.Management_Type, SBD.Management_ID from WareHouseMS.dbo.SlocBinDetail as SBD " +
                    " left join WareHouseMS.dbo.Material as M " + 
                    " on SBD.Material_Number = M.Material_Number " + 
                    $" where SBD.Material_Number = {ClsFungsi.C2Q(MaterialNumber)} Order By Tgl";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        // cek stok generally 
        public bool checkStokGenerally(List<ClsSlocBinDetail> listSlocBinDetail)
        {
            bool next = true; 
            foreach(ClsSlocBinDetail SlocBinDetail in listSlocBinDetail)
            {
                decimal qtySlocBin = this.getSlocbinDetailQtyofaMaterial(SlocBinDetail.SlocBin, SlocBinDetail.MaterialNumber, SlocBinDetail.ManagementID);
                if(qtySlocBin - SlocBinDetail.Qty < 0)
                {
                    next = false;
                    return next;
                }
            }
            return next;
        }

        public bool checkStokGenerally(DataGridView dgv)
        {
            bool next = true;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                
                if ( Convert.ToDecimal(row.Cells["QtyAlokasi"].Value) - Convert.ToDecimal(row.Cells["Qty"].Value) < 0)
                {
                    next = false;
                    return next;
                }
            }
            return next;
        }

        // cek count material number per slocbin 
        public string cekSlocBinCount(string SlocBinID)
        {
            query = "Select Count(Material_Number) from WareHouseMS.dbo.SlocBinDetail where SlocBIn = " + ClsFungsi.C2Q(SlocBinID);
            int count = Convert.ToInt32(ClsStaticVariables.objConnection.objsqlconnection.ExecuteScalar2(query));
            if(count > 0)
            {
                return "Available";
            }
            else
            {
                return "Empty";
            }
        }

        public decimal getSlocbinDetailQtyofaMaterial(string SlocBinID, string MaterialNumber, string ManagementID)
        {
            query = $" Select Qty from WareHouseMS.dbo.SlocBinDetail where SlocBin = {ClsFungsi.C2Q(SlocBinID)} and Material_Number = {ClsFungsi.C2Q(MaterialNumber)} and Management_ID = " + ClsFungsi.C2Q(ManagementID);
            return Convert.ToDecimal(ClsStaticVariables.objConnection.objsqlconnection.ExecuteScalar2(query));
        }

        public decimal getSlocbinDetailQtyofaMaterial(string SlocBinID, string MaterialNumber, string ManagementID, string Sloc)
        {
            query = $" Select Qty from WareHouseMS.dbo.SlocBinDetail where SlocBin = {ClsFungsi.C2Q(SlocBinID)} and Material_Number = {ClsFungsi.C2Q(MaterialNumber)} and Management_ID = " + ClsFungsi.C2Q(ManagementID) + "and Sloc = " + ClsFungsi.C2Q(Sloc);
            return Convert.ToDecimal(ClsStaticVariables.objConnection.objsqlconnection.ExecuteScalar2(query));
        }

        public decimal getSlocbinDetailQtyofaMaterial(string SlocBinID, string MaterialNumber)
        {
            query = $" Select Qty from WareHouseMS.dbo.SlocBinDetail where SlocBin = {ClsFungsi.C2Q(SlocBinID)} and Material_Number = {ClsFungsi.C2Q(MaterialNumber)}";
            return Convert.ToDecimal(ClsStaticVariables.objConnection.objsqlconnection.ExecuteScalar2(query));
        }

        // Update SlocBinStatus
        public string UpdateSlocBinStatus (string SlocBin, string Sloc, bool isfull, bool available, bool isempty)
        {
            try
            {
                query = "Update WareHouseMS.dbo.SlocBin " +
                        $" set Sloc = {ClsFungsi.C2Q(Sloc)} , Is_Full = {ClsFungsi.C2Q(isfull)}, Still_Available = {ClsFungsi.C2Q(available)}, Is_Empty = {ClsFungsi.C2Q(isempty)} " +
                        $" where SlocBin = {ClsFungsi.C2Q(SlocBin)}";
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                return "Status SlocBin Berhasil diubah";
            }
            catch(Exception e)
            {
                return "Status SlocBin Gagal untukdiubah";
            }
        }
            // UpdateSloceBinDetails 
            // Delete AllSlocBinDetails 

        #endregion

        // Update Qty Material 
        public string UpdateQtyMaterials (List<ClsKartuRayon> listKartuRaYON)
        {
            try
            {
                foreach (ClsKartuRayon kartuRayon in listKartuRaYON)
                {
                    
                }
                return "Data Material Berhasil ditambah ! ";
            }
            catch(Exception e)
            {
                return "Qty Material Gagal Untuk Ditambah ! error Message = " + e.Message; 
            }
        }

        public DataTable getOneMaterial(string MaterialNumber)
        {
            query = "Select * from WareHouseMS.dbo.Material where Material_Number = " + ClsFungsi.C2Q(MaterialNumber) + " and Status = 1";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataTable getSlocBinDetails (string SlocBinID)
        {
            query = "Select SBD.Sloc, SBD.SlocBin, SBD.Tgl, SBD.Management_ID, SBD.Material_Number, M.Material_Description, isnull(TTD.ItemTitipan, '-') as itemTitipan, SBD.Qty, " + 
                    " MA.Qty as QtyAlokasi, MA.Reference, SBD.Base_Unit,  SBD.Area, SBD.Equipment, SBD.SlocBin as Lokasi , SBD.Management_ID , M.FilePath " + 
                    " from WareHouseMS.dbo.SlocBinDetail as SBD left join WareHouseMS.dbo.Material as M " + 
                    " on SBD.Material_Number = M.Material_Number left join WareHouseMS.dbo.MManagement_Detail MMD " +
                    " on SBD.Management_ID = MMD.Management_ID and SBD.Material_Number = MMD.Material_Number and SBD.Sloc = MMD.Sloc" + 
                    " left join WareHouseMS.dbo.Material_Alocation MA " +
                    " on SBD.Management_ID = MA.Management_ID and SBD.Material_Number = MA.Material_Number and MMD.Management_ID = MA.Management_ID and SBD.Sloc = MA.Sloc" +
                    " left join WareHouseMS.dbo.TblTitipanDetail as TTD on SBD.Material_Number = TTD.Material_Number and SBD.Management_ID = TTD.Titipan_ID and TTD.Sloc = SBD.Sloc " + 
                    $" where SBD.SlocBin = {ClsFungsi.C2Q(SlocBinID)}";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataTable getSlocBinDetails2(string MaterialNumber)
        {
            query = "Select MMD.Sloc, SBD.SlocBin, SBD.Tgl, SBD.Management_ID, SBD.Material_Number, M.Material_Description,  SBD.Qty, " +
                    " MA.Qty as QtyAlokasi, MA.Reference, SBD.Base_Unit,  SBD.Area, SBD.Equipment, SBD.SlocBin as Lokasi , SBD.Management_ID , M.FilePath " +
                    " from WareHouseMS.dbo.SlocBinDetail as SBD left join WareHouseMS.dbo.Material as M " +
                    " on SBD.Material_Number = M.Material_Number left join WareHouseMS.dbo.MManagement_Detail MMD " +
                    " on SBD.Management_ID = MMD.Management_ID and SBD.Material_Number = MMD.Material_Number and SBD.Sloc = MMD.Sloc" +
                    " left join WareHouseMS.dbo.Material_Alocation MA " +
                    " on SBD.Management_ID = MA.Management_ID and SBD.Material_Number = MA.Material_Number and MMD.Management_ID = MA.Management_ID and SBD.Sloc = MA.Sloc" +
                    $" where SBD.Management_Type = 'Entry' and SBD.Material_Number = {ClsFungsi.C2Q(MaterialNumber)}";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataTable getSlocBinDetails2()
        {
            query = "Select MMD.Sloc, SBD.SlocBin, SBD.Tgl, SBD.Management_ID, SBD.Material_Number, M.Material_Description,  SBD.Qty, " +
                    " MA.Qty as QtyAlokasi, MA.Reference, SBD.Base_Unit,  SBD.Area, SBD.Equipment, SBD.SlocBin as Lokasi , SBD.Management_ID , M.FilePath " +
                    " from WareHouseMS.dbo.SlocBinDetail as SBD left join WareHouseMS.dbo.Material as M " +
                    " on SBD.Material_Number = M.Material_Number left join WareHouseMS.dbo.MManagement_Detail MMD " +
                    " on SBD.Management_ID = MMD.Management_ID and SBD.Material_Number = MMD.Material_Number and SBD.Sloc = MMD.Sloc" +
                    " left join WareHouseMS.dbo.Material_Alocation MA " +
                    " on SBD.Management_ID = MA.Management_ID and SBD.Material_Number = MA.Material_Number and MMD.Management_ID = MA.Management_ID and SBD.Sloc = MA.Sloc" +
                    $" where SBD.Management_Type = 'Entry'";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public string getSloc (string SlocBinID)
        {
            query = "Select Sloc from WareHouseMS.dbo.SlocBin where SlocBin = " + ClsFungsi.C2Q(SlocBinID);
            return ClsStaticVariables.objConnection.objsqlconnection.ExecuteScalar(query);
        }

        public string cekStatusSlocBin (string SlocBinID)
        {
            query = "Select * from WareHouseMS.dbo.SlocBin where SlocBin = " + ClsFungsi.C2Q(SlocBinID);
            dt = ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            if(Convert.ToBoolean(dt.Rows[0]["Is_Full"].ToString()))
            {
                return "Full";
            }
            else if(Convert.ToBoolean(dt.Rows[0]["Still_Available"].ToString()))
            {
                return "Available";
            }
            else
            {
                return "Empty";
            }
        }

        public DataTable getFullMaterialInfo(string SlocBin)
        {
            query = "Select SB.Sloc, SBD.SlocBin, SBD.Management_ID, SBD.Management_Type, SBD.Material_Number , M.Material_Description, SBD.Tgl, SBD.Qty, " +
                    " SBD.Base_Unit, SBD.Area, SBD.Equipment, MM.Reservation_Code, MM.PO_RO, MM.WorkOrder " +
                    " from WareHouseMS.dbo.SlocBinDetail as SBD left join WareHouseMS.dbo.SlocBin as SB on SBD.SlocBin = SB.SlocBin " +
                    " left join WareHouseMS.dbo.Material as M on SBD.Material_Number = M.Material_Number " + 
                    " left join WareHouseMS.dbo.Material_Management as MM on SBD.Management_ID = MM.Management_ID " +
                    $" where SBD.SlocBin = {ClsFungsi.C2Q(SlocBin)} ";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataSet LoadMaterialRequest(string ManagementID)
        {
            query = "Select MM.*, MMD.*, M.Material_Description, M.Value from WareHouseMS.dbo.Material_Management as MM " +
                    " left join WareHouseMS.dbo.MManagement_Detail as MMD on MM.Management_ID = MMD.Management_ID " +
                    " left join WareHouseMS.dbo.Material as M on MMD.Material_Number = M.Material_Number " +
                    $" where MM.Management_ID = {ClsFungsi.C2Q(ManagementID)}";
            dt = ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            DataSet ds = new DataSet();
            DataTable MMjoinDetail = new DataTable();
            MMjoinDetail = dt;
            MMjoinDetail.TableName = "MMJoinMMD";
            ds.Tables.Add(MMjoinDetail);
            return ds;
        }

        public DataSet LoadTitipan(string ManagementID, string value)
        {
            query = "Select TT.Titipan_ID as Management_ID, Management_Type = 'Titip', TT.Tgl as Tgl_Dibuat, TT.Reference as Reservation_Code, PO_RO = '' , WorkOrder = '', " + 
                    " TT.Nama_PenanggungJawab, UserID = '' , Management_ID1 = '' , TTD.NoUrut, TTD.Material_Number, " + 
                    " TTD.Qty, Base_Unit = '' , TTD.ItemTitipan as Material_Description, TTD.Note as Value from WareHouseMS.dbo.TblTitipan TT left " + 
                    " join WareHouseMS.dbo.TblTitipanDetail TTD " + 
                    $" on TT.Titipan_ID = TTD.Titipan_ID where TT.Titipan_ID = {ClsFungsi.C2Q(ManagementID)} and TTD.Status = {ClsFungsi.C2Q(value)}" ;
            dt = ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            DataSet ds = new DataSet();
            DataTable MMjoinDetail = new DataTable();
            MMjoinDetail = dt;
            MMjoinDetail.TableName = "MMJoinMMD";
            ds.Tables.Add(MMjoinDetail);
            return ds;
        }

        public DataSet LoadMaterialAllocationGlobal()
        {
            query = "Select SBD.SlocBin, SBD.Management_ID, SBD.Material_Number, M.Material_Description, SBD.Tgl, " + 
                    " IIF(MA.Reference = 'z~Free Stock', 'Free Stock', MA.Reference) as Reference  , " + 
                    " M.Qty as LastStock, MA.Sloc as Qty_SBD, ISNULL(MA.Qty, 0) as Qty_Alokasi " + 
                    " from WareHouseMS.dbo.Material_Alocation as MA left join WareHouseMS.dbo.SlocBinDetail as SBD " + 
                    " on MA.Management_ID = SBD.Management_ID and MA.Material_Number = SBD.Material_Number left join " + 
                    " Material as M on SBD.Material_Number = M.Material_Number and MA.Material_Number = SBD.Material_Number " + 
                    " Where SBD.Management_Type = 'Entry'  group by MA.Qty , SBD.SlocBin,  SBD.Management_ID, SBD.Material_Number, " + 
                    " M.Material_Description, SBD.Tgl,  ISNULL(MA.Reference, 'Free Stock'),  M.Qty , MA.Reference , MA.Sloc " +  
                    " Order By Material_Number asc, MA.Reference asc, SBD.Management_ID, SBD.Tgl  ";
            dt = ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            DataSet ds = new DataSet();
            DataTable MMjoinDetail = new DataTable();
            MMjoinDetail = dt;
            MMjoinDetail.TableName = "Allocation";
            ds.Tables.Add(MMjoinDetail);
            return ds;
        }

        #region Gudang

        public DataTable getAllGudang()
        {
            query = "Select * from WareHouseMS.dbo.TblGudang Order By NoUrut";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataTable getAllGudang(string option1, string option2)
        {
            query = $"Select * from WareHouseMS.dbo.TblGudang Where GudangID like {ClsFungsi.C2Q( option1+"%")} or GudangID like {ClsFungsi.C2Q( option2+"%" )} Order By NoUrut";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataTable getAllRakHeader(string GudangID)
        {
            query = "Select * from WareHouseMS.dbo.TblRakHeader where GudangID = " + ClsFungsi.C2Q(GudangID);
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        #endregion

        #region fortitipan

        public DataTable getAlltitipan ()
        {
            query = "Select * from WareHouseMS.dbo.TblTitipan Order By Titipan_ID desc ";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataTable getAlltitipanDetail(string ID)
        {
            query = "  Select TT.Titipan_ID, TT.SlocBin, TTD.Material_Number, TTD.ItemTitipan, TTD.Qty, TTD.Note, TTD.Status " +
                    " from WareHouseMS.dbo.TblTitipan as TT left join WareHouseMS.dbo.TblTitipanDetail as TTD " +
                    $" on TT.Titipan_ID = TTD.Titipan_ID where TT.Titipan_ID = {ClsFungsi.C2Q(ID)} ";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public string InsertTitipan(ClsTitipan objTitip)
        {
            query = "  Insert WareHouseMS.dbo.TblTitipan  " + 
                    " (Titipan_ID, Reference, Nama_PenanggungJawab, Note, SlocBin, Tgl, Status) " + 
                    " Values " + 
                    $" ({ClsFungsi.C2Q(objTitip.TitipanID)}, {ClsFungsi.C2Q(objTitip.Reference)}, {ClsFungsi.C2Q(objTitip.NamaPenanggungJawab)}, {ClsFungsi.C2Q(objTitip.Note)}, {ClsFungsi.C2Q(objTitip.SlocBin)}, {ClsFungsi.C2Q(objTitip.Tgl)}, {ClsFungsi.C2Q(objTitip.Status)})";
            try
            {
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                return "Penambahan Data Titipan Berhasil Dilakukan !";
            }
            catch (Exception e)
            {
                //Delete Management ID
                //string tmp = this.DeleteManagement(objManagement.ManagementID);
                return "Penambahan Data Titipan gagal dilakukan ! , error Message = " + e.Message;
            }
        }

        public string InsertTitipanDetail(List<CLsTitipanDetail> listtitip)
        {
            try
            {
                foreach (CLsTitipanDetail titip  in listtitip)
                {
                    query = " Insert WareHouseMS.dbo.TblTitipanDetail " + 
                            " (NoUrut, Titipan_ID, Material_Number, ItemTitipan, Qty, Note, Status, Sloc) " + 
                            " values " + 
                            $" ({ClsFungsi.C2Q(titip.NoUrut)}, {ClsFungsi.C2Q(objTitip.TitipanID)}, {ClsFungsi.C2Q(titip.MaterialNumber)}, {ClsFungsi.C2Q(titip.ItemTitipan)}, {ClsFungsi.C2Q(titip.Qty)}, {ClsFungsi.C2Q(titip.Note)}, {ClsFungsi.C2Q(titip.Status)}, {ClsFungsi.C2Q(titip.Sloc)})";
                    ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                }
                return "Data titipan detail Berhasil ditambah !";
            }
            catch (Exception e)
            {
                return "Data titipan detail gagal untuk ditambah ! , error Message = " + e.Message;
            }
        }

        public void UpdateStatusTitipan(string titipanID)
        {
            query = $" Update WareHouseMS.dbo.TblTitipan set Status = 'Done' where Titipan_ID = {ClsFungsi.C2Q(titipanID)}";
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public void UpdateStatusTitipanDetail (string Material_Number, string titipanID, string Sloc)
        {
            query = $" Update WareHouseMS.dbo.TblTitipanDetail set Status = 'Done' where Titipan_ID = {ClsFungsi.C2Q(titipanID)}  and Material_Number = {ClsFungsi.C2Q(Material_Number)} and Sloc = {ClsFungsi.C2Q(Sloc)}";
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public void DeleteTitipn(string TitipanID, string SlocBin, string Material_Number, string Sloc)
        {
            query = $" Delete WareHouseMS.dbo.SlocBinDetail where Management_ID = {ClsFungsi.C2Q(TitipanID)} and SlocBin = {ClsFungsi.C2Q(SlocBin)} and Material_Number = {ClsFungsi.C2Q(Material_Number)} and Sloc = {ClsFungsi.C2Q(Sloc)}" ;
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public void UpdateStatusMaterialRequest (List<Tuple<string, string>> listData, string Status)
        {
            foreach(Tuple<string, string> item in listData)
            {
                query = "Update WareHouseMS.dbo.MManagement_Detail " + 
                        $" set Status = {ClsFungsi.C2Q(Status)} where Management_ID = {ClsFungsi.C2Q(item.Item1)} and Material_Number = {ClsFungsi.C2Q(item.Item2)}";
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
            }
        }

        public bool CekMaterialRequestMainStatus (string Management_ID)
        {
            query = $" Select Status from WareHouseMS.dbo.MManagement_Detail where Management_ID = {ClsFungsi.C2Q(Management_ID)}";
            dt = ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            bool done = true;
            foreach (DataRow row in dt.Rows)
            {
                if(row["Status"].ToString() == "Problem")
                {
                    done = false;
                    break;
                }
            }
            return done;
        }

        public void UpdateMaterialRequestMianstatus (string Management_ID, string Status)
        {
            query = $" Update WareHouseMS.dbo.Material_Management set Status = {ClsFungsi.C2Q(Status)} where Management_ID = {ClsFungsi.C2Q(Management_ID)}";
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public DataTable LoadAllMaterialManagement (string type, DateTime start, DateTime End)
        {
            query = "Select MM.Management_ID, MM.Management_Type , MM.Tgl_Dibuat, MM.Reservation_Code, MM.PO_RO, MM.WorkOrder, " + 
                    " MMD.No_Urut, MMD.Material_Number, M.Material_Description, MMD.Qty, MMD.Base_Unit, " +
                    " MMD.Sloc, ISNULL(SBD.SlocBin, '-') as SlocBin , MMD.Status as [Status Material], ISNULL(MMD.Reference, '-') as Reference, MM.Nama_PenanggungJawab, " +
                    " ISNULL(MM.Status,'-') as [Status Transaksi] from WareHouseMS.dbo.Material_Management MM " + 
                    " left join WareHouseMS.dbo.MManagement_Detail MMD on MM.Management_ID = MMD.Management_ID " + 
                    " left join WareHouseMS.dbo.Material M on MMD.Material_Number = M.Material_Number left join " + 
                    " SlocBinDetail SBD on SBD.Management_ID = MMD.Management_ID and SBD.Material_Number = MMD.Material_Number " + 
                    $" where MM.Tgl_Dibuat >= {ClsFungsi.C2QTime(start)} and MM.Tgl_Dibuat <= {ClsFungsi.C2QTime(End)} and MM.Management_Type like {ClsFungsi.C2Q(type)} " + 
                    " Order By MM.Management_Type, MM.Management_ID , MMD.No_Urut";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public bool cekTitipanDiSlocBIn (string titipan_ID)
        {
            query = $" Select * from WareHouseMS.dbo.TblTitipanDetail where Titipan_ID = {ClsFungsi.C2Q(titipan_ID)}";
            dt = ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            foreach(DataRow row in dt.Rows)
            {
                if(row["Status"].ToString() == "OnProcess")
                {
                    return false;
                }
            }
            return true;
        }

        #endregion
    }
}
