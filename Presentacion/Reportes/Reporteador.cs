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
    public class Reporteador
    {

        public void generar(List<Empleado> misEmpleados)
        {
            PdfDocument documento = new PdfDocument();
            XGraphics gfx = null;
            XImage image = XImage.FromFile(Environment.CurrentDirectory + @"\Empleados.png");
            XFont titulo = new XFont("Arial Black", 12);
            XFont letra = new XFont("Arial", 7);
            XFont letra2 = new XFont("Arial Black", 7);
            PdfPage pagina = documento.AddPage();
            pagina.Size = PageSize.Letter;
            pagina.Orientation = PageOrientation.Portrait;
            gfx = XGraphics.FromPdfPage(pagina);
            image.Interpolate = true;
            gfx.DrawImage(image, 35, 30);
            gfx.DrawString("Reporte de Empleados", titulo, XBrushes.Black, new XPoint(250, 50));
            int y = 135;
            //int x = 100;

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 120/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 120/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 1
            gfx.DrawRectangle(XPens.Black, 30/*alineacion ala derecha o izquierda*/, 25/* top de la figura*/, 550/*ancho de la figura*/, 720/*alto de la figura*/);
            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 145/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 145/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 2 
            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 170/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 170/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 3 

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 195/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 195/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 4

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 220/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 220/*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 5

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 245/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 245 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 6

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 270/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 270 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 7 

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 295/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 295 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 8

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 320/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 320 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 9


            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 345/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 345 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 10 


            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 370/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 370 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 11 


            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 395/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 395 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 12


            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 420/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 420 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 13


            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 445/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 445 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 14

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 470/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 470 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 15

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 495/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 495 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 16 

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 520/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 520 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 17

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 545/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 545 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 18 

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 570/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 570 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 19 


            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 595/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 595 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 20 

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 620/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 620 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 21 

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 645 /*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 645 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 22 


            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 670 /*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 670  /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 23 

            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 695/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 695 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 24 
            gfx.DrawLine(XPens.Black, 30/*alineacion top de la linea*/, 720/*alineacion del primer punto de la linea desde top*/, 580/*largo de la linea*/, 720 /*alineacion del segundo punto de la linea desde top*/);//linea horizontal numero 25 

            gfx.DrawLine(XPens.Black, 150/*alineacion top de la linea*/, 120/*alineacion del primer punto de la linea desde top*/, 150/*largo de la linea*/, 745 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 1

            gfx.DrawLine(XPens.Black, 270/*alineacion top de la linea*/, 120/*alineacion del primer punto de la linea desde top*/, 270/*largo de la linea*/, 745 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 2
            gfx.DrawLine(XPens.Black, 410/*alineacion top de la linea*/, 120/*alineacion del primer punto de la linea desde top*/, 410/*largo de la linea*/, 745 /*alineacion del segundo punto de la linea desde top*/);//linea vertical numero 3



            gfx.DrawString("Nombre", letra2, XBrushes.Black, new XPoint(50, y));
            gfx.DrawString("Apellido Paterno", letra2, XBrushes.Black, new XPoint(160, y));
            gfx.DrawString("Apellido Materno", letra2, XBrushes.Black, new XPoint(290, y));
            gfx.DrawString("NSS", letra2, XBrushes.Black, new XPoint(420, y));

            y += 25;
            GenerandoLista(misEmpleados);
            documento.Save("miNuevoEmpleado.pdf");

            System.Diagnostics.Process.Start("miNuevoEmpleado.pdf");
        }
       public void GenerandoLista(List<Empleado> misEmpleados)
       {
           
           foreach (Empleado d in misEmpleados)
           {
               
               int y = 135;
               XGraphics gfx = null;
               XFont letra = new XFont("Arial", 7);
               gfx.DrawString(d.Nombre, letra, XBrushes.Black, 50, y);
               gfx.DrawString(d.ApPaterno, letra, XBrushes.Black, 160, y);
               gfx.DrawString(d.ApMaterno.ToString(), letra, XBrushes.Black, 290, y);
               gfx.DrawString(d.NSS.ToString(), letra, XBrushes.Black, 420, y);
           }
       }


    }
}
