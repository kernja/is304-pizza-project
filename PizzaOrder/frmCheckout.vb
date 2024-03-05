
Public Class frmCheckout
    Dim submitted As Boolean = False
    Dim myOrder As classOrder
    Public Sub loadForm(ByRef order As classOrder)
        myOrder = order
        Me.ShowDialog()

        If submitted = True Then
            order = New classOrder
        End If
    End Sub
    Private Sub submit(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        MsgBox("Insert code here to submit order to server.", MsgBoxStyle.Information, "Information")
        Me.Hide()
        submitted = True

    End Sub

    Private Sub cancel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub frmCheckout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class