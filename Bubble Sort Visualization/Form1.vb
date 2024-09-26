Public Class Form1
    'set some variables te standard value
    Public inc As Integer = 0
    Public val1 As Integer = 0
    Public val2 As Integer = 0
    Public val3 As Integer = 0
    Public val4 As Integer = 0
    Public val5 As Integer = 0
    Public val6 As Integer = 0
    Public val7 As Integer = 0
    Public val8 As Integer = 0
    Public val9 As Integer = 0
    Public Rec1 As New Rectangle(110, 130, 250, 80)
    Public aprove2 As Boolean = False
    Public Ascending As Boolean = False
    Public Descending As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'make sure the user inputs the correct format of numbers
        Try
            Dim UserInput As Integer = TextBox1.Text
            Dim Valid As Boolean
            Dim Valid2 As Boolean

            If UserInput <= 100 Then
                If UserInput = val1 Then
                    MsgBox("Please Enter another value!")
                    TextBox1.Clear()
                ElseIf UserInput = val2 Then
                    MsgBox("Please Enter another value!")
                    TextBox1.Clear()
                ElseIf UserInput = val3 Then
                    MsgBox("Please Enter another value!")
                    TextBox1.Clear()
                ElseIf UserInput = val4 Then
                    MsgBox("Please Enter another value!")
                    TextBox1.Clear()
                ElseIf UserInput = val5 Then
                    MsgBox("Please Enter another value!")
                    TextBox1.Clear()
                ElseIf UserInput = val6 Then
                    MsgBox("Please Enter another value!")
                    TextBox1.Clear()
                ElseIf UserInput = val7 Then
                    MsgBox("Please Enter another value!")
                    TextBox1.Clear()
                ElseIf UserInput = val8 Then
                    MsgBox("Please Enter another value!")
                    TextBox1.Clear()
                ElseIf UserInput = val9 Then
                    MsgBox("Please Enter another value!")
                    TextBox1.Clear()
                Else
                    Valid = True
                End If
            End If

            If Valid = True Then
                If Label1.Text = "?" Then
                    val1 = UserInput
                    Label1.Text = UserInput
                    TextBox1.Clear()
                ElseIf Label2.Text = "?" Then
                    val2 = UserInput
                    Label2.Text = UserInput
                    TextBox1.Clear()
                ElseIf Label3.Text = "?" Then
                    val3 = UserInput
                    Label3.Text = UserInput
                    TextBox1.Clear()
                ElseIf Label4.Text = "?" Then
                    val4 = UserInput
                    Label4.Text = UserInput
                    TextBox1.Clear()
                ElseIf Label5.Text = "?" Then
                    val5 = UserInput
                    Label5.Text = UserInput
                    TextBox1.Clear()
                ElseIf Label6.Text = "?" Then
                    val6 = UserInput
                    Label6.Text = UserInput
                    TextBox1.Clear()
                ElseIf Label7.Text = "?" Then
                    val7 = UserInput
                    Label7.Text = UserInput
                    TextBox1.Clear()
                ElseIf Label8.Text = "?" Then
                    val8 = UserInput
                    Label8.Text = UserInput
                    TextBox1.Clear()
                ElseIf Label9.Text = "?" Then
                    val9 = UserInput
                    Label9.Text = UserInput
                    TextBox1.Clear()
                    Valid2 = True
                End If
            End If

            If Valid2 = True Then
                Button2.Enabled = True
                Button1.Enabled = False
                TextBox1.Enabled = False
            Else
                Button2.Enabled = False
                Button1.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dont display some features untill later
        Label10.Text = "Created By Mornante" & Chr(153)

        Button2.Enabled = False
        Button3.Enabled = False

        inc = 0
        val1 = 0
        val2 = 0
        val3 = 0
        val4 = 0
        val5 = 0
        val6 = 0
        val7 = 0
        val8 = 0
        val9 = 0
        Ascending = False
        Descending = False
        aprove2 = False
    End Sub
    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'how to rearange the order of the numbers on what time and display when completed
        inc = inc + 1
        Label12.Text = inc
        Dim X As String

        If inc = 5 Then
            Rec1.Location = New Point(Rec1.Location.X, Rec1.Location.Y)
            Me.Refresh()
            If val2 < val1 Then
                X = val1
                val1 = val2
                val2 = X
                Label1.Text = val1
                Label2.Text = val2
            End If
        ElseIf inc = 10 Then
            Rec1.Location = New Point(Rec1.Location.X + 127, Rec1.Location.Y)
            Me.Refresh()
            If val3 < val2 Then
                X = val2
                val2 = val3
                val3 = X
                Label2.Text = val2
                Label3.Text = val3
            End If
        ElseIf inc = 15 Then
            Rec1.Location = New Point(Rec1.Location.X + 127, Rec1.Location.Y)
            Me.Refresh()
            If val4 < val3 Then
                X = val3
                val3 = val4
                val4 = X
                Label3.Text = val3
                Label4.Text = val4
            End If
        ElseIf inc = 20 Then
            Rec1.Location = New Point(Rec1.Location.X + 127, Rec1.Location.Y)
            Me.Refresh()
            If val5 < val4 Then
                X = val4
                val4 = val5
                val5 = X
                Label4.Text = val4
                Label5.Text = val5
            End If
        ElseIf inc = 25 Then
            Rec1.Location = New Point(Rec1.Location.X + 127, Rec1.Location.Y)
            Me.Refresh()
            If val6 < val5 Then
                X = val5
                val5 = val6
                val6 = X
                Label5.Text = val5
                Label6.Text = val6
            End If
        ElseIf inc = 30 Then
            Rec1.Location = New Point(Rec1.Location.X + 127, Rec1.Location.Y)
            Me.Refresh()
            If val7 < val6 Then
                X = val6
                val6 = val7
                val7 = X
                Label6.Text = val6
                Label7.Text = val7
            End If
        ElseIf inc = 35 Then
            Rec1.Location = New Point(Rec1.Location.X + 127, Rec1.Location.Y)
            Me.Refresh()
            If val8 < val7 Then
                X = val7
                val7 = val8
                val8 = X
                Label7.Text = val7
                Label8.Text = val8
            End If
        ElseIf inc = 40 Then
            Rec1.Location = New Point(Rec1.Location.X + 127, Rec1.Location.Y)
            Me.Refresh()
            If val9 < val8 Then
                X = val8
                val8 = val9
                val9 = X
                Label8.Text = val8
                Label9.Text = val9
            End If
        ElseIf inc = 45 Then
            Rec1.Location = New Point(110, 130)
            Me.Refresh()
            If val1 < val2 And val2 < val3 And val3 < val4 And
            val4 < val5 And val5 < val6 And val6 < val7 And
            val7 < val8 And val8 < val9 Then
                Timer1.Stop()
                Button3.Enabled = True
                Button2.Enabled = False
                Label12.Text = "Completed"
                Label1.ForeColor = Color.Green
                Label2.ForeColor = Color.Green
                Label3.ForeColor = Color.Green
                Label4.ForeColor = Color.Green
                Label5.ForeColor = Color.Green
                Label6.ForeColor = Color.Green
                Label7.ForeColor = Color.Green
                Label8.ForeColor = Color.Green
                Label9.ForeColor = Color.Green
                Label12.ForeColor = Color.Green
            Else
                Timer1.Stop()
                inc = 0
                Timer1.Start()
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'if all settings are correct start the app
        Try
            If aprove2 = True Then
                If Ascending = True Then
                    Timer1.Start()
                    TextBox1.Enabled = False
                    RadioButton4.Enabled = False
                    RadioButton5.Enabled = False
                    Button2.Enabled = False
                ElseIf Descending = True Then
                    Timer2.Start()
                    TextBox1.Enabled = False
                    RadioButton4.Enabled = False
                    RadioButton5.Enabled = False
                    Button2.Enabled = False
                End If
            Else
                MsgBox("Please sellect the Order it should be in (As. or De.)")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'reset the app
        Try
            Me.Controls.Clear()
            InitializeComponent()
            Form1_Load(e, e)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'create the rectangles
        e.Graphics.DrawRectangle(Pens.White, Rec1)
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        'set the order function
        If RadioButton4.Checked = True Then
            Ascending = True
            Descending = False
            RadioButton5.Checked = False
            aprove2 = True
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        'set the order function
        If RadioButton5.Checked = True Then
            Descending = True
            Ascending = False
            RadioButton4.Checked = False
            aprove2 = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'how to rearange the order of the numbers on what time and display when completed
        inc = inc + 1
        Label12.Text = inc
        Dim X As String

        If inc = 5 Then
            Rec1.Location = New Point(Rec1.Location.X, Rec1.Location.Y)
            Me.Refresh()
            If val2 > val1 Then
                X = val1
                val1 = val2
                val2 = X
                Label1.Text = val1
                Label2.Text = val2
            End If
        ElseIf inc = 10 Then
            Rec1.Location = New Point(Rec1.Location.X + 127, Rec1.Location.Y)
            Me.Refresh()
            If val3 > val2 Then
                X = val2
                val2 = val3
                val3 = X
                Label2.Text = val2
                Label3.Text = val3
            End If
        ElseIf inc = 15 Then
            Rec1.Location = New Point(Rec1.Location.X + 127, Rec1.Location.Y)
            Me.Refresh()
            If val4 > val3 Then
                X = val3
                val3 = val4
                val4 = X
                Label3.Text = val3
                Label4.Text = val4
            End If
        ElseIf inc = 20 Then
            Rec1.Location = New Point(Rec1.Location.X + 127, Rec1.Location.Y)
            Me.Refresh()
            If val5 > val4 Then
                X = val4
                val4 = val5
                val5 = X
                Label4.Text = val4
                Label5.Text = val5
            End If
        ElseIf inc = 25 Then
            Rec1.Location = New Point(Rec1.Location.X + 127, Rec1.Location.Y)
            Me.Refresh()
            If val6 > val5 Then
                X = val5
                val5 = val6
                val6 = X
                Label5.Text = val5
                Label6.Text = val6
            End If
        ElseIf inc = 30 Then
            Rec1.Location = New Point(Rec1.Location.X + 127, Rec1.Location.Y)
            Me.Refresh()
            If val7 > val6 Then
                X = val6
                val6 = val7
                val7 = X
                Label6.Text = val6
                Label7.Text = val7
            End If
        ElseIf inc = 35 Then
            Rec1.Location = New Point(Rec1.Location.X + 127, Rec1.Location.Y)
            Me.Refresh()
            If val8 > val7 Then
                X = val7
                val7 = val8
                val8 = X
                Label7.Text = val7
                Label8.Text = val8
            End If
        ElseIf inc = 40 Then
            Rec1.Location = New Point(Rec1.Location.X + 127, Rec1.Location.Y)
            Me.Refresh()
            If val9 > val8 Then
                X = val8
                val8 = val9
                val9 = X
                Label8.Text = val8
                Label9.Text = val9
            End If
        ElseIf inc = 45 Then
            Rec1.Location = New Point(110, 130)
            Me.Refresh()
            If val1 > val2 And val2 > val3 And val3 > val4 And
            val4 > val5 And val5 > val6 And val6 > val7 And
            val7 > val8 And val8 > val9 Then
                Timer2.Stop()
                Button3.Enabled = True
                Button2.Enabled = False
                Label12.Text = "Completed"
                Label1.ForeColor = Color.Green
                Label2.ForeColor = Color.Green
                Label3.ForeColor = Color.Green
                Label4.ForeColor = Color.Green
                Label5.ForeColor = Color.Green
                Label6.ForeColor = Color.Green
                Label7.ForeColor = Color.Green
                Label8.ForeColor = Color.Green
                Label9.ForeColor = Color.Green
                Label12.ForeColor = Color.Green
            Else
                Timer2.Stop()
                inc = 0
                Timer2.Start()
            End If
        End If
    End Sub
End Class
