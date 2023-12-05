Public Class frm_login

    Private Sub init()
        txt_nomdutil.Clear()
        txt_mdp.Clear()
    End Sub

    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click

        Dim login As String
        Dim pw As String
        login = txt_nomdutil.Text
        pw = txt_mdp.Text
        If (login = "admin") And (pw = "1234") Then
            Me.Hide()
            frm_main.Show()
            frm_main.WindowState = FormWindowState.Maximized
        Else
            init()
        End If



    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        init()

    End Sub

End Class