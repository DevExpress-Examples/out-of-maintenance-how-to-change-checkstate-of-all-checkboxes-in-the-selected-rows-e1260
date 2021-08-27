<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1260)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q146124/Form1.cs) (VB: [Form1.vb](./VB/Q146124/Form1.vb))
* [Program.cs](./CS/Q146124/Program.cs) (VB: [Program.vb](./VB/Q146124/Program.vb))
<!-- default file list end -->
# How to change CheckState of all CheckBoxes in the selected rows.


<p>This example demonstrates how to change check state of the check boxes in 
all selected rows by clicking the check box in the 
selected row. This task can be accomplished by handling the GridView.MouseDown event and calculating the GridHitInfo. Based on the GridHitInfo, you can determine the row and column of the clicked cell, and if this cell has a check box and belongs to the selected row, iterate through the selected rows and set the CheckBox state using the GridView.SetRowCellValue method.</p>

<br/>


