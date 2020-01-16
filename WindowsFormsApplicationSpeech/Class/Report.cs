using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using WindowsFormsApplicationSpeech.Class;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplicationSpeech.Class
{
    class Report
    {
        public string userName;
        public DateTime activityTime;

        public Report(string userName, string report_id, DateTime activityTime)
        {
            this.userName = userName;
            this.activityTime = activityTime;
        }
        public Report(string userName)
        {
            this.userName = userName;
           
        }
      

        public bool checkIfReportExsist()
        {
            string sql = "select * from [reports] where userName='" + this.userName + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;

            return false;
        }






    }
}
