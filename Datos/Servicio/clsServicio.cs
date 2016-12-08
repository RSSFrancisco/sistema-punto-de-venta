#region Referencias
using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;
#endregion

namespace Datos
{
    public class clsServicio
    {
        conexion _cnn = new conexion();//inicia una nueva conexion ala BD y se la asigna a la variable _cnn
        //conexionSQLite _cnn = new conexionSQLite();

        #region Constructor
        public clsServicio()
        { }
        #endregion
        #region Destructor
        ~clsServicio()
        {
            _cnn = null;
        }
        #endregion

        public DataTable Buscar(int clave)
        {
            try
            {
                string sql = string.Empty;
                sql = "select idservicio, nombre, preciounitario from Servicio where idservicio=" + clave;
                DataTable DT;
                DT = _cnn.seleccionar(sql);
                return DT;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable Listar()
        {
            try
            {
                string sql = string.Empty;
                sql = "select idservicio, nombre,preciounitario from Servicio where baja=0";
                DataTable dt;
                dt = _cnn.seleccionar(sql);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Guardar(Hashtable[] Servicio)
        {
            bool continuar = false;
            try
            {
                _cnn.Insertar("Servicio", Servicio);
                continuar = true;
            }
            catch (Exception)
            {
                continuar = false;
            }
            finally
            {
            }
            return continuar;
        }

        public bool Actualizar(string campo, int clave, Hashtable NuevoServicio)
        {
            bool seguir = false;
            try
            {
                _cnn.Actualizar("Servicio", campo, clave, NuevoServicio);
                seguir = true;
            }
            catch (Exception)
            {
                seguir = false;
            }
            finally
            {
            }
            return seguir;
        }

        public bool Eliminar(int clave)
        {
            string sql = "UPDATE Servicio SET baja=1 WHERE idservicio =" + clave;
            _cnn.seleccionar(sql);
            return true;
        }
    }
}
