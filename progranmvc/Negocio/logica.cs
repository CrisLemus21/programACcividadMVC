using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;




namespace Negocio
{
    
    public class logica
    {

        private productos datate = new productos();
        public DataTable mostrardatos()
        {
            DataTable tablass = new DataTable();
            tablass = datate.Mostrar();
            return tablass;
        }
        public void InsProd(string nombre, string desc, string precio, string cantidad, string estado, string id)
        {
            datate.Insertar(nombre, desc, Convert.ToDouble(precio), Convert.ToInt32(cantidad), Convert.ToInt32(estado));
        }
        public void ActProd(string nombre, string desc, string precio, string cantidad, string estado, string idproductos)
        {
            datate.Actualizar(nombre, desc, Convert.ToDouble(precio), Convert.ToInt32(cantidad), Convert.ToInt32(estado), Convert.ToInt32(idproductos));
        }

        public void eliprod(string idpro)
        {
            datate.Borrar(int.Parse(idpro));
        }

        
    }
}
