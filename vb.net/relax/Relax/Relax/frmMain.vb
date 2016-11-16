
Imports System.IO
Imports System.Media
Imports System.Threading              ' for sleep command



Public Class Form1
    Private myIni As goini
    Public startin1, startin2, startin3, FilePathUbix, FilePathClient, FilePathClientOut, removepath1, removepath2, removepath3, removepath4, removepath5 As String
    Public mydate As String
    Public mytime As String
    Public  projdir As String
    
    Public FileSizeClient as System.IO.FileInfo
    Public FileSizeUbix as System.IO.FileInfo
    Public    nofileclient  As Boolean   = False 
       dim co as Integer = 100




    Sub  tst
    
        
        End 
    End Sub


    Private Sub Main()

       

    On Error goto errpart 
            
         ' check needed files tu run relax 
            filechk ( "vars.ini")
            filechk ( "extract.exe")
        	filechk ( "LisaCore.dll")
        	filechk ( "LisaExtractor.dll")
        	filechk ( "LisaExtractorApp.dll")
        	filechk ( "LisaCoreWin.dll")
        
             projdir = My.Application.Info.DirectoryPath & "\"   
             mydate = Now.Date()
             mytime = TimeOfDay.ToString("hh:mm")
             chkini()          'get setting from INI file
              
     '  Dim pathsclient() As String = IO.Directory.GetFiles(projdir &  FilePathClient  , "*.ts" )  
        Dim pathsubix() As String = IO.Directory.GetFiles( FilePathUbix  , "*.ts" )  
      '  Dim comparets As New stuff
        Dim desfile As String 
        Dim cmdcommand As String 
        Dim OpenCMD 

     
       

     While mytime = startin1 Or mytime = startin2 Or mytime = startin3
          
           
                    CreateObject("WScript.Shell").Popup("This program will copy and convert TOOSHEH TV DATA and Media to shared folder on network share path.RELAX Running at this location : " & projdir ,  3, "Welcome to RELAX",64)
                    Directory.CreateDirectory (projdir & FilePathClient )         ' create ts folder in project dir 
                    Thread.Sleep(1000)
            
                '  comparets.CompareFiles  ( pathsclient(0),pathsubix(0) )                'compare TS on server and client 
            
                        If chktsclient ("ts")=False Then
                    'so file does noit exist  and start copy from server 
                 ''   MsgBox  ("nabood comi mikonam ")
                        My.Computer.FileSystem.CopyDirectory(FilePathUbix  , projdir & "ts", showUI:=FileIO.UIOption.AllDialogs)
                                
                              Else 
                        ''    MsgBox  ("bood  rad shod  ")
                '   FileSizeClient  = My.Computer.FileSystem.GetFileInfo(pathsclient(0) )    ' get TS file size on CLIENT 
                'MsgBox (FileSizeClient.Length )             
                         End If
   
                FileSizeUbix =  My.Computer.FileSystem.GetFileInfo(pathsubix(0) )            ' ' get TS file size on SERVER  
                   
               CreateObject("WScript.Shell").Popup("file size on server = " & FileSizeUbix .Length ,  3, "File already exist  ",64)
            
            If chktssrv ("ts")=False Then
       
                    CreateObject("WScript.Shell").Popup("No .TS file found in server to copy. " ,  3, "Copy status ... ",64)

						else
					
                    CreateObject("WScript.Shell").Popup("All file(s) copied to client successfully." ,  3, "Copy status ... ",64)

		       end if

                        desfile =   Now.Date.ToString ("yyyy-MM-dd")            ' date format like 2016-10-25
                            cmdcommand =  projdir  & FilePathClientOut & desfile & " /ts  " &  projdir & FilePathClient
                        '   MsgBox (cmdcommand )
                            OpenCMD = CreateObject("wscript.shell")
                        OpenCMD.run("cmd /c extract.exe " & cmdcommand )

                        Thread.Sleep (20000)


            '   Remove folders  ==============================================================================================================

                    delfile  (projdir  & FilePathClientOut &desfile &  removepath1)
                    delfile  (projdir  & FilePathClientOut &desfile &  removepath2)
                    delfile  (projdir  & FilePathClientOut &desfile &  removepath3)
                    delfile  (projdir  & FilePathClientOut &desfile &  removepath4)
                    delfile  (projdir  & FilePathClientOut &desfile &  removepath5)

            

                  '  Directory.Delete (projdir  & FilePathClientOut &desfile &  removepath1,True)
                   '     Directory.Delete (projdir  & FilePathClientOut &desfile &  removepath2,True)
                    '    Directory.Delete (projdir  & FilePathClientOut &desfile &  removepath3,True)
                     '   Directory.Delete (projdir  & FilePathClientOut &desfile &  removepath4,True)
                      '  Directory.Delete (projdir  & FilePathClientOut &desfile &  removepath5,True)

        '  Remove folders  ==============================================================================================================
                              '      Directory.Delete (projdir  & FilePathClient ,True)

                    delfile  (projdir  & FilePathClient)

                    CreateObject("WScript.Shell").Popup(".TS file deleting ... , Operational successfully completed. " ,  3, "RELAX Inform",64)

                    mytime = TimeOfDay.ToString("hh:mm")
           


        End While

  errpart:

        If Err.Number = 76 then 
            
        
                Using w As StreamWriter = File.AppendText(projdir & "relax.log")
                stuff .  Log(ErrorToString, w)
                End Using
                msgbox ( ErrorToString  & " RELAX need correct path to access the TS file.Please set correct path in vars.ini.RELAX now terminate.",vbCritical ,"TS path not found")
      end If 
    
        If Err.Number <> 0 then  
            MsgBox ( Err.Number & ErrorToString )
        End If
        
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
        ContextMenuStrip1.Enabled = True
        me.Show()

     

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
     
        
        
                   Application.DoEvents()
                   me.Refresh 
                 '  Thread.Sleep(300)
                   Main()

          co =co -10
        if co < 0 then
            co=100
       End If
      label1.Text=co 
      progressBar1.Value=co

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
      ''  ContextMenuStrip1.Enabled = False
        me.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
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

    Private Sub chkini()

        'Create ini object.
        myIni = New goini
        'File to process.
        myIni.Filename = My.Application.Info.DirectoryPath & "\vars.ini"         ' current ini path in relax app


        Dim oLst As New List(Of String)
        'Check if ini loaded.
        If myIni.LoadFromFile() Then
            'Read a value name.


            'read start times
            startin1 = myIni.ReadString("time", "startin1")
            startin2 = myIni.ReadString("time", "startin2")
            startin3 = myIni.ReadString("time", "startin3")


            'read paths
            FilePathUbix = myIni.ReadString("path", "FilePathUbix")
            FilePathClient = myIni.ReadString("path", "FilePathClient")
            FilePathClientOut = myIni.ReadString("path", "FilePathClientOut")



            'read removing files

            removepath1 = myIni.ReadString("remove", "path1")
            removepath2 = myIni.ReadString("remove", "path2")
            removepath3 = myIni.ReadString("remove", "path3")
            removepath4 = myIni.ReadString("remove", "path4")
            removepath5 = myIni.ReadString("remove", "path5")



            If removepath1 = "" Then removepath1 = "0"
            If removepath2 = "" Then removepath2 = "0"
            If removepath3 = "" Then removepath3 = "0"
            If removepath4 = "" Then removepath4 = "0"
            If removepath5 = "" Then removepath5 = "0"


        End If

    End Sub

    Private Function filechk(filename As String)
         projdir = My.Application.Info.DirectoryPath & "\" & filename
        If File.Exists(projdir) = False Then
            MsgBox("RELAX need some files to runing correctly but  " & projdir & " not found in current dir.Please copy this file to current project dir and run it again.RELAX terminated by now.", vbCritical, "File not found")
        

            End
        End If
            projdir =""
           End Function


    Private function chktsclient (ext As string)

       Dim  tspath = projdir &  FilePathClient 
           Dim paths() As String = IO.Directory.GetFiles(tspath  , "*." & ext )
            If paths.Length > 0 Then
                chktsclient = True            '      MsgBox ("file   fond")

                Else 
                    chktsclient = False      '    MsgBox ("file nis")
             end if 
            End function


     Private function chktssrv (ext As string)

       Dim  tspath =   FilePathUbix  
           Dim paths() As String = IO.Directory.GetFiles(tspath  , "*." & ext )
            If paths.Length > 0 Then
                chktssrv = True            '      MsgBox ("file   fond")

                Else 
                    chktssrv = False      '    MsgBox ("file nis")
             end if 
            End function



   Private  Function delfile(fname As String )

        Try
            Directory.Delete(fname, True)
  
            Dim directoryExists = Directory.Exists(fname)

         '   MsgBox ("top-level directory exists: " & directoryExists)
        Catch e As Exception
        '   MsgBox("The process failed: {0}" &  e.Message)
        End Try


    End Function

End Class
