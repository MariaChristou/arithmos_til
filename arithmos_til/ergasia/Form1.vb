Public Class Form1

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim selStart As Integer = TextBox1.SelectionStart
        Dim selMoveLeft As Integer = 0
        Dim newStr As String = ""
        Dim array(2) As Integer


        For i As Integer = 0 To TextBox1.Text.Length - 1

            If "0123456789".IndexOf(TextBox1.Text(i)) <> -1 Then
                newStr = newStr & TextBox1.Text(i)

            ElseIf i < selStart Then
                selMoveLeft = selMoveLeft + 1

            End If
        Next
        TextBox1.Text = newStr
        TextBox1.SelectionStart = selStart - selMoveLeft

        Dim Price As Integer
        Dim firstTwoDigits As String = Int32.TryParse(newStr, Price)
        firstTwoDigits = TextBox1.Text.ToString()
        Dim Substring As String = firstTwoDigits.Substring(0, 2)

        If TextBox1.Text.Length < 10 Then
            MessageBox.Show("Less Than 10 Digits...Check The Number Again!")
        ElseIf TextBox1.Text.Length = 10 Then

            If Substring = "69" Then
                MessageBox.Show("Thank You!")
            ElseIf Substring <> "69" Then
                MessageBox.Show("Only Greek Numbers Please!")
            End If
        End If



    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress


    End Sub
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class
