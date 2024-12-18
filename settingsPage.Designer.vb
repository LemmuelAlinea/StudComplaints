<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settingsPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settingsPage))
        Me.accBtn = New System.Windows.Forms.Button()
        Me.outBtn = New System.Windows.Forms.Button()
        Me.bBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'accBtn
        '
        Me.accBtn.BackColor = System.Drawing.Color.Transparent
        Me.accBtn.BackgroundImage = CType(resources.GetObject("accBtn.BackgroundImage"), System.Drawing.Image)
        Me.accBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.accBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.accBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.accBtn.Location = New System.Drawing.Point(335, 310)
        Me.accBtn.Name = "accBtn"
        Me.accBtn.Size = New System.Drawing.Size(34, 23)
        Me.accBtn.TabIndex = 0
        Me.accBtn.UseVisualStyleBackColor = False
        '
        'outBtn
        '
        Me.outBtn.BackColor = System.Drawing.Color.Transparent
        Me.outBtn.BackgroundImage = CType(resources.GetObject("outBtn.BackgroundImage"), System.Drawing.Image)
        Me.outBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.outBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.outBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.outBtn.Location = New System.Drawing.Point(335, 354)
        Me.outBtn.Name = "outBtn"
        Me.outBtn.Size = New System.Drawing.Size(34, 23)
        Me.outBtn.TabIndex = 1
        Me.outBtn.UseVisualStyleBackColor = False
        '
        'bBtn
        '
        Me.bBtn.BackColor = System.Drawing.Color.Transparent
        Me.bBtn.BackgroundImage = CType(resources.GetObject("bBtn.BackgroundImage"), System.Drawing.Image)
        Me.bBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBtn.ForeColor = System.Drawing.Color.Transparent
        Me.bBtn.Location = New System.Drawing.Point(377, 12)
        Me.bBtn.Name = "bBtn"
        Me.bBtn.Size = New System.Drawing.Size(45, 42)
        Me.bBtn.TabIndex = 2
        Me.bBtn.UseVisualStyleBackColor = False
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.backBtn.Location = New System.Drawing.Point(77, 416)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(90, 31)
        Me.backBtn.TabIndex = 4
        Me.backBtn.Text = "BACK"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'logoutBtn
        '
        Me.logoutBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.logoutBtn.Location = New System.Drawing.Point(256, 416)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(90, 31)
        Me.logoutBtn.TabIndex = 5
        Me.logoutBtn.Text = "LOGOUT"
        Me.logoutBtn.UseVisualStyleBackColor = False
        '
        'settingsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 711)
        Me.Controls.Add(Me.logoutBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.bBtn)
        Me.Controls.Add(Me.outBtn)
        Me.Controls.Add(Me.accBtn)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settingsPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "settingsPage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents accBtn As Button
    Friend WithEvents outBtn As Button
    Friend WithEvents bBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents logoutBtn As Button
End Class
