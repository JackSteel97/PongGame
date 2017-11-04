<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentForm
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParentForm))
		Me.Titlelbl = New System.Windows.Forms.Label()
		Me.OneplayerStartbtn = New System.Windows.Forms.Button()
		Me.TwoPlayerStartbtn = New System.Windows.Forms.Button()
		Me.ControlsBtn = New System.Windows.Forms.Button()
		Me.Controlslbl = New System.Windows.Forms.Label()
		Me.GamePanel = New System.Windows.Forms.Panel()
		Me.BottomBorder = New System.Windows.Forms.Label()
		Me.TopBorder = New System.Windows.Forms.Label()
		Me.RightScoreZone = New System.Windows.Forms.Label()
		Me.LeftScoreZone = New System.Windows.Forms.Label()
		Me.RightPadel = New System.Windows.Forms.Label()
		Me.LeftPadel = New System.Windows.Forms.Label()
		Me.RightScoreLbl = New System.Windows.Forms.Label()
		Me.LeftScoreLbl = New System.Windows.Forms.Label()
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
		Me.Ball = New Microsoft.VisualBasic.PowerPacks.OvalShape()
		Me.CenterLine = New Microsoft.VisualBasic.PowerPacks.LineShape()
		Me.BallMover = New System.Windows.Forms.Timer(Me.components)
		Me.PadelMover = New System.Windows.Forms.Timer(Me.components)
		Me.diffpanel = New System.Windows.Forms.Panel()
		Me.Impossiblebtn = New System.Windows.Forms.Button()
		Me.Hardbtn = New System.Windows.Forms.Button()
		Me.Mediumbtn = New System.Windows.Forms.Button()
		Me.Easybtn = New System.Windows.Forms.Button()
		Me.CpuMover = New System.Windows.Forms.Timer(Me.components)
		Me.GamePanel.SuspendLayout()
		Me.diffpanel.SuspendLayout()
		Me.SuspendLayout()
		'
		'Titlelbl
		'
		Me.Titlelbl.AutoSize = True
		Me.Titlelbl.Font = New System.Drawing.Font("OCR A Std", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Titlelbl.ForeColor = System.Drawing.Color.White
		Me.Titlelbl.Location = New System.Drawing.Point(302, 33)
		Me.Titlelbl.Name = "Titlelbl"
		Me.Titlelbl.Size = New System.Drawing.Size(213, 68)
		Me.Titlelbl.TabIndex = 0
		Me.Titlelbl.Text = "PONG"
		'
		'OneplayerStartbtn
		'
		Me.OneplayerStartbtn.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.OneplayerStartbtn.Location = New System.Drawing.Point(361, 122)
		Me.OneplayerStartbtn.Name = "OneplayerStartbtn"
		Me.OneplayerStartbtn.Size = New System.Drawing.Size(105, 29)
		Me.OneplayerStartbtn.TabIndex = 1
		Me.OneplayerStartbtn.Text = "One Player Game"
		Me.OneplayerStartbtn.UseVisualStyleBackColor = True
		'
		'TwoPlayerStartbtn
		'
		Me.TwoPlayerStartbtn.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TwoPlayerStartbtn.Location = New System.Drawing.Point(361, 168)
		Me.TwoPlayerStartbtn.Name = "TwoPlayerStartbtn"
		Me.TwoPlayerStartbtn.Size = New System.Drawing.Size(105, 29)
		Me.TwoPlayerStartbtn.TabIndex = 2
		Me.TwoPlayerStartbtn.Text = "Two Player Game"
		Me.TwoPlayerStartbtn.UseVisualStyleBackColor = True
		'
		'ControlsBtn
		'
		Me.ControlsBtn.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ControlsBtn.Location = New System.Drawing.Point(361, 213)
		Me.ControlsBtn.Name = "ControlsBtn"
		Me.ControlsBtn.Size = New System.Drawing.Size(105, 29)
		Me.ControlsBtn.TabIndex = 3
		Me.ControlsBtn.Text = "View Controls"
		Me.ControlsBtn.UseVisualStyleBackColor = True
		'
		'Controlslbl
		'
		Me.Controlslbl.AutoSize = True
		Me.Controlslbl.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Controlslbl.ForeColor = System.Drawing.Color.White
		Me.Controlslbl.Location = New System.Drawing.Point(146, 256)
		Me.Controlslbl.Name = "Controlslbl"
		Me.Controlslbl.Size = New System.Drawing.Size(506, 286)
		Me.Controlslbl.TabIndex = 4
		Me.Controlslbl.Text = resources.GetString("Controlslbl.Text")
		Me.Controlslbl.Visible = False
		'
		'GamePanel
		'
		Me.GamePanel.Controls.Add(Me.BottomBorder)
		Me.GamePanel.Controls.Add(Me.TopBorder)
		Me.GamePanel.Controls.Add(Me.RightScoreZone)
		Me.GamePanel.Controls.Add(Me.LeftScoreZone)
		Me.GamePanel.Controls.Add(Me.RightPadel)
		Me.GamePanel.Controls.Add(Me.LeftPadel)
		Me.GamePanel.Controls.Add(Me.RightScoreLbl)
		Me.GamePanel.Controls.Add(Me.LeftScoreLbl)
		Me.GamePanel.Controls.Add(Me.ShapeContainer1)
		Me.GamePanel.Location = New System.Drawing.Point(12, 33)
		Me.GamePanel.Name = "GamePanel"
		Me.GamePanel.Size = New System.Drawing.Size(867, 569)
		Me.GamePanel.TabIndex = 5
		Me.GamePanel.Visible = False
		'
		'BottomBorder
		'
		Me.BottomBorder.BackColor = System.Drawing.Color.Black
		Me.BottomBorder.Location = New System.Drawing.Point(31, 557)
		Me.BottomBorder.Name = "BottomBorder"
		Me.BottomBorder.Size = New System.Drawing.Size(800, 10)
		Me.BottomBorder.TabIndex = 8
		'
		'TopBorder
		'
		Me.TopBorder.BackColor = System.Drawing.Color.Black
		Me.TopBorder.Location = New System.Drawing.Point(2, 3)
		Me.TopBorder.Name = "TopBorder"
		Me.TopBorder.Size = New System.Drawing.Size(800, 10)
		Me.TopBorder.TabIndex = 7
		'
		'RightScoreZone
		'
		Me.RightScoreZone.BackColor = System.Drawing.Color.Black
		Me.RightScoreZone.Location = New System.Drawing.Point(834, 0)
		Me.RightScoreZone.Name = "RightScoreZone"
		Me.RightScoreZone.Size = New System.Drawing.Size(25, 563)
		Me.RightScoreZone.TabIndex = 6
		'
		'LeftScoreZone
		'
		Me.LeftScoreZone.BackColor = System.Drawing.Color.Black
		Me.LeftScoreZone.Location = New System.Drawing.Point(0, 4)
		Me.LeftScoreZone.Name = "LeftScoreZone"
		Me.LeftScoreZone.Size = New System.Drawing.Size(25, 563)
		Me.LeftScoreZone.TabIndex = 5
		'
		'RightPadel
		'
		Me.RightPadel.BackColor = System.Drawing.Color.White
		Me.RightPadel.Location = New System.Drawing.Point(835, 155)
		Me.RightPadel.Name = "RightPadel"
		Me.RightPadel.Size = New System.Drawing.Size(10, 100)
		Me.RightPadel.TabIndex = 4
		'
		'LeftPadel
		'
		Me.LeftPadel.BackColor = System.Drawing.Color.White
		Me.LeftPadel.Location = New System.Drawing.Point(30, 4)
		Me.LeftPadel.Name = "LeftPadel"
		Me.LeftPadel.Size = New System.Drawing.Size(10, 100)
		Me.LeftPadel.TabIndex = 3
		'
		'RightScoreLbl
		'
		Me.RightScoreLbl.AutoSize = True
		Me.RightScoreLbl.Font = New System.Drawing.Font("OCR A Std", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RightScoreLbl.ForeColor = System.Drawing.Color.White
		Me.RightScoreLbl.Location = New System.Drawing.Point(492, 20)
		Me.RightScoreLbl.Name = "RightScoreLbl"
		Me.RightScoreLbl.Size = New System.Drawing.Size(42, 37)
		Me.RightScoreLbl.TabIndex = 2
		Me.RightScoreLbl.Text = "0"
		'
		'LeftScoreLbl
		'
		Me.LeftScoreLbl.AutoSize = True
		Me.LeftScoreLbl.Font = New System.Drawing.Font("OCR A Std", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LeftScoreLbl.ForeColor = System.Drawing.Color.White
		Me.LeftScoreLbl.Location = New System.Drawing.Point(332, 20)
		Me.LeftScoreLbl.Name = "LeftScoreLbl"
		Me.LeftScoreLbl.Size = New System.Drawing.Size(42, 37)
		Me.LeftScoreLbl.TabIndex = 1
		Me.LeftScoreLbl.Text = "0"
		'
		'ShapeContainer1
		'
		Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
		Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
		Me.ShapeContainer1.Name = "ShapeContainer1"
		Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Ball, Me.CenterLine})
		Me.ShapeContainer1.Size = New System.Drawing.Size(867, 569)
		Me.ShapeContainer1.TabIndex = 0
		Me.ShapeContainer1.TabStop = False
		'
		'Ball
		'
		Me.Ball.BackColor = System.Drawing.Color.White
		Me.Ball.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
		Me.Ball.FillColor = System.Drawing.Color.White
		Me.Ball.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
		Me.Ball.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
		Me.Ball.Location = New System.Drawing.Point(458, 198)
		Me.Ball.Name = "Ball"
		Me.Ball.Size = New System.Drawing.Size(20, 20)
		'
		'CenterLine
		'
		Me.CenterLine.BorderColor = System.Drawing.Color.White
		Me.CenterLine.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
		Me.CenterLine.BorderWidth = 3
		Me.CenterLine.Name = "CenterLine"
		Me.CenterLine.SelectionColor = System.Drawing.Color.White
		Me.CenterLine.X1 = 433
		Me.CenterLine.X2 = 431
		Me.CenterLine.Y1 = 3
		Me.CenterLine.Y2 = 566
		'
		'BallMover
		'
		Me.BallMover.Interval = 10
		'
		'PadelMover
		'
		Me.PadelMover.Interval = 10
		'
		'diffpanel
		'
		Me.diffpanel.Controls.Add(Me.Impossiblebtn)
		Me.diffpanel.Controls.Add(Me.Hardbtn)
		Me.diffpanel.Controls.Add(Me.Mediumbtn)
		Me.diffpanel.Controls.Add(Me.Easybtn)
		Me.diffpanel.Location = New System.Drawing.Point(486, 122)
		Me.diffpanel.Name = "diffpanel"
		Me.diffpanel.Size = New System.Drawing.Size(200, 100)
		Me.diffpanel.TabIndex = 6
		Me.diffpanel.Visible = False
		'
		'Impossiblebtn
		'
		Me.Impossiblebtn.Location = New System.Drawing.Point(107, 35)
		Me.Impossiblebtn.Name = "Impossiblebtn"
		Me.Impossiblebtn.Size = New System.Drawing.Size(75, 23)
		Me.Impossiblebtn.TabIndex = 3
		Me.Impossiblebtn.Text = "Impossible"
		Me.Impossiblebtn.UseVisualStyleBackColor = True
		'
		'Hardbtn
		'
		Me.Hardbtn.Location = New System.Drawing.Point(3, 64)
		Me.Hardbtn.Name = "Hardbtn"
		Me.Hardbtn.Size = New System.Drawing.Size(75, 23)
		Me.Hardbtn.TabIndex = 2
		Me.Hardbtn.Text = "Hard"
		Me.Hardbtn.UseVisualStyleBackColor = True
		'
		'Mediumbtn
		'
		Me.Mediumbtn.Location = New System.Drawing.Point(3, 35)
		Me.Mediumbtn.Name = "Mediumbtn"
		Me.Mediumbtn.Size = New System.Drawing.Size(75, 23)
		Me.Mediumbtn.TabIndex = 1
		Me.Mediumbtn.Text = "Medium"
		Me.Mediumbtn.UseVisualStyleBackColor = True
		'
		'Easybtn
		'
		Me.Easybtn.Location = New System.Drawing.Point(3, 6)
		Me.Easybtn.Name = "Easybtn"
		Me.Easybtn.Size = New System.Drawing.Size(75, 23)
		Me.Easybtn.TabIndex = 0
		Me.Easybtn.Text = "Easy"
		Me.Easybtn.UseVisualStyleBackColor = True
		'
		'CpuMover
		'
		'
		'ParentForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(892, 594)
		Me.Controls.Add(Me.diffpanel)
		Me.Controls.Add(Me.GamePanel)
		Me.Controls.Add(Me.Controlslbl)
		Me.Controls.Add(Me.ControlsBtn)
		Me.Controls.Add(Me.TwoPlayerStartbtn)
		Me.Controls.Add(Me.OneplayerStartbtn)
		Me.Controls.Add(Me.Titlelbl)
		Me.KeyPreview = True
		Me.Name = "ParentForm"
		Me.Text = "Pong"
		Me.GamePanel.ResumeLayout(False)
		Me.GamePanel.PerformLayout()
		Me.diffpanel.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Titlelbl As System.Windows.Forms.Label
	Friend WithEvents OneplayerStartbtn As System.Windows.Forms.Button
	Friend WithEvents TwoPlayerStartbtn As System.Windows.Forms.Button
	Friend WithEvents ControlsBtn As System.Windows.Forms.Button
	Friend WithEvents Controlslbl As System.Windows.Forms.Label
	Friend WithEvents GamePanel As System.Windows.Forms.Panel
	Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Friend WithEvents CenterLine As Microsoft.VisualBasic.PowerPacks.LineShape
	Friend WithEvents RightScoreLbl As System.Windows.Forms.Label
	Friend WithEvents LeftScoreLbl As System.Windows.Forms.Label
	Friend WithEvents LeftPadel As System.Windows.Forms.Label
	Friend WithEvents RightPadel As System.Windows.Forms.Label
	Friend WithEvents LeftScoreZone As System.Windows.Forms.Label
	Friend WithEvents RightScoreZone As System.Windows.Forms.Label
	Friend WithEvents TopBorder As System.Windows.Forms.Label
	Friend WithEvents BottomBorder As System.Windows.Forms.Label
	Friend WithEvents Ball As Microsoft.VisualBasic.PowerPacks.OvalShape
	Friend WithEvents BallMover As System.Windows.Forms.Timer
	Friend WithEvents PadelMover As System.Windows.Forms.Timer
	Friend WithEvents diffpanel As System.Windows.Forms.Panel
	Friend WithEvents Impossiblebtn As System.Windows.Forms.Button
	Friend WithEvents Hardbtn As System.Windows.Forms.Button
	Friend WithEvents Mediumbtn As System.Windows.Forms.Button
	Friend WithEvents Easybtn As System.Windows.Forms.Button
	Friend WithEvents CpuMover As System.Windows.Forms.Timer

End Class
