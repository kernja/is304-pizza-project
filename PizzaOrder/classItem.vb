Public MustInherit Class classItem
    Friend myOptions As ArrayList

    Friend myType As PIZZA_ITEM_TYPE
    Friend mySpecialty As PIZZA_ITEM_SPECIALTY_TYPE
    Friend mySize As PIZZA_ITEM_SIZE
    Public Sub New()
        myType = PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_NOTHING
        mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PIZZA_HANDTOSSED
        mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_PERSONAL
    End Sub
    Public Overrides Function toString() As String
        Return ""
    End Function
    Protected Overrides Sub Finalize()
        myOptions = Nothing
        MyBase.Finalize()
    End Sub
    Public Sub copy(ByVal newValues As classItem)
        Dim i As Single
        Dim myCast As classToppings
        myType = newValues.myType
        mySpecialty = newValues.mySpecialty
        mySize = newValues.mySize

        myOptions.Clear()
        For i = 0 To newValues.myOptions.Count - 1
            myCast = newValues.myOptions.Item(i)
            myOptions.Add(New classToppings(myCast.myType))
        Next
    End Sub
    Public Overridable Function getItemCost() As Double
        Return 0
    End Function
End Class
