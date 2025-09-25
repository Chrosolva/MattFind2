using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Master;

namespace WBPOS.Models
{
    public class ClsUser
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string HakAkses { get; set; }

        public ClsUser()
        {

        }

        public ClsUser(string UserID, string UserName, string Password, string HakAkses)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.HakAkses = HakAkses;
        }

        #region function

        public void EnkripsiPassword()
        {
            ClsCrypthography objCryptography = new ClsCrypthography();
            this.Password = objCryptography.EncryptString(Password);
        }

        public void DekripsiPassword()
        {
            ClsCrypthography objCryptography = new ClsCrypthography();
            this.Password = objCryptography.DecryptString(Password);
        }

        #endregion
    }
}
