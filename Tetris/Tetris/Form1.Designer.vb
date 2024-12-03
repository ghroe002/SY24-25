<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Avatar = New PictureBox()
        Timer1 = New Timer(components)
        FootballImage = New PictureBox()
        Enemy = New PictureBox()
        Enemy2 = New PictureBox()
        Enemy3 = New PictureBox()
        Platform = New PictureBox()
        ScoreLabel = New Label()
        PointsTimer = New Timer(components)
        PictureBox1 = New PictureBox()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(FootballImage, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(12, 12)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(157, 108)
        Avatar.SizeMode = PictureBoxSizeMode.StretchImage
        Avatar.TabIndex = 0
        Avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' FootballImage
        ' 
        FootballImage.Image = CType(resources.GetObject("FootballImage.Image"), Image)
        FootballImage.Location = New Point(680, 113)
        FootballImage.Name = "FootballImage"
        FootballImage.Size = New Size(108, 90)
        FootballImage.SizeMode = PictureBoxSizeMode.StretchImage
        FootballImage.TabIndex = 1
        FootballImage.TabStop = False
        FootballImage.Tag = "Football"
        ' 
        ' Enemy
        ' 
        Enemy.Image = CType(resources.GetObject("Enemy.Image"), Image)
        Enemy.Location = New Point(460, 715)
        Enemy.Name = "Enemy"
        Enemy.Size = New Size(146, 141)
        Enemy.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy.TabIndex = 2
        Enemy.TabStop = False
        Enemy.Tag = "1"
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), Image)
        Enemy2.Location = New Point(927, 506)
        Enemy2.Name = "Enemy2"
        Enemy2.Size = New Size(153, 145)
        Enemy2.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy2.TabIndex = 3
        Enemy2.TabStop = False
        ' 
        ' Enemy3
        ' 
        Enemy3.Image = CType(resources.GetObject("Enemy3.Image"), Image)
        Enemy3.Location = New Point(317, 291)
        Enemy3.Name = "Enemy3"
        Enemy3.Size = New Size(158, 130)
        Enemy3.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy3.TabIndex = 4
        Enemy3.TabStop = False
        ' 
        ' Platform
        ' 
        Platform.BackColor = Color.Transparent
        Platform.Location = New Point(394, 842)
        Platform.Name = "Platform"
        Platform.Size = New Size(270, 55)
        Platform.TabIndex = 5
        Platform.TabStop = False
        ' 
        ' ScoreLabel
        ' 
        ScoreLabel.AutoSize = True
        ScoreLabel.Location = New Point(439, 24)
        ScoreLabel.Name = "ScoreLabel"
        ScoreLabel.Size = New Size(0, 20)
        ScoreLabel.TabIndex = 6
        ' 
        ' PointsTimer
        ' 
        PointsTimer.Enabled = True
        PointsTimer.Interval = 1000
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Red
        PictureBox1.Location = New Point(287, 277)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(10, 166)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        PictureBox1.Tag = "Wall"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1732, 953)
        Controls.Add(PictureBox1)
        Controls.Add(ScoreLabel)
        Controls.Add(Platform)
        Controls.Add(Enemy3)
        Controls.Add(Enemy2)
        Controls.Add(Enemy)
        Controls.Add(FootballImage)
        Controls.Add(Avatar)
        Name = "Form1"
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(FootballImage, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FootballImage As PictureBox
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Enemy3 As PictureBox
    Friend WithEvents Platform As PictureBox
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents PointsTimer As Timer
    Friend WithEvents PictureBox1 As PictureBox

End Class
