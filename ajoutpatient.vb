Public Class frm_ajoutpatient

    Private codeActuel As Integer = 1

    Private Sub btn_afficher_Click(sender As Object, e As EventArgs) Handles btn_afficher.Click
        frm_affichepatient.Show()

    End Sub


    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim x As patient
        x.code = codeActuel.ToString()
        x.nom = txt_nom.Text
        x.prenom = txt_prenom.Text
        ajouter(x)
        frm_ajoutRDV.cmb_codeR.Items.Add(x.code)
        codeActuel += 1
        txt_code.Text = codeActuel.ToString()
        txt_code.Clear()
        txt_nom.Clear()
        txt_prenom.Clear()
    End Sub

    Private Sub txt_nom_TextChanged(sender As Object, e As EventArgs) Handles txt_nom.TextChanged
        txt_code.Text = codeActuel.ToString()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()

    End Sub

    Private Sub Retour_Click(sender As Object, e As EventArgs) Handles Retour.Click
        Me.Hide()
        frm_main.Show()
        frm_main.WindowState = FormWindowState.Maximized
    End Sub


End Class