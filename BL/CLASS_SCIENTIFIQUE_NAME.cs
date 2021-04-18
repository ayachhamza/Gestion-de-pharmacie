using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT_FIN_ETUDE.DAL;
using System.Data;
namespace PROJECT_FIN_ETUDE.BL
{
    class CLASS_SCIENTIFIQUE_NAME
    {
        public static int sp_addScientificName(string nom)
        {
            DataAccessLayer.Open();
            int count = DataAccessLayer.ExecuteNonQuery("sp_addScientificName", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@nom", SqlDbType.VarChar, nom));
            DataAccessLayer.close();
            return count;
        }

        public static int sp_deleteScientificName(int id)
        {
            DataAccessLayer.Open();
            int count = DataAccessLayer.ExecuteNonQuery("sp_deleteScientificName", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@id", SqlDbType.VarChar, id));
            DataAccessLayer.close();
            return count;
        }

        public static int sp_updateScientificName(int id,string nom)
        {
            DataAccessLayer.Open();
            int count = DataAccessLayer.ExecuteNonQuery("sp_updateScientificName", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@id",SqlDbType.Int,id),
                DataAccessLayer.createParameter("@nom", SqlDbType.VarChar, nom));
            DataAccessLayer.close();
            return count;
        }

        public static DataTable sp_selectAllScientificName()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_selectAllScientificName",CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;
        }

        public static DataTable sp_searchScientificName(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_searchScientificName", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@search",SqlDbType.VarChar,search));
            DataAccessLayer.close();
            return dt;
        }


    }
}
