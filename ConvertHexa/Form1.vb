Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BT_VALIDER_Click(sender As Object, e As EventArgs) Handles BT_VALIDER.Click
        If Me.INP_SOURCE.Text = "" Then
            Me.INP_SOURCE.Text = 0
        End If

        Me.INP_RESULTAT.Text = Hex(Me.INP_SOURCE.Text)
    End Sub
End Class
