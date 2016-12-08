using Negocios;

namespace Presentacion
{
  public  class Helper
    {
        Core _objCore = new Core();
        public int ObtenerNumeroFilas(string llavePrimaria, string tabla,int tamanio)
        {
            int numeroFilas = _objCore.ObtenerNumeroFilas(llavePrimaria,tabla);
            int numeroPaginas = numeroFilas / tamanio;
            return numeroPaginas; 
        }
        // Metodo que actualiza el estado de un producto en el stock de la base de datos del sistema
        //public bool actualizar_existencia_producto(string llavePrimaria, string accion, int nuevaCantidad, int cantidadAnterior)
        //{
        //    return _objCore.actualizar_existencia_producto(llavePrimaria, accion, nuevaCantidad, cantidadAnterior);
        //}
       
    }
}
