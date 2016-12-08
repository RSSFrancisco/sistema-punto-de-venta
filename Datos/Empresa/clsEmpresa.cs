//clase comentada por:Francisco Reyes Sànchez
#region librerias
using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
#endregion

namespace Datos
{
   public class clsEmpresa//publicacion de la clase  clsEmpresa
    {
        conexion _cnn = new conexion();//iniciacion de la instancia _cnn que conecta a la clase conexion
        //conexionSQLite _cnn = new conexionSQLite();
       #region Constructor
       public clsEmpresa() { }//inicializa un constructor de la clase clsEmpresa
       #endregion
       #region Destructor
       ~clsEmpresa()//inicializa un desctructor de la clase clsEmpresa
       {
           _cnn = null;//inicializa al objeto _cnn como vacio
       }
       #endregion

       public bool Eliminar(int clave)//publica el metodo booleano Eliminar el cual trae como parametro la variable entera clave
       {
           string sql = "DELETE FROM Empresa WHERE idempresa =" + clave;//cadena sql la cual hace una consulta para eliminar un registro de la tabla empresa
           DataTable dt;//crea la tabla de memoria dt
           dt = _cnn.seleccionar(sql);//a la tabla de memoria se le asigna lo que trae la consulta que se hizo con cadena sql
           sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
           sql += "'" + DateTime.Now.ToString("yyyy/dd/MM HH:mm:ss") + "','Empresa','Eliminando la empresa')";
           _cnn.seleccionar(sql);//al la instancia _cnn se le manda lo que trae la cadena sql y se le concatena la funcion seleccionar
           return true;//retorna verdadero si el bloque anterior se cumple

       }
       public DataTable Listar()//publicaciòn de la tabla de memoria Listar
       {
           try//inicia el bloque de instrucciones try-catch
           {
              
             
               string sql = string.Empty;//a la cadena sql se inicializa como vacia
               sql = "select idempresa,rfc,siglas,nombre,giro,direccion,colonia,";
               sql += "ciudad,estado,cp,telefono from Empresa where baja=0;";//instrucion sql la cual tiene como funcion hacer una consulta ala BD RG Soluciones 
               DataTable dt;//se crea la tabla de memoria
               dt = _cnn.seleccionar(sql);//a la tabla de memoria se le asigna lo que trae la cadena sql y la funcion seleccionar 
               sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
               sql += "'" + DateTime.Now.ToString("yyyy/dd/MM HH:mm:ss") + "','Empresa','Listando empresa')";
               _cnn.seleccionar(sql);//al objeto _cnn se le asigna lo que trae la cadena sql y la funcion selecionar
               return dt;//si el bloque de instrucciones anterior se cumple correctamente retorna lo que trae la tabla de memoria dt
           }
           catch (Exception)
           {
               throw;
           }
       }
//funcion que actualiza los registros de la tabla empresa apartir de el campo y el parametro clave 
       public bool Actualizar(string campo, int clave, Hashtable nuevasEmpresas)
       {
           bool seguir = false;//si seguir es igual a falso entonces
           try//inicia el bloque de instrucciones try-catch
           {
               _cnn.Actualizar("Empresa", campo, clave, nuevasEmpresas);//ala variable _cnn se le envian los parametros empresa,clave y lo que trae nuevasEmpresas
             string  sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
               sql += "'" + DateTime.Now.ToString("yyyy/dd/MM HH:mm:ss") + "','Empresa','Actualizando empresa')";
               seguir = true;//ala variable seguir se le asigna el valor de verdadero
           }
           catch (Exception)
           {
               seguir = false;//ala variable seguir se le asigna el valor de falso
           }
           finally
           {
           }
           return seguir;//retorna lo que trae la variable seguir
       }
   //metodo booleano que guarda los registros de la tabla empresa
       public bool Guardar(Hashtable[] Empresas)
       {
           bool continuar = false;//se publica una variable booleana continuar a la cual se le asigna como falso
           try//inicia el bloque try-catch
           {
               _cnn.Insertar("Empresa", Empresas);//a la variable _cnn se le manda la funcion Insertar la cual trae como parametro el nombre de la tabla Empresa y el objeto Empresas
              string sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
               sql += "'" + DateTime.Now.ToString("yyyy/dd/MM HH:mm:ss") + "','Empresa','Guardando empresa')";
               continuar = true;//a la variable continuar se le asigna como verdadera
           }
           catch (Exception )
           {
               continuar = false;//se le asigna falso a la variable continuar
           }
           finally
           {
           }
           return continuar;//retorna lo que trae la variable continuar
       }

       
    }
    
}
