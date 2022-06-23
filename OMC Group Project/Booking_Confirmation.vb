Public Class Booking_Confirmation
    Private Sub btnConfirm_MouseEnter(sender As Object, e As EventArgs) Handles btnConfirm.MouseEnter
        btnConfirm.Image = New Bitmap(My.Resources.btnConfirmHover)
    End Sub

    Private Sub btnConfirm_MouseLeave(sender As Object, e As EventArgs) Handles btnConfirm.MouseLeave
        btnConfirm.Image = New Bitmap(My.Resources.btnConfirm)
    End Sub

    Private Sub dateEnd_ValueChanged(sender As Object, e As EventArgs) Handles dateEnd.ValueChanged
        Dim dt1 As DateTime = Convert.ToDateTime(dateStart.Value.ToString("dd/MM/yyy"))
        Dim dt2 As DateTime = Convert.ToDateTime(dateEnd.Value.ToString("dd/MM/yyy"))
        Dim days As Integer = (dt1.Date - dt2.Date).Days

        txtDays.Text = days
    End Sub

    Private Sub txtPerson_TextChanged(sender As Object, e As EventArgs) Handles txtPerson.TextChanged
        'Calculate total price
    End Sub
End Class