Imports System.Globalization

Public Class Form1
    Private txtstGender As Object

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        MsgBox("Welcome ")
        MsgBox("to")
        MsgBox("the ")
        MsgBox("VB.NET")
        MsgBox("programming")
        MsgBox("course")

        MessageBox.Show("this is another message")
    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String                'st  StringVariable
        Dim stLastName As String

        stFirstName = "Kevin"
        stLastName = "Drumm"

        'MsgBox(stFirstName)

        MsgBox("Hello and Welcome " & stFirstName & " " & stLastName & " I hope you are well")

        stFirstName = "Murvin"
        stLastName = "Drake"

        MsgBox("Hello and Welcome " & stFirstName & " " & stLastName & " I hope you are well")
    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click

        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date


        stMake = "Ford"
        stModel = "escort"
        iDoors = 5
        stColour = "red "
        bTaxed = True
        iEngineSize = 1200
        decPrice = 999.99
        dtDateRegistered = #11/2/2020#

        ' MsgBox("the car is " & stMake & " " & stModel & " " & iDoors & " " & stColour & " " & bTaxed & " " & iEngineSize & " " & decPrice & " " & dtDateRegistered & " ")

        ' MsgBox("the car is " & stMake & vbNewLine & stModel & vbNewLine & iDoors & vbNewLine & stColour & vbNewLine & bTaxed & vbNewLine & iEngineSize & vbNewLine & decPrice & vbNewLine & dtDateRegistered)

        MsgBox("the car is " & stMake & vbNewLine & stModel & vbNewLine &
               iDoors & vbNewLine & stColour & vbNewLine & bTaxed & vbNewLine &
               iEngineSize & vbNewLine & decPrice & vbNewLine & dtDateRegistered)


    End Sub

    Private Sub btnGo1_Click(sender As Object, e As EventArgs) Handles btnGo1.Click

        Dim stFirstName As String

        stFirstName = InputBox("Please enter your first name ")

        MsgBox("Hello " & stFirstName)
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblLastName.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblGender.Click

    End Sub

    Private Sub txtGo2_Click(sender As Object, e As EventArgs) Handles txtGo2.Click
        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccupation As String

        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text
        stOccupation = lstOccupation.SelectedItem

        MsgBox("Hello " & stFirstName & " " & stLastName & " you are " & stGender & "  " & stOccupation & " ")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstOccupation.Items.Add("Writer")
        lstOccupation.Items.Add("Actor")
        lstOccupation.Items.Add("Painter")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim iNumber1 As Integer
        Dim iNumber2 As Integer

        Dim iResult As Integer

        iNumber1 = txtNumber1.Text
        iNumber2 = txtNumber2.Text

        iResult = iNumber1 + iNumber2

        MsgBox(iResult)

        iResult = iNumber1 - iNumber2

        MsgBox(iResult)


        'iResult = iNumber1 * iNumber2

        'MsgBox(iResult)

        'iResult = iNumber1 / iNumber2

        'MsgBox(iResult)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate2.Click

        Dim dblNumber3 As Double
        Dim dblNumber4 As Double

        Dim dblResult As Double

        dblNumber3 = txtNumber3.Text
        dblNumber4 = txtNumber4.Text

        MsgBox(dblNumber3 + dblNumber4)

        dblResult = dblNumber3 - dblNumber4
        MsgBox(dblResult)

        dblResult = dblNumber3 * dblNumber4
        MsgBox(dblResult)

        dblResult = dblNumber3 / dblNumber4
        MsgBox(dblResult)

        dblResult = dblNumber3 ^ dblNumber4
        MsgBox(dblResult)

        dblResult = dblNumber3 Mod dblNumber4
        MsgBox(dblResult)

        dblResult = dblNumber3 \ dblNumber4
        MsgBox(dblResult)
    End Sub

    Private Sub btnCalculate3_Click(sender As Object, e As EventArgs) Handles btnCalculate3.Click

        Dim decPrice As Decimal
        Dim iQuantity As Integer
        Dim decDiscount As Decimal
        Dim decTotalCost As Decimal
        Dim decPostage As Decimal


        decPrice = 5
        iQuantity = 10
        decDiscount = 2
        decPostage = 3

        decTotalCost = (decPrice - decDiscount) * iQuantity + decPostage
        MsgBox(decTotalCost)

        ' BO (DM)(AS) -  Brackets Order Division Multiplication Addition Subtraction
        ' Please excuse my dear aunt sally PE(MD) (AS) - Parentheses Exponentiation Multiplication Addition Subtraction

        Dim iResult As Integer
        iResult = 10 - 5 + 2
        MsgBox(iResult)

        iResult = 10 + 5 - 2
        MsgBox(iResult)

        iResult = 10 - 2 + 5
        MsgBox(iResult)

        iResult = 10 / 5 * 2
        MsgBox(iResult)

        iResult = 2 * 10 / 5
        MsgBox(iResult)

        iResult = 10 * 5 / 2
        MsgBox(iResult)
    End Sub

    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click

        Dim stCountry As String
        stCountry = txtCountry.Text

        If stCountry.ToUpper = "AUSTRALIA" Then
            MsgBox("G'day mate")
            MsgBox("Good on ya")
            MsgBox("No worries")

        ElseIf stCountry.ToUpper = "FRANCE" Then
            MsgBox("Bonjour")
            MsgBox("Comment allez- vous?")

        ElseIf stCountry.ToUpper = "JAPAN" Then
            MsgBox("Konnichiwa")
            MsgBox("Choushi wa dou desu ka")

        Else
            MsgBox("Hello there")
            MsgBox("I hope you are well")
        End If

        MsgBox("You entered " & stCountry)
    End Sub

    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click

        Dim iScore As Integer
        iScore = txtExamScore.Text

        If iScore < 0 Or iScore > 100 Then
            MsgBox("That is not a valid score. Enter a member between 0 and 100")
            Exit Sub
        End If

        If iScore >= 50 Then
            MsgBox("Pass")
        End If

        If iScore < 50 Then
            MsgBox("Fail")
        End If

        MsgBox("all done")
    End Sub
End Class
