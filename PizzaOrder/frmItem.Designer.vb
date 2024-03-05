<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItem
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
        Me.grpItemType = New System.Windows.Forms.GroupBox
        Me.optItemF = New System.Windows.Forms.RadioButton
        Me.optItemE = New System.Windows.Forms.RadioButton
        Me.optItemD = New System.Windows.Forms.RadioButton
        Me.optItemC = New System.Windows.Forms.RadioButton
        Me.optItemB = New System.Windows.Forms.RadioButton
        Me.optItemA = New System.Windows.Forms.RadioButton
        Me.grpItemSize = New System.Windows.Forms.GroupBox
        Me.optItemSizeF = New System.Windows.Forms.RadioButton
        Me.optItemSizeE = New System.Windows.Forms.RadioButton
        Me.optItemSizeD = New System.Windows.Forms.RadioButton
        Me.optItemSizeC = New System.Windows.Forms.RadioButton
        Me.optItemSizeB = New System.Windows.Forms.RadioButton
        Me.optItemSizeA = New System.Windows.Forms.RadioButton
        Me.grpItemOptions = New System.Windows.Forms.GroupBox
        Me.btnRemoveObject = New System.Windows.Forms.Button
        Me.btnAddObject = New System.Windows.Forms.Button
        Me.cboItems = New System.Windows.Forms.ComboBox
        Me.lstObjects = New System.Windows.Forms.ListBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.grpItemType.SuspendLayout()
        Me.grpItemSize.SuspendLayout()
        Me.grpItemOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpItemType
        '
        Me.grpItemType.Controls.Add(Me.optItemF)
        Me.grpItemType.Controls.Add(Me.optItemE)
        Me.grpItemType.Controls.Add(Me.optItemD)
        Me.grpItemType.Controls.Add(Me.optItemC)
        Me.grpItemType.Controls.Add(Me.optItemB)
        Me.grpItemType.Controls.Add(Me.optItemA)
        Me.grpItemType.Location = New System.Drawing.Point(12, 12)
        Me.grpItemType.Name = "grpItemType"
        Me.grpItemType.Size = New System.Drawing.Size(271, 90)
        Me.grpItemType.TabIndex = 0
        Me.grpItemType.TabStop = False
        Me.grpItemType.Text = "Item Type"
        '
        'optItemF
        '
        Me.optItemF.AutoSize = True
        Me.optItemF.Location = New System.Drawing.Point(170, 64)
        Me.optItemF.Name = "optItemF"
        Me.optItemF.Size = New System.Drawing.Size(90, 17)
        Me.optItemF.TabIndex = 5
        Me.optItemF.TabStop = True
        Me.optItemF.Text = "RadioButton1"
        Me.optItemF.UseVisualStyleBackColor = True
        '
        'optItemE
        '
        Me.optItemE.AutoSize = True
        Me.optItemE.Location = New System.Drawing.Point(170, 42)
        Me.optItemE.Name = "optItemE"
        Me.optItemE.Size = New System.Drawing.Size(90, 17)
        Me.optItemE.TabIndex = 4
        Me.optItemE.TabStop = True
        Me.optItemE.Text = "RadioButton1"
        Me.optItemE.UseVisualStyleBackColor = True
        '
        'optItemD
        '
        Me.optItemD.AutoSize = True
        Me.optItemD.Location = New System.Drawing.Point(170, 19)
        Me.optItemD.Name = "optItemD"
        Me.optItemD.Size = New System.Drawing.Size(90, 17)
        Me.optItemD.TabIndex = 3
        Me.optItemD.TabStop = True
        Me.optItemD.Text = "RadioButton1"
        Me.optItemD.UseVisualStyleBackColor = True
        '
        'optItemC
        '
        Me.optItemC.AutoSize = True
        Me.optItemC.Location = New System.Drawing.Point(18, 65)
        Me.optItemC.Name = "optItemC"
        Me.optItemC.Size = New System.Drawing.Size(90, 17)
        Me.optItemC.TabIndex = 2
        Me.optItemC.TabStop = True
        Me.optItemC.Text = "RadioButton1"
        Me.optItemC.UseVisualStyleBackColor = True
        '
        'optItemB
        '
        Me.optItemB.AutoSize = True
        Me.optItemB.Location = New System.Drawing.Point(18, 42)
        Me.optItemB.Name = "optItemB"
        Me.optItemB.Size = New System.Drawing.Size(90, 17)
        Me.optItemB.TabIndex = 1
        Me.optItemB.TabStop = True
        Me.optItemB.Text = "RadioButton1"
        Me.optItemB.UseVisualStyleBackColor = True
        '
        'optItemA
        '
        Me.optItemA.AutoSize = True
        Me.optItemA.Location = New System.Drawing.Point(18, 19)
        Me.optItemA.Name = "optItemA"
        Me.optItemA.Size = New System.Drawing.Size(90, 17)
        Me.optItemA.TabIndex = 0
        Me.optItemA.TabStop = True
        Me.optItemA.Text = "RadioButton1"
        Me.optItemA.UseVisualStyleBackColor = True
        '
        'grpItemSize
        '
        Me.grpItemSize.Controls.Add(Me.optItemSizeF)
        Me.grpItemSize.Controls.Add(Me.optItemSizeE)
        Me.grpItemSize.Controls.Add(Me.optItemSizeD)
        Me.grpItemSize.Controls.Add(Me.optItemSizeC)
        Me.grpItemSize.Controls.Add(Me.optItemSizeB)
        Me.grpItemSize.Controls.Add(Me.optItemSizeA)
        Me.grpItemSize.Location = New System.Drawing.Point(12, 108)
        Me.grpItemSize.Name = "grpItemSize"
        Me.grpItemSize.Size = New System.Drawing.Size(271, 87)
        Me.grpItemSize.TabIndex = 1
        Me.grpItemSize.TabStop = False
        Me.grpItemSize.Text = "Item Size"
        '
        'optItemSizeF
        '
        Me.optItemSizeF.AutoSize = True
        Me.optItemSizeF.Location = New System.Drawing.Point(169, 64)
        Me.optItemSizeF.Name = "optItemSizeF"
        Me.optItemSizeF.Size = New System.Drawing.Size(90, 17)
        Me.optItemSizeF.TabIndex = 6
        Me.optItemSizeF.TabStop = True
        Me.optItemSizeF.Text = "RadioButton1"
        Me.optItemSizeF.UseVisualStyleBackColor = True
        '
        'optItemSizeE
        '
        Me.optItemSizeE.AutoSize = True
        Me.optItemSizeE.Location = New System.Drawing.Point(169, 42)
        Me.optItemSizeE.Name = "optItemSizeE"
        Me.optItemSizeE.Size = New System.Drawing.Size(90, 17)
        Me.optItemSizeE.TabIndex = 5
        Me.optItemSizeE.TabStop = True
        Me.optItemSizeE.Text = "RadioButton1"
        Me.optItemSizeE.UseVisualStyleBackColor = True
        '
        'optItemSizeD
        '
        Me.optItemSizeD.AutoSize = True
        Me.optItemSizeD.Location = New System.Drawing.Point(170, 19)
        Me.optItemSizeD.Name = "optItemSizeD"
        Me.optItemSizeD.Size = New System.Drawing.Size(90, 17)
        Me.optItemSizeD.TabIndex = 4
        Me.optItemSizeD.TabStop = True
        Me.optItemSizeD.Text = "RadioButton1"
        Me.optItemSizeD.UseVisualStyleBackColor = True
        '
        'optItemSizeC
        '
        Me.optItemSizeC.AutoSize = True
        Me.optItemSizeC.Location = New System.Drawing.Point(18, 64)
        Me.optItemSizeC.Name = "optItemSizeC"
        Me.optItemSizeC.Size = New System.Drawing.Size(90, 17)
        Me.optItemSizeC.TabIndex = 3
        Me.optItemSizeC.TabStop = True
        Me.optItemSizeC.Text = "RadioButton1"
        Me.optItemSizeC.UseVisualStyleBackColor = True
        '
        'optItemSizeB
        '
        Me.optItemSizeB.AutoSize = True
        Me.optItemSizeB.Location = New System.Drawing.Point(18, 42)
        Me.optItemSizeB.Name = "optItemSizeB"
        Me.optItemSizeB.Size = New System.Drawing.Size(90, 17)
        Me.optItemSizeB.TabIndex = 1
        Me.optItemSizeB.TabStop = True
        Me.optItemSizeB.Text = "RadioButton1"
        Me.optItemSizeB.UseVisualStyleBackColor = True
        '
        'optItemSizeA
        '
        Me.optItemSizeA.AutoSize = True
        Me.optItemSizeA.Location = New System.Drawing.Point(18, 19)
        Me.optItemSizeA.Name = "optItemSizeA"
        Me.optItemSizeA.Size = New System.Drawing.Size(90, 17)
        Me.optItemSizeA.TabIndex = 0
        Me.optItemSizeA.TabStop = True
        Me.optItemSizeA.Text = "RadioButton1"
        Me.optItemSizeA.UseVisualStyleBackColor = True
        '
        'grpItemOptions
        '
        Me.grpItemOptions.Controls.Add(Me.btnRemoveObject)
        Me.grpItemOptions.Controls.Add(Me.btnAddObject)
        Me.grpItemOptions.Controls.Add(Me.cboItems)
        Me.grpItemOptions.Controls.Add(Me.lstObjects)
        Me.grpItemOptions.Location = New System.Drawing.Point(12, 201)
        Me.grpItemOptions.Name = "grpItemOptions"
        Me.grpItemOptions.Size = New System.Drawing.Size(271, 147)
        Me.grpItemOptions.TabIndex = 2
        Me.grpItemOptions.TabStop = False
        Me.grpItemOptions.Text = "Item Objects"
        '
        'btnRemoveObject
        '
        Me.btnRemoveObject.Enabled = False
        Me.btnRemoveObject.Location = New System.Drawing.Point(127, 120)
        Me.btnRemoveObject.Name = "btnRemoveObject"
        Me.btnRemoveObject.Size = New System.Drawing.Size(132, 19)
        Me.btnRemoveObject.TabIndex = 3
        Me.btnRemoveObject.Text = "Remove Selected"
        Me.btnRemoveObject.UseVisualStyleBackColor = True
        '
        'btnAddObject
        '
        Me.btnAddObject.Location = New System.Drawing.Point(170, 19)
        Me.btnAddObject.Name = "btnAddObject"
        Me.btnAddObject.Size = New System.Drawing.Size(89, 19)
        Me.btnAddObject.TabIndex = 2
        Me.btnAddObject.Text = "Add..."
        Me.btnAddObject.UseVisualStyleBackColor = True
        '
        'cboItems
        '
        Me.cboItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItems.FormattingEnabled = True
        Me.cboItems.Location = New System.Drawing.Point(18, 18)
        Me.cboItems.Name = "cboItems"
        Me.cboItems.Size = New System.Drawing.Size(143, 21)
        Me.cboItems.TabIndex = 1
        '
        'lstObjects
        '
        Me.lstObjects.FormattingEnabled = True
        Me.lstObjects.Location = New System.Drawing.Point(18, 45)
        Me.lstObjects.Name = "lstObjects"
        Me.lstObjects.Size = New System.Drawing.Size(242, 69)
        Me.lstObjects.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(171, 354)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(112, 32)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 354)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 32)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(293, 393)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpItemOptions)
        Me.Controls.Add(Me.grpItemSize)
        Me.Controls.Add(Me.grpItemType)
        Me.Name = "frmItem"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmItem"
        Me.grpItemType.ResumeLayout(False)
        Me.grpItemType.PerformLayout()
        Me.grpItemSize.ResumeLayout(False)
        Me.grpItemSize.PerformLayout()
        Me.grpItemOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpItemType As System.Windows.Forms.GroupBox
    Friend WithEvents optItemF As System.Windows.Forms.RadioButton
    Friend WithEvents optItemE As System.Windows.Forms.RadioButton
    Friend WithEvents optItemD As System.Windows.Forms.RadioButton
    Friend WithEvents optItemC As System.Windows.Forms.RadioButton
    Friend WithEvents optItemB As System.Windows.Forms.RadioButton
    Friend WithEvents optItemA As System.Windows.Forms.RadioButton
    Friend WithEvents grpItemSize As System.Windows.Forms.GroupBox
    Friend WithEvents optItemSizeD As System.Windows.Forms.RadioButton
    Friend WithEvents optItemSizeC As System.Windows.Forms.RadioButton
    Friend WithEvents optItemSizeB As System.Windows.Forms.RadioButton
    Friend WithEvents optItemSizeA As System.Windows.Forms.RadioButton
    Friend WithEvents grpItemOptions As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemoveObject As System.Windows.Forms.Button
    Friend WithEvents btnAddObject As System.Windows.Forms.Button
    Friend WithEvents cboItems As System.Windows.Forms.ComboBox
    Friend WithEvents lstObjects As System.Windows.Forms.ListBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents optItemSizeF As System.Windows.Forms.RadioButton
    Friend WithEvents optItemSizeE As System.Windows.Forms.RadioButton
End Class
