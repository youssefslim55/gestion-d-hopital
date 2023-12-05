Public Class frm_main
    Private Sub AjoutPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutPatientToolStripMenuItem.Click
        frm_ajoutpatient.Show()
    End Sub

    Private Sub AffichePatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AffichePatientToolStripMenuItem.Click
        frm_affichepatient.Show()
    End Sub

    Private Sub AjoutRdvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutRdvToolStripMenuItem.Click
        frm_ajoutRDV.Show()
    End Sub

    Private Sub AfficheRdvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficheRdvToolStripMenuItem.Click
        frm_afficheRDV.Show()
    End Sub

    Private Sub btn_Rechercher_Click(sender As Object, e As EventArgs) Handles btn_Rechercher.Click


        lst_recherche.Items.Clear()
        Dim recherche As String = txt_NomRecherche.Text
        txt_NomRecherche.Clear()
        If (recherche = Nothing) Then
            MsgBox("taper un nom")
        Else
            For Each p As patient In tab
                For Each R As RDV In tableauRDV
                    If (recherche = p.nom) Then
                        If (p.code = R.code) Then
                            lst_recherche.Items.Add("patient:  " & "   " & p.code & "    " & p.nom & "    " & p.prenom & "    " & R.consultation)
                            Exit For
                        ElseIf (p.code <> R.code) Then
                            lst_recherche.Items.Add("patient:  " & "   " & p.code & "    " & p.nom & "    " & p.prenom & "      pas de Rdv ")
                            Exit For
                        End If
                    End If
                Next
            Next
        End If
    End Sub
End Class