Module gestion_livre
    Public Structure livre
        Dim isbn As Integer
        Dim titre As Integer
        Dim auteur As String
    End Structure
    Public bibliotheque(100) As livre
    Dim nb As Integer = 0
    Function ajouter_livre(l As livre)
        If nb < bibliotheque.Length Then
            bibliotheque(nb) = l
            nb += 1
            Return True
        Else
            Return False
        End If
    End Function
    Sub afficher_livre(l1 As ListBox, l2 As ListBox, l3 As ListBox)
        For Each livre In bibliotheque
            l1.Items.Add(livre.isbn)
            l2.Items.Add(livre.titre)
            l3.Items.Add(livre.auteur)
        Next
    End Sub
    Sub afficher2_livre(dgv_livre As DataGridView)
        For i As Integer = 0 To nb - 1
            Dim livre As livre = bibliotheque(i)
            dgv_livre.Rows.Add(livre.isbn, livre.titre, livre.auteur)
        Next
    End Sub

End Module
