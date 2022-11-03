Public Class Barco
    Private _imagen As PictureBox

    Public Sub New()
        imagen = New PictureBox()
        imagen.Size = New Size(50, 50)
        imagen.Location = New Point(200, 200)
        imagen.Image = Image.FromFile("imagenes\nave.png")
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
        imagen.BackColor = Color.Transparent

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
    Private _y As Integer
    Public Property y() As Integer
        Get
            Return imagen.Location.Y
        End Get
        Set(ByVal value As Integer)
            _y = value
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

    Private _diry As Integer
    Public Property diry() As Integer
        Get
            Return _diry
        End Get
        Set(ByVal value As Integer)
            _diry = value
        End Set
    End Property

    Public Sub Mover(formulario As Form)
        If x <= 0 Then
            imagen.Location = New Point(formulario.Width - imagen.Width - 12, y + diry)
        ElseIf x >= Formulario.Width - imagen.Width - 10 Then
            imagen.Location = New Point(-11 + dirx, y + diry)
        End If
        imagen.Location = New Point(x + dirx, y + diry)
        If y <= 0 Or y >= formulario.Height - imagen.Height - 30 Then
            diry = -diry
        End If
        If dirx > 0 Then
            imagen.Image = Image.FromFile("imagenes\nave.png")
        End If
        If dirx < 0 Then
            imagen.Image = Image.FromFile("imagenes\naveIzqui.png")
        End If
        If diry < 0 Then
            imagen.Image = Image.FromFile("imagenes\naveRiba.png")
        End If
        If diry > 0 Then
            imagen.Image = Image.FromFile("imagenes\naveBajo.png")
        End If




    End Sub

End Class
