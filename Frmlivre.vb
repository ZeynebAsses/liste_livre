Public Class Frmlivre
    Private Sub Button_ajouter_Click(sender As Object, e As EventArgs) Handles Button_ajouter.Click
        Dim l As listelivre
        l.isbn = Textbox_isbn
        l.titre = TextBox_titre
        l.auteur = TextBox_auteur
        If ajouterlivre(l) Then
            MessageBox.Show("ajouter livre avec succes")
        Else
            MessageBox.Show("le tableau bibiliotheque est saturer")
        End If

    End Sub
End Class