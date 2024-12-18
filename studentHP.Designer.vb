<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentHP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentHP))
        Me.settingsBtn = New System.Windows.Forms.Button()
        Me.complaintsBtn = New System.Windows.Forms.Button()
        Me.historyBtn = New System.Windows.Forms.Button()
        Me.pendingTbl = New System.Windows.Forms.DataGridView()
        CType(Me.pendingTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'settingsBtn
        '
        Me.settingsBtn.BackgroundImage = CType(resources.GetObject("settingsBtn.BackgroundImage"), System.Drawing.Image)
        Me.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settingsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.settingsBtn.Location = New System.Drawing.Point(386, 3)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.Size = New System.Drawing.Size(45, 35)
        Me.settingsBtn.TabIndex = 8
        Me.settingsBtn.UseVisualStyleBackColor = True
        '
        'complaintsBtn
        '
        Me.complaintsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.complaintsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.complaintsBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.complaintsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.complaintsBtn.Location = New System.Drawing.Point(135, 420)
        Me.complaintsBtn.Name = "complaintsBtn"
        Me.complaintsBtn.Size = New System.Drawing.Size(161, 55)
        Me.complaintsBtn.TabIndex = 9
        Me.complaintsBtn.Text = "COMPLAINTS"
        Me.complaintsBtn.UseVisualStyleBackColor = False
        '
        'historyBtn
        '
        Me.historyBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.historyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.historyBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.historyBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.historyBtn.Location = New System.Drawing.Point(135, 500)
        Me.historyBtn.Name = "historyBtn"
        Me.historyBtn.Size = New System.Drawing.Size(161, 55)
        Me.historyBtn.TabIndex = 10
        Me.historyBtn.Text = "HISTORY"
        Me.historyBtn.UseVisualStyleBackColor = False
        '
        'pendingTbl
        '
        Me.pendingTbl.AllowUserToAddRows = False
        Me.pendingTbl.AllowUserToDeleteRows = False
        Me.pendingTbl.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pendingTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pendingTbl.GridColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pendingTbl.Location = New System.Drawing.Point(93, 116)
        Me.pendingTbl.Name = "pendingTbl"
        Me.pendingTbl.ReadOnly = True
        Me.pendingTbl.Size = New System.Drawing.Size(254, 146)
        Me.pendingTbl.TabIndex = 11
        '
        'studentHP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 711)
        Me.Controls.Add(Me.pendingTbl)
        Me.Controls.Add(Me.historyBtn)
        Me.Controls.Add(Me.complaintsBtn)
        Me.Controls.Add(Me.settingsBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "studentHP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "studentHP"
        CType(Me.pendingTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents settingsBtn As Button
    Friend WithEvents complaintsBtn As Button
    Friend WithEvents historyBtn As Button
    Friend WithEvents pendingTbl As DataGridView
End Class
