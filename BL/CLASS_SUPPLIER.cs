using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PROJECT_FIN_ETUDE.DAL;

namespace PROJECT_FIN_ETUDE.BL
{
    class CLASS_SUPPLIER
    {
        public static int sp_add_new_sup(string nom,string tele,string email)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_add_new_sup", CommandType.StoredProcedure
                , DataAccessLayer.createParameter("@nom", SqlDbType.VarChar, nom)
                , DataAccessLayer.createParameter("tele", SqlDbType.VarChar, tele),
                DataAccessLayer.createParameter("email", SqlDbType.VarChar, email));
            DataAccessLayer.close();
            return i;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DataTable sp_select_supplier()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_select_supplier", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;
        }

        public static DataTable sp_search_supplier(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_search_supplier", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@search", SqlDbType.VarChar, search));
            DataAccessLayer.close();
            return dt;
        }
        public static DataTable sp_supplier_select_id(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_supplier_select_id", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.close();
            return dt;
        }
        public static int sp_update_supplier(int id, string name,string tele,string email)
        {
            DataAccessLayer.Open();
            int i =DataAccessLayer.ExecuteNonQuery("sp_update_supplier", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.createParameter("@name", SqlDbType.Int, name),
                DataAccessLayer.createParameter("@mobile", SqlDbType.Int, tele),
                DataAccessLayer.createParameter("@email", SqlDbType.Int, email));
            DataAccessLayer.close();
            return i;
        }
        public static int sp_delete_supplier(int id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_delete_supplier", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.close();
            return i;
        }

    }
}
