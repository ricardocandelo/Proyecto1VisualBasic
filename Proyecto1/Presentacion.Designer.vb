<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presentacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_Universidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Facultad = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_Regresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Universidad
        '
        Me.lbl_Universidad.AutoSize = True
        Me.lbl_Universidad.Location = New System.Drawing.Point(245, 31)
        Me.lbl_Universidad.Name = "lbl_Universidad"
        Me.lbl_Universidad.Size = New System.Drawing.Size(294, 25)
        Me.lbl_Universidad.TabIndex = 0
        Me.lbl_Universidad.Text = "Universidad Tecnologica de Panamá"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(329, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Proyecto 1"
        '
        'lbl_Facultad
        '
        Me.lbl_Facultad.AutoSize = True
        Me.lbl_Facultad.Location = New System.Drawing.Point(253, 95)
        Me.lbl_Facultad.Name = "lbl_Facultad"
        Me.lbl_Facultad.Size = New System.Drawing.Size(272, 25)
        Me.lbl_Facultad.TabIndex = 2
        Me.lbl_Facultad.Text = "Facultad de Tecnología y Sistema"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Prof: Ricardo Chan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 25)
        Me.Label3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ricardo Candelo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(329, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "5-713-134"
        '
        'btn_Regresar
        '
        Me.btn_Regresar.Location = New System.Drawing.Point(589, 366)
        Me.btn_Regresar.Name = "btn_Regresar"
        Me.btn_Regresar.Size = New System.Drawing.Size(112, 34)
        Me.btn_Regresar.TabIndex = 7
        Me.btn_Regresar.Text = "Regresar"
        Me.btn_Regresar.UseVisualStyleBackColor = True
        '
        'Presentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Regresar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_Facultad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Universidad)
        Me.Name = "Presentacion"
        Me.Text = "Presentacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Universidad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Facultad As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_Regresar As Button
End Class
