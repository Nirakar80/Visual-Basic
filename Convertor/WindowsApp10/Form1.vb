Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If radbtn1.Checked Then
            If radbtn7.Checked Then
                lblResult.Text = txtInput.Text * 1
                lblUnit.Text = "Acres"
            ElseIf radbtn8.Checked Then
                lblResult.Text = txtInput.Text * 0.404686
                lblUnit.Text = "Hectares"
            ElseIf radbtn9.Checked Then
                lblResult.Text = txtInput.Text * 1224.17
                lblUnit.Text = "Ping"
            ElseIf radbtn10.Checked Then
                lblResult.Text = txtInput.Text * 1210
                lblUnit.Text = "Square Fhathoms"
            ElseIf radbtn11.Checked Then
                lblResult.Text = txtInput.Text * 0.00404686
                lblUnit.Text = "Square Kilometers"
            ElseIf radbtn12.Checked Then
                lblResult.Text = txtInput.Text * 160
                lblUnit.Text = "Square Rods"
            End If

        ElseIf radbtn2.Checked Then
            If radbtn7.Checked Then
                lblResult.Text = txtInput.Text * 2.47105
                lblUnit.Text = "Acres"
            ElseIf radbtn8.Checked Then
                lblResult.Text = txtInput.Text * 1
                lblUnit.Text = "Hectares"
            ElseIf radbtn9.Checked Then
                lblResult.Text = txtInput.Text * 3025
                lblUnit.Text = "Ping"
            ElseIf radbtn10.Checked Then
                lblResult.Text = txtInput.Text * 2990
                lblUnit.Text = "Square Fhathoms"
            ElseIf radbtn11.Checked Then
                lblResult.Text = txtInput.Text * 0.01
                lblUnit.Text = "Square Kilometers"
            ElseIf radbtn12.Checked Then
                lblResult.Text = txtInput.Text * 395.4
                lblUnit.Text = "Square Rods"
            End If

        ElseIf radbtn3.Checked Then
            If radbtn7.Checked Then
                lblResult.Text = txtInput.Text * 0.0008
                lblUnit.Text = "Acres"
            ElseIf radbtn8.Checked Then
                lblResult.Text = txtInput.Text * 0.0003
                lblUnit.Text = "Hectares"
            ElseIf radbtn9.Checked Then
                lblResult.Text = txtInput.Text * 1
                lblUnit.Text = "Ping"
            ElseIf radbtn10.Checked Then
                lblResult.Text = txtInput.Text * 0.99
                lblUnit.Text = "Square Fhathoms"
            ElseIf radbtn11.Checked Then
                lblResult.Text = txtInput.Text * 3.3058e-6
                lblUnit.Text = "Square Kilometers"
            ElseIf radbtn12.Checked Then
                lblResult.Text = txtInput.Text * 0.1307
                lblUnit.Text = "Square Rods"
            End If

        ElseIf radbtn4.Checked Then
            If radbtn7.Checked Then
                lblResult.Text = txtInput.Text * 0.0008
                lblUnit.Text = "Acres"
            ElseIf radbtn8.Checked Then
                lblResult.Text = txtInput.Text * 0.0003
            ElseIf radbtn9.Checked Then
                lblResult.Text = txtInput.Text * 1.01171
                lblUnit.Text = "Ping"
            ElseIf radbtn10.Checked Then
                lblResult.Text = txtInput.Text * 1
                lblUnit.Text = "Square Fhathoms"
            ElseIf radbtn11.Checked Then
                lblResult.Text = txtInput.Text * 0.00000334
                lblUnit.Text = "Square Kilometers"
            ElseIf radbtn12.Checked Then
                lblResult.Text = txtInput.Text * 0.13
                lblUnit.Text = "Square Rods"
            End If

        ElseIf radbtn5.Checked Then
            If radbtn7.Checked Then
                lblResult.Text = txtInput.Text * 247.105
                lblUnit.Text = "Acres"
            ElseIf radbtn8.Checked Then
                lblResult.Text = txtInput.Text * 100
                lblUnit.Text = "Hectares"
            ElseIf radbtn9.Checked Then
                lblResult.Text = txtInput.Text * 302500
                lblUnit.Text = "Ping"
            ElseIf radbtn10.Checked Then
                lblResult.Text = txtInput.Text * 298998
                lblUnit.Text = "Square Fhathoms"
            ElseIf radbtn11.Checked Then
                lblResult.Text = txtInput.Text * 1
                lblUnit.Text = "Square Kilometers"
            ElseIf radbtn12.Checked Then
                lblResult.Text = txtInput.Text * 39536.9
                lblUnit.Text = "Square Rods"
            End If

        ElseIf radbtn6.Checked Then
            If radbtn7.Checked Then
                lblResult.Text = txtInput.Text * 0.00625
                lblUnit.Text = "Acres"
            ElseIf radbtn8.Checked Then
                lblResult.Text = txtInput.Text * 0.00252929
                lblUnit.Text = "Hectares"
            ElseIf radbtn9.Checked Then
                lblResult.Text = txtInput.Text * 7.65109
                lblUnit.Text = "Ping"
            ElseIf radbtn10.Checked Then
                lblResult.Text = txtInput.Text * 7.5625
                lblUnit.Text = "Square Fhathoms"
            ElseIf radbtn11.Checked Then
                lblResult.Text = txtInput.Text * 0.000025293
                lblUnit.Text = "Square Kilometers"
            ElseIf radbtn12.Checked Then
                lblResult.Text = txtInput.Text * 1
                lblUnit.Text = "Square Rods"
            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtInput.Clear()
        lblResult.Text = "Result"
        lblUnit.Text = ""
    End Sub

End Class
