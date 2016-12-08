using Datos;

namespace Negocios
{
 public class Core
    {
        clsCore _objCore = new clsCore();
        public int ObtenerNumeroFilas(string llavePrimaria, string tabla)
        {
            return _objCore.ObtenerNumeroFilas(llavePrimaria,tabla);
        }
        //public bool actualizar_existencia_producto(string llavePrimaria,string accion,int nuevaCantidad, int cantidadAnterior)
        //{
        //    return _objCore.actualizar_existencia_producto(llavePrimaria,accion,nuevaCantidad,cantidadAnterior);
        //}
    }
}
