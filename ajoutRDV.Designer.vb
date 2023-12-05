<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ajoutRDV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ajoutRDV))
        Me.lbl_code = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.btn_ajoutRDV = New System.Windows.Forms.Button()
        Me.btn_afficherRDV = New System.Windows.Forms.Button()
        Me.cmb_codeR = New System.Windows.Forms.ComboBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_code
        '
        Me.lbl_code.AutoSize = True
        Me.lbl_code.BackColor = System.Drawing.Color.Transparent
        Me.lbl_code.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_code.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_code.Location = New System.Drawing.Point(178, 47)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(63, 24)
        Me.lbl_code.TabIndex = 0
        Me.lbl_code.Text = "Code :"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_date.Location = New System.Drawing.Point(178, 166)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(128, 24)
        Me.lbl_date.TabIndex = 1
        Me.lbl_date.Text = "Date de RDV :"
        '
        'Dtp_date
        '
        Me.Dtp_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Dtp_date.Location = New System.Drawing.Point(239, 244)
        Me.Dtp_date.Name = "Dtp_date"
        Me.Dtp_date.Size = New System.Drawing.Size(348, 28)
        Me.Dtp_date.TabIndex = 3
        '
        'btn_ajoutRDV
        '
        Me.btn_ajoutRDV.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ajoutRDV.Location = New System.Drawing.Point(267, 336)
        Me.btn_ajoutRDV.Name = "btn_ajoutRDV"
        Me.btn_ajoutRDV.Size = New System.Drawing.Size(102, 37)
        Me.btn_ajoutRDV.TabIndex = 4
        Me.btn_ajoutRDV.Text = "Ajouter"
        Me.btn_ajoutRDV.UseVisualStyleBackColor = True
        '
        'btn_afficherRDV
        '
        Me.btn_afficherRDV.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_afficherRDV.Location = New System.Drawing.Point(418, 336)
        Me.btn_afficherRDV.Name = "btn_afficherRDV"
        Me.btn_afficherRDV.Size = New System.Drawing.Size(102, 37)
        Me.btn_afficherRDV.TabIndex = 5
        Me.btn_afficherRDV.Text = "Afficher"
        Me.btn_afficherRDV.UseVisualStyleBackColor = True
        '
        'cmb_codeR
        '
        Me.cmb_codeR.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cmb_codeR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.cmb_codeR.FormattingEnabled = True
        Me.cmb_codeR.Location = New System.Drawing.Point(239, 97)
        Me.cmb_codeR.Name = "cmb_codeR"
        Me.cmb_codeR.Size = New System.Drawing.Size(348, 30)
        Me.cmb_codeR.TabIndex = 6
        '
        'btn_exit
        '
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.Location = New System.Drawing.Point(724, 12)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(64, 63)
        Me.btn_exit.TabIndex = 9
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frm_ajoutRDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(638, 484)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.cmb_codeR)
        Me.Controls.Add(Me.btn_afficherRDV)
        Me.Controls.Add(Me.btn_ajoutRDV)
        Me.Controls.Add(Me.Dtp_date)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_code)
        Me.Name = "frm_ajoutRDV"
        Me.Text = "ajoutRDV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_code As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents Dtp_date As DateTimePicker
    Friend WithEvents btn_ajoutRDV As Button
    Friend WithEvents btn_afficherRDV As Button
    Friend WithEvents cmb_codeR As ComboBox
    Friend WithEvents btn_exit As Button
End Class
