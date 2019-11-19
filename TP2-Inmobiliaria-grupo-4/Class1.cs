using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TP2_Inmobiliaria_grupo_4
{
    class Class1
    {
        public static string Cadena()
        {
             // return "data source=192.168.1.46";

            // Pablo Tartalo
              return @"data source = LAPTOP-BDOHKMHV;" +
                           "initial catalog = Promociones_inmobiliarias;" + //nombre base de datos
                            "integrated security = SSPI";
             //



         //   return @"data source = USUARIO-RMGTSE8\SQLEXPRESS;" +
         //               "initial catalog = Promociones_inmobiliarias;" + //nombre base de datos
         //                "integrated security = SSPI";
           
        }
    }
}
