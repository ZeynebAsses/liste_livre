<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class listelivre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label_isbn = New Label()
        Label_titre = New Label()
        Label_auteur = New Label()
        Button_ajouter = New Button()
        Button_affiche = New Button()
        Box1 = New TextBox()
        Box2 = New TextBox()
        Box3 = New TextBox()
        SuspendLayout()
        ' 
        ' Label_isbn
        ' 
        Label_isbn.AutoSize = True
        Label_isbn.Location = New Point(118, 73)
        Label_isbn.Name = "Label_isbn"
        Label_isbn.Size = New Size(36, 20)
        Label_isbn.TabIndex = 0
        Label_isbn.Text = "isbn"
        ' 
        ' Label_titre
        ' 
        Label_titre.AutoSize = True
        Label_titre.Location = New Point(351, 73)
        Label_titre.Name = "Label_titre"
        Label_titre.Size = New Size(36, 20)
        Label_titre.TabIndex = 1
        Label_titre.Text = "titre"
        ' 
        ' Label_auteur
        ' 
        Label_auteur.AutoSize = True
        Label_auteur.Location = New Point(581, 73)
        Label_auteur.Name = "Label_auteur"
        Label_auteur.Size = New Size(51, 20)
        Label_auteur.TabIndex = 2
        Label_auteur.Text = "auteur"
        ' 
        ' Button_ajouter
        ' 
        Button_ajouter.Font = New Font("SimSun-ExtG", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button_ajouter.ForeColor = SystemColors.ActiveCaptionText
        Button_ajouter.Location = New Point(127, 320)
        Button_ajouter.Name = "Button_ajouter"
        Button_ajouter.Size = New Size(154, 98)
        Button_ajouter.TabIndex = 6
        Button_ajouter.Text = "ajouter"
        Button_ajouter.UseVisualStyleBackColor = True
        ' 
        ' Button_affiche
        ' 
        Button_affiche.Font = New Font("SimSun-ExtB", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button_affiche.Location = New Point(400, 330)
        Button_affiche.Name = "Button_affiche"
        Button_affiche.Size = New Size(178, 76)
        Button_affiche.TabIndex = 7
        Button_affiche.Text = "afficher"
        Button_affiche.UseVisualStyleBackColor = True
        ' 
        ' Box1
        ' 
        Box1.Location = New Point(83, 131)
        Box1.Name = "Box1"
        Box1.Size = New Size(125, 27)
        Box1.TabIndex = 8
        ' 
        ' Box2
        ' 
        Box2.Location = New Point(331, 131)
        Box2.Name = "Box2"
        Box2.Size = New Size(125, 27)
        Box2.TabIndex = 9
        ' 
        ' Box3
        ' 
        Box3.Location = New Point(565, 131)
        Box3.Name = "Box3"
        Box3.Size = New Size(125, 27)
        Box3.TabIndex = 10
        ' 
        ' listelivre
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Box3)
        Controls.Add(Box2)
        Controls.Add(Box1)
        Controls.Add(Button_affiche)
        Controls.Add(Button_ajouter)
        Controls.Add(Label_auteur)
        Controls.Add(Label_titre)
        Controls.Add(Label_isbn)
        Name = "listelivre"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_isbn As Label
    Friend WithEvents Label_titre As Label
    Friend WithEvents Label_auteur As Label
    Friend WithEvents Button_ajouter As Button
    Friend WithEvents Button_affiche As Button
    Friend WithEvents Box1 As TextBox
    Friend WithEvents Box2 As TextBox
    Friend WithEvents Box3 As TextBox

End Class
