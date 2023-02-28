Public Class frmPayroll
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblIncome.Click

    End Sub

    Private Sub btnTaxCalc_Click(sender As Object, e As EventArgs) Handles btnTaxCalc.Click
        ' Step 1: Create variables
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal

        ' Step 2: Create constants and initialize them
        Const cdecFica As Decimal = 0.0765D
        Const cdecFed As Decimal = 0.22D
        Const cdecState As Decimal = 0.04D

        ' Step 3: Convert strIncome to decIncome
        strIncome = txtIncome.Text
        decIncome = Decimal.Parse(strIncome)

        ' Step 4: Calculate tax amounts
        decFica = decIncome * cdecFica
        decFederal = decIncome * cdecFed
        decState = decIncome * cdecState

        ' Step 5: Calculate net income
        decNet = decIncome - (decFica + decFederal + decState)

        ' Step 6: Display results on the form
        lblFica.Text = decFica.ToString("C")
        lblFederal.Text = decFederal.ToString("C")
        lblState.Text = decState.ToString("C")
        lblNetIncome.Text = decNet.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFica.Text = ""
        lblFederal.Text = ""
        lblState.Text = ""
        lblNetIncome.Text = ""
        txtIncome.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFica.Text = ""
        lblFederal.Text = ""
        lblState.Text = ""
        lblNetIncome.Text = ""
        txtIncome.Text = ""

    End Sub

    Private Sub txtIncome_TextChanged(sender As Object, e As EventArgs) Handles txtIncome.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
