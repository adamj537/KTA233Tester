Module Module1
    Public txNext As Boolean

    Public SorI As Byte
    'Declare Sub monitor(ByVal rxstr As String)
    Public Sub monitor(ByVal rxstr As String)
        Dim i As Integer, j As Integer
        Dim result As Integer
        Dim val1 As String, val2 As String, val3 As String
        Dim res(0 To 2) As Single
        Dim parse As Boolean

        'Text1.Text = rxstr
        If InStr(rxstr, " ") <> 0 Then
            val1 = Right(rxstr, Len(rxstr) - InStr(rxstr, " "))
            'Text2.Text = val1
            parse = True
        Else
            val1 = ""
            'Text2.Text = "none"
        End If
        If InStr(val1, " ") <> 0 Then
            val2 = Right(val1, Len(val1) - InStr(val1, " "))
            val1 = Left(val1, InStr(val1, " "))
            'Text2.Text = val1
            'Text3.Text = val2
        Else
            val2 = ""
            'Text3.Text = "none"
        End If
        If InStr(val2, " ") <> 0 Then
            val3 = Right(val2, Len(val2) - InStr(val2, " ")) & " "
            val2 = Left(val2, InStr(val2, " "))
            'Text2.Text = val1
            'Text3.Text = val2
        Else
            val3 = ""
            'Text3.Text = "none"
        End If
        If parse = True Then
            Select Case SorI
                Case 0 'Relay Status
                    result = Val(val1)
                    j = 1
                    For i = 1 To 8
                        If (result And j) = j Then
                            If i = 1 Then Form1.Button1.BackColor = Color.LawnGreen
                            If i = 2 Then Form1.Button2.BackColor = Color.LawnGreen
                            If i = 3 Then Form1.Button3.BackColor = Color.LawnGreen
                            If i = 4 Then Form1.Button4.BackColor = Color.LawnGreen
                            If i = 5 Then Form1.Button5.BackColor = Color.LawnGreen
                            If i = 6 Then Form1.Button6.BackColor = Color.LawnGreen
                            If i = 7 Then Form1.Button7.BackColor = Color.LawnGreen
                            If i = 8 Then Form1.Button8.BackColor = Color.LawnGreen
                            If i = 1 Then Form1.Button1.ForeColor = Color.Black
                            If i = 2 Then Form1.Button2.ForeColor = Color.Black
                            If i = 3 Then Form1.Button3.ForeColor = Color.Black
                            If i = 4 Then Form1.Button4.ForeColor = Color.Black
                            If i = 5 Then Form1.Button5.ForeColor = Color.Black
                            If i = 6 Then Form1.Button6.ForeColor = Color.Black
                            If i = 7 Then Form1.Button7.ForeColor = Color.Black
                            If i = 8 Then Form1.Button8.ForeColor = Color.Black
                        Else
                            If i = 1 Then Form1.Button1.BackColor = Color.Red
                            If i = 2 Then Form1.Button2.BackColor = Color.Red
                            If i = 3 Then Form1.Button3.BackColor = Color.Red
                            If i = 4 Then Form1.Button4.BackColor = Color.Red
                            If i = 5 Then Form1.Button5.BackColor = Color.Red
                            If i = 6 Then Form1.Button6.BackColor = Color.Red
                            If i = 7 Then Form1.Button7.BackColor = Color.Red
                            If i = 8 Then Form1.Button8.BackColor = Color.Red
                            If i = 1 Then Form1.Button1.ForeColor = Color.White
                            If i = 2 Then Form1.Button2.ForeColor = Color.White
                            If i = 3 Then Form1.Button3.ForeColor = Color.White
                            If i = 4 Then Form1.Button4.ForeColor = Color.White
                            If i = 5 Then Form1.Button5.ForeColor = Color.White
                            If i = 6 Then Form1.Button6.ForeColor = Color.White
                            If i = 7 Then Form1.Button7.ForeColor = Color.White
                            If i = 8 Then Form1.Button8.ForeColor = Color.White
                        End If
                        j = j * 2
                    Next i
                    If result = 255 Then
                        Form1.Button9.BackColor = Color.LawnGreen
                        Form1.Button9.ForeColor = Color.Black
                    Else
                        Form1.Button9.BackColor = Color.Red
                        Form1.Button9.ForeColor = Color.White
                    End If
                    If result = 0 Then
                        Form1.Button10.BackColor = Color.LawnGreen
                        Form1.Button10.ForeColor = Color.Black
                    Else
                        Form1.Button10.BackColor = Color.Red
                        Form1.Button10.ForeColor = Color.White
                    End If
                Case 1 'Input Status
                    result = Val(val1)
                    j = 1
                    For i = 1 To 4
                        If (result And j) = j Then
                            If i = 1 Then Form1.Panel1.BackColor = Color.LawnGreen
                            If i = 2 Then Form1.Panel2.BackColor = Color.LawnGreen
                            If i = 3 Then Form1.Panel3.BackColor = Color.LawnGreen
                            If i = 4 Then Form1.Panel4.BackColor = Color.LawnGreen
                        Else
                            If i = 1 Then Form1.Panel1.BackColor = Color.Red
                            If i = 2 Then Form1.Panel2.BackColor = Color.Red
                            If i = 3 Then Form1.Panel3.BackColor = Color.Red
                            If i = 4 Then Form1.Panel4.BackColor = Color.Red
                        End If
                        j = j * 2
                    Next i
                Case 2 'Analog Input
                    res(0) = Val(val1)
                    res(1) = Val(val2)
                    res(2) = Val(val3)
                    Form1.Label4.Text = Val(val1)
                    Form1.Label5.Text = Val(val2)
                    Form1.Label6.Text = Val(val3)
                    j = 1
                    Form1.ProgressBar1.Value = Val(val1)
                    Form1.ProgressBar2.Value = Val(val2)
                    Form1.ProgressBar3.Value = Val(val3)

                    'For i = 0 To 2
                    'Shape4(i).FillColor = vbGreen
                    'Shape4(i).Width = res(i) / 1023 * Shape3(i).Width
                    'Next i
            End Select


        End If

    End Sub

End Module
