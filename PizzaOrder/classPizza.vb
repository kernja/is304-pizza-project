Class classPizza
    Inherits classItem

    Public Sub New()
        myType = PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_PIZZA
        mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_PERSONAL
        mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PIZZA_HANDTOSSED

        myOptions = New ArrayList
    End Sub

    Public Overrides Function getItemCost() As Double
        Dim myPrice As Double = 0
        Dim count As Double = 0

        Select Case mySize
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_PERSONAL
                myPrice = 3
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_SMALL
                myPrice = 5
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_MEDIUM
                myPrice = 7
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_LARGE
                myPrice = 9
            Case Else
                myPrice = 13
        End Select

        'if they have cheesy crust, we add two dollars extra to their price
        If mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PIZZA_LAYEREDCHEESE Then
            myPrice = myPrice + 2
        End If

        count = myOptions.Count
        If count >= 3 Then
            'we don't charge for their first two toppings
            count = count - 2
            myPrice = myPrice + (count * 0.5)
        End If

        Return myPrice
    End Function

    Public Overrides Function toString() As String
        Dim myReturn As String = ""

        Select Case mySize
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_PERSONAL
                myReturn = "Personal"
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_SMALL
                myReturn = "Small"
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_MEDIUM
                myReturn = "Medium"
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_LARGE
                myReturn = "Large"
            Case Else
                myReturn = "Extra large"
        End Select

        Select Case mySpecialty
            Case PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PIZZA_HANDTOSSED
                myReturn = myReturn + " handtossed pizza with"
            Case PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PIZZA_DEEPDISH
                myReturn = myReturn + " deep-dish pizza with"
            Case PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PIZZA_THINCRUST
                myReturn = myReturn + " thin-crust pizza with"
            Case Else
                myReturn = myReturn + " layered cheese pizza with"
        End Select

        myReturn = myReturn + " " + myOptions.Count.ToString + " topping(s)"
        Return myReturn
    End Function
End Class
