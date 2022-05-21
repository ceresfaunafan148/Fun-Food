
Public Class Form1
    Dim ItemQuantity(9) As Integer 'This array stores the quantity of each item as whole integers
    Dim ItemPrice(9) As Double 'This array stores the price of each item as a double
    Dim TotalPrice As Double 'This double stores the total price of all items times quantity before tax and surcharge
    Dim FinalPrice As Double 'This double stores the final price of all items times quantity after tax and surcharge
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub ButtonTakeAway_Click(sender As Object, e As EventArgs) Handles ButtonTakeAway.Click
        ButtonTakeAway.Enabled = False 'Disables itself
        ButtonDelivery.Enabled = True 'Enables delivery
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonGrain.Click
        ButtonGrain.Enabled = False
        ButtonChicken.Enabled = True
        ButtonFish.Enabled = True
    End Sub
    Private Sub ButtonNewOrder_Click(sender As Object, e As EventArgs) Handles ButtonNewOrder.Click 'Selecting the button hides all other panels other than the one requested.
        PanelNewOrder.Visible = True 'Hides all other panels apart from itself
        PanelFood.Visible = False
        PanelDrinks.Visible = False
        PanelSides.Visible = False
        PanelOrderDetails.Visible = False
        PanelOrderHistory.Visible = False
    End Sub
    Private Sub ButtonDelivery_Click(sender As Object, e As EventArgs) Handles ButtonDelivery.Click
        ButtonTakeAway.Enabled = True 'Enables takeaway
        ButtonDelivery.Enabled = False 'Disables itself
    End Sub

    Private Sub ButtonRestart_Click(sender As Object, e As EventArgs) Handles ButtonRestart.Click
        Me.Refresh() 'Restarts the app
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
    Private Sub ButtonChicken_Click(sender As Object, e As EventArgs) Handles ButtonChicken.Click
        ButtonGrain.Enabled = True
        ButtonChicken.Enabled = False
        ButtonFish.Enabled = True
    End Sub
    Private Sub ButtonFish_Click(sender As Object, e As EventArgs) Handles ButtonFish.Click
        ButtonGrain.Enabled = True '????
        ButtonChicken.Enabled = True
        ButtonFish.Enabled = False
    End Sub
    Private Sub ItemAddFood_Click(sender As Object, e As EventArgs) Handles ItemAddFood.Click
        If ButtonGrain.Enabled = False Then 'If the respective button for a dish is selected and then the button is selected it adds 1 to the quantity of the dish.
            ItemQuantity(0) = ItemQuantity(0) + 1
            ItemOneLabel.Text = (Convert.ToString(ItemQuantity(0)))
        ElseIf ButtonChicken.Enabled = False Then
            ItemQuantity(1) = ItemQuantity(1) + 1
            ItemTwoLabel.Text = (Convert.ToString(ItemQuantity(1)))
        ElseIf ButtonFish.Enabled = False Then
            ItemQuantity(2) = ItemQuantity(2) + 1
            ItemThreeLabel.Text = (Convert.ToString(ItemQuantity(2)))
        Else
        End If
    End Sub
    Private Sub ItemSubtractFood_Click(sender As Object, e As EventArgs) Handles ItemSubtractFood.Click
        If ButtonGrain.Enabled = False And Not ItemQuantity(0) = 0 Then 'Credit: Hugh Triglone for solving negative integer problem
            ItemQuantity(0) = ItemQuantity(0) - 1 'If the respective button for a dish is selected and it's value is not 0(prevents negative integers) it subtracts 1 from the quantity of the dish.
            ItemOneLabel.Text = (Convert.ToString(ItemQuantity(0)))
        ElseIf ButtonChicken.Enabled = False And Not ItemQuantity(1) = 0 Then
            ItemQuantity(1) = ItemQuantity(1) - 1
            ItemTwoLabel.Text = (Convert.ToString(ItemQuantity(1)))
        ElseIf ButtonFish.Enabled = False And Not ItemQuantity(2) = 0 Then
            ItemQuantity(2) = ItemQuantity(2) - 1
            ItemThreeLabel.Text = (Convert.ToString(ItemQuantity(2)))
        End If
    End Sub
    Private Sub ButtonVoidFood_Click(sender As Object, e As EventArgs) Handles ButtonVoidFood.Click
        If ButtonGrain.Enabled = False Then 'Changes the value of the quantity for the respective dish if it's button is pressed to 0
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
        If ButtonWater.Enabled = False And Not ItemQuantity(3) = 0 Then
            ItemQuantity(3) = ItemQuantity(3) - 1
            ItemFourLabel.Text = (Convert.ToString(ItemQuantity(3)))
        ElseIf ButtonFruitPunch.Enabled = False And Not ItemQuantity(4) = 0 Then
            ItemQuantity(4) = ItemQuantity(4) - 1
            ItemFiveLabel.Text = (Convert.ToString(ItemQuantity(4)))
        ElseIf ButtonAlmondMilk.Enabled = False And Not ItemQuantity(5) = 0 Then
            ItemQuantity(5) = ItemQuantity(5) - 1
            ItemSixLabel.Text = (Convert.ToString(ItemQuantity(5)))
        ElseIf ButtonVegetableSmoothie.Enabled = False And Not ItemQuantity(6) = 0 Then
            ItemQuantity(6) = ItemQuantity(6) - 1
            ItemSevenLabel.Text = (Convert.ToString(ItemQuantity(6)))
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
    Private Sub ButtonFruitSalad_Click(sender As Object, e As EventArgs) Handles ButtonFruitSalad.Click
        ButtonFruitSalad.Enabled = False 'It re-enables itself if i press add sides WHY?>?????????????? 
        ButtonVegetableSalad.Enabled = True
        ButtonBoneMarrow.Enabled = True
    End Sub
    Private Sub ButtonVegetableSalad_Click(sender As Object, e As EventArgs) Handles ButtonVegetableSalad.Click
        ButtonFruitSalad.Enabled = True
        ButtonVegetableSalad.Enabled = False
        ButtonBoneMarrow.Enabled = True
    End Sub
    Private Sub ButtonBoneMarrow_Click(sender As Object, e As EventArgs) Handles ButtonBoneMarrow.Click
        ButtonFruitSalad.Enabled = True
        ButtonVegetableSalad.Enabled = True
        ButtonBoneMarrow.Enabled = False
    End Sub
    Private Sub ItemAddSides_Click(sender As Object, e As EventArgs) Handles ItemAddSides.Click 'WHY THE FUCK DOESNT THIS WORK?????????
        If ButtonFruitSalad.Enabled = False Then
            ItemQuantity(7) = ItemQuantity(7) + 1
            ItemEightLabel.Text = (Convert.ToString(ItemQuantity(7)))
        ElseIf ButtonVegetableSalad.Enabled = False Then
            ItemQuantity(8) = ItemQuantity(8) + 1
            ItemNineLabel.Text = (Convert.ToString(ItemQuantity(8)))
        ElseIf ButtonBoneMarrow.Enabled = False Then
            ItemQuantity(9) = ItemQuantity(9) + 1
            ItemTenLabel.Text = (Convert.ToString(ItemQuantity(9)))
        End If
    End Sub
    Private Sub ItemSubtractSides_Click(sender As Object, e As EventArgs) Handles ItemSubtractSides.Click
        If ButtonFruitSalad.Enabled = False And Not ItemQuantity(7) = 0 Then
            ItemQuantity(7) = ItemQuantity(7) - 1
            ItemEightLabel.Text = (Convert.ToString(ItemQuantity(7)))
        ElseIf ButtonVegetableSalad.Enabled = False And Not ItemQuantity(7) = 0 Then
            ItemQuantity(8) = ItemQuantity(8) - 1
            ItemNineLabel.Text = (Convert.ToString(ItemQuantity(8)))
        ElseIf ButtonBoneMarrow.Enabled = False And Not ItemQuantity(9) = 0 Then
            ItemQuantity(9) = ItemQuantity(9) - 1
            ItemTenLabel.Text = (Convert.ToString(ItemQuantity(9)))
        End If
    End Sub
    Private Sub ItemVoidSides_Click(sender As Object, e As EventArgs) Handles ItemVoidSides.Click
        If ButtonFruitSalad.Enabled = False Then
            ItemQuantity(7) = 0
            ItemEightLabel.Text = (Convert.ToString(ItemQuantity(7)))
        ElseIf ButtonVegetableSalad.Enabled = False Then
            ItemQuantity(8) = 0
            ItemNineLabel.Text = (Convert.ToString(ItemQuantity(8)))
        ElseIf ButtonBoneMarrow.Enabled = False Then
            ItemQuantity(9) = 0
            ItemTenLabel.Text = (Convert.ToString(ItemQuantity(9)))
        End If
    End Sub
    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click 'Receipt Generation Button
        Dim TotalPriceString As String
        Dim FinalPriceString As String

        ItemPrice(0) = 10.5 'Grain
        ItemPrice(1) = 11.0 'Chicken
        ItemPrice(2) = 12.5 'Fish
        ItemPrice(3) = 3.0 'Water
        ItemPrice(4) = 4.0 'Fruit Punch
        ItemPrice(5) = 4.5 'Almond Milk
        ItemPrice(6) = 8.0 'Vegetable Smoothie
        ItemPrice(7) = 8.0 'Fruit Salad
        ItemPrice(8) = 8.0 'Vegetable Salad
        ItemPrice(9) = 35.0 'Bone Marrow

        'Declaring all the price values of each item in the array

        TotalPrice = ItemPrice(0) * ItemQuantity(0) + ItemPrice(1) * ItemQuantity(1) + ItemPrice(2) * ItemQuantity(2) + ItemPrice(3) * ItemQuantity(3) + ItemPrice(4) * ItemQuantity(4) + ItemPrice(5) * ItemQuantity(5) + ItemPrice(6) * ItemQuantity(6) + ItemPrice(7) * ItemQuantity(7) + ItemPrice(8) * ItemQuantity(8) + ItemPrice(9) * ItemQuantity(9)
        'looooooong but simple equation


        FinalPrice = TotalPrice * 1.1 'Adds 10% Goods & Services Tax (GST)

        TotalPriceString = (Convert.ToString(TotalPrice)) 'Converts to string so it can be written as one in 
        FinalPriceString = (Convert.ToString(FinalPrice))

        ListBoxReceipt.Items.Add("PAYMENT METHOD: " + ComboBoxPayment.SelectedItem) 'Writes the payment method into the listbox
        ListBoxReceipt.Items.Add("CUSTOMER NAME: " + TextBoxName.Text) 'Writes the name from order details
        ListBoxReceipt.Items.Add("PHONE: " + TextBoxPhoneNumber.Text) 'Writes the phone number from order details
        ListBoxReceipt.Items.Add("===================================")
        If ButtonDelivery.Enabled = False Then 'Displays all information necessary for delivery contact
            ListBoxReceipt.Items.Add("DELIVERY SURCHARGE $3")
            ListBoxReceipt.Items.Add("EMAIL: " + TextBoxEmail.Text)
            ListBoxReceipt.Items.Add("ADDRESS: " + TextBoxUnitNumber.Text + TextBoxStreetNumber.Text)
            ListBoxReceipt.Items.Add("Suburb" + TextBoxSuburb.Text + TextBoxPostCode.Text)
            ListBoxReceipt.Items.Add("===================================")
            FinalPrice = FinalPrice + 3.0 'Adds delivery surcharge

        End If

        Select Case ItemQuantity(0) 'If an item quantity is greater than 0 it will write the quantity and the item's name to the receipt
            Case > 0
                ListBoxReceipt.Items.Add(Convert.ToString(ItemQuantity(0)) + "x " + "Grain Kibble")
        End Select

        Select Case ItemQuantity(1)
            Case > 0
                ListBoxReceipt.Items.Add(Convert.ToString(ItemQuantity(1)) + "x " + "Chicken Kibble")
        End Select

        Select Case ItemQuantity(2)
            Case > 0
                ListBoxReceipt.Items.Add(Convert.ToString(ItemQuantity(2)) + "x " + "Fish Kibble")
        End Select

        Select Case ItemQuantity(3)
            Case > 0
                ListBoxReceipt.Items.Add(Convert.ToString(ItemQuantity(3)) + "x " + "Water")
        End Select

        Select Case ItemQuantity(4)
            Case > 0
                ListBoxReceipt.Items.Add(Convert.ToString(ItemQuantity(4)) + "x " + "Fruit Punch")
        End Select

        Select Case ItemQuantity(5)
            Case > 0
                ListBoxReceipt.Items.Add(Convert.ToString(ItemQuantity(5)) + "x " + "Almond Milk")
        End Select

        Select Case ItemQuantity(6)
            Case > 0
                ListBoxReceipt.Items.Add(Convert.ToString(ItemQuantity(6)) + "x " + "Vegetable Smoothie")
        End Select

        Select Case ItemQuantity(7)
            Case > 0
                ListBoxReceipt.Items.Add(Convert.ToString(ItemQuantity(7)) + "x " + "Fruit Salad")
        End Select

        Select Case ItemQuantity(8)
            Case > 0
                ListBoxReceipt.Items.Add(Convert.ToString(ItemQuantity(8)) + "x " + "Vegetable Salad")
        End Select

        Select Case ItemQuantity(9)
            Case > 0
                ListBoxReceipt.Items.Add(Convert.ToString(ItemQuantity(9)) + "x " + "Bone Marrow")
        End Select

        ListBoxReceipt.Items.Add("PRICE BEFORE TAX AND SURCHARGES $" + TotalPriceString)
        ListBoxReceipt.Items.Add("PRICE AFTER TAX AND SURCHARGES $" + FinalPriceString)
    End Sub
    Private Sub TextBoxName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxName.KeyPress
        If Not (Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") Then 'Keys.Back as a KeyChar has the same value as 8, I need this to allow backspace
            'Also need e.KeyChar = " " to allow the user to press space.
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter a valid character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxPhoneNumber_TextChanged_1(sender As Object, e As KeyPressEventArgs) Handles TextBoxPhoneNumber.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednumbers As String = "0123456789"
            If Not allowednumbers.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter numbers only!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxEmail_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxEmail.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then

            Dim allowednumbers As String = "0123456789"
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
            Dim allowedsymbols As String = "@."
            If Not allowednumbers.Contains(e.KeyChar.ToString.ToLower) And Not allowedchars.Contains(e.KeyChar.ToString.ToLower) And Not allowedsymbols.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter numbers, @. or alphabet")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxUnitNumber_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxUnitNumber.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednumbers As String = "0123456789"
            If Not allowednumbers.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter numbers only!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxStreetNumber_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxStreetNumber.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednumbers As String = "0123456789"
            If Not allowednumbers.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter numbers only!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxStreet_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxStreet.KeyPress
        If Not (Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter a valid character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSuburb_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSuburb.KeyPress
        If Not (Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter a valid character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxPostCode_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxPostCode.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednumbers As String = "0123456789"
            If Not allowednumbers.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter numbers only!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxNameCredit_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxNameCredit.KeyPress
        If Not (Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter a valid character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxCreditNumber_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxCreditNumber.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednumbers As String = "0123456789"
            If Not allowednumbers.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter numbers only, no spaces allowed!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxCVV_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxCVV.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednumbers As String = "0123456789"
            If Not allowednumbers.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter numbers only!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class

