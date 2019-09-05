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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.INP_SOURCEDecHex = New System.Windows.Forms.TextBox()
        Me.INP_ResultDecHex = New System.Windows.Forms.TextBox()
        Me.BT_ValidDecHex = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ResetDecHex = New System.Windows.Forms.Button()
        Me.ResetHexDec = New System.Windows.Forms.Button()
        Me.INP_SOURCEHexDec = New System.Windows.Forms.TextBox()
        Me.INP_ResultHexDec = New System.Windows.Forms.TextBox()
        Me.BT_ValidHexDec = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'INP_SOURCEDecHex
        '
        Me.INP_SOURCEDecHex.Location = New System.Drawing.Point(10, 67)
        Me.INP_SOURCEDecHex.Name = "INP_SOURCEDecHex"
        Me.INP_SOURCEDecHex.Size = New System.Drawing.Size(151, 22)
        Me.INP_SOURCEDecHex.TabIndex = 0
        Me.INP_SOURCEDecHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'INP_ResultDecHex
        '
        Me.INP_ResultDecHex.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.INP_ResultDecHex.Location = New System.Drawing.Point(10, 228)
        Me.INP_ResultDecHex.Name = "INP_ResultDecHex"
        Me.INP_ResultDecHex.ReadOnly = True
        Me.INP_ResultDecHex.Size = New System.Drawing.Size(151, 22)
        Me.INP_ResultDecHex.TabIndex = 1
        Me.INP_ResultDecHex.TabStop = False
        Me.INP_ResultDecHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_ValidDecHex
        '
        Me.BT_ValidDecHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ValidDecHex.ForeColor = System.Drawing.Color.Black
        Me.BT_ValidDecHex.Location = New System.Drawing.Point(10, 134)
        Me.BT_ValidDecHex.Name = "BT_ValidDecHex"
        Me.BT_ValidDecHex.Size = New System.Drawing.Size(77, 44)
        Me.BT_ValidDecHex.TabIndex = 2
        Me.BT_ValidDecHex.Text = "Convert to HEX"
        Me.BT_ValidDecHex.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Type in Decimal value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(224, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(324, 46)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hex-Dec Converter"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.ResetDecHex)
        Me.GroupBox1.Controls.Add(Me.INP_SOURCEDecHex)
        Me.GroupBox1.Controls.Add(Me.INP_ResultDecHex)
        Me.GroupBox1.Controls.Add(Me.BT_ValidDecHex)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 275)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "From DEC to HEX"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(380, 396)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "by Soaresden 4 GbaTemp"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.ResetHexDec)
        Me.GroupBox2.Controls.Add(Me.INP_SOURCEHexDec)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.INP_ResultHexDec)
        Me.GroupBox2.Controls.Add(Me.BT_ValidHexDec)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(354, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(194, 275)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "From HEX to DEC"
        '
        'ResetDecHex
        '
        Me.ResetDecHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetDecHex.ForeColor = System.Drawing.Color.Black
        Me.ResetDecHex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ResetDecHex.Location = New System.Drawing.Point(93, 134)
        Me.ResetDecHex.Name = "ResetDecHex"
        Me.ResetDecHex.Size = New System.Drawing.Size(68, 44)
        Me.ResetDecHex.TabIndex = 9
        Me.ResetDecHex.Text = "Reset"
        Me.ResetDecHex.UseVisualStyleBackColor = True
        '
        'ResetHexDec
        '
        Me.ResetHexDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetHexDec.ForeColor = System.Drawing.Color.Black
        Me.ResetHexDec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ResetHexDec.Location = New System.Drawing.Point(105, 134)
        Me.ResetHexDec.Name = "ResetHexDec"
        Me.ResetHexDec.Size = New System.Drawing.Size(68, 44)
        Me.ResetHexDec.TabIndex = 14
        Me.ResetHexDec.Text = "Reset"
        Me.ResetHexDec.UseVisualStyleBackColor = True
        '
        'INP_SOURCEHexDec
        '
        Me.INP_SOURCEHexDec.Location = New System.Drawing.Point(13, 67)
        Me.INP_SOURCEHexDec.Name = "INP_SOURCEHexDec"
        Me.INP_SOURCEHexDec.Size = New System.Drawing.Size(160, 22)
        Me.INP_SOURCEHexDec.TabIndex = 10
        Me.INP_SOURCEHexDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'INP_ResultHexDec
        '
        Me.INP_ResultHexDec.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.INP_ResultHexDec.Location = New System.Drawing.Point(13, 228)
        Me.INP_ResultHexDec.Name = "INP_ResultHexDec"
        Me.INP_ResultHexDec.ReadOnly = True
        Me.INP_ResultHexDec.Size = New System.Drawing.Size(160, 22)
        Me.INP_ResultHexDec.TabIndex = 11
        Me.INP_ResultHexDec.TabStop = False
        Me.INP_ResultHexDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_ValidHexDec
        '
        Me.BT_ValidHexDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ValidHexDec.ForeColor = System.Drawing.Color.Black
        Me.BT_ValidHexDec.Location = New System.Drawing.Point(13, 134)
        Me.BT_ValidHexDec.Name = "BT_ValidHexDec"
        Me.BT_ValidHexDec.Size = New System.Drawing.Size(77, 44)
        Me.BT_ValidHexDec.TabIndex = 12
        Me.BT_ValidHexDec.Text = "Convert to DEC"
        Me.BT_ValidHexDec.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Type in Hexadec. value"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(327, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cheat Modifier"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(569, 424)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "SX OS Cheat Assistant - Hex Dec Converter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents INP_SOURCEDecHex As TextBox
    Friend WithEvents INP_ResultDecHex As TextBox
    Friend WithEvents BT_ValidDecHex As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ResetDecHex As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ResetHexDec As Button
    Friend WithEvents INP_SOURCEHexDec As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents INP_ResultHexDec As TextBox
    Friend WithEvents BT_ValidHexDec As Button
    Friend WithEvents Label5 As Label
End Class
