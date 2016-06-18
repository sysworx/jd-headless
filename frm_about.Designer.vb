<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_about
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_about))
        Me.pb_icon = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_versiontext = New System.Windows.Forms.Label()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.lbl_copyright = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_website = New System.Windows.Forms.LinkLabel()
        Me.lbl_licence = New System.Windows.Forms.Label()
        Me.lbl_cc = New System.Windows.Forms.LinkLabel()
        Me.rtb_licence = New System.Windows.Forms.RichTextBox()
        Me.btn_close = New System.Windows.Forms.Button()
        CType(Me.pb_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_icon
        '
        Me.pb_icon.Image = Global.jd_headless.My.Resources.Resources.icon_jdownloader_128
        Me.pb_icon.Location = New System.Drawing.Point(12, 12)
        Me.pb_icon.Name = "pb_icon"
        Me.pb_icon.Size = New System.Drawing.Size(128, 128)
        Me.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_icon.TabIndex = 0
        Me.pb_icon.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(146, 12)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(300, 55)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "JD-Headless"
        '
        'lbl_versiontext
        '
        Me.lbl_versiontext.AutoSize = True
        Me.lbl_versiontext.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_versiontext.Location = New System.Drawing.Point(153, 67)
        Me.lbl_versiontext.Name = "lbl_versiontext"
        Me.lbl_versiontext.Size = New System.Drawing.Size(65, 18)
        Me.lbl_versiontext.TabIndex = 2
        Me.lbl_versiontext.Text = "Version:"
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_version.Location = New System.Drawing.Point(224, 67)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(56, 18)
        Me.lbl_version.TabIndex = 3
        Me.lbl_version.Text = "0.0.0.0"
        '
        'lbl_copyright
        '
        Me.lbl_copyright.AutoSize = True
        Me.lbl_copyright.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_copyright.Location = New System.Drawing.Point(153, 85)
        Me.lbl_copyright.Name = "lbl_copyright"
        Me.lbl_copyright.Size = New System.Drawing.Size(241, 18)
        Me.lbl_copyright.TabIndex = 4
        Me.lbl_copyright.Text = "Copyright (C) Sys-worX.net, 2016"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Web:"
        '
        'lbl_website
        '
        Me.lbl_website.AutoSize = True
        Me.lbl_website.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_website.Location = New System.Drawing.Point(215, 121)
        Me.lbl_website.Name = "lbl_website"
        Me.lbl_website.Size = New System.Drawing.Size(129, 18)
        Me.lbl_website.TabIndex = 6
        Me.lbl_website.TabStop = True
        Me.lbl_website.Text = "www.sys-worx.net"
        '
        'lbl_licence
        '
        Me.lbl_licence.AutoSize = True
        Me.lbl_licence.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_licence.Location = New System.Drawing.Point(153, 103)
        Me.lbl_licence.Name = "lbl_licence"
        Me.lbl_licence.Size = New System.Drawing.Size(56, 18)
        Me.lbl_licence.TabIndex = 7
        Me.lbl_licence.Text = "Lizenz:"
        '
        'lbl_cc
        '
        Me.lbl_cc.AutoSize = True
        Me.lbl_cc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cc.Location = New System.Drawing.Point(215, 103)
        Me.lbl_cc.Name = "lbl_cc"
        Me.lbl_cc.Size = New System.Drawing.Size(203, 18)
        Me.lbl_cc.TabIndex = 8
        Me.lbl_cc.TabStop = True
        Me.lbl_cc.Text = "Creative Commons <by-nd>"
        '
        'rtb_licence
        '
        Me.rtb_licence.BackColor = System.Drawing.Color.White
        Me.rtb_licence.Location = New System.Drawing.Point(12, 146)
        Me.rtb_licence.Name = "rtb_licence"
        Me.rtb_licence.ReadOnly = True
        Me.rtb_licence.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtb_licence.Size = New System.Drawing.Size(511, 220)
        Me.rtb_licence.TabIndex = 9
        Me.rtb_licence.Text = resources.GetString("rtb_licence.Text")
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(232, 372)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 10
        Me.btn_close.Text = "Ok"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'frm_about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(535, 407)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.rtb_licence)
        Me.Controls.Add(Me.lbl_cc)
        Me.Controls.Add(Me.lbl_licence)
        Me.Controls.Add(Me.lbl_website)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_copyright)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.lbl_versiontext)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pb_icon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_about"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About JD-Headless"
        CType(Me.pb_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_icon As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_versiontext As Label
    Friend WithEvents lbl_version As Label
    Friend WithEvents lbl_copyright As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_website As LinkLabel
    Friend WithEvents lbl_licence As Label
    Friend WithEvents lbl_cc As LinkLabel
    Friend WithEvents rtb_licence As RichTextBox
    Friend WithEvents btn_close As Button
End Class
