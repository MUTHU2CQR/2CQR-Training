using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample15
{
    class DataBaseConnection
    {
        private string sql_string;
        private string strCon;

        public string Sql
        {

            set
            {
                sql_string = value;

            }
        }
        public string connection_string
        {

            set { strCon = value; }

        }
    }
}
