Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '*****EJERCICIO QUE ME PIDE UNA FRASE ME TIENE QUE DECIR DE CUÁNTAS PALABRAS ES LA FRASE

        Dim CONTADOR As Integer
        Dim MIDE As Integer
        Dim FRASE As String
        Dim LETRA As Char
        FRASE = InputBox(" INGRESE UNA FRASE")
        MIDE = Len(FRASE)
        For I = 1 To MIDE
            LETRA = Mid(FRASE, I, 1)
            If LETRA = " " Then CONTADOR = CONTADOR + 1
        Next
        MsgBox("EL NUMERO DE PALABRAS ES " & CONTADOR + 1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '****HACE UN RECORRIDO DE LA PALABRA 
        Dim FLAG As Boolean
        Dim PALABRA As String
        Dim DE, AT As Char
        Dim MIDE As Integer
        Dim R As Integer

        PALABRA = InputBox(" INGRESE PALABRA A COMPROBAR")
        MIDE = Len(PALABRA)

        R = MIDE
        FLAG = True
        For I = 1 To MIDE
            DE = Mid(PALABRA, I, 1)
            AT = Mid(PALABRA, R, 1)
            If DE <> AT Then
                MsgBox("NO PALINDROMA")
                Exit For
            End If
            R = R - 1
        Next


        If FLAG <> False Then  '***CUANDO SALE PALINDROMA, SE LEE IGUAL DE IZQUIERDA A DERECHA QUE DE DERECHA A IZQUIERDA.
            MsgBox("PALINDROMA")
        End If
    End Sub
End Class
