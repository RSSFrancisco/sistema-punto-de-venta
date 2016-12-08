using System;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using Datos;
namespace Negocios
{
    public class Reportes
    {
        public void Generando(List<Empleado> misEmpleados)
        {

            PdfDocument documento = new PdfDocument();
            XGraphics gfx = null;
            XFont letra = new XFont("Times New Roman", 12);
            PdfPage pagina = documento.AddPage();
            pagina.Orientation = PageOrientation.Landscape;
            gfx = XGraphics.FromPdfPage(pagina);
            gfx.DrawString("BaseArvel", letra, XBrushes.Red, new Point(400, 40));
            gfx.DrawString("Empleado", letra, XBrushes.Green, new Point(400, 65));
            int y = 90;
            gfx.DrawString("Nombre", letra, XBrushes.Black, new Point(150, y));
            gfx.DrawString("appaterno", letra, XBrushes.Black, new Point(280, y));
            gfx.DrawString("apmaterno", letra, XBrushes.Black, new Point(410, y));
            gfx.DrawString("nss", letra, XBrushes.Black, new Point(490, y));
            gfx.DrawString("fechanacimiento", letra, XBrushes.Black, new Point(600, y));
            gfx.DrawString("direccion", letra, XBrushes.Black, new Point(600, y));
            gfx.DrawString("colonia", letra, XBrushes.Black, new Point(600, y));
            gfx.DrawString("ciudad", letra, XBrushes.Black, new Point(600, y));
            gfx.DrawString("estado", letra, XBrushes.Black, new Point(600, y));
            gfx.DrawString("cp", letra, XBrushes.Black, new Point(600, y));
            gfx.DrawString("telefono", letra, XBrushes.Black, new Point(600, y));
            gfx.DrawString("correo", letra, XBrushes.Black, new Point(600, y));
            gfx.DrawString("nivelescolar", letra, XBrushes.Black, new Point(600, y));
            gfx.DrawString("especialidad", letra, XBrushes.Black, new Point(600, y));
            y += 25;

            foreach (Empleado e in misEmpleados)
            {
                gfx.DrawString(e.Nombre, letra, XBrushes.Red, 150, y);
                gfx.DrawString(e.ApPaterno.ToString(), letra, XBrushes.Red, 280, y);
                gfx.DrawString(e.ApMaterno.ToString(), letra, XBrushes.Red, 410, y);
                gfx.DrawString(e.NSS, letra, XBrushes.Red, 490, y);
                gfx.DrawString(e.Direccion, letra, XBrushes.Red, 600, y);
                y += 20;
            }
            if (y > 500)
            {
                y = 90;
                pagina = documento.AddPage();
                pagina.Orientation = PageOrientation.Landscape;
                gfx = XGraphics.FromPdfPage(pagina);
            }
            documento.Save("ReporteEmpleado.pdf");
            System.Diagnostics.Process.Start("ReporteEmpleado.pdf");

        }
        public void GenerandoEmpresa(List<Empresa> misEmpresas) 
        {

            PdfDocument documento = new PdfDocument();
            XGraphics gfx = null;
            XFont letra = new XFont("Times New Roman", 12);
            PdfPage pagina = documento.AddPage();
            pagina.Orientation = PageOrientation.Landscape;
            gfx = XGraphics.FromPdfPage(pagina);
            gfx.DrawString("Sistema Integral Arvel", letra, XBrushes.Red, new Point(375, 40));
            gfx.DrawString("Tabla Empresa", letra, XBrushes.Green, new Point(390, 65));
            int y = 90;
          
            gfx.DrawString("RFC", letra, XBrushes.Black, new Point(150, y));
            gfx.DrawString("Siglas", letra, XBrushes.Black, new Point(280, y));
            gfx.DrawString("Nombre", letra, XBrushes.Black, new Point(360, y));
            gfx.DrawString("Giro", letra, XBrushes.Black, new Point(450, y));
            gfx.DrawString("direccion", letra, XBrushes.Black, new Point(520, y));
            gfx.DrawString("ciudad", letra, XBrushes.Black, new Point(620, y));
         
            y += 25;

            foreach (Empresa e in misEmpresas)
            {
                
                gfx.DrawString(e.Rfc, letra, XBrushes.Blue, 150, y);
               
                gfx.DrawString(e.Siglas, letra, XBrushes.Blue, 280, y);
                gfx.DrawString(e.Nombre, letra, XBrushes.Blue, 360, y);
                gfx.DrawString(e.Giro, letra, XBrushes.Blue, 450, y);
                gfx.DrawString(e.Direccion, letra, XBrushes.Blue, 520, y);
                gfx.DrawString(e.Ciudad, letra, XBrushes.Blue, 620, y);
                y += 20;
            }
            if (y > 500)
            {
                y = 90;
                pagina = documento.AddPage();
                pagina.Orientation = PageOrientation.Landscape;
                gfx = XGraphics.FromPdfPage(pagina);
            }
            documento.Save("ReporteEmpresa.pdf");
            System.Diagnostics.Process.Start("ReporteEmpresa.pdf");

        }
        public void GenerandoProveedor(List<Proveedor> miProveedor)
        {

            PdfDocument documento = new PdfDocument();
            XGraphics gfx = null;
            XFont letra = new XFont("Times New Roman", 12);
            PdfPage pagina = documento.AddPage();
            pagina.Orientation = PageOrientation.Landscape;
            gfx = XGraphics.FromPdfPage(pagina);
            gfx.DrawString("Sistema Integral Arvel", letra, XBrushes.Red, new Point(375, 40));
            gfx.DrawString("Tabla Proveedor", letra, XBrushes.Green, new Point(390, 65));
            int y = 90;

            gfx.DrawString("RFC", letra, XBrushes.Black, new Point(150, y));
            gfx.DrawString("Siglas", letra, XBrushes.Black, new Point(280, y));
            gfx.DrawString("Nombre", letra, XBrushes.Black, new Point(360, y));
            gfx.DrawString("Giro", letra, XBrushes.Black, new Point(450, y));
            gfx.DrawString("direccion", letra, XBrushes.Black, new Point(520, y));
            gfx.DrawString("ciudad", letra, XBrushes.Black, new Point(620, y));

            y += 25;

            foreach (Proveedor e in miProveedor )
            {

                gfx.DrawString(e.Rfc, letra, XBrushes.Blue, 150, y);

                //gfx.DrawString(e.Siglas, letra, XBrushes.Blue, 280, y);
                gfx.DrawString(e.Nombre, letra, XBrushes.Blue, 360, y);
                //gfx.DrawString(e.Giro, letra, XBrushes.Blue, 450, y);
                gfx.DrawString(e.Direccion, letra, XBrushes.Blue, 520, y);
                gfx.DrawString(e.Ciudad, letra, XBrushes.Blue, 620, y);
                y += 20;
            }
            if (y > 500)
            {
                y = 90;
                pagina = documento.AddPage();
                pagina.Orientation = PageOrientation.Landscape;
                gfx = XGraphics.FromPdfPage(pagina);
            }
            documento.Save("ReporteProveedor.pdf");
            System.Diagnostics.Process.Start("ReporteProveedor.pdf");

        }
    }

}