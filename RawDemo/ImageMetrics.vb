Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Imports Atalasoft.Imaging.Codec
Namespace RawDemo
	''' <summary>
	''' Summary description for ImageMetrics.
	''' </summary>
	Public Class ImageMetrics : Inherits System.Windows.Forms.Form
		Private _decoder As RawDecoder
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private WithEvents buttonOk As System.Windows.Forms.Button
		Private WithEvents buttonCancel As System.Windows.Forms.Button
		Private textBoxBrightness As System.Windows.Forms.TextBox
		Private textBoxRed As System.Windows.Forms.TextBox
		Private textBoxBlue As System.Windows.Forms.TextBox
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Public Sub New(ByVal decoder As RawDecoder)
			_decoder = decoder
			InitializeComponent()

			textBoxBrightness.Text = _decoder.Brightness.ToString()
			textBoxRed.Text = _decoder.RedAberration.ToString()
			textBoxBlue.Text = _decoder.BlueAberration.ToString()
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.buttonOk = New System.Windows.Forms.Button()
			Me.buttonCancel = New System.Windows.Forms.Button()
			Me.textBoxBrightness = New System.Windows.Forms.TextBox()
			Me.textBoxRed = New System.Windows.Forms.TextBox()
			Me.textBoxBlue = New System.Windows.Forms.TextBox()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(8, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(80, 24)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Brightness"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(8, 32)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(80, 24)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Red Aberration"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(8, 56)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(88, 24)
			Me.label3.TabIndex = 2
			Me.label3.Text = "Blue Aberration"
			' 
			' buttonOk
			' 
			Me.buttonOk.Location = New System.Drawing.Point(176, 80)
			Me.buttonOk.Name = "buttonOk"
			Me.buttonOk.Size = New System.Drawing.Size(104, 32)
			Me.buttonOk.TabIndex = 3
			Me.buttonOk.Text = "Ok"
'			Me.buttonOk.Click += New System.EventHandler(Me.buttonOk_Click);
			' 
			' buttonCancel
			' 
			Me.buttonCancel.Location = New System.Drawing.Point(8, 80)
			Me.buttonCancel.Name = "buttonCancel"
			Me.buttonCancel.Size = New System.Drawing.Size(104, 32)
			Me.buttonCancel.TabIndex = 4
			Me.buttonCancel.Text = "Cancel"
'			Me.buttonCancel.Click += New System.EventHandler(Me.buttonCancel_Click);
			' 
			' textBoxBrightness
			' 
			Me.textBoxBrightness.Cursor = System.Windows.Forms.Cursors.Default
			Me.textBoxBrightness.Location = New System.Drawing.Point(96, 8)
			Me.textBoxBrightness.Name = "textBoxBrightness"
			Me.textBoxBrightness.Size = New System.Drawing.Size(184, 20)
			Me.textBoxBrightness.TabIndex = 5
			Me.textBoxBrightness.Text = ""
			' 
			' textBoxRed
			' 
			Me.textBoxRed.Location = New System.Drawing.Point(96, 32)
			Me.textBoxRed.Name = "textBoxRed"
			Me.textBoxRed.Size = New System.Drawing.Size(184, 20)
			Me.textBoxRed.TabIndex = 6
			Me.textBoxRed.Text = ""
			' 
			' textBoxBlue
			' 
			Me.textBoxBlue.Location = New System.Drawing.Point(96, 56)
			Me.textBoxBlue.Name = "textBoxBlue"
			Me.textBoxBlue.Size = New System.Drawing.Size(184, 20)
			Me.textBoxBlue.TabIndex = 7
			Me.textBoxBlue.Text = ""
			' 
			' ImageMetrics
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(292, 114)
			Me.Controls.Add(Me.textBoxBlue)
			Me.Controls.Add(Me.textBoxRed)
			Me.Controls.Add(Me.textBoxBrightness)
			Me.Controls.Add(Me.buttonCancel)
			Me.Controls.Add(Me.buttonOk)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Name = "ImageMetrics"
			Me.Text = "ImageMetrics"
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub buttonCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonCancel.Click
			Me.Close()
		End Sub

		Private Sub buttonOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonOk.Click
			_decoder.Brightness = Double.Parse(textBoxBrightness.Text)
			_decoder.RedAberration = Double.Parse(textBoxRed.Text)
			_decoder.BlueAberration = Double.Parse(textBoxBlue.Text)

			Me.Close()
		End Sub


	End Class
End Namespace
