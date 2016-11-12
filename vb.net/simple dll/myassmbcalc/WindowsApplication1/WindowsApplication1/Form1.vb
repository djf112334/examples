

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
   
       Dim aa As New mycl
             
       mycl.tst (" hi.this is a test from class .","my title here ")


      
         MsgBox (   ( mycl.div ( 5,3)))
        
    End Sub
End Class
