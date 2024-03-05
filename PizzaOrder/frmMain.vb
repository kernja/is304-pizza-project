Public Class frmMain
    Friend myOrder As classOrder
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myOrder = New classOrder

     updateBoxes()
    End Sub

    Private Sub addItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    btnAddPizza.Click, btnAddPasta.Click, btnAddSticks.Click, btnAddSoda.Click
        Dim newObject As New Object

        If sender.Equals(btnAddPizza) Then
            newObject = New frmItem().newItem(PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_PIZZA)
        ElseIf sender.Equals(btnAddPasta) Then
            newObject = New frmItem().newItem(PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_PASTA)
        ElseIf sender.Equals(btnAddSticks) Then
            newObject = New frmItem().newItem(PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_BREADSTICK)
        Else
            newObject = New frmItem().newItem(PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_SODA)
        End If

        Try
            If Not (newObject.Equals(vbNull)) Then
                myOrder.orderItems.Add(newObject)

            End If
        Catch ex As Exception
            Debug.Print("casting error")
        End Try
updateBoxes()
    End Sub

    Private Sub selectedItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOrder.SelectedIndexChanged
        Me.btnModifyItem.Enabled = True
        Me.btnRemoveItem.Enabled = True
    End Sub

    Private Sub modifyItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifyItem.Click
        Dim myCast As classItem
        Dim myReturn As New Object
        Dim myForm As New frmItem
        myCast = lstOrder.Items(lstOrder.SelectedIndex)

        myReturn = myForm.editItem(myCast)

        Try
            If Not (myReturn.Equals(Nothing)) Then
                myOrder.orderItems.Item(lstOrder.SelectedIndex) = myReturn
              
            End If
        Catch ex As Exception
            Debug.Print("Casting exception with Null and nothing.")
        End Try

        updateBoxes()
        btnModifyItem.Enabled = False
    End Sub

    Private Sub removeItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveItem.Click
        myOrder.orderItems.RemoveAt(lstOrder.SelectedIndex)
        myOrder.updateOrderBox(lstOrder)
        myOrder.computeTotal(lblSubtotalValue, lblTotalValue)

        btnRemoveItem.Enabled = False
        btnModifyItem.Enabled = False
    End Sub

    Private Sub submit(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrderSubmit.Click
        Dim submitOrder As frmCheckout
        submitOrder = New frmCheckout
        submitOrder.loadForm(myOrder)

        updateBoxes()
    End Sub

    Sub updateBoxes()
        myOrder.updateOrderBox(lstOrder)
        myOrder.computeTotal(lblSubtotalValue, lblTotalValue)

        If myOrder.orderItems.Count = 0 Then
            lblSubtotalValue.Text = 0
            lblTotalValue.Text = 0
        End If
    End Sub

    Private Sub btnClearOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearOrder.Click
        Dim myReturn As Single

        myReturn = MsgBox("Are you sure you want to clear your order?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Confirm clear?")
        If myReturn = vbYes Then
            myOrder = New classOrder
            updateBoxes()
        End If
    End Sub
End Class
