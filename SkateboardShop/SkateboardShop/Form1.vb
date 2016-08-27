Public Class Form1

    'Made by Sam Kapoor
    'Year 10 IST

    'LOAD FORM
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.AutoScroll = False

        'Get Host Name and Ip Address:
        Dim strHostName As String
        Dim strIPAddress As String

        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()


        Label5.Text = ("Host Name: " & strHostName)
        Label6.Text = ("IP Address: " & strIPAddress)

        'Start Timer
        Timer1.Start()

        'Init Date
        Dim regDate As Date = Date.Now()
        Dim strDate As String = regDate.ToString("dd/MMM/yyyy")
        Label8.Text = strDate

    End Sub

    'Activate Form 2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    'Applied GST
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MyBase.Click, Button2.Click
        MsgBox("10% GST is applied.")
    End Sub

    'Browse "SkateboardShop.accmdb" Database
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Close()
    End Sub

    'Settings Page
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        '<--NULL-->
    End Sub

    'Timer 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    'Mouse Hover Over Button 4
    Private Sub Button4_MouseHover(sender As Object, e As EventArgs)

    End Sub

    'Mouse Hover Over Button 2
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover, MyBase.MouseHover
        ToolTip1.Show("Applied GST", Button2)
    End Sub

    'Mouse Hover Over Button 1
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        ToolTip1.Show("Invoice and Checkout", Button1)
    End Sub

    'Mouse Hover Over Button 3
    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        ToolTip1.Show("Browse Databse", Button3)
    End Sub

    'MISC:
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button4_MouseHover_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs)

    End Sub
End Class
