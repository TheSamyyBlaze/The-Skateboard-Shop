Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkateboardShopDataSet.Skateboard' table. You can move, or remove it, as needed.
        Me.SkateboardTableAdapter.Fill(Me.SkateboardShopDataSet.Skateboard)

    End Sub

    'Back Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub SkateboardBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SkateboardBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SkateboardBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SkateboardShopDataSet)

    End Sub

    'Mouse Hover
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover

    End Sub

End Class