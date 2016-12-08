using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using Datos;

namespace Negocios
{
    public class RegistrarUsuario : CollectionBase
    {
        #region Atributos
        clsUsuario _oUsuario = new clsUsuario();//crea un objeto _oUsuario de la clase clsUsuario
        #endregion

        #region Metodos de la coleccion base
        public int Add(Usuario NuevoUsuario)//publica el metodo para agregar un nuevo usuario
        {
            return (List.Add(NuevoUsuario));//retorna la lista que se agrego a NuevoUsuario
        }
        public int IndexOf(Usuario PosicionDelUsuario)//se publica un indice para la Posicion del usuario en la lista
        {
            return (List.IndexOf(PosicionDelUsuario));//retorna el indice con la posicion del usuario

        }
        public void Insert(int Indice, Usuario InsertarUsuario)//se publica el metodo Insert que contiene una variable indice del tipo usuario con el metodo insertar usuario
        {
            List.Insert(Indice, InsertarUsuario);//lista el indice del usuario que se inserto
        }
        #endregion
        public List<Usuario> Listar()//se crea una  lista del tipo Usuario 
        {
            try//inicia el bloque try-catch
            {
                DataTable dt = _oUsuario.Listar();//creacion de la tabla de memoria dt 
                if (dt != null)//declara el bucle de control si dt es diferente de vacio
                {
                    List<Usuario> misUsuarios = new List<Usuario>();//lista los usuarios y le asigna a misUsuarios la nueva lista 
                    foreach (DataRow dr in dt.Rows)//crea un foreach con DataRow en la tabla de memoria dt
                    {
                        Usuario c = new Usuario();//se inicializa el objeto c de tipo usuario
                        c.Clave = int.Parse(dr["idusuario"].ToString());//asigna el objeto c de tipo clave ala fila dr en la base de datos 
                        c.Nick = dr["nick"].ToString();//asigna el objeto c de tipo Nick ala fila dr en la base de datos 
                        c.Contrasenia = dr["contrasenia"].ToString();//asigna el objeto c de tipo Contrasenia ala fila dr en la base de datos 
                        c.Idempleado = int.Parse(dr["idempleado"].ToString());//asigna el objeto c de tipo Idempleado ala fila dr en la base de datos 
                        misUsuarios.Add(c);//ala variable  c se le agrega lo que trae la lista  de tipo Usuario 
                        c = null;//inicializa c en vacio
                    }
                    return misUsuarios;//retorna a misUsuarios 

                }
                else//si no se cumple el bucle if entonces
                {
                    return null;//retorna el valor que trae en vacio
                }
            }
            catch (Exception ex)//si el bloque try cacha una excepcion dentro del mismo le manda el mensaje de error ala variable ex
            {
                throw new Exception(ex.Message);//manda un mensaje de error del tipo message
            }
        }
        public bool Guardar()//se publica el metodo de tipo booleano con el nombre Guardar
        {
            if (this.Count == 0)//si el valor que cuenta es igual a 0
            {
                return false;//retorna el valor en falso
            }
            try//inicia el bloque try-catch
            {
                Hashtable[] MisUsuarios = new Hashtable[this.Count];//creacion de HashTable del tipo MisUsuarios
                int indice = 0;//inicializa a la variable indice en 0 o vacio 
                foreach (Usuario c in this)//declaracion de foreach del tipo Usuario 
                {
                    Hashtable ht = new Hashtable();//declaracion del objeto ht del tipo HashTable 
                    ht.Add("nick", c.Nick);//se le agrega al objeto ht el nick de la BD y la variable c del tipo Nick
                    ht.Add("contrasenia", c.Contrasenia);
                    ht.Add("idempleado", c.Idempleado);
                    MisUsuarios[indice] = ht;
                    ht = null;
                    indice++;
                }
                return (_oUsuario.Guardar(MisUsuarios));
            }

            catch (Exception)
            {
                return false;
            }
        }
    }
}
