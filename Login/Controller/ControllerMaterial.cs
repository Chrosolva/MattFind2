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
    public class ControllerMaterial
    {
        #region properties

        public string query;
        public DataTable dt;
        public DataTable othr;
        public DataRow dr;
        public ClsMaterial clsMaterial = new ClsMaterial();

        #endregion

        #region function

        public DataTable getAllMaterial()
        {
            query = "Select * from WareHouseMS.dbo.Material where Status = 1";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataTable getAllMaterialTitipan()
        {
            query = "Select * from WareHouseMS.dbo.Material where Status = 1 and Material_Number like '%Titipan%'";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        //Insert Data Material
        public string InsertMaterial(ClsMaterial objMaterial)
        {
            query = "Insert Into WareHouseMS.dbo.Material " + 
                    " (Material_Number, Material_Description, Qty, Base_Unit, Status, Value, Document_Header_Text, FilePath) " + 
                    " Values " + 
                    $" ({ClsFungsi.C2Q(objMaterial.MaterialNumber)}, {ClsFungsi.C2Q(objMaterial.MaterialDescription)}, {ClsFungsi.C2Q(objMaterial.Qty)}, {ClsFungsi.C2Q(objMaterial.BaseUnit)}, {ClsFungsi.C2Q(objMaterial.Status)}, {ClsFungsi.C2Q(objMaterial.Value)}, {ClsFungsi.C2Q(objMaterial.DocumentHeaderText)} , {ClsFungsi.C2Q(objMaterial.FilePath)})";
            try
            {
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                return "Data Material Berhasil ditambah !";
            }

            catch (Exception e)
            {
                return "Data Material Gagal ditambah , error message = " + e.Message;
            }
        }

        // Update Material 
        public string UpdateMaterial(ClsMaterial objMaterial)
        {
            query = "Update WareHouseMS.dbo.Material " +
                    $" set Material_Description = {ClsFungsi.C2Q(objMaterial.MaterialDescription)}, Qty = {ClsFungsi.C2Q(objMaterial.Qty)}, Base_Unit = {ClsFungsi.C2Q(objMaterial.BaseUnit)}, " +
                    $" Status = {ClsFungsi.C2Q(objMaterial.Status)}, Value = {ClsFungsi.C2Q(objMaterial.Value)}, Document_Header_Text = {ClsFungsi.C2Q(objMaterial.DocumentHeaderText ?? "")}, FilePath = {ClsFungsi.C2Q(objMaterial.FilePath)} " +
                    $" where Material_Number = {ClsFungsi.C2Q(objMaterial.MaterialNumber)}";
            try
            {
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                return "Data Material Berhasil di ubah !";
            }

            catch (Exception e)
            {
                return "Data Material gagal diubah , error message = " + e.Message;
            }
        }

        //Delete Material
        public string DeleteMaterial(string MaterialNumber)
        {
            query = "Delete WareHouseMS.dbo.Material where Material_Number = " + ClsFungsi.C2Q(MaterialNumber);
            try
            {
                ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                return "Data Material Number = " + MaterialNumber + " berhasil dihapus !";
            }
            catch (Exception e)
            {
                return "Data Material Number = " + MaterialNumber + "  Gagal untuk dihapus, error Message = " + e.Message;
            }
        }

        public void GetOneMaterial (string MaterialNumber)
        {
            query = "Select * from WareHouseMS.dbo.Material where Material_Number = " + ClsFungsi.C2Q(MaterialNumber) +  " and Status = 1";
            dt = ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            string tmp = dt.Rows[0]["Status"].ToString();
            if(tmp == "1")
            {
                tmp = "true";
            }
            else
            {
                tmp = "false";
            }
            clsMaterial = new ClsMaterial(dt.Rows[0]["Material_Number"].ToString(), dt.Rows[0]["Material_Description"].ToString(), Convert.ToDecimal(dt.Rows[0]["Qty"].ToString()), dt.Rows[0]["Base_Unit"].ToString(), Convert.ToBoolean(tmp), Convert.ToDecimal(dt.Rows[0]["Value"].ToString()), dt.Rows[0]["Document_Header_Text"].ToString(), dt.Rows[0]["FilePath"].ToString());
        }

        #endregion
    }
}
