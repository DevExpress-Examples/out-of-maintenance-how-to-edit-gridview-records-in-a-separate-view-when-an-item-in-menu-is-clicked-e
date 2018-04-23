@ModelType VB.MyObject
@Code
    ViewBag.Title = "Edit"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<h2>
    Edit</h2>
@Using (Html.BeginForm("Edit", "Home"))
    @<input type="hidden" name="ID" value='@Model.ID' />
    @<text>Name: </text>
    @Html.DevExpress().TextBox( _
    Sub(settings)
        settings.Name = "Name"
        settings.Width = 170
    End Sub).Bind(Model, "Name").GetHtml()
    
    @Html.DevExpress().Button( _
    Sub(settings)
        settings.Name = "btn"
        settings.UseSubmitBehavior = True
        settings.Text = "Submit changes"
    End Sub).GetHtml()
End Using