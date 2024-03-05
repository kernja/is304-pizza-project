Public Class classOrder
    Public orderItems As ArrayList
    Public subtotal As Double
    Public total As Double

    Public Sub New()
        orderItems = New ArrayList
        subtotal = 0
        total = 0
    End Sub
    Public Sub resetOrder()
        orderItems.Clear()
        subtotal = 0
        total = 0
    End Sub
    Public Sub computeTotal(ByRef labelSubTotal As Windows.Forms.Label, ByRef labelTotal As Windows.Forms.Label)
        Dim i As Single
        Dim mySubtotal As Decimal
        Dim myTotal As Decimal
        Dim tempCast As classItem

        For i = 0 To orderItems.Count - 1
            tempCast = orderItems.Item(i)

            If Not (tempCast.myType = PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_NOTHING) Then
                mySubtotal = mySubtotal + tempCast.getItemCost
            End If

            myTotal = mySubtotal * 1.055

            myTotal = Math.Round(myTotal, 2)
            mySubtotal = Math.Round(mySubtotal, 2)

            labelSubTotal.Text = mySubtotal.ToString
            labelTotal.Text = myTotal.ToString
        Next i
    End Sub
    Public Sub updateOrderBox(ByRef listOrderBox As Windows.Forms.ListBox)
        Dim i As Single
        listOrderBox.Items.Clear()

        For i = 0 To orderItems.Count - 1
            listOrderBox.Items.Add(orderItems.Item(i))
        Next
    End Sub
    Protected Overrides Sub Finalize()
        orderItems = Nothing
        subtotal = 0
        total = 0
        MyBase.Finalize()
    End Sub
End Class
