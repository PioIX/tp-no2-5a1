Public Class Cartel
    Dim z = -1, y = 1
    Dim btn(90) As Button
    Dim saltodelinea As Single
    Private Sub T1_Click(sender As Object, e As EventArgs) Handles T1.Click
        T1.BackColor = Color.FromArgb(125, 125, 125)
        LstNumeros.Items.Add(T1.Text)
    End Sub

    Private Sub Cartel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 90
            btn(i) = New Button()
            Me.Controls.Add(btn(i))
            btn(i).Visible = True
            btn(i).Font = New Font("Monotype Corsiva", 20)
            btn(i).Text = i
            btn(i).Width = 60
            btn(i).Height = 60
            btn(1).Left = 60
            btn(1).Top = 60
            z = z + 1
            saltodelinea = z / 10
            If i <> 1 Then
                If saltodelinea = 1 Or saltodelinea = 2 Or saltodelinea = 3 Or saltodelinea = 4 Or saltodelinea = 5 Or saltodelinea = 6 Or saltodelinea = 7 Or saltodelinea = 8 Or saltodelinea = 9 Then
                    btn(i).Top = btn(i - 1).Top + 60
                    btn(i).Left = 60
                Else
                    btn(i).Left = btn(i - 1).Left + 60
                    btn(i).Top = btn(i - 1).Top
                End If
            End If
        Next
    End Sub
End Class