Public Class Form1
    Sub panelswitch(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub
End Class