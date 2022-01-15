Imports System.ComponentModel

Public Class Form1

	Dim drag As Boolean
	Dim mousex As Integer
	Dim mousey As Integer
	Public result As Integer
	Public iconView As Boolean = True

	Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
		If drag Then
			Me.Top = Windows.Forms.Cursor.Position.Y - mousey
			Me.Left = Windows.Forms.Cursor.Position.X - mousex
		End If
	End Sub

	Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
		drag = True 'Sets the variable drag to true.
		mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
		mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
	End Sub

	Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
		drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
	End Sub

	Private Sub Label5_Click(sender As Object, e As EventArgs) _
		Handles Label5.Click
		Form2.Show()
		Me.Enabled = False
	End Sub

	Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) _
		Handles Label5.MouseEnter
		Label5.Image = Bitmap.FromFile("C:\Users\ahmad\Downloads\cancel2.png")
		Label5.BackColor = Color.LightSteelBlue
		Label5.ForeColor = Color.Tomato
	End Sub

	Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) _
		Handles Label5.MouseLeave
		Label5.Image = Bitmap.FromFile("C:\Users\ahmad\Downloads\cancel.png")
		Label5.ForeColor = Color.Black
		Label5.BackColor = Color.DodgerBlue

	End Sub

	Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) _
		Handles Label5.MouseDown
		Label5.Image = Bitmap.FromFile("C:\Users\ahmad\Downloads\cancel.png")
		Label5.ForeColor = Color.DarkRed

	End Sub

	Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) _
		Handles Label5.MouseUp
		Label5.ForeColor = Color.Black
	End Sub

	Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) _
		Handles Label4.MouseEnter
		Label4.BackColor = Color.DodgerBlue
		Label4.ForeColor = Color.Black
	End Sub

	Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) _
		Handles Label4.MouseLeave
		Label4.BackColor = Color.Gray
		Label4.ForeColor = Color.White

	End Sub

	Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) _
		Handles Label4.MouseDown
		Label4.ForeColor = Color.Black

		Label4.BackColor = Color.Blue
	End Sub

	Private Sub Label4_MouseUp(sender As Object, e As MouseEventArgs) _
		Handles Label4.MouseUp
		Label4.BackColor = Color.DodgerBlue
		Label4.ForeColor = Color.Black

	End Sub

	Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

		submit()
	End Sub

	Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

	End Sub

	Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

	End Sub
	Private Sub submit()
		If TextBox1.Text = "" Then
			TextBox1.Select()
		ElseIf TextBox2.Text = "" Then
			TextBox2.Select()
		Else
			If TextBox1.Text = "ahmadalashtar" And TextBox2.Text = "0000" Then
				MsgBox("Welcome back!")
			Else
				MsgBox("Invalid password or username.")
			End If
		End If

	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

	End Sub

	Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
		TextBox1.SelectAll()
	End Sub

	Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
		TextBox2.SelectAll()
	End Sub

	Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing



	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

		Me.StartPosition = FormStartPosition.CenterScreen
	End Sub

	Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
		If e.KeyCode = Keys.Enter Then
			submit()
		End If
	End Sub

	Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

	End Sub

	Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
		Label7.BackColor = Color.DarkOrange
	End Sub

	Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
		Label7.BackColor = Color.White
	End Sub

	Private Sub Label7_MouseClick(sender As Object, e As MouseEventArgs) Handles Label7.MouseClick
		If iconView Then
			Label7.Image = Bitmap.FromFile("C:\Users\ahmad\Downloads\hide.png")
			iconView = False
			TextBox2.PasswordChar = ""
		Else
			Label7.Image = Bitmap.FromFile("C:\Users\ahmad\Downloads\view.png")
			iconView = True
			TextBox2.PasswordChar = "*"
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs)

	End Sub
End Class
