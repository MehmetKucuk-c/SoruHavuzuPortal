using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruHavuzuPortal
{
    class DataBase
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FGPFH37;Initial Catalog=SoruBankası;Integrated Security=True;MultipleActiveResultSets=True");
    }
}
