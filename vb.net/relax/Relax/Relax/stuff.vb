Imports System.IO
Imports System.Threading

Public Class stuff

      
    Public Function CompareFiles(ByVal file1FullPath As String, ByVal file2FullPath As String) As Boolean

        If Not File.Exists(file1FullPath) Or Not File.Exists(file2FullPath) Then
            'One or both of the files does not exist.
            MsgBox ("file nist")
            Return False
        End If

        If file1FullPath = file2FullPath Then
            ' fileFullPath1 and fileFullPath2 points to the same file...
            MsgBox ("file MASIR YEKIE ")
            Return True
        End If

        Try
            Dim file1Hash As String = hashFile(file1FullPath)
            Dim file2Hash As String = hashFile(file2FullPath)

            If file1Hash = file2Hash Then
                  MsgBox ("file hash yekist ")
                Return True
            Else
                  MsgBox ("file motavaet ast ")
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public  Function hashFile(ByVal filepath As String) As String
        Using reader As New System.IO.FileStream(filepath, IO.FileMode.Open, IO.FileAccess.Read)
            Using md5 As New System.Security.Cryptography.MD5CryptoServiceProvider
                Dim hash() As Byte = md5.ComputeHash(reader)
                Return System.Text.Encoding.Unicode.GetString(hash)
            End Using
        End Using
    End Function

    
 Public Shared Sub DumpLog(r As StreamReader)
        Dim line As String
        line = r.ReadLine()
        While Not (line Is Nothing)
            Console.WriteLine(line)
            line = r.ReadLine()
        End While
    End Sub




  Public Shared sub mylog (logtxt As String)
    
      dim logdir =  My.Application.Info.DirectoryPath
          Directory.CreateDirectory (logdir & "\logs")
          Thread.Sleep(1000)
      Dim strFile As String = logdir &  "\logs\ErrorLog_" & DateTime.Today.ToString("dd-MMM-yyyy") & ".log"
      Dim sw As StreamWriter


            Try
               If (Not File.Exists(strFile)) Then
                  sw = File.CreateText(strFile)
                  sw.WriteLine("Start Error Log for today")
               Else
                  sw = File.AppendText(strFile)
               End If
               sw.WriteLine( DateTime.Now & " Err# [" & Err.Number & "].Des --> "  & logtxt & vbCrLf & "------------------------------------------------------------------" )
               sw.Close()
            Catch ex As IOException
               MsgBox("Error writing to log file.")
            End Try


    End sub


       
   public Shared  sub ttip (tiptxt As String ,tipdelay as integer , tipinit as integer )
        
         ' Create the ToolTip and associate with the Form container.
   Dim toolTip1 As New ToolTip()

   ' Set up the delays for the ToolTip.
   toolTip1.AutoPopDelay = 5000
   toolTip1.InitialDelay = 1000
   toolTip1.ReshowDelay = 500
   ' Force the ToolTip text to be displayed whether or not the form is active.
   toolTip1.ShowAlways = True

  

    End sub



     


    


End Class