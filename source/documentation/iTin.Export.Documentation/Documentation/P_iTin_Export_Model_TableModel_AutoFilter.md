# TableModel.AutoFilter Property 
Additional header content 

Gets or sets a value indicating whether displays the autofilter.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public YesNo AutoFilter { get; set; }
```

**VB**<br />
``` VB
Public Property AutoFilter As YesNo
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_YesNo">YesNo</a><br /><a href="T_iTin_Export_Model_YesNo">Yes</a> if displays the autofilter; otherwise, <a href="T_iTin_Export_Model_YesNo">No</a>. The default is <a href="T_iTin_Export_Model_YesNo">No</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**TEE Object Element Usage**<br />
``` XML
<Table AutoFilter="Yes|No" ...>
...
</Table>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table><strong>`X`</strong>


## Examples

**XML**<br />
``` XML
<Table AutoFilter="Yes">
...
</Table>
```

**C#**<br />
``` C#
...
TableModel table = new TableModel
{
Name = "Sample name",
Alias = "Sample alias",
AutoFilter = YesNo.Yes,
Location = new[] { 2, 2 },
AutoFitColumns = YesNo.Yes,
} ;
...
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_TableModel">TableModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />