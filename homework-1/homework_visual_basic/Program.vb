Imports System.Drawing

Module Module1
    Sub Main()
        ' Creare un'immagine con una dimensione specifica
        Dim width As Integer = 800
        Dim height As Integer = 600
        Using bitmap As New Bitmap(width, height)
            ' Creare un oggetto Graphics dall'immagine
            Using g As Graphics = Graphics.FromImage(bitmap)
                ' Disegnare un punto rosso alle coordinate (50, 50)
                g.FillEllipse(Brushes.Red, 50, 50, 10, 10)

                ' Disegnare una linea blu dalle coordinate (100, 100) a (200, 200)
                g.DrawLine(Pens.Blue, 100, 100, 200, 200)

                ' Disegnare un rettangolo verde con angolo in alto a sinistra alle coordinate (250, 100)
                ' e larghezza 100 e altezza 50
                g.FillRectangle(Brushes.Green, 250, 100, 100, 50)

                ' Disegnare un cerchio arancione con centro alle coordinate (400, 150)
                ' e raggio 50
                g.FillEllipse(Brushes.Orange, 350, 100, 100, 100)
            End Using

            ' Salvare l'immagine in un file (puoi anche visualizzarla o utilizzarla come desideri)
            bitmap.Save("D:\\magistrale\\statistics\\output_visual_basic.png")
        End Using
    End Sub
End Module
