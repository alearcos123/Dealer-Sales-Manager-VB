<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumberSold = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFullTimeSales = New System.Windows.Forms.Label()
        Me.lblPartTimeSales = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNewSales = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblUsedSales = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&ID:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(18, 41)
        Me.txtID.MaxLength = 5
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 31)
        Me.txtID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Number sold:"
        '
        'txtNumberSold
        '
        Me.txtNumberSold.Location = New System.Drawing.Point(132, 41)
        Me.txtNumberSold.Name = "txtNumberSold"
        Me.txtNumberSold.Size = New System.Drawing.Size(54, 31)
        Me.txtNumberSold.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(254, 22)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(81, 33)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(254, 61)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 33)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblUsedSales)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblNewSales)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblPartTimeSales)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblFullTimeSales)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 140)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cars sold by"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Full-time employees:"
        '
        'lblFullTimeSales
        '
        Me.lblFullTimeSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullTimeSales.Location = New System.Drawing.Point(128, 38)
        Me.lblFullTimeSales.Name = "lblFullTimeSales"
        Me.lblFullTimeSales.Size = New System.Drawing.Size(57, 20)
        Me.lblFullTimeSales.TabIndex = 1
        Me.lblFullTimeSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPartTimeSales
        '
        Me.lblPartTimeSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPartTimeSales.Location = New System.Drawing.Point(128, 63)
        Me.lblPartTimeSales.Name = "lblPartTimeSales"
        Me.lblPartTimeSales.Size = New System.Drawing.Size(57, 20)
        Me.lblPartTimeSales.TabIndex = 3
        Me.lblPartTimeSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Part-time employees:"
        '
        'lblNewSales
        '
        Me.lblNewSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNewSales.Location = New System.Drawing.Point(128, 88)
        Me.lblNewSales.Name = "lblNewSales"
        Me.lblNewSales.Size = New System.Drawing.Size(57, 20)
        Me.lblNewSales.TabIndex = 5
        Me.lblNewSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "New car employees:"
        '
        'lblUsedSales
        '
        Me.lblUsedSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUsedSales.Location = New System.Drawing.Point(128, 113)
        Me.lblUsedSales.Name = "lblUsedSales"
        Me.lblUsedSales.Size = New System.Drawing.Size(57, 20)
        Me.lblUsedSales.TabIndex = 7
        Me.lblUsedSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Used car employees:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(277, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Alejandro Arcos"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 305)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNumberSold)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rembrandt Auto-Mart"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumberSold As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFullTimeSales As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNewSales As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPartTimeSales As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblUsedSales As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
End Class
