
Public Class Form1

    Private Sub OpenPort(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOpenPort.Click
        Try
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
            End If
            SerialPort1.PortName = "COM" & TextBoxPort.Text
            SerialPort1.Open()
            'TODO:  change this button from opening a port to toggling the port open and closed
        Catch ex As Exception
            MsgBox("Error Opening " & SerialPort1.PortName)
        End Try
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class