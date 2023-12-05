<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AffichePatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RendezvousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutRdvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficheRdvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_Rechercher = New System.Windows.Forms.Button()
        Me.txt_NomRecherche = New System.Windows.Forms.TextBox()
        Me.lst_recherche = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientToolStripMenuItem, Me.RendezvousToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1309, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutPatientToolStripMenuItem, Me.AffichePatientToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(77, 23)
        Me.PatientToolStripMenuItem.Text = "patient"
        '
        'AjoutPatientToolStripMenuItem
        '
        Me.AjoutPatientToolStripMenuItem.Name = "AjoutPatientToolStripMenuItem"
        Me.AjoutPatientToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.AjoutPatientToolStripMenuItem.Text = "ajout patient"
        '
        'AffichePatientToolStripMenuItem
        '
        Me.AffichePatientToolStripMenuItem.Name = "AffichePatientToolStripMenuItem"
        Me.AffichePatientToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.AffichePatientToolStripMenuItem.Text = "affiche patient"
        '
        'RendezvousToolStripMenuItem
        '
        Me.RendezvousToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutRdvToolStripMenuItem, Me.AfficheRdvToolStripMenuItem})
        Me.RendezvousToolStripMenuItem.Name = "RendezvousToolStripMenuItem"
        Me.RendezvousToolStripMenuItem.Size = New System.Drawing.Size(118, 23)
        Me.RendezvousToolStripMenuItem.Text = "rendez-vous"
        '
        'AjoutRdvToolStripMenuItem
        '
        Me.AjoutRdvToolStripMenuItem.Name = "AjoutRdvToolStripMenuItem"
        Me.AjoutRdvToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.AjoutRdvToolStripMenuItem.Text = "ajout rdv"
        '
        'AfficheRdvToolStripMenuItem
        '
        Me.AfficheRdvToolStripMenuItem.Name = "AfficheRdvToolStripMenuItem"
        Me.AfficheRdvToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.AfficheRdvToolStripMenuItem.Text = "affiche rdv"
        '
        'btn_Rechercher
        '
        Me.btn_Rechercher.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Rechercher.Location = New System.Drawing.Point(753, 271)
        Me.btn_Rechercher.Name = "btn_Rechercher"
        Me.btn_Rechercher.Size = New System.Drawing.Size(207, 28)
        Me.btn_Rechercher.TabIndex = 1
        Me.btn_Rechercher.Text = "Recherche par Nom"
        Me.btn_Rechercher.UseVisualStyleBackColor = True
        '
        'txt_NomRecherche
        '
        Me.txt_NomRecherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.txt_NomRecherche.Location = New System.Drawing.Point(1018, 271)
        Me.txt_NomRecherche.Name = "txt_NomRecherche"
        Me.txt_NomRecherche.Size = New System.Drawing.Size(217, 28)
        Me.txt_NomRecherche.TabIndex = 2
        '
        'lst_recherche
        '
        Me.lst_recherche.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lst_recherche.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_recherche.FormattingEnabled = True
        Me.lst_recherche.ItemHeight = 21
        Me.lst_recherche.Location = New System.Drawing.Point(716, 411)
        Me.lst_recherche.Name = "lst_recherche"
        Me.lst_recherche.Size = New System.Drawing.Size(604, 256)
        Me.lst_recherche.TabIndex = 3
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1309, 785)
        Me.Controls.Add(Me.lst_recherche)
        Me.Controls.Add(Me.txt_NomRecherche)
        Me.Controls.Add(Me.btn_Rechercher)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_main"
        Me.Text = "main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AffichePatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RendezvousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutRdvToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficheRdvToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_Rechercher As Button
    Friend WithEvents txt_NomRecherche As TextBox
    Friend WithEvents lst_recherche As ListBox
End Class
