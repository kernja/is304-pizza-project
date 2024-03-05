Public Class classSoda
    Inherits classItem

    Public Sub New()
        myType = PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_SODA
        mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_20OZ
        mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_COKE

        myOptions = New ArrayList
    End Sub

    Public Overrides Function getItemCost() As Double
        Dim myPrice As Double = 0
        Dim count As Double = 0

        Select Case mySize
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_20OZ
                myPrice = 1.29
            Case Else
                myPrice = 1.99
        End Select

        Return myPrice
    End Function

    Public Overrides Function toString() As String
        Dim myReturn As String = ""

        Select Case mySize
            Case PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_20OZ
                myReturn = "20 oz. bottle of"
            Case Else
                myReturn = "2 liter bottle of"
        End Select

        Select Case mySpecialty
            Case PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_COKE
                myReturn = myReturn + " Coca-Cola"
            Case PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_DCOKE
                myReturn = myReturn + " Diet Coca-Cola"
            Case PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_MELLOYELLOW
                myReturn = myReturn + " Mello-Yellow"
            Case PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_SPRITE
                myReturn = myReturn + " Sprite"
            Case PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_LEMONAIDE
                myReturn = myReturn + " Lemonaide"
            Case Else
                myReturn = myReturn + " Rootbeer"
        End Select

        Return myReturn
    End Function
End Class
