@ModelType List(Of VB.MyObject)
@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "grid"
            settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "GridViewPartial"}
            settings.KeyFieldName = "ID"
    
            settings.CommandColumn.Visible = True
            settings.CommandColumn.ShowSelectCheckbox = True
    
            settings.Columns.Add("ID")
            settings.Columns.Add("Name")

            settings.SettingsBehavior.AllowSelectSingleRowOnly = True
            settings.SettingsBehavior.AllowSelectByRowClick = True
    End Sub).Bind(Model).GetHtml()