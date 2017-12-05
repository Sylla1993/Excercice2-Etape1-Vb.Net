Public Class Form1
    Dim affiche As String
    Dim i As Decimal

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lstproducts.Items.Add("pomme")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lstproducts.Items.Add("Orange")

    End Sub

    Private Sub btnPrix_Click(sender As Object, e As EventArgs) Handles btnPrix.Click
        Dim O As Decimal
        Dim P As Decimal
        O = 0
        P = 0
        i = 0
        For Each items In lstproducts.Items

            Afficher(items)

            If (items = "Orange") Then

                O = O + 1

            ElseIf (items = "pomme") Then

                P = P + 1

            End If


        Next



        lstPrix.Items.Add("[" & affiche & "] =>" & Prix(O, P))
        affiche = " "




    End Sub



    Function Prix(ByVal orange As Decimal, ByVal pomme As Decimal) As Decimal


        i = (orange * 1.25) + (pomme * 0.6)

        Return i

    End Function

    Function Afficher(ByVal liste As String) As String

        affiche += liste + ","

        Return affiche




    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        lstPrix.Items.Clear()
        lstproducts.Items.Clear()


    End Sub

    Private Sub lstproducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstproducts.SelectedIndexChanged




    End Sub

    Private Sub btnsuppProduct_Click(sender As Object, e As EventArgs) Handles btnsuppProduct.Click


        lstproducts.Items.Remove(lstproducts.SelectedItem)
    End Sub
End Class
