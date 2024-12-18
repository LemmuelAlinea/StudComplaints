<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentHistory))
        Me.backBtn = New System.Windows.Forms.Button()
        Me.historyTbl = New System.Windows.Forms.DataGridView()
        Me.deleteBtn = New System.Windows.Forms.Button()
        CType(Me.historyTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.Transparent
        Me.backBtn.BackgroundImage = CType(resources.GetObject("backBtn.BackgroundImage"), System.Drawing.Image)
        Me.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.backBtn.Location = New System.Drawing.Point(385, 4)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(45, 42)
        Me.backBtn.TabIndex = 6
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'historyTbl
        '
        Me.historyTbl.AllowUserToAddRows = False
        Me.historyTbl.AllowUserToDeleteRows = False
        Me.historyTbl.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.historyTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.historyTbl.GridColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.historyTbl.Location = New System.Drawing.Point(37, 229)
        Me.historyTbl.Name = "historyTbl"
        Me.historyTbl.ReadOnly = True
        Me.historyTbl.Size = New System.Drawing.Size(361, 224)
        Me.historyTbl.TabIndex = 9
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.deleteBtn.Location = New System.Drawing.Point(177, 459)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(86, 29)
        Me.deleteBtn.TabIndex = 11
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'studentHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 711)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.historyTbl)
        Me.Controls.Add(Me.backBtn)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "studentHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "studentHistory"
        CType(Me.historyTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents backBtn As Button
    Friend WithEvents historyTbl As DataGridView
    Friend WithEvents deleteBtn As Button
End Class
