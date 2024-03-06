<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnVariables = New System.Windows.Forms.Button()
        Me.btnDataTypes = New System.Windows.Forms.Button()
        Me.btnGo1 = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtGo2 = New System.Windows.Forms.Button()
        Me.lstOccupation = New System.Windows.Forms.ListBox()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnCalculate2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumber4 = New System.Windows.Forms.TextBox()
        Me.txtNumber3 = New System.Windows.Forms.TextBox()
        Me.btnCalculate3 = New System.Windows.Forms.Button()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.btnGreet = New System.Windows.Forms.Button()
        Me.lblExamScore = New System.Windows.Forms.Label()
        Me.txtExamScore = New System.Windows.Forms.TextBox()
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(55, 44)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(71, 52)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnVariables
        '
        Me.btnVariables.Location = New System.Drawing.Point(180, 44)
        Me.btnVariables.Name = "btnVariables"
        Me.btnVariables.Size = New System.Drawing.Size(71, 52)
        Me.btnVariables.TabIndex = 1
        Me.btnVariables.Text = "Variables"
        Me.btnVariables.UseVisualStyleBackColor = True
        '
        'btnDataTypes
        '
        Me.btnDataTypes.Location = New System.Drawing.Point(305, 44)
        Me.btnDataTypes.Name = "btnDataTypes"
        Me.btnDataTypes.Size = New System.Drawing.Size(71, 52)
        Me.btnDataTypes.TabIndex = 2
        Me.btnDataTypes.Text = "Data Types"
        Me.btnDataTypes.UseVisualStyleBackColor = True
        '
        'btnGo1
        '
        Me.btnGo1.Location = New System.Drawing.Point(306, 132)
        Me.btnGo1.Name = "btnGo1"
        Me.btnGo1.Size = New System.Drawing.Size(71, 52)
        Me.btnGo1.TabIndex = 3
        Me.btnGo1.Text = "Go"
        Me.btnGo1.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(137, 216)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(61, 20)
        Me.txtFirstName.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(54, 223)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(137, 260)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(61, 20)
        Me.txtLastName.TabIndex = 6
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(137, 305)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(61, 20)
        Me.txtGender.TabIndex = 7
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(54, 265)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 8
        Me.lblLastName.Text = "Last Name"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(54, 310)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 9
        Me.lblGender.Text = "Gender"
        '
        'txtGo2
        '
        Me.txtGo2.Location = New System.Drawing.Point(297, 245)
        Me.txtGo2.Name = "txtGo2"
        Me.txtGo2.Size = New System.Drawing.Size(80, 52)
        Me.txtGo2.TabIndex = 10
        Me.txtGo2.Text = "Go"
        Me.txtGo2.UseVisualStyleBackColor = True
        '
        'lstOccupation
        '
        Me.lstOccupation.FormattingEnabled = True
        Me.lstOccupation.Items.AddRange(New Object() {"Doctor", "Programmer", "Teacher", "Student", "Thinker", "Tailor", "Soldier", "Sailor"})
        Me.lstOccupation.Location = New System.Drawing.Point(204, 216)
        Me.lstOccupation.Name = "lstOccupation"
        Me.lstOccupation.Size = New System.Drawing.Size(65, 134)
        Me.lstOccupation.TabIndex = 11
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Location = New System.Drawing.Point(201, 200)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(62, 13)
        Me.lblOccupation.TabIndex = 12
        Me.lblOccupation.Text = "Occupation"
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(137, 369)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(54, 20)
        Me.txtNumber1.TabIndex = 13
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(137, 405)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(54, 20)
        Me.txtNumber2.TabIndex = 14
        '
        'lblNumber1
        '
        Me.lblNumber1.AutoSize = True
        Me.lblNumber1.Location = New System.Drawing.Point(57, 376)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(56, 13)
        Me.lblNumber1.TabIndex = 15
        Me.lblNumber1.Text = "Number 1 "
        '
        'lblNumber2
        '
        Me.lblNumber2.AutoSize = True
        Me.lblNumber2.Location = New System.Drawing.Point(57, 412)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(53, 13)
        Me.lblNumber2.TabIndex = 16
        Me.lblNumber2.Text = "Number 2"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(297, 369)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(80, 56)
        Me.btnCalculate.TabIndex = 17
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnCalculate2
        '
        Me.btnCalculate2.Location = New System.Drawing.Point(297, 441)
        Me.btnCalculate2.Name = "btnCalculate2"
        Me.btnCalculate2.Size = New System.Drawing.Size(80, 56)
        Me.btnCalculate2.TabIndex = 22
        Me.btnCalculate2.Text = "Calculate"
        Me.btnCalculate2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 498)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Number 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 462)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Number 1 "
        '
        'txtNumber4
        '
        Me.txtNumber4.Location = New System.Drawing.Point(137, 491)
        Me.txtNumber4.Name = "txtNumber4"
        Me.txtNumber4.Size = New System.Drawing.Size(54, 20)
        Me.txtNumber4.TabIndex = 19
        '
        'txtNumber3
        '
        Me.txtNumber3.Location = New System.Drawing.Point(137, 455)
        Me.txtNumber3.Name = "txtNumber3"
        Me.txtNumber3.Size = New System.Drawing.Size(54, 20)
        Me.txtNumber3.TabIndex = 18
        '
        'btnCalculate3
        '
        Me.btnCalculate3.Location = New System.Drawing.Point(297, 521)
        Me.btnCalculate3.Name = "btnCalculate3"
        Me.btnCalculate3.Size = New System.Drawing.Size(80, 56)
        Me.btnCalculate3.TabIndex = 23
        Me.btnCalculate3.Text = "Calculate"
        Me.btnCalculate3.UseVisualStyleBackColor = True
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(57, 622)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(141, 13)
        Me.lblCountry.TabIndex = 24
        Me.lblCountry.Text = "What country are you from ?"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(197, 619)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(94, 20)
        Me.txtCountry.TabIndex = 25
        '
        'btnGreet
        '
        Me.btnGreet.Location = New System.Drawing.Point(297, 600)
        Me.btnGreet.Name = "btnGreet"
        Me.btnGreet.Size = New System.Drawing.Size(80, 52)
        Me.btnGreet.TabIndex = 26
        Me.btnGreet.Text = "Greeting"
        Me.btnGreet.UseVisualStyleBackColor = True
        '
        'lblExamScore
        '
        Me.lblExamScore.AutoSize = True
        Me.lblExamScore.Location = New System.Drawing.Point(56, 680)
        Me.lblExamScore.Name = "lblExamScore"
        Me.lblExamScore.Size = New System.Drawing.Size(138, 13)
        Me.lblExamScore.TabIndex = 27
        Me.lblExamScore.Text = "Enter the examination score"
        '
        'txtExamScore
        '
        Me.txtExamScore.Location = New System.Drawing.Point(197, 677)
        Me.txtExamScore.Name = "txtExamScore"
        Me.txtExamScore.Size = New System.Drawing.Size(94, 20)
        Me.txtExamScore.TabIndex = 28
        '
        'btnGrade
        '
        Me.btnGrade.Location = New System.Drawing.Point(297, 658)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(80, 52)
        Me.btnGrade.TabIndex = 29
        Me.btnGrade.Text = "Get Grade"
        Me.btnGrade.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1635, 848)
        Me.Controls.Add(Me.btnGrade)
        Me.Controls.Add(Me.txtExamScore)
        Me.Controls.Add(Me.lblExamScore)
        Me.Controls.Add(Me.btnGreet)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.btnCalculate3)
        Me.Controls.Add(Me.btnCalculate2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumber4)
        Me.Controls.Add(Me.txtNumber3)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblNumber2)
        Me.Controls.Add(Me.lblNumber1)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.lblOccupation)
        Me.Controls.Add(Me.lstOccupation)
        Me.Controls.Add(Me.txtGo2)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnGo1)
        Me.Controls.Add(Me.btnDataTypes)
        Me.Controls.Add(Me.btnVariables)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGo As Button
    Protected WithEvents btnVariables As Button
    Friend WithEvents btnDataTypes As Button
    Friend WithEvents btnGo1 As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtGo2 As Button
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents lblNumber1 As Label
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnCalculate2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumber4 As TextBox
    Friend WithEvents txtNumber3 As TextBox
    Friend WithEvents btnCalculate3 As Button
    Friend WithEvents lblCountry As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents btnGreet As Button
    Friend WithEvents lblExamScore As Label
    Friend WithEvents txtExamScore As TextBox
    Friend WithEvents btnGrade As Button

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
