Public Class Home
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

        If cboState.SelectedIndex = 0 Then
            'picLangkawi.Location = New Point(172, 70)
            'picCameron.Location = New Point(172, 140)
            'lblTest.Text = picPPerhentian.Location.ToString()
            'picLangkawi.Location = New Point(230, 90)
            picPPerhentian.Visible = False
        End If
    End Sub
End Class