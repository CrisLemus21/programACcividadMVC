using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    public class conexion
    {
        
        
            public SqlConnection conexion1 = new SqlConnection("Data Source=CRISLEMUS;Initial Catalog=BarDb;Integrated Security=True");
            public SqlConnection iniciarConexion()
            {
                if (conexion1.State == ConnectionState.Closed)
                    conexion1.Open();
                return conexion1;
            }

            public SqlConnection cerrarconexion()
            {
                if (conexion1.State == ConnectionState.Open)
                    conexion1.Close();
                return conexion1;
            }
        
    }
}
