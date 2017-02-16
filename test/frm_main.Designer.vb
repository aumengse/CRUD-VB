<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.menu_admin = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menu_admin_users = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_admin_access = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_data = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_admin, Me.menu_data})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1146, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'menu_admin
        '
        Me.menu_admin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_admin_users, Me.menu_admin_access})
        Me.menu_admin.Name = "menu_admin"
        Me.menu_admin.ShowDropDownArrow = False
        Me.menu_admin.Size = New System.Drawing.Size(47, 22)
        Me.menu_admin.Text = "Admin"
        '
        'menu_admin_users
        '
        Me.menu_admin_users.Name = "menu_admin_users"
        Me.menu_admin_users.Size = New System.Drawing.Size(152, 22)
        Me.menu_admin_users.Text = "Users"
        '
        'menu_admin_access
        '
        Me.menu_admin_access.Name = "menu_admin_access"
        Me.menu_admin_access.Size = New System.Drawing.Size(152, 22)
        Me.menu_admin_access.Text = "Acces"
        '
        'menu_data
        '
        Me.menu_data.Name = "menu_data"
        Me.menu_data.Size = New System.Drawing.Size(44, 22)
        Me.menu_data.Text = "Data"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 514)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents menu_admin As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menu_admin_users As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_admin_access As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_data As System.Windows.Forms.ToolStripDropDownButton

End Class
