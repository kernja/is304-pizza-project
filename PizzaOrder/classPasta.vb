Public Class classPasta
    Inherits classItem

    Public Sub New()
        myType = PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_PASTA
        mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_SMALL
        mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PASTA_MARINARA

        myOptions = New ArrayList
    End Sub

    Public Overrides Function getItemCost() As Double
        Dim myPrice As Double = 0
        Dim count As Double = 0

        Select Case mySize
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_SMALL
                myPrice = 4
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_MEDIUM
                myPrice = 6
            Case Else
                myPrice = 8
        End Select

        count = myOptions.Count
        If count >= 3 Then
            'we don't charge for their first two toppings
            count = count - 2
            myPrice = myPrice + (count * 0.75)
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
            Case PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PASTA_MARINARA
                myReturn = myReturn + " marinara pasta with"
            Case PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PASTA_ALFREDO
                myReturn = myReturn + " alfredo pasta with"
            Case Else
                myReturn = myReturn + " italian pasta with"
        End Select

        myReturn = myReturn + " " + myOptions.Count.ToString + " topping(s)"
        Return myReturn
    End Function
End Class
