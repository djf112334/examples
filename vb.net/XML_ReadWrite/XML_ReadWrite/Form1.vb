
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

            ' Write the Xml declaration.
            .WriteStartDocument()

            ' Write a comment.
            .WriteComment("XML settings.")

            ' Write the root element.
            .WriteStartElement("configs")

            ' Start our first person.
            .WriteStartElement("tab_1")

            ' The person nodes.

            .WriteStartElement("FirstName")
            REM .WriteString("akbar")
            .WriteString(TextBox1.Text)
            .WriteEndElement()

            .WriteStartElement("LastName")
            .WriteString(TextBox2.Text)
            .WriteEndElement()

            .WriteStartElement("tel")
            .WriteString(TextBox3.Text)
            .WriteEndElement()

            ' The end of this person.
            .WriteEndElement()

            ' Close the XmlTextWriter.
            .WriteEndDocument()
            .Close()

        End With

        MessageBox.Show("XML file saved.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'check if file myxml.xml is existing
        Dim curdir, xmldir As String
        curdir = My.Application.Info.DirectoryPath
        xmldir = curdir & "\MyXML.xml"

        If (IO.File.Exists(xmldir)) Then

            'create a new xmltextreader object
            'this is the object that we will loop and will be used to read the xml file
            Dim document As XmlReader = New XmlTextReader(xmldir)

            'loop through the xml file
            While (document.Read())

                Dim type = document.NodeType

                'if node type was element
                If (type = XmlNodeType.Element) Then

                    'if the loop found a <FirstName> tag
                    If (document.Name = "FirstName") Then

                        TextBox4.Text = document.ReadInnerXml.ToString()

                    End If

                    'if the loop found a <LastName tag
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


