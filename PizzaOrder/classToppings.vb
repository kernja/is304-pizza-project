Public Class classToppings
    Public myType As PIZZA_ITEM_TOPPINGS

    Public Sub New(ByVal type As PIZZA_ITEM_TOPPINGS)
        myType = type
    End Sub

    Public Overrides Function ToString() As String
        Dim myReturn As String

        Select Case myType
            Case PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_BACON
                myReturn = "Bacon"
            Case PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_CHEESE
                myReturn = "Cheese"
            Case PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_GREENPEPPER
                myReturn = "Green pepper"
            Case PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_HAM
                myReturn = "Ham"
            Case PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_NACHOCHEESE
                myReturn = "Nacho cheese"
            Case PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_PEPPERONI
                myReturn = "Pepperoni"
            Case PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_PINEAPPLE
                myReturn = "Pineapple"
            Case PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_RANCH
                myReturn = "Ranch"
            Case PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_SAUSAGE
                myReturn = "Sausage"
            Case Else
                myReturn = "Vanilla icing"
        End Select
        Return myReturn
    End Function
End Class
