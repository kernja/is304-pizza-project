<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpAddProduct = New System.Windows.Forms.GroupBox
        Me.btnAddSoda = New System.Windows.Forms.Button
        Me.btnAddSticks = New System.Windows.Forms.Button
        Me.btnAddPasta = New System.Windows.Forms.Button
        Me.btnAddPizza = New System.Windows.Forms.Button
        Me.grpCurrentOrder = New System.Windows.Forms.GroupBox
        Me.btnRemoveItem = New System.Windows.Forms.Button
        Me.btnModifyItem = New System.Windows.Forms.Button
        Me.lstOrder = New System.Windows.Forms.ListBox
        Me.grpCheckOut = New System.Windows.Forms.GroupBox
        Me.lblTotalValue = New System.Windows.Forms.Label
        Me.lblPercentValue = New System.Windows.Forms.Label
        Me.lblSubtotalValue = New System.Windows.Forms.Label
        Me.btnClearOrder = New System.Windows.Forms.Button
        Me.btnOrderSubmit = New System.Windows.Forms.Button
        Me.lblTotalCaption = New System.Windows.Forms.Label
        Me.lblTaxCaption = New System.Windows.Forms.Label
        Me.lblSubtotalCaption = New System.Windows.Forms.Label
        Me.grpAddProduct.SuspendLayout()
        Me.grpCurrentOrder.SuspendLayout()
        Me.grpCheckOut.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAddProduct
        '
        Me.grpAddProduct.Controls.Add(Me.btnAddSoda)
        Me.grpAddProduct.Controls.Add(Me.btnAddSticks)
        Me.grpAddProduct.Controls.Add(Me.btnAddPasta)
        Me.grpAddProduct.Controls.Add(Me.btnAddPizza)
        Me.grpAddProduct.Location = New System.Drawing.Point(12, 12)
        Me.grpAddProduct.Name = "grpAddProduct"
        Me.grpAddProduct.Size = New System.Drawing.Size(321, 174)
        Me.grpAddProduct.TabIndex = 0
        Me.grpAddProduct.TabStop = False
        Me.grpAddProduct.Text = "Add to your order..."
        '
        'btnAddSoda
        '
        Me.btnAddSoda.Location = New System.Drawing.Point(6, 133)
        Me.btnAddSoda.Name = "btnAddSoda"
        Me.btnAddSoda.Size = New System.Drawing.Size(309, 32)
        Me.btnAddSoda.TabIndex = 3
        Me.btnAddSoda.Text = "Soda"
        Me.btnAddSoda.UseVisualStyleBackColor = True
        '
        'btnAddSticks
        '
        Me.btnAddSticks.Location = New System.Drawing.Point(6, 95)
        Me.btnAddSticks.Name = "btnAddSticks"
        Me.btnAddSticks.Size = New System.Drawing.Size(309, 32)
        Me.btnAddSticks.TabIndex = 2
        Me.btnAddSticks.Text = "Breadsticks"
        Me.btnAddSticks.UseVisualStyleBackColor = True
        '
        'btnAddPasta
        '
        Me.btnAddPasta.Location = New System.Drawing.Point(6, 57)
        Me.btnAddPasta.Name = "btnAddPasta"
        Me.btnAddPasta.Size = New System.Drawing.Size(309, 32)
        Me.btnAddPasta.TabIndex = 1
        Me.btnAddPasta.Text = "Pasta"
        Me.btnAddPasta.UseVisualStyleBackColor = True
        '
        'btnAddPizza
        '
        Me.btnAddPizza.Location = New System.Drawing.Point(6, 19)
        Me.btnAddPizza.Name = "btnAddPizza"
        Me.btnAddPizza.Size = New System.Drawing.Size(309, 32)
        Me.btnAddPizza.TabIndex = 0
        Me.btnAddPizza.Text = "Pizza"
        Me.btnAddPizza.UseVisualStyleBackColor = True
        '
        'grpCurrentOrder
        '
        Me.grpCurrentOrder.Controls.Add(Me.btnRemoveItem)
        Me.grpCurrentOrder.Controls.Add(Me.btnModifyItem)
        Me.grpCurrentOrder.Controls.Add(Me.lstOrder)
        Me.grpCurrentOrder.Location = New System.Drawing.Point(12, 192)
        Me.grpCurrentOrder.Name = "grpCurrentOrder"
        Me.grpCurrentOrder.Size = New System.Drawing.Size(321, 177)
        Me.grpCurrentOrder.TabIndex = 1
        Me.grpCurrentOrder.TabStop = False
        Me.grpCurrentOrder.Text = "Current Order"
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Enabled = False
        Me.btnRemoveItem.Location = New System.Drawing.Point(169, 151)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(145, 20)
        Me.btnRemoveItem.TabIndex = 2
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'btnModifyItem
        '
        Me.btnModifyItem.Enabled = False
        Me.btnModifyItem.Location = New System.Drawing.Point(11, 151)
        Me.btnModifyItem.Name = "btnModifyItem"
        Me.btnModifyItem.Size = New System.Drawing.Size(152, 20)
        Me.btnModifyItem.TabIndex = 1
        Me.btnModifyItem.Text = "Modify Selected Item"
        Me.btnModifyItem.UseVisualStyleBackColor = True
        '
        'lstOrder
        '
        Me.lstOrder.FormattingEnabled = True
        Me.lstOrder.Location = New System.Drawing.Point(11, 20)
        Me.lstOrder.Name = "lstOrder"
        Me.lstOrder.Size = New System.Drawing.Size(303, 121)
        Me.lstOrder.TabIndex = 0
        '
        'grpCheckOut
        '
        Me.grpCheckOut.Controls.Add(Me.lblTotalValue)
        Me.grpCheckOut.Controls.Add(Me.lblPercentValue)
        Me.grpCheckOut.Controls.Add(Me.lblSubtotalValue)
        Me.grpCheckOut.Controls.Add(Me.btnClearOrder)
        Me.grpCheckOut.Controls.Add(Me.btnOrderSubmit)
        Me.grpCheckOut.Controls.Add(Me.lblTotalCaption)
        Me.grpCheckOut.Controls.Add(Me.lblTaxCaption)
        Me.grpCheckOut.Controls.Add(Me.lblSubtotalCaption)
        Me.grpCheckOut.Location = New System.Drawing.Point(15, 376)
        Me.grpCheckOut.Name = "grpCheckOut"
        Me.grpCheckOut.Size = New System.Drawing.Size(317, 120)
        Me.grpCheckOut.TabIndex = 2
        Me.grpCheckOut.TabStop = False
        Me.grpCheckOut.Text = "Checkout"
        '
        'lblTotalValue
        '
        Me.lblTotalValue.AutoSize = True
        Me.lblTotalValue.Location = New System.Drawing.Point(242, 53)
        Me.lblTotalValue.Name = "lblTotalValue"
        Me.lblTotalValue.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalValue.TabIndex = 7
        Me.lblTotalValue.Text = "0"
        Me.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPercentValue
        '
        Me.lblPercentValue.AutoSize = True
        Me.lblPercentValue.Location = New System.Drawing.Point(242, 29)
        Me.lblPercentValue.Name = "lblPercentValue"
        Me.lblPercentValue.Size = New System.Drawing.Size(30, 13)
        Me.lblPercentValue.TabIndex = 6
        Me.lblPercentValue.Text = "5.5%"
        Me.lblPercentValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSubtotalValue
        '
        Me.lblSubtotalValue.AutoSize = True
        Me.lblSubtotalValue.Location = New System.Drawing.Point(242, 16)
        Me.lblSubtotalValue.Name = "lblSubtotalValue"
        Me.lblSubtotalValue.Size = New System.Drawing.Size(13, 13)
        Me.lblSubtotalValue.TabIndex = 5
        Me.lblSubtotalValue.Text = "0"
        Me.lblSubtotalValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClearOrder
        '
        Me.btnClearOrder.Location = New System.Drawing.Point(6, 86)
        Me.btnClearOrder.Name = "btnClearOrder"
        Me.btnClearOrder.Size = New System.Drawing.Size(132, 27)
        Me.btnClearOrder.TabIndex = 4
        Me.btnClearOrder.Text = "Clear Order"
        Me.btnClearOrder.UseVisualStyleBackColor = True
        '
        'btnOrderSubmit
        '
        Me.btnOrderSubmit.Location = New System.Drawing.Point(144, 85)
        Me.btnOrderSubmit.Name = "btnOrderSubmit"
        Me.btnOrderSubmit.Size = New System.Drawing.Size(163, 28)
        Me.btnOrderSubmit.TabIndex = 3
        Me.btnOrderSubmit.Text = "Pay and Submit Order"
        Me.btnOrderSubmit.UseVisualStyleBackColor = True
        '
        'lblTotalCaption
        '
        Me.lblTotalCaption.AutoSize = True
        Me.lblTotalCaption.Location = New System.Drawing.Point(12, 53)
        Me.lblTotalCaption.Name = "lblTotalCaption"
        Me.lblTotalCaption.Size = New System.Drawing.Size(34, 13)
        Me.lblTotalCaption.TabIndex = 2
        Me.lblTotalCaption.Text = "Total:"
        '
        'lblTaxCaption
        '
        Me.lblTaxCaption.AutoSize = True
        Me.lblTaxCaption.Location = New System.Drawing.Point(12, 29)
        Me.lblTaxCaption.Name = "lblTaxCaption"
        Me.lblTaxCaption.Size = New System.Drawing.Size(28, 13)
        Me.lblTaxCaption.TabIndex = 1
        Me.lblTaxCaption.Text = "Tax:"
        '
        'lblSubtotalCaption
        '
        Me.lblSubtotalCaption.AutoSize = True
        Me.lblSubtotalCaption.Location = New System.Drawing.Point(12, 16)
        Me.lblSubtotalCaption.Name = "lblSubtotalCaption"
        Me.lblSubtotalCaption.Size = New System.Drawing.Size(49, 13)
        Me.lblSubtotalCaption.TabIndex = 0
        Me.lblSubtotalCaption.Text = "Subtotal:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 508)
        Me.Controls.Add(Me.grpCheckOut)
        Me.Controls.Add(Me.grpCurrentOrder)
        Me.Controls.Add(Me.grpAddProduct)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(353, 542)
        Me.MinimumSize = New System.Drawing.Size(353, 542)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeffrey E. Cheese's @home Order Guide"
        Me.grpAddProduct.ResumeLayout(False)
        Me.grpCurrentOrder.ResumeLayout(False)
        Me.grpCheckOut.ResumeLayout(False)
        Me.grpCheckOut.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpAddProduct As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddSoda As System.Windows.Forms.Button
    Friend WithEvents btnAddSticks As System.Windows.Forms.Button
    Friend WithEvents btnAddPasta As System.Windows.Forms.Button
    Friend WithEvents btnAddPizza As System.Windows.Forms.Button
    Friend WithEvents grpCurrentOrder As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents btnModifyItem As System.Windows.Forms.Button
    Friend WithEvents lstOrder As System.Windows.Forms.ListBox
    Friend WithEvents grpCheckOut As System.Windows.Forms.GroupBox
    Friend WithEvents lblTaxCaption As System.Windows.Forms.Label
    Friend WithEvents lblSubtotalCaption As System.Windows.Forms.Label
    Friend WithEvents btnClearOrder As System.Windows.Forms.Button
    Friend WithEvents btnOrderSubmit As System.Windows.Forms.Button
    Friend WithEvents lblTotalCaption As System.Windows.Forms.Label
    Friend WithEvents lblTotalValue As System.Windows.Forms.Label
    Friend WithEvents lblPercentValue As System.Windows.Forms.Label
    Friend WithEvents lblSubtotalValue As System.Windows.Forms.Label

End Class
