Public Class frm_about
    Private Sub frm_about_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_version.Text = My.Application.Info.Version.ToString

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub lbl_cc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_cc.LinkClicked
        Process.Start("http://creativecommons.org/licenses/by-nd/4.0/")
    End Sub

    Private Sub lbl_website_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_website.LinkClicked
        Process.Start("http://www.sys-worx.net")
    End Sub
End Class