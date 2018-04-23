# How to change CheckState of all CheckBoxes in the selected rows.


<p>This example demonstrates how to change check state of the check boxes in all selected rows by clicking the check box in the 
selected row. This task can be accomplished by handling the GridView.MouseDown event and calculating the GridHitInfo. Based on the GridHitInfo, you can determine the row and column of the clicked cell, and if this cell has a check box and belongs to the selected row, iterate through the selected rows and set the CheckBox state using the GridView.SetRowCellValue method.</p>

<br/>


