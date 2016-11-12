Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         ContextMenuStrip1.Enabled = False

    End Sub


    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
       'Cancel Closing:
       e.Cancel = True
       'Minimize the form:
       Me.WindowState = FormWindowState.Minimized
       'Don't show in the task bar
       Me.ShowInTaskbar = False
       'Enable the Context Menu Strip
       ContextMenuStrip1.Enabled = True
   End Sub

      Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
       'When Show menu clicks, it will show the form:
       Me.WindowState = FormWindowState.Normal
       'Show in the task bar:
       Me.ShowInTaskbar = True
       'Disable the Context Menu:
       ContextMenuStrip1.Enabled = False
   End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
               end
    End Sub

    Private Sub Form1_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            ShowInTaskbar = False
            ContextMenuStrip1.Enabled = True
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAboutBox1.Show

    End Sub
End Class
