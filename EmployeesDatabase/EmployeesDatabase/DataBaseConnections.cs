using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDatabase
{
    class DataBaseConnections
    {
        private string sql_string;
        private string strCon;

        public string sql
        {
            set { sql_string = value; }

        }
        public string connection_string
        {
            set { strCon = value; }
        }
        public System.Data.DataSet GetConnection   
        {
            get
            {
                return MyDataSet();
            }     

        }
        private System.Data.DataSet MyDataSet()
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);
            con.Open();
            System.Data.SqlClient.SqlDataAdapter d1= new System.Data.SqlClient.SqlDataAdapter(sql_string, con);
            System.Data.DataSet data_set = new System.Data.DataSet();
            d1.Fill(data_set, "Table_Data_1");

            con.Close();

            return data_set;
        }
    }
}
