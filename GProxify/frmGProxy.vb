Public Class frmSelectGProxy

    Private Sub frmSelectGProxy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbServer.Items.Clear()
        ' make a reference to a directory
        Dim di As New IO.DirectoryInfo(Application.StartupPath + "\gproxy")
        Dim diar1() As IO.DirectoryInfo = di.GetDirectories()

        'list the names of all files in the specified directory
        For Each dra In diar1
            If My.Computer.FileSystem.FileExists(dra.FullName + "\gproxy.exe") Then
                lbServer.Items.Add(dra)
                lbServer.SelectedItems.Add(lbServer.Items(0))
            End If

        Next
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        frmMain.btnLaunch.Enabled = True
        frmMain.selectedProxy = lbServer.SelectedItem.ToString
        frmMain.lblGProxy.Text = "Selected GProxy : " + frmMain.selectedProxy
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class