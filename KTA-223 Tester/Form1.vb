
Public Class Form1

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Try
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
            End If
            SerialPort1.PortName = "COM" & TextBox2.Text
            'SerialPort1.PortName = "COM6"
            SerialPort1.Open()
        Catch ex As Exception
            MsgBox("Error Opening " & SerialPort1.PortName)
        End Try
    End Sub
End Class