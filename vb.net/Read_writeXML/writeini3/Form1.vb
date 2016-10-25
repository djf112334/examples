Imports System.Security.Cryptography.X509Certificates
Imports System.Xml
Imports System.IO
Imports System.Text




Public Class Form1


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'first let's check if there is a file MyXML.xml into our application folder
        'if there wasn't a file something like that, then let's create a new one.

        If IO.File.Exists("MyXML.xml") = False Then

            'declare our xmlwritersettings object
            Dim settings As New XmlWriterSettings()

            'lets tell to our xmlwritersettings that it must use indention for our xml
            settings.Indent = True

            'lets create the MyXML.xml document, the first parameter was the Path/filename of xml file
            ' the second parameter was our xml settings
            Dim XmlWrt As XmlWriter = XmlWriter.Create("o:\MyXML.xml", settings)

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
                .WriteString("akbar")
                .WriteEndElement()

                .WriteStartElement("LastName")
                .WriteString("alizadeh")
                .WriteEndElement()

                .WriteStartElement("tel")
                .WriteString("23589963")
                .WriteEndElement()


                ' The end of this person.
                .WriteEndElement()

                ' Close the XmlTextWriter.
                .WriteEndDocument()
                .Close()

            End With

            MessageBox.Show("XML file saved.")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        'check if file myxml.xml is existing
        If (IO.File.Exists("o:\MyXML.xml")) Then

            'create a new xmltextreader object
            'this is the object that we will loop and will be used to read the xml file
            Dim document As XmlReader = New XmlTextReader("o:\MyXML.xml")

            'loop through the xml file
            While (document.Read())

                Dim type = document.NodeType

                'if node type was element
                If (type = XmlNodeType.Element) Then

                    'if the loop found a <FirstName> tag
                    If (document.Name = "FirstName") Then

                        TextBox1.Text = document.ReadInnerXml.ToString()

                    End If

                    'if the loop found a <LastName tag
                    If (document.Name = "LastName") Then

                        TextBox2.Text = document.ReadInnerXml.ToString()

                    End If
                    If (document.Name = "tel") Then

                        TextBox3.Text = document.ReadInnerXml.ToString()

                    End If

                End If

            End While

        Else

            MessageBox.Show("The filename you selected was not found.")
        End If

    End Sub
End Class


