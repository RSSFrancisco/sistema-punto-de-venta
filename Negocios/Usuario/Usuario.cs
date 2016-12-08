using System;
using Datos;

namespace Negocios
{
    public class Usuario
    {

        #region Atributos
        int _IdUsuario = -1;
        string _nick = string.Empty;
        string _contrasenia = string.Empty;
        int _idempleado = -1;
        clsUsuario _usuario = new clsUsuario();

        #endregion
        #region Propiedades Públicas
        public int Clave
        {
            set {
                _IdUsuario = value;  
            }

            get { return _IdUsuario; }
        }
        public string Nick
        {
            set { _nick = value; }
            get { return _nick; }
        }
        public string Contrasenia
        {
            set { _contrasenia = value; }
            get { return _contrasenia; }
        }

        public int Idempleado
        {
            set {
                
                _idempleado = value; 
            
            
                }
            get { return _idempleado; }
        }

        #endregion


        public bool ingresar(string usuario, string clave)
        {
            try
            {
                return _usuario.Ingresar(usuario, clave);

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #region Constructor
        public Usuario(int idusuario, string nick, string contrasenia, int idempleado)
        {
            this._IdUsuario = idusuario;
            this._nick = nick;
            this._contrasenia = contrasenia;
            this._idempleado = idempleado;


        }
        public Usuario(string nick, string contrasenia, int idempleado)
        {

            this._nick = nick;
            this._contrasenia = contrasenia;
            this._idempleado = idempleado;

        }


        public Usuario()
        { }
        #endregion


    }
}


