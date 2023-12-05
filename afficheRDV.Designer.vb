<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_afficheRDV
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
        Me.DGV_RDV = New System.Windows.Forms.DataGridView()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.consultation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_AnnulerRDV = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rb_code = New System.Windows.Forms.RadioButton()
        Me.rb_aujourdhui = New System.Windows.Forms.RadioButton()
        CType(Me.DGV_RDV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_RDV
        '
        Me.DGV_RDV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGV_RDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_RDV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code, Me.consultation})
        Me.DGV_RDV.Location = New System.Drawing.Point(135, 32)
        Me.DGV_RDV.Name = "DGV_RDV"
        Me.DGV_RDV.RowHeadersWidth = 51
        Me.DGV_RDV.RowTemplate.Height = 24
        Me.DGV_RDV.Size = New System.Drawing.Size(533, 266)
        Me.DGV_RDV.TabIndex = 0
        '
        'code
        '
        Me.code.HeaderText = "code"
        Me.code.MinimumWidth = 6
        Me.code.Name = "code"
        Me.code.ReadOnly = True
        Me.code.Width = 125
        '
        'consultation
        '
        Me.consultation.HeaderText = "consultation"
        Me.consultation.MinimumWidth = 6
        Me.consultation.Name = "consultation"
        Me.consultation.ReadOnly = True
        Me.consultation.Width = 125
        '
        'btn_AnnulerRDV
        '
        Me.btn_AnnulerRDV.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_AnnulerRDV.Location = New System.Drawing.Point(547, 304)
        Me.btn_AnnulerRDV.Name = "btn_AnnulerRDV"
        Me.btn_AnnulerRDV.Size = New System.Drawing.Size(121, 34)
        Me.btn_AnnulerRDV.TabIndex = 1
        Me.btn_AnnulerRDV.Text = "Annuler RDV"
        Me.btn_AnnulerRDV.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 381)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Recherche RDV par :"
        '
        'rb_code
        '
        Me.rb_code.AutoSize = True
        Me.rb_code.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_code.Location = New System.Drawing.Point(323, 378)
        Me.rb_code.Name = "rb_code"
        Me.rb_code.Size = New System.Drawing.Size(82, 30)
        Me.rb_code.TabIndex = 3
        Me.rb_code.TabStop = True
        Me.rb_code.Text = "Code"
        Me.rb_code.UseVisualStyleBackColor = True
        '
        'rb_aujourdhui
        '
        Me.rb_aujourdhui.AutoSize = True
        Me.rb_aujourdhui.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_aujourdhui.Location = New System.Drawing.Point(474, 378)
        Me.rb_aujourdhui.Name = "rb_aujourdhui"
        Me.rb_aujourdhui.Size = New System.Drawing.Size(194, 30)
        Me.rb_aujourdhui.TabIndex = 4
        Me.rb_aujourdhui.TabStop = True
        Me.rb_aujourdhui.Text = "Date aujourd'hui"
        Me.rb_aujourdhui.UseVisualStyleBackColor = True
        '
        'frm_afficheRDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rb_aujourdhui)
        Me.Controls.Add(Me.rb_code)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_AnnulerRDV)
        Me.Controls.Add(Me.DGV_RDV)
        Me.Name = "frm_afficheRDV"
        Me.Text = "afficheRDV"
        CType(Me.DGV_RDV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_RDV As DataGridView
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents consultation As DataGridViewTextBoxColumn
    Friend WithEvents btn_AnnulerRDV As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents rb_code As RadioButton
    Friend WithEvents rb_aujourdhui As RadioButton
End Class
