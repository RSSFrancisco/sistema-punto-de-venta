#region Referencias
using System;//libreria que hace uso del sistema
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;
#endregion


namespace Datos
{
    public class respaldo
    {
        conexion _cnn = new conexion();
       
        public bool respaldar(string nombre, DateTime fecha, string dispositivo, string carpeta)
        {
            string sql = string.Empty;
            sql = " backup database baseRG2 TO DISK ='" + dispositivo + ":\\" + carpeta + "\\" + nombre + ".bak' WITH description ='" + fecha + "';";
            DataTable dt;
            dt = _cnn.seleccionar(sql);

            return true;

        }
        public void respaldoRapido(/*string directorio*/)
        {
            //string sql = string.Empty;
            //sql = " backup database sys_ventas TO DISK ='" + directorio +" "+ DateTime.Now.ToString("yyyy MM dd")+ ".bak';";
            //DataTable dt;
            //dt = _cnn.seleccionar(sql);
            //return true;
            //_cnn.Backup(/*directorio*/);



        }
        public bool restaurar(string nombre, string unidad, string carpeta)
        {
            string sql = string.Empty;
            sql = "restore database baseRG2 from disk='" + unidad + ":\\" + carpeta + "\\" + nombre + "'";
            DataTable dt;
            dt = _cnn.seleccionar(sql);
            return true;
        }
        public bool restauracionRapida(string directorio)
        {
            string sql = string.Empty;
            sql = "USE master  restore database baseRG2 from disk='" + directorio + "'";
            DataTable dt;
            dt = _cnn.seleccionar(sql);
            return true;
        }



    }
}
