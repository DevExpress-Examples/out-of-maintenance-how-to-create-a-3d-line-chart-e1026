Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_3DLineChart
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a new chart.
            Dim LineChart3D As New ChartControl()

            ' Add a line series to it.
            Dim series1 As New Series("Series 1", ViewType.Line3D)

            ' Add points to the series.
            series1.Points.Add(New SeriesPoint("A", 12))
            series1.Points.Add(New SeriesPoint("B", 4))
            series1.Points.Add(New SeriesPoint("C", 17))
            series1.Points.Add(New SeriesPoint("D", 7))
            series1.Points.Add(New SeriesPoint("E", 12))
            series1.Points.Add(New SeriesPoint("F", 4))
            series1.Points.Add(New SeriesPoint("G", 17))
            series1.Points.Add(New SeriesPoint("H", 7))

            ' Add both series to the chart.
            LineChart3D.Series.Add(series1)


            ' Customize the view-type-specific properties of the series.
            Dim myView As Line3DSeriesView = CType(series1.View, Line3DSeriesView)
            myView.LineWidth = 5
            myView.LineThickness = 4

            ' Access the diagram's options.
            CType(LineChart3D.Diagram, XYDiagram3D).ZoomPercent = 110
            CType(LineChart3D.Diagram, XYDiagram3D).VerticalScrollPercent = 10

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "3D Line Chart"
            LineChart3D.Titles.Add(chartTitle1)
            LineChart3D.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

            ' Add the chart to the form.
            LineChart3D.Dock = DockStyle.Fill
            Me.Controls.Add(LineChart3D)
        End Sub

    End Class
End Namespace