using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Data
{
    public static class FontHelper
    {
        private static PrivateFontCollection pfc = new PrivateFontCollection();

        // Importación de la API nativa de Windows para registrar fuentes desde memoria
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        public static Font CargarFuenteDesdeRecursos(byte[] fontBytes, float size, FontStyle style = FontStyle.Regular)
        {
            if (fontBytes == null || fontBytes.Length == 0)
            {
                return new Font("Segoe UI", size, style);
            }

            // Reservar memoria no administrada
            IntPtr fontData = Marshal.AllocCoTaskMem(fontBytes.Length);
            Marshal.Copy(fontBytes, 0, fontData, fontBytes.Length);

            // 1. Agregar a PrivateFontCollection
            pfc.AddMemoryFont(fontData, fontBytes.Length);

            // 2. Registrar la fuente en el sistema GDI32 de Windows
            uint cFonts = 0;
            AddFontMemResourceEx(fontData, (uint)fontBytes.Length, IntPtr.Zero, ref cFonts);

            // Liberar la memoria reservada
            Marshal.FreeCoTaskMem(fontData);

            // Devolver la fuente creada a partir de la primera familia de la colección
            if (pfc.Families.Length > 0)
            {
                // Si el estilo solicitado no es soportado, se intenta con el estilo disponible en la familia
                FontFamily familia = pfc.Families[0];

                if (familia.IsStyleAvailable(style))
                {
                    return new Font(familia, size, style);
                }
                else if (familia.IsStyleAvailable(FontStyle.Regular))
                {
                    return new Font(familia, size, FontStyle.Regular);
                }
                else
                {
                    return new Font(familia, size);
                }
            }

            return new Font("Segoe UI", size, style);
        }
    }
}