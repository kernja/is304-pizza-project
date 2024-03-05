Public Class classBreadsticks
    Inherits classItem

    Public Sub New()
        myType = PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_BREADSTICK
        mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_SMALL
        mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_BREADSTICKS_REGULAR

        myOptions = New ArrayList
    End Sub

    Public Overrides Function getItemCost() As Double
        Dim myPrice As Double = 0
        Dim count As Double = 0

        Select Case mySize
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_SMALL
                myPrice = 3
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_MEDIUM
                myPrice = 4
            Case Else
                myPrice = 5
        End Select

        'we add a dollar and a half if they order specialty breadsticks
        If Not (mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_BREADSTICKS_REGULAR) Then
            myPrice = myPrice + 1.5
        End If

        count = myOptions.Count
        If count >= 2 Then
            'we don't charge for their first topping
            count = count - 1
            myPrice = myPrice + (count * 0.99)
        End If

        Return myPrice
    End Function

    Public Overrides Function toString() As String
        Dim myReturn As String = ""

        Select Case mySize
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_SMALL
                myReturn = "Small"
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_MEDIUM
                myReturn = "Medium"
            Case Else
                myReturn = "Large"
        End Select

        Select Case mySpecialty
            Case PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_BREADSTICKS_REGULAR
                myReturn = myReturn + " regular breadsticks with"
            Case PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_BREADSTICKS_CINNAMON
                myReturn = myReturn + " cinnamon breadsticks with"
            Case Else
                myReturn = myReturn + " cheesy breadsticks with"
        End Select

        myReturn = myReturn + " " + myOptions.Count.ToString + " dipping sauce(s)"
        Return myReturn
    End Function
End Class
