<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminUsers))
        Me.usersTbl = New System.Windows.Forms.DataGridView()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.unameBox = New System.Windows.Forms.TextBox()
        Me.userTypeBox = New System.Windows.Forms.TextBox()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.passBox = New System.Windows.Forms.TextBox()
        Me.viewBtn = New System.Windows.Forms.Button()
        CType(Me.usersTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usersTbl
        '
        Me.usersTbl.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.usersTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.usersTbl.GridColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.usersTbl.Location = New System.Drawing.Point(12, 192)
        Me.usersTbl.Name = "usersTbl"
        Me.usersTbl.Size = New System.Drawing.Size(410, 154)
        Me.usersTbl.TabIndex = 0
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.deleteBtn.Location = New System.Drawing.Point(12, 472)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(86, 29)
        Me.deleteBtn.TabIndex = 5
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addBtn.Location = New System.Drawing.Point(336, 472)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(86, 29)
        Me.addBtn.TabIndex = 6
        Me.addBtn.Text = "ADD"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.Transparent
        Me.backBtn.BackgroundImage = CType(resources.GetObject("backBtn.BackgroundImage"), System.Drawing.Image)
        Me.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.backBtn.Location = New System.Drawing.Point(389, 4)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(40, 38)
        Me.backBtn.TabIndex = 9
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'unameBox
        '
        Me.unameBox.Location = New System.Drawing.Point(12, 446)
        Me.unameBox.Name = "unameBox"
        Me.unameBox.Size = New System.Drawing.Size(100, 20)
        Me.unameBox.TabIndex = 10
        '
        'userTypeBox
        '
        Me.userTypeBox.Location = New System.Drawing.Point(322, 446)
        Me.userTypeBox.Name = "userTypeBox"
        Me.userTypeBox.Size = New System.Drawing.Size(100, 20)
        Me.userTypeBox.TabIndex = 11
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(116, 446)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(100, 20)
        Me.nameBox.TabIndex = 11
        '
        'passBox
        '
        Me.passBox.Location = New System.Drawing.Point(220, 446)
        Me.passBox.Name = "passBox"
        Me.passBox.Size = New System.Drawing.Size(100, 20)
        Me.passBox.TabIndex = 12
        '
        'viewBtn
        '
        Me.viewBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewBtn.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.viewBtn.Location = New System.Drawing.Point(170, 352)
        Me.viewBtn.Name = "viewBtn"
        Me.viewBtn.Size = New System.Drawing.Size(99, 27)
        Me.viewBtn.TabIndex = 13
        Me.viewBtn.Text = "VIEW USERS"
        Me.viewBtn.UseVisualStyleBackColor = False
        '
        'adminUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 711)
        Me.Controls.Add(Me.viewBtn)
        Me.Controls.Add(Me.passBox)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.userTypeBox)
        Me.Controls.Add(Me.unameBox)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.usersTbl)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "adminUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminUsers"
        CType(Me.usersTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usersTbl As DataGridView
    Friend WithEvents deleteBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents unameBox As TextBox
    Friend WithEvents userTypeBox As TextBox
    Friend WithEvents nameBox As TextBox
    Friend WithEvents passBox As TextBox
    Friend WithEvents viewBtn As Button
End Class
