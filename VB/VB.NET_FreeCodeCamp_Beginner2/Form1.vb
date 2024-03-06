Public Class Form1
    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        Dim iScore As Integer

        If IsNumeric(txtExamScore.Text) Then
            iScore = CInt(txtExamScore.Text)
        Else
            MsgBox("You must enter a number")
            Exit Sub
        End If

        If iScore < 0 Or iScore > 100 Then
            MsgBox("That is not a valid score. Enter a number  ")
            Exit Sub
        End If

        If iScore >= 50 Then MsgBox("Pass")
        If iScore < 50 Then MsgBox("Fail")
        MsgBox("All Done")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGrade1.Click
        Dim iScore As Integer

        If IsNumeric(txtExamScore1.Text) Then
            iScore = CInt(txtExamScore1.Text)
        Else
            MsgBox("You must enter a number")
            Exit Sub
        End If

        If Not (iScore > 0 And iScore <= 100) Then
            MsgBox("That is not a valid score. Enter a number  ")
        ElseIf iScore <= 20 Then
            MsgBox("Grade F")
        ElseIf iScore > 20 And iScore <= 30 Then
            MsgBox("Grade E")
        ElseIf iScore > 30 And iScore <= 40 Then
            MsgBox("Grade D")
        ElseIf iScore > 40 And iScore <= 50 Then
            MsgBox("Grade C")
        ElseIf iScore > 50 And iScore <= 70 Then
            MsgBox("Grade B")
        Else
            MsgBox("Grade A")
        End If

        MsgBox("All Done")
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim iTemperature As Integer
        iTemperature = CInt(txtTemperature.Text)

        Select Case iTemperature
            Case Is = 0
                MsgBox("Freezing")
                MsgBox("Water will freeze")
                MsgBox("and you can go skating")
            Case Is < 0
                MsgBox("Sub Zero")
            Case 1 To 10
                MsgBox("Cold")
            Case 11 To 20
                MsgBox("Warm")
            Case Else
                MsgBox("Hot")
        End Select

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim iCount As Integer

        For iCount = 1 To 5
            Beep()
            Threading.Thread.Sleep(3000)
            MsgBox("Hello " & iCount)
            MsgBox("How are you")
            MsgBox("Well I hope")
        Next
    End Sub

    Private Sub btnGo1_Click(sender As Object, e As EventArgs) Handles btnGo1.Click
        Dim iCount As Integer

        'For iCount = 0 To 50 Step 5
        For iCount = 50 To 0 Step -5
            MsgBox(iCount)
        Next
    End Sub

    Private Sub btnGo2_Click(sender As Object, e As EventArgs) Handles btnGo2.Click
        Dim iCount As Integer
        Dim stOut As String

        For iCount = 50 To 0 Step -5
            stOut += iCount & vbNewLine
        Next

        MsgBox(stOut)
    End Sub

    Private Sub btnCountUpTask_Click(sender As Object, e As EventArgs) Handles btnCountUpTask.Click
        Dim iMax As Integer
        Dim stOddOrEven As String
        Dim x As Integer

        iMax = InputBox("What number do you want to count up to?")
        stOddOrEven = InputBox("Do you want odd numbers or even numbers?")

        'If stOddOrEven = "even" Then
        'For x = 0 To iMax Step 2
        'MsgBox(x)
        'Next
        'ElseIf stOddOrEven = "odd" Then
        'For x = 1 To iMax Step 2
        'MsgBox(x)
        'Next
        '  End If

        If stOddOrEven = "even" Then
            For x = 0 To iMax Step 2
                MsgBox(x)
            Next
        End If

        If stOddOrEven = "odd" Then
            For x = 1 To iMax Step 2
                MsgBox(x)
            Next
        End If


    End Sub

    Private Sub btnGo3_Click(sender As Object, e As EventArgs) Handles btnGo3.Click
        Dim iCount As Integer

        iCount = 0
        Do While iCount < 5
            iCount = iCount + 1
            MsgBox("Hello " & iCount)
        Loop

        iCount = 0
        Do
            iCount = iCount + 1
            MsgBox("Hello " & iCount)
        Loop While iCount < 5

        iCount = 0
        Do Until iCount = 5
            iCount = iCount + 1
            MsgBox("Hello " & iCount)
        Loop

        iCount = 0
        Do
            iCount = iCount + 1
            MsgBox("Hello " & iCount)
        Loop Until iCount = 5

        MsgBox("All Done")

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim stName As String

        Do While stName <> "Kevin"

            'Do While True = True   
            'Do While True

            stName = InputBox("Please enter your name")

            'If stName = "Kevin" Then
            'Exit Do
            'End If

        Loop

        MsgBox("Hello " & stName)
    End Sub

    Private Sub BtnStart1_Click(sender As Object, e As EventArgs) Handles BtnStart1.Click
        Dim stAge As String
        Dim iAge As Integer

        Do While IsNumeric(stAge) = False  '<> True
            ' Do While Not IsNumeric (stAge)  
            stAge = InputBox("Please enter your age in years")
        Loop

        iAge = CInt(stAge)


        MsgBox("Hello you are " & iAge)

    End Sub

    Private Sub btnExercise1_Click(sender As Object, e As EventArgs) Handles btnExercise1.Click
        'Output each item in a separate message box one after another
        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer

        For i = 0 To 4
            MsgBox(aiData(i))
        Next
    End Sub

    Private Sub btnExercise2_Click(sender As Object, e As EventArgs) Handles btnExercise2.Click
        'Output all of the items in the same message box on separate lines

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim stOut As String

        For i = 0 To 4
            stOut = stOut & aiData(i) & vbNewLine
        Next

        MsgBox(stOut)
    End Sub

    Private Sub btnExercise3_Click(sender As Object, e As EventArgs) Handles btnExercise3.Click
        ' Add up all of the items then output the total in a message box

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iTotal As Integer

        For i = 0 To 4
            iTotal = iTotal + aiData(i)
        Next

        MsgBox("The Total is " & iTotal)

    End Sub

    Private Sub btnExercise4_Click(sender As Object, e As EventArgs) Handles btnExercise4.Click
        'Calculate the average of the items then output it in a message box

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iTotal As Integer

        For i = 0 To 4
            iTotal = iTotal + aiData(i)
        Next

        MsgBox("The average is " & iTotal / 5)

    End Sub

    Private Sub btnExercise5_Click(sender As Object, e As EventArgs) Handles btnExercise5.Click
        'Add up the items greater than 20 then output the result in a message box

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iTotal As Integer

        For i = 0 To 4
            If aiData(i) > 20 Then
                iTotal = iTotal + aiData(i)
            End If
        Next

        MsgBox("The total of the items bigger than 20 is " & iTotal)
    End Sub

    Private Sub btnExercise6_Click(sender As Object, e As EventArgs) Handles btnExercise6.Click
        'Find the largest item then output it in a message box

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iMax As Integer

        iMax = 0

        For i = 0 To 4
            If aiData(i) > iMax Then
                iMax = aiData(i)
            End If
        Next
        MsgBox("The largest item is " & iMax)
    End Sub

    Private Sub btnExercise7_Click(sender As Object, e As EventArgs) Handles btnExercise7.Click
        'Find the smallest item then output it in a message box
        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iMin As Integer

        iMin = 10000

        For i = 0 To 4
            If aiData(i) < iMin Then
                iMin = aiData(i)
            End If
        Next

        MsgBox("The smallest item is " & iMin)
    End Sub

    Private Sub btnExercise8_Click(sender As Object, e As EventArgs) Handles btnExercise8.Click
        'Replace each item in the array with a new value which is twice as big then output the new values
        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer

        For i = 0 To 4
            aiData(i) = aiData(i) * 2
        Next

        Dim stOut As String
        For i = 0 To 4

            stOut = stOut & aiData(i) & vbNewLine

        Next
        MsgBox(stOut)
    End Sub

    Private Sub btnLinearSearch_Click(sender As Object, e As EventArgs) Handles btnLinearSearch.Click
        Dim stTarget As String
        Dim astFruit(9) As String
        Dim bFound As Boolean



        astFruit(0) = "Apple"
        astFruit(1) = "Mango"
        astFruit(2) = "Strawberry"
        astFruit(3) = "Banana"
        astFruit(4) = "Tomato"
        astFruit(5) = "Grape"
        astFruit(6) = "Pear"
        astFruit(7) = "Lemon"
        astFruit(8) = "Melon"
        astFruit(9) = "Fig"

        stTarget = InputBox("Which fruit are you looking for?")

        Dim i As Integer
        For i = 0 To 9
            If astFruit(i).ToUpper = stTarget.ToUpper Then
                bFound = True
                Exit For
            End If

        Next
        If bFound = True Then
            MsgBox("Found it")
        Else
            MsgBox("Not this one")
        End If


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn2DArray.Click
        Dim astPeople(4, 5) As String
        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Einstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahatma"
        astPeople(1, 4) = "Gandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "Lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "Van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        ' MsgBox(astPeople(3, 3))

        Dim x As Integer
        Dim y As Integer

        For x = 0 To 4
            MsgBox(astPeople(x, 4))
        Next

        ' x = 3
        ' y = 2

        ' MsgBox(astPeople(x, y))



    End Sub

    Private Sub btnRowWise_Click(sender As Object, e As EventArgs) Handles btnRowWise.Click
        Dim astPeople(4, 5) As String
        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Einstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahatma"
        astPeople(1, 4) = "Gandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "Lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "Van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"


        Dim x As Integer
        Dim y As Integer

        For y = 0 To 5
            For x = 0 To 4
                MsgBox(astPeople(x, y))
            Next
        Next

    End Sub

    Private Sub btnColumnWise_Click(sender As Object, e As EventArgs) Handles btnColumnWise.Click
        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Einstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahatma"
        astPeople(1, 4) = "Gandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "Lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "Van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"


        Dim x As Integer
        Dim y As Integer

        For x = 0 To 4
            For y = 0 To 5
                MsgBox(astPeople(x, y))
            Next
        Next

    End Sub

    Private Sub btnAllOnce_Click(sender As Object, e As EventArgs) Handles btnAllOnce.Click
        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Einstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahatma"
        astPeople(1, 4) = "Gandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "Lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "Van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"


        Dim x As Integer
        Dim y As Integer
        Dim stOut As String

        For y = 0 To 5
            For x = 0 To 4
                stOut = stOut & astPeople(x, y) & " "
            Next
            stOut = stOut & vbNewLine
        Next

        MsgBox(stOut)
    End Sub

    Private Sub btnPerson_Click(sender As Object, e As EventArgs) Handles btnPerson.Click
        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Einstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahatma"
        astPeople(1, 4) = "Gandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "Lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "Van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"


        Dim x As Integer
        Dim y As Integer
        Dim bFound As Boolean
        Dim stTarget As String
        Dim stOut As String


        bFound = False

        stTarget = InputBox("Enter the surname of the person you want to find ")

        For y = 0 To 5
            If astPeople(1, y) = stTarget Then
                bFound = True
                Exit For
            End If
        Next

        If bFound = True Then
            For x = 0 To 4
                stOut = stOut & astPeople(x, y) & " "
            Next
        Else
            stOut = "Not Found"
        End If

        MsgBox(stOut)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
