<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574915/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1928)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to implement custom zooming for a chart control in a Windows Forms application when Secondary Axis are used


<p>This example demonstrates how to implement custom zooming for a chart control. To accomplish this task, handle the MouseWheel event. 
<br />
Within this event handler, call the XYDiagram.PointToDiagram method to obtain information relative to the coordinates of the mouse pointer 
<br />
affiliation with a series or series point in a diagram. Corresponding values for the secondary axes should be calculated manually.  After 
<br />
that you can manually assign both minimum and maximum internal values of an axis range as your needs dictate.</p><p>See also: <a href="https://www.devexpress.com/Support/Center/p/E1871">How to implement custom zooming for the chart control in a Windows Forms application</a>.</p>

<br/>


