Public Class Form1


    Private Sub btnExit_Click(sender As Object, e As EventArgs)
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


        cmbProductID.Items.Add("Rice")
        cmbProductID.Items.Add("Beans")
        cmbProductID.Items.Add("Carrot")
        cmbProductID.Items.Add("Bread")
        cmbProductID.Items.Add("Eggs")
        cmbProductID.Items.Add("Apple")


        For q = 18 To 28
            cmbOrderID.Items.Add("OrID" & q)
            cmbCustomerID.Items.Add("CID002" & q)


        Next
    End Sub

    Private Sub cmbProductID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductID.SelectedIndexChanged
        If cmbProductID.Text = "Rice" Then
            txtProduct.Text = "PIDOO1"
            txtDescription.Text = "White Seed"
            txtStockLevel.Text = "200"
            lblReOrderLevel.Text = "Order more stock"
            lblOutofStock.Text = "2"
            txtCost.Text = "20"
        ElseIf cmbProductID.Text = "Beans" Then
            txtProduct.Text = "PIDO12"
            txtDescription.Text = "White Seed eye"
            txtStockLevel.Text = "120"
            lblReOrderLevel.Text = "Order more stock"
            lblOutofStock.Text = "2"
            txtCost.Text = "17"
        ElseIf cmbProductID.Text = "Carrot" Then
            txtProduct.Text = "PIDO13"
            txtDescription.Text = "Vegetable"
            txtStockLevel.Text = "150"
            lblReOrderLevel.Text = "Order more stock"
            lblOutofStock.Text = "2"
            txtCost.Text = "3"
        ElseIf cmbProductID.Text = "Bread" Then
            txtProduct.Text = "PIDO14"
            txtDescription.Text = "Flour/ Grain"
            txtStockLevel.Text = "400"
            lblReOrderLevel.Text = "Order more stock"
            lblOutofStock.Text = "2"
            txtCost.Text = "1.5"
        ElseIf cmbProductID.Text = "Eggs" Then
            txtProduct.Text = "PIDO15"
            txtDescription.Text = "Poultry"
            txtStockLevel.Text = "500"
            lblReOrderLevel.Text = "Order more stock"
            lblOutofStock.Text = "2"
            txtCost.Text = "1.34"
        ElseIf cmbProductID.Text = "Apple" Then
            txtProduct.Text = "PIDO16"
            txtDescription.Text = "Fruits"
            txtStockLevel.Text = "120"
            lblReOrderLevel.Text = "Order more stock"
            lblOutofStock.Text = "2"
            txtCost.Text = "3.00"

        End If
    End Sub

    Private Sub Form1_formClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub Form1_formClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        btnExit.PerformClick()

    End Sub

    Private Sub txtNoOrder_TextChanged(sender As Object, e As EventArgs) Handles txtNoOrder.TextChanged
        lblNoItemOrder.Text = txtNoOrder.Text

        lblReminder.Text = Val(txtStockLevel.Text) - Val(txtNoOrder.Text)

        If (lblReminder.Text <= 2) Then
            MsgBox("More order requested", MsgBoxStyle.Information, "Order messege")

        Else
            lblAction.Text = "No order requested"
        End If
    End Sub

    Private Sub txtProduct_TextChanged(sender As Object, e As EventArgs) Handles txtProduct.TextChanged
        lblItemOrder.Text = cmbProductID.Text

    End Sub

    Private Sub lblReminder_Click(sender As Object, e As EventArgs) Handles lblReminder.Click



    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim iTax As Decimal

        iTax = ((Val(txtCost.Text) * Val(txtNoOrder.Text)) / 100 * 7.5)
        lblTax.Text = iTax
        lblSubTotal.Text = Val(txtCost.Text) * Val(txtNoOrder.Text)


        lblTotal.Text = (Val(lblSubTotal.Text) + Val(lblTax.Text))


        lblTax.Text = FormatCurrency(lblTax.Text)
        lblSubTotal.Text = FormatCurrency(lblSubTotal.Text)
        lblTotal.Text = FormatCurrency(lblTotal.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtCost.Text = ""
        lblTax.Text = ""
        lblSubTotal.Text = ""
        lblTotal.Text = ""


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtCost.Text = ""
        lblTax.Text = ""
        lblSubTotal.Text = ""
        lblTotal.Text = ""
        cmbCustomerID.Text = "0"
    End Sub

    Private Sub cmbPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentMethod.SelectedIndexChanged
        If cmbPaymentMethod.Text = "Cash" Then
            cmbAccountType.Text = "Pay "
        Else
            cmbAccountType.Text = "Account type "
        End If
    End Sub


End Class
