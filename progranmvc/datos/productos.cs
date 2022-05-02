using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class productos
    {
        private Class1 conexion = new Class1();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable Mostrar()
        {
            comando.Connection = conexion.iniciarConexion();
            comando.CommandText = "LeerProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarconexion();
            return tabla;
        }

        public void Insertar(string nombre, string desc, double precio, int cantidad, int estado)
        {
            

            comando.Connection = conexion.iniciarConexion();
            comando.CommandText = "InsertarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nomprod", nombre);
            comando.Parameters.AddWithValue("@descripcion", desc);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@estado", estado);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }


        public void Actualizar(string nombre, string desc, double precio, int cantidad, int estado, int idproducto)
        {

            comando.Connection = conexion.iniciarConexion();
            comando.CommandText = "ActualizarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nomprod", nombre);
            comando.Parameters.AddWithValue("@descripcion", desc);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@idproducto", idproducto);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Borrar(int idproducto)
        {

            comando.Connection = conexion.iniciarConexion();
            comando.CommandText = "EliminarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idprod", idproducto);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
