#region librerias
using System;
using System.Data;
#endregion

namespace Datos
{
   public class clsCore
    {
        conexion _cnn = new conexion();//inicia una nueva conexion ala BD y se la asigna a la variable _cnn
        //conexionSQLite _cnn = new conexionSQLite();
        #region Funciones Privadas
        protected int formato_cadena_unico(DataTable cadena)
        {
            int numero = Convert.ToInt32(cadena.Rows[0].ItemArray[0]);
            return numero;
        }
        #endregion
        #region Funciones públicas
        public int ObtenerNumeroFilas(string llavePrimaria,string tabla)
        {
            DataTable dt = _cnn.seleccionar("SELECT MAX("+llavePrimaria+") AS numero FROM "+tabla+"");
            int numero=formato_cadena_unico(dt);
            if (numero == 0)
            {
                return 1;
            }
            else
            {
                return (numero + 1);
            }
        }
        // falta optimizar esta funcion para que funcione como un trigger o buscar realizar un lanzador en SQLite
        //public bool actualizar_existencia_producto(string llavePrimaria, string accion, int nuevaCantidad, int cantidadAnterior)
        //{
        //    // Se obtiene la existencia actual del producto en la base de datos
        //    bool resultado = false;
        //    DataTable existencia = _cnn.seleccionar("select sum(existencia) as cantidad from producto where idproducto=" + llavePrimaria + "");
        //    int ExistenciaProductos = formato_cadena_unico(existencia);
        //    int existencia_actual = 0;
        //    // Se inicia un bloque de intrucciones switch en el cual se comprueba que tipo de acción va a ejecutar
        //    switch (accion)
        //    {
        //        case "Insertar":
        //            if (ExistenciaProductos >= nuevaCantidad)
        //            {
        //               existencia_actual= ExistenciaProductos - nuevaCantidad;
        //                DataTable dt = _cnn.seleccionar(" UPDATE producto SET existencia ='"+existencia_actual +"' WHERE idproducto=" + llavePrimaria + ";");
        //            }
        //            break;
        //        case "Actualizar":
        //            if (nuevaCantidad > cantidadAnterior)
        //            {
        //                existencia_actual = ExistenciaProductos - (nuevaCantidad - cantidadAnterior);
        //                DataTable dt = _cnn.seleccionar("UPDATE producto SET existencia = '" + existencia_actual + "' WHERE idproducto =" + llavePrimaria + "; ");
        //            }
        //            else if (nuevaCantidad < cantidadAnterior)
        //            {
        //                existencia_actual = ExistenciaProductos + (cantidadAnterior - nuevaCantidad);
        //                DataTable dt = _cnn.seleccionar("UPDATE producto SET existencia='" + existencia_actual + "'  WHERE idproducto=NEW.idproducto; ");
        //            }

        //            break;
        //        case "Eliminar":
        //            DataTable dtc = _cnn.seleccionar("UPDATE productos SET ");
        //            break;
        //        default:
        //            break;
        //    }
        //    return resultado;
        //}
        #endregion
    }
}
