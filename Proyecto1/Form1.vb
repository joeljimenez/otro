Friend Class Form
    Dim vTxt(4) As TextBox
    Dim vTxtOp(3) As TextBox
    Dim vTxtAll(7) As TextBox
    Dim vBtn(4) As Button
    Dim vBtnOp(4) As Button
    Dim control(4) As Integer
    Dim selum(7) As String
    Dim nx As Integer
    Dim Nivel As Integer
    Dim ayano As String
    Dim kazuma As String
    Dim resp As String
    Dim ck As Integer
    Dim n1 As Integer
    Dim n2 As Integer
    Dim n3 As Integer
    Dim n4 As Integer
    Dim cal As Integer
    Dim x As Integer
    Dim y As Integer
    Dim g As String
    Dim milinda As New qwenthur


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Label2.Text = "Label"
        ' Add any initialization after the InitializeComponent() call.
        vTxt(0) = tnum1
        vTxt(1) = tnum2
        vTxt(2) = tnum3
        vTxt(3) = tnum4

        vTxtOp(0) = tsig1
        vTxtOp(1) = tsig2
        vTxtOp(2) = tsig3

        vTxtAll = New TextBox() {tnum1, tsig1, tnum2, tsig2, tnum3, tsig3, tnum4}


        vBtn = New Button() {num1, num2, num3, num4}
        vBtnOp = New Button() {opsum, opmin, Button7, opdiv}
        For c = 0 To 3
            vBtnOp(c).Enabled = False
        Next
        For d = 0 To 3
            vBtn(d).Enabled = False
        Next
        n1 = 0
        n2 = 0
        Button1.Tag = "0"
        Label2.Text = "0"
        btnSig.Tag = "0"
        btnResolver.Enabled = "False"
        Nivel = 0
        nx = 60
        Olimpo()
        btnSig.Enabled = False
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles tsig2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tnum2.TextChanged
        cal = 0
        If (tnum2.Text <> "") Then
            x = Int32.Parse(tnum1.Text)
            y = Int32.Parse(tnum2.Text)
            g = tsig1.Text
            cal = milinda.Execute(x, y, g)
            Label2.Text = cal
        Else
            Label2.Text = tnum1.Text
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Start()
        Button8.Enabled = False
        nx = 60
        Nivel = 0
    End Sub

    Public Sub Llenar(ByVal n As Integer)
        n3 = n1
        Button1.Tag = "0"
        btnSig.Tag = "0"
        If (n1 <= 3) Then
            vTxt(n1).Text = vBtn(n).Text
            vTxt(n1).Tag = n
            bloq_num()
            n1 = n1 + 1
            ck = ck + 1
        Else
            n1 = 3
            n3 = n1
        End If
    End Sub

    Public Sub Llenar2(ByVal q As Integer)
        n4 = n2
        If (n2 <= 2) Then
            vTxtOp(n2).Text = vBtnOp(q).Text
            n2 = n2 + 1
            ck = ck + 1
        Else
            n2 = 2
            n4 = n2
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles opsum.Click
        Llenar2(0)
        bloquear()
    End Sub

    Private Sub num1_Click(sender As Object, e As EventArgs) Handles num1.Click
        Llenar(0)
        vBtn(0).Tag = 0
        desbloquear_op()
    End Sub
    Private Sub num2_Click(sender As Object, e As EventArgs) Handles num2.Click
        Llenar(1)
        vBtn(1).Tag = 1
        desbloquear_op()
    End Sub

    Private Sub num3_Click(sender As Object, e As EventArgs) Handles num3.Click
        Llenar(2)
        vBtn(2).Tag = 2
        desbloquear_op()
    End Sub

    Private Sub num4_Click(sender As Object, e As EventArgs) Handles num4.Click
        Llenar(3)
        vBtn(3).Tag = 3
        desbloquear_op()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Llenar2(2)
        bloquear()
    End Sub

    Private Sub opmin_Click(sender As Object, e As EventArgs) Handles opmin.Click
        Llenar2(1)
        bloquear()
    End Sub

    Private Sub opdiv_Click(sender As Object, e As EventArgs) Handles opdiv.Click
        Llenar2(3)
        bloquear()
    End Sub

    Public Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        borrar_arc()
    End Sub

    Sub bloquear()
        Dim k As Integer
        For k = 0 To 3
            If vBtn(k).Tag = "5" Then
                vBtn(k).Enabled = True
            End If
        Next
        For k = 0 To 3
            vBtnOp(k).Enabled = False
        Next
    End Sub

    Sub desbloquear_op()
        Dim i As Integer
        For i = 0 To 3
            vBtnOp(i).Enabled = True
        Next

    End Sub

    Sub bloq_num()
        Dim f As Integer
        For f = 0 To 3
            vBtn(f).Enabled = False
        Next
    End Sub
    Sub desbloq_num()
        Dim f As Integer
        For f = 0 To 3
            If (vBtn(f).Tag = "5") Then
                vBtn(f).Enabled = True
            End If

        Next
    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub tnum3_TextChanged(sender As Object, e As EventArgs) Handles tnum3.TextChanged
        enviar()
    End Sub

    Private Sub tnum4_TextChanged(sender As Object, e As EventArgs) Handles tnum4.TextChanged
        enviar()
    End Sub
    Public Sub enviar()
        If (btnSig.Tag = "0" And Button8.Enabled = False) Then
            If (Button1.Tag = "0") Then
                If (btnResolver.Tag = "0") Then
                    If (vTxt(n1).Text <> "") Then
                        x = cal
                        y = Int32.Parse(vTxt(n1).Text)
                        g = vTxtOp(n2 - 1).Text
                        cal = milinda.Execute(x, y, g)
                        Label2.Text = cal
                    Else
                        cal = milinda.Re_execute(cal, y, g)
                        y = Int32.Parse(vTxt(n3).Text)
                        g = vTxtOp(n4 - 1).Text
                        Label2.Text = cal
                    End If
                End If
            End If
        End If
    End Sub
    Public Sub bloquear_op()
        For k = 0 To 3
            vBtnOp(k).Enabled = False
        Next
    End Sub

    Private Sub tnum1_TextChanged(sender As Object, e As EventArgs) Handles tnum1.TextChanged
        If (tnum1.Text <> "") Then
            Label2.Text = tnum1.Text
        Else
            Label2.Text = "0"
        End If
    End Sub

    Private Sub res_TextChanged(sender As Object, e As EventArgs) Handles res.TextChanged

    End Sub
    Public Sub Aldnoah()
        Dim rnd As Random = New Random
        Dim i, j As Integer
        Dim tmp As String
        Dim iota As Integer
        Dim delta As Integer
        Dim kappa As Integer
        Dim gamma As Integer
        Dim uk As Integer
        For uk = 0 To 3
            control(uk) = Int32.Parse(vBtn(uk).Text)
        Next
        For i = 0 To 2
            j = rnd.Next(0, 3)
            tmp = control(i)
            control(i) = control(j)
            control(j) = tmp
        Next
        iota = control(0)
        delta = control(1)
        kappa = control(2)
        gamma = control(3)
        resp = milinda.Natsume(iota, delta, kappa, gamma)
        res.Text = resp
        kazuma = milinda.completar()
        Label3.Text = kazuma
    End Sub
    Public Sub bankai()
        Dim ay As Integer
        ayano = vTxtAll(0).Text
        If tnum4.Text <> "" Then
            For ay = 1 To 6
                ayano = ayano + vTxtAll(ay).Text
            Next
        Else
            MessageBox.Show("Complete primero las casillas")
        End If
    End Sub
    Private Sub btnResolver_Click(sender As Object, e As EventArgs) Handles btnResolver.Click
        btnResolver.Tag = "1"
        '' bankai()
        selum = milinda.ea()
        Dim p As Integer
        For p = 0 To 6
            vTxtAll(p).Text = selum(p)
        Next
        Label3.Text = kazuma
        Label2.Text = resp
        reboot()
        Timer1.Stop()
        Olimpo()
        btnSig.Enabled = True
    End Sub
    Public Sub reboot()
        For i = 0 To 3
            vBtn(i).Text = ""
            vBtn(i).Tag = "5"
            vBtn(i).Enabled = False
        Next
        n1 = 0
        n2 = 0
        ck = 0
        bloquear_op()
    End Sub
    Public Sub todo_v()
        Dim i As Integer
        For i = 0 To 7
            borrar_arc()
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        todo_v()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (nx > 0) Then
            nx = nx - 1
            Label4.Text = nx
        Else
            Timer1.Stop()
            zero()
        End If
    End Sub
    Public Sub Start()
        Dim lm As Integer
        n1 = 0
        n2 = 0
        ck = 0

        btnSig.Enabled = False
        For lm = 0 To 6
            vTxtAll(lm).Text = ""
        Next
        Dim i As Integer
        Dim rdm As Random = New Random()
        For i = 0 To 3
            vBtn(i).Text = rdm.Next(1, 20)
            vBtn(i).Tag = "5"
            vBtn(i).Enabled = True
        Next
        btnResolver.Tag = "0"
        Button1.Tag = "0"
        Aldnoah()
        Olimpo2()
        Timer1.Enabled = True
    End Sub
    Public Sub end_of_days()
        bankai()
        If (ayano = kazuma) Then
            Timer1.Stop()
            nx = nx + 40
            Nivel = Nivel + 1
            btnSig.Enabled = True
            Olimpo()
            btnResolver.Enabled = False
            Label6.Text = "Ecuación Correcta"
            reboot()
        End If
    End Sub
    Public Sub borrar_arc()
        If ((ck - 1) <= 6 And ck > 0) Then
            If ((vTxtAll(ck - 1).Text = vTxt(n3).Text)) Then
                For h = 0 To 3
                    If ((vTxtAll(ck - 1).Text) = (vBtn(h).Text) And (vTxt(n3).Tag = vBtn(h).Tag)) Then
                        vBtn(h).Tag = "5"
                        desbloq_num()
                        bloquear_op()
                    End If
                Next
                n1 = n3
                n3 = n3 - 1
                ck = ck - 1
                vTxt(n3 + 1).Clear()
            ElseIf ((vTxtAll(ck - 1).Text = vTxtOp(n4).Text)) Then
                n2 = n4
                n4 = n4 - 1
                ck = ck - 1
                vTxtOp(n4 + 1).Clear()
                bloq_num()
                desbloquear_op()
            End If
        End If
    End Sub
    Public Sub Olimpo()
        Button1.Enabled = False
        borrar.Enabled = False
        btnVer.Enabled = False
    End Sub
    Public Sub Olimpo2()
        Button1.Enabled = True
        borrar.Enabled = True
        btnVer.Enabled = True
        btnResolver.Enabled = True
    End Sub
    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        end_of_days()
    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click
        btnSig.Tag = "1"
        Label6.Text = ""
        Start()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            Label3.Visible = True
        Else
            Label3.Visible = False
        End If
    End Sub
    Public Sub zero()
        If (nx = 0) Then
            MessageBox.Show("El tiempo se acabo")
            reboot()
            Olimpo()
            Nivel = 0
            btnResolver.Enabled = False
            btnSig.Enabled = False
            Button8.Enabled = True
        End If
    End Sub
End Class
