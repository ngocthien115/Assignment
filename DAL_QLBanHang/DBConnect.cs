using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBanHang
{
    public class DBConnect
    {
        // Tạo chuỗi kết nối.
        protected SqlConnection _conn = new SqlConnection("Data Source=.;Initial Catalog=Assignment;Integrated Security=True");
    }
}
