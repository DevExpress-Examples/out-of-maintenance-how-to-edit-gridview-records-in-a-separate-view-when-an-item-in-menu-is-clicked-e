Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.ComponentModel.DataAnnotations


Public Class MyObject
    Public Sub New()
        ID = 0
        Name = String.Empty
    End Sub

    Public Sub New(ByVal ID As Int32, ByVal Name As String)
        Me.ID = ID
        Me.Name = Name
    End Sub

    Private privateID As Int32
    <Key()> _
    Public Property ID() As Int32
        Get
            Return privateID
        End Get
        Set(ByVal value As Int32)
            privateID = value
        End Set
    End Property
    Private privateName As String
    Public Property Name() As String
        Get
            Return privateName
        End Get
        Set(ByVal value As String)
            privateName = value
        End Set
    End Property
End Class
