#region Librerias
using System;//libreria para el uso de las herramientas del sistema
#endregion 

namespace Negocios/*capa ala que pertenece la clase de tipo Historial °,°*/
{
   public class Historial
   {
       #region Atributos
       int _clave = -1;
       string _fechahora =string.Empty;///--<atributo _fechahora de tipo DateTime></atributo> 
       string _comentario = string.Empty;///--<atributo _comentario del tipo string></atributo>
       string _tabla = string.Empty;///--<atributo _tabla del tipo string></atributo>
       #endregion
       #region Propiedades publicas
       public int Clave
       {
           set
           {
               _clave = value;

           }
           get
           {
               return _clave;
           }
       }
       public string FechaHora///--<publicación del  metodo FechaHora del tipo DateTime>
       {
           set
           {
               _fechahora = value;///--<se envia lo que trae _fechahora>

           }
           get
           {
               return _fechahora;///--<retorna lo que trae _fechahora>
           }


       }
       public string Comentario///--<publicación del metodo Comentario del tipo string>
       {
           set
           {
               _comentario = value;///--<se envia el valor que trae _comentario>
           }
           get
           {
               return _comentario;///--<retorna el valor que trae _comentario>
           }

       }
       public string Tabla///--<publicación del metodo Tabla del tipo string>
       {
           set
           {
               _tabla = value;///--<envia el valor que trae _tabla>
           }
           get
           {
               return _tabla;///--<retorna el valor que trae _tabla>
           }

       }
       #endregion
       #region Constructores
       /// <summary>
       /// Inicializacion de las clases de Historial
       /// </summary>
       /// <param name="fechahora">parametro de fecha y hora del tipo DateTime </param>
       /// <param name="comentario">parametro de comentario del tipo string</param>
       /// <param name="tabla">parametro de tabla del tipo string</param>
       public Historial(int clave,string fechahora, string comentario, string tabla)
       {
           this._clave = clave;
           this._fechahora = fechahora;///  se le asigna el valor que trae  _fechahora al parametro fechahora [*-*]
           this._comentario = comentario;///se le asigna el valor que trae _comentario al parametro comentario[*-*]
           this._tabla = tabla;///          se le asigna el valor que trae _tabla al parametro tabla          [*-*]
       }
       public Historial(string fechahora, string comentario, string tabla)
       {
           this._fechahora = fechahora;///  se le asigna el valor que trae  _fechahora al parametro fechahora [*-*]
           this._comentario = comentario;///se le asigna el valor que trae _comentario al parametro comentario[*-*]
           this._tabla = tabla;///          se le asigna el valor que trae _tabla al parametro tabla          [*-*]
       }
       /// <summary>
       /// inicializa el constructor de la clase Historial como vacio
       /// </summary>
       public Historial() { }
       #endregion
   }
}
