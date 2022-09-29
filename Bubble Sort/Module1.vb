Module Module1
    Sub delay(ByVal dblsecs As Double)
        Const onesec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblwaittil As Date
        Now.AddSeconds(onesec)

        dblwaittil = Now.AddSeconds(onesec).AddSeconds(dblsecs)
        Do Until Now > dblwaittil
            Application.DoEvents()
        Loop
    End Sub
End Module
