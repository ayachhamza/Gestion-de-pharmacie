using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT_FIN_ETUDE.DAL;
using System.Data;
using System.Data.SqlClient;


namespace PROJECT_FIN_ETUDE.BL
{
    class CLASS_CATEGORIE
    {
        /// <summary>
        /// ADD NEW CATEGORIE
        /// </summary>
        /// <param name="cat_name">THE NAME OF THE CATEGORIE </param> 
        /// <returns>THE NUMBER OF THE INSERTED ROW </returns> 
        public static int sp_addCategorie(string cat_name)
        {
            DataAccessLayer.Open();
            int count = DataAccessLayer.ExecuteNonQuery("sp_addCategorie", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@cat_name", SqlDbType.VarChar, cat_name));
            DataAccessLayer.close();
            return count;
        }
        /// <summary>
        /// SELECT ALL CATEGORIES
        /// </summary>
        /// <returns></returns>
        public static DataTable selectAllCategorie()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_selectAllCategorie", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;
        }
        /// <summary>
        /// SEARCH FOR A SPECIFIC CATEGORIE USING NAME OR ID OF THE CATEGORIE 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public static DataTable sp_searchCategorie(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_searchCategorie", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@search", SqlDbType.VarChar, search));
            DataAccessLayer.close();
            return dt;
        }

        /// <summary>
        /// UPDATE THE CATEGORIE ITEM FROM TABLE IN DB USNIG ID FOR SEARCH
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <returns> IT RETURNS THE NUMBER OF UPDATED ROWS </returns>
        public static int sp_updateCat(int id, string nom)
        {
            DataAccessLayer.Open();
            int count = DataAccessLayer.ExecuteNonQuery("sp_updateCategorie", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.createParameter("@cat_name", SqlDbType.VarChar, nom));
            return count;
        }
        /// <summary>
        ///  DELETE THE CATEGORIE ITEMS FROM THE TABLE USING ID FOR SEARCH
        /// </summary>
        /// <param name="id"></param>
        /// <returns> IT RETURN THE NUMBER OF DELETED ROWS </returns>
        public static int sp_deleteCat(int id)
        {
            DataAccessLayer.Open();
            int count = DataAccessLayer.ExecuteNonQuery("sp_deleteCategorie", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.close();
            return count;
        }
    }
}
