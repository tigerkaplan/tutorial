Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Reading")
        ComboBox1.Items.Add("Fishing")
        ComboBox1.Items.Add("Crafts")
        ComboBox1.Items.Add("Television")
        ComboBox1.Items.Add("Collecting")
        ComboBox1.Items.Add("Music")
        ComboBox1.Items.Add("Video Games")

        ComboBox1.Text = " Select from ..."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Sorted = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Items.Clear()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If ComboBox1.SelectedIndex > -1 Then

            Dim Index1 As Integer

            Index1 = ComboBox1.SelectedIndex

            Dim Item1 As Object
            Item1 = ComboBox1.SelectedItem
            ListBox1.Items.Add(Item1)


        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem.ToString)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox1.Sorted = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ListBox1.Items.Clear()

    End Sub

    Private Sub CheckedListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox.SelectedIndexChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("www.google.com")
    End Sub
End Class
