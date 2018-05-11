# ChartBorderModel Class
Additional header content 

Represents the visual setting of chart border. Includes visibility, shadow definition, line style, width and color.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(ChartBorderModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.ChartBorderModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class ChartBorderModel : BaseModel<ChartBorderModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class ChartBorderModel
	Inherits BaseModel(Of ChartBorderModel)
```

The ChartBorderModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ChartBorderModel__ctor">ChartBorderModel</a></td><td>
Initializes a new instance of the ChartBorderModel class.</td></tr></table>&nbsp;
<a href="#chartbordermodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartBorderModel_Color">Color</a></td><td>
Gets or sets preferred border color.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartBorderModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance contains the default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartBorderModel_Shadow">Shadow</a></td><td>
Gets or sets a reference that contains the visual setting of shadow-border.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartBorderModel_Show">Show</a></td><td>
Gets or sets a value that determines whether to display the border.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartBorderModel_Style">Style</a></td><td>
Gets or sets preferred border line style.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartBorderModel_Width">Width</a></td><td>
Gets or sets preferred style for width of the border line.</td></tr></table>&nbsp;
<a href="#chartbordermodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ChartBorderModel_GetColor">GetColor</a></td><td>
Gets a reference to the Color structure that represents color for this border.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#chartbordermodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Chart`</strong>. For more information, please see <a href="T_iTin_Export_Model_ChartModel">ChartModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<Border>
  <Shadow/>
</Border>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_ChartBorderModel_Show">Show</a></td><td align="center">Yes</td><td>Determines whether displays the border. The default is <a href="T_iTin_Export_Model_YesNo">No</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_ChartBorderModel_Color">Color</a></td><td align="center">Yes</td><td>Preferred border color. The default is "`Black`".</td></tr><tr><td><a href="P_iTin_Export_Model_ChartBorderModel_Width">Width</a></td><td align="center">Yes</td><td>Preferred style for width of the border line. The default is <a href="T_iTin_Export_Model_KnownWidthLineStyle">Thin</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_ChartBorderModel_Style">Style</a></td><td align="center">Yes</td><td>Preferred border line style. The default is <a href="T_iTin_Export_Model_KnownLineStyle">Continuous</a>.</td></tr></table><strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_ChartBorderModel_Shadow">Shadow</a></td><td>Represents the visual setting of shadow-border. Includes shadow visibility and transparency.</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />