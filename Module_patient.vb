Module Module_patient
    Public Structure patient
        Dim code As String
        Dim nom As String
        Dim prenom As String
    End Structure


    Public nb As Integer = 0
    Public tab(100) As patient

    Function ajouter(p As patient) As Boolean
        If nb < 100 Then
            tab(nb) = p
            nb += 1
            MsgBox("ajout patient avec succés")
            Return True

        Else
            MsgBox("liste saturée")
            Return False
        End If
    End Function

    Public Sub afficher(s As DataGridView)
        For Each p As patient In tab
            s.Rows.Add(p.code, p.nom, p.prenom)
        Next

    End Sub

    Public Sub supprimerpatient(dataGridView As DataGridView, a As Integer)
        For p = a To nb - 1
            tab(p) = tab(p + 1)
        Next
        nb -= 1
        dataGridView.Rows.RemoveAt(a)
        MsgBox("supression avec succés")
        MiseAJourComboBox()
    End Sub

    Private Sub MiseAJourComboBox()

        frm_ajoutRDV.cmb_codeR.Items.Clear()

        For i = 0 To nb - 1
            frm_ajoutRDV.cmb_codeR.Items.Add(tab(i).code)
        Next
    End Sub

End Module
