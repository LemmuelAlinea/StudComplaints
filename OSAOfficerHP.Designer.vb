<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OSAOfficerHP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OSAOfficerHP))
        Me.complaintsBtn = New System.Windows.Forms.Button()
        Me.reportsBtn = New System.Windows.Forms.Button()
        Me.historyBtn = New System.Windows.Forms.Button()
        Me.settingsBtn = New System.Windows.Forms.Button()
        Me.recentComplaints = New System.Windows.Forms.DataGridView()
        CType(Me.recentComplaints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'complaintsBtn
        '
        Me.complaintsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.complaintsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.complaintsBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.complaintsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.complaintsBtn.Location = New System.Drawing.Point(136, 366)
        Me.complaintsBtn.Name = "complaintsBtn"
        Me.complaintsBtn.Size = New System.Drawing.Size(161, 55)
        Me.complaintsBtn.TabIndex = 1
        Me.complaintsBtn.Text = "COMPLAINTS"
        Me.complaintsBtn.UseVisualStyleBackColor = False
        '
        'reportsBtn
        '
        Me.reportsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reportsBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.reportsBtn.Location = New System.Drawing.Point(136, 453)
        Me.reportsBtn.Name = "reportsBtn"
        Me.reportsBtn.Size = New System.Drawing.Size(161, 55)
        Me.reportsBtn.TabIndex = 2
        Me.reportsBtn.Text = "REPORTS"
        Me.reportsBtn.UseVisualStyleBackColor = False
        '
        'historyBtn
        '
        Me.historyBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.historyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.historyBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.historyBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.historyBtn.Location = New System.Drawing.Point(136, 540)
        Me.historyBtn.Name = "historyBtn"
        Me.historyBtn.Size = New System.Drawing.Size(161, 55)
        Me.historyBtn.TabIndex = 3
        Me.historyBtn.Text = "HISTORY"
        Me.historyBtn.UseVisualStyleBackColor = False
        '
        'settingsBtn
        '
        Me.settingsBtn.BackgroundImage = CType(resources.GetObject("settingsBtn.BackgroundImage"), System.Drawing.Image)
        Me.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settingsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.settingsBtn.Location = New System.Drawing.Point(384, 8)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.Size = New System.Drawing.Size(45, 35)
        Me.settingsBtn.TabIndex = 7
        Me.settingsBtn.UseVisualStyleBackColor = True
        '
        'recentComplaints
        '
        Me.recentComplaints.AllowUserToAddRows = False
        Me.recentComplaints.AllowUserToDeleteRows = False
        Me.recentComplaints.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.recentComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.recentComplaints.GridColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.recentComplaints.Location = New System.Drawing.Point(88, 165)
        Me.recentComplaints.Name = "recentComplaints"
        Me.recentComplaints.ReadOnly = True
        Me.recentComplaints.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.recentComplaints.Size = New System.Drawing.Size(261, 125)
        Me.recentComplaints.TabIndex = 8
        '
        'OSAOfficerHP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 711)
        Me.Controls.Add(Me.recentComplaints)
        Me.Controls.Add(Me.settingsBtn)
        Me.Controls.Add(Me.historyBtn)
        Me.Controls.Add(Me.reportsBtn)
        Me.Controls.Add(Me.complaintsBtn)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OSAOfficerHP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "guidanceHP"
        CType(Me.recentComplaints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents complaintsBtn As Button
    Friend WithEvents reportsBtn As Button
    Friend WithEvents historyBtn As Button
    Friend WithEvents settingsBtn As Button
    Friend WithEvents recentComplaints As DataGridView
End Class
