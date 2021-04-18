using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT_FIN_ETUDE.DAL;
using System.Data;

namespace PROJECT_FIN_ETUDE.BL
{
    class CLASS_PRODUCT
    {
        /// <summary>
        /// THIS METHODE WILL FILL THE COMBO BOX WITH THE ID AND NAME OF THE CATEGORIES
        /// </summary>
        /// <returns> IT WILL RETURN A DATATABLE FILL WITH NAME OF THE CATEGORIE </returns>
        public static DataTable sp_Fill_combo_cat()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_Fill_combo_cat", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns> IT WILL RETURN A DATATABLE FILL WITH NAME OF THE ACTIVE MATERIEL </returns>
        public static DataTable sp_Fill_combo_am()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_Fill_combo_am", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns> IT WILL RETURN A DATATABLE FILL WITH NAME OF THE SCIENTIFIC NAME</returns>
        public static DataTable sp_Fill_combo_sn()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_Fill_combo_sn", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"> le nom </param>
        /// <param name="desc"> la dscription</param>
        /// <param name="image">l'image</param>
        /// <param name="buy_price"> le prix d'achat</param>
        /// <param name="sell_price"></param>
        /// <param name="catID">le prix de vente</param>
        /// <param name="amID">l'identifiant du matiere actif</param>
        /// <param name="snID">l'identifiant du nom scientifique</param>
        /// <param name="barcode">la barcode</param>
        /// <returns>it add the product to the database</returns>
        public static int sp_addProduct(string name, string desc ,byte[] image ,string buy_price ,string sell_price ,int catID  ,int amID ,int snID ,string barcode)
        {
            int count = DataAccessLayer.ExecuteNonQuery("sp_addProduct", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@name", SqlDbType.VarChar, name),
                DataAccessLayer.createParameter("@desc", SqlDbType.VarChar, desc),
                DataAccessLayer.createParameter("@image", SqlDbType.Image, image),
                DataAccessLayer.createParameter("@buy_price", SqlDbType.VarChar, buy_price),
                DataAccessLayer.createParameter("@sell_price", SqlDbType.VarChar, sell_price),
                DataAccessLayer.createParameter("@catID", SqlDbType.Int,catID),
                DataAccessLayer.createParameter("@amID", SqlDbType.Int, amID),
                DataAccessLayer.createParameter("@snID", SqlDbType.Int, snID),
                DataAccessLayer.createParameter("@barcode", SqlDbType.VarChar,barcode));
            DataAccessLayer.close();
            
            return count;
            
        }

        public static DataTable sp_selectAllProducts()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_selectAllProducts", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;
        }
        public static DataTable sp_searchProduct(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_searchProduct", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@search", SqlDbType.VarChar, search));
            DataAccessLayer.close();
            return dt;
        }
        public static byte[] sp_getImage(int id)
        {
            DataAccessLayer.Open();
            byte[] arr =(byte[]) DataAccessLayer.ExecuteScalar("sp_getImage", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.close();
            return arr;

        }

        public static DataTable sp_expireDate(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_expireDate", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.close();
            return dt;
        }

        public static int  sp_deletProduct(int id)
        {
            DataAccessLayer.Open();
            int count = DataAccessLayer.ExecuteNonQuery("sp_deletProduct", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.close();
            return count;
        }

        public static DataTable sp_getSelectedProduct(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_getSelectedProduct", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.close();
            return dt;
        }

        public static int sp_updateProduct(int id,string name, string desc, byte[] image, string buy_price, string sell_price, int catID, int amID, int snID, string barcode)
        {
            DataAccessLayer.Open();
            int count = DataAccessLayer.ExecuteNonQuery("sp_updateProduct", CommandType.StoredProcedure,
                DataAccessLayer.createParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.createParameter("@name", SqlDbType.VarChar, name),
                DataAccessLayer.createParameter("@desc", SqlDbType.VarChar, desc),
                DataAccessLayer.createParameter("@image", SqlDbType.Image, image),
                DataAccessLayer.createParameter("@buy_price", SqlDbType.VarChar, buy_price),
                DataAccessLayer.createParameter("@sell_price", SqlDbType.VarChar, sell_price),
                DataAccessLayer.createParameter("@catID", SqlDbType.Int, catID),
                DataAccessLayer.createParameter("@amID", SqlDbType.Int, amID),
                DataAccessLayer.createParameter("@snID", SqlDbType.Int, snID),
                DataAccessLayer.createParameter("@barcode", SqlDbType.VarChar, barcode)
                );
            DataAccessLayer.close();
            return count;
        }
    }
}
