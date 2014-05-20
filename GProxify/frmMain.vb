Public Class frmMain
    Dim configurator As String()()
    Public selectedServer As String
    Public selectedProxy As String
    Public serverString As String
    Private Sub btnServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServer.Click
        frmSelectServer.ShowDialog()

    End Sub

    Private Sub ChangeServerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeServerToolStripMenuItem.Click
        frmSelectServer.ShowDialog()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath + "\w3l.exe") Then
            For Each a As Control In Me.Controls
                a.Enabled = False
            Next
            lblNotice.Visible = True
            lblNotice.Enabled = True
            mnMenu.Enabled = True
            ChangeServerToolStripMenuItem.Visible = False
            ChangeGProxyVersionToolStripMenuItem.Visible = False
        End If
        Dim ls As String = Application.StartupPath + "\config.ini"
        configurator = ReadINI(ls)
        If Not configurator Is Nothing Then
            selectedServer = GetOptionValue(configurator, "SELECTED_SERVER")
            selectedProxy = GetOptionValue(configurator, "SELECTED_PROXY")
            Dim cont As String()() = ReadINI(Application.StartupPath + "\serverlist\" + GetOptionValue(configurator, "SELECTED_SERVER") + ".lst")
            lblServer.Text = "Server Name : " + GetOptionValue(cont, "SERVER_NAME")
            serverString = GetOptionValue(cont, "IP")
            lblAddress.Text = "Server Address : " + serverString
            lblDesc.Text = "Description : " + GetOptionValue(cont, "DESC")
            lblGProxy.Text = "GProxy Selected : " + GetOptionValue(configurator, "SELECTED_PROXY")
        Else
            btnLaunch.Enabled = False
            IniModule.InitializeContainment(configurator)
            IniModule.InitArrayValue(configurator)
        End If

        'IniModule.InitArrayValue(configurator)
    End Sub

    Private Sub btnGproxy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGproxy.Click
        frmSelectGProxy.ShowDialog()
    End Sub

    Private Sub ChangeGProxyVersionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeGProxyVersionToolStripMenuItem.Click
        frmSelectGProxy.ShowDialog()
    End Sub

    Private Sub btnLaunch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaunch.Click
        SaveConfigurationToolStripMenuItem_Click(Me, Nothing)
        Dim gproxycfg As String = _
            "bnet_hostname = " + serverString + vbNewLine + _
            "game_port = 6125" + vbNewLine + _
        "game_indicator = [CB]"
        My.Computer.FileSystem.WriteAllText(
            Application.StartupPath + "\gproxy\" + selectedProxy + "\gproxy.cfg",
            gproxycfg, False, System.Text.ASCIIEncoding.ASCII)
        My.Computer.FileSystem.WriteAllText(
            Application.StartupPath + "\gproxy.cfg",
            gproxycfg, False, System.Text.ASCIIEncoding.ASCII)
        Threading.Thread.Sleep(500)
        Me.Hide()
        Shell(Application.StartupPath + "\gproxy\" + selectedProxy + "\gproxy.exe", AppWinStyle.MinimizedNoFocus, False)
        Threading.Thread.Sleep(1000)
        Shell(Application.StartupPath + "\w3l.exe", AppWinStyle.NormalFocus, False)
        End
    End Sub

    Private Sub SaveConfigurationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveConfigurationToolStripMenuItem.Click
        SetOptionValue(configurator, "SELECTED_SERVER", selectedServer)
        SetOptionValue(configurator, "SELECTED_PROXY", selectedProxy)
        WriteINI(Application.StartupPath + "\config.ini", configurator)

    End Sub

    Private Sub ClearConfigurationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearConfigurationToolStripMenuItem.Click
        On Error Resume Next
        My.Computer.FileSystem.DeleteFile(Application.StartupPath + "\config.ini", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        btnLaunch.Enabled = False
        lblServer.Text = "Server Name : "
        lblDesc.Text = "Description : "
        lblGProxy.Text = "GProxy Selected : "
        lblAddress.Text = "Server Address : "
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub
End Class
