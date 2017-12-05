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
        Me.lstproducts = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrix = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstPrix = New System.Windows.Forms.ListBox()
        Me.btnsuppProduct = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstproducts
        '
        Me.lstproducts.FormattingEnabled = True
        Me.lstproducts.HorizontalScrollbar = True
        Me.lstproducts.ItemHeight = 20
        Me.lstproducts.Location = New System.Drawing.Point(62, 88)
        Me.lstproducts.Name = "lstproducts"
        Me.lstproducts.ScrollAlwaysVisible = True
        Me.lstproducts.Size = New System.Drawing.Size(223, 244)
        Me.lstproducts.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(267, 366)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(223, 34)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Effacer"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPrix
        '
        Me.btnPrix.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPrix.Location = New System.Drawing.Point(319, 270)
        Me.btnPrix.Name = "btnPrix"
        Me.btnPrix.Size = New System.Drawing.Size(100, 90)
        Me.btnPrix.TabIndex = 4
        Me.btnPrix.Text = "Generer le prix"
        Me.btnPrix.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Produits sélectionnés"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(319, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 34)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Orange"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(319, 141)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 34)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Pomme"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(334, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Produits"
        '
        'lstPrix
        '
        Me.lstPrix.FormattingEnabled = True
        Me.lstPrix.HorizontalScrollbar = True
        Me.lstPrix.ItemHeight = 20
        Me.lstPrix.Location = New System.Drawing.Point(457, 88)
        Me.lstPrix.Name = "lstPrix"
        Me.lstPrix.ScrollAlwaysVisible = True
        Me.lstPrix.Size = New System.Drawing.Size(223, 244)
        Me.lstPrix.TabIndex = 10
        '
        'btnsuppProduct
        '
        Me.btnsuppProduct.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnsuppProduct.Location = New System.Drawing.Point(319, 230)
        Me.btnsuppProduct.Name = "btnsuppProduct"
        Me.btnsuppProduct.Size = New System.Drawing.Size(100, 34)
        Me.btnsuppProduct.TabIndex = 11
        Me.btnsuppProduct.Text = "Retirer"
        Me.btnsuppProduct.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(332, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Operations"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(476, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Articles et cout total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(775, 447)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsuppProduct)
        Me.Controls.Add(Me.lstPrix)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPrix)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstproducts)
        Me.Name = "Form1"
        Me.Text = "Shopping Cart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstproducts As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPrix As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lstPrix As ListBox
    Friend WithEvents btnsuppProduct As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
