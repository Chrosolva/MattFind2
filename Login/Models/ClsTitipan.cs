using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    public class CLsTitipanDetail
    {
        #region properties

        public int NoUrut { get; set; }
        public string MaterialNumber { get; set; }
        public string ItemTitipan { get; set; }
        public decimal Qty { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string Sloc { get; set; }

        #endregion

        public CLsTitipanDetail()
        {

        }

        public CLsTitipanDetail(int NoUrut, string MaterialNumber, string itemtitipan, decimal qty, string note)
        {
            this.NoUrut = NoUrut;
            this.MaterialNumber = MaterialNumber;
            this.ItemTitipan = itemtitipan;
            this.Qty = qty;
            this.Note = note;
        }

        public CLsTitipanDetail(int NoUrut, string MaterialNumber, string itemtitipan, decimal qty, string note, string Status)
        {
            this.NoUrut = NoUrut;
            this.MaterialNumber = MaterialNumber;
            this.ItemTitipan = itemtitipan;
            this.Qty = qty;
            this.Note = note;
            this.Status = Status;
        }

        public CLsTitipanDetail(int NoUrut, string MaterialNumber, string itemtitipan, decimal qty, string note, string Status, string Sloc)
        {
            this.NoUrut = NoUrut;
            this.MaterialNumber = MaterialNumber;
            this.ItemTitipan = itemtitipan;
            this.Qty = qty;
            this.Note = note;
            this.Status = Status;
            this.Sloc = Sloc;
        }
    }

    public class ClsTitipan
    {
        

        #region properties

        public string TitipanID { get; set; }
        public string Reference { get; set; }
        public string NamaPenanggungJawab { get; set; }
        public string Note { get; set; }
        public string SlocBin { get; set; }
        public DateTime Tgl { get; set; }
        public string Status { get; set; }
        public List<CLsTitipanDetail> listtitipandetail = new List<CLsTitipanDetail>();
        CLsTitipanDetail objtitipdet = new CLsTitipanDetail();

        

        #endregion

        #region constructor
        
        public ClsTitipan ()
        {

        }

        public ClsTitipan(string titipanID, string reference, string nama, string note, string SlocBin, DateTime Tgl, string Status)
        {
            this.TitipanID = titipanID;
            this.Reference = reference;
            this.NamaPenanggungJawab = nama;
            this.Note = note;
            this.SlocBin = SlocBin;
            this.Tgl = Tgl;
            this.Status = Status;
        }
        

        public ClsTitipan(string titipanID, string reference, string nama, string note, string SlocBin, DateTime tgl,  List<CLsTitipanDetail> listtitip)
        {
            this.TitipanID = titipanID;
            this.Reference = reference;
            this.NamaPenanggungJawab = nama;
            this.Note = note;
            this.SlocBin = SlocBin;
            this.listtitipandetail = listtitip;
            this.Tgl = tgl;
        }

        #endregion

    }
}
