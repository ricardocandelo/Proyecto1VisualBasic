Imports System.Net.Mime.MediaTypeNames

Public Class Form1
    Dim rnd As New Random()
    Private pic_barco As Barco
    Private pic_meteoro(9) As Meteoro
    Private pic_plataforma As Plataforma
    Private pic_desecho(9) As Desecho
    Dim time, t As Integer

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        time = 0
        pic_barco = New Barco()

        pic_plataforma = New Plataforma


        Controls.Add(pic_barco.imagen)
        Controls.Add(pic_plataforma.imagen)
        tmr_Barco.Start()
        For i = 0 To 9
            pic_desecho(i) = New Desecho()
            Controls.Add(pic_desecho(i).imagen)

        Next
        For i = 0 To 9
            pic_meteoro(i) = New Meteoro()
            Controls.Add(pic_meteoro(i).imagen)


        Next

    End Sub

    Private Sub btn_Star_Click(sender As Object, e As EventArgs) Handles btn_Star.Click
        tmr_Star.Start()
        tmr_Tiempo.Start()
        lbl_Vidas.Text = 3
        lbl_Nivel.Text = 1
        btn_Star.Hide()
        btn_Cerrar.Hide()
        btn_Presentacion.Hide()


    End Sub

    Private Sub tmr_Star_Tick(sender As Object, e As EventArgs) Handles tmr_Star.Tick



        pic_plataforma.Mover(Me)


        Desechos()
        Tiempo()
        Nave()
        Meteoro()
        If lbl_Vidas.Text = 0 Then
            lbl_Mensaje.Text = "PERDISTE"
            tmr_Star.Stop()
            btn_Cerrar.Show()
        End If






    End Sub

    Public Sub Nave()
        Dim i, e, d As Integer
        For i = 0 To 9
            If pic_desecho(i).imagen.Bounds.IntersectsWith(pic_barco.imagen.Bounds) Then


                d = Val(lbl_Desechos.Text)
                If d <= 2 Then
                    lbl_Desechos.Text += 1
                    pic_desecho(i).imagen.Location = New Point(-200, rnd.Next(20, 200))
                    e = prg_Energia.Value + 5
                    If e >= 40 Then
                        prg_Energia.Value = 40
                    Else
                        prg_Energia.Value = prg_Energia.Value + 5
                    End If
                End If


            End If
            If pic_barco.imagen.Bounds.IntersectsWith(pic_plataforma.imagen.Bounds) Then
                If pic_barco.dirx <= pic_plataforma.dirx And pic_barco.diry <= 2 And pic_barco.diry >= -2 Then
                    d = Val(lbl_Desechos.Text)
                    If d = 3 Then
                        lbl_Puntos.Text += 10
                        lbl_Desechos.Text = 0
                    End If

                    If lbl_Puntos.Text >= 100 Then
                        lbl_Puntos.Text = 0

                        lbl_Nivel.Text += 1
                        lbl_Vidas.Text = 3

                    End If
                    pic_barco.diry *= -1


                    prg_Energia.Value = 40

                Else
                    pic_barco.imagen.Location = New Point(200, 200)
                    pic_barco.dirx *= 0
                    pic_barco.diry *= 0
                    lbl_Desechos.Text = 0

                    lbl_Vidas.Text = Val(lbl_Vidas.Text) - 1
                    prg_Energia.Value = 40
                End If

            End If
            If pic_barco.imagen.Bounds.IntersectsWith(pic_meteoro(i).imagen.Bounds) Then
                pic_barco.imagen.Location = New Point(200, 200)
                pic_barco.dirx *= 0
                pic_barco.diry *= 0
                lbl_Desechos.Text = 0

                lbl_Vidas.Text = Val(lbl_Vidas.Text) - 1
                prg_Energia.Value = 40
            End If

        Next

    End Sub

    Public Sub Meteoro()
        Dim i, a As Integer
        Integer.TryParse(lbl_Nivel.Text, a)

        For i = 0 To a - 1
            Try
                pic_meteoro(i).Mover(Me)
            Catch ex As Exception

            End Try

        Next

    End Sub

    Public Sub Tiempo()
        lbl_Tiempo.Text = time
        tmr_Tiempo.Enabled = True
        tmr_Tiempo.Interval = 1000
    End Sub
    Public Sub Desechos()
        Dim i, a As Integer
        For i = 0 To 9
            CondDesecho()

            If pic_plataforma.imagen.Bounds.IntersectsWith(pic_desecho(i).imagen.Bounds) Or pic_meteoro(i).imagen.Bounds.IntersectsWith(pic_desecho(i).imagen.Bounds) Then
                If pic_desecho(i).dirx <= pic_desecho(i).dirx And pic_desecho(i).dirx >= pic_desecho(i).dirx Then
                    pic_desecho(i).diry *= -1
                ElseIf pic_desecho(i).diry <= pic_desecho(i).diry And pic_desecho(i).diry >= pic_desecho(i).diry Then
                    pic_desecho(i).dirx *= -1

                End If
            End If


            If pic_desecho(i).imagen.Bounds.IntersectsWith(pic_desecho(i).imagen.Bounds) Then
                If pic_desecho(i).imagen.Bounds <> pic_desecho(i).imagen.Bounds Then

                    MsgBox("Chocaron")

                    If pic_desecho(i).dirx >= pic_desecho(i).dirx Or pic_desecho(i).dirx <= pic_desecho(i).dirx Then
                        pic_desecho(i).dirx *= -1
                    End If
                End If
            End If

        Next

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Up
                pic_barco.diry -= 1
            Case Keys.Down
                pic_barco.diry += 1
            Case Keys.Right
                pic_barco.dirx += 1
            Case Keys.Left
                pic_barco.dirx -= 1
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub tmr_Barco_Tick(sender As Object, e As EventArgs) Handles tmr_Barco.Tick
        pic_barco.Mover(Me)
    End Sub

    Private Sub btn_Presentacion_Click(sender As Object, e As EventArgs) Handles btn_Presentacion.Click
        Dim presentacion As New Presentacion
        presentacion.Show()
        Me.Hide()
    End Sub


    Private Sub trm_Tiempo_Tick(sender As Object, e As EventArgs) Handles tmr_Tiempo.Tick
        time = time + 1
        t = time + 1
        prg_Energia.Increment(-1)
    End Sub

    Private Sub lbl_Vidas_Click(sender As Object, e As EventArgs) Handles lbl_Vidas.Click

    End Sub

    Public Sub CondDesecho()
        Dim a As Integer
        a = 0
        pic_desecho(a).Mover(Me)
        While t >= 40 And a <= 10
            a += 1
            Try
                pic_desecho(a).Mover(Me)
            Catch ex As Exception
            End Try
            t -= 20
        End While
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click

        Me.Close()
    End Sub




End Class
