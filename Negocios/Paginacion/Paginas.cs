#region Leeme
/*
 * Fecha de creación: 09/10/2016
 * Autor: Ing.Francisco Reyes Sánchez
 * 
 */
#endregion
namespace Negocios
{
   public class Paginas
    {
        int _numeroPaginas = 0;
        int _paginaActual = 0;
        int _tamanio = 25;
        public int NumeroPaginas
        {
            set { _numeroPaginas = value; }
            get { return _numeroPaginas; }
        }
        public int PaginaActual
        {
            set { _paginaActual = value; }
            get { return _paginaActual; }
        }
        public int Tamanio
        {
            set { _tamanio = value; }
            get { return _tamanio; }
        }
        public Paginas(int numeroPaginas, int paginaActual, int tamanio)
        {
            _numeroPaginas = numeroPaginas;
            _paginaActual = paginaActual;
            _tamanio = tamanio;
        }
        public Paginas()
        {

        }
    }
}
