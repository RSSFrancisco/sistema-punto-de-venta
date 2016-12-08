using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Datos;

namespace Negocios
{
  public  class RegistroRespaldo:CollectionBase
    {
      respaldo _oRespaldo = new respaldo();
  

    
        public bool respaldar(string nombre,string dispositivo,DateTime fecha,string carpeta)//publica el metodo Buscar del tipo Producto que lleva la variable clave de tipo entero
      {
          try
          {
              _oRespaldo.respaldar(nombre,fecha,dispositivo,carpeta);

              return true;
          }
          catch (Exception ex)
          {
              throw new Exception(ex.Message);
          }
      }
        public void respaldarRapido(/*string directorio*/)//publica el metodo Buscar del tipo Producto que lleva la variable clave de tipo entero
        {
            try
            {
                //_oRespaldo.respaldoRapido(/*directorio*/);

                ////return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool restaurarRapido(string directorio)//publica el metodo Buscar del tipo Producto que lleva la variable clave de tipo entero
        {
            try
            {
                _oRespaldo.restauracionRapida(directorio);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool restaurar(string nombre, string dispositivo, string carpeta)//publica el metodo Buscar del tipo Producto que lleva la variable clave de tipo entero
        {
            try
            {
                _oRespaldo.restaurar(nombre, dispositivo, carpeta);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
