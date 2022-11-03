Public Class Plataforma

    Private _imagen As PictureBox

    Public Sub New()
        Dim rnd As New Random()
        imagen = New PictureBox()
        imagen.Size = New Size(200, 15)
        imagen.Location = New Point(200, 500)
        imagen.Image = Image.FromFile("imagenes\Estacion.png")
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
        imagen.BackColor = Color.Transparent
        dirx = 1

    End Sub

    Public Property imagen() As PictureBox
        Get
            Return _imagen
        End Get
        Set(ByVal value As PictureBox)
            _imagen = value
        End Set
    End Property

    Private _x As Integer
    Public Property x() As Integer
        Get
            Return imagen.Location.X
        End Get
        Set(ByVal value As Integer)
            _x = value
        End Set
    End Property

    Private _dirx As Integer
    Public Property dirx() As Integer
        Get
            Return _dirx
        End Get
        Set(ByVal value As Integer)
            _dirx = value
        End Set
    End Property


    Public Sub Mover(formulario As Form)
        If x <= 0 Or x >= formulario.Width - imagen.Width - 10 Then
            dirx = -dirx

        End If



        imagen.Location = New Point(x + dirx, 500)
    End Sub







End Class
