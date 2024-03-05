<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckout
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
        Me.grpPayment = New System.Windows.Forms.GroupBox
        Me.lblInfoTele = New System.Windows.Forms.Label
        Me.lblInfoExp = New System.Windows.Forms.Label
        Me.lblInfoNumber = New System.Windows.Forms.Label
        Me.lblInfoName = New System.Windows.Forms.Label
        Me.txtTele = New System.Windows.Forms.TextBox
        Me.txtExp = New System.Windows.Forms.TextBox
        Me.txtCredit = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.grpPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.lblInfoTele)
        Me.grpPayment.Controls.Add(Me.lblInfoExp)
        Me.grpPayment.Controls.Add(Me.lblInfoNumber)
        Me.grpPayment.Controls.Add(Me.lblInfoName)
        Me.grpPayment.Controls.Add(Me.txtTele)
        Me.grpPayment.Controls.Add(Me.txtExp)
        Me.grpPayment.Controls.Add(Me.txtCredit)
        Me.grpPayment.Controls.Add(Me.txtName)
        Me.grpPayment.Location = New System.Drawing.Point(11, 12)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(269, 186)
        Me.grpPayment.TabIndex = 0
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Payment Information"
        '
        'lblInfoTele
        '
        Me.lblInfoTele.AutoSize = True
        Me.lblInfoTele.Location = New System.Drawing.Point(9, 136)
        Me.lblInfoTele.Name = "lblInfoTele"
        Me.lblInfoTele.Size = New System.Drawing.Size(98, 13)
        Me.lblInfoTele.TabIndex = 7
        Me.lblInfoTele.Text = "Telephone Number"
        '
        'lblInfoExp
        '
        Me.lblInfoExp.AutoSize = True
        Me.lblInfoExp.Location = New System.Drawing.Point(9, 98)
        Me.lblInfoExp.Name = "lblInfoExp"
        Me.lblInfoExp.Size = New System.Drawing.Size(79, 13)
        Me.lblInfoExp.TabIndex = 6
        Me.lblInfoExp.Text = "Expiration Date"
        '
        'lblInfoNumber
        '
        Me.lblInfoNumber.AutoSize = True
        Me.lblInfoNumber.Location = New System.Drawing.Point(9, 60)
        Me.lblInfoNumber.Name = "lblInfoNumber"
        Me.lblInfoNumber.Size = New System.Drawing.Size(99, 13)
        Me.lblInfoNumber.TabIndex = 5
        Me.lblInfoNumber.Text = "Credit Card Number"
        '
        'lblInfoName
        '
        Me.lblInfoName.AutoSize = True
        Me.lblInfoName.Location = New System.Drawing.Point(9, 21)
        Me.lblInfoName.Name = "lblInfoName"
        Me.lblInfoName.Size = New System.Drawing.Size(105, 13)
        Me.lblInfoName.TabIndex = 4
        Me.lblInfoName.Text = "Name on Credit Card"
        '
        'txtTele
        '
        Me.txtTele.Location = New System.Drawing.Point(45, 152)
        Me.txtTele.Name = "txtTele"
        Me.txtTele.Size = New System.Drawing.Size(213, 20)
        Me.txtTele.TabIndex = 3
        '
        'txtExp
        '
        Me.txtExp.Location = New System.Drawing.Point(207, 110)
        Me.txtExp.Name = "txtExp"
        Me.txtExp.Size = New System.Drawing.Size(51, 20)
        Me.txtExp.TabIndex = 2
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(45, 75)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(212, 20)
        Me.txtCredit.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(45, 37)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(213, 20)
        Me.txtName.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(11, 205)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 27)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(187, 204)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(93, 28)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 240)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.grpPayment)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 274)
        Me.MinimumSize = New System.Drawing.Size(300, 274)
        Me.Name = "frmCheckout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Checkout"
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpPayment As System.Windows.Forms.GroupBox
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblInfoTele As System.Windows.Forms.Label
    Friend WithEvents lblInfoExp As System.Windows.Forms.Label
    Friend WithEvents lblInfoNumber As System.Windows.Forms.Label
    Friend WithEvents lblInfoName As System.Windows.Forms.Label
    Friend WithEvents txtTele As System.Windows.Forms.TextBox
    Friend WithEvents txtExp As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
End Class
