﻿
Public Class mycl

   
    shared Function tst(txx  As String )
        MsgBox (txx)
         End Function


    Shared function add (ax  ,bx)
     Dim cx
            cx=  Val (ax) + Val ( bx)
          Return (cx )
    End function
       Shared function mul (ax  ,bx)
     Dim cx
            cx=  Val (ax) * Val ( bx)
          Return (cx )
    End function
       Shared function lea (ax  ,bx)
     Dim cx
            cx=  Val (ax)- Val ( bx)
          Return (cx )
    End function
       Shared function div (ax  ,bx)
     Dim cx
            cx=  Val (ax) / Val ( bx)
          Return (cx )
    End function

 
End Class
