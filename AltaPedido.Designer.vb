<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaPedido))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskcod = New System.Windows.Forms.MaskedTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBCat = New System.Windows.Forms.ComboBox()
        Me.datefecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtimporte = New System.Windows.Forms.TextBox()
        Me.checkdesayuno = New System.Windows.Forms.CheckBox()
        Me.checkalmuerzo = New System.Windows.Forms.CheckBox()
        Me.checkmerienda = New System.Windows.Forms.CheckBox()
        Me.checkcena = New System.Windows.Forms.CheckBox()
        Me.BTNRegistrar = New System.Windows.Forms.Button()
        Me.lvpedidos = New System.Windows.Forms.ListView()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BTNImportar = New System.Windows.Forms.Button()
        Me.BTNCargar = New System.Windows.Forms.Button()
        Me.BTNExportar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(275, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(623, 241)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cod. Producto"
        '
        'mskcod
        '
        Me.mskcod.Location = New System.Drawing.Point(269, 292)
        Me.mskcod.Mask = "LL999"
        Me.mskcod.Name = "mskcod"
        Me.mskcod.Size = New System.Drawing.Size(200, 20)
        Me.mskcod.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(198, 330)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(50, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Producto"
        '
        'txtproducto
        '
        Me.txtproducto.Location = New System.Drawing.Point(269, 323)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(200, 20)
        Me.txtproducto.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Categoria"
        '
        'CMBCat
        '
        Me.CMBCat.FormattingEnabled = True
        Me.CMBCat.Location = New System.Drawing.Point(269, 355)
        Me.CMBCat.Name = "CMBCat"
        Me.CMBCat.Size = New System.Drawing.Size(200, 21)
        Me.CMBCat.TabIndex = 6
        '
        'datefecha
        '
        Me.datefecha.Location = New System.Drawing.Point(269, 393)
        Me.datefecha.Name = "datefecha"
        Me.datefecha.Size = New System.Drawing.Size(200, 20)
        Me.datefecha.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 399)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha Vigente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(191, 427)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Precio"
        '
        'txtimporte
        '
        Me.txtimporte.Location = New System.Drawing.Point(269, 427)
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Size = New System.Drawing.Size(200, 20)
        Me.txtimporte.TabIndex = 10
        '
        'checkdesayuno
        '
        Me.checkdesayuno.AutoSize = True
        Me.checkdesayuno.Location = New System.Drawing.Point(194, 465)
        Me.checkdesayuno.Name = "checkdesayuno"
        Me.checkdesayuno.Size = New System.Drawing.Size(74, 17)
        Me.checkdesayuno.TabIndex = 11
        Me.checkdesayuno.Text = "Desayuno"
        Me.checkdesayuno.UseVisualStyleBackColor = True
        '
        'checkalmuerzo
        '
        Me.checkalmuerzo.AutoSize = True
        Me.checkalmuerzo.Location = New System.Drawing.Point(275, 465)
        Me.checkalmuerzo.Name = "checkalmuerzo"
        Me.checkalmuerzo.Size = New System.Drawing.Size(69, 17)
        Me.checkalmuerzo.TabIndex = 12
        Me.checkalmuerzo.Text = "Almuerzo"
        Me.checkalmuerzo.UseVisualStyleBackColor = True
        '
        'checkmerienda
        '
        Me.checkmerienda.AutoSize = True
        Me.checkmerienda.Location = New System.Drawing.Point(363, 465)
        Me.checkmerienda.Name = "checkmerienda"
        Me.checkmerienda.Size = New System.Drawing.Size(70, 17)
        Me.checkmerienda.TabIndex = 13
        Me.checkmerienda.Text = "Merienda"
        Me.checkmerienda.UseVisualStyleBackColor = True
        '
        'checkcena
        '
        Me.checkcena.AutoSize = True
        Me.checkcena.Location = New System.Drawing.Point(450, 465)
        Me.checkcena.Name = "checkcena"
        Me.checkcena.Size = New System.Drawing.Size(51, 17)
        Me.checkcena.TabIndex = 14
        Me.checkcena.Text = "Cena"
        Me.checkcena.UseVisualStyleBackColor = True
        '
        'BTNRegistrar
        '
        Me.BTNRegistrar.Location = New System.Drawing.Point(307, 497)
        Me.BTNRegistrar.Name = "BTNRegistrar"
        Me.BTNRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.BTNRegistrar.TabIndex = 15
        Me.BTNRegistrar.Text = "Registrar"
        Me.BTNRegistrar.UseVisualStyleBackColor = True
        '
        'lvpedidos
        '
        Me.lvpedidos.HideSelection = False
        Me.lvpedidos.Location = New System.Drawing.Point(552, 275)
        Me.lvpedidos.Name = "lvpedidos"
        Me.lvpedidos.Size = New System.Drawing.Size(597, 197)
        Me.lvpedidos.TabIndex = 16
        Me.lvpedidos.UseCompatibleStateImageBehavior = False
        '
        'BTNImportar
        '
        Me.BTNImportar.Location = New System.Drawing.Point(596, 497)
        Me.BTNImportar.Name = "BTNImportar"
        Me.BTNImportar.Size = New System.Drawing.Size(75, 23)
        Me.BTNImportar.TabIndex = 17
        Me.BTNImportar.Text = "Importar"
        Me.BTNImportar.UseVisualStyleBackColor = True
        '
        'BTNCargar
        '
        Me.BTNCargar.Location = New System.Drawing.Point(692, 496)
        Me.BTNCargar.Name = "BTNCargar"
        Me.BTNCargar.Size = New System.Drawing.Size(75, 23)
        Me.BTNCargar.TabIndex = 18
        Me.BTNCargar.Text = "Cargar Listado"
        Me.BTNCargar.UseVisualStyleBackColor = True
        '
        'BTNExportar
        '
        Me.BTNExportar.Location = New System.Drawing.Point(784, 497)
        Me.BTNExportar.Name = "BTNExportar"
        Me.BTNExportar.Size = New System.Drawing.Size(75, 23)
        Me.BTNExportar.TabIndex = 19
        Me.BTNExportar.Text = "Exportar"
        Me.BTNExportar.UseVisualStyleBackColor = True
        '
        'AltaPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 543)
        Me.Controls.Add(Me.BTNExportar)
        Me.Controls.Add(Me.BTNCargar)
        Me.Controls.Add(Me.BTNImportar)
        Me.Controls.Add(Me.lvpedidos)
        Me.Controls.Add(Me.BTNRegistrar)
        Me.Controls.Add(Me.checkcena)
        Me.Controls.Add(Me.checkmerienda)
        Me.Controls.Add(Me.checkalmuerzo)
        Me.Controls.Add(Me.checkdesayuno)
        Me.Controls.Add(Me.txtimporte)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.datefecha)
        Me.Controls.Add(Me.CMBCat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtproducto)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.mskcod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AltaPedido"
        Me.Text = "AltaPedido"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mskcod As MaskedTextBox
    Friend WithEvents label2 As Label
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CMBCat As ComboBox
    Friend WithEvents datefecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtimporte As TextBox
    Friend WithEvents checkdesayuno As CheckBox
    Friend WithEvents checkalmuerzo As CheckBox
    Friend WithEvents checkmerienda As CheckBox
    Friend WithEvents checkcena As CheckBox
    Friend WithEvents BTNRegistrar As Button
    Friend WithEvents lvpedidos As ListView
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents BTNImportar As Button
    Friend WithEvents BTNCargar As Button
    Friend WithEvents BTNExportar As Button
End Class
