using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PROJECT_FIN_ETUDE.DAL;

namespace PROJECT_FIN_ETUDE.BL
{
    class CLASS_LOGIN
    {
        public static DataTable sp_login(string Uname,string Upass)
        {
            DataTable dt=DataAccessLayer.ExecuteTable("sp_login", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@UName", SqlDbType.VarChar, Uname),
                DataAccessLayer.createParameter("@Upass", SqlDbType.VarChar, Upass));

            DataAccessLayer.close();
            return dt;

        }
    }
}
