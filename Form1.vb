Public Class Form1


    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        Dim iExit As DialogResult
        iExit = MessageBox.Show("comfirm if you want to exit", "Stock Control", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If iExit = DialogResult.Yes Then
            Application.Exit()



        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPaymentMethod.Items.Add("Cash")
        cmbPaymentMethod.Items.Add("Master Card")
        cmbPaymentMethod.Items.Add("Visa Card")
        cmbPaymentMethod.Items.Add("Visa Debit Cash")

        cmbAccountType.Items.Add("Credit Account")
        cmbAccountType.Items.Add("Debit Account")
        cmbAccountType.Items.Add("Commercial Account")
        cmbAccountType.Items.Add("Online Order")
        cmbAccountType.Items.Add("Customer Account")

        cmbVAT.Items.Add("Yes")
        cmbVAT.Items.Add("NO")

        cmbProductID.Items.Add("PIDOO1")
        cmbProductID.Items.Add("PID012")
        cmbProductID.Items.Add("PIDO13")
        cmbProductID.Items.Add("PIDO14")
        cmbProductID.Items.Add("PIDO15")

        cmbNoSale.Items.Add("Yes")
        cmbNoSale.Items.Add("No")

        For q = 18 To 28
            cmbOrderID.Items.Add("OrID" & q)
            cmbCustomerID.Items.Add("CID002" & q)

        Next
        For d = 0 To 25 Step 5
            cmbDiscount.Items.Add(d)

        Next
    End Sub

    Private Sub cmbProductID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductID.SelectedIndexChanged
        If cmbProductID.Text = "PIDOO1" Then
            txtProduct.Text = "Rice"
            txtDescription.Text = "White Seed"
            txtStockLevel.Text = "200"
            lblReOrderLevel.Text = "50"
            lblOutofStock.Text = "2"
            txtCost.Text = "20"
        ElseIf cmbProductID.Text = "PIDO12" Then
            txtProduct.Text = "Beans"
            txtDescription.Text = "White Seed eye"
            txtStockLevel.Text = "120"
            lblReOrderLevel.Text = "10"
            lblOutofStock.Text = "2"
            txtCost.Text = "17"
        ElseIf cmbProductID.Text = "PIDO13" Then
            txtProduct.Text = "Carrot"
            txtDescription.Text = "Vegetable"
            txtStockLevel.Text = "150"
            lblReOrderLevel.Text = "15"
            lblOutofStock.Text = "2"
            txtCost.Text = "3"
        ElseIf cmbProductID.Text = "PIDO14" Then
            txtProduct.Text = "Bread"
            txtDescription.Text = "Flour/ Grain"
            txtStockLevel.Text = "400"
            lblReOrderLevel.Text = "100"
            lblOutofStock.Text = "2"
            txtCost.Text = "1.5"
        ElseIf cmbProductID.Text = "PIDO15" Then
            txtProduct.Text = "Eggs"
            txtDescription.Text = "Poultry"
            txtStockLevel.Text = "500"
            lblReOrderLevel.Text = "150"
            lblOutofStock.Text = "2"
            txtCost.Text = "1.34"

        End If
    End Sub

    Private Sub Form1_formClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub Form1_formClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub txtNoOrder_TextChanged(sender As Object, e As EventArgs) Handles txtNoOrder.TextChanged
        lblNoItemOrder.Text = txtNoOrder.Text

        lblReminder.Text = Val(txtStockLevel.Text) - Val(txtNoOrder.Text)

        If (lblReminder.Text = 2) Then
            lblAction.Text = "Order more product "
        Else
            lblAction.Text = "No order requested "
        End If
    End Sub

    Private Sub txtProduct_TextChanged(sender As Object, e As EventArgs) Handles txtProduct.TextChanged
        lblItemOrder.Text = txtProduct.Text

    End Sub

    Private Sub lblReminder_Click(sender As Object, e As EventArgs) Handles lblReminder.Click



    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim iTax As Decimal

        If cmbDiscount.Text = 0 Then



            iTax = ((Val(txtCost.Text) * Val(txtNoOrder.Text) * 7.5) / 100)
            lblTax.Text = iTax
            lblSubTotal.Text = Val(txtCost.Text) * Val(txtNoOrder.Text)


            lblTotal.Text = Val(lblSubTotal.Text) + (iTax)

        ElseIf cmbDiscount.Text = 5 Then

            iTax = ((Val(txtCost.Text) * Val(txtNoOrder.Text) * 7.5) / 100)
            lblTax.Text = iTax
            lblSubTotal.Text = Val(txtCost.Text) * Val(txtNoOrder.Text)


            lblTotal.Text = Val(lblSubTotal.Text) + (iTax)

        End If
        lblTax.Text = FormatCurrency(lblTax.Text)
        lblSubTotal.Text = FormatCurrency(lblSubTotal.Text)
        lblTotal.Text = FormatCurrency(lblTotal.Text)
    End Sub
End Class
