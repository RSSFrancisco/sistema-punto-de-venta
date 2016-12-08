using System;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using Negocios;

namespace Presentacion
{
    class reporteServicio
    {

        public void Generando(List<Empleado> misEmpleados)//publica la variable Generando la cual lleva como parametros la lista del tipo empleado que trae misEmpleados
        {
            PdfDocument documento = new PdfDocument();
            XGraphics gfx = null;
            XImage image = XImage.FromFile(Environment.CurrentDirectory + @"\logo RG Soluciones Ciberneticas.png");
            XFont titulo = new XFont("Arial Black", 12);
            XFont letra = new XFont("Arial", 7);
            XFont letra2 = new XFont("Arial Black", 7);
            PdfPage pagina = documento.AddPage();
            pagina.Size = PageSize.Letter;
            pagina.Orientation = PageOrientation.Portrait;
            gfx = XGraphics.FromPdfPage(pagina);
            image.Interpolate = true;
            gfx.DrawImage(image, 35, 30);
            gfx.DrawString("Empleados", titulo, XBrushes.Black, new XPoint(50, 150));
            //int y = 200;
            //int x = 50;


          

  



 gfx.DrawRectangle(XPens.Black, 46/*alineacion ala derecha o izquierda*/, 70/* top de la figura*/, 400/*ancho de la figura*/, 400/*alto de la figura*/);

 gfx.DrawLine(XPens.Black, 46/*alineacion top de la linea*/,100/*alineacion del primer punto de la linea desde top*/, 234/*largo de la linea*/, 100/*alineacion del segundo punto de la linea desde top*/);

            //esto es para hacer todo tipo de lineas 
            XPen pen = new XPen (XColors.Navy, 4);
            gfx.DrawLine(pen, 0, 20, 250, 20);
 
          pen = new XPen (XColors.Firebrick, 6);
 pen.DashStyle = XDashStyle.Dash;
  gfx.DrawLine (pen, 0, 40, 250, 40);
 pen.Width = 7;
 pen.DashStyle = XDashStyle.DashDotDot;
  gfx.DrawLine (pen, 0, 60, 250, 60);

            pen = new XPen (XColors.Firebrick, 6);
pen.DashStyle = XDashStyle.Dash;
 gfx.DrawLine (pen, 0, 40, 250, 40);
pen.Width = 3;
pen.DashStyle = XDashStyle.DashDotDot;
 gfx.DrawLine (pen, 0, 60, 250, 60);

 pen = new XPen (XColors.Goldenrod, 10);
pen.LineCap = XLineCap.Flat;
 gfx.DrawLine (pen, 10, 90, 240, 90);
 gfx.DrawLine (XPens.Black, 10, 90, 240, 90);

pen = new XPen (XColors.Goldenrod, 10);
pen.LineCap = XLineCap.Square;
 gfx.DrawLine (pen, 10, 110, 240, 110);
 gfx.DrawLine (XPens.Black, 10, 110, 240, 110);

 pen = new XPen (XColors.Goldenrod, 10);
pen.LineCap = XLineCap.Round;
 gfx.DrawLine (pen, 10, 130, 240, 130);
 gfx.DrawLine (XPens.Black, 10, 130, 240, 130);


            //esto es para dibujar una polilinea
   pen = new XPen (XColors.DarkSeaGreen, 6);
 pen.LineCap = XLineCap.Round;
 pen.LineJoin = XLineJoin.Bevel;
 XPoint [] puntos =
   new XPoint [] { new XPoint (20, 30), new XPoint (60, 120), new XPoint (90, 20), new XPoint (170, 90), new XPoint (230, 40)};
 gfx.DrawLines (pen, puntos);

            //esto es para dibujar una curva beizier

            XPoint [] punto = new XPoint [] { new XPoint (20, 30), new XPoint (40, 120), new XPoint (80, 20), new XPoint (110, 90),
                                new XPoint (180, 40), new XPoint (210, 40), new XPoint (220, 80)};
XPen pen2 = new XPen (XColors.Firebrick, 4);
gfx.DrawBeziers (pen2, punto);

            //dibujar un spline cardinal
              XPoint [] puntoSpline =
   new XPoint [] { new XPoint (20, 30), new XPoint (60, 120), new XPoint (90, 20), new XPoint (170, 90), new XPoint (230, 40)};
 XPen penSpline = new XPen (XColors.RoyalBlue, 3.5);
  gfx.DrawCurve (penSpline, puntoSpline, 1);


    
                documento.Save("ReporteServicio.pdf");
                System.Diagnostics.Process.Start("ReporteServicio.pdf");
            }
        }
    }






       