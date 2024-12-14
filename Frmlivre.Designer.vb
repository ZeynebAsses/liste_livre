<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmlivre
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label_isbn = New Label()
        Label_titre = New Label()
        Label_auteur = New Label()
        Textbox_isbn = New TextBox()
        TextBox_titre = New TextBox()
        TextBox_auteur = New TextBox()
        Button_ajouter = New Button()
        Button_afficher = New Button()
        SuspendLayout()
        ' 
        ' Label_isbn
        ' 
        Label_isbn.AutoSize = True
        Label_isbn.Font = New Font("Segoe UI Variable Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_isbn.Location = New Point(88, 48)
        Label_isbn.Name = "Label_isbn"
        Label_isbn.Size = New Size(45, 24)
        Label_isbn.TabIndex = 0
        Label_isbn.Text = "isbn"
        ' 
        ' Label_titre
        ' 
        Label_titre.AutoSize = True
        Label_titre.Font = New Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_titre.Location = New Point(73, 183)
        Label_titre.Name = "Label_titre"
        Label_titre.Size = New Size(43, 25)
        Label_titre.TabIndex = 1
        Label_titre.Text = "titre"
        ' 
        ' Label_auteur
        ' 
        Label_auteur.AutoSize = True
        Label_auteur.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_auteur.Location = New Point(73, 335)
        Label_auteur.Name = "Label_auteur"
        Label_auteur.Size = New Size(72, 27)
        Label_auteur.TabIndex = 2
        Label_auteur.Text = "auteur"
        ' 
        ' Textbox_isbn
        ' 
        Textbox_isbn.Location = New Point(299, 45)
        Textbox_isbn.Name = "Textbox_isbn"
        Textbox_isbn.Size = New Size(125, 27)
        Textbox_isbn.TabIndex = 3
        ' 
        ' TextBox_titre
        ' 
        TextBox_titre.Location = New Point(299, 183)
        TextBox_titre.Name = "TextBox_titre"
        TextBox_titre.Size = New Size(125, 27)
        TextBox_titre.TabIndex = 4
        ' 
        ' TextBox_auteur
        ' 
        TextBox_auteur.Location = New Point(308, 324)
        TextBox_auteur.Name = "TextBox_auteur"
        TextBox_auteur.Size = New Size(125, 27)
        TextBox_auteur.TabIndex = 5
        ' 
        ' Button_ajouter
        ' 
        Button_ajouter.FlatStyle = FlatStyle.Popup
        Button_ajouter.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button_ajouter.Location = New Point(120, 422)
        Button_ajouter.Name = "Button_ajouter"
        Button_ajouter.Size = New Size(146, 74)
        Button_ajouter.TabIndex = 6
        Button_ajouter.Text = "ajouter"
        Button_ajouter.UseVisualStyleBackColor = True
        ' 
        ' Button_afficher
        ' 
        Button_afficher.FlatStyle = FlatStyle.Popup
        Button_afficher.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button_afficher.Location = New Point(372, 422)
        Button_afficher.Name = "Button_afficher"
        Button_afficher.Size = New Size(164, 74)
        Button_afficher.TabIndex = 7
        Button_afficher.Text = "afficher"
        Button_afficher.UseVisualStyleBackColor = True
        ' 
        ' Frmlivre
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 514)
        Controls.Add(Button_afficher)
        Controls.Add(Button_ajouter)
        Controls.Add(TextBox_auteur)
        Controls.Add(TextBox_titre)
        Controls.Add(Textbox_isbn)
        Controls.Add(Label_auteur)
        Controls.Add(Label_titre)
        Controls.Add(Label_isbn)
        Name = "Frmlivre"
        Text = "Frmlivre"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_isbn As Label
    Friend WithEvents Label_titre As Label
    Friend WithEvents Label_auteur As Label
    Friend WithEvents Textbox_isbn As TextBox
    Friend WithEvents TextBox_titre As TextBox
    Friend WithEvents TextBox_auteur As TextBox
    Friend WithEvents Button_ajouter As Button
    Friend WithEvents Button_afficher As Button
End Class
