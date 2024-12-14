Public Class listelivre

    Private Sub Button_ajouter_Click(sender As Object, e As EventArgs) Handles Button_ajouter.Click
        Dim l As livre
        l.isbn = box1.text
        l.titre = box2.text
        l.auteur = box3.text
        If ajouter_livre(l) Then
            MessageBox.Show("ajouter livre avec succes")
        Else
            MessageBox.Show("Le tableau bibliotheque est sature")
        End If
    End Sub
    Private Sub Button_affiche_Click(sender As Object, e As EventArgs) Handles Button_affiche.Click
        Frm2.Show()
    End Sub

End Class


