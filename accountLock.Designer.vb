<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accountLock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(accountLock))
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.unameBox = New System.Windows.Forms.TextBox()
        Me.cpassBox = New System.Windows.Forms.TextBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'idBox
        '
        Me.idBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idBox.Location = New System.Drawing.Point(44, 270)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(338, 26)
        Me.idBox.TabIndex = 0
        '
        'unameBox
        '
        Me.unameBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unameBox.Location = New System.Drawing.Point(44, 322)
        Me.unameBox.Name = "unameBox"
        Me.unameBox.Size = New System.Drawing.Size(338, 26)
        Me.unameBox.TabIndex = 1
        '
        'cpassBox
        '
        Me.cpassBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpassBox.Location = New System.Drawing.Point(44, 374)
        Me.cpassBox.Name = "cpassBox"
        Me.cpassBox.Size = New System.Drawing.Size(338, 26)
        Me.cpassBox.TabIndex = 2
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.saveBtn.Location = New System.Drawing.Point(161, 425)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(90, 31)
        Me.saveBtn.TabIndex = 3
        Me.saveBtn.Text = "SAVE"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.backBtn.BackgroundImage = CType(resources.GetObject("backBtn.BackgroundImage"), System.Drawing.Image)
        Me.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.backBtn.Location = New System.Drawing.Point(242, 564)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(28, 24)
        Me.backBtn.TabIndex = 4
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(146, 567)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "back to login page"
        '
        'accountLock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 711)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.cpassBox)
        Me.Controls.Add(Me.unameBox)
        Me.Controls.Add(Me.idBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "accountLock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "accountLock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents idBox As TextBox
    Friend WithEvents unameBox As TextBox
    Friend WithEvents cpassBox As TextBox
    Friend WithEvents saveBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents Label1 As Label
End Class
