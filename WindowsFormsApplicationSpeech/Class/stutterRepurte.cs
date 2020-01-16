using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplicationSpeech.Class
{
    class stutterRepurte
    {
        public string userName;
        public DateTime activityTime;

        public stutterRepurte(string userName, string report_id, DateTime activityTime)
        {
            this.userName = userName;
            this.activityTime = activityTime;
        }
        public stutterRepurte(string userName)
        {
            this.userName = userName;

        }


        public bool checkIfReportExsist()
        {
            string sql = "select * from [stutterReport] where userName='" + this.userName + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;

            return false;
        }

    }
}
