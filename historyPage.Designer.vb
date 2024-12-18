<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historyPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(historyPage))
        Me.historyTbl = New System.Windows.Forms.DataGridView()
        Me.viewBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        CType(Me.historyTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'historyTbl
        '
        Me.historyTbl.AllowUserToAddRows = False
        Me.historyTbl.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.historyTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.historyTbl.GridColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.historyTbl.Location = New System.Drawing.Point(13, 226)
        Me.historyTbl.Name = "historyTbl"
        Me.historyTbl.Size = New System.Drawing.Size(409, 279)
        Me.historyTbl.TabIndex = 0
        '
        'viewBtn
        '
        Me.viewBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.viewBtn.Location = New System.Drawing.Point(358, 511)
        Me.viewBtn.Name = "viewBtn"
        Me.viewBtn.Size = New System.Drawing.Size(64, 27)
        Me.viewBtn.TabIndex = 5
        Me.viewBtn.Text = "VIEW"
        Me.viewBtn.UseVisualStyleBackColor = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.saveBtn.Location = New System.Drawing.Point(185, 511)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(64, 27)
        Me.saveBtn.TabIndex = 6
        Me.saveBtn.Text = "SAVE"
        Me.saveBtn.UseVisualStyleBackColor = False
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
        Me.backBtn.TabIndex = 10
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.deleteBtn.Location = New System.Drawing.Point(12, 511)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(84, 27)
        Me.deleteBtn.TabIndex = 11
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'historyPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 711)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.viewBtn)
        Me.Controls.Add(Me.historyTbl)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "historyPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adHistory"
        CType(Me.historyTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents historyTbl As DataGridView
    Friend WithEvents viewBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents deleteBtn As Button
End Class
