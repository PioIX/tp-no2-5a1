Public Class Cartel
    Private Sub Cartel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 90
            Dim Num(i) As TextBox
            Num(i).Width = 40
            Num(i).Height = 40
            If i <> 0 Then
                Num(i).Left = Num(i - 1).Left + 40
            Else
                Num(0).Left = 40
            End If
        Next
    End Sub
End Class
