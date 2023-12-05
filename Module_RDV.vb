Module Module_RDV
    Public Structure RDV
        Dim code As String
        Dim consultation As Date
    End Structure

    Public nb As Integer = 0
    Public tableauRDV(100) As RDV

    Function ajouterRDV(R As RDV) As Boolean

        Dim patientExists As Boolean = False
        For Each p As patient In tab
            If (R.code = p.code) Then
                patientExists = True

                Exit For
            End If
        Next
        If patientExists Then
            If nb < 100 Then
                tableauRDV(nb) = R
                nb += 1
                Return True
            Else
                MsgBox("liste des rdv est saturée")
                Return False
            End If
        Else
            MsgBox("ce client n'existe pas")
            Return False
        End If

    End Function
    Public Sub afficherRDV(A As DataGridView)
        For i As Integer = 0 To nb - 1
            A.Rows.Add(tableauRDV(i).code, tableauRDV(i).consultation)
        Next
    End Sub


    Public Sub supprimerRDV(dataGridView As DataGridView, q As Integer)
        For R = q To nb - 1
            tableauRDV(R) = tableauRDV(R + 1)
        Next
        nb -= 1
        dataGridView.Rows.RemoveAt(q)
        MsgBox("Annulation  avec succés")


    End Sub

    Public Sub AfficherRDVdujour()
        Dim dateAujourdhui As DateTime = DateTime.Today
        For Each rdv As RDV In tableauRDV
            If rdv.code IsNot Nothing And rdv.consultation.Date = dateAujourdhui Then
                frm_afficheRDV.DGV_RDV.Rows.Add(rdv.code, rdv.consultation)


            End If

        Next

    End Sub
    Function RechercherParCodeInPatient(userInputCode As Integer) As Boolean

        Dim b As Boolean = False
        For Each i As RDV In tableauRDV
            If i.code = userInputCode Then
                MsgBox("patient :  " & "   " & i.code & "    " & i.consultation)
                b = True
            End If
        Next
        If Not b Then
            MsgBox("pas de rendez-vous")
        End If

    End Function

End Module
