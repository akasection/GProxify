<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnServer = New System.Windows.Forms.Button()
        Me.btnGproxy = New System.Windows.Forms.Button()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.lblGProxy = New System.Windows.Forms.Label()
        Me.lblNotice = New System.Windows.Forms.Label()
        Me.mnMenu = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeGProxyVersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GProxify"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(8, 96)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 118)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(128, 96)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(94, 16)
        Me.lblServer.TabIndex = 3
        Me.lblServer.Text = "Server Name : "
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(128, 120)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(108, 16)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Server Address : "
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(128, 144)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(81, 16)
        Me.lblDesc.TabIndex = 5
        Me.lblDesc.Text = "Description :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(257, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "A Simple GUI-yet-Powerful GProxy Handler"
        '
        'btnServer
        '
        Me.btnServer.Location = New System.Drawing.Point(128, 192)
        Me.btnServer.Name = "btnServer"
        Me.btnServer.Size = New System.Drawing.Size(112, 24)
        Me.btnServer.TabIndex = 7
        Me.btnServer.Text = "Change Server..."
        Me.btnServer.UseVisualStyleBackColor = True
        '
        'btnGproxy
        '
        Me.btnGproxy.Location = New System.Drawing.Point(248, 192)
        Me.btnGproxy.Name = "btnGproxy"
        Me.btnGproxy.Size = New System.Drawing.Size(176, 24)
        Me.btnGproxy.TabIndex = 8
        Me.btnGproxy.Text = "Change GProxy Version...."
        Me.btnGproxy.UseVisualStyleBackColor = True
        '
        'btnLaunch
        '
        Me.btnLaunch.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaunch.Location = New System.Drawing.Point(296, 240)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(176, 32)
        Me.btnLaunch.TabIndex = 9
        Me.btnLaunch.Text = "Save and Launch"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'lblGProxy
        '
        Me.lblGProxy.AutoSize = True
        Me.lblGProxy.Location = New System.Drawing.Point(128, 168)
        Me.lblGProxy.Name = "lblGProxy"
        Me.lblGProxy.Size = New System.Drawing.Size(113, 16)
        Me.lblGProxy.TabIndex = 10
        Me.lblGProxy.Text = "GProxy Selected : "
        '
        'lblNotice
        '
        Me.lblNotice.AutoSize = True
        Me.lblNotice.ForeColor = System.Drawing.Color.Red
        Me.lblNotice.Location = New System.Drawing.Point(8, 256)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(275, 16)
        Me.lblNotice.TabIndex = 11
        Me.lblNotice.Text = "Warcraft III PvPGN Loader (w3l.exe) not found!"
        Me.lblNotice.Visible = False
        '
        'mnMenu
        '
        Me.mnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnMenu.Name = "mnMenu"
        Me.mnMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnMenu.Size = New System.Drawing.Size(477, 24)
        Me.mnMenu.TabIndex = 12
        Me.mnMenu.Text = "Menu"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeServerToolStripMenuItem, Me.ChangeGProxyVersionToolStripMenuItem, Me.ToolStripSeparator2, Me.ClearConfigurationToolStripMenuItem, Me.SaveConfigurationToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ChangeServerToolStripMenuItem
        '
        Me.ChangeServerToolStripMenuItem.Name = "ChangeServerToolStripMenuItem"
        Me.ChangeServerToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ChangeServerToolStripMenuItem.Text = "Change Server..."
        '
        'ChangeGProxyVersionToolStripMenuItem
        '
        Me.ChangeGProxyVersionToolStripMenuItem.Name = "ChangeGProxyVersionToolStripMenuItem"
        Me.ChangeGProxyVersionToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ChangeGProxyVersionToolStripMenuItem.Text = "Change GProxy Version..."
        '
        'SaveConfigurationToolStripMenuItem
        '
        Me.SaveConfigurationToolStripMenuItem.Name = "SaveConfigurationToolStripMenuItem"
        Me.SaveConfigurationToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SaveConfigurationToolStripMenuItem.Text = "Save Configuration"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(203, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ClearConfigurationToolStripMenuItem
        '
        Me.ClearConfigurationToolStripMenuItem.Name = "ClearConfigurationToolStripMenuItem"
        Me.ClearConfigurationToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ClearConfigurationToolStripMenuItem.Text = "Clear Configuration"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(203, 6)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(477, 279)
        Me.Controls.Add(Me.lblNotice)
        Me.Controls.Add(Me.lblGProxy)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.btnGproxy)
        Me.Controls.Add(Me.btnServer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnMenu)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnMenu
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "GProxify"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnMenu.ResumeLayout(False)
        Me.mnMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnServer As System.Windows.Forms.Button
    Friend WithEvents btnGproxy As System.Windows.Forms.Button
    Friend WithEvents btnLaunch As System.Windows.Forms.Button
    Friend WithEvents lblGProxy As System.Windows.Forms.Label
    Friend WithEvents lblNotice As System.Windows.Forms.Label
    Friend WithEvents mnMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeGProxyVersionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
