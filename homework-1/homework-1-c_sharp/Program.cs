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
                // Disegnare un punto rosso alle coordinate (50, 50)
                g.FillEllipse(Brushes.Red, 50, 50, 10, 10);

                // Disegnare una linea blu dalle coordinate (100, 100) a (200, 200)
                g.DrawLine(Pens.Blue, 100, 100, 200, 200);

                // Disegnare un rettangolo verde con angolo in alto a sinistra alle coordinate (250, 100)
                // e larghezza 100 e altezza 50
                g.FillRectangle(Brushes.Green, 250, 100, 100, 50);

                // Disegnare un cerchio arancione con centro alle coordinate (400, 150)
                // e raggio 50
                g.FillEllipse(Brushes.Orange, 350, 100, 100, 100);
            }

            // Salvare l'immagine in un file (puoi anche visualizzarla o utilizzarla come desideri)
            bitmap.Save("D:\\magistrale\\statistics\\output.png");
        }
    }
}
