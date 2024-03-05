Public Class frmItem
    Dim myItem As classItem
    Dim cancelled As Boolean = False
    Friend Function newItem(ByVal itemType As PIZZA_ITEM_TYPE) As classItem
        Select Case itemType
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_PIZZA
                myItem = New classPizza
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_PASTA
                myItem = New classPasta
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_BREADSTICK
                myItem = New classBreadsticks
            Case Else
                myItem = New classSoda
        End Select

        prepForm()
        ShowDialog()
        copyToppings()

        Return myItem
    End Function
    Friend Function editItem(ByRef editedItem As classItem) As classItem
        Select Case editedItem.myType
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_PIZZA
                myItem = New classPizza
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_PASTA
                myItem = New classPasta
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_BREADSTICK
                myItem = New classBreadsticks
            Case Else
                myItem = New classSoda
        End Select
        myItem.copy(editedItem)
        prepForm()
        ShowDialog()
        copyToppings()
        Return myItem
    End Function
    Private Sub copyToppings()
        Dim i As Single
        Dim myCast As classToppings

        If cancelled = False Then
            myItem.myOptions.Clear()
            For i = 0 To lstObjects.Items.Count - 1
                myCast = lstObjects.Items(i)
                myItem.myOptions.Add(New classToppings(myCast.myType))
            Next
        End If
    End Sub
    Private Sub prepForm()
        Dim i As Single
        Dim myCast As classToppings

        cboItems.Items.Clear()
        lstObjects.Items.Clear()

        For i = 0 To myItem.myOptions.Count - 1
            myCast = myItem.myOptions.Item(i)
            Me.lstObjects.Items.Add(New classToppings(myCast.myType))
        Next

        Select Case myItem.myType
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_PIZZA
                Me.Text = "Pizza Selector"
                grpItemType.Text = "Pizza Type"
                grpItemSize.Text = "Pizza Size"
                optItemA.Text = "Hand-Tossed"
                optItemB.Text = "Deep-Dish"
                optItemC.Text = "Thin-Crust"
                optItemD.Text = "Cheesy Crust"
                optItemE.Visible = False
                optItemF.Visible = False

                optItemSizeA.Text = "Personal"
                optItemSizeB.Text = "Small"
                optItemSizeC.Text = "Medium"
                optItemSizeD.Text = "Large"
                optItemSizeE.Text = "Extra Large"
                optItemSizeF.Visible = False

                If myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PIZZA_HANDTOSSED Then
                    optItemA.Checked = True
                ElseIf myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PIZZA_DEEPDISH Then
                    optItemB.Checked = True
                ElseIf myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PIZZA_DEEPDISH Then
                    optItemC.Checked = True
                Else
                    optItemD.Checked = True
                End If

                If myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_PERSONAL Then
                    optItemSizeA.Checked = True
                ElseIf myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_SMALL Then
                    optItemSizeB.Checked = True
                ElseIf myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_MEDIUM Then
                    optItemSizeC.Checked = True
                ElseIf myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_LARGE Then
                    optItemSizeD.Checked = True
                Else
                    optItemSizeE.Checked = True
                End If

                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_BACON))
                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_CHEESE))
                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_GREENPEPPER))
                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_HAM))
                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_PEPPERONI))
                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_PINEAPPLE))
                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_SAUSAGE))
                cboItems.SelectedIndex = 0
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_PASTA
                Me.Text = "Pasta Selector"
                grpItemType.Text = "Pasta Type"
                grpItemSize.Text = "Pasta Size"
                optItemA.Text = "Marinara"
                optItemB.Text = "Alfredo"
                optItemC.Text = "Italian"
                optItemD.Visible = False
                optItemE.Visible = False
                optItemF.Visible = False

                optItemSizeA.Text = "Small"
                optItemSizeB.Text = "Medium"
                optItemSizeC.Text = "Large"
                optItemSizeD.Visible = False
                optItemSizeE.Visible = False
                optItemSizeF.Visible = False

                If myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PASTA_MARINARA Then
                    optItemA.Checked = True
                ElseIf myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PASTA_ALFREDO Then
                    optItemB.Checked = True
                ElseIf myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PASTA_ITALIAN Then
                    optItemC.Checked = True
                End If

                If myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_SMALL Then
                    optItemSizeA.Checked = True
                ElseIf myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_MEDIUM Then
                    optItemSizeB.Checked = True
                ElseIf myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_LARGE Then
                    optItemSizeC.Checked = True
                End If

                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_BACON))
                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_CHEESE))
                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_GREENPEPPER))
                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_HAM))
                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_PEPPERONI))
                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_PINEAPPLE))
                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_SAUSAGE))
                cboItems.SelectedIndex = 0
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_BREADSTICK
                Me.Text = "Breadstick Selector"
                grpItemType.Text = "Breadstick Type"
                grpItemSize.Text = "Breadstick Size"
                optItemA.Text = "Regular"
                optItemB.Text = "Cinnamon"
                optItemC.Text = "Cheesy"
                optItemD.Visible = False
                optItemE.Visible = False
                optItemF.Visible = False

                optItemSizeA.Text = "Small"
                optItemSizeB.Text = "Medium"
                optItemSizeC.Text = "Large"
                optItemSizeD.Visible = False
                optItemSizeE.Visible = False
                optItemSizeF.Visible = False

                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_NACHOCHEESE))
                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_VANILLAICING))
                cboItems.Items.Add(New classToppings(PIZZA_ITEM_TOPPINGS.PIZZA_ITEM_TOPPINGS_RANCH))
                cboItems.SelectedIndex = 0

                If myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_BREADSTICKS_REGULAR Then
                    optItemA.Checked = True
                ElseIf myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_BREADSTICKS_CINNAMON Then
                    optItemB.Checked = True
                ElseIf myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_BREADSTICKS_CHEESY Then
                    optItemC.Checked = True
                End If

                If myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_SMALL Then
                    optItemSizeA.Checked = True
                ElseIf myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_MEDIUM Then
                    optItemSizeB.Checked = True
                ElseIf myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_LARGE Then
                    optItemSizeC.Checked = True
                End If

            Case Else
                Me.Text = "Soda Selector"
                grpItemType.Text = "Soda Type"
                grpItemOptions.Visible = False

                btnOK.Top = grpItemSize.Bottom + 8
                btnCancel.Top = grpItemSize.Bottom + 8

                Me.Height = btnOK.Top + 73

                optItemA.Text = "Coca-Cola"
                optItemB.Text = "Diet Coca-Cola"
                optItemC.Text = "Mello-Yellow"
                optItemD.Text = "Sprite"
                optItemE.Text = "Lemonaide"
                optItemF.Text = "Rootbeer"

                optItemSizeA.Text = "20 oz."
                optItemSizeB.Text = "2-Liter"
                optItemSizeC.Visible = False
                optItemSizeD.Visible = False
                optItemSizeE.Visible = False
                optItemSizeF.Visible = False

                If myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_COKE Then
                    optItemA.Checked = True
                ElseIf myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_DCOKE Then
                    optItemB.Checked = True
                ElseIf myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_MELLOYELLOW Then
                    optItemC.Checked = True
                ElseIf myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_SPRITE Then
                    optItemD.Checked = True
                ElseIf myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_LEMONAIDE Then
                    optItemE.Checked = True
                ElseIf myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_ROOTBEER Then
                    optItemF.Checked = True
                End If

                If myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_20OZ Then
                    optItemSizeA.Checked = True
                Else
                    optItemSizeB.Checked = True
                End If

        End Select

    End Sub
    Private Sub selectedSpeciality(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    optItemA.CheckedChanged, optItemB.CheckedChanged, optItemC.CheckedChanged, optItemD.CheckedChanged, _
    optItemE.CheckedChanged, optItemF.CheckedChanged

        Select Case myItem.myType
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_PIZZA
                If sender.Equals(optItemA) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PIZZA_HANDTOSSED
                ElseIf sender.Equals(optItemB) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PIZZA_DEEPDISH
                ElseIf sender.Equals(optItemC) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PIZZA_THINCRUST
                ElseIf sender.Equals(optItemD) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PIZZA_LAYEREDCHEESE
                End If
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_PASTA
                If sender.Equals(optItemA) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PASTA_MARINARA
                ElseIf sender.Equals(optItemB) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PASTA_ALFREDO
                ElseIf sender.Equals(optItemC) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_PASTA_ITALIAN
                End If
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_BREADSTICK
                If sender.Equals(optItemA) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_BREADSTICKS_REGULAR
                ElseIf sender.Equals(optItemB) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_BREADSTICKS_CINNAMON
                ElseIf sender.Equals(optItemC) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_BREADSTICKS_CHEESY
                End If
            Case Else
                If sender.Equals(optItemA) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_COKE
                ElseIf sender.Equals(optItemB) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_DCOKE
                ElseIf sender.Equals(optItemC) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_MELLOYELLOW
                ElseIf sender.Equals(optItemD) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_SPRITE
                ElseIf sender.Equals(optItemE) Then
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_LEMONAIDE
                Else
                    myItem.mySpecialty = PIZZA_ITEM_SPECIALTY_TYPE.PIZZA_ITEM_SPECIALTY_TYPE_SODA_ROOTBEER
                End If
        End Select

    End Sub

    Private Sub selectedSize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
   optItemSizeA.CheckedChanged, optItemSizeB.CheckedChanged, optItemSizeC.CheckedChanged, optItemSizeD.CheckedChanged, _
   optItemSizeE.CheckedChanged, optItemSizeF.CheckedChanged

        Select Case myItem.myType
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_PIZZA
                If sender.Equals(optItemSizeA) Then
                    myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_PERSONAL
                ElseIf sender.Equals(optItemSizeB) Then
                    myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_SMALL
                ElseIf sender.Equals(optItemSizeC) Then
                    myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_MEDIUM
                ElseIf sender.Equals(optItemSizeD) Then
                    myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_LARGE
                ElseIf sender.Equals(optItemSizeE) Then
                    myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_XLARGE
                End If
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_PASTA
                If sender.Equals(optItemSizeA) Then
                    myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_SMALL
                ElseIf sender.Equals(optItemSizeB) Then
                    myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_MEDIUM
                ElseIf sender.Equals(optItemSizeC) Then
                    myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_LARGE
                End If
            Case PIZZA_ITEM_TYPE.PIZZA_ITEM_TYPE_BREADSTICK
                If sender.Equals(optItemSizeA) Then
                    myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_SMALL
                ElseIf sender.Equals(optItemSizeB) Then
                    myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_MEDIUM
                ElseIf sender.Equals(optItemSizeC) Then
                    myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_LARGE
                End If
            Case Else
                If sender.Equals(optItemSizeA) Then
                    myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_20OZ
                ElseIf sender.Equals(optItemSizeB) Then
                    myItem.mySize = PIZZA_ITEM_SIZE.PIZZA_ITEM_SIZE_2LITER
                End If
        End Select

    End Sub
    Private Sub exitForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    btnOK.Click, btnCancel.Click

        If sender.Equals(btnOK) Then
            Me.Hide()
        Else
            myItem = Nothing
            cancelled = True
            Me.Hide()
        End If

    End Sub

    Private Sub addObject(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddObject.Click
        Dim myCast As classToppings
        myCast = cboItems.Items(cboItems.SelectedIndex)
        myItem.myOptions.Add(New classToppings(myCast.myType))

        prepForm()
    End Sub

    Private Sub selectedObject(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstObjects.SelectedIndexChanged
        btnRemoveObject.Enabled = True
    End Sub

    Private Sub btnRemoveObject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveObject.Click
        myItem.myOptions.RemoveAt(lstObjects.SelectedIndex)

        prepForm()
        btnRemoveObject.Enabled = False
    End Sub

    Private Sub frmItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class