using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Master
{
    public class ClsFungsi
    {
        /// <summary>
        /// untuk mengubah data menjadi string
        /// </summary>
        /// <param name="xVar">data masukan</param>
        /// <returns>data string</returns>
        public static string C2Q(object xVar)
        {
            if (xVar == null)
                return "NULL";
            else if (xVar is string)
                return "'" + xVar.ToString().Replace("'", "‘") + "'";  // ' dipakai di query
            else if (xVar is DateTime)
                return " convert(datetime,'" + Convert.ToDateTime(xVar).ToShortDateString() + "',103) "; //.ToShortDateString()
            else if (xVar is Boolean)
                return (Convert.ToBoolean(xVar) ? "1" : "0");
            else if (xVar is Decimal)
                return xVar.ToString().Replace(",", ".");
            //else if (xVar is System.Drawing.Image)
            //    return (System.Drawing.Image)xVar;
            else
                return xVar.ToString();
        }

        public static string C2QTime(object xVar)//date with time
        {
            if (xVar == null)
                return "NULL";
            else if (xVar is string)
                return "'" + xVar.ToString().Replace("'", "‘") + "'";  // ' dipakai di query
            else if (xVar is DateTime)
                return " convert(datetime,'" + xVar.ToString().Replace('.', ':') + "', 103) "; //.ToShortDateString()
            else if (xVar is Boolean)
                return (Convert.ToBoolean(xVar) ? "1" : "0");
            else if (xVar is Decimal)
                return xVar.ToString().Replace(",", ".");
            else
                return xVar.ToString();
        }
    }
}
