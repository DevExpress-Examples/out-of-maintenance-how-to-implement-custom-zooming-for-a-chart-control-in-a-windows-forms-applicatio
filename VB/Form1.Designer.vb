Imports Microsoft.VisualBasic
Imports System
Namespace CustomZooming
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim secondaryAxisX1 As New DevExpress.XtraCharts.SecondaryAxisX()
			Dim secondaryAxisY1 As New DevExpress.XtraCharts.SecondaryAxisY()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(1R, New Object() { (CObj(7R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(2R, New Object() { (CObj(8R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(3R, New Object() { (CObj(6R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(4R, New Object() { (CObj(7R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(5R, New Object() { (CObj(5R))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(6R, New Object() { (CObj(6R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(7R, New Object() { (CObj(4R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(8R, New Object() { (CObj(7R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(9R, New Object() { (CObj(5R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(10R, New Object() { (CObj(6R))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(100R, New Object() { (CObj(54R))})
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint(21R, New Object() { (CObj(5R))})
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint(22R, New Object() { (CObj(6R))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint(23R, New Object() { (CObj(4R))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint(24R, New Object() { (CObj(8R))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint(25R, New Object() { (CObj(7R))})
			Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(secondaryAxisX1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(secondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.EnableAxisXScrolling = True
			xyDiagram1.EnableAxisYScrolling = True
			secondaryAxisX1.AxisID = 0
			secondaryAxisX1.Name = "secondaryAxisX1"
			secondaryAxisX1.VisibleInPanesSerializable = "-1"
			xyDiagram1.SecondaryAxesX.AddRange(New DevExpress.XtraCharts.SecondaryAxisX() { secondaryAxisX1})
			secondaryAxisY1.AxisID = 0
			secondaryAxisY1.Name = "secondaryAxisY1"
			secondaryAxisY1.VisibleInPanesSerializable = "-1"
			xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() { secondaryAxisY1})
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11})
			series1.View = lineSeriesView1
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series2.Name = "Series 2"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16})
			lineSeriesView2.AxisXName = "secondaryAxisX1"
			lineSeriesView2.AxisYName = "secondaryAxisY1"
			series2.View = lineSeriesView2
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			Me.chartControl1.Size = New System.Drawing.Size(945, 386)
			Me.chartControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(945, 386)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(secondaryAxisX1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(secondaryAxisY1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

