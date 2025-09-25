using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    public class ClsKartuRayon
    {

        #region properties

        public string MaterialNumber { get; set; }
        public DateTime Tgl{ get; set; }
        public string ManagementId { get; set; }
        public string ManagementType { get; set; }
        public string ReservationCode { get; set; }
        public string PO_RO { get; set; }
        public string WorkOrder { get; set; }
        public decimal Terima { get; set; }
        public decimal Keluar { get; set; }
        public decimal Stokc { get; set; }
        public decimal DepositMasuk { get; set; }
        public decimal DepositKeluar { get; set; }
        public decimal StokcTitipan { get; set; }
        public string Note { get; set; }
        public decimal Value { get; set; }
        public string Sloc { get; set; }

        #endregion

        #region constructor

        public ClsKartuRayon()
        {

        }

        public ClsKartuRayon(string MaterialNumber, DateTime Tgl, string ManagementId, string ManagementType, string reservationcode, string PORO, string WorkOrder, decimal terima, decimal keluar, decimal stokc, decimal depositmasuk , decimal depositkeluar, decimal stoktitipan, string note)
        {
            this.MaterialNumber = MaterialNumber;
            this.Tgl = Tgl;
            this.ManagementId = ManagementId;
            this.ManagementType = ManagementType;
            this.ReservationCode = reservationcode;
            this.PO_RO = PORO;
            this.WorkOrder = WorkOrder;
            this.Terima = terima;
            this.Keluar = keluar;
            this.Stokc = stokc;
            this.DepositMasuk = depositmasuk;
            this.DepositKeluar = depositkeluar;
            this.StokcTitipan = stoktitipan;
            this.Note = note;
        }

        public ClsKartuRayon(string MaterialNumber, DateTime Tgl, string ManagementId, string ManagementType, string reservationcode, string PORO, string WorkOrder, decimal terima, decimal keluar, decimal stokc, decimal depositmasuk, decimal depositkeluar, decimal stoktitipan, string note, decimal Value, string Sloc)
        {
            this.MaterialNumber = MaterialNumber;
            this.Tgl = Tgl;
            this.ManagementId = ManagementId;
            this.ManagementType = ManagementType;
            this.ReservationCode = reservationcode;
            this.PO_RO = PORO;
            this.WorkOrder = WorkOrder;
            this.Terima = terima;
            this.Keluar = keluar;
            this.Stokc = stokc;
            this.DepositMasuk = depositmasuk;
            this.DepositKeluar = depositkeluar;
            this.StokcTitipan = stoktitipan;
            this.Note = note;
            this.Value = Value;
            this.Sloc = Sloc;
        }
        #endregion

    }
}
