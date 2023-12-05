Public Class frm_affichepatient
    Private Sub frm_affichepatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher(Dgv_patient)
    End Sub

    Private Sub btn_Supprimer_Click(sender As Object, e As EventArgs) Handles btn_Supprimer.Click
        Dim a As Integer
        a = Dgv_patient.SelectedCells(0).RowIndex
        tab(a) = Nothing
        supprimerpatient(Dgv_patient, a)

    End Sub

End Class
