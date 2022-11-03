Public Class Meteoro
    Private _imagen As PictureBox


    Public Sub New()
        Dim rnd As New Random()
        Dim cond As Integer
        imagen = New PictureBox()
        imagen.Size = New Size(50, 50)
        cond = rnd.Next(1, 10)
        If cond > 5 Then
            imagen.Location = New Point(-60, rnd.Next(-10, 400))
            dirx = rnd.Next(3, 8)
            diry = rnd.Next(-3, 3)
        Else
            imagen.Location = New Point(900, rnd.Next(-10, 400))
            dirx = rnd.Next(-8, -2)
            diry = rnd.Next(-3, 3)
        End If
        imagen.Image = Image.FromFile("imagenes\meteoro.png")
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


        If x <= -10 Or x >= formulario.Width Then
            imagen.Location = New Point(1, y)

        End If
        If x <= 0 Or x >= formulario.Width - imagen.Width - 10 Then
            dirx = -dirx

        End If
        If y <= 0 Or y >= formulario.Height - imagen.Height - 30 Then
            diry = -diry
        End If




        imagen.Location = New Point(x + dirx, y + diry)
    End Sub



End Class


