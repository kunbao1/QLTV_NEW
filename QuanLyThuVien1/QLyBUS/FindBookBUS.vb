﻿Imports QLyDTO

Public Class FindBookBUS
    Public Function ValidKindOfFind(fb As FindBookDTO) As Boolean
        If (fb.Kind.ToString.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidFind(fb As FindBookDTO) As Boolean
        If (fb.Find.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidBookCode(fb As FindBookDTO) As Boolean
        If (fb.BookCode.ToString.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidBookName(fb As FindBookDTO) As Boolean
        If (fb.BookName.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidProducerCode(fb As FindBookDTO) As Boolean
        If (fb.ProducerCode.ToString.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidAuthorCode(fb As FindBookDTO) As Boolean
        If (fb.AuthorCode.ToString.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidKindCode(fb As FindBookDTO) As Boolean
        If (fb.KindCode.ToString.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidPublishingYear(fb As FindBookDTO) As Boolean
        If (fb.PublishingYear.ToString < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidAmount(fb As FindBookDTO) As Boolean
        If (fb.Amount.ToString.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidInputDay(fb As FindBookDTO) As Boolean
        If (fb.InputDay.ToString.Length < 1) Then
            Return False
        End If
        Return True
    End Function
End Class
