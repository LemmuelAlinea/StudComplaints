<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentsComplaints
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentsComplaints))
        Me.bullyingCheckBox = New System.Windows.Forms.CheckBox()
        Me.ppCheckBox = New System.Windows.Forms.CheckBox()
        Me.roomCheckBox = New System.Windows.Forms.CheckBox()
        Me.commotionCheckBox = New System.Windows.Forms.CheckBox()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.recentTbl = New System.Windows.Forms.DataGridView()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.otherCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.recentTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bullyingCheckBox
        '
        Me.bullyingCheckBox.AutoSize = True
        Me.bullyingCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bullyingCheckBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bullyingCheckBox.ForeColor = System.Drawing.Color.White
        Me.bullyingCheckBox.Location = New System.Drawing.Point(31, 211)
        Me.bullyingCheckBox.Name = "bullyingCheckBox"
        Me.bullyingCheckBox.Size = New System.Drawing.Size(75, 23)
        Me.bullyingCheckBox.TabIndex = 0
        Me.bullyingCheckBox.Text = "Bullying"
        Me.bullyingCheckBox.UseVisualStyleBackColor = False
        '
        'ppCheckBox
        '
        Me.ppCheckBox.AutoSize = True
        Me.ppCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ppCheckBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppCheckBox.ForeColor = System.Drawing.Color.White
        Me.ppCheckBox.Location = New System.Drawing.Point(31, 240)
        Me.ppCheckBox.Name = "ppCheckBox"
        Me.ppCheckBox.Size = New System.Drawing.Size(135, 23)
        Me.ppCheckBox.TabIndex = 1
        Me.ppCheckBox.Text = "Personal Problem"
        Me.ppCheckBox.UseVisualStyleBackColor = False
        '
        'roomCheckBox
        '
        Me.roomCheckBox.AutoSize = True
        Me.roomCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.roomCheckBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomCheckBox.ForeColor = System.Drawing.Color.White
        Me.roomCheckBox.Location = New System.Drawing.Point(236, 211)
        Me.roomCheckBox.Name = "roomCheckBox"
        Me.roomCheckBox.Size = New System.Drawing.Size(65, 23)
        Me.roomCheckBox.TabIndex = 2
        Me.roomCheckBox.Text = "Room"
        Me.roomCheckBox.UseVisualStyleBackColor = False
        '
        'commotionCheckBox
        '
        Me.commotionCheckBox.AutoSize = True
        Me.commotionCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.commotionCheckBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commotionCheckBox.ForeColor = System.Drawing.Color.White
        Me.commotionCheckBox.Location = New System.Drawing.Point(236, 240)
        Me.commotionCheckBox.Name = "commotionCheckBox"
        Me.commotionCheckBox.Size = New System.Drawing.Size(99, 23)
        Me.commotionCheckBox.TabIndex = 3
        Me.commotionCheckBox.Text = "Commotion"
        Me.commotionCheckBox.UseVisualStyleBackColor = False
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionTextBox.Location = New System.Drawing.Point(31, 328)
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(361, 22)
        Me.descriptionTextBox.TabIndex = 4
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.Transparent
        Me.backBtn.BackgroundImage = CType(resources.GetObject("backBtn.BackgroundImage"), System.Drawing.Image)
        Me.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.backBtn.Location = New System.Drawing.Point(384, 7)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(45, 42)
        Me.backBtn.TabIndex = 5
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'submitBtn
        '
        Me.submitBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submitBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.submitBtn.Location = New System.Drawing.Point(306, 368)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(86, 29)
        Me.submitBtn.TabIndex = 7
        Me.submitBtn.Text = "SUBMIT"
        Me.submitBtn.UseVisualStyleBackColor = False
        '
        'recentTbl
        '
        Me.recentTbl.AllowUserToAddRows = False
        Me.recentTbl.AllowUserToDeleteRows = False
        Me.recentTbl.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.recentTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.recentTbl.GridColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.recentTbl.Location = New System.Drawing.Point(31, 430)
        Me.recentTbl.Name = "recentTbl"
        Me.recentTbl.ReadOnly = True
        Me.recentTbl.Size = New System.Drawing.Size(361, 105)
        Me.recentTbl.TabIndex = 8
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.deleteBtn.Location = New System.Drawing.Point(169, 541)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(86, 29)
        Me.deleteBtn.TabIndex = 10
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'otherCheckBox
        '
        Me.otherCheckBox.AutoSize = True
        Me.otherCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.otherCheckBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otherCheckBox.ForeColor = System.Drawing.Color.White
        Me.otherCheckBox.Location = New System.Drawing.Point(152, 269)
        Me.otherCheckBox.Name = "otherCheckBox"
        Me.otherCheckBox.Size = New System.Drawing.Size(63, 23)
        Me.otherCheckBox.TabIndex = 11
        Me.otherCheckBox.Text = "Other"
        Me.otherCheckBox.UseVisualStyleBackColor = False
        '
        'studentsComplaints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 711)
        Me.Controls.Add(Me.otherCheckBox)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.recentTbl)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.descriptionTextBox)
        Me.Controls.Add(Me.commotionCheckBox)
        Me.Controls.Add(Me.roomCheckBox)
        Me.Controls.Add(Me.ppCheckBox)
        Me.Controls.Add(Me.bullyingCheckBox)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "studentsComplaints"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "studentsComplaints"
        CType(Me.recentTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bullyingCheckBox As CheckBox
    Friend WithEvents ppCheckBox As CheckBox
    Friend WithEvents roomCheckBox As CheckBox
    Friend WithEvents commotionCheckBox As CheckBox
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents backBtn As Button
    Friend WithEvents submitBtn As Button
    Friend WithEvents recentTbl As DataGridView
    Friend WithEvents deleteBtn As Button
    Friend WithEvents otherCheckBox As CheckBox
End Class
