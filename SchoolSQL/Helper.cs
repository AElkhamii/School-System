using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSQL
{
    public static class Helper
    {
        public static string CnnVal(string ConnectionName)
        {
            /* Ask ConfigurationManager [App.config] to retun ConnectionStrings called ConnectionName and ask him to return string value inside it */
            return ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
        }
    }
}
