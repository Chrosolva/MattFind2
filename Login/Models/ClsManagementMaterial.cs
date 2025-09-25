using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    public class ClsManagementMaterial
    {
        #region properties

        public string ManagementID { get; set; }
        public string ManagementType { get; set; }
        public DateTime TglDibuat { get; set; }
        public string ReservationCode { get; set; }
        public string PORO { get; set; }
        public string WorkOrder { get; set; }
        public string NamaPenganggungJawab { get; set; }
        public string UserID { get; set; }

        public List<ClsMMaterialDetail> listMMatsDetails;
        public string Status { get; set; }
        
        

        #endregion

        #region constructor

        public ClsManagementMaterial()
        {

        }

        public ClsManagementMaterial(string ManagementID, string ManagementType, DateTime TglDibuat, string Reservationcode, string PORO , string WorkOrder, string NamaPenganggungJawab, string UserID)
        {
            this.ManagementID = ManagementID;
            this.ManagementType = ManagementType;
            this.TglDibuat = TglDibuat;
            this.ReservationCode = Reservationcode;
            this.PORO = PORO;
            this.WorkOrder = WorkOrder;
            this.NamaPenganggungJawab = NamaPenganggungJawab;
            this.UserID = UserID;
        }
        
        public ClsManagementMaterial(string ManagementID, string ManagementType, DateTime TglDibuat, string Reservationcode, string PORO, string WorkOrder, string NamaPenganggungJawab, string UserID, string status)
        {
            this.ManagementID = ManagementID;
            this.ManagementType = ManagementType;
            this.TglDibuat = TglDibuat;
            this.ReservationCode = Reservationcode;
            this.PORO = PORO;
            this.WorkOrder = WorkOrder;
            this.NamaPenganggungJawab = NamaPenganggungJawab;
            this.UserID = UserID;
            this.Status = status;

        }


        public ClsManagementMaterial(string ManagementID, string ManagementType, DateTime TglDibuat, string Reservationcode, string PORO, string WorkOrder, string NamaPenganggungJawab, string UserID, List<ClsMMaterialDetail> listMMDetail)
        {
            this.ManagementID = ManagementID;
            this.ManagementType = ManagementType;
            this.TglDibuat = TglDibuat;
            this.ReservationCode = Reservationcode;
            this.PORO = PORO;
            this.WorkOrder = WorkOrder;
            this.NamaPenganggungJawab = NamaPenganggungJawab;
            this.UserID = UserID;
            this.listMMatsDetails = listMMDetail;
        }

        #endregion
    }
}
