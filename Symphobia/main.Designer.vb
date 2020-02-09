<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.lst_carro = New System.Windows.Forms.ListBox()
        Me.cbo_buscarpor = New System.Windows.Forms.ComboBox()
        Me.cbo_filtro = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbt_stock = New System.Windows.Forms.RadioButton()
        Me.rbt_compras = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbt_ventas = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModeloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasDelUltimoMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasDelMesAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.btn_mercaderia = New System.Windows.Forms.Button()
        Me.lbl_importe = New System.Windows.Forms.Label()
        Me.lbl_empresa = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_ticket = New System.Windows.Forms.Button()
        Me.msg_producto = New AxMSFlexGridLib.AxMSFlexGrid()
        Me.btn_factura = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.msg_producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_carro
        '
        Me.lst_carro.FormattingEnabled = True
        Me.lst_carro.Location = New System.Drawing.Point(99, 430)
        Me.lst_carro.Name = "lst_carro"
        Me.lst_carro.Size = New System.Drawing.Size(679, 95)
        Me.lst_carro.TabIndex = 1
        '
        'cbo_buscarpor
        '
        Me.cbo_buscarpor.FormattingEnabled = True
        Me.cbo_buscarpor.Items.AddRange(New Object() {"Modelo", "Marca", "Tipo"})
        Me.cbo_buscarpor.Location = New System.Drawing.Point(12, 95)
        Me.cbo_buscarpor.Name = "cbo_buscarpor"
        Me.cbo_buscarpor.Size = New System.Drawing.Size(121, 21)
        Me.cbo_buscarpor.TabIndex = 5
        '
        'cbo_filtro
        '
        Me.cbo_filtro.Enabled = False
        Me.cbo_filtro.FormattingEnabled = True
        Me.cbo_filtro.Location = New System.Drawing.Point(139, 95)
        Me.cbo_filtro.Name = "cbo_filtro"
        Me.cbo_filtro.Size = New System.Drawing.Size(121, 21)
        Me.cbo_filtro.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar Por"
        '
        'rbt_stock
        '
        Me.rbt_stock.AutoSize = True
        Me.rbt_stock.Location = New System.Drawing.Point(141, 16)
        Me.rbt_stock.Name = "rbt_stock"
        Me.rbt_stock.Size = New System.Drawing.Size(53, 17)
        Me.rbt_stock.TabIndex = 9
        Me.rbt_stock.TabStop = True
        Me.rbt_stock.Text = "Stock"
        Me.rbt_stock.UseVisualStyleBackColor = True
        '
        'rbt_compras
        '
        Me.rbt_compras.AutoSize = True
        Me.rbt_compras.Location = New System.Drawing.Point(6, 16)
        Me.rbt_compras.Name = "rbt_compras"
        Me.rbt_compras.Size = New System.Drawing.Size(66, 17)
        Me.rbt_compras.TabIndex = 10
        Me.rbt_compras.TabStop = True
        Me.rbt_compras.Text = "Compras"
        Me.rbt_compras.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbt_ventas)
        Me.GroupBox1.Controls.Add(Me.rbt_compras)
        Me.GroupBox1.Controls.Add(Me.rbt_stock)
        Me.GroupBox1.Location = New System.Drawing.Point(563, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 39)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ver"
        '
        'rbt_ventas
        '
        Me.rbt_ventas.AutoSize = True
        Me.rbt_ventas.Location = New System.Drawing.Point(70, 16)
        Me.rbt_ventas.Name = "rbt_ventas"
        Me.rbt_ventas.Size = New System.Drawing.Size(58, 17)
        Me.rbt_ventas.TabIndex = 11
        Me.rbt_ventas.TabStop = True
        Me.rbt_ventas.Text = "Ventas"
        Me.rbt_ventas.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(791, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedorToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.LocalidadToolStripMenuItem, Me.EmpresaToolStripMenuItem, Me.PedidoToolStripMenuItem})
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "&Añadir"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem1, Me.ModeloToolStripMenuItem, Me.MarcaToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'RegistroToolStripMenuItem1
        '
        Me.RegistroToolStripMenuItem1.Name = "RegistroToolStripMenuItem1"
        Me.RegistroToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.RegistroToolStripMenuItem1.Text = "Nuevo"
        '
        'ModeloToolStripMenuItem
        '
        Me.ModeloToolStripMenuItem.Name = "ModeloToolStripMenuItem"
        Me.ModeloToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ModeloToolStripMenuItem.Text = "Modelo"
        '
        'MarcaToolStripMenuItem
        '
        Me.MarcaToolStripMenuItem.Name = "MarcaToolStripMenuItem"
        Me.MarcaToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.MarcaToolStripMenuItem.Text = "Marca"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'LocalidadToolStripMenuItem
        '
        Me.LocalidadToolStripMenuItem.Name = "LocalidadToolStripMenuItem"
        Me.LocalidadToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.LocalidadToolStripMenuItem.Text = "Forma De Pago"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'PedidoToolStripMenuItem
        '
        Me.PedidoToolStripMenuItem.Name = "PedidoToolStripMenuItem"
        Me.PedidoToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PedidoToolStripMenuItem.Text = "Pedido"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.VentasDelUltimoMesToolStripMenuItem, Me.VentasDelMesAToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "&Consultas"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ClientesToolStripMenuItem.Text = "Ventas Por Cliente"
        '
        'VentasDelUltimoMesToolStripMenuItem
        '
        Me.VentasDelUltimoMesToolStripMenuItem.Name = "VentasDelUltimoMesToolStripMenuItem"
        Me.VentasDelUltimoMesToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.VentasDelUltimoMesToolStripMenuItem.Text = "Ventas Del Ultimo Mes"
        '
        'VentasDelMesAToolStripMenuItem
        '
        Me.VentasDelMesAToolStripMenuItem.Name = "VentasDelMesAToolStripMenuItem"
        Me.VentasDelMesAToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.VentasDelMesAToolStripMenuItem.Text = "Ventas Del Mes En Transcurso"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'lst_id
        '
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.Location = New System.Drawing.Point(16, 430)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(77, 95)
        Me.lst_id.TabIndex = 15
        '
        'btn_mercaderia
        '
        Me.btn_mercaderia.Location = New System.Drawing.Point(310, 89)
        Me.btn_mercaderia.Name = "btn_mercaderia"
        Me.btn_mercaderia.Size = New System.Drawing.Size(217, 23)
        Me.btn_mercaderia.TabIndex = 16
        Me.btn_mercaderia.Text = "Ingreso Mercaderia"
        Me.btn_mercaderia.UseVisualStyleBackColor = True
        Me.btn_mercaderia.Visible = False
        '
        'lbl_importe
        '
        Me.lbl_importe.AutoSize = True
        Me.lbl_importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_importe.Location = New System.Drawing.Point(221, 411)
        Me.lbl_importe.Name = "lbl_importe"
        Me.lbl_importe.Size = New System.Drawing.Size(63, 13)
        Me.lbl_importe.TabIndex = 17
        Me.lbl_importe.Text = "IMPORTE"
        '
        'lbl_empresa
        '
        Me.lbl_empresa.Font = New System.Drawing.Font("Monotype Corsiva", 24.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empresa.Location = New System.Drawing.Point(178, 23)
        Me.lbl_empresa.Name = "lbl_empresa"
        Me.lbl_empresa.Size = New System.Drawing.Size(404, 50)
        Me.lbl_empresa.TabIndex = 18
        Me.lbl_empresa.Text = "Label2"
        Me.lbl_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 411)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "IMPORTE:"
        '
        'btn_ticket
        '
        Me.btn_ticket.BackgroundImage = Global.Symphobia.My.Resources.Resources.ticket
        Me.btn_ticket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ticket.Location = New System.Drawing.Point(623, 343)
        Me.btn_ticket.Name = "btn_ticket"
        Me.btn_ticket.Size = New System.Drawing.Size(75, 81)
        Me.btn_ticket.TabIndex = 14
        Me.btn_ticket.UseVisualStyleBackColor = True
        '
        'msg_producto
        '
        Me.msg_producto.Location = New System.Drawing.Point(11, 121)
        Me.msg_producto.Name = "msg_producto"
        Me.msg_producto.OcxState = CType(resources.GetObject("msg_producto.OcxState"), System.Windows.Forms.AxHost.State)
        Me.msg_producto.Size = New System.Drawing.Size(767, 215)
        Me.msg_producto.TabIndex = 13
        '
        'btn_factura
        '
        Me.btn_factura.BackgroundImage = Global.Symphobia.My.Resources.Resources.icon_ventas
        Me.btn_factura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_factura.Location = New System.Drawing.Point(704, 343)
        Me.btn_factura.Name = "btn_factura"
        Me.btn_factura.Size = New System.Drawing.Size(75, 81)
        Me.btn_factura.TabIndex = 4
        Me.btn_factura.UseVisualStyleBackColor = True
        '
        'btn_quitar
        '
        Me.btn_quitar.BackgroundImage = Global.Symphobia.My.Resources.Resources.dep_1536839_Market_car1
        Me.btn_quitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_quitar.Location = New System.Drawing.Point(12, 343)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(84, 81)
        Me.btn_quitar.TabIndex = 3
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(791, 537)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_empresa)
        Me.Controls.Add(Me.lbl_importe)
        Me.Controls.Add(Me.btn_mercaderia)
        Me.Controls.Add(Me.lst_id)
        Me.Controls.Add(Me.btn_ticket)
        Me.Controls.Add(Me.msg_producto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_filtro)
        Me.Controls.Add(Me.cbo_buscarpor)
        Me.Controls.Add(Me.btn_factura)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.lst_carro)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.msg_producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_carro As System.Windows.Forms.ListBox
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_factura As System.Windows.Forms.Button
    Friend WithEvents cbo_buscarpor As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_filtro As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbt_stock As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_compras As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModeloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasDelUltimoMesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasDelMesAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msg_producto As AxMSFlexGridLib.AxMSFlexGrid
    Friend WithEvents btn_ticket As System.Windows.Forms.Button
    Friend WithEvents rbt_ventas As System.Windows.Forms.RadioButton
    Friend WithEvents lst_id As System.Windows.Forms.ListBox
    Friend WithEvents btn_mercaderia As System.Windows.Forms.Button
    Friend WithEvents PedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_importe As System.Windows.Forms.Label
    Friend WithEvents lbl_empresa As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
