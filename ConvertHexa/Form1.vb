Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BT_VALIDER_Click(sender As Object, e As EventArgs) Handles BT_ValidDecHex.Click
        If Me.INP_SOURCEDecHex.Text = "" Then
            Me.INP_SOURCEDecHex.Text = 0
        End If

        Me.INP_ResultDecHex.Text = Hex(Me.INP_SOURCEDecHex.Text)
    End Sub

    Private Sub INP_SOURCE_TextChanged(sender As Object, e As EventArgs) Handles INP_SOURCEDecHex.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ResetDecHex.Click
        Me.INP_SOURCEDecHex.Text = ""
        Me.INP_ResultDecHex.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BT_ValidHexDec.Click
        If Me.INP_SOURCEHexDec.Text = "" Then
            Me.INP_SOURCEHexDec.Text = 0
        End If

        Me.INP_ResultHexDec.Text = Convert.ToInt32(Me.INP_SOURCEHexDec.Text, 16)
    End Sub

    Private Sub INP_RESULTAT_TextChanged(sender As Object, e As EventArgs) Handles INP_ResultDecHex.TextChanged

    End Sub

    Private Sub ResetHexDec_Click(sender As Object, e As EventArgs) Handles ResetHexDec.Click
        Me.INP_SOURCEHexDec.Text = ""
        Me.INP_ResultHexDec.Text = ""
    End Sub
End Class
