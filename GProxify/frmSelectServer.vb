Public Class frmSelectServer
    Dim containment As String()()
    Private Sub frmSelectServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbServer.Items.Clear()
        ' make a reference to a directory
        Dim di As New IO.DirectoryInfo(Application.StartupPath + "\serverlist")
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo

        'list the names of all files in the specified directory
        For Each dra In diar1

            lbServer.Items.Add(dra.ToString.Substring(0, dra.ToString.Length - 4))
            If dra.ToString.Equals(frmMain.selectedServer + ".lst") Then
                lbServer.SelectedItems.Add(frmMain.selectedServer)
                'MessageBox.Show(dra.ToString + " " + frmMain.selectedServer)
            Else
                lbServer.SelectedItems.Add(lbServer.Items(0))
            End If
        Next
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        frmMain.btnLaunch.Enabled = True
        frmMain.lblServer.Text = "Server Name : " + GetOptionValue(containment, "SERVER_NAME")
        frmMain.lblAddress.Text = "Address : " + GetOptionValue(containment, "IP")
        frmMain.lblDesc.Text = "Description : " + GetOptionValue(containment, "DESC")
        frmMain.serverString = GetOptionValue(containment, "IP")
        frmMain.selectedServer = lbServer.SelectedItem()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lbServer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbServer.SelectedIndexChanged
        containment = ReadINI(Application.StartupPath + "\serverlist\" + lbServer.SelectedItem() + ".lst")
        lblServer.Text = "Server Name : " + GetOptionValue(containment, "SERVER_NAME")
        lblAddress.Text = "Address : " + GetOptionValue(containment, "IP")
        lblDesc.Text = "Description : " + GetOptionValue(containment, "DESC")

    End Sub
End Class