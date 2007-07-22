Imports Framework
Imports Framework.Cuestionario.CuestionarioDN

<Serializable()> _
Public Class ValorMarcaCaracterisitcaDN
    Inherits Framework.DatosNegocio.EntidadDN
    Implements Framework.Cuestionario.CuestionarioDN.IValorCaracteristicaDN

    Protected mMarca As MarcaDN
    Protected mFechaefectoValor As DateTime
    Protected mCaracteristica As CaracteristicaDN
    Protected mIVCPadre As IValorCaracteristicaDN


    <Framework.DatosNegocio.RelacionPropCampoAtribute("mCaracteristica")> Public Property Caracteristica() As CaracteristicaDN Implements IValorCaracteristicaDN.Caracteristica
        Get
            Return Me.mCaracteristica
        End Get
        Set(ByVal value As CaracteristicaDN)
            Me.CambiarValorRef(Of CaracteristicaDN)(value, Me.mCaracteristica)
        End Set
    End Property

    Public Property ValorMarca() As MarcaDN
        Get
            Return Me.mMarca
        End Get
        Set(ByVal value As MarcaDN)
            Me.CambiarValorRef(Of MarcaDN)(value, Me.mMarca)
        End Set
    End Property

    Public Property Valor() As Object Implements IValorCaracteristicaDN.Valor
        Get
            Return Me.ValorMarca
        End Get
        Set(ByVal value As Object)
            Me.ValorMarca = value
        End Set
    End Property

    Public Property ValorCaracPadre() As IValorCaracteristicaDN Implements IValorCaracteristicaDN.ValorCaracPadre
        Get
            Return mIVCPadre
        End Get
        Set(ByVal value As IValorCaracteristicaDN)
            Me.CambiarValorRef(Of IValorCaracteristicaDN)(value, mIVCPadre)
        End Set
    End Property

    Public Property FechaEfectoValor() As Date Implements IValorCaracteristicaDN.FechaEfectoValor
        Get
            Return mFechaefectoValor
        End Get
        Set(ByVal value As Date)
            CambiarValorVal(Of Date)(value, mFechaefectoValor)
        End Set
    End Property

    Public Overrides Function EstadoIntegridad(ByRef pMensaje As String) As DatosNegocio.EstadoIntegridadDN

        If Not Me.mCaracteristica.Padre Is Nothing AndAlso Me.mIVCPadre Is Nothing Then
            pMensaje = "Dado que la caracteristica es subordinada, mVNCPadre no puede ser nothing"
            Return Framework.DatosNegocio.EstadoIntegridadDN.Inconsistente
        End If

        Return MyBase.EstadoIntegridad(pMensaje)
    End Function

    Public Function ClonarIValorCaracteristica() As Framework.Cuestionario.CuestionarioDN.IValorCaracteristicaDN Implements Framework.Cuestionario.CuestionarioDN.IValorCaracteristicaDN.ClonarIValorCaracteristica
        Dim valorClon As ValorMarcaCaracterisitcaDN
        valorClon = Me.CloneSuperficialSinIdentidad()
        valorClon.FechaEfectoValor = Date.MinValue

        If Me.mIVCPadre IsNot Nothing Then
            valorClon.mIVCPadre = Me.mIVCPadre.ClonarIValorCaracteristica()
        End If

        Return valorClon
    End Function

End Class

