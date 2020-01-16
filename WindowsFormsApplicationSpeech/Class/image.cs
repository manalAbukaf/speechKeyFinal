using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationSpeech.Class
{
    class image
    {
        public string imageName;
        public string imagel;
        public image(string  imageName, string imagel)
        {
           this.imageName = imageName;
            this.imagel = imagel;
        }


        public bool checkIfImageExsist()
        {
            string sql = "select * from [imges] whereimageName ='" + this.imageName+ "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;

            return false;
        }

        public bool insertImage()
        {

            if (!checkIfImageExsist())
            {
                string sql = " INSERT INTO [imges] ([imageName],[image])";
                string sql2 = "VALUES ('" + this.imageName + "','" + this.imagel + "')";
                DBFunctions.ChangTable(sql + sql2);

                return true;
            }

            return false;

        }

    }
}
