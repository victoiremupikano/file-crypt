Public Class FrmAbout
    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        frm_Main.Opacity = 1
        Me.Close()
    End Sub


End Class