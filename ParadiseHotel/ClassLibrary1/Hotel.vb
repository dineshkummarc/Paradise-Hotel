﻿
Public Class Hotel
    Dim nom As String
    Dim rut As Integer
    Dim dir As String
    Dim tel As Integer
    Dim gerente As String
    Dim estrellas As Byte
    Dim colPisos As Hashtable
    Dim colServicios As Hashtable
    Dim objPers As PersHotel

    Public Function AltaPiso(ByVal objP As Piso) As Boolean
        If Not colPisos.ContainsKey(objP.Numero) Then
            objP.guardame()
            colPisos.Add(objP.Numero, objP)
            Return True
        End If
        Return False
    End Function

    Public Function BajaPiso(ByVal objP As Piso) As Boolean
        If colPisos.ContainsKey(objP.Numero) Then
            objP.eliminame()
            colPisos.Remove(objP)
            Return True
        End If
        Return False
    End Function

    Public Function CalcularNroHabitacion() As Integer
        Dim nroHabMax As Integer = 0
        For Each objp As Piso In colPisos.Values
            For Each objHab As Habitacion In objp.DevolverHabitaciones.Values
                If (nroHabMax < objHab.Numero) Then
                    nroHabMax = objHab.Numero
                End If
            Next
        Next
        Return nroHabMax + 1
    End Function

    Public Function DevolverPisos() As Hashtable
        Return colPisos
    End Function

    Public Function DevolverServicios() As Hashtable
        Return colServicios
    End Function

    Public Function ModificarPiso(ByVal objP As Piso) As Boolean
        If colPisos.ContainsKey(objP.Numero) Then
            objP.modificame()
            colPisos.Remove(objP)
            colPisos.Add(objP.Numero, objP)
            Return True
        End If
        Return False
    End Function

    Public Sub ObtenerPisos()

        Dim objDataSet As DataSet = objPers.ObtenerDataSetPisos
        For Each objfila As DataRow In objDataSet.Tables("Pisos").Rows
            Dim objP As New Piso(CInt(objfila("NumeroPiso")), CInt(objfila("MetrajeMaximo")))
            colPisos.Add(objP.Numero, objP)
            objP.ObtenerHabitaciones()
        Next
    End Sub

    Public Sub New()
        colPisos = New Hashtable
        colServicios = New Hashtable
        objPers = New PersHotel
    End Sub

End Class
