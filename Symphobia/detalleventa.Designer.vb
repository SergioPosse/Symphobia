<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detalleventa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(detalleventa))
        Me.msg_detalle = New AxMSFlexGridLib.AxMSFlexGrid()
        CType(Me.msg_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msg_detalle
        '
        Me.msg_detalle.Location = New System.Drawing.Point(12, 12)
        Me.msg_detalle.Name = "msg_detalle"
        Me.msg_detalle.OcxState = CType(resources.GetObject("msg_detalle.OcxState"), System.Windows.Forms.AxHost.State)
        Me.msg_detalle.Size = New System.Drawing.Size(551, 235)
        Me.msg_detalle.TabIndex = 0
        '
        'detalleventa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 259)
        Me.Controls.Add(Me.msg_detalle)
        Me.Name = "detalleventa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "detalleventa"
        CType(Me.msg_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents msg_detalle As AxMSFlexGridLib.AxMSFlexGrid
End Class
