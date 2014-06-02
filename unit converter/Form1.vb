Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
   
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A As Double
        Dim C As Char



        C = ComboBox3.Text

        If TextBox1.Text = "" Then
            MsgBox("Please Enter a Value")
        Else
            A = TextBox1.Text

            Select Case ComboBox3.SelectedIndex
                Case 0
                    TextBox4.Text = A * 2.54
                Case 1
                    TextBox4.Text = A * 0.393700787
                Case 2
                    TextBox4.Text = A * 0.3048
                Case 3
                    TextBox4.Text = A * 3.280839895
                Case 4
                    TextBox4.Text = A * 0.9144
                Case 5
                    TextBox4.Text = A * 1.093613298
                Case 6
                    TextBox4.Text = A * 1.609344
                Case 7
                    TextBox4.Text = A * 0.621371192
                Case 8
                    TextBox4.Text = A * 1852
                Case 9
                    TextBox4.Text = A * 0.0005399568035
                Case 10
                    TextBox4.Text = A * 4046.856
                Case 11
                    TextBox4.Text = A * 0.0002471054073
                Case 12
                    TextBox4.Text = A * 3.785412
                Case 13
                    TextBox4.Text = A * 0.264172037
                Case 14
                    TextBox4.Text = A * 4.54609
                Case 15
                    TextBox4.Text = A * 0.219969248
                Case 16
                    TextBox4.Text = A * 30856780000000.0
                Case 17
                    TextBox4.Text = A * 0.0000000000000324077885
                Case 18
                    TextBox4.Text = A * 0.27777777777777779
                Case 19
                    TextBox4.Text = A * 3.6
                Case Else
                    TextBox4.Text = "INAPPROPRIATE INPUT"
            End Select
        End If




    End Sub

    
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(TextBox1.Text) Then

            Me.TextBox1.Text = Nothing
        End If

    End Sub

    
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
