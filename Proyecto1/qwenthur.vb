Public Class qwenthur
    Dim hana As String
    Dim inaho As Integer
    Dim enkidu(7) As String
    Public Function Execute(ByVal n1 As Integer, ByVal n2 As Integer, ByVal op As String) As Integer
        Dim exe As Integer
        Select Case op
            Case "+"
                exe = n1 + n2
            Case "-"
                exe = n1 - n2
            Case "*"
                exe = n1 * n2
            Case "/"
                If (n2 <> 0) Then
                    exe = n1 / n2
                End If
        End Select
        Return exe
    End Function

    Public Function Re_execute(ByVal n1 As Integer, ByVal n2 As Integer, ByVal op As String) As Integer
        Dim re_exe As Integer
        re_exe = 0
        Select Case op
            Case "+"
                re_exe = n1 - n2
            Case "-"
                re_exe = n1 + n2
            Case "*"
                re_exe = n1 / n2
            Case "/"
                If (n2 <> 0) Then
                    re_exe = n1 * n2
                End If
        End Select
        Return re_exe
    End Function
    Public Function Natsume(ByVal a1 As Integer, ByVal a2 As Integer, ByVal a3 As Integer, ByVal a4 As Integer) As Integer
        Dim havia As Integer
        Dim barbatos(3) As Integer
        Dim inaho As Integer
        inaho = 1
        havia = a1
        hana = a1.ToString()
        barbatos(0) = a2
        barbatos(1) = a3
        barbatos(2) = a4
        enkidu(0) = a1.ToString
        enkidu(2) = a2.ToString
        enkidu(4) = a3.ToString
        enkidu(6) = a4.ToString
        Dim mk As Integer
        Dim rdm As Random = New Random()
        Dim magnum As Integer
        For mk = 0 To 2
            magnum = rdm.Next(1, 5)
            Select Case magnum
                Case 1
                    havia = havia + barbatos(mk)
                    hana = hana + "+" + barbatos(mk).ToString()
                    enkidu(inaho) = "+"
                Case 2
                    havia = havia - barbatos(mk)
                    hana = hana + "-" + barbatos(mk).ToString()
                    enkidu(inaho) = "-"
                Case 3
                    havia = havia * barbatos(mk)
                    hana = hana + "*" + barbatos(mk).ToString()
                    enkidu(inaho) = "*"
                Case 4
                    havia = havia / barbatos(mk)
                    hana = hana + "/" + barbatos(mk).ToString()
                    enkidu(inaho) = "/"
            End Select
            inaho = inaho + 2

        Next
        Return havia
    End Function
    Public Function completar()
        hana = hana
        Return hana
    End Function
    Public Function ea()
        enkidu = enkidu
        Return enkidu
    End Function

End Class
