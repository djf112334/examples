Imports System
Imports System.Xml

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Now()
        'first let's check if there is a file MyXML.xml into our application folder
        'if there wasn't a file something like that, then let's create a new one.

        If IO.File.Exists("mbktest.xml") = False Then
            MessageBox.Show("no file ")

            'declare our xmlwritersettings object
            Dim settings As New XmlWriterSettings()
            'lets tell to our xmlwritersettings that it must use indention for our xml
            settings.Indent = True

            'lets create the MyXML.xml document, the first parameter was the Path/filename of xml file
            ' the second parameter was our xml settings
            Dim XmlWrt As XmlWriter = XmlWriter.Create("mbktest.xml", settings)
            With XmlWrt

                ' Write the Xml declaration.
                .WriteStartDocument()

                ' Write a comment.
                .WriteComment("XML Database.")

                ' Write the root element.
                .WriteStartElement("Data")

                ' Start our first person.
                .WriteStartElement("Person")

                ' The person nodes.

                .WriteStartElement("FirstName")
                .WriteString("Alleo")
                .WriteEndElement()

                .WriteStartElement("LastName")
                .WriteString("Indong")
                .WriteEndElement()


                ' The end of this person.
                .WriteEndElement()

                ' Close the XmlTextWriter.
                .WriteEndDocument()
                .Close()

            End With

            MessageBox.Show("XML file saved.")
        End If


        '---------------------------------------------------------------------------
        'check if file myxml.xml is existing
        If (IO.File.Exists("mbktest.xml")) Then

            'create a new xmltextreader object
            'this is the object that we will loop and will be used to read the xml file
            Dim document As XmlReader = New XmlTextReader("mbktest.xml")

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

                End If

            End While

        Else

            MessageBox.Show("The filename you selected was not found.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
