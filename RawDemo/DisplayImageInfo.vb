Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Imports Atalasoft.Imaging.Codec

Namespace RawDemo
	''' <summary>
	''' Summary description for DisplayImageInfo.
	''' </summary>
	Public Class DisplayImageInfo : Inherits System.Windows.Forms.Form
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private groupBoxCameraInfo As System.Windows.Forms.GroupBox
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private groupBoxRawImageInfo As System.Windows.Forms.GroupBox
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private groupBoxImageInfo As System.Windows.Forms.GroupBox
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
		Private textBoxIIColorDepth As System.Windows.Forms.TextBox
		Private textBoxIIFrameCount As System.Windows.Forms.TextBox
		Private textBoxIIImageType As System.Windows.Forms.TextBox
		Private textBoxIIPixelFormat As System.Windows.Forms.TextBox
		Private textBoxIIResolution As System.Windows.Forms.TextBox
		Private textBoxIISize As System.Windows.Forms.TextBox
		Private textBoxRIDataSize As System.Windows.Forms.TextBox
		Private textBoxRIImageSize As System.Windows.Forms.TextBox
		Private textBoxCIDataSize As System.Windows.Forms.TextBox
		Private textBoxCIMake As System.Windows.Forms.TextBox
		Private textBoxCIModel As System.Windows.Forms.TextBox
		Private textBoxCIModelExt As System.Windows.Forms.TextBox
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

		Public Sub New(ByVal info As ImageInfo)
			InitializeComponent()

			Dim rawInfo As RawImageInfo = CType(IIf(TypeOf info Is RawImageInfo, info, Nothing), RawImageInfo)
			Dim camInfo As CameraInfo = rawInfo.CameraInfo

			textBoxIIColorDepth.Text = info.ColorDepth.ToString()
			textBoxIIFrameCount.Text = info.FrameCount.ToString()
			textBoxIIImageType.Text = info.ImageType.ToString()
			textBoxIIPixelFormat.Text = info.PixelFormat.ToString()
			textBoxIIResolution.Text = info.Resolution.ToString()
			textBoxIISize.Text = info.Size.ToString()

			textBoxRIImageSize.Text = rawInfo.RawImageSize.ToString()
			textBoxRIDataSize.Text = rawInfo.DataSize.ToString()

			textBoxCIDataSize.Text = camInfo.DataSize.ToString()
			textBoxCIMake.Text = camInfo.Make.ToString()
			textBoxCIModel.Text = camInfo.Model.ToString()
			textBoxCIModelExt.Text = camInfo.ModelExtended.ToString()
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
			Me.textBoxRIDataSize = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.textBoxRIImageSize = New System.Windows.Forms.TextBox()
			Me.groupBoxRawImageInfo = New System.Windows.Forms.GroupBox()
			Me.groupBoxCameraInfo = New System.Windows.Forms.GroupBox()
			Me.textBoxCIModelExt = New System.Windows.Forms.TextBox()
			Me.textBoxCIModel = New System.Windows.Forms.TextBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.textBoxCIDataSize = New System.Windows.Forms.TextBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.textBoxCIMake = New System.Windows.Forms.TextBox()
			Me.groupBoxImageInfo = New System.Windows.Forms.GroupBox()
			Me.textBoxIISize = New System.Windows.Forms.TextBox()
			Me.textBoxIIResolution = New System.Windows.Forms.TextBox()
			Me.textBoxIIPixelFormat = New System.Windows.Forms.TextBox()
			Me.textBoxIIImageType = New System.Windows.Forms.TextBox()
			Me.textBoxIIFrameCount = New System.Windows.Forms.TextBox()
			Me.textBoxIIColorDepth = New System.Windows.Forms.TextBox()
			Me.label12 = New System.Windows.Forms.Label()
			Me.label11 = New System.Windows.Forms.Label()
			Me.label10 = New System.Windows.Forms.Label()
			Me.label9 = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.groupBoxRawImageInfo.SuspendLayout()
			Me.groupBoxCameraInfo.SuspendLayout()
			Me.groupBoxImageInfo.SuspendLayout()
			Me.SuspendLayout()
			' 
			' textBoxRIDataSize
			' 
			Me.textBoxRIDataSize.Location = New System.Drawing.Point(80, 16)
			Me.textBoxRIDataSize.Name = "textBoxRIDataSize"
			Me.textBoxRIDataSize.Size = New System.Drawing.Size(176, 20)
			Me.textBoxRIDataSize.TabIndex = 0
			Me.textBoxRIDataSize.Text = ""
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(8, 16)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(64, 24)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Data Size:"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(8, 40)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(64, 24)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Image Size:"
			' 
			' textBoxRIImageSize
			' 
			Me.textBoxRIImageSize.Location = New System.Drawing.Point(80, 40)
			Me.textBoxRIImageSize.Name = "textBoxRIImageSize"
			Me.textBoxRIImageSize.Size = New System.Drawing.Size(176, 20)
			Me.textBoxRIImageSize.TabIndex = 3
			Me.textBoxRIImageSize.Text = ""
			' 
			' groupBoxRawImageInfo
			' 
			Me.groupBoxRawImageInfo.Controls.Add(Me.label1)
			Me.groupBoxRawImageInfo.Controls.Add(Me.textBoxRIDataSize)
			Me.groupBoxRawImageInfo.Controls.Add(Me.label2)
			Me.groupBoxRawImageInfo.Controls.Add(Me.textBoxRIImageSize)
			Me.groupBoxRawImageInfo.Location = New System.Drawing.Point(8, 8)
			Me.groupBoxRawImageInfo.Name = "groupBoxRawImageInfo"
			Me.groupBoxRawImageInfo.Size = New System.Drawing.Size(264, 72)
			Me.groupBoxRawImageInfo.TabIndex = 4
			Me.groupBoxRawImageInfo.TabStop = False
			Me.groupBoxRawImageInfo.Text = "RawImageInfo"
			' 
			' groupBoxCameraInfo
			' 
			Me.groupBoxCameraInfo.Controls.Add(Me.textBoxCIModelExt)
			Me.groupBoxCameraInfo.Controls.Add(Me.textBoxCIModel)
			Me.groupBoxCameraInfo.Controls.Add(Me.label6)
			Me.groupBoxCameraInfo.Controls.Add(Me.label5)
			Me.groupBoxCameraInfo.Controls.Add(Me.label3)
			Me.groupBoxCameraInfo.Controls.Add(Me.textBoxCIDataSize)
			Me.groupBoxCameraInfo.Controls.Add(Me.label4)
			Me.groupBoxCameraInfo.Controls.Add(Me.textBoxCIMake)
			Me.groupBoxCameraInfo.Location = New System.Drawing.Point(8, 88)
			Me.groupBoxCameraInfo.Name = "groupBoxCameraInfo"
			Me.groupBoxCameraInfo.Size = New System.Drawing.Size(264, 120)
			Me.groupBoxCameraInfo.TabIndex = 5
			Me.groupBoxCameraInfo.TabStop = False
			Me.groupBoxCameraInfo.Text = "CameraInfo"
			' 
			' textBoxCIModelExt
			' 
			Me.textBoxCIModelExt.Location = New System.Drawing.Point(80, 88)
			Me.textBoxCIModelExt.Name = "textBoxCIModelExt"
			Me.textBoxCIModelExt.Size = New System.Drawing.Size(176, 20)
			Me.textBoxCIModelExt.TabIndex = 7
			Me.textBoxCIModelExt.Text = ""
			' 
			' textBoxCIModel
			' 
			Me.textBoxCIModel.Location = New System.Drawing.Point(80, 64)
			Me.textBoxCIModel.Name = "textBoxCIModel"
			Me.textBoxCIModel.Size = New System.Drawing.Size(176, 20)
			Me.textBoxCIModel.TabIndex = 6
			Me.textBoxCIModel.Text = ""
			' 
			' label6
			' 
			Me.label6.Location = New System.Drawing.Point(8, 88)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(64, 24)
			Me.label6.TabIndex = 5
			Me.label6.Text = "Model Ext:"
			' 
			' label5
			' 
			Me.label5.Location = New System.Drawing.Point(8, 64)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(64, 24)
			Me.label5.TabIndex = 4
			Me.label5.Text = "Model:"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(8, 16)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(64, 24)
			Me.label3.TabIndex = 1
			Me.label3.Text = "Data Size:"
			' 
			' textBoxCIDataSize
			' 
			Me.textBoxCIDataSize.Location = New System.Drawing.Point(80, 16)
			Me.textBoxCIDataSize.Name = "textBoxCIDataSize"
			Me.textBoxCIDataSize.Size = New System.Drawing.Size(176, 20)
			Me.textBoxCIDataSize.TabIndex = 0
			Me.textBoxCIDataSize.Text = ""
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(8, 40)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(64, 24)
			Me.label4.TabIndex = 2
			Me.label4.Text = "Make:"
			' 
			' textBoxCIMake
			' 
			Me.textBoxCIMake.Location = New System.Drawing.Point(80, 40)
			Me.textBoxCIMake.Name = "textBoxCIMake"
			Me.textBoxCIMake.Size = New System.Drawing.Size(176, 20)
			Me.textBoxCIMake.TabIndex = 3
			Me.textBoxCIMake.Text = ""
			' 
			' groupBoxImageInfo
			' 
			Me.groupBoxImageInfo.Controls.Add(Me.textBoxIISize)
			Me.groupBoxImageInfo.Controls.Add(Me.textBoxIIResolution)
			Me.groupBoxImageInfo.Controls.Add(Me.textBoxIIPixelFormat)
			Me.groupBoxImageInfo.Controls.Add(Me.textBoxIIImageType)
			Me.groupBoxImageInfo.Controls.Add(Me.textBoxIIFrameCount)
			Me.groupBoxImageInfo.Controls.Add(Me.textBoxIIColorDepth)
			Me.groupBoxImageInfo.Controls.Add(Me.label12)
			Me.groupBoxImageInfo.Controls.Add(Me.label11)
			Me.groupBoxImageInfo.Controls.Add(Me.label10)
			Me.groupBoxImageInfo.Controls.Add(Me.label9)
			Me.groupBoxImageInfo.Controls.Add(Me.label8)
			Me.groupBoxImageInfo.Controls.Add(Me.label7)
			Me.groupBoxImageInfo.Location = New System.Drawing.Point(8, 216)
			Me.groupBoxImageInfo.Name = "groupBoxImageInfo"
			Me.groupBoxImageInfo.Size = New System.Drawing.Size(264, 168)
			Me.groupBoxImageInfo.TabIndex = 6
			Me.groupBoxImageInfo.TabStop = False
			Me.groupBoxImageInfo.Text = "ImageInfo"
			' 
			' textBoxIISize
			' 
			Me.textBoxIISize.Location = New System.Drawing.Point(80, 136)
			Me.textBoxIISize.Name = "textBoxIISize"
			Me.textBoxIISize.Size = New System.Drawing.Size(176, 20)
			Me.textBoxIISize.TabIndex = 19
			Me.textBoxIISize.Text = ""
			' 
			' textBoxIIResolution
			' 
			Me.textBoxIIResolution.Location = New System.Drawing.Point(80, 112)
			Me.textBoxIIResolution.Name = "textBoxIIResolution"
			Me.textBoxIIResolution.Size = New System.Drawing.Size(176, 20)
			Me.textBoxIIResolution.TabIndex = 18
			Me.textBoxIIResolution.Text = ""
			' 
			' textBoxIIPixelFormat
			' 
			Me.textBoxIIPixelFormat.Location = New System.Drawing.Point(80, 88)
			Me.textBoxIIPixelFormat.Name = "textBoxIIPixelFormat"
			Me.textBoxIIPixelFormat.Size = New System.Drawing.Size(176, 20)
			Me.textBoxIIPixelFormat.TabIndex = 17
			Me.textBoxIIPixelFormat.Text = ""
			' 
			' textBoxIIImageType
			' 
			Me.textBoxIIImageType.Location = New System.Drawing.Point(80, 64)
			Me.textBoxIIImageType.Name = "textBoxIIImageType"
			Me.textBoxIIImageType.Size = New System.Drawing.Size(176, 20)
			Me.textBoxIIImageType.TabIndex = 16
			Me.textBoxIIImageType.Text = ""
			' 
			' textBoxIIFrameCount
			' 
			Me.textBoxIIFrameCount.Location = New System.Drawing.Point(80, 40)
			Me.textBoxIIFrameCount.Name = "textBoxIIFrameCount"
			Me.textBoxIIFrameCount.Size = New System.Drawing.Size(176, 20)
			Me.textBoxIIFrameCount.TabIndex = 15
			Me.textBoxIIFrameCount.Text = ""
			' 
			' textBoxIIColorDepth
			' 
			Me.textBoxIIColorDepth.Location = New System.Drawing.Point(80, 16)
			Me.textBoxIIColorDepth.Name = "textBoxIIColorDepth"
			Me.textBoxIIColorDepth.Size = New System.Drawing.Size(176, 20)
			Me.textBoxIIColorDepth.TabIndex = 14
			Me.textBoxIIColorDepth.Text = ""
			' 
			' label12
			' 
			Me.label12.Location = New System.Drawing.Point(8, 136)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(80, 24)
			Me.label12.TabIndex = 13
			Me.label12.Text = "Size:"
			' 
			' label11
			' 
			Me.label11.Location = New System.Drawing.Point(8, 112)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(80, 24)
			Me.label11.TabIndex = 12
			Me.label11.Text = "Resolution:"
			' 
			' label10
			' 
			Me.label10.Location = New System.Drawing.Point(8, 88)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(80, 24)
			Me.label10.TabIndex = 11
			Me.label10.Text = "Pixel Format:"
			' 
			' label9
			' 
			Me.label9.Location = New System.Drawing.Point(8, 64)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(80, 24)
			Me.label9.TabIndex = 10
			Me.label9.Text = "Image Type:"
			' 
			' label8
			' 
			Me.label8.Location = New System.Drawing.Point(8, 40)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(80, 24)
			Me.label8.TabIndex = 9
			Me.label8.Text = "Frame Count:"
			' 
			' label7
			' 
			Me.label7.Location = New System.Drawing.Point(8, 16)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(72, 24)
			Me.label7.TabIndex = 8
			Me.label7.Text = "Color Depth:"
			' 
			' DisplayImageInfo
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(280, 389)
			Me.Controls.Add(Me.groupBoxImageInfo)
			Me.Controls.Add(Me.groupBoxCameraInfo)
			Me.Controls.Add(Me.groupBoxRawImageInfo)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Name = "DisplayImageInfo"
			Me.Text = "DisplayImageInfo"
			Me.groupBoxRawImageInfo.ResumeLayout(False)
			Me.groupBoxCameraInfo.ResumeLayout(False)
			Me.groupBoxImageInfo.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region


	End Class
End Namespace
