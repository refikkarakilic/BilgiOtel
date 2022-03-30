using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BilgiHotel
{
    public static class HelperSql
    {

        //SqlConnection
        public static SqlConnection getSqlConnection()
        {
            //Geriye SqlConnection Tipinden Nesne döndürecek
            return new SqlConnection(Tools.cnnStr);

        }

        //SqlCommand, nesnesi hazırlıyoruz
        public static SqlCommand getSqlCommand(string spName, bool spOK, SqlParameter[] cmdParams)
        {
            SqlCommand cmd = new SqlCommand(spName, getSqlConnection());

            if (spOK)
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
            }


            if (cmdParams != null)
            {
                cmd.Parameters.AddRange(cmdParams);
            }


            return cmd;

        }

        //SqlCommand, ExecuteNonQuery
        public static void SqlGeriDondurmezWithSp(string spName, bool spOK, SqlParameter[] cmdParams)
        {
            SqlCommand cmd = getSqlCommand(spName, spOK, cmdParams);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            
        }


        //SqlCommand, ExecuteScalar
        public static object SqlNesneDondurWithSP(string spName, bool spOK, SqlParameter[] cmdParams)
        {
            SqlCommand cmd = getSqlCommand(spName, spOK, cmdParams);
            cmd.Connection.Open();
            object donenDeger = cmd.ExecuteScalar();
            cmd.Connection.Close();
            
            return donenDeger;
        }

        //SqlDataReader -- SqlCommand, ExecuteReader

        public static SqlDataReader SqlOkuyucuDondurWithSp(string spName, bool spOK, SqlParameter[] cmdParams)
        {
            SqlCommand cmd = getSqlCommand(spName, spOK, cmdParams);
            cmd.Connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            //cmd.Connection.Close();
            return rd;
        }

    }
}
