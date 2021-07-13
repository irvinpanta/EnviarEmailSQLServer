<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmail
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDestinatario = New System.Windows.Forms.TextBox()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.txtCuerpo = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enviar Correo desde Vb,net con SQL Server"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destinatario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Asunto;"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cuerpo:"
        '
        'txtDestinatario
        '
        Me.txtDestinatario.Location = New System.Drawing.Point(138, 68)
        Me.txtDestinatario.Name = "txtDestinatario"
        Me.txtDestinatario.Size = New System.Drawing.Size(396, 23)
        Me.txtDestinatario.TabIndex = 4
        '
        'txtAsunto
        '
        Me.txtAsunto.Location = New System.Drawing.Point(138, 101)
        Me.txtAsunto.Multiline = True
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(396, 53)
        Me.txtAsunto.TabIndex = 5
        '
        'txtCuerpo
        '
        Me.txtCuerpo.Location = New System.Drawing.Point(138, 160)
        Me.txtCuerpo.Multiline = True
        Me.txtCuerpo.Name = "txtCuerpo"
        Me.txtCuerpo.Size = New System.Drawing.Size(396, 116)
        Me.txtCuerpo.TabIndex = 6
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(387, 282)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(147, 35)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = "Enviar Correo"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'FrmEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(567, 326)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtCuerpo)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.txtDestinatario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmEmail"
        Me.Text = "Enviar Correo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDestinatario As System.Windows.Forms.TextBox
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents txtCuerpo As System.Windows.Forms.TextBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button

End Class
