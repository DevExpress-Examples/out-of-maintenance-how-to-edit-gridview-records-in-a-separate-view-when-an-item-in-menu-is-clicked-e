@Code
    ViewBag.Title = "Home Page"
End Code
@ModelType List(Of VB.MyObject)

@Html.DevExpress().Menu( _
    Sub(settings)
            settings.Name = "menu"
            settings.Items.Add("Edit", "edt")

            settings.ClientSideEvents.ItemClick = "OnItemClick"
    End Sub).GetHtml()

@Html.Partial("GridViewPartial", Model)