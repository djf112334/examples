Public Class Form1
     Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                           Handles MyBase.Load

        NotifyIcon1.BalloonTipText = "Tool Tip Text for Windows Application"
        NotifyIcon1.Text = "Windows Application"
        NotifyIcon1.ShowBalloonTip(5000)
        CreateContextMenu()

    End Sub

    Public Sub CreateContextMenu()

        'Define New Context Menu and Menu Item 
        Dim contextMenu As New ContextMenu
        Dim menuItem As New MenuItem("Exit")
        contextMenu.MenuItems.Add(menuItem)

        ' Associate context menu with Notify Icon 
        NotifyIcon1.ContextMenu = contextMenu

        'Add functionality for menu Item click 
        AddHandler menuItem.Click, AddressOf menuItem_Click

    End Sub

    Private Sub menuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class
