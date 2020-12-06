Public Class Form1
    Private Sub buttonCalc_Click(sender As Object, e As EventArgs) Handles buttonCalc.Click
        Dim grade1, grade2, grade3, gradeAvg As Single

        If TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text) Then
            MsgBox("Please input a numeric value in Field 1.")
        ElseIf CSng(TextBox1.Text) < 0 = True Or TextBox1.Text > 100 = True Then
            MsgBox("Grade values may not fall below 0 or exceed 100.")

        Else
            grade1 = CSng(TextBox1.Text)
            If TextBox2.Text = "" Or Not IsNumeric(TextBox2.Text) Then
                MsgBox("Please input a numeric value in Field 2.")
            ElseIf CSng(TextBox2.Text) < 0 = True Or TextBox2.Text > 100 = True Then
                MsgBox("Grade values may not fall below 0 or exceed 100.")

            Else
                grade2 = CSng(TextBox2.Text)
                If TextBox3.Text = "" Or Not IsNumeric(TextBox3.Text) Then
                    MsgBox("Please input a numeric value in Field 3.")
                ElseIf CSng(TextBox3.Text) < 0 = True Or TextBox3.Text > 100 = True Then
                    MsgBox("Grade values may not fall below 0 or exceed 100.")
                Else
                    grade3 = CSng(TextBox3.Text)

                    gradeAvg = ((grade1 + grade2 + grade3) / 3)
                    If (gradeAvg > 59) Then
                        resultLabel.Text = gradeAvg.ToString("N")
                        resultLabel.ForeColor = Color.Green
                        rewriteNotifier.Text = ""
                    Else
                        resultLabel.Text = gradeAvg.ToString("N")
                        resultLabel.ForeColor = Color.Red
                        If (grade1 > 89) Or (grade2 > 89) Or (grade3 > 89) Then
                            rewriteNotifier.Text = "Rewrite eligible!"
                            rewriteNotifier.ForeColor = Color.CornflowerBlue
                        Else
                            rewriteNotifier.Text = "Rewrite not eligible."
                            rewriteNotifier.ForeColor = Color.Orange
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        resultLabel.Text = ""
        rewriteNotifier.Text = ""
    End Sub
End Class
