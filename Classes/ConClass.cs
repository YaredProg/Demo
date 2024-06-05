using BookProject.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject.Classes
{
    internal class ConClass
    {
        public static SqlDataAdapter da;
        public static SqlCommand cmd; 
        public static string SqlQuery;
        public static SqlConnection con = new SqlConnection
            ("Data Source="+ Settings.Default.Server + ";Initial Catalog=" + Settings.Default.Database +
            ";Integrated Security=False;User Id=" + Settings.Default.SQLLogin
            + ";Password=" + Settings.Default.SQLPassword + ";");

    }
}
