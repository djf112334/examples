<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtDownloadAddress = New System.Windows.Forms.TextBox()
        Me.txtSaveAddress = New System.Windows.Forms.TextBox()
        Me.lblDownload = New System.Windows.Forms.Label()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.lblDownloadSize = New System.Windows.Forms.Label()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pbDownloadProgress = New System.Windows.Forms.ProgressBar()
        Me.lblDownloadBytes = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.cMnu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cMnuApplyExtension = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSpeedKBytes = New System.Windows.Forms.Label()
        Me.lblSpeedKBits = New System.Windows.Forms.Label()
        Me.ttip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblElapsedTime = New System.Windows.Forms.Label()
        Me.btnOpenDownload = New System.Windows.Forms.Button()
        Me.bg = New System.ComponentModel.BackgroundWorker()
        Me.pnlControlsAndStatus = New System.Windows.Forms.Panel()
        Me.cMnu.SuspendLayout
        Me.pnlControlsAndStatus.SuspendLayout
        Me.SuspendLayout
        '
        'btnDownload
        '
        Me.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDownload.Location = New System.Drawing.Point(169, 102)
        Me.btnDownload.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(115, 24)
        Me.btnDownload.TabIndex = 0
        Me.btnDownload.Text = "Start Download"
        Me.ttip.SetToolTip(Me.btnDownload, "Click to start downloading from the source url to the destination path on the com"& _ 
        "puter")
        Me.btnDownload.UseVisualStyleBackColor = false
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = false
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(288, 102)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(115, 24)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel Download"
        Me.ttip.SetToolTip(Me.btnCancel, "This will tell the DownloadAsync class to cancel the current download operation")
        Me.btnCancel.UseVisualStyleBackColor = false
        '
        'txtDownloadAddress
        '
        Me.txtDownloadAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDownloadAddress.Location = New System.Drawing.Point(6, 21)
        Me.txtDownloadAddress.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.txtDownloadAddress.Name = "txtDownloadAddress"
        Me.txtDownloadAddress.Size = New System.Drawing.Size(494, 21)
        Me.txtDownloadAddress.TabIndex = 2
        Me.txtDownloadAddress.Text = "http://192.168.10.106/Manoto/2017-01-08.12.00.1-0.rec/00001.mpg"
        Me.ttip.SetToolTip(Me.txtDownloadAddress, "The source url for the file you want to download")
        Me.txtDownloadAddress.WordWrap = false
        '
        'txtSaveAddress
        '
        Me.txtSaveAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaveAddress.Location = New System.Drawing.Point(6, 65)
        Me.txtSaveAddress.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.txtSaveAddress.Name = "txtSaveAddress"
        Me.txtSaveAddress.Size = New System.Drawing.Size(410, 21)
        Me.txtSaveAddress.TabIndex = 3
        Me.txtSaveAddress.Text = "o:\dl\123.mpg"
        Me.ttip.SetToolTip(Me.txtSaveAddress, "The location on the computer to save the download")
        '
        'lblDownload
        '
        Me.lblDownload.AutoSize = true
        Me.lblDownload.Location = New System.Drawing.Point(4, 3)
        Me.lblDownload.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDownload.Name = "lblDownload"
        Me.lblDownload.Size = New System.Drawing.Size(93, 15)
        Me.lblDownload.TabIndex = 4
        Me.lblDownload.Text = "Source Address"
        '
        'lblSave
        '
        Me.lblSave.AutoSize = true
        Me.lblSave.BackColor = System.Drawing.Color.Transparent
        Me.lblSave.Location = New System.Drawing.Point(4, 48)
        Me.lblSave.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(98, 15)
        Me.lblSave.TabIndex = 5
        Me.lblSave.Text = "SaveTo Location"
        '
        'lblDownloadSize
        '
        Me.lblDownloadSize.AutoEllipsis = true
        Me.lblDownloadSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.lblDownloadSize.Location = New System.Drawing.Point(5, 6)
        Me.lblDownloadSize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDownloadSize.Name = "lblDownloadSize"
        Me.lblDownloadSize.Size = New System.Drawing.Size(173, 17)
        Me.lblDownloadSize.TabIndex = 6
        Me.lblDownloadSize.Text = "Total Size: 0 KB"
        Me.ttip.SetToolTip(Me.lblDownloadSize, "Shows the size of the download in Kilo-Bytes")
        '
        'lblProgress
        '
        Me.lblProgress.AutoEllipsis = true
        Me.lblProgress.AutoSize = true
        Me.lblProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblProgress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.lblProgress.Location = New System.Drawing.Point(5, 113)
        Me.lblProgress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(100, 16)
        Me.lblProgress.TabIndex = 7
        Me.lblProgress.Text = "Progress: 0%"
        Me.ttip.SetToolTip(Me.lblProgress, "Shows how far along the download is based on a percentage value between 0 and 100"& _ 
        "%")
        '
        'lblStatus
        '
        Me.lblStatus.AutoEllipsis = true
        Me.lblStatus.AutoSize = true
        Me.lblStatus.Location = New System.Drawing.Point(5, 96)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(67, 15)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Status: Idle"
        Me.ttip.SetToolTip(Me.lblStatus, "The status of the application")
        '
        'pbDownloadProgress
        '
        Me.pbDownloadProgress.Location = New System.Drawing.Point(8, 68)
        Me.pbDownloadProgress.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.pbDownloadProgress.Name = "pbDownloadProgress"
        Me.pbDownloadProgress.Size = New System.Drawing.Size(480, 26)
        Me.pbDownloadProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbDownloadProgress.TabIndex = 9
        Me.ttip.SetToolTip(Me.pbDownloadProgress, "Displays the current percentage the download is currently at")
        '
        'lblDownloadBytes
        '
        Me.lblDownloadBytes.AutoEllipsis = true
        Me.lblDownloadBytes.AutoSize = true
        Me.lblDownloadBytes.Location = New System.Drawing.Point(5, 24)
        Me.lblDownloadBytes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDownloadBytes.Name = "lblDownloadBytes"
        Me.lblDownloadBytes.Size = New System.Drawing.Size(109, 15)
        Me.lblDownloadBytes.TabIndex = 10
        Me.lblDownloadBytes.Text = "Downloaded: 0 KB"
        Me.ttip.SetToolTip(Me.lblDownloadBytes, "Shows how many Kilo-Bytes has been downloaded so far")
        '
        'btnBrowse
        '
        Me.btnBrowse.AutoEllipsis = true
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowse.Location = New System.Drawing.Point(420, 60)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(80, 26)
        Me.btnBrowse.TabIndex = 11
        Me.btnBrowse.Text = "Save To..."
        Me.ttip.SetToolTip(Me.btnBrowse, "Click here to select the path and filename to save your download too")
        Me.btnBrowse.UseVisualStyleBackColor = false
        '
        'cMnu
        '
        Me.cMnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cMnuApplyExtension})
        Me.cMnu.Name = "cMnu"
        Me.cMnu.Size = New System.Drawing.Size(228, 26)
        '
        'cMnuApplyExtension
        '
        Me.cMnuApplyExtension.Name = "cMnuApplyExtension"
        Me.cMnuApplyExtension.Size = New System.Drawing.Size(227, 22)
        Me.cMnuApplyExtension.Text = "Apply Source Ext. to Save File"
        '
        'lblSpeedKBytes
        '
        Me.lblSpeedKBytes.AutoEllipsis = true
        Me.lblSpeedKBytes.AutoSize = true
        Me.lblSpeedKBytes.Location = New System.Drawing.Point(222, 24)
        Me.lblSpeedKBytes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSpeedKBytes.Name = "lblSpeedKBytes"
        Me.lblSpeedKBytes.Size = New System.Drawing.Size(84, 15)
        Me.lblSpeedKBytes.TabIndex = 13
        Me.lblSpeedKBytes.Text = "Speed: 0 KB/s"
        Me.ttip.SetToolTip(Me.lblSpeedKBytes, "The approximate current speed your downloading at in Kilo-Bytes per Second (1KB ="& _ 
        "1000 bytes)")
        '
        'lblSpeedKBits
        '
        Me.lblSpeedKBits.AutoEllipsis = true
        Me.lblSpeedKBits.AutoSize = true
        Me.lblSpeedKBits.Location = New System.Drawing.Point(222, 42)
        Me.lblSpeedKBits.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSpeedKBits.Name = "lblSpeedKBits"
        Me.lblSpeedKBits.Size = New System.Drawing.Size(81, 15)
        Me.lblSpeedKBits.TabIndex = 14
        Me.lblSpeedKBits.Text = "Speed: 0 kb/s"
        Me.ttip.SetToolTip(Me.lblSpeedKBits, "The approximate current speed your downloading at in kilo-bits (8 bits in a Byte)"& _ 
        " each second")
        Me.lblSpeedKBits.Visible = false
        '
        'lblElapsedTime
        '
        Me.lblElapsedTime.AutoEllipsis = true
        Me.lblElapsedTime.AutoSize = true
        Me.lblElapsedTime.Location = New System.Drawing.Point(5, 42)
        Me.lblElapsedTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblElapsedTime.Name = "lblElapsedTime"
        Me.lblElapsedTime.Size = New System.Drawing.Size(106, 15)
        Me.lblElapsedTime.TabIndex = 15
        Me.lblElapsedTime.Text = "Elasped Time: n/a"
        Me.ttip.SetToolTip(Me.lblElapsedTime, "Displays the amount of time that has elasped since the download started.")
        '
        'btnOpenDownload
        '
        Me.btnOpenDownload.Enabled = false
        Me.btnOpenDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOpenDownload.Location = New System.Drawing.Point(408, 102)
        Me.btnOpenDownload.Name = "btnOpenDownload"
        Me.btnOpenDownload.Size = New System.Drawing.Size(82, 23)
        Me.btnOpenDownload.TabIndex = 16
        Me.btnOpenDownload.Text = "Open"
        Me.btnOpenDownload.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ttip.SetToolTip(Me.btnOpenDownload, "Once the download has finished successfully click here to open the destination fi"& _ 
        "le")
        Me.btnOpenDownload.UseVisualStyleBackColor = true
        '
        'bg
        '
        Me.bg.WorkerReportsProgress = true
        Me.bg.WorkerSupportsCancellation = true
        '
        'pnlControlsAndStatus
        '
        Me.pnlControlsAndStatus.BackColor = System.Drawing.Color.Transparent
        Me.pnlControlsAndStatus.Controls.Add(Me.btnOpenDownload)
        Me.pnlControlsAndStatus.Controls.Add(Me.lblStatus)
        Me.pnlControlsAndStatus.Controls.Add(Me.lblElapsedTime)
        Me.pnlControlsAndStatus.Controls.Add(Me.lblDownloadBytes)
        Me.pnlControlsAndStatus.Controls.Add(Me.lblSpeedKBits)
        Me.pnlControlsAndStatus.Controls.Add(Me.pbDownloadProgress)
        Me.pnlControlsAndStatus.Controls.Add(Me.lblProgress)
        Me.pnlControlsAndStatus.Controls.Add(Me.lblDownloadSize)
        Me.pnlControlsAndStatus.Controls.Add(Me.btnDownload)
        Me.pnlControlsAndStatus.Controls.Add(Me.lblSpeedKBytes)
        Me.pnlControlsAndStatus.Controls.Add(Me.btnCancel)
        Me.pnlControlsAndStatus.Location = New System.Drawing.Point(4, 94)
        Me.pnlControlsAndStatus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlControlsAndStatus.Name = "pnlControlsAndStatus"
        Me.pnlControlsAndStatus.Size = New System.Drawing.Size(496, 133)
        Me.pnlControlsAndStatus.TabIndex = 16
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(505, 229)
        Me.Controls.Add(Me.lblDownload)
        Me.Controls.Add(Me.pnlControlsAndStatus)
        Me.Controls.Add(Me.txtDownloadAddress)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lblSave)
        Me.Controls.Add(Me.txtSaveAddress)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = true
        Me.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checking for Update ..."
        Me.cMnu.ResumeLayout(false)
        Me.pnlControlsAndStatus.ResumeLayout(false)
        Me.pnlControlsAndStatus.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtDownloadAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSaveAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblDownload As System.Windows.Forms.Label
    Friend WithEvents lblSave As System.Windows.Forms.Label
    Friend WithEvents lblDownloadSize As System.Windows.Forms.Label
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents pbDownloadProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents lblDownloadBytes As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents cMnu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cMnuApplyExtension As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblSpeedKBytes As System.Windows.Forms.Label
    Friend WithEvents lblSpeedKBits As System.Windows.Forms.Label
    Friend WithEvents ttip As System.Windows.Forms.ToolTip
    Friend WithEvents lblElapsedTime As System.Windows.Forms.Label
    Friend WithEvents bg As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnlControlsAndStatus As System.Windows.Forms.Panel
    Friend WithEvents btnOpenDownload As System.Windows.Forms.Button
End Class
