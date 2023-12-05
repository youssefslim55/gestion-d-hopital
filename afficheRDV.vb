Public Class frm_afficheRDV
    Private Sub frm_afficheRDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficherRDV(DGV_RDV)
    End Sub

    Private Sub btn_AnnulerRDV_Click(sender As Object, e As EventArgs) Handles btn_AnnulerRDV.Click

        Dim q As Integer
        q = DGV_RDV.SelectedCells(0).RowIndex
        tab(q) = Nothing
        supprimerRDV(DGV_RDV, q)

    End Sub

    Private Sub rb_code_CheckedChanged(sender As Object, e As EventArgs) Handles rb_code.CheckedChanged
        If rb_code.Checked Then
            Dim code As Integer
            If Integer.TryParse(InputBox("Code desire a rechercher ? "), code) Then
                RechercherParCodeInPatient(code)

                rb_code.Checked = True
            Else
                MessageBox.Show("Inserer Valid Code ! ")
            End If
        End If
    End Sub

    Private Sub rb_aujourdhui_CheckedChanged(sender As Object, e As EventArgs) Handles rb_aujourdhui.CheckedChanged
        DGV_RDV.Rows.Clear()
        AfficherRDVdujour()
    End Sub
End Class
