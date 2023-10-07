Imports System.Drawing

Module Module1
    Sub Main()
        ' Creare un'immagine con una dimensione specifica
        Dim width As Integer = 800
        Dim height As Integer = 600
        Using bitmap As New Bitmap(width, height)
            ' Creare un oggetto Graphics dall'immagine
            Using g As Graphics = Graphics.FromImage(bitmap)
                ' Disegno un punto rosso 
                g.FillEllipse(Brushes.Red, 50, 50, 10, 10)

                ' Disegno una linea blu 
                g.DrawLine(Pens.Blue, 100, 100, 200, 200)

                ' Disegno un rettangolo verde 
                g.FillRectangle(Brushes.Green, 250, 100, 100, 50)

                ' Disegno un cerchio arancione
                g.FillEllipse(Brushes.Orange, 350, 100, 100, 100)
            End Using

            ' Salvare l'immagine in un file 
            bitmap.Save("C:\\output_visual_basic.png")
        End Using
    End Sub
End Module
