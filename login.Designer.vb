<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.lbl_nomdutil = New System.Windows.Forms.Label()
        Me.lbl_mdp = New System.Windows.Forms.Label()
        Me.txt_nomdutil = New System.Windows.Forms.TextBox()
        Me.txt_mdp = New System.Windows.Forms.TextBox()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_nomdutil
        '
        Me.lbl_nomdutil.AutoSize = True
        Me.lbl_nomdutil.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nomdutil.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomdutil.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_nomdutil.Location = New System.Drawing.Point(38, 81)
        Me.lbl_nomdutil.Name = "lbl_nomdutil"
        Me.lbl_nomdutil.Size = New System.Drawing.Size(201, 27)
        Me.lbl_nomdutil.TabIndex = 0
        Me.lbl_nomdutil.Text = "Nom d'utilisateur :"
        '
        'lbl_mdp
        '
        Me.lbl_mdp.AutoSize = True
        Me.lbl_mdp.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mdp.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mdp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_mdp.Location = New System.Drawing.Point(38, 202)
        Me.lbl_mdp.Name = "lbl_mdp"
        Me.lbl_mdp.Size = New System.Drawing.Size(160, 27)
        Me.lbl_mdp.TabIndex = 1
        Me.lbl_mdp.Text = "Mot de passe :"
        '
        'txt_nomdutil
        '
        Me.txt_nomdutil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomdutil.Location = New System.Drawing.Point(34, 143)
        Me.txt_nomdutil.Name = "txt_nomdutil"
        Me.txt_nomdutil.Size = New System.Drawing.Size(218, 28)
        Me.txt_nomdutil.TabIndex = 2
        '
        'txt_mdp
        '
        Me.txt_mdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mdp.Location = New System.Drawing.Point(43, 264)
        Me.txt_mdp.Name = "txt_mdp"
        Me.txt_mdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_mdp.Size = New System.Drawing.Size(218, 28)
        Me.txt_mdp.TabIndex = 3
        '
        'btn_annuler
        '
        Me.btn_annuler.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(338, 352)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(103, 35)
        Me.btn_annuler.TabIndex = 4
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'btn_valider
        '
        Me.btn_valider.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_valider.Location = New System.Drawing.Point(210, 352)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(103, 35)
        Me.btn_valider.TabIndex = 5
        Me.btn_valider.Text = "Valider"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(737, 432)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.txt_mdp)
        Me.Controls.Add(Me.txt_nomdutil)
        Me.Controls.Add(Me.lbl_mdp)
        Me.Controls.Add(Me.lbl_nomdutil)
        Me.Name = "frm_login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_nomdutil As Label
    Friend WithEvents lbl_mdp As Label
    Friend WithEvents txt_nomdutil As TextBox
    Friend WithEvents txt_mdp As TextBox
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_valider As Button
End Class
