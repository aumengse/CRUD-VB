Public Class frm_main

    Private Sub UseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_admin_users.Click
        ConnectDatabase()
        frm_users.Show()
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_data.Click

    End Sub
End Class
