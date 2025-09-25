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

namespace Master.Controller
{
    public class ControllerUser
    {
        #region properties

        public ClsUser objUser = new ClsUser();
        public ClsUser other = new ClsUser();
        public string query;
        public DataTable dt;
        

        #endregion

        #region Constructor 
        #endregion

        #region function

        public ClsUser getOneUser(string UserID, string Password)
        {
            query = "Select * From TblUser where UserID = " + ClsFungsi.C2Q(UserID);
            try
            {
                dt = ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
                if(dt.Rows.Count != 0)
                {
                    return new ClsUser(dt.Rows[0]["UserID"].ToString(), dt.Rows[0]["UserName"].ToString(), dt.Rows[0]["Password"].ToString(), dt.Rows[0]["HakAkses"].ToString());
                }
                else
                {
                    return new ClsUser();
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        public DataTable getListHakAkses ()
        {
            query = "Select * From TblHakAkses where HakAkses != 'superadmin'";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataTable getListHakAksesB()
        {
            query = "Select * From TblHakAkses";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public DataTable getListUser ()
        {
            query = "Select * From TblUSer";
            return ClsStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
        }

        public void InsertUser(ClsUser user)
        {
            query = "Insert into TblUser(UserID,UserName,Password,HakAkses) " +
                    $" values({ClsFungsi.C2Q(user.UserID)}, {ClsFungsi.C2Q(user.UserName)}, {ClsFungsi.C2Q(user.Password)}, {ClsFungsi.C2Q(user.HakAkses)})";
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public void EditUser(ClsUser user)
        {
            query = "Update TblUser set " +
                    $"UserID = {ClsFungsi.C2Q(user.UserID)}, UserName = {ClsFungsi.C2Q(user.UserName)}, Password = {ClsFungsi.C2Q(user.Password)}, HakAkses = {ClsFungsi.C2Q(user.HakAkses)} " +
                    $"where UserID = {ClsFungsi.C2Q(user.UserID)} ";
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public void EditHakAksesonly (ClsUser user)
        {
            query = "Update TblUser set " +
                    $"HakAkses = {ClsFungsi.C2Q(user.HakAkses)} " +
                    $"where UserID = {ClsFungsi.C2Q(user.UserID)} ";
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public void DeleteUser(ClsUser user)
        {
            query = "Delete TblUser where UserID = " + ClsFungsi.C2Q(user.UserID);
            ClsStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        #endregion

    }
}
