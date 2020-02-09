<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class config_factura
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbo_dni = New System.Windows.Forms.ComboBox()
        Me.cbo_pago = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.rbt_b = New System.Windows.Forms.RadioButton()
        Me.rbt_c = New System.Windows.Forms.RadioButton()
        Me.rbt_a = New System.Windows.Forms.RadioButton()
        Me.txt_importe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbo_dni
        '
        Me.cbo_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_dni.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.cbo_dni.FormattingEnabled = True
        Me.cbo_dni.Location = New System.Drawing.Point(12, 26)
        Me.cbo_dni.Name = "cbo_dni"
        Me.cbo_dni.Size = New System.Drawing.Size(121, 21)
        Me.cbo_dni.TabIndex = 2
        Me.cbo_dni.Text = "Busqueda............"
        '
        'cbo_pago
        '
        Me.cbo_pago.FormattingEnabled = True
        Me.cbo_pago.Location = New System.Drawing.Point(15, 95)
        Me.cbo_pago.Name = "cbo_pago"
        Me.cbo_pago.Size = New System.Drawing.Size(121, 21)
        Me.cbo_pago.TabIndex = 3
        Me.cbo_pago.Text = "Seleccionar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Forma de pago"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cliente DNI"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(139, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(29, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(142, 93)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(29, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'rbt_b
        '
        Me.rbt_b.AutoSize = True
        Me.rbt_b.Location = New System.Drawing.Point(78, 173)
        Me.rbt_b.Name = "rbt_b"
        Me.rbt_b.Size = New System.Drawing.Size(32, 17)
        Me.rbt_b.TabIndex = 8
        Me.rbt_b.TabStop = True
        Me.rbt_b.Text = "B"
        Me.rbt_b.UseVisualStyleBackColor = True
        '
        'rbt_c
        '
        Me.rbt_c.AutoSize = True
        Me.rbt_c.Location = New System.Drawing.Point(134, 173)
        Me.rbt_c.Name = "rbt_c"
        Me.rbt_c.Size = New System.Drawing.Size(32, 17)
        Me.rbt_c.TabIndex = 9
        Me.rbt_c.TabStop = True
        Me.rbt_c.Text = "C"
        Me.rbt_c.UseVisualStyleBackColor = True
        '
        'rbt_a
        '
        Me.rbt_a.AutoSize = True
        Me.rbt_a.Location = New System.Drawing.Point(15, 173)
        Me.rbt_a.Name = "rbt_a"
        Me.rbt_a.Size = New System.Drawing.Size(32, 17)
        Me.rbt_a.TabIndex = 10
        Me.rbt_a.TabStop = True
        Me.rbt_a.Text = "A"
        Me.rbt_a.UseVisualStyleBackColor = True
        '
        'txt_importe
        '
        Me.txt_importe.Location = New System.Drawing.Point(15, 228)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.Size = New System.Drawing.Size(151, 20)
        Me.txt_importe.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Importe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tipo de Factura"
        '
        'config_factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(178, 289)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_importe)
        Me.Controls.Add(Me.rbt_a)
        Me.Controls.Add(Me.rbt_c)
        Me.Controls.Add(Me.rbt_b)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_pago)
        Me.Controls.Add(Me.cbo_dni)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "config_factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "config_factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cbo_dni As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_pago As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents rbt_b As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_c As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_a As System.Windows.Forms.RadioButton
    Friend WithEvents txt_importe As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
