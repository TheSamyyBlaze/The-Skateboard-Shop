Public Class Form2

    'Made by Sam Kapoor
    'Year 10 IST

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkateboardShopDataSet.Skateboard' table. You can move, or remove it, as needed.
        Me.SkateboardTableAdapter.Fill(Me.SkateboardShopDataSet.Skateboard)
        'TODO: This line of code loads data into the 'SkateboardShopDataSet.Skateboard' table. You can move, or remove it, as needed.
        Me.SkateboardTableAdapter.Fill(Me.SkateboardShopDataSet.Skateboard)
        'TODO: This line of code loads data into the 'SkateboardShopDataSet.Skateboard' table. You can move, or remove it, as needed.
        Me.SkateboardTableAdapter.Fill(Me.SkateboardShopDataSet.Skateboard)

    End Sub

    'Proceed To Checkout Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Send Info to Form3
        Try
            Form3.Show()

            Form3.TextBox1.Text = Full_NameTextBox.Text
            Form3.TextBox2.Text = Phone_NumberTextBox.Text
            Form3.TextBox3.Text = EmailTextBox.Text
            Form3.TextBox4.Text = QuantityTextBox.Text

            'TOTAL PRICE INCLUDING 10% GST!!!
            Form3.TextBox5.Text = ((Total_PriceTextBox.Text * (10 / 100)) + Total_PriceTextBox.Text)
        Catch ex As Exception
            Form3.Close()
            Form1.Show()
            Me.Close()
            MsgBox("ERROR in the Invoice Page: Please fill in all tables next time!!!")
        End Try

        Me.Close()
    End Sub

    'Back Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    'Extra Stuff, lables, etc. :
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SkateboardBindingNavigator_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub Yellow_SkateboardLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Blue_SkateboardCheckBox_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Full_NameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Yellow_SkateboardCheckBox_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub IDTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Total_PriceTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'Mouse Hover:
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover

    End Sub
End Class