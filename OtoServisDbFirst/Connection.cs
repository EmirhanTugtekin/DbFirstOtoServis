using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisDbFirst
{
    public class Connection
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-6TUVH6H;Initial Catalog=DbOtoServis;Integrated Security=True");
    }
}
