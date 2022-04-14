Public Class Form1

    Dim resultado As Decimal
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim horasdobles As Integer
        Dim subdobles As Decimal
        Dim total As Decimal

        Dim resultado As Decimal
        If TextBox1.Text <= 40 Then
            total = TextBox1.Text * TextBox2.Text
            Label7.Text = Format(total, "$ ###,##0.#0")
            Label8.Text = Format(0, "$ ###,##0.#0")
            Label10.Text = Format(total, "$ ###,##0.#0")
        Else
            total = 40 * TextBox2.Text
            Label7.Text = Format(total, "$ ###,##0.#0")
            horasdobles = TextBox1.Text - 40
            subdobles = horasdobles * TextBox2.Text * 2
            Label8.Text = Format(subdobles, "$ ###,##0.#0")
            total = total + subdobles
            Label10.Text = Format(total, "$ ###,##0.#0")


        End If


        TextBox1.Focus()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
