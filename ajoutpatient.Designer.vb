<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ajoutpatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ajoutpatient))
        Me.lbl_code = New System.Windows.Forms.Label()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.lbl_prenom = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_afficher = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Retour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_code
        '
        Me.lbl_code.AutoSize = True
        Me.lbl_code.BackColor = System.Drawing.Color.Transparent
        Me.lbl_code.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_code.ForeColor = System.Drawing.Color.White
        Me.lbl_code.Location = New System.Drawing.Point(88, 94)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(63, 24)
        Me.lbl_code.TabIndex = 0
        Me.lbl_code.Text = "Code :"
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nom.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_nom.ForeColor = System.Drawing.Color.White
        Me.lbl_nom.Location = New System.Drawing.Point(88, 173)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(62, 24)
        Me.lbl_nom.TabIndex = 1
        Me.lbl_nom.Text = "Nom :"
        '
        'lbl_prenom
        '
        Me.lbl_prenom.AutoSize = True
        Me.lbl_prenom.BackColor = System.Drawing.Color.Transparent
        Me.lbl_prenom.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_prenom.ForeColor = System.Drawing.Color.White
        Me.lbl_prenom.Location = New System.Drawing.Point(88, 256)
        Me.lbl_prenom.Name = "lbl_prenom"
        Me.lbl_prenom.Size = New System.Drawing.Size(87, 24)
        Me.lbl_prenom.TabIndex = 2
        Me.lbl_prenom.Text = "Prénom :"
        '
        'txt_code
        '
        Me.txt_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.txt_code.Location = New System.Drawing.Point(231, 90)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.ReadOnly = True
        Me.txt_code.Size = New System.Drawing.Size(274, 28)
        Me.txt_code.TabIndex = 3
        '
        'txt_nom
        '
        Me.txt_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.txt_nom.Location = New System.Drawing.Point(231, 169)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(274, 28)
        Me.txt_nom.TabIndex = 4
        '
        'txt_prenom
        '
        Me.txt_prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.txt_prenom.Location = New System.Drawing.Point(231, 256)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(274, 28)
        Me.txt_prenom.TabIndex = 5
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ajouter.Location = New System.Drawing.Point(452, 420)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(115, 40)
        Me.btn_ajouter.TabIndex = 6
        Me.btn_ajouter.Text = "Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'btn_afficher
        '
        Me.btn_afficher.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_afficher.Location = New System.Drawing.Point(298, 420)
        Me.btn_afficher.Name = "btn_afficher"
        Me.btn_afficher.Size = New System.Drawing.Size(115, 40)
        Me.btn_afficher.TabIndex = 7
        Me.btn_afficher.Text = "Afficher"
        Me.btn_afficher.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.Location = New System.Drawing.Point(578, 30)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(62, 53)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Retour
        '
        Me.Retour.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Retour.Location = New System.Drawing.Point(139, 420)
        Me.Retour.Name = "Retour"
        Me.Retour.Size = New System.Drawing.Size(115, 40)
        Me.Retour.TabIndex = 9
        Me.Retour.Text = "Retour"
        Me.Retour.UseVisualStyleBackColor = True
        '
        'frm_ajoutpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(682, 540)
        Me.Controls.Add(Me.Retour)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_afficher)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.txt_prenom)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.lbl_prenom)
        Me.Controls.Add(Me.lbl_nom)
        Me.Controls.Add(Me.lbl_code)
        Me.Name = "frm_ajoutpatient"
        Me.Text = "ajoutpatient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_code As Label
    Friend WithEvents lbl_nom As Label
    Friend WithEvents lbl_prenom As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_afficher As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Retour As Button
End Class
