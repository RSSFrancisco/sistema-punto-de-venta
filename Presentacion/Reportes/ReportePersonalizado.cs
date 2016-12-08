#region Derechos Reservados
/****************************************************************************
*Advertencia este programa esta protegido po las leyes de derechos de autor *
*y otros tratados internacionales.                                          *
*la reproducción o distribución ilícitas de este programa ,o de cualquier   *
*parte del mismo,esta penada por la ley con severas sanciones civiles y     *
*penales,y sera objeto de todas las acciones judiciales que correspondan.   *
*Autor: Francisco Reyes Sánchez.     ¬~~~~~~~~°@°='o'                       *
*                            * 
****************************************************************************/
#endregion
using System;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Collections.Generic;
using Negocios;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Media.Imaging;


namespace Presentacion
{
    class ReportePersonalizado
    {

        public void GenerandoReporte(List<Requisicion> misRequisiciones, string nombre)
        {
            try
            {
                PdfDocument documento = new PdfDocument();
                XGraphics gfx = null;
                XImage image = XImage.FromFile(Environment.CurrentDirectory + @"\LOGO_RG.png");//esto tambien se debe de repetir en el segundo cuerpo del reporte
                XFont titulo = new XFont("Arial Black", 13);
                XFont letra = new XFont("Arial", 9);
                XFont letra2 = new XFont("Arial Black", 7);
                XFont letra3 = new XFont("Arial", 9);
                XFont letra4 = new XFont("Arial Black", 9);
                PdfPage pagina = documento.AddPage();
                pagina.Size = PageSize.Letter;
                pagina.Orientation = PageOrientation.Portrait;
                gfx = XGraphics.FromPdfPage(pagina);
                image.Interpolate = true;
                gfx.DrawImage(image, 35, 30);
                int folio = 56;
                int fecha = 85;
                int cliente = 120;
                int direccion = 135;
                int ciudad = 150;
                int atendio = 165;
                int TipoServicio = 220;
                int Entrada = 198;
                int Salida = 218;
                int HoraEntrada = 200;
                int HoraSalida = 218;

                int ServicioAdomicilio = 235;
                int nombreEquipo = 275;
                int condicion = 345;
                //int x = 100;
                #region cuerpo y cabezera del reporte
                gfx.DrawString("REPORTE DE SERVICIO", titulo, XBrushes.Black, new XPoint(245, 40));
                gfx.DrawString("VENTA DE ACCESORIOS PARA COMPUTADORA", letra, XBrushes.Black, new XPoint(225, 50));
                gfx.DrawString("REFACCIONES, SOPORTE TECNICO ESPECIALIZADO", letra, XBrushes.Black, new XPoint(217, 60));
                gfx.DrawString("MANTENIMIENTO PREVENTIVO Y CORRECTIVO", letra, XBrushes.Black, new XPoint(225, 70));
                gfx.DrawRectangle(XPens.Black, 465/*alineacion ala derecha o izquierda*/, 35/* top de la figura*/, 100/*ancho de la figura*/, 25/*alto de la figura*/);
                gfx.DrawLine(XPens.Black, 465/*alineacion del primerr punto */, 45/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 45/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                gfx.DrawString("Numero", letra, XBrushes.Black, new XPoint(499, 42));
                //aqui debe ir el id de la requisicion

                gfx.DrawRectangle(XPens.Black, 465/*alineacion ala derecha o izquierda*/, 65/* top de la figura*/, 100/*ancho de la figura*/, 25/*alto de la figura*/);
                gfx.DrawLine(XPens.Black, 465/*alineacion del primerr punto */, 75/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 75/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                gfx.DrawString("Fecha", letra, XBrushes.Black, new XPoint(499, 72));
                //aqui debe ir la fecha en la que se realizo la requisicion del servicio

                gfx.DrawRectangle(XPens.Black, 35/*alineacion ala derecha o izquierda*/, 100/* top de la figura*/, 530/*ancho de la figura*/, 430/*alto de la figura*/);
                gfx.DrawRectangle(XPens.Black, 36/*alineacion ala derecha o izquierda*/, 101/* top de la figura*/, 529/*ancho de la figura*/, 429/*alto de la figura*/);

                gfx.DrawRectangle(XPens.Black, 35/*alineacion ala derecha o izquierda*/, 550/* top de la figura*/, 530/*ancho de la figura*/, 180/*alto de la figura*/);
                gfx.DrawRectangle(XPens.Black, 35/*alineacion ala derecha o izquierda*/, 550/* top de la figura*/, 530/*ancho de la figura*/, 60/*alto de la figura*/);
                gfx.DrawRectangle(XPens.Black, 45/*alineacion ala derecha o izquierda*/, 560/* top de la figura*/, 510/*ancho de la figura*/, 40/*alto de la figura*/);
                #endregion
                #region Lineas Horizontales
                gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 180/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 180/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 1
                gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 240/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 240/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 250/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 250/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 300/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 300/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 3 
                gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 310/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 310/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 4 
                gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 370/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 370/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 380/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 380/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 440/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 440/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 450/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 450/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                //gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 510/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 510/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 520/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 520/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                //gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 580/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 580/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 

                gfx.DrawRectangle(XPens.Black, 105/*alineacion ala derecha o izquierda*/, 660/* top de la figura*/, 160/*ancho de la figura*/, 20/*alto de la figura*/);
                gfx.DrawRectangle(XPens.Black, 345/*alineacion ala derecha o izquierda*/, 660/* top de la figura*/, 160/*ancho de la figura*/, 20/*alto de la figura*/);

                gfx.DrawRectangle(XPens.Black, 135/*alineacion ala derecha o izquierda*/, 574/* top de la figura*/, 80/*ancho de la figura*/, 15/*alto de la figura*/);//caja de texto mano de obra
                gfx.DrawRectangle(XPens.Black, 300/*alineacion ala derecha o izquierda*/, 574/* top de la figura*/, 80/*ancho de la figura*/, 15/*alto de la figura*/);//caja de texto refacciones
                gfx.DrawRectangle(XPens.Black, 460/*alineacion ala derecha o izquierda*/, 574/* top de la figura*/, 80/*ancho de la figura*/, 15/*alto de la figura*/);//caja de texto total

                gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 190/*alineacion del primer punto de la linea desde top*/, 225/*segundo punto de la linea a lo ancho*/, 190/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 1
                gfx.DrawLine(XPens.Black, 565/*alineacion del primerr punto */, 223/*alineacion del primer punto de la linea desde top*/, 375/*segundo punto de la linea a lo ancho*/, 223/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 1

                #endregion

                #region lineas Verticales
                gfx.DrawLine(XPens.Black, 315/*primer punto vertical*/, 100/*alineacion del primer punto de la linea desde top*/, 315/*segundo punto vertical*/, 180 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1
                gfx.DrawLine(XPens.Black, 225/*primer punto vertical*/, 180/*alineacion del primer punto de la linea desde top*/, 225/*segundo punto vertical*/, 240 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1
                gfx.DrawLine(XPens.Black, 375/*primer punto vertical*/, 180/*alineacion del primer punto de la linea desde top*/, 375/*segundo punto vertical*/, 240 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1

                gfx.DrawLine(XPens.Black, 170/*primer punto vertical*/, 240/*alineacion del primer punto de la linea desde top*/, 170/*segundo punto vertical*/, 300 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1
                gfx.DrawLine(XPens.Black, 300/*primer punto vertical*/, 240/*alineacion del primer punto de la linea desde top*/, 300/*segundo punto vertical*/, 300 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1
                gfx.DrawLine(XPens.Black, 420/*primer punto vertical*/, 240/*alineacion del primer punto de la linea desde top*/, 420/*segundo punto vertical*/, 300 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1

                gfx.DrawLine(XPens.Black, 300/*primer punto vertical*/, 310/*alineacion del primer punto de la linea desde top*/, 300/*segundo punto vertical*/, 370 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1

                #endregion

                #region Etiquetas y titulos
                gfx.DrawString("Cliente", letra3, XBrushes.Black, new XPoint(42, 120));

                gfx.DrawRectangle(XPens.Black, 90/*alineacion ala derecha o izquierda*/, 110/* top de la figura*/, 210/*ancho de la figura*/, 14/*alto de la figura*/);

                gfx.DrawString("Dirección", letra3, XBrushes.Black, new XPoint(42, 135));

                gfx.DrawRectangle(XPens.Black, 90/*alineacion ala derecha o izquierda*/, 125/* top de la figura*/, 210/*ancho de la figura*/, 14/*alto de la figura*/);

                gfx.DrawString("Teléfono", letra3, XBrushes.Black, new XPoint(42, 150));

                gfx.DrawRectangle(XPens.Black, 90/*alineacion ala derecha o izquierda*/, 140/* top de la figura*/, 210/*ancho de la figura*/, 14/*alto de la figura*/);

                gfx.DrawString("Atendió", letra3, XBrushes.Black, new XPoint(42, 165));

                gfx.DrawRectangle(XPens.Black, 90/*alineacion ala derecha o izquierda*/, 155/* top de la figura*/, 210/*ancho de la figura*/, 14/*alto de la figura*/);

                #endregion
                #region segundo recuadro con informacion de la empresa
                gfx.DrawString("Reporte del Sistema SYSCEM.INC S.A DE C.V", letra, XBrushes.Black, new XPoint(335, 130));
                gfx.DrawString("Calle 3 , avenida 2 Col.Centro, Córdoba, Ver.", letra3, XBrushes.Black, new XPoint(350, 140));
                gfx.DrawString("Telefono: 271-112-25-29 CP: 94550", letra3, XBrushes.Black, new XPoint(350, 150));
                gfx.DrawString("Email: soporte@sicem.one", letra3, XBrushes.Black, new XPoint(353, 160));

                gfx.DrawString("Tipo de servicio", letra4, XBrushes.Black, new XPoint(50, 188));//etiqueta de tipo de servicio

                gfx.DrawRectangle(XPens.Black, 250/*alineacion ala derecha o izquierda*/, 190/* top de la figura*/, 10/*ancho de la figura*/, 10/*alto de la figura*/);//entrada de equipo
                gfx.DrawString("Entrada de Equipo", letra3, XBrushes.Black, new XPoint(265, 199));//etiqueta entrada de equipo
                gfx.DrawRectangle(XPens.Black, 250/*alineacion ala derecha o izquierda*/, 210/* top de la figura*/, 10/*ancho de la figura*/, 10/*alto de la figura*/);//salida  de equipo
                gfx.DrawString("Salida de Equipo", letra3, XBrushes.Black, new XPoint(265, 219));//etiqueta de salida de equipo

                gfx.DrawString("Hora de Entrada", letra3, XBrushes.Black, new XPoint(390, 199));//etiqueta hora de entrada
                gfx.DrawString("Hora de Salida", letra3, XBrushes.Black, new XPoint(390, 219));//etiqueta hora de salida
                gfx.DrawRectangle(XPens.Black, 465/*alineacion ala derecha o izquierda*/, 208/* top de la figura*/, 70/*ancho de la figura*/, 12/*alto de la figura*/);//salida  de equipo
                gfx.DrawString("Servicio a Domicilio", letra3, XBrushes.Black, new XPoint(390, 233));//etiqueta hora de salida
                gfx.DrawRectangle(XPens.Black, 465/*alineacion ala derecha o izquierda*/, 190/* top de la figura*/, 70/*ancho de la figura*/, 12/*alto de la figura*/);//salida  de equipo


                gfx.DrawRectangle(XPens.Black, 480/*alineacion ala derecha o izquierda*/, 226/* top de la figura*/, 10/*ancho de la figura*/, 10/*alto de la figura*/);//check box de servicio a domicilio

                gfx.DrawString("Descripción", letra4, XBrushes.Black, new XPoint(75, 248));//etiqueta descripcion
                gfx.DrawString("Marca", letra4, XBrushes.Black, new XPoint(225, 248));//etiqueta de marca
                gfx.DrawString("Modelo", letra4, XBrushes.Black, new XPoint(342, 248));//etiqueta de modelo
                gfx.DrawString("No. de serie", letra4, XBrushes.Black, new XPoint(447, 248));//etiqueta de modelo

                gfx.DrawString("Condiciones en que se recibe el equipo", letra4, XBrushes.Black, new XPoint(52, 308));//etiqueta de condiciones en que se recibe el equipo
                gfx.DrawString("Falla Reportada", letra4, XBrushes.Black, new XPoint(400, 308));//etiqueta de falla reportada

                gfx.DrawString("Reporte de ingeniería y refacciones utilizadas", letra4, XBrushes.Black, new XPoint(52, 378));//etiqueta de Reporte de ingenieria y refacciones utilizadas
                gfx.DrawString("Observaciones", letra4, XBrushes.Black, new XPoint(52, 448));

                gfx.DrawString("Mano de Obra $", letra4, XBrushes.Black, new XPoint(52, 583));
                gfx.DrawString("Refacciones $", letra4, XBrushes.Black, new XPoint(224, 583));
                gfx.DrawString("Total $", letra4, XBrushes.Black, new XPoint(414, 583));


                gfx.DrawString("Nombre y Firma del Cliente ", letra3, XBrushes.Black, new XPoint(130, 695));
                gfx.DrawString("Nombre y Firma del Tecnico de Servicio  ", letra3, XBrushes.Black, new XPoint(345, 695));
                #endregion

                foreach (Requisicion r in misRequisiciones)
                {

                    PdfPage pagina2 = documento.AddPage();
                    gfx.DrawString(r.TotalFilas.ToString(), letra3, XBrushes.Black, 500, folio);
                    gfx.DrawString(r.Fecha.ToString().Substring(0, 10), letra3, XBrushes.Black, 490, fecha);
                    gfx.DrawString(r.Cliente, letra3, XBrushes.Black, 100, cliente);
                    gfx.DrawString(r.Direccion, letra3, XBrushes.Black, 100, direccion);
                    gfx.DrawString(r.Telefono, letra3, XBrushes.Black, 100, ciudad);

                    gfx.DrawString(r.Empleado, letra3, XBrushes.Black, 100, atendio);
                    gfx.DrawString(r.TipoServicio, letra3, XBrushes.Black, 60, TipoServicio);
                    gfx.DrawString(r.Entrada, letra4, XBrushes.Black, 250, Entrada);
                    gfx.DrawString(r.Salida, letra4, XBrushes.Black, 250, Salida);

                    gfx.DrawString(r.HoraEntrada, letra3, XBrushes.Black, 480, HoraEntrada);
                    gfx.DrawString(r.HoraSalida, letra3, XBrushes.Black, 480, HoraSalida);
                    gfx.DrawString(r.ServicioADomicilio, letra4, XBrushes.Black, 481, ServicioAdomicilio);
                    gfx.DrawString(r.Nombre, letra3, XBrushes.Black, 60, nombreEquipo);
                    gfx.DrawString(r.Marca, letra3, XBrushes.Black, 200, nombreEquipo);
                    gfx.DrawString(r.Modelo, letra3, XBrushes.Black, 310, nombreEquipo);
                    gfx.DrawString(r.NumSerie, letra3, XBrushes.Black, 425, nombreEquipo);




                    if (r.CondicionEquipo.Length <= 52)
                    {
                        gfx.DrawString(r.CondicionEquipo, letra3, XBrushes.Black, 60, condicion);

                    }
                    else
                    {

                        gfx.DrawString(r.CondicionEquipo.Substring(0, 52), letra3, XBrushes.Black, 60, 345);
                        gfx.DrawString(r.CondicionEquipo.Substring(52, 52), letra3, XBrushes.Black, 60, 352);
                        gfx.DrawString(r.CondicionEquipo.Substring(104), letra3, XBrushes.Black, 60, 360);


                    }
                    if (r.FallaReportada.Length <= 52)
                    {
                        gfx.DrawString(r.FallaReportada, letra3, XBrushes.Black, 340, 345);
                    }
                    else
                    {
                        gfx.DrawString(r.FallaReportada.Substring(0, 52), letra3, XBrushes.Black, 340, 345);
                        gfx.DrawString(r.FallaReportada.Substring(52, 52), letra3, XBrushes.Black, 340, 352);
                        gfx.DrawString(r.FallaReportada.Substring(104), letra3, XBrushes.Black, 340, 360);
                    }
                    if (r.ReporteIng.Length <= 124)
                    {
                        gfx.DrawString(r.ReporteIng, letra3, XBrushes.Black, 60, 410);
                    }
                    else
                    {
                        gfx.DrawString(r.ReporteIng.Substring(0, 124), letra3, XBrushes.Black, 60, 390);
                        gfx.DrawString(r.ReporteIng, letra3, XBrushes.Black, 60, 405);
                    }
                    gfx.DrawString(r.Observaciones, letra3, XBrushes.Black, 60, 480);//dibujo del objeto Observaciones de tipo String

                    gfx.DrawString(r.ManoDeObra.ToString(), letra3, XBrushes.Black, 145, 585);
                    gfx.DrawString(r.CostoRefaccion.ToString(), letra3, XBrushes.Black, 315, 585);
                    gfx.DrawString(r.Total.ToString(), letra3, XBrushes.Black, 475, 585);
                    gfx.DrawString(r.Empleado, letra4, XBrushes.Black, 360, 675);
                    if (misRequisiciones.Count > 0)
                    {
                        XImage image2 = XImage.FromFile(Environment.CurrentDirectory + @"\LOGO_RG.png");//esto tambien se debe de repetir en el segundo cuerpo del reporte
                        gfx.DrawImage(image2, 35, 30);
                        image.Interpolate = true;

                        #region cuerpo y cabezera del reporte
                        gfx.DrawString("REPORTE DE SERVICIO", titulo, XBrushes.Black, new XPoint(245, 40));
                        gfx.DrawString("VENTA DE ACCESORIOS PARA COMPUTADORA", letra, XBrushes.Black, new XPoint(225, 50));
                        gfx.DrawString("REFACCIONES, SOPORTE TECNICO ESPECIALIZADO", letra, XBrushes.Black, new XPoint(217, 60));
                        gfx.DrawString("MANTENIMIENTO PREVENTIVO Y CORRECTIVO", letra, XBrushes.Black, new XPoint(225, 70));
                        gfx.DrawRectangle(XPens.Black, 465/*alineacion ala derecha o izquierda*/, 35/* top de la figura*/, 100/*ancho de la figura*/, 25/*alto de la figura*/);
                        gfx.DrawLine(XPens.Black, 465/*alineacion del primerr punto */, 45/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 45/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                        gfx.DrawString("Numero", letra, XBrushes.Black, new XPoint(499, 42));
                        //aqui debe ir el id de la requisicion

                        gfx.DrawRectangle(XPens.Black, 465/*alineacion ala derecha o izquierda*/, 65/* top de la figura*/, 100/*ancho de la figura*/, 25/*alto de la figura*/);
                        gfx.DrawLine(XPens.Black, 465/*alineacion del primerr punto */, 75/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 75/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                        gfx.DrawString("Fecha", letra, XBrushes.Black, new XPoint(499, 72));
                        //aqui debe ir la fecha en la que se realizo la requisicion del servicio

                        gfx.DrawRectangle(XPens.Black, 35/*alineacion ala derecha o izquierda*/, 100/* top de la figura*/, 530/*ancho de la figura*/, 430/*alto de la figura*/);
                        gfx.DrawRectangle(XPens.Black, 36/*alineacion ala derecha o izquierda*/, 101/* top de la figura*/, 529/*ancho de la figura*/, 429/*alto de la figura*/);

                        gfx.DrawRectangle(XPens.Black, 35/*alineacion ala derecha o izquierda*/, 550/* top de la figura*/, 530/*ancho de la figura*/, 180/*alto de la figura*/);
                        gfx.DrawRectangle(XPens.Black, 35/*alineacion ala derecha o izquierda*/, 550/* top de la figura*/, 530/*ancho de la figura*/, 60/*alto de la figura*/);
                        gfx.DrawRectangle(XPens.Black, 45/*alineacion ala derecha o izquierda*/, 560/* top de la figura*/, 510/*ancho de la figura*/, 40/*alto de la figura*/);
                        #endregion
                        #region Lineas Horizontales
                        gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 180/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 180/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 1
                        gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 240/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 240/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                        gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 250/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 250/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                        gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 300/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 300/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 3 
                        gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 310/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 310/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 4 
                        gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 370/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 370/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                        gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 380/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 380/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                        gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 440/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 440/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                        gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 450/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 450/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                        //gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 510/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 510/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                        gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 520/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 520/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
                        //gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 580/*alineacion del primer punto de la linea desde top*/, 565/*segundo punto de la linea a lo ancho*/, 580/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 

                        gfx.DrawRectangle(XPens.Black, 105/*alineacion ala derecha o izquierda*/, 660/* top de la figura*/, 160/*ancho de la figura*/, 20/*alto de la figura*/);
                        gfx.DrawRectangle(XPens.Black, 345/*alineacion ala derecha o izquierda*/, 660/* top de la figura*/, 160/*ancho de la figura*/, 20/*alto de la figura*/);

                        gfx.DrawRectangle(XPens.Black, 135/*alineacion ala derecha o izquierda*/, 574/* top de la figura*/, 80/*ancho de la figura*/, 15/*alto de la figura*/);//caja de texto mano de obra
                        gfx.DrawRectangle(XPens.Black, 300/*alineacion ala derecha o izquierda*/, 574/* top de la figura*/, 80/*ancho de la figura*/, 15/*alto de la figura*/);//caja de texto refacciones
                        gfx.DrawRectangle(XPens.Black, 460/*alineacion ala derecha o izquierda*/, 574/* top de la figura*/, 80/*ancho de la figura*/, 15/*alto de la figura*/);//caja de texto total

                        gfx.DrawLine(XPens.Black, 35/*alineacion del primerr punto */, 190/*alineacion del primer punto de la linea desde top*/, 225/*segundo punto de la linea a lo ancho*/, 190/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 1
                        gfx.DrawLine(XPens.Black, 565/*alineacion del primerr punto */, 223/*alineacion del primer punto de la linea desde top*/, 375/*segundo punto de la linea a lo ancho*/, 223/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 1

                        #endregion

                        #region lineas Verticales
                        gfx.DrawLine(XPens.Black, 315/*primer punto vertical*/, 100/*alineacion del primer punto de la linea desde top*/, 315/*segundo punto vertical*/, 180 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1
                        gfx.DrawLine(XPens.Black, 225/*primer punto vertical*/, 180/*alineacion del primer punto de la linea desde top*/, 225/*segundo punto vertical*/, 240 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1
                        gfx.DrawLine(XPens.Black, 375/*primer punto vertical*/, 180/*alineacion del primer punto de la linea desde top*/, 375/*segundo punto vertical*/, 240 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1

                        gfx.DrawLine(XPens.Black, 170/*primer punto vertical*/, 240/*alineacion del primer punto de la linea desde top*/, 170/*segundo punto vertical*/, 300 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1
                        gfx.DrawLine(XPens.Black, 300/*primer punto vertical*/, 240/*alineacion del primer punto de la linea desde top*/, 300/*segundo punto vertical*/, 300 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1
                        gfx.DrawLine(XPens.Black, 420/*primer punto vertical*/, 240/*alineacion del primer punto de la linea desde top*/, 420/*segundo punto vertical*/, 300 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1

                        gfx.DrawLine(XPens.Black, 300/*primer punto vertical*/, 310/*alineacion del primer punto de la linea desde top*/, 300/*segundo punto vertical*/, 370 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1


                        #endregion

                        #region Etiquetas y titulos
                        gfx.DrawString("Cliente", letra3, XBrushes.Black, new XPoint(42, 120));

                        gfx.DrawRectangle(XPens.Black, 90/*alineacion ala derecha o izquierda*/, 110/* top de la figura*/, 210/*ancho de la figura*/, 14/*alto de la figura*/);

                        gfx.DrawString("Dirección", letra3, XBrushes.Black, new XPoint(42, 135));

                        gfx.DrawRectangle(XPens.Black, 90/*alineacion ala derecha o izquierda*/, 125/* top de la figura*/, 210/*ancho de la figura*/, 14/*alto de la figura*/);

                        gfx.DrawString("Teléfono", letra3, XBrushes.Black, new XPoint(42, 150));

                        gfx.DrawRectangle(XPens.Black, 90/*alineacion ala derecha o izquierda*/, 140/* top de la figura*/, 210/*ancho de la figura*/, 14/*alto de la figura*/);

                        gfx.DrawString("Atendió", letra3, XBrushes.Black, new XPoint(42, 165));

                        gfx.DrawRectangle(XPens.Black, 90/*alineacion ala derecha o izquierda*/, 155/* top de la figura*/, 210/*ancho de la figura*/, 14/*alto de la figura*/);

                        #endregion
                        #region segundo recuadro con informacion de la empresa
                        gfx.DrawString("Reporte del Sistema SYSCEM.INC S.A DE C.V", letra, XBrushes.Black, new XPoint(335, 130));
                        gfx.DrawString("Calle 3 , avenida 2 Col.Centro, Córdoba, Ver.", letra3, XBrushes.Black, new XPoint(350, 140));
                        gfx.DrawString("Telefono: 271-112-25-29 CP: 94550", letra3, XBrushes.Black, new XPoint(350, 150));
                        gfx.DrawString("Email:  soporte@sicem.one", letra3, XBrushes.Black, new XPoint(353, 160));

                        gfx.DrawString("Tipo de servicio", letra4, XBrushes.Black, new XPoint(50, 188));//etiqueta de tipo de servicio

                        gfx.DrawRectangle(XPens.Black, 250/*alineacion ala derecha o izquierda*/, 190/* top de la figura*/, 10/*ancho de la figura*/, 10/*alto de la figura*/);//entrada de equipo
                        gfx.DrawString("Entrada de Equipo", letra3, XBrushes.Black, new XPoint(265, 199));//etiqueta entrada de equipo
                        gfx.DrawRectangle(XPens.Black, 250/*alineacion ala derecha o izquierda*/, 210/* top de la figura*/, 10/*ancho de la figura*/, 10/*alto de la figura*/);//salida  de equipo
                        gfx.DrawString("Salida de Equipo", letra3, XBrushes.Black, new XPoint(265, 219));//etiqueta de salida de equipo

                        gfx.DrawString("Hora de Entrada", letra3, XBrushes.Black, new XPoint(390, 199));//etiqueta hora de entrada
                        gfx.DrawString("Hora de Salida", letra3, XBrushes.Black, new XPoint(390, 219));//etiqueta hora de salida
                        gfx.DrawRectangle(XPens.Black, 465/*alineacion ala derecha o izquierda*/, 208/* top de la figura*/, 70/*ancho de la figura*/, 12/*alto de la figura*/);//salida  de equipo
                        gfx.DrawString("Servicio a Domicilio", letra3, XBrushes.Black, new XPoint(390, 233));//etiqueta hora de salida
                        gfx.DrawRectangle(XPens.Black, 465/*alineacion ala derecha o izquierda*/, 190/* top de la figura*/, 70/*ancho de la figura*/, 12/*alto de la figura*/);//salida  de equipo


                        gfx.DrawRectangle(XPens.Black, 480/*alineacion ala derecha o izquierda*/, 226/* top de la figura*/, 10/*ancho de la figura*/, 10/*alto de la figura*/);//check box de servicio a domicilio

                        gfx.DrawString("Descripción", letra4, XBrushes.Black, new XPoint(75, 248));//etiqueta descripcion
                        gfx.DrawString("Marca", letra4, XBrushes.Black, new XPoint(225, 248));//etiqueta de marca
                        gfx.DrawString("Modelo", letra4, XBrushes.Black, new XPoint(342, 248));//etiqueta de modelo
                        gfx.DrawString("No. de serie", letra4, XBrushes.Black, new XPoint(447, 248));//etiqueta de modelo

                        gfx.DrawString("Condiciones en que se recibe el equipo", letra4, XBrushes.Black, new XPoint(52, 308));//etiqueta de condiciones en que se recibe el equipo
                        gfx.DrawString("Falla Reportada", letra4, XBrushes.Black, new XPoint(400, 308));//etiqueta de falla reportada

                        gfx.DrawString("Reporte de ingeniería y refacciones utilizadas", letra4, XBrushes.Black, new XPoint(52, 378));//etiqueta de Reporte de ingenieria y refacciones utilizadas
                        gfx.DrawString("Observaciones", letra4, XBrushes.Black, new XPoint(52, 448));

                        gfx.DrawString("Mano de Obra $", letra4, XBrushes.Black, new XPoint(52, 583));
                        gfx.DrawString("Refacciones $", letra4, XBrushes.Black, new XPoint(224, 583));
                        gfx.DrawString("Total $", letra4, XBrushes.Black, new XPoint(414, 583));


                        gfx.DrawString("Nombre y Firma del Cliente ", letra3, XBrushes.Black, new XPoint(130, 695));
                        gfx.DrawString("Nombre y Firma del Tecnico de Servicio  ", letra3, XBrushes.Black, new XPoint(345, 695));
                        #endregion

                        pagina.Size = PageSize.Letter;
                        pagina.Orientation = PageOrientation.Portrait;
                        gfx = XGraphics.FromPdfPage(pagina2);


                    }
                    else
                    {


                    }
                }
                /* string archivo = "";
                 SaveFileDialog saveFile = new SaveFileDialog();
                 BitmapImage b = new BitmapImage();
                 saveFile.Title = "Seleccione la carpeta donde desea guardar su reporte";
                 saveFile.Filter = "Todos(*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp;*.pdf";
                 if (saveFile.ShowDialog() == true)
                 {
                     archivo = saveFile.FileName;
                 }
                 else
                 {
                     archivo = "";
                 }

                 if (archivo != "")
                 {
                 */

                documento.Save("C:\\Reportes\\Reporte Num." + nombre + ".pdf");
                System.Diagnostics.Process.Start("C:\\Reportes\\Reporte Num." + nombre + ".pdf");

                /*  }
                  else
                  {*/
                //  MessageBox.Show("Execución Cancelada", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                /*  } */


            }
            catch
            {


            }


        }
    }
}
