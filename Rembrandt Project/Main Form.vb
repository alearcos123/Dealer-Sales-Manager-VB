' Name:         Rembrandt Project
' Purpose:      Calculate the car sales per category
' Programmer:   Alejandro Arcos on 3/29/2018


Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    'class level variables to store the total sales per category
    Dim intFullTimeSales As Integer
    Dim intPartTimeSales As Integer
    Dim intNewCarsSales As Integer
    Dim intUsedCarsSales As Integer

    Private Sub AssignSales(strId As String, intSales As Integer)
        'verify if is New or Used cars
        Select Case strId.Substring(3, 1)
            Case "N"
                intNewCarsSales += intSales
            Case Else
                intUsedCarsSales += intSales
        End Select

        'verify if is full time or part time employee
        Select Case strId.Substring(4, 1)
            Case "F"
                intFullTimeSales += intSales
            Case Else
                intPartTimeSales += intSales
        End Select


    End Sub


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strId As String
        Dim intNoSold As Integer

        'read and save the user input
        strId = txtID.Text.ToUpper
        Integer.TryParse(txtNumberSold.Text, intNoSold)

        'verify Id is in the correct format
        If strId Like "###[NU][FP]" Then
            'calculate sales per category
            AssignSales(strId, intNoSold)
            'display sales
            lblFullTimeSales.Text = intFullTimeSales.ToString("n0")
            lblPartTimeSales.Text = intPartTimeSales.ToString("n0")
            lblNewSales.Text = intNewCarsSales.ToString("n0")
            lblUsedSales.Text = intUsedCarsSales.ToString("n0")

        Else
            'incorrect id entered, show message error
            MessageBox.Show("Make sure you enter the correct format ID.", "Rembrandt Auto-Mart", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'send the focus to the ID
        txtID.SelectAll()
        txtID.Focus()

    End Sub

    Private Sub txtNumberSold_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumberSold.KeyPress
        'text box will allow only numbers
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub EmptyResults(sender As Object, e As EventArgs) Handles txtID.TextChanged, txtNumberSold.TextChanged
        'clear labels
        lblFullTimeSales.Text = String.Empty
        lblPartTimeSales.Text = String.Empty
        lblNewSales.Text = String.Empty
        lblUsedSales.Text = String.Empty

    End Sub

    Private Sub txtNumberSold_Enter(sender As Object, e As EventArgs) Handles txtNumberSold.Enter
        txtNumberSold.SelectAll()
    End Sub

    Private Sub txtID_Enter(sender As Object, e As EventArgs) Handles txtID.Enter
        'txtID.SelectAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you want to exit?", "Rembrandt Auto-Mart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
