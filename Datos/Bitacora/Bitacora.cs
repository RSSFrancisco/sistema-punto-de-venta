using System;
using System.Xml;

namespace Datos
{
    class Bitacora
    {

        #region Variables Privadas
        XmlDocument _archivo;
        string _name = DateTime.Now.Date.ToString("dddd_dd_HH_mm_ss", new System.Globalization.CultureInfo("es-ES")) + ".xml";
        #endregion

        #region Constructor
        public Bitacora()
        {
            Boolean existe = archivo(_name);
            _archivo = new XmlDocument();
            if (!(existe))
            {
                XmlNode minode = _archivo.CreateElement("BITACORA");
                _archivo.AppendChild(minode);
            }
            else
            {
                _archivo.Load(Environment.CurrentDirectory + @"\" + _name);
            }
        }
        #endregion

        public Boolean RegistrarAccion(DateTime Fecha,  string Observaciones)
        {
            XmlNode registro = this.CrearNodoXml( Fecha,  Observaciones);
            XmlNode nodeRaiz = _archivo.DocumentElement;
            nodeRaiz.InsertAfter(registro, nodeRaiz.LastChild);
            _archivo.Save(Environment.CurrentDirectory + @"\" + DateTime.Now.ToString("ss") + _name);
            
            return true;
        }

        private XmlNode CrearNodoXml( DateTime Fecha,  string Observaciones)
        {
            XmlElement error = _archivo.CreateElement("REGISTRO");

            
            XmlElement fecha = _archivo.CreateElement("FECHA");
            fecha.InnerText = Fecha.ToString("yyyy/MM/dd HH:mm:ss");

            
            XmlElement observa = _archivo.CreateElement("OBSERVACIONES");
            observa.InnerText = Observaciones;

            
            error.AppendChild(fecha);
            error.AppendChild(observa);
            return error;
        }

        public static bool archivo(string nombre)
        {
            System.IO.FileInfo arch = new System.IO.FileInfo(Environment.CurrentDirectory + @"\" + nombre);
            if (arch.Exists)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

