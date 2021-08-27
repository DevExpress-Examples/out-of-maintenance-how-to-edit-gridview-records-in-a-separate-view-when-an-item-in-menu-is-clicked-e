<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128551429/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3609)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [MyObject.cs](./CS/Models/MyObject.cs) (VB: [MyObject.vb](./VB/Models/MyObject.vb))
* [ObjectsList.cs](./CS/Models/ObjectsList.cs) (VB: [ObjectsList.vb](./VB/Models/ObjectsList.vb))
* [HomeScript.js](./CS/Scripts/HomeScript.js) (VB: [HomeScript.js](./VB/Scripts/HomeScript.js))
* [Edit.cshtml](./CS/Views/Home/Edit.cshtml)
* [GridViewPartial.cshtml](./CS/Views/Home/GridViewPartial.cshtml)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
* [_Layout.cshtml](./CS/Views/Shared/_Layout.cshtml)
<!-- default file list end -->
# How to edit GridView records in a separate View when an item in Menu is clicked
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3609/)**
<!-- run online end -->


<p>The example uses an external Form that edits records displayed by the GridView extension. When a user selects a record, it is possible to retrieve keys from a visible page using the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewScriptsASPxClientGridView_GetSelectedKeysOnPagetopic"><u>ASPxClientGridView.GetSelectedKeysOnPage</u></a> method.<br />
When a user clicks a Menu item, it is possible to open a required page (invoke a Controller's Action) on the client side.</p>

<br/>


