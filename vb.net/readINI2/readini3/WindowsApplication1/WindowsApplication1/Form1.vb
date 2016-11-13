Public Class Form1

    Private myIni As cIniFile

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Create ini object.
        myIni = New cIniFile()
        'File to process.
        myIni.Filename = "o:\test00.ini"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oLst As New List(Of String)

        'Check if ini loaded.
        If myIni.LoadFromFile() Then
            'Read a value name.
            
              MsgBox(myIni.ReadString("Test", "Name" ))
              MsgBox(myIni.ReadString("Test", "age" ))

              MsgBox(myIni.ReadString("inff", "name" ))


          
        Else
            Call MsgBox("INI Filenmae Not Found Opps.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
      
    End Sub
End Class
