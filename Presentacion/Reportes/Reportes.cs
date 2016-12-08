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
    public class Reportes
    {
      
        
        public void Generando(List<Empleado> misEmpleados)//publica la variable Generando la cual lleva como parametros la lista del tipo empleado que trae misEmpleados
        {

            {
                /*
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
                int y = 200;
                int x = 50;
                
                
              
                
               

                XPen pen = new XPen(XColors.Black, Math.PI);

                gfx.DrawRectangle(pen, 500, 50, 100, 60);


                gfx.DrawString("Nombre", letra2, XBrushes.Black, new XPoint(500,x));
                gfx.DrawString("Apellido Paterno", letra2, XBrushes.Black, new XPoint(150, y));
                gfx.DrawString("Apellido Materno", letra2, XBrushes.Black, new XPoint(300, y));
                gfx.DrawString("NSS", letra2, XBrushes.Black, new XPoint(420, y));

                y += 25;

                foreach (Empleado d in misEmpleados)
                {
                    gfx.DrawString(d.Nombre, letra, XBrushes.Black, 500, 65);
                    gfx.DrawString(d.ApPaterno, letra, XBrushes.Black, 150, y);
                    gfx.DrawString(d.ApMaterno.ToString(), letra, XBrushes.Black, 300, y);
                    gfx.DrawString(d.NSS.ToString(), letra, XBrushes.Black, 420, y);

                    y += 20;
                }
                if (y > 500)
                {
                    y = 90;
                    pagina = documento.AddPage();
                    pagina.Orientation = PageOrientation.Portrait;
                    gfx = XGraphics.FromPdfPage(pagina);

                }

                documento.Save("ReporteEmpleados.pdf");
                System.Diagnostics.Process.Start("ReporteEmpleados.pdf");
            }
        }
        public void GenerandoEmpresa(List<Empresa> misEmpresas)
        {
            {
                PdfDocument documento = new PdfDocument();
                XGraphics gfx = null;
                XImage image = XImage.FromFile(Environment.CurrentDirectory + @"\Reporte.png");
                XFont titulo = new XFont("Arial Black", 16);
                XFont letra = new XFont("Arial", 12);
                XFont letra2 = new XFont("Arial Black", 12);
                PdfPage pagina = documento.AddPage();
                pagina.Size = PageSize.Letter;
                pagina.Orientation = PageOrientation.Portrait;
                gfx = XGraphics.FromPdfPage(pagina);
                image.Interpolate = true;
                gfx.DrawImage(image, 0, 0);
                gfx.DrawString("Empresas", titulo, XBrushes.Black, new XPoint(50, 150));
                int y = 200;
                gfx.DrawString("RFC", letra2, XBrushes.Black, new XPoint(50, y));
                gfx.DrawString("Siglas", letra2, XBrushes.Black, new XPoint(150, y));
                gfx.DrawString("Nombre", letra2, XBrushes.Black, new XPoint(300, y));
                gfx.DrawString("Giro", letra2, XBrushes.Black, new XPoint(420, y));
                gfx.DrawString("Dirección", letra2, XBrushes.Black, new XPoint(500, y));


                y += 25;

                foreach (Empresa d in misEmpresas)
                {
                    gfx.DrawString(d.Rfc, letra, XBrushes.Black, 50, y);
                    gfx.DrawString(d.Siglas, letra, XBrushes.Black, 150, y);
                    gfx.DrawString(d.Nombre.ToString(), letra, XBrushes.Black, 300, y);
                    gfx.DrawString(d.Giro.ToString(), letra, XBrushes.Black, 420, y);
                    gfx.DrawString(d.Direccion.ToString(), letra, XBrushes.Black, 500, y);

                    y += 20;
                }
                if (y > 500)
                {
                    y = 90;
                    pagina = documento.AddPage();
                    pagina.Orientation = PageOrientation.Portrait;
                    gfx = XGraphics.FromPdfPage(pagina);

                }

                documento.Save("ReporteEmpresa.pdf");
                System.Diagnostics.Process.Start("ReporteEmpresa.pdf");
            }
        }

        public void GenerandoProveedor(List<Proveedor> miProveedor)
        {
            {
                PdfDocument documento = new PdfDocument();
                XGraphics gfx = null;
                XImage image = XImage.FromFile(Environment.CurrentDirectory + @"\Reporte.png");
                XFont titulo = new XFont("Arial Black", 16);
                XFont letra = new XFont("Arial", 12);
                XFont letra2 = new XFont("Arial Black", 12);
                PdfPage pagina = documento.AddPage();
                pagina.Size = PageSize.Letter;
                pagina.Orientation = PageOrientation.Portrait;
                gfx = XGraphics.FromPdfPage(pagina);
                image.Interpolate = true;
                gfx.DrawImage(image, 0, 0);
                gfx.DrawString("Proveedor", titulo, XBrushes.Black, new XPoint(50, 150));
                int y = 200;
                gfx.DrawString("RFC", letra2, XBrushes.Black, new XPoint(50, y));
                gfx.DrawString("Nombre", letra2, XBrushes.Black, new XPoint(150, y));
                gfx.DrawString("Dirección", letra2, XBrushes.Black, new XPoint(300, y));
                gfx.DrawString("Colonia", letra2, XBrushes.Black, new XPoint(420, y));
                gfx.DrawString("Ciudad", letra2, XBrushes.Black, new XPoint(500, y));
                y += 25;

                foreach (Proveedor d in miProveedor)
                {
                    gfx.DrawString(d.Rfc, letra, XBrushes.Black, 50, y);
                   gfx.DrawString(d.Nombre, letra, XBrushes.Black, 150, y);
                    gfx.DrawString(d.Direccion.ToString(), letra, XBrushes.Black, 300, y);
                   gfx.DrawString(d.Colonia.ToString(), letra, XBrushes.Black, 420, y);
                   gfx.DrawString(d.Ciudad.ToString(), letra, XBrushes.Black, 500, y);

                    y += 20;
                }
                if (y > 500)
                {
                    y = 90;
                    pagina = documento.AddPage();
                    pagina.Orientation = PageOrientation.Portrait;
                    gfx = XGraphics.FromPdfPage(pagina);

                }

                documento.Save("ReporteProveedor.pdf");
                System.Diagnostics.Process.Start("ReporteProveedor.pdf");
            }
        }
        public void GenerandoContacto(List<Contacto> miContacto)
        {
            {
                PdfDocument documento = new PdfDocument();
                XGraphics gfx = null;
                XImage image = XImage.FromFile(Environment.CurrentDirectory + @"\Reporte.png");
                XFont titulo = new XFont("Arial Black", 16);
                XFont letra = new XFont("Arial", 12);
                XFont letra2 = new XFont("Arial Black", 12);
                PdfPage pagina = documento.AddPage();
                pagina.Size = PageSize.Letter;
                pagina.Orientation = PageOrientation.Portrait;
                gfx = XGraphics.FromPdfPage(pagina);
                image.Interpolate = true;
                gfx.DrawImage(image, 0, 0);
                gfx.DrawString("Contactos", titulo, XBrushes.Black, new XPoint(50, 150));
                int y = 200;
                gfx.DrawString("Nombre", letra2, XBrushes.Black, new XPoint(50, y));
                gfx.DrawString("Apellido Paterno", letra2, XBrushes.Black, new XPoint(150, y));
                gfx.DrawString("Apellido Materno", letra2, XBrushes.Black, new XPoint(300, y));
                gfx.DrawString("Telefono", letra2, XBrushes.Black, new XPoint(420, y));
                gfx.DrawString("Extención", letra2, XBrushes.Black, new XPoint(500, y));
                y += 25;

                foreach (Contacto d in miContacto)
                {
                    gfx.DrawString(d.Nombre, letra, XBrushes.Black, 50, y);
                    gfx.DrawString(d.ApellidoPaterno, letra, XBrushes.Black, 150, y);
                    gfx.DrawString(d.ApellidoMaterno.ToString(), letra, XBrushes.Black, 300, y);
                    gfx.DrawString(d.Telefono.ToString(), letra, XBrushes.Black, 420, y);
                    gfx.DrawString(d.Extension.ToString(), letra, XBrushes.Black, 500, y);

                    y += 20;
                }
                if (y > 500)
                {
                    y = 90;
                    pagina = documento.AddPage();
                    pagina.Orientation = PageOrientation.Portrait;
                    gfx = XGraphics.FromPdfPage(pagina);

                }

                documento.Save("ReporteContacto.pdf");
                System.Diagnostics.Process.Start("ReporteContacto.pdf");
            }
        }
        public void GenerandoProducto(List<Producto> miProducto)
        {
            {
                PdfDocument documento = new PdfDocument();
                XGraphics gfx = null;
                XImage image = XImage.FromFile(Environment.CurrentDirectory + @"\Reporte.png");
                XFont titulo = new XFont("Arial Black", 16);
                XFont letra = new XFont("Arial", 12);
                XFont letra2 = new XFont("Arial Black", 12);
                PdfPage pagina = documento.AddPage();
                pagina.Size = PageSize.Letter;
                pagina.Orientation = PageOrientation.Portrait;
                gfx = XGraphics.FromPdfPage(pagina);
                image.Interpolate = true;
                gfx.DrawImage(image, 0, 0);
                gfx.DrawString("Productos", titulo, XBrushes.Black, new XPoint(50, 150));
                int y = 200;
                gfx.DrawString("Nombre", letra2, XBrushes.Black, new XPoint(50, y));
                gfx.DrawString("Marca", letra2, XBrushes.Black, new XPoint(150, y));
                gfx.DrawString("Descripción", letra2, XBrushes.Black, new XPoint(300, y));
                gfx.DrawString("Proveedor", letra2, XBrushes.Black, new XPoint(420, y));
                gfx.DrawString("Fecha de Compra", letra2, XBrushes.Black, new XPoint(500, y));
                y += 25;

                foreach (Producto d in miProducto)
                {
                    gfx.DrawString(d.Nombre, letra, XBrushes.Black, 50, y);
                    gfx.DrawString(d.Marca, letra, XBrushes.Black, 150, y);
                    gfx.DrawString(d.Descripcion.ToString(), letra, XBrushes.Black, 300, y);
                    gfx.DrawString(d.Idproveedor.ToString(), letra, XBrushes.Black, 420, y);
                    gfx.DrawString(d.FechaCompra.ToString(), letra, XBrushes.Black, 500, y);

                    y += 20;
                }
                if (y > 500)
                {
                    y = 90;
                    pagina = documento.AddPage();
                    pagina.Orientation = PageOrientation.Portrait;
                    gfx = XGraphics.FromPdfPage(pagina);

                }

                documento.Save("ReporteProducto.pdf");
                System.Diagnostics.Process.Start("ReporteProducto.pdf");
            }
        }
        public void GenerandoServicio(List<Servicio> miServicio)
        {
            {
                PdfDocument documento = new PdfDocument();
                XGraphics gfx = null;
                XImage image = XImage.FromFile(Environment.CurrentDirectory + @"\Reporte.png");
                XFont titulo = new XFont("Arial Black", 16);
                XFont letra = new XFont("Arial", 12);
                XFont letra2 = new XFont("Arial Black", 12);
                PdfPage pagina = documento.AddPage();
                pagina.Size = PageSize.Letter;
                pagina.Orientation = PageOrientation.Portrait;
                gfx = XGraphics.FromPdfPage(pagina);
                image.Interpolate = true;
                gfx.DrawImage(image, 0, 0);
                gfx.DrawString("Servicios", titulo, XBrushes.Black, new XPoint(50, 150));
                int y = 200;
               
                gfx.DrawString("Nombre", letra2, XBrushes.Black, new XPoint(150, y));
                gfx.DrawString("Precio Unitario", letra2, XBrushes.Black, new XPoint(300, y));
                
                y += 25;

                foreach (Servicio d in miServicio)
                {
                  
                    gfx.DrawString(d.Nombre, letra, XBrushes.Black, 150, y);
                    gfx.DrawString(d.PrecioUnitario.ToString(), letra, XBrushes.Black, 300, y);
                   
                    y += 20;
                }
                if (y > 500)
                {
                    y = 90;
                    pagina = documento.AddPage();
                    pagina.Orientation = PageOrientation.Portrait;
                    gfx = XGraphics.FromPdfPage(pagina);

                }

                documento.Save("ReporteServicio.pdf");
                System.Diagnostics.Process.Start("ReporteServicio.pdf");*/
            }
        }
  }
}