using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Creare un'immagine con una dimensione specifica
        int width = 800;
        int height = 600;
        using (Bitmap bitmap = new Bitmap(width, height))
        {
            // Creare un oggetto Graphics dall'immagine
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Disegno un punto 
                g.FillEllipse(Brushes.Red, 50, 50, 10, 10);

                // Disegno una linea blu 
                g.DrawLine(Pens.Blue, 100, 100, 200, 200);

                // Disegno un rettangolo verde
                g.FillRectangle(Brushes.Green, 250, 100, 100, 50);

                // Disegno un cerchio arancione
                g.FillEllipse(Brushes.Orange, 350, 100, 100, 100);
            }

            // Salvare l'immagine in un file
            bitmap.Save("C:\\output.png");
        }
    }
}
