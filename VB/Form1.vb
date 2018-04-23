Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace CustomZooming
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			AddHandler chartControl1.MouseWheel, AddressOf chartControl1_MouseWheel
		End Sub

		Private Sub chartControl1_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs)
			CType(sender, ChartControl).BeginInit()
			Dim diagram As XYDiagram = TryCast((CType(sender, ChartControl)).Diagram, XYDiagram)
			Dim minValueX As Double = diagram.AxisX.Range.MinValueInternal
			Dim maxValueX As Double = diagram.AxisX.Range.MaxValueInternal
			Dim minValueY As Double = diagram.AxisY.Range.MinValueInternal
			Dim maxValueY As Double = diagram.AxisY.Range.MaxValueInternal
			Dim secondMinValueX As Double = diagram.SecondaryAxesX(0).Range.MinValueInternal
			Dim secondMaxValueX As Double = diagram.SecondaryAxesX(0).Range.MaxValueInternal
			Dim secondMinValueY As Double = diagram.SecondaryAxesY(0).Range.MinValueInternal
			Dim secondMaxValueY As Double = diagram.SecondaryAxesY(0).Range.MaxValueInternal
			Dim scrollMinValueX As Double = diagram.AxisX.Range.ScrollingRange.MinValueInternal
			Dim scrollMaxValueX As Double = diagram.AxisX.Range.ScrollingRange.MaxValueInternal
			Dim scrollMinValueY As Double = diagram.AxisY.Range.ScrollingRange.MinValueInternal
			Dim scrollMaxValueY As Double = diagram.AxisY.Range.ScrollingRange.MaxValueInternal
			Dim secondScrollMinValueX As Double = diagram.SecondaryAxesX(0).Range.ScrollingRange.MinValueInternal
			Dim secondScrollMaxValueX As Double = diagram.SecondaryAxesX(0).Range.ScrollingRange.MaxValueInternal
			Dim secondScrollMinValueY As Double = diagram.SecondaryAxesY(0).Range.ScrollingRange.MinValueInternal
			Dim secondScrollMaxValueY As Double = diagram.SecondaryAxesY(0).Range.ScrollingRange.MaxValueInternal


			Dim coord As DiagramCoordinates = diagram.PointToDiagram(e.Location)
			Dim x As Double = coord.NumericalArgument
			Dim y As Double = coord.NumericalValue
			Dim secx As Double = (secondMaxValueX - secondMinValueX) * (x - minValueX) / (maxValueX - minValueX) + secondMinValueX
			Dim secy As Double = (secondMaxValueY - secondMinValueY) * (y - minValueY) / (maxValueY - minValueY) + secondMinValueY
			If e.Delta > 0 AndAlso maxValueY - minValueY > 0.1 AndAlso maxValueX - minValueX > 0.1 Then
				diagram.AxisX.Range.SetMinMaxValues(0.2 * x + 0.8 * minValueX, 0.2 * x + 0.8 * maxValueX)
				diagram.AxisY.Range.SetMinMaxValues(0.2 * y + 0.8 * minValueY, 0.2 * y + 0.8 * maxValueY)

				diagram.SecondaryAxesX(0).Range.SetMinMaxValues(0.2 * secx + 0.8 * secondMinValueX, 0.2 * secx + 0.8 * secondMaxValueX)
				diagram.SecondaryAxesY(0).Range.SetMinMaxValues(0.2 * secy + 0.8 * secondMinValueY, 0.2 * secy + 0.8 * secondMaxValueY)

			End If
			If e.Delta < 0 AndAlso (minValueX > scrollMinValueX OrElse maxValueX < scrollMinValueX OrElse minValueY > scrollMinValueY OrElse maxValueY < scrollMaxValueY) Then
				Dim minValueInternalX As Double = If((1.2 * minValueX - 0.2 * x >= scrollMinValueX), 1.2 * minValueX - 0.2 * x, scrollMinValueX)
				Dim maxValueInternalX As Double = If((1.2 * maxValueX - 0.2 * x <= scrollMaxValueX), 1.2 * maxValueX - 0.2 * x, scrollMaxValueX)
				Dim minValueInternalY As Double = If((1.2 * minValueY - 0.2 * y >= scrollMinValueY), 1.2 * minValueY - 0.2 * y, scrollMinValueY)
				Dim maxValueInternalY As Double = If((1.2 * maxValueY - 0.2 * y <= scrollMaxValueY), 1.2 * maxValueY - 0.2 * y, scrollMaxValueY)
				diagram.AxisX.Range.SetMinMaxValues(minValueInternalX, maxValueInternalX)
				diagram.AxisY.Range.SetMinMaxValues(minValueInternalY, maxValueInternalY)
				Dim secondMinValueInternalX As Double = If((1.2 * secondMinValueX - 0.2 * secx >= secondScrollMinValueX), 1.2 * secondMinValueX - 0.2 * secx, secondScrollMinValueX)
				Dim secondMaxValueInternalX As Double = If((1.2 * secondMaxValueX - 0.2 * secx <= secondScrollMaxValueX), 1.2 * secondMaxValueX - 0.2 * secx, secondScrollMaxValueX)
				Dim secondMinValueInternalY As Double = If((1.2 * secondMinValueY - 0.2 * secy >= secondScrollMinValueY), 1.2 * secondMinValueY - 0.2 * secy, secondScrollMinValueY)
				Dim secondMaxValueInternalY As Double = If((1.2 * secondMaxValueY - 0.2 * secy <= secondScrollMaxValueY), 1.2 * secondMaxValueY - 0.2 * secy, secondScrollMaxValueY)
				diagram.SecondaryAxesX(0).Range.SetMinMaxValues(secondMinValueInternalX, secondMaxValueInternalX)
				diagram.SecondaryAxesY(0).Range.SetMinMaxValues(secondMinValueInternalY, secondMaxValueInternalY)
			End If
			CType(sender, ChartControl).EndInit()
		End Sub
	End Class
End Namespace