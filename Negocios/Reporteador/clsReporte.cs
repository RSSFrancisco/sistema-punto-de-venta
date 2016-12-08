#region Librerias
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace Negocios
{
   public class clsReporte
    {
       string _nombre = "Reporte_de_Empleados";

       public string Nombre
       {
           set { _nombre=value; }
           get { return _nombre; }

       }
       public clsReporte(string nombre)
       {
           this._nombre = nombre;
       }
       public clsReporte()
       {
         
       }
      
    }
   
}
