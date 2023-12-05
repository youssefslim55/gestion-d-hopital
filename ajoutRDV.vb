Public Class frm_ajoutRDV

    Private Sub btn_afficherRDV_Click(sender As Object, e As EventArgs) Handles btn_afficherRDV.Click
        frm_afficheRDV.Show()
    End Sub
    Private Sub btn_ajoutRDV_Click(sender As Object, e As EventArgs) Handles btn_ajoutRDV.Click
        Dim Z As RDV
        Z.code = cmb_codeR.Text
        Z.consultation = Dtp_date.Value
        ajouterRDV(Z)
        cmb_codeR.Text = ""
    End Sub
    Private Sub Dtp_date_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_date.ValueChanged
        Dtp_date.MinDate = DateTime.Now.AddDays(0)
        Dtp_date.MaxDate = DateTime.Now.AddDays(30)
    End Sub

    Private Sub frm_ajoutRDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dtp_date.Format = DateTimePickerFormat.Custom
        Dtp_date.CustomFormat = "yyyy-MM-dd HH:mm"
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
        frm_main.Show()
        frm_main.WindowState = FormWindowState.Maximized
    End Sub


End Class