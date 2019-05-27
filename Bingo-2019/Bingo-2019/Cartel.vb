Public Class Cartel
    Dim z = 1, y = 1

    Private Sub Cartel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 90
            Dim Num(i) As TextBox
            Num(i).Visible = True
            Num(i).Width = 40
            Num(i).Height = 40
            z = z + 1
            If i <> 0 Then
                Num(i).Left = Num(i - 1).Left + 40
                If z > 10 Then
                    y = y + 1
                    If y > 1 Then
                        Num(i).Top = Num(i - 1).Top + 40
                    End If
                End If
            Else
                Num(0).Top = 40
                Num(0).Left = 40
            End If
        Next
    End Sub
End Class
