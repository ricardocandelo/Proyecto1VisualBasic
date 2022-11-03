Public Class Presentacion
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_Universidad.Click

    End Sub

    Private Sub Presentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        Dim Form As New Form1
        Form.Show()
        Me.Hide()
    End Sub
End Class