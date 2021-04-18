using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT_FIN_ETUDE.DAL;
using System.Data.SqlClient;
using System.Data;

namespace PROJECT_FIN_ETUDE.BL
{
    class CLASS_ACTIVE_MATERIEL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom">c'est le nom de la matiere </param>
        /// <param name="desc"></param>
        /// <returns></returns>
        public static int sp_addActiveMateriel(string nom ,string desc)
        {
            DataAccessLayer.Open();
            int count = DataAccessLayer.ExecuteNonQuery("sp_addActiveMateriel", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@nom", SqlDbType.VarChar, nom),
                DataAccessLayer.createParameter("@description", SqlDbType.VarChar, desc));
            DataAccessLayer.close();
            return count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DataTable sp_selectAllActiveMateriel()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_selectAllActiveMateriel", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;

           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>

        public static DataTable sp_SearchActiveMateriel(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_SearchActiveMateriel", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@search", SqlDbType.VarChar, search));
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="desc"></param>
        /// <returns></returns>
        public static int sp_updateActiveMateriel(int id,string nom ,string desc)
        {
            DataAccessLayer.Open();
            int count = DataAccessLayer.ExecuteNonQuery("sp_updateActiveMateriel", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.createParameter("@nom", SqlDbType.VarChar, nom),
                DataAccessLayer.createParameter("@description", SqlDbType.VarChar, desc));
            return count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int sp_deleteActiveMateriel(int id)
        {
            DataAccessLayer.Open();
            int count = DataAccessLayer.ExecuteNonQuery("sp_deleteActiveMateriel", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.close();
            return count;
        }
    }
}
