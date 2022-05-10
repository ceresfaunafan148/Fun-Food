Public Class Form1
    Dim PriceTotal As Double
    Dim ItemQuantity(9) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelTitle.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTakeAway.Click
        ButtonTakeAway.Enabled = False
        ButtonDelivery.Enabled = True
    End Sub

    Private Sub PanelMain_Paint(sender As Object, e As PaintEventArgs) Handles PanelNewOrder.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonGrain.Click
        ButtonGrain.Enabled = False
        ButtonChicken.Enabled = True
        ButtonFish.Enabled = True
    End Sub

    Private Sub ButtonNewOrder_Click(sender As Object, e As EventArgs) Handles ButtonNewOrder.Click 'Selecting the button hides all other panels other than the one requested.
        PanelNewOrder.Visible = True
        PanelFood.Visible = False
        PanelDrinks.Visible = False
        PanelSides.Visible = False
        PanelOrderDetails.Visible = False
        PanelOrderHistory.Visible = False
    End Sub

    Private Sub ButtonDelivery_Click(sender As Object, e As EventArgs) Handles ButtonDelivery.Click
        ButtonTakeAway.Enabled = True
        ButtonDelivery.Enabled = False
        PriceTotal = PriceTotal - 3
    End Sub

    Private Sub ButtonRestart_Click(sender As Object, e As EventArgs) Handles ButtonRestart.Click
        Application.Restart()
    End Sub

    Private Sub ButtonTest_Click(sender As Object, e As EventArgs) Handles LabelTest.Click
        PriceTotal = PriceTotal - 3
    End Sub

    Private Sub ButtonFood_Click(sender As Object, e As EventArgs) Handles ButtonFood.Click
        PanelNewOrder.Visible = False
        PanelFood.Visible = True
        PanelDrinks.Visible = False
        PanelSides.Visible = False
        PanelOrderDetails.Visible = False
        PanelOrderHistory.Visible = False
    End Sub

    Private Sub ButtonDrinks_Click(sender As Object, e As EventArgs) Handles ButtonDrinks.Click
        PanelNewOrder.Visible = False
        PanelFood.Visible = False
        PanelDrinks.Visible = True
        PanelSides.Visible = False
        PanelOrderDetails.Visible = False
        PanelOrderHistory.Visible = False
    End Sub

    Private Sub ButtonSides_Click(sender As Object, e As EventArgs) Handles ButtonSides.Click
        PanelNewOrder.Visible = False
        PanelFood.Visible = False
        PanelDrinks.Visible = False
        PanelSides.Visible = True
        PanelOrderDetails.Visible = False
        PanelOrderHistory.Visible = False
    End Sub

    Private Sub ButtonDetails_Click(sender As Object, e As EventArgs) Handles ButtonDetails.Click
        PanelNewOrder.Visible = False
        PanelFood.Visible = False
        PanelDrinks.Visible = False
        PanelSides.Visible = False
        PanelOrderDetails.Visible = True
        PanelOrderHistory.Visible = False
    End Sub

    Private Sub ButtonHistory_Click(sender As Object, e As EventArgs) Handles ButtonHistory.Click
        PanelNewOrder.Visible = False
        PanelFood.Visible = False
        PanelDrinks.Visible = False
        PanelSides.Visible = False
        PanelOrderDetails.Visible = False
        PanelOrderHistory.Visible = True
    End Sub

    Private Sub RadioButtonReceipt_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelSides_Paint(sender As Object, e As PaintEventArgs) Handles PanelSides.Paint

    End Sub

    Private Sub ButtonChicken_Click(sender As Object, e As EventArgs) Handles ButtonChicken.Click
        ButtonGrain.Enabled = True
        ButtonChicken.Enabled = False
        ButtonFish.Enabled = True
    End Sub

    Private Sub ButtonFish_Click(sender As Object, e As EventArgs) Handles ButtonFish.Click
        ButtonGrain.Enabled = True
        ButtonChicken.Enabled = True
        ButtonFish.Enabled = False
    End Sub

    Private Sub ItemAddFood_Click(sender As Object, e As EventArgs) Handles ItemAddFood.Click
        If ButtonGrain.Enabled = False Then
            ItemQuantity(0) = ItemQuantity(0) + 1
            ItemOneLabel.Text = (Convert.ToString(ItemQuantity(0)))
        ElseIf ButtonChicken.Enabled = False Then
            ItemQuantity(1) = ItemQuantity(1) + 1
            ItemTwoLabel.Text = (Convert.ToString(ItemQuantity(1)))
        ElseIf ButtonFish.Enabled = False Then
            ItemQuantity(2) = ItemQuantity(2) + 1
            ItemThreeLabel.Text = (Convert.ToString(ItemQuantity(2)))
        End If
    End Sub

    Private Sub ItemOneQuantity_Click(sender As Object, e As EventArgs) Handles ItemOneLabel.Click

    End Sub

    Private Sub ItemSubtractFood_Click(sender As Object, e As EventArgs) Handles ItemSubtractFood.Click
        If ButtonGrain.Enabled = False Then
            ItemQuantity(0) = ItemQuantity(0) - 1
            ItemOneLabel.Text = (Convert.ToString(ItemQuantity(0)))
        ElseIf ButtonChicken.Enabled = False Then
            ItemQuantity(1) = ItemQuantity(1) - 1
            ItemTwoLabel.Text = (Convert.ToString(ItemQuantity(1)))
        ElseIf ButtonFish.Enabled = False Then
            ItemQuantity(2) = ItemQuantity(2) - 1
            ItemThreeLabel.Text = (Convert.ToString(ItemQuantity(2)))
        End If

        If ItemQuantity(0) = 0 Then
            ItemQuantity(0) = ItemQuantity(0) + 1
        End If
        If ItemQuantity(1) = 0 Then
            ItemQuantity(1) = ItemQuantity(1) + 1
        End If
        If ItemQuantity(2) = 0 Then
            ItemQuantity(2) = ItemQuantity(2) + 1
        End If
        If ItemQuantity(3) = 0 Then
            ItemQuantity(3) = ItemQuantity(3) + 1
        End If
    End Sub

    Private Sub ButtonVoidFood_Click(sender As Object, e As EventArgs) Handles ButtonVoidFood.Click
        If ButtonGrain.Enabled = False Then
            ItemQuantity(0) = 0
            ItemOneLabel.Text = (Convert.ToString(ItemQuantity(0)))
        ElseIf ButtonChicken.Enabled = False Then
            ItemQuantity(1) = 0
            ItemTwoLabel.Text = (Convert.ToString(ItemQuantity(1)))
        ElseIf ButtonFish.Enabled = False Then
            ItemQuantity(2) = 0
            ItemThreeLabel.Text = (Convert.ToString(ItemQuantity(2)))
        End If
    End Sub

    Private Sub PriceGrain_Click(sender As Object, e As EventArgs) Handles PriceGrain.Click

    End Sub

    Private Sub ComboBoxPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPayment.SelectedIndexChanged

    End Sub

    Private Sub PanelOrderDetails_Paint(sender As Object, e As PaintEventArgs) Handles PanelOrderDetails.Paint

    End Sub

    Private Sub ButtonWater_Click(sender As Object, e As EventArgs) Handles ButtonWater.Click
        ButtonWater.Enabled = False
        ButtonFruitPunch.Enabled = True
        ButtonAlmondMilk.Enabled = True
        ButtonVegetableSmoothie.Enabled = True
    End Sub

    Private Sub ButtonAlmondMilk_Click(sender As Object, e As EventArgs) Handles ButtonAlmondMilk.Click
        ButtonWater.Enabled = True
        ButtonFruitPunch.Enabled = True
        ButtonAlmondMilk.Enabled = False
        ButtonVegetableSmoothie.Enabled = True
    End Sub

    Private Sub ButtonVegetableSmoothie_Click(sender As Object, e As EventArgs) Handles ButtonVegetableSmoothie.Click
        ButtonWater.Enabled = True
        ButtonFruitPunch.Enabled = True
        ButtonAlmondMilk.Enabled = True
        ButtonVegetableSmoothie.Enabled = False
    End Sub

    Private Sub ButtonFruitPunch_Click(sender As Object, e As EventArgs) Handles ButtonFruitPunch.Click
        ButtonWater.Enabled = True
        ButtonFruitPunch.Enabled = False
        ButtonAlmondMilk.Enabled = True
        ButtonVegetableSmoothie.Enabled = True
    End Sub

    Private Sub ItemAddDrinks_Click(sender As Object, e As EventArgs) Handles ItemAddDrinks.Click
        If ButtonWater.Enabled = False Then
            ItemQuantity(3) = ItemQuantity(3) + 1
            ItemFourLabel.Text = (Convert.ToString(ItemQuantity(3)))
        ElseIf ButtonFruitPunch.Enabled = False Then
            ItemQuantity(4) = ItemQuantity(4) + 1
            ItemFiveLabel.Text = (Convert.ToString(ItemQuantity(4)))
        ElseIf ButtonAlmondMilk.Enabled = False Then
            ItemQuantity(5) = ItemQuantity(5) + 1
            ItemSixLabel.Text = (Convert.ToString(ItemQuantity(5)))
        ElseIf ButtonVegetableSmoothie.Enabled = False Then
            ItemQuantity(6) = ItemQuantity(6) + 1
            ItemSevenLabel.Text = (Convert.ToString(ItemQuantity(6)))
        End If
    End Sub

    Private Sub ItemSubtractDrinks_Click(sender As Object, e As EventArgs) Handles ItemSubtractDrinks.Click
        If ButtonWater.Enabled = False Then
            ItemQuantity(3) = ItemQuantity(3) - 1
            ItemFourLabel.Text = (Convert.ToString(ItemQuantity(3)))
        ElseIf ButtonFruitPunch.Enabled = False Then
            ItemQuantity(4) = ItemQuantity(4) - 1
            ItemFiveLabel.Text = (Convert.ToString(ItemQuantity(4)))
        ElseIf ButtonAlmondMilk.Enabled = False Then
            ItemQuantity(5) = ItemQuantity(5) - 1
            ItemSixLabel.Text = (Convert.ToString(ItemQuantity(5)))
        ElseIf ButtonVegetableSmoothie.Enabled = False Then
            ItemQuantity(6) = ItemQuantity(6) - 1
            ItemSevenLabel.Text = (Convert.ToString(ItemQuantity(6)))
        End If

        If ItemQuantity(3) = 0 Then
            ItemQuantity(3) = ItemQuantity(3) + 1
        End If
        If ItemQuantity(4) = 0 Then
            ItemQuantity(4) = ItemQuantity(4) + 1
        End If
        If ItemQuantity(5) = 0 Then
            ItemQuantity(5) = ItemQuantity(5) + 1
        End If
        If ItemQuantity(6) = 0 Then
            ItemQuantity(6) = ItemQuantity(6) + 1
        End If
    End Sub

    Private Sub ItemVoidDrinks_Click(sender As Object, e As EventArgs) Handles ItemVoidDrinks.Click
        If ButtonWater.Enabled = False Then
            ItemQuantity(3) = 0
            ItemFourLabel.Text = (Convert.ToString(ItemQuantity(3)))
        ElseIf ButtonFruitPunch.Enabled = False Then
            ItemQuantity(4) = 0
            ItemFiveLabel.Text = (Convert.ToString(ItemQuantity(4)))
        ElseIf ButtonAlmondMilk.Enabled = False Then
            ItemQuantity(5) = 0
            ItemSixLabel.Text = (Convert.ToString(ItemQuantity(5)))
        ElseIf ButtonVegetableSmoothie.Enabled = False Then
            ItemQuantity(6) = 0
            ItemSevenLabel.Text = (Convert.ToString(ItemQuantity(6)))
        End If
    End Sub
End Class
