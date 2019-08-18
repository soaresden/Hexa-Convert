<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.INP_SOURCE = New System.Windows.Forms.TextBox()
        Me.INP_RESULTAT = New System.Windows.Forms.TextBox()
        Me.BT_VALIDER = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'INP_SOURCE
        '
        Me.INP_SOURCE.Location = New System.Drawing.Point(38, 29)
        Me.INP_SOURCE.Name = "INP_SOURCE"
        Me.INP_SOURCE.Size = New System.Drawing.Size(100, 22)
        Me.INP_SOURCE.TabIndex = 0
        Me.INP_SOURCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'INP_RESULTAT
        '
        Me.INP_RESULTAT.Location = New System.Drawing.Point(38, 86)
        Me.INP_RESULTAT.Name = "INP_RESULTAT"
        Me.INP_RESULTAT.Size = New System.Drawing.Size(100, 22)
        Me.INP_RESULTAT.TabIndex = 1
        Me.INP_RESULTAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_VALIDER
        '
        Me.BT_VALIDER.Location = New System.Drawing.Point(38, 57)
        Me.BT_VALIDER.Name = "BT_VALIDER"
        Me.BT_VALIDER.Size = New System.Drawing.Size(100, 23)
        Me.BT_VALIDER.TabIndex = 2
        Me.BT_VALIDER.Text = "Convertir"
        Me.BT_VALIDER.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Saisir Valeur Numerique"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(177, 133)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BT_VALIDER)
        Me.Controls.Add(Me.INP_RESULTAT)
        Me.Controls.Add(Me.INP_SOURCE)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents INP_SOURCE As TextBox
    Friend WithEvents INP_RESULTAT As TextBox
    Friend WithEvents BT_VALIDER As Button
    Friend WithEvents Label1 As Label
End Class
