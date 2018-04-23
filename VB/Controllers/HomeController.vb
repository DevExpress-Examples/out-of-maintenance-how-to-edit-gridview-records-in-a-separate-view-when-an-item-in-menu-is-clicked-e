Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc

Public Class HomeController
    Inherits Controller
    Private list As New ObjectsList()

    Public Function Index() As ActionResult
        Return View(list.GetObjects())
    End Function

    Public Function GridViewPartial() As ActionResult
        Return PartialView(list.GetObjects())
    End Function

    <HttpGet()> _
    Public Function Edit(ByVal id As Nullable(Of Int32)) As ActionResult
        If (Not id.HasValue) Then
            Return Content("Please enter a valid key value")
        End If

        Dim model As MyObject = list.GetObjects().Where(Function(m) m.ID.Equals(id)).First()

        Return View(model)
    End Function

    <HttpPost()> _
    Public Function Edit(<ModelBinder(GetType(DevExpressEditorsBinder))> ByVal obj As MyObject) As ActionResult
        list.UpdateObject(obj)

        Return RedirectToAction("Index")
    End Function
End Class
