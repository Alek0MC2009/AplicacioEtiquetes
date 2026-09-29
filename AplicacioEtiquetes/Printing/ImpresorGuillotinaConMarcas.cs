
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Printing
{
    public class ImpresorGuillotinaConMarcas
    {
        private List<string> listaPrecios;
        private Font fuenteMunson;
        private const int AnchoEtiqueta = 236; // 6cm mas o menos
        private const int AltoEtiqueta = 118;
        private const int MargenX = 80;
        private const int MargenY = 80;
        private const int Columnas = 3;
        private const int LargoMarcaCorte = 20;

        public ImpresorGuillotinaConMarcas(List<string> precios, Font fuente)
        {
            this.listaPrecios = precios;
            this.fuenteMunson = fuente;
        }

        public PrintDocument CrearPrintDocument()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(DibujarPagina);
            return pd;
        }

        public void LanzarImpresionDirecta()
        {
            using (PrintDocument pd = CrearPrintDocument())
            using (PrintDialog dialog = new PrintDialog())
            {
                dialog.Document = pd;
                dialog.UseEXDialog = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pd.Print();
                }
            }
        }
        private void DibujarPagina(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Pen lapizEtiqueta = new Pen(Color.Black, 2))
            using (Pen lapizCorte = new Pen(Color.Gray, 1) { DashStyle = DashStyle.Dash })
            using (SolidBrush pincelTexto = new SolidBrush(ColorTranslator.FromHtml("#1d1a16")))
            {
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                // Si hay N precios en BD, imprimimos 3 de cada uno (rellenando la fila)
                int totalEtiquetas = listaPrecios.Count * 3;
                int filas = (int)Math.Ceiling((double)totalEtiquetas / Columnas);

                int anchoTotalBloque = Columnas * AnchoEtiqueta;
                int altoTotalBloque = filas * AltoEtiqueta;

                // 1. DIBUJAR MARCAS EXTERNAS DE GUILLOTINA (Fuera del bloque de etiquetas)
                // Guías verticales
                for (int c = 0; c <= Columnas; c++)
                {
                    int posX = MargenX + (c * AnchoEtiqueta);
                    g.DrawLine(lapizCorte, posX, MargenY - LargoMarcaCorte, posX, MargenY);
                    g.DrawLine(lapizCorte, posX, MargenY + altoTotalBloque, posX, MargenY + altoTotalBloque + LargoMarcaCorte);
                }

                // Guías horizontales
                for (int f = 0; f <= filas; f++)
                {
                    int posY = MargenY + (f * AltoEtiqueta);
                    g.DrawLine(lapizCorte, MargenX - LargoMarcaCorte, posY, MargenX, posY);
                    g.DrawLine(lapizCorte, MargenX + anchoTotalBloque, posY, MargenX + anchoTotalBloque + LargoMarcaCorte, posY);
                }

                // 2. DIBUJAR LAS ETIQUETAS Y SUS TEXTOS
                int col = 0;
                int fila = 0;

                foreach (string precio in listaPrecios)
                {
                    // Cada precio se repite 3 veces consecutivas para ocupar toda la fila de la rejilla
                    for (int rep = 0; rep < 3; rep++)
                    {
                        int x = MargenX + (col * AnchoEtiqueta);
                        int y = MargenY + (fila * AltoEtiqueta);

                        Rectangle rectEtiqueta = new Rectangle(x, y, AnchoEtiqueta, AltoEtiqueta);

                        // Borde continuo de la etiqueta
                        g.DrawRectangle(lapizEtiqueta, rectEtiqueta);

                        // Texto del precio centrado con Munson Bold
                        g.DrawString(precio, fuenteMunson, pincelTexto, rectEtiqueta, format);

                        col++;
                        if (col >= Columnas)
                        {
                            col = 0;
                            fila++;
                        }
                    }
                }
            }
        }
    }
}