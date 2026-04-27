Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Reflection

Imports Atalasoft.Imaging
Imports Atalasoft.Imaging.Codec
Namespace RawDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private _decoder As RawDecoder
		Private _scaleFactor As Double = 0.5

		Private imageViewer1 As Atalasoft.Imaging.WinControls.ImageViewer
		Private mainMenu1 As System.Windows.Forms.MainMenu
		Private menuItemFile As System.Windows.Forms.MenuItem
		Private WithEvents menuItemOpen As System.Windows.Forms.MenuItem
		Private menuItemDecoder As System.Windows.Forms.MenuItem
		Private WithEvents menuItemOpenScaled As System.Windows.Forms.MenuItem
		Private menuItemInterpolation As System.Windows.Forms.MenuItem
		Private WithEvents menuItemOpenThumbnail As System.Windows.Forms.MenuItem
		Private WithEvents menuItemOpenPreview As System.Windows.Forms.MenuItem
		Private menuItemWhiteBalance As System.Windows.Forms.MenuItem
		Private menuItemLoadingPolicy As System.Windows.Forms.MenuItem
		Private WithEvents menuItemUseCameraMatrix As System.Windows.Forms.MenuItem
		Private statusBar1 As System.Windows.Forms.StatusBar
		Private progressBar1 As System.Windows.Forms.ProgressBar
		Private WithEvents menuItemSetImageMetrics As System.Windows.Forms.MenuItem
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
        Private WithEvents menuItemImageInfo As System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
        Friend WithEvents AboutMenuItem As System.Windows.Forms.MenuItem
        Private components As System.ComponentModel.IContainer
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            InitializeDecoder()
            InitializeMenus()
        End Sub

        Private Sub InitializeDecoder()
            _decoder = New RawDecoder()
            RegisteredDecoders.Decoders.Insert(0, _decoder)
        End Sub

        Private Sub InitializeMenus()
            'Populate LoadingPolicy
            populateMenu(menuItemLoadingPolicy, GetType(LoadingPolicy), New EventHandler(AddressOf Me.menuItemLoadingPolicy_Click))
            setDefaultMenuItem(menuItemLoadingPolicy, _decoder.Policy.ToString())

            'Populate Interpolation
            populateMenu(menuItemInterpolation, GetType(RawInterpolationMethods), New EventHandler(AddressOf Me.menuItemRawInterpolationMethods_Click))
            setDefaultMenuItem(menuItemInterpolation, _decoder.Interpolation.ToString())

            'Populate WhiteBalance
            populateMenu(menuItemWhiteBalance, GetType(RawWhiteBalanceMethods), New EventHandler(AddressOf Me.menuItemRawWhiteBalanceMethods_Click))
            setDefaultMenuItem(menuItemWhiteBalance, _decoder.WhiteBalance.ToString())

            'Set UseCameraMatrix MenuItem
            menuItemUseCameraMatrix.Checked = _decoder.UseCameraMatrix
        End Sub

        Private Sub setDefaultMenuItem(ByVal parent As MenuItem, ByVal selected As String)
            For Each item As MenuItem In parent.MenuItems
                If item.Text.Equals(selected) Then
                    item.Checked = True
                    Return
                End If
            Next item
        End Sub

        Private Sub populateMenu(ByVal baseItem As MenuItem, ByVal inType As Type, ByVal inEvent As EventHandler)
            For Each name As String In System.Enum.GetNames(inType)
                Dim newItem As MenuItem = New MenuItem(name)
                AddHandler newItem.Click, inEvent
                baseItem.MenuItems.Add(newItem)
            Next name

        End Sub

        Private Sub checkAndUncheckSiblings(ByVal selectedItem As MenuItem)
            For Each subItem As MenuItem In selectedItem.Parent.MenuItems
                subItem.Checked = False
            Next subItem

            selectedItem.Checked = True
        End Sub

        Private Sub menuItemLoadingPolicy_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim selectedItem As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)
            checkAndUncheckSiblings(selectedItem)

            _decoder.Policy = CType(System.Enum.Parse(GetType(LoadingPolicy), selectedItem.Text), LoadingPolicy)
        End Sub

        Private Sub menuItemRawInterpolationMethods_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim selectedItem As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)
            checkAndUncheckSiblings(selectedItem)

            _decoder.Interpolation = CType(System.Enum.Parse(GetType(RawInterpolationMethods), selectedItem.Text), RawInterpolationMethods)

        End Sub

        Private Sub menuItemRawWhiteBalanceMethods_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim selectedItem As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)
            checkAndUncheckSiblings(selectedItem)

            _decoder.WhiteBalance = CType(System.Enum.Parse(GetType(RawWhiteBalanceMethods), selectedItem.Text), RawWhiteBalanceMethods)
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Me.components = New System.ComponentModel.Container
            Me.imageViewer1 = New Atalasoft.Imaging.WinControls.ImageViewer
            Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
            Me.menuItemFile = New System.Windows.Forms.MenuItem
            Me.menuItemOpen = New System.Windows.Forms.MenuItem
            Me.menuItemOpenScaled = New System.Windows.Forms.MenuItem
            Me.menuItemOpenThumbnail = New System.Windows.Forms.MenuItem
            Me.menuItemOpenPreview = New System.Windows.Forms.MenuItem
            Me.menuItemImageInfo = New System.Windows.Forms.MenuItem
            Me.menuItemDecoder = New System.Windows.Forms.MenuItem
            Me.menuItemLoadingPolicy = New System.Windows.Forms.MenuItem
            Me.menuItemInterpolation = New System.Windows.Forms.MenuItem
            Me.menuItemWhiteBalance = New System.Windows.Forms.MenuItem
            Me.menuItemSetImageMetrics = New System.Windows.Forms.MenuItem
            Me.menuItemUseCameraMatrix = New System.Windows.Forms.MenuItem
            Me.statusBar1 = New System.Windows.Forms.StatusBar
            Me.progressBar1 = New System.Windows.Forms.ProgressBar
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
            Me.MenuItem1 = New System.Windows.Forms.MenuItem
            Me.AboutMenuItem = New System.Windows.Forms.MenuItem
            Me.SuspendLayout()
            '
            'imageViewer1
            '
            Me.imageViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.imageViewer1.AntialiasDisplay = Atalasoft.Imaging.WinControls.AntialiasDisplayMode.ScaleToGray
            Me.imageViewer1.DisplayProfile = Nothing
            Me.imageViewer1.Location = New System.Drawing.Point(0, 0)
            Me.imageViewer1.Magnifier.BackColor = System.Drawing.Color.White
            Me.imageViewer1.Magnifier.BorderColor = System.Drawing.Color.Black
            Me.imageViewer1.Magnifier.Size = New System.Drawing.Size(100, 100)
            Me.imageViewer1.Name = "imageViewer1"
            Me.imageViewer1.OutputProfile = Nothing
            Me.imageViewer1.Selection = Nothing
            Me.imageViewer1.Size = New System.Drawing.Size(680, 560)
            Me.imageViewer1.TabIndex = 0
            Me.imageViewer1.Text = "imageViewer1"
            Me.imageViewer1.MouseTool = Atalasoft.Imaging.WinControls.MouseToolType.Magnifier
            '
            'mainMenu1
            '
            Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemFile, Me.menuItemDecoder, Me.MenuItem1})
            '
            'menuItemFile
            '
            Me.menuItemFile.Index = 0
            Me.menuItemFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemOpen, Me.menuItemOpenScaled, Me.menuItemOpenThumbnail, Me.menuItemOpenPreview, Me.menuItemImageInfo})
            Me.menuItemFile.Text = "File"
            '
            'menuItemOpen
            '
            Me.menuItemOpen.Index = 0
            Me.menuItemOpen.Text = "Open"
            '
            'menuItemOpenScaled
            '
            Me.menuItemOpenScaled.Index = 1
            Me.menuItemOpenScaled.Text = "Open Scaled"
            '
            'menuItemOpenThumbnail
            '
            Me.menuItemOpenThumbnail.Index = 2
            Me.menuItemOpenThumbnail.Text = "Open Thumbnail"
            '
            'menuItemOpenPreview
            '
            Me.menuItemOpenPreview.Index = 3
            Me.menuItemOpenPreview.Text = "Open Preview"
            '
            'menuItemImageInfo
            '
            Me.menuItemImageInfo.Index = 4
            Me.menuItemImageInfo.Text = "Open Image Info"
            '
            'menuItemDecoder
            '
            Me.menuItemDecoder.Index = 1
            Me.menuItemDecoder.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemLoadingPolicy, Me.menuItemInterpolation, Me.menuItemWhiteBalance, Me.menuItemSetImageMetrics, Me.menuItemUseCameraMatrix})
            Me.menuItemDecoder.Text = "Decoder"
            '
            'menuItemLoadingPolicy
            '
            Me.menuItemLoadingPolicy.Index = 0
            Me.menuItemLoadingPolicy.Text = "Loading Policy"
            '
            'menuItemInterpolation
            '
            Me.menuItemInterpolation.Index = 1
            Me.menuItemInterpolation.Text = "Interpolation"
            '
            'menuItemWhiteBalance
            '
            Me.menuItemWhiteBalance.Index = 2
            Me.menuItemWhiteBalance.Text = "White Balance"
            '
            'menuItemSetImageMetrics
            '
            Me.menuItemSetImageMetrics.Index = 3
            Me.menuItemSetImageMetrics.Text = "Set Image Metrics"
            '
            'menuItemUseCameraMatrix
            '
            Me.menuItemUseCameraMatrix.Index = 4
            Me.menuItemUseCameraMatrix.Text = "Use Camera Matrix"
            '
            'statusBar1
            '
            Me.statusBar1.Location = New System.Drawing.Point(0, 565)
            Me.statusBar1.Name = "statusBar1"
            Me.statusBar1.Size = New System.Drawing.Size(680, 24)
            Me.statusBar1.TabIndex = 1
            '
            'progressBar1
            '
            Me.progressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.progressBar1.Location = New System.Drawing.Point(8, 568)
            Me.progressBar1.Name = "progressBar1"
            Me.progressBar1.Size = New System.Drawing.Size(648, 16)
            Me.progressBar1.TabIndex = 2
            '
            'openFileDialog1
            '
            Me.openFileDialog1.Filter = "All Files|*.*|Raw Files|*.dcr;*.dng;*.eff;*.mrw;*.nef;*.orf;*.pef;*.raf;*.srf;*.x" & _
                "3f;*.crw;*.cr2;*.tif;*.ppm"
            Me.openFileDialog1.FilterIndex = 2
            Me.openFileDialog1.RestoreDirectory = True
            Me.openFileDialog1.Title = "Select Raw File"
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 2
            Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.AboutMenuItem})
            Me.MenuItem1.Text = "Help"
            '
            'AboutMenuItem
            '
            Me.AboutMenuItem.Index = 0
            Me.AboutMenuItem.Text = "About ..."
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(680, 589)
            Me.Controls.Add(Me.progressBar1)
            Me.Controls.Add(Me.statusBar1)
            Me.Controls.Add(Me.imageViewer1)
            Me.Menu = Me.mainMenu1
            Me.Name = "Form1"
            Me.Text = "Raw Demo"
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub

        Private Sub Viewer_Progress(ByVal sender As Object, ByVal e As ProgressEventArgs)
            If e.Total = 0 Then
                e.Total = 1
            End If
            progressBar1.Value = e.Current * 100 / e.Total
            If progressBar1.Value = 100 Then
                progressBar1.Value = 0
            End If
        End Sub

        Private Sub menuItemOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemOpen.Click
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                Try
                    imageViewer1.Image = _decoder.Read(openFileDialog1.OpenFile(), New Atalasoft.Imaging.ProgressEventHandler(AddressOf Viewer_Progress))
                Catch Ex As Exception
                    MessageBox.Show("Image Could Not Be Read:" & Constants.vbLf & " " & Ex.ToString())
                End Try
            End If
        End Sub

        Private Sub menuItemOpenScaled_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemOpenScaled.Click
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                Try
                    imageViewer1.Image = _decoder.ReadScaled(openFileDialog1.OpenFile(), 0, _scaleFactor, New Atalasoft.Imaging.ProgressEventHandler(AddressOf Viewer_Progress))
                Catch Ex As Exception
                    MessageBox.Show("Image Could Not Be Read:" & Constants.vbLf & " " & Ex.ToString())
                End Try
            End If
        End Sub

        Private Sub menuItemOpenThumbnail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemOpenThumbnail.Click
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                Try
                    imageViewer1.Image = _decoder.GetThumbnail(openFileDialog1.OpenFile())
                Catch Ex As Exception
                    MessageBox.Show("Thumbnail Could Not Be Read:" & Constants.vbLf & " " & Ex.ToString())
                End Try

                If imageViewer1.Image Is Nothing Then
                    MessageBox.Show("No Thumbnail Could Be Found.")
                End If
            End If
        End Sub

        Private Sub menuItemOpenPreview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemOpenPreview.Click
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                Try
                    imageViewer1.Image = _decoder.GetPreviewImage(openFileDialog1.OpenFile())
                Catch Ex As Exception
                    MessageBox.Show("Preview Could Not Be Read:" & Constants.vbLf & " " & Ex.ToString())
                End Try

                If imageViewer1.Image Is Nothing Then
                    MessageBox.Show("No Preview Could Be Found.")
                End If
            End If
        End Sub

        Private Sub menuItemImageInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemImageInfo.Click
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim info As ImageInfo

                Try
                    info = _decoder.GetImageInfo(openFileDialog1.OpenFile())

                    Dim dInfo As DisplayImageInfo = New DisplayImageInfo(info)
                    dInfo.ShowDialog()
                Catch Ex As Exception
                    MessageBox.Show("ImageInfo Could Not Be Read:" & Constants.vbLf & " " & Ex.ToString())
                End Try
            End If
        End Sub

        Private Sub menuItemUseCameraMatrix_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemUseCameraMatrix.Click
            Dim item As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)
            If item.Checked = True Then
                item.Checked = False
                _decoder.UseCameraMatrix = False

            Else
                item.Checked = True
                _decoder.UseCameraMatrix = True
            End If
        End Sub

        Private Sub menuItemSetImageMetrics_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemSetImageMetrics.Click
            Dim form As ImageMetrics = New ImageMetrics(_decoder)
            form.ShowDialog()
        End Sub


        Private Sub AboutMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMenuItem.Click
            Dim aboutBox As AtalaDemos.AboutBox.About = New AtalaDemos.AboutBox.About("About Atalasoft Raw Demo", "Raw Demo")
            aboutBox.Description = "A basic image viewer using our RawDecoder to load/view RAW format images (DNG, RAW, CR2, etc...) as well as the embedded thumbnails and image info." & vbCrLf & vbCrLf & _
                                   "Demonstrates using our RawDecoder to view and scale RAW format images, as well as accessing the embedded thumbnail, preview, and Image Info." & vbCrLf & vbCrLf & _
                                   "In addition, our RawDecoder allows for control over loading policy, interpolation, white balance and Image metrics. This demo provides a practical working example of these settings."
            aboutBox.ShowDialog()
        End Sub
    End Class
End Namespace
