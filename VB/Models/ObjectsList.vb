Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Public Class ObjectsList
    Private Const Key As String = "SomeValue"

    Public Function GetObjects() As List(Of MyObject)
        If HttpContext.Current.Session("Key") Is Nothing Then
            Dim list As List(Of MyObject) = New List(Of MyObject)()

            list.Add(New MyObject(1, "Test1"))
            list.Add(New MyObject(2, "Test2"))
            list.Add(New MyObject(3, "Test3"))
            list.Add(New MyObject(4, "Test4"))

            HttpContext.Current.Session("Key") = list
        End If

        Return CType(HttpContext.Current.Session("Key"), List(Of MyObject))
    End Function

    Public Sub UpdateObject(ByVal obj As MyObject)
        Dim objects As List(Of MyObject) = GetObjects()

        Dim editedObject As MyObject = objects.Where(Function(m) m.ID = obj.ID).First()

        editedObject.Name = obj.Name
    End Sub
End Class