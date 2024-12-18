<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrystalReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrystalReport))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.showBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.crystalReport31 = New StudComplaints.CrystalReport3()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.statusBox = New System.Windows.Forms.ComboBox()
        Me.categoryBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dateBox = New System.Windows.Forms.ComboBox()
        Me.dateLbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrystalReportViewer1.ForeColor = System.Drawing.Color.Black
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'showBtn
        '
        Me.showBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.showBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showBtn.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.showBtn.Location = New System.Drawing.Point(59, 322)
        Me.showBtn.Name = "showBtn"
        Me.showBtn.Size = New System.Drawing.Size(69, 28)
        Me.showBtn.TabIndex = 4
        Me.showBtn.Text = "SHOW"
        Me.showBtn.UseVisualStyleBackColor = False
        '
        'backBtn
        '
        Me.backBtn.BackgroundImage = CType(resources.GetObject("backBtn.BackgroundImage"), System.Drawing.Image)
        Me.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.backBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.backBtn.Location = New System.Drawing.Point(12, 380)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(36, 33)
        Me.backBtn.TabIndex = 6
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 397)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'statusBox
        '
        Me.statusBox.FormattingEnabled = True
        Me.statusBox.Location = New System.Drawing.Point(39, 151)
        Me.statusBox.Name = "statusBox"
        Me.statusBox.Size = New System.Drawing.Size(121, 21)
        Me.statusBox.TabIndex = 7
        '
        'categoryBox
        '
        Me.categoryBox.FormattingEnabled = True
        Me.categoryBox.Location = New System.Drawing.Point(39, 215)
        Me.categoryBox.Name = "categoryBox"
        Me.categoryBox.Size = New System.Drawing.Size(121, 21)
        Me.categoryBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(75, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(69, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Category"
        '
        'dateBox
        '
        Me.dateBox.FormattingEnabled = True
        Me.dateBox.Location = New System.Drawing.Point(39, 279)
        Me.dateBox.Name = "dateBox"
        Me.dateBox.Size = New System.Drawing.Size(121, 21)
        Me.dateBox.TabIndex = 11
        '
        'dateLbl
        '
        Me.dateLbl.AutoSize = True
        Me.dateLbl.BackColor = System.Drawing.Color.Transparent
        Me.dateLbl.Location = New System.Drawing.Point(75, 254)
        Me.dateLbl.Name = "dateLbl"
        Me.dateLbl.Size = New System.Drawing.Size(30, 13)
        Me.dateLbl.TabIndex = 12
        Me.dateLbl.Text = "Date"
        '
        'CrystalReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dateLbl)
        Me.Controls.Add(Me.dateBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.categoryBox)
        Me.Controls.Add(Me.statusBox)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.showBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CrystalReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrystalReport"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents showBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents crystalReport31 As CrystalReport3
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents statusBox As ComboBox
    Friend WithEvents categoryBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dateBox As ComboBox
    Friend WithEvents dateLbl As Label
End Class
