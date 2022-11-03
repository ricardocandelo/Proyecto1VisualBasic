<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmr_Star = New System.Windows.Forms.Timer(Me.components)
        Me.btn_Star = New System.Windows.Forms.Button()
        Me.tmr_Barco = New System.Windows.Forms.Timer(Me.components)
        Me.btn_Presentacion = New System.Windows.Forms.Button()
        Me.prg_Energia = New System.Windows.Forms.ProgressBar()
        Me.lbl_Energia = New System.Windows.Forms.Label()
        Me.lbl_Nivel = New System.Windows.Forms.Label()
        Me.lbl_Vidas = New System.Windows.Forms.Label()
        Me.lbl_Tiempo = New System.Windows.Forms.Label()
        Me.tmr_Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Puntos = New System.Windows.Forms.Label()
        Me.lbl_Level = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_Des = New System.Windows.Forms.Label()
        Me.lbl_Desechos = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_Mensaje = New System.Windows.Forms.Label()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmr_Star
        '
        '
        'btn_Star
        '
        Me.btn_Star.Location = New System.Drawing.Point(217, 273)
        Me.btn_Star.Name = "btn_Star"
        Me.btn_Star.Size = New System.Drawing.Size(112, 34)
        Me.btn_Star.TabIndex = 4
        Me.btn_Star.Text = "STAR"
        Me.btn_Star.UseVisualStyleBackColor = True
        '
        'tmr_Barco
        '
        '
        'btn_Presentacion
        '
        Me.btn_Presentacion.Location = New System.Drawing.Point(660, 102)
        Me.btn_Presentacion.Name = "btn_Presentacion"
        Me.btn_Presentacion.Size = New System.Drawing.Size(112, 34)
        Me.btn_Presentacion.TabIndex = 5
        Me.btn_Presentacion.Text = "Presentacion"
        Me.btn_Presentacion.UseVisualStyleBackColor = True
        '
        'prg_Energia
        '
        Me.prg_Energia.Enabled = False
        Me.prg_Energia.Location = New System.Drawing.Point(508, 32)
        Me.prg_Energia.Maximum = 40
        Me.prg_Energia.Name = "prg_Energia"
        Me.prg_Energia.Size = New System.Drawing.Size(150, 24)
        Me.prg_Energia.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prg_Energia.TabIndex = 6
        Me.prg_Energia.Value = 40
        '
        'lbl_Energia
        '
        Me.lbl_Energia.AutoSize = True
        Me.lbl_Energia.Location = New System.Drawing.Point(535, 3)
        Me.lbl_Energia.Name = "lbl_Energia"
        Me.lbl_Energia.Size = New System.Drawing.Size(83, 25)
        Me.lbl_Energia.TabIndex = 7
        Me.lbl_Energia.Text = "ENERGIA"
        '
        'lbl_Nivel
        '
        Me.lbl_Nivel.AutoSize = True
        Me.lbl_Nivel.Location = New System.Drawing.Point(24, 31)
        Me.lbl_Nivel.Name = "lbl_Nivel"
        Me.lbl_Nivel.Size = New System.Drawing.Size(22, 25)
        Me.lbl_Nivel.TabIndex = 8
        Me.lbl_Nivel.Text = "0"
        '
        'lbl_Vidas
        '
        Me.lbl_Vidas.AutoSize = True
        Me.lbl_Vidas.Location = New System.Drawing.Point(137, 31)
        Me.lbl_Vidas.Name = "lbl_Vidas"
        Me.lbl_Vidas.Size = New System.Drawing.Size(22, 25)
        Me.lbl_Vidas.TabIndex = 11
        Me.lbl_Vidas.Text = "0"
        '
        'lbl_Tiempo
        '
        Me.lbl_Tiempo.AutoSize = True
        Me.lbl_Tiempo.Location = New System.Drawing.Point(719, 31)
        Me.lbl_Tiempo.Name = "lbl_Tiempo"
        Me.lbl_Tiempo.Size = New System.Drawing.Size(22, 25)
        Me.lbl_Tiempo.TabIndex = 12
        Me.lbl_Tiempo.Text = "0"
        '
        'tmr_Tiempo
        '
        Me.tmr_Tiempo.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(363, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 13
        '
        'lbl_Puntos
        '
        Me.lbl_Puntos.AutoSize = True
        Me.lbl_Puntos.Location = New System.Drawing.Point(275, 31)
        Me.lbl_Puntos.Name = "lbl_Puntos"
        Me.lbl_Puntos.Size = New System.Drawing.Size(22, 25)
        Me.lbl_Puntos.TabIndex = 14
        Me.lbl_Puntos.Text = "0"
        '
        'lbl_Level
        '
        Me.lbl_Level.AutoSize = True
        Me.lbl_Level.Location = New System.Drawing.Point(12, 6)
        Me.lbl_Level.Name = "lbl_Level"
        Me.lbl_Level.Size = New System.Drawing.Size(58, 25)
        Me.lbl_Level.TabIndex = 15
        Me.lbl_Level.Text = "NIVEL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "PUNTOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(697, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "TIEMPO"
        '
        'lbl_Des
        '
        Me.lbl_Des.AutoSize = True
        Me.lbl_Des.Location = New System.Drawing.Point(363, 6)
        Me.lbl_Des.Name = "lbl_Des"
        Me.lbl_Des.Size = New System.Drawing.Size(111, 25)
        Me.lbl_Des.TabIndex = 18
        Me.lbl_Des.Text = "RECOGIDOS"
        '
        'lbl_Desechos
        '
        Me.lbl_Desechos.AutoSize = True
        Me.lbl_Desechos.Location = New System.Drawing.Point(403, 31)
        Me.lbl_Desechos.Name = "lbl_Desechos"
        Me.lbl_Desechos.Size = New System.Drawing.Size(22, 25)
        Me.lbl_Desechos.TabIndex = 19
        Me.lbl_Desechos.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "VIDAS"
        '
        'lbl_Mensaje
        '
        Me.lbl_Mensaje.AutoSize = True
        Me.lbl_Mensaje.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Mensaje.Location = New System.Drawing.Point(265, 135)
        Me.lbl_Mensaje.Name = "lbl_Mensaje"
        Me.lbl_Mensaje.Size = New System.Drawing.Size(0, 54)
        Me.lbl_Mensaje.TabIndex = 21
        Me.lbl_Mensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Location = New System.Drawing.Point(438, 273)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(112, 34)
        Me.btn_Cerrar.TabIndex = 22
        Me.btn_Cerrar.Text = "CERRAR"
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 589)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.lbl_Mensaje)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_Desechos)
        Me.Controls.Add(Me.lbl_Des)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_Level)
        Me.Controls.Add(Me.lbl_Puntos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Tiempo)
        Me.Controls.Add(Me.lbl_Vidas)
        Me.Controls.Add(Me.lbl_Nivel)
        Me.Controls.Add(Me.lbl_Energia)
        Me.Controls.Add(Me.prg_Energia)
        Me.Controls.Add(Me.btn_Presentacion)
        Me.Controls.Add(Me.btn_Star)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Star As Button
    Friend WithEvents tmr_Star As Timer
    Friend WithEvents tmr_Barco As Timer
    Friend WithEvents btn_Presentacion As Button
    Friend WithEvents prg_Energia As ProgressBar
    Friend WithEvents lbl_Energia As Label
    Friend WithEvents lbl_Nivel As Label
    Friend WithEvents lbl_Vidas As Label
    Friend WithEvents lbl_Tiempo As Label
    Friend WithEvents tmr_Tiempo As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Puntos As Label
    Friend WithEvents lbl_Level As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_Des As Label
    Friend WithEvents lbl_Desechos As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_Mensaje As Label
    Friend WithEvents btn_Cerrar As Button
End Class
