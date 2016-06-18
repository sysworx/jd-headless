Option Strict On
Imports System.Threading
Imports System.IO

Public NotInheritable Class NotificationIcon
    Private Shared notifyIcon As NotifyIcon
    Private notificationMenu As ContextMenu
    Private Shared timeCounter As String
    Private Shared WithEvents timer As New System.Windows.Forms.Timer()
	Private Shared configFile As New IniFile
    Private Shared jdPath As String
    Private Shared jdp As New Process()
    Private Shared timed As Date
    Private Shared menu As MenuItem()

#Region "Initialize icon and menu"
    Public Sub New()
		notifyIcon = New NotifyIcon()
		notificationMenu = New ContextMenu(InitializeMenu())
        AddHandler notifyIcon.DoubleClick, AddressOf IconDoubleClick
        notifyIcon.Icon = My.Resources.icon_jdownloader_bw
        notifyIcon.ContextMenu = notificationMenu
	End Sub

	Private Function InitializeMenu() As MenuItem()
        menu = New MenuItem() {New MenuItem("About", AddressOf menuAboutClick), New MenuItem("-"), New MenuItem("Start Jdownloader", AddressOf menuJdStart), New MenuItem("Stop Jdownloader", AddressOf menuJdStop), New MenuItem("-"), New MenuItem("Exit", AddressOf menuExitClick)}
        Return menu
	End Function
	#End Region

	#Region "Main - Program entry point"
	<STAThread> _
	Public Shared Sub Main(args As String())
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        'NotifyIcon things
        Dim notificationIcon As New NotificationIcon()
        NotificationIcon.notifyIcon.Visible = True


        'load the config file
        configFile.Load(Application.StartupPath.ToString & "\jdh_config.ini")    
		jdPath = pCheck(configFile.GetKeyValue("Setup", "jdownloader_path"))
		
		'startup checks
		If jdPath = "Nothing" Then
			MessageBox.Show("Path to JDownloader not set in the config!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Application.[Exit]()
        End If

        If Not File.Exists(jdPath & "JDownloader2.exe") Then
            MessageBox.Show("JDownloader was not found in the configurated path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Application.[Exit]()
        End If

        'headless start (javaw -Djava.awt.headless=true -jar JDownloader.jar)
        jdp.StartInfo.FileName = jdPath & "jre/bin/javaw.exe"
        Debug.WriteLine("-Djava.awt.headless=true -jar """ & jdPath & "JDownloader.jar""")
        jdp.StartInfo.Arguments = "-Djava.awt.headless=true -jar """ & jdPath & "JDownloader.jar"""
        jdp.StartInfo.UseShellExecute = False
        jdp.StartInfo.RedirectStandardOutput = False
        jdp.StartInfo.CreateNoWindow = False
        jdp.StartInfo.WorkingDirectory = jdPath

        startJD()

        'Multiple instance protect
        Dim isFirstInstance As Boolean
        Using mtx As New Mutex(True, "jd_headless", isFirstInstance)
            If isFirstInstance Then
                Application.Run()
                NotificationIcon.notifyIcon.Dispose()
            Else
            End If
        End Using

    End Sub
#End Region

#Region "Event Handlers"

    Private Shared Sub startJD()
        jdp.Start()
        'prozess check
        If jdp.HasExited = False Then
            'seticon to color
            notifyIcon.Icon = My.Resources.icon_jdownloader
            'show baloontip
            notifyIcon.BalloonTipTitle = "JD Headless"
            notifyIcon.BalloonTipText = "Jdownloader was started in Headless-Mode!"
            notifyIcon.ShowBalloonTip(20000)
        End If

        'start checktimer
        timed = DateTime.Now.AddSeconds(10)
        timer.Start()
    End Sub


    Private Shared Sub timertick(ByVal myObject As Object, ByVal myEventArgs As EventArgs) Handles timer.Tick
        'timer code
        Dim tSpan As TimeSpan = timed - DateTime.Now.AddSeconds(-1)
        timeCounter = tSpan.Hours.ToString("00") & ":" & tSpan.Minutes.ToString("00") & ":" & tSpan.Seconds.ToString("00")
        Debug.WriteLine(timeCounter)

        If timeCounter = "00:00:00" Then
            timer.Stop()

            If jdp.HasExited = True Then
                'show baloontip
                notifyIcon.BalloonTipTitle = "JD Headless"
                notifyIcon.BalloonTipText = "Jdownloader was terminated somehow!"
                notifyIcon.ShowBalloonTip(0)
                notifyIcon.Icon = My.Resources.icon_jdownloader_bw
                Return
            End If

            timed = DateTime.Now.AddSeconds(10)
            timer.Start()

        End If

    End Sub

    Private Sub menuAboutClick(sender As Object, e As EventArgs)
        frm_about.Show()
    End Sub

	Private Sub menuExitClick(sender As Object, e As EventArgs)
        'JD close
        If jdp.HasExited = False Then
            jdp.Kill()
        End If
        Application.[Exit]()
    End Sub

    Private Sub menuJdStart(sender As Object, e As EventArgs)
        If jdp.HasExited = True Then
            startJD()
        Else
            notifyIcon.BalloonTipTitle = "JD Headless"
            notifyIcon.BalloonTipText = "Jdownloader is already started."
            notifyIcon.ShowBalloonTip(10000)
        End If

    End Sub

    Private Sub menuJdStop(sender As Object, e As EventArgs)
        'JD close
        If jdp.HasExited = False Then
            jdp.Kill()
            timer.Stop()
            'show baloontip
            notifyIcon.BalloonTipTitle = "JD Headless"
            notifyIcon.BalloonTipText = "Jdownloader has been shutdown!"
            notifyIcon.ShowBalloonTip(20000)
            notifyIcon.Icon = My.Resources.icon_jdownloader_bw
        End If
    End Sub

    Private Sub IconDoubleClick(sender As Object, e As EventArgs)

    End Sub

#End Region

End Class
