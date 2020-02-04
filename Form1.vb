Public Class Form1

    Dim b(4) As String
    Dim a(4, 3) As Decimal
    Dim i As Integer
    Dim cadena As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i = 0 To 3

            b(i) = InputBox("introduce el nombre")
            a(i, 0) = InputBox("Notas primer parcial")
            a(i, 1) = InputBox("Notas segundo parcial")
            a(i, 2) = (a(i, 0) + a(i, 1)) / 2
            cadena = cadena & "Alumno " & b(i) & " notas 1R =" & a(i, 0) & " 2do = " & a(i, 1) & " Media " & a(i, 2) & vbNewLine
        Next
        TextBox1.Text = cadena
    End Sub
End Class
