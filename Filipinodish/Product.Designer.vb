<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(862, 54)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FILIPINO DISH"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 54)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(862, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripLabel1.Text = "Add Product"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripButton1.Text = "Close"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Item"
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(141, 193)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(354, 23)
        Me.txtProduct.TabIndex = 5
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(141, 235)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(354, 23)
        Me.txtPrice.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(141, 279)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(354, 23)
        Me.txtQuantity.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Category"
        '
        'cboCategory
        '
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(143, 328)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(271, 23)
        Me.cboCategory.TabIndex = 11
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(141, 376)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(117, 37)
        Me.btnadd.TabIndex = 13
        Me.btnadd.Text = "Add Item"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(283, 376)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(117, 37)
        Me.btnupdate.TabIndex = 14
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(419, 376)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 37)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(638, 308)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(189, 37)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Browse Image"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(419, 321)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(43, 33)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(141, 155)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(354, 23)
        Me.txtID.TabIndex = 19
        Me.txtID.Text = "(Auto)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(638, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 192)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 501)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
