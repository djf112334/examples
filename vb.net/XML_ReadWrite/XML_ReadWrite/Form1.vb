
Imports System.Xml




Public Class Form1
   
    
     Dim curdir As String =  My.Application.Info.DirectoryPath
     Dim xmldir As String = curdir & "\MyXML.xml"
     Dim settings As New XmlWriterSettings()
    
        
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        REM ===========================WRITE ==========================
       
     settings.Indent = True
     Dim XmlWrt As XmlWriter = XmlWriter.Create(xmldir, settings)
        With XmlWrt
            .WriteStartDocument()
            .WriteComment("XML settings.")
            .WriteStartElement("configs")
            .WriteStartElement("tab_1")
            .WriteStartElement("FirstName")
             
            .WriteString(TextBox1.Text)
            .WriteEndElement()
            .WriteStartElement("LastName")
            .WriteString(TextBox2.Text)
            .WriteEndElement()
            .WriteStartElement("tel")
            .WriteString(TextBox3.Text)
            .WriteEndElement()
            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With
        MessageBox.Show("XML file saved.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       
        If (IO.File.Exists(xmldir)) Then
            Dim document As XmlReader = New XmlTextReader(xmldir)
             While (document.Read())
                Dim type = document.NodeType
                If (type = XmlNodeType.Element) Then
                     If (document.Name = "FirstName") Then
                         TextBox4.Text = document.ReadInnerXml.ToString()
                      End If
                            If (document.Name = "LastName") Then
                          TextBox5.Text = document.ReadInnerXml.ToString()
                            End If
                       If (document.Name = "tel") Then
                       TextBox6.Text = document.ReadInnerXml.ToString()
                    End If
                End If
            End While
            document.Close()
                  Else
            MessageBox.Show("The filename you selected was not found.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show(curdir)
        
    End Sub

                         
    
End Class


