Imports System.Math

Public Class ParentForm
	Dim controlshown As Boolean
	Dim BallXVelocity As Integer
	Dim BallYVelocity As Integer
	Dim gametype As Byte
	Dim RightPadelDirection As Char
	Dim LeftPadelDirection As Char
	Dim PlayerOneScore As Integer
	Dim PlayerTwoScore As Integer
	Dim ballstartpos As System.Drawing.Point
	Dim difficulty As Byte
	Dim target As Integer
	Dim check As Boolean
	Dim bounces As Integer

	Private Sub AlignComponents()
		Titlelbl.Left = (Me.Width / 2) - 150
		OneplayerStartbtn.Left = Titlelbl.Left + 58
		TwoPlayerStartbtn.Left = Titlelbl.Left + 58
		ControlsBtn.Left = Titlelbl.Left + 58
		Controlslbl.Left = Titlelbl.Left - 156
		GamePanel.Top = 0
		GamePanel.Left = 0
		GamePanel.Size = Me.Size
		CenterLine.X1 = (Me.Width / 2) - 20
		CenterLine.X2 = CenterLine.X1
		CenterLine.Y1 = 0
		CenterLine.Y2 = Me.Height
		LeftScoreLbl.Left = CenterLine.X1 - 100
		RightScoreLbl.Left = CenterLine.X1 + 100 - RightScoreLbl.Width

		LeftScoreZone.Height = Me.Height
		LeftScoreZone.Top = 0
		LeftScoreZone.Left = 0
		RightScoreZone.Height = Me.Height
		RightScoreZone.Top = 0
		RightScoreZone.Left = Me.Width - 40
		TopBorder.Top = 0
		TopBorder.Left = 0
		TopBorder.Width = Me.Width
		BottomBorder.Left = 0
		BottomBorder.Top = Me.Height - 45
		BottomBorder.Width = Me.Width
		RightPadel.Left = RightScoreZone.Left - 15
		diffpanel.Left = OneplayerStartbtn.Left + 150
	End Sub

	Private Sub ParentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.WindowState = FormWindowState.Maximized
		AlignComponents()
		LeftPadel.Top = ((Me.Height / 2) \ 10) * 10
		RightPadel.Top = ((Me.Height / 2) \ 10) * 10
		Ball.Left = CenterLine.X1
		Ball.Top = (Me.Height / 2) - 20
		ballstartpos = Ball.Location
	End Sub

	Private Sub ControlsBtn_Click(sender As Object, e As EventArgs) Handles ControlsBtn.Click
		If controlshown = False Then
			Controlslbl.Show()
			controlshown = True
		Else
			Controlslbl.Hide()
			controlshown = False
		End If
	End Sub

	Private Sub FormResized(sender As Object, e As EventArgs) Handles MyBase.Resize
		AlignComponents()
	End Sub

	Private Sub PadelMovement(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
		If gametype = 1 Then
			If e.KeyData = Keys.Down Then
				RightPadelDirection = "D"
			ElseIf e.KeyData = Keys.Up Then
				RightPadelDirection = "U"
			End If
		ElseIf gametype = 2 Then
			If e.KeyData = Keys.M Then
				RightPadelDirection = "D"
			ElseIf e.KeyData = Keys.K Then
				RightPadelDirection = "U"
			End If
			If e.KeyData = Keys.W Then
				LeftPadelDirection = "U"
			ElseIf e.KeyData = Keys.S Then
				LeftPadelDirection = "D"
			End If
		End If
	End Sub

	Private Sub PadelStop(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
		If gametype = 1 Then
			If e.KeyData = Keys.Down Then
				RightPadelDirection = "S"
			ElseIf e.KeyData = Keys.Up Then
				RightPadelDirection = "S"
			End If
		ElseIf gametype = 2 Then
			If e.KeyData = Keys.K Then
				RightPadelDirection = "S"
			ElseIf e.KeyData = Keys.M Then
				RightPadelDirection = "S"
			End If
			If e.KeyData = Keys.W Then
				LeftPadelDirection = "S"
			ElseIf e.KeyData = Keys.S Then
				LeftPadelDirection = "S"
			End If
		End If
	End Sub

	Private Sub PadelMover_Tick(sender As Object, e As EventArgs) Handles PadelMover.Tick
		If gametype = 1 Then
			If RightPadelDirection = "U" And RightPadel.Top >= 20 Then
				RightPadel.Top -= 10
			ElseIf RightPadelDirection = "D" And RightPadel.Top <= BottomBorder.Top - 100 Then
				RightPadel.Top += 10
			End If
			check = True
		ElseIf gametype = 2 Then
			If LeftPadelDirection = "U" And LeftPadel.Top >= 20 Then
				LeftPadel.Top -= 10
			ElseIf LeftPadelDirection = "D" And LeftPadel.Top <= BottomBorder.Top - 100 Then
				LeftPadel.Top += 10
			End If
			If RightPadelDirection = "U" And RightPadel.Top >= 20 Then
				RightPadel.Top -= 10
			ElseIf RightPadelDirection = "D" And RightPadel.Top <= BottomBorder.Top - 100 Then
				RightPadel.Top += 10
			End If
		End If
		
	End Sub

	Private Sub TwoPlayerStartbtn_Click(sender As Object, e As EventArgs) Handles TwoPlayerStartbtn.Click
		gametype = 2
		GamePanel.Show()
		BallMover.Start()
		PadelMover.Start()
		BallXVelocity = 10
		BallYVelocity = 2
		LeftScoreLbl.Text = PlayerTwoScore
		RightScoreLbl.Text = PlayerOneScore
		Ball.Location = ballstartpos
	End Sub

	Private Sub BallMover_Tick(sender As Object, e As EventArgs) Handles BallMover.Tick
		

		If Ball.Bounds.IntersectsWith(TopBorder.Bounds) Or Ball.Bounds.IntersectsWith(BottomBorder.Bounds) Then
			My.Computer.Audio.Play(My.Resources.BorderHit, AudioPlayMode.Background)
			BallYVelocity *= -1
		End If


		If Ball.Bounds.IntersectsWith(RightPadel.Bounds) Then
			bounces += 1
			IncrementBounceSpeed()
			My.Computer.Audio.Play(My.Resources.PadelHit, AudioPlayMode.Background)
			Dim centerpos As Integer = RightPadel.Top - (RightPadel.Height / 2)
			If (Ball.Top) - (Ball.Height / 2) < centerpos + 5 And (Ball.Top) - (Ball.Height / 2) > centerpos Then
				BallXVelocity *= -2
				If BallYVelocity < 0 Then
					BallYVelocity = -1
				ElseIf BallYVelocity > 0 Then
					BallYVelocity = 1
				Else
					BallYVelocity = 0
				End If
			ElseIf (Ball.Top) - (Ball.Height / 2) > centerpos - 5 And (Ball.Top) - (Ball.Height / 2) < centerpos Then
				BallXVelocity *= -1.05

				If BallYVelocity < 0 Then
					BallYVelocity = -1
				ElseIf BallYVelocity > 0 Then
					BallYVelocity = 1
				End If
			Else
				BallXVelocity *= -1

			End If
		ElseIf Ball.Bounds.IntersectsWith(LeftPadel.Bounds) Then
			My.Computer.Audio.Play(My.Resources.PadelHit, AudioPlayMode.Background)
			bounces += 1
			Dim centerpos As Integer = LeftPadel.Top - (LeftPadel.Height / 2)
			If (Ball.Top) - (Ball.Height / 2) < centerpos + 5 And (Ball.Top) - (Ball.Height / 2) > centerpos Then
				BallXVelocity *= -1.05
				If BallYVelocity < 0 Then
					BallYVelocity = -1
				ElseIf BallYVelocity > 0 Then
					BallYVelocity = 1
				Else
					BallYVelocity = 0
				End If
			ElseIf (Ball.Top) - (Ball.Height / 2) > centerpos - 5 And (Ball.Top) - (Ball.Height / 2) < centerpos Then
				BallXVelocity *= -1.05
				If BallYVelocity < 0 Then
					BallYVelocity = -1
				ElseIf BallYVelocity > 0 Then
					BallYVelocity = 1
				End If
			Else
				BallXVelocity *= -1


			End If
		ElseIf Ball.Bounds.IntersectsWith(RightScoreZone.Bounds) Then
			My.Computer.Audio.Play(My.Resources.Score, AudioPlayMode.Background)
			bounces = 0
			PlayerTwoScore += 1
			LeftScoreLbl.Text = PlayerTwoScore
			Ball.Location = ballstartpos
			BallXVelocity = 10
			BallYVelocity = 3
			If PlayerTwoScore = 11 Then
				If gametype = 2 Then

					BallMover.Stop()
					PadelMover.Stop()
					GamePanel.Hide()
					PlayerTwoScore = 0
					PlayerOneScore = 0
					MsgBox("Player Two Wins!", MsgBoxStyle.OkOnly, "Game Over")
				Else

					BallMover.Stop()
					PadelMover.Stop()
					GamePanel.Hide()
					PlayerTwoScore = 0
					PlayerOneScore = 0
					MsgBox("CPU Wins!", MsgBoxStyle.OkOnly, "Game Over")
				End If
			End If
		ElseIf Ball.Bounds.IntersectsWith(LeftScoreZone.Bounds) Then
			My.Computer.Audio.Play(My.Resources.Score, AudioPlayMode.Background)
			bounces = 0
			PlayerOneScore += 1
			RightScoreLbl.Text = PlayerOneScore
			Ball.Location = ballstartpos
			BallXVelocity = -10
			BallYVelocity = 3
			If PlayerOneScore = 11 Then

				BallMover.Stop()
				PadelMover.Stop()
				GamePanel.Hide()
				PlayerTwoScore = 0
				PlayerOneScore = 0
				MsgBox("Player One Wins!", MsgBoxStyle.OkOnly, "Game Over")
			End If
		End If

		Ball.Left += BallXVelocity
		Ball.Top += BallYVelocity
	End Sub

	Private Sub IncrementBounceSpeed()
		If BallXVelocity > 0 Then
			BallXVelocity += 1
		Else
			BallXVelocity -= 1
		End If

		If bounces > 50 Then
			If BallYVelocity > 0 Then
				BallYVelocity += 1
			Else
				BallYVelocity -= 1
			End If
		End If
	End Sub
	Private Sub OneplayerStartbtn_Click(sender As Object, e As EventArgs) Handles OneplayerStartbtn.Click
		gametype = 1
		diffpanel.show()
	End Sub

	Private Sub Easybtn_Click(sender As Object, e As EventArgs) Handles Easybtn.Click
		GamePanel.Show()
		BallMover.Start()
		PadelMover.Start()
		diffpanel.Hide()
		BallXVelocity = 10
		BallYVelocity = 2
		LeftScoreLbl.Text = PlayerTwoScore
		RightScoreLbl.Text = PlayerOneScore
		Ball.Location = ballstartpos
		CpuMover.Start()
		difficulty = 1
		CpuMover.Interval = 50
	End Sub

	Private Sub Mediumbtn_Click(sender As Object, e As EventArgs) Handles Mediumbtn.Click
		GamePanel.Show()
		BallMover.Start()
		PadelMover.Start()
		diffpanel.Hide()
		BallXVelocity = 10
		BallYVelocity = 2
		LeftScoreLbl.Text = PlayerTwoScore
		RightScoreLbl.Text = PlayerOneScore
		Ball.Location = ballstartpos
		CpuMover.Start()
		difficulty = 2
		CpuMover.Interval = 40

	End Sub

	Private Sub Hardbtn_Click(sender As Object, e As EventArgs) Handles Hardbtn.Click
		GamePanel.Show()
		BallMover.Start()
		PadelMover.Start()
		diffpanel.Hide()
		BallXVelocity = 10
		BallYVelocity = 2
		LeftScoreLbl.Text = PlayerTwoScore
		RightScoreLbl.Text = PlayerOneScore
		Ball.Location = ballstartpos
		CpuMover.Start()
		difficulty = 3
		CpuMover.Interval = 20
	End Sub

	Private Sub Impossiblebtn_Click(sender As Object, e As EventArgs) Handles Impossiblebtn.Click
		GamePanel.Show()
		BallMover.Start()
		diffpanel.Hide()
		PadelMover.Start()
		BallXVelocity = 10
		BallYVelocity = 2
		LeftScoreLbl.Text = PlayerTwoScore
		RightScoreLbl.Text = PlayerOneScore
		Ball.Location = ballstartpos
		CpuMover.Start()
		difficulty = 4
		CpuMover.Interval = 1
	End Sub

	Private Sub CpuMover_Tick(sender As Object, e As EventArgs) Handles CpuMover.Tick
		target = Ball.Top
		target = (target \ 10) * 10
		checkcpudirection()

		If LeftPadelDirection = "U" And LeftPadel.Top >= 20 Then
			If difficulty = 4 Then
				LeftPadel.Top -= 4
			Else
				LeftPadel.Top -= 10
			End If

		Else
			If LeftPadelDirection = "D" And LeftPadel.Top <= BottomBorder.Top - 100 Then
				If difficulty = 4 Then
					LeftPadel.Top += 4
				Else
					LeftPadel.Top += 10
				End If

			End If
		End If

	End Sub

	Private Sub checkcpudirection()

		If target < LeftPadel.Top Then
			LeftPadelDirection = "U"
		ElseIf target > LeftPadel.Top + 100 Then
			LeftPadelDirection = "D"
		Else
			If BallYVelocity > 0 And target > LeftPadel.Top + 90 And target < LeftPadel.Top + 100 Then
				LeftPadelDirection = "D"
			End If

			If BallYVelocity < 0 And target < LeftPadel.Top + 10 And target > LeftPadel.Top Then
				LeftPadelDirection = "U"
			End If
		End If



	End Sub


End Class
