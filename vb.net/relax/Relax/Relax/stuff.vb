Imports System.IO
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



    
    Public Shared Sub Log(logMessage As String, w As TextWriter)

        w.Write("Log Entry : ")
        w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), _
            DateTime.Now.ToLongDateString())
      '  w.WriteLine("  :")
        w.WriteLine("  :{0}", logMessage)
        w.WriteLine ("---------------------------------------------------------------")
    End Sub

    Public Shared Sub DumpLog(r As StreamReader)
        Dim line As String
        line = r.ReadLine()
        While Not (line Is Nothing)
            Console.WriteLine(line)
            line = r.ReadLine()
        End While
    End Sub



End Class