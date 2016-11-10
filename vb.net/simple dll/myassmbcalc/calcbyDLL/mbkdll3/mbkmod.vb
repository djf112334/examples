
public Module mbkmod

   Public  Sub prn(txt As String)

        MsgBox (txt)

    End Sub
      Public  cx As Integer
       Public  function  lea(ax,bx)
          cx=(ax-bx)
        Return ( cx)
      End function
       Public  function  add(ax,bx)
          cx=(val (ax)+val (bx))
        Return ( cx)
      End function
       Public  function  div(ax,bx)
          cx=(ax/bx)
        Return ( cx)
      End function
  

    Public  function  mul(ax,bx)  
         
           cx=(ax*bx)
        Return (cx)
           
      End function

     Public  function  rst( )  
         cx=0
                Return (  cx)
         End function

       Public  function  fix(ax)
          Return( Math.Round (ax))

      End function


              

End Module
