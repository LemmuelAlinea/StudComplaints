<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginPage))
        Me.unameBox = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.passBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'unameBox
        '
        Me.unameBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unameBox.Location = New System.Drawing.Point(101, 452)
        Me.unameBox.Name = "unameBox"
        Me.unameBox.Size = New System.Drawing.Size(238, 26)
        Me.unameBox.TabIndex = 0
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.loginBtn.Location = New System.Drawing.Point(174, 561)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(90, 31)
        Me.loginBtn.TabIndex = 2
        Me.loginBtn.Text = "LOGIN"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'passBox
        '
        Me.passBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passBox.Location = New System.Drawing.Point(101, 515)
        Me.passBox.Name = "passBox"
        Me.passBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passBox.Size = New System.Drawing.Size(238, 26)
        Me.passBox.TabIndex = 1
        '
        'loginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 711)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.passBox)
        Me.Controls.Add(Me.unameBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loginPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students' Complaints"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents unameBox As TextBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents passBox As TextBox
End Class
