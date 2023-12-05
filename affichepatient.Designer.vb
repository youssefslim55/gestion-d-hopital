<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_affichepatient
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
        Me.Dgv_patient = New System.Windows.Forms.DataGridView()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Supprimer = New System.Windows.Forms.Button()
        CType(Me.Dgv_patient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_patient
        '
        Me.Dgv_patient.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Dgv_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_patient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code, Me.Nom, Me.Prenom})
        Me.Dgv_patient.Location = New System.Drawing.Point(72, 120)
        Me.Dgv_patient.Name = "Dgv_patient"
        Me.Dgv_patient.RowHeadersWidth = 51
        Me.Dgv_patient.RowTemplate.Height = 24
        Me.Dgv_patient.Size = New System.Drawing.Size(668, 183)
        Me.Dgv_patient.TabIndex = 0
        '
        'code
        '
        Me.code.HeaderText = "Code"
        Me.code.MinimumWidth = 6
        Me.code.Name = "code"
        Me.code.ReadOnly = True
        Me.code.Width = 125
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.MinimumWidth = 6
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        Me.Nom.Width = 125
        '
        'Prenom
        '
        Me.Prenom.HeaderText = "Prenom"
        Me.Prenom.MinimumWidth = 6
        Me.Prenom.Name = "Prenom"
        Me.Prenom.ReadOnly = True
        Me.Prenom.Width = 125
        '
        'btn_Supprimer
        '
        Me.btn_Supprimer.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Supprimer.Location = New System.Drawing.Point(611, 356)
        Me.btn_Supprimer.Name = "btn_Supprimer"
        Me.btn_Supprimer.Size = New System.Drawing.Size(116, 37)
        Me.btn_Supprimer.TabIndex = 1
        Me.btn_Supprimer.Text = "Supprimer"
        Me.btn_Supprimer.UseVisualStyleBackColor = True
        '
        'frm_affichepatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(849, 471)
        Me.Controls.Add(Me.btn_Supprimer)
        Me.Controls.Add(Me.Dgv_patient)
        Me.Name = "frm_affichepatient"
        Me.Text = "affichepatient"
        CType(Me.Dgv_patient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Dgv_patient As DataGridView
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prenom As DataGridViewTextBoxColumn
    Friend WithEvents btn_Supprimer As Button
End Class
