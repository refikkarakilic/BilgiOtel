using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BilgiHotel
{
    public static class Tools
    {
        //Connection String
        public static string cnnStr
        {
            get
            {
                return "Server=Z36-03;Database=DB_Bilgi_Hotel;Integrated Security=true";
            }
        }
    }
}
