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
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(1, New Object() { (CObj(7))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(2, New Object() { (CObj(8))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(3, New Object() { (CObj(6))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(4, New Object() { (CObj(7))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(5, New Object() { (CObj(5))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(6, New Object() { (CObj(6))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(7, New Object() { (CObj(4))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(8, New Object() { (CObj(7))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(9, New Object() { (CObj(5))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(10, New Object() { (CObj(6))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(100, New Object() { (CObj(54))})
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint(21, New Object() { (CObj(5))})
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint(22, New Object() { (CObj(6))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint(23, New Object() { (CObj(4))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint(24, New Object() { (CObj(8))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint(25, New Object() { (CObj(7))})
			Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(secondaryAxisX1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(secondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.EnableScrolling = True
			secondaryAxisX1.AxisID = 0
			secondaryAxisX1.Name = "secondaryAxisX1"
			secondaryAxisX1.Range.ScrollingRange.SideMarginsEnabled = True
			secondaryAxisX1.Range.SideMarginsEnabled = True
			secondaryAxisX1.VisibleInPanesSerializable = "-1"
			xyDiagram1.SecondaryAxesX.AddRange(New DevExpress.XtraCharts.SecondaryAxisX() { secondaryAxisX1})
			secondaryAxisY1.AxisID = 0
			secondaryAxisY1.Name = "secondaryAxisY1"
			secondaryAxisY1.Range.ScrollingRange.SideMarginsEnabled = True
			secondaryAxisY1.Range.SideMarginsEnabled = True
			secondaryAxisY1.VisibleInPanesSerializable = "-1"
			xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() { secondaryAxisY1})
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			pointSeriesLabel1.LineVisible = True
			pointSeriesLabel1.OverlappingOptionsTypeName = "PointOverlappingOptions"
			series1.Label = pointSeriesLabel1
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11})
			series1.View = lineSeriesView1
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			pointSeriesLabel2.LineVisible = True
			pointSeriesLabel2.OverlappingOptionsTypeName = "PointOverlappingOptions"
			series2.Label = pointSeriesLabel2
			series2.Name = "Series 2"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16})
			lineSeriesView2.AxisXName = "secondaryAxisX1"
			lineSeriesView2.AxisYName = "secondaryAxisY1"
			series2.View = lineSeriesView2
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			sideBySideBarSeriesLabel1.LineVisible = True
			sideBySideBarSeriesLabel1.OverlappingOptionsTypeName = "OverlappingOptions"
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
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
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

