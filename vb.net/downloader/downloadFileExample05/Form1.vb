'
'
''Title: Downloading Files using DownloadFileAsync Example VB 2005
'
''By: Jason Hensley
'
''Contact: mailto:vbcodesource@gmail.com
'
''Website: http://www.vbcodesource.com and http://www.vbforfree.com
'
''Description: A little application to simply show how to use the Webclient class built-in the .NET 
'framework using VB 2005 or newer. It uses the DownloadFileAsync features and does not consume your 
'thread which can keep your application from responding which would happen if you used the regular 
'DownloadFile feature without running it in a seperate thread. The example also adds events to get 
'the progress and download size, ect...
'
''Copyright: 2010, July 7th; Updated: 2010, July 18th
'
'
Imports Microsoft.Win32
'
Public Class frmMain
    '
    '
    'Will be used to setup the download url.
    Dim uriSource As Uri
    '
    'Create a new instance of the Webclient class.
    Dim downloading As New Net.WebClient
    '
    'Used for the Managed API Timer for calculating the approximate download speed.
    '
    'Will contain the ID of the timer.
    Dim timerID As IntPtr = 0
    '
    'Will simply hold the download speeds calculated value.
    Dim downloadSpeed As Integer = 0
    '
    'Willbe used to approximate the download speed.
    Dim currBytes As Long
    Dim prevBytes As Long
    '
    'These will be used to provide the elapsed time since the download started.
    Dim startTime As Long
    Dim elapsedTime As TimeSpan
    '
    'Used to let me know whether the download was successfully started or not.
    Dim downloadStarted As Boolean = False
    '
    'This sub will setup the event handlers for the program.
    Sub setupEventHandlers()

        Try
            '
            'The getDownloadProgress Sub will fire whenever the DownloadAsync method updates the file 
            'download status.
            AddHandler downloading.DownloadProgressChanged, AddressOf getDownloadProgress
            AddHandler downloading.DownloadFileCompleted, AddressOf downloadHasEnded
            '
            'This will setup the handler for the api timer.
            AddHandler SystemEvents.TimerElapsed, AddressOf downloadUpdating

        Catch exc As Exception

            MessageBox.Show(exc.Message, "  Info!", MessageBoxButtons.OK, _
                 MessageBoxIcon.Information)

        End Try

    End Sub
    '
    'This method will be called when the TimerElapsed event for the API timer is executed.
    Sub downloadUpdating(ByVal sender As Object, ByVal e As Microsoft.Win32.TimerElapsedEventArgs)
        '
        'The code below will calculate the approximate speed the download is running at. Unfortunately
        'the Webclient class doesn't have a feature for this. Thats why I came up with me own way. :)
        'My testing does show its not to far off from the real download speed.
        '
        Try
            '
            'This will display the time that has elapsed since the download started.
            elapsedTime = TimeSpan.FromTicks((Now.Ticks - startTime))
            '
            'I decided to use this custom code to format the timespan to not include 6 or more 
            'numbers past the decimal. Big oversite by Microsoft not having custom format options 
            'available for the TimeSpan class. Unless I overlooked it somewhere? I got this code from
            'a post in a question forum. Not sure the exact place though.
            lblElapsedTime.Text = "Elapsed Time: " & String.Format("{0:00}:{1:00}:{2:00}", _
                elapsedTime.TotalHours, elapsedTime.Minutes, elapsedTime.Seconds)
            '
            'This contains the total bytes that have been processed since the last time the value was 
            'checked about 1 second ago. Thus this will give you the approximate download speed in 
            'Kilo-Bytes per second. :)
            downloadSpeed = (currBytes - prevBytes)
            '
            'This will display the Kilo-BYTEs speed. I divide by 1024 to convert to the Kilo-Bytes value.
            'I've been back and forth between using 1000 bytes and 1024 bytes as a Kilo-Byte. I've 
            'looked at various info and I still don't know what I will eventually leave it at yet.
            lblSpeedKBytes.Text = "Speed: " & FormatNumber(downloadSpeed / 1000, 2).ToString & " KB/s"
            '
            'This will display the Kilo-BITS speed which some people like to see. Since their is 8 Bits to
            'every byte you will want to multiply the bytes value by 8. ISPs love using Bit to advertise
            'their internet speeds since it is a much higher number.
            lblSpeedKBits.Text = "Speed: " & FormatNumber((downloadSpeed / 1000) * 8, 2).ToString & " Kb/s"
            '
            'Keep the previous value to recalulate the speed when the timer reaches 1 second again.
            prevBytes = currBytes

        Catch exc As Exception

            MessageBox.Show(exc.Message, "  Info!", MessageBoxButtons.OK, _
                 MessageBoxIcon.Information)

        End Try

    End Sub
    '
    'This Sub contains the main download code. Not really any advantage to this now that I moved the 
    'uri and other code that was originially in this sub.
    Sub doDownload() '(ByVal sourceAddress As String, ByVal destLocation As String)

        Try
            '
            '
            'By using the Async version of DownloadFile your applications thread won't be focused on the 
            'download and thus you can still interact with your application. The only way to get that 
            'feature with the regular DownloadFile method is by running it in a seperate thread which is 
            'really not really worth doing since an async version is availble.
            downloading.DownloadFileAsync(uriSource, txtSaveAddress.Text)
            '
            downloadStarted = True

            btnCancel.Enabled = True
            btnDownload.Enabled = False

        Catch exc As Exception

            downloadStarted = False

            MessageBox.Show(exc.Message, "  Info!", MessageBoxButtons.OK, _
                 MessageBoxIcon.Information)

        End Try

    End Sub
    '
    'Will will fire when the download has ended.
    Sub downloadHasEnded(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        Try
            '
            'Display the download has finished or was canceled.
            '
            If e.Cancelled Then
                '
                'Show that the download had been canceled.
                lblStatus.Text = "Status: Canceled"
                btnOpenDownload.Enabled = False

            Else

                'Show that the download finished gracefully.
                lblStatus.Text = "Status: Finished!"
                btnOpenDownload.Enabled = True

            End If
            '
            btnCancel.Enabled = False
            btnDownload.Enabled = True
            '


            'First make sure the timerID has a address to a timer before calling KillTimer.
            If timerID.ToInt32 > 0 Then
                '
                'Now kill the timer passing the ID of the timer.
                SystemEvents.KillTimer(timerID)
                timerID = Nothing

            End If

        Catch exc As Exception

            MessageBox.Show(e.Error.Message, "  Info!", MessageBoxButtons.OK, _
                 MessageBoxIcon.Information)

        End Try

    End Sub
    '
    'This will be fired whenever the DownloadProgress based event is hit.
    Sub getDownloadProgress(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        '
        Try
            '
            'Update the progress bar and percentage label.
            pbDownloadProgress.Value = e.ProgressPercentage
            lblProgress.Text = "Progress: " & e.ProgressPercentage.ToString & "%"
            '
            'I went back and forth on whether to define a kilo-byte as 1000 bytes or 1024 bytes. I 
            'did some research and came up with download based bytes says 1KB = 1000bytes. But when 
            'it comes to files or storage then 1KB = 1024bytes. Anyways, I just went ahead and set 
            '1 KB to equal 1000 bytes. Even though I personally feel all KB's whether packet based 
            'or file based should be 1024.
            lblDownloadBytes.Text = "Downloaded: " & FormatNumber(e.BytesReceived / 1000, 2).ToString & " KB"
            lblDownloadSize.Text = "Download Size: " & FormatNumber(e.TotalBytesToReceive / 1000, 2).ToString & " KB"
            '
            'Keep this updated with the latest value. Used for calculating the download speed.
            currBytes = e.BytesReceived
            '
        Catch exc As Exception

            MessageBox.Show(exc.Message, "  Info!", MessageBoxButtons.OK, _
                 MessageBoxIcon.Information)

        End Try

    End Sub

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click

        Try
            '
            'Setup a new Uniform Resource Identifier. I originally had this in the DoDownload method
            'but decided to put it hereso it wouldn't process anymore code then it has to if the url 
            'is invalid.
            uriSource = New Uri(txtDownloadAddress.Text)
            '
            'Starts a Windows timer to tick every one second and gets the id which will be used when 
            'you want to kill the timer.
            timerID = SystemEvents.CreateTimer((1000))
            '
            'This will call the sub to get the downloaded started.
            doDownload() 'txtDownloadAddress.Text, txtSaveAddress.Text)
            '
            'This will hold the initial value for display the download elapsed time. Tickcount uses less
            'resources than the stopwatch class although it has a much lower resolution of abour 15-16ms.
            startTime = Now.Ticks
            '
            'Clear all values.
            currBytes = 0
            prevBytes = 0
            downloadSpeed = 0
            pbDownloadProgress.Value = 0
            lblStatus.Text = "Status: Started"

        Catch exc As Exception

            MessageBox.Show(exc.Message, "  Download Button!", MessageBoxButtons.OK, _
                 MessageBoxIcon.Information)

        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        '
        'Try to stop the download gracefully.
        '
        Try
            '
            'First make sure the timerID has a address to a timer before calling KillTimer.
            If timerID.ToInt32 > 0 Then
                '
                'Now kill the timer passing the ID of the timer.
                SystemEvents.KillTimer(timerID)
                timerID = Nothing

            End If
            '
            'Tell the Download operation to stop the download.
            downloading.CancelAsync()

        Catch exc As Exception

            MessageBox.Show(exc.Message, "  Info!", MessageBoxButtons.OK, _
                 MessageBoxIcon.Information)

        End Try

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        Dim saveDLG As New SaveFileDialog
        Dim ext As String = "|Exe(*.exe)|*.exe"

        saveDLG.Filter = "All Files (*.*)|*.*" & ext '"Exe (*.exe)|*.exe"

        saveDLG.Title = "Select the path and filename to save the download." & vbNewLine & vbNewLine _
            & "Be sure to add the extension."

        If saveDLG.ShowDialog = Windows.Forms.DialogResult.OK Then

            txtSaveAddress.Text = saveDLG.FileName

        End If

    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            '
            'Setup the needed event handlers for getting download status, ect..
            setupEventHandlers()

        Catch exc As Exception

            MessageBox.Show(exc.Message, "  Info!", MessageBoxButtons.OK, _
                 MessageBoxIcon.Information)

        End Try

    End Sub

    Private Sub btnOpenDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenDownload.Click
        '
        'This will try to execute the file from the path in the destination textbox.
        '
        Try
            '
            'Check first that the file exists.
            If My.Computer.FileSystem.FileExists(txtSaveAddress.Text) Then
                '
                'Attempt to open the downloaded file.
                Process.Start(txtSaveAddress.Text)

            Else

                MessageBox.Show("The file in the SaveTo Location doesn't appear to exist." & vbNewLine & _
                    vbNewLine & "Make sure the file was downloaded and saved successfully.", "  Cannot Open File", _
                        MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch exc As Exception

            MessageBox.Show(exc.Message, "  Info!", MessageBoxButtons.OK, _
                 MessageBoxIcon.Information)

        End Try

    End Sub

End Class