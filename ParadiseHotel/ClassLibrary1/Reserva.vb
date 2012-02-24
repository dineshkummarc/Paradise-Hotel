﻿Public Class Reserva
    Dim idRes As Integer
    Dim objHab As Habitacion
    Dim colHuespedes As Hashtable
    Dim CIn As Date
    Dim COut As Date
    Dim montoReserva As Integer
    Dim fechaRealizacion As Date
    Dim montoTotal As Integer
    Dim fechaPagoSaldo As Date
    Dim montoRembolsado As Integer

    Public Function devolverHuespedes() As Hashtable
        Return Me.colHuespedes
    End Function

    Public Sub New(ByVal id As Integer, ByVal objhab As Habitacion, ByVal colHuespedes As Hashtable, ByVal cin As Date, ByVal cout As Date, ByVal Reserva As Integer, ByVal fRealizacion As Date, ByVal total As Integer, ByVal fpagosaldo As Date)
        Me.idRes = id
        Me.objHab = objhab
        Me.colHuespedes = colHuespedes
        Me.CIn = cin
        Me.COut = cout
        Me.montoReserva = Reserva
        Me.fechaRealizacion = fRealizacion
        Me.montoTotal = total
        Me.fechaPagoSaldo = fpagosaldo
        Me.montoRembolsado = Nothing
    End Sub

    Public Overrides Function ToString() As String
        Return "Reserva: " & idRes & " - Hab.: " & objHab.Numero & " Desde: " & CIn & " - Hasta: " & COut
    End Function

    Public Property Id() As Integer
        Get
            Return idRes
        End Get
        Set(ByVal value As Integer)
            idRes = value
        End Set
    End Property

    Public Property Habitacion() As Habitacion
        Get
            Return objHab
        End Get
        Set(ByVal value As Habitacion)
            objHab = value
        End Set
    End Property

    Public Property CheckIn() As Date
        Get
            Return CIn
        End Get
        Set(ByVal value As Date)
            CIn = value
        End Set
    End Property

    Public Property CheckOut() As Date
        Get
            Return COut
        End Get
        Set(ByVal value As Date)
            COut = value
        End Set
    End Property

    Public Property Reserva() As Integer
        Get
            Return montoReserva
        End Get
        Set(ByVal value As Integer)
            montoReserva = value
        End Set
    End Property

    Public Property Total() As Integer
        Get
            Return montoTotal
        End Get
        Set(ByVal value As Integer)
            montoTotal = value
        End Set
    End Property

    Public Property FechaPago() As Date
        Get
            Return fechaPagoSaldo
        End Get
        Set(ByVal value As Date)
            fechaPagoSaldo = value
        End Set
    End Property

    Public Property Rembolso() As Integer
        Get
            Return montoRembolsado
        End Get
        Set(ByVal value As Integer)
            montoRembolsado = value
        End Set
    End Property




End Class