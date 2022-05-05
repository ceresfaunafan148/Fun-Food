Public Class Form1
    Dim PriceTotal As Double
    Dim ItemOneQuantity As Integer
    Dim ItemTwoQuantity As Integer
    Dim ItemThreeQuantity As Integer

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
            ItemOneQuantity = ItemOneQuantity + 1
            ItemOneLabel.Text = (Convert.ToString(ItemOneQuantity))
        ElseIf ButtonChicken.Enabled = False Then
            ItemTwoQuantity = ItemTwoQuantity + 1
            ItemTwoLabel.Text = (Convert.ToString(ItemTwoQuantity))
        ElseIf ButtonFish.Enabled = False Then
            ItemThreeQuantity = ItemThreeQuantity + 1
            ItemThreeLabel.Text = (Convert.ToString(ItemThreeQuantity))
        End If
    End Sub

    Private Sub ItemOneQuantity_Click(sender As Object, e As EventArgs) Handles ItemOneLabel.Click

    End Sub

    Private Sub ItemSubtractFood_Click(sender As Object, e As EventArgs) Handles ItemSubtractFood.Click
        If ButtonGrain.Enabled = False Then
            ItemOneQuantity = ItemOneQuantity - 1
            ItemOneLabel.Text = (Convert.ToString(ItemOneQuantity))
        ElseIf ButtonChicken.Enabled = False Then
            ItemTwoQuantity = ItemTwoQuantity - 1
            ItemTwoLabel.Text = (Convert.ToString(ItemTwoQuantity))
        ElseIf ButtonFish.Enabled = False Then
            ItemThreeQuantity = ItemThreeQuantity - 1
            ItemThreeLabel.Text = (Convert.ToString(ItemThreeQuantity))
        End If
    End Sub

    Private Sub ButtonVoidFood_Click(sender As Object, e As EventArgs) Handles ButtonVoidFood.Click
        If ButtonGrain.Enabled = False Then
            ItemOneQuantity = ItemOneQuantity = 0
            ItemOneLabel.Text = (Convert.ToString(ItemOneQuantity))
        ElseIf ButtonChicken.Enabled = False Then
            ItemTwoQuantity = ItemTwoQuantity = 0
            ItemTwoLabel.Text = (Convert.ToString(ItemTwoQuantity))
        ElseIf ButtonFish.Enabled = False Then
            ItemThreeQuantity = ItemThreeQuantity = 0
            ItemThreeLabel.Text = (Convert.ToString(ItemThreeQuantity))
        End If
    End Sub

    Private Sub PriceGrain_Click(sender As Object, e As EventArgs) Handles PriceGrain.Click

    End Sub

    Private Sub ComboBoxPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPayment.SelectedIndexChanged

    End Sub
End Class
