﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("FN.Seguros.Polizas.AD.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwAlertasProximasVencimiento as
        '''
        '''SELECT     ID, Nombre, Comentario, FEjecProgramada, Atendida, Usuario, GUIDReferida
        '''FROM         dbo.vwAlertasyUsuario
        '''WHERE     (FEjecProgramada &lt; GETDATE() - 1) AND (Atendida = 0).
        '''</summary>
        Friend ReadOnly Property vwAlertasProximasVencimiento() As String
            Get
                Return ResourceManager.GetString("vwAlertasProximasVencimiento", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwAlertasxPresupuesto as SELECT     dbo.tlAlertaDN.ID, dbo.tlAlertaDN.Nombre, dbo.tlAlertaDN.Comentario, dbo.tlAlertaDN.FEjecProgramada, dbo.tlAlertaDN.Atendida, 
        '''                      dbo.tlUsuarioDN.Nombre AS Usuario, dbo.tlHEDN.GUIDReferida
        '''FROM         dbo.tlAlertaDN INNER JOIN
        '''                      dbo.trtlAlertaDNColHEntidadXtlHEDN ON dbo.tlAlertaDN.ID = dbo.trtlAlertaDNColHEntidadXtlHEDN.idttlAlertaDN INNER JOIN
        '''                      dbo.tlHEDN ON dbo.trtlAlertaDNColHEntidadXtlHEDN.id [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwAlertasxPresupuesto() As String
            Get
                Return ResourceManager.GetString("vwAlertasxPresupuesto", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwAlertasyUsuario as
        '''SELECT     dbo.tlAlertaDN.ID, dbo.tlAlertaDN.Nombre, dbo.tlAlertaDN.Comentario, dbo.tlAlertaDN.FEjecProgramada, dbo.tlAlertaDN.Atendida, 
        '''                      dbo.tlUsuarioDN.Nombre AS Usuario, dbo.tlHEDN.GUIDReferida
        '''FROM         dbo.tlAlertaDN INNER JOIN
        '''                      dbo.trtlAlertaDNColHEntidadXtlHEDN ON dbo.tlAlertaDN.ID = dbo.trtlAlertaDNColHEntidadXtlHEDN.idttlAlertaDN INNER JOIN
        '''                      dbo.tlHEDN ON dbo.trtlAlertaDNColHEntidadXtlHEDN.idptl [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwAlertasyUsuario() As String
            Get
                Return ResourceManager.GetString("vwAlertasyUsuario", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwCajonDocumentoVerificableXPoliza as SELECT     dbo.tlCajonDocumentoDN.ID, dbo.tlPeriodoRenovacionPolizaDN.ID AS idPR
        '''FROM         dbo.trtlCajonDocumentoDNHuellasEntidadesReferidasXtlHuellaEntidadReferidaCajonDocumentoDN INNER JOIN
        '''                      dbo.tlCajonDocumentoDN ON 
        '''                      dbo.trtlCajonDocumentoDNHuellasEntidadesReferidasXtlHuellaEntidadReferidaCajonDocumentoDN.idttlCajonDocumentoDN = dbo.tlCajonDocumentoDN.ID
        '''                       INNER JOIN
        '''                  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwCajonDocumentoVerificableXPoliza() As String
            Get
                Return ResourceManager.GetString("vwCajonDocumentoVerificableXPoliza", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwCajonDocumentoVerificableXPresupuesto as
        '''
        '''SELECT     dbo.tlCajonDocumentoDN.ID, dbo.tlPresupuestoDN.ID AS idPresupuesto, dbo.tlPeriodoCoberturaDN.ID AS idPeridoCobertura
        '''FROM         dbo.tlPeriodoCoberturaDN RIGHT OUTER JOIN
        '''                      dbo.tlPresupuestoDN INNER JOIN
        '''                      dbo.trtlCajonDocumentoDNHuellasEntidadesReferidasXtlHuellaEntidadReferidaCajonDocumentoDN ON 
        '''                      dbo.tlPresupuestoDN.GUID = dbo.trtlCajonDocumentoDNHuellasEntidadesReferidas [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwCajonDocumentoVerificableXPresupuesto() As String
            Get
                Return ResourceManager.GetString("vwCajonDocumentoVerificableXPresupuesto", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwCajonDocxPoliza as 
        '''SELECT     dbo.tlCajonDocumentoDN.ID, dbo.tlCajonDocumentoDN.FechaVerificacon, dbo.tlTipoFicheroDN.Nombre, dbo.tlCajonDocumentoDN.idDocumento, 
        '''                      dbo.tlAlertaDN.FEjecProgramada, dbo.tlAlertaDN.prioridad, dbo.tlAlertaDN.Comentario, dbo.tlPolizaDN.ID AS idPoliza
        '''FROM         dbo.trtlCajonDocumentoDNHuellasEntidadesReferidasXtlHuellaEntidadReferidaCajonDocumentoDN INNER JOIN
        '''                      dbo.tlCajonDocumentoDN ON 
        '''                      dbo.trt [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwCajonDocxPoliza() As String
            Get
                Return ResourceManager.GetString("vwCajonDocxPoliza", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwCajonDocxPresupuesto as SELECT     dbo.tlCajonDocumentoDN.ID, dbo.tlPresupuestoDN.ID AS idPresupuesto, dbo.tlCajonDocumentoDN.FechaVerificacon, dbo.tlTipoFicheroDN.Nombre, 
        '''                      dbo.tlCajonDocumentoDN.idDocumento, dbo.tlAlertaDN.FEjecProgramada, dbo.tlAlertaDN.prioridad, dbo.tlAlertaDN.Comentario
        '''FROM         dbo.trtlCajonDocumentoDNHuellasEntidadesReferidasXtlHuellaEntidadReferidaCajonDocumentoDN INNER JOIN
        '''                      dbo.tlCajonDocumentoDN ON 
        '''                 [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwCajonDocxPresupuesto() As String
            Get
                Return ResourceManager.GetString("vwCajonDocxPresupuesto", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwImportesDebidosIncidentadosXPR as 
        '''
        '''SELECT     dbo.vwImportesDebidosIncidentados.*, dbo.tlPeriodoRenovacionPolizaOidDN.idPeriodoRenovacionPoliza
        '''FROM         dbo.vwImportesDebidosIncidentados INNER JOIN
        '''                      dbo.tlPeriodoRenovacionPolizaOidDN ON 
        '''                      dbo.vwImportesDebidosIncidentados.idID = dbo.tlPeriodoRenovacionPolizaOidDN.idIImporteDebidoApunteImpDDN.
        '''</summary>
        Friend ReadOnly Property vwImportesDebidosIncidentadosXPR() As String
            Get
                Return ResourceManager.GetString("vwImportesDebidosIncidentadosXPR", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwLiquidacionesxPolizas as SELECT     dbo.vwLiquidacionesXPago.ID, dbo.tlPeriodoRenovacionPolizaDN.idPoliza, dbo.tlPeriodoRenovacionPolizaOidDN.idPeriodoRenovacionPoliza, 
        '''                      dbo.tlPeriodoRenovacionPolizaDN.Periodo_FInicio AS fiPR, dbo.tlPeriodoRenovacionPolizaDN.Periodo_FFinal AS ffPR, 
        '''                      dbo.vwLiquidacionesXPago.idPago, dbo.vwLiquidacionesXPago.ImportePago, dbo.vwLiquidacionesXPago.fePago, dbo.vwLiquidacionesXPago.faPago, 
        '''                      dbo.vwL [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwLiquidacionesxPolizas() As String
            Get
                Return ResourceManager.GetString("vwLiquidacionesxPolizas", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwNotasxPeridoRenovacion as SELECT     dbo.tlNotaDN.ID, dbo.tlNotaDN.Nombre, dbo.tlNotaDN.Comentario, dbo.tlUsuarioDN.Nombre AS Usuario, dbo.tlNotaDN.FechaCreacion, 
        '''                      dbo.tlPeriodoRenovacionPolizaDN.ID AS idPR, dbo.tlPeriodoRenovacionPolizaDN.GUID AS guidPR
        '''FROM         dbo.tlNotaDN INNER JOIN
        '''                      dbo.trtlNotaDNColHEntidadXtlHEDN ON dbo.tlNotaDN.ID = dbo.trtlNotaDNColHEntidadXtlHEDN.idttlNotaDN INNER JOIN
        '''                      dbo.tlUsuarioDN ON dbo.tlN [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwNotasxPeridoRenovacion() As String
            Get
                Return ResourceManager.GetString("vwNotasxPeridoRenovacion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwNotasxPoliza as SELECT     dbo.tlNotaDN.ID, dbo.tlNotaDN.Nombre, dbo.tlNotaDN.Comentario, dbo.tlUsuarioDN.Nombre AS Usuario, dbo.tlNotaDN.FechaCreacion, 
        '''                      dbo.tlPolizaDN.NumeroPoliza, dbo.tlPolizaDN.ID AS idPoliza, dbo.tlPolizaDN.GUID AS guidPoliza
        '''FROM         dbo.tlNotaDN INNER JOIN
        '''                      dbo.trtlNotaDNColHEntidadXtlHEDN ON dbo.tlNotaDN.ID = dbo.trtlNotaDNColHEntidadXtlHEDN.idttlNotaDN INNER JOIN
        '''                      dbo.tlUsuarioDN ON dbo.tlNotaDN.i [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwNotasxPoliza() As String
            Get
                Return ResourceManager.GetString("vwNotasxPoliza", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwPagosxPolizaSimple as 
        '''
        '''SELECT     dbo.tlPagoDN.ID, dbo.tlPagoDN.ImportePago, dbo.tlPagoDN.FechaProgramadaEmision, dbo.tlPagoDN.FechaEmision, 
        '''                      dbo.tlPagoDN.FechaEfectoEsperada, dbo.tlPagoDN.FechaEfecto, dbo.tlPagoDN.FechaAnulacion, dbo.tlEntidadFiscalGenericaDN.ToSt AS Deudor, 
        '''                      tlEntidadFiscalGenericaDN_1.ToSt AS Acreedor, dbo.tlPolizaDN.ID AS idPol, dbo.tlPolizaDN.NumeroPoliza, 
        '''                      dbo.tlPeriodoRenovacionPolizaDN.ID AS idPeri [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwPagosxPolizaSimple() As String
            Get
                Return ResourceManager.GetString("vwPagosxPolizaSimple", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwPeridosRenovacionAlertados as
        '''
        '''SELECT DISTINCT 
        '''                      dbo.tlPeriodoRenovacionPolizaDN.ID, dbo.tlPeriodoRenovacionPolizaDN.idPoliza, dbo.tlPeriodoRenovacionPolizaDN.idPeriodoCoberturaActivo, 
        '''                      dbo.tlAlertaDN.ID AS idAlerta
        '''FROM         dbo.trtlAlertaDNColHEntidadXtlHEDN INNER JOIN
        '''                      dbo.tlAlertaDN ON dbo.trtlAlertaDNColHEntidadXtlHEDN.idttlAlertaDN = dbo.tlAlertaDN.ID INNER JOIN
        '''                      dbo.tlHEDN ON dbo.trtlAlertaDNC [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwPeridosRenovacionAlertados() As String
            Get
                Return ResourceManager.GetString("vwPeridosRenovacionAlertados", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwPeridosRenovacionImpDebIncidentados as
        '''
        '''SELECT     dbo.tlPeriodoRenovacionPolizaDN.ID, dbo.vwImportesDebidosIncidentados.comentario, dbo.tlPeriodoRenovacionPolizaDN.Periodo_FInicio, 
        '''                      dbo.tlPeriodoRenovacionPolizaDN.Periodo_FFinal, dbo.tlPolizaDN.ID AS idPoliza, dbo.tlTomadorDN.Vetado, dbo.tlTomadorDN.NoRenovacion, 
        '''                      dbo.tlTomadorDN.EsImpago, dbo.tlTomadorDN.ToSt AS Tomador
        '''FROM         dbo.tlPeriodoRenovacionPolizaDN INNER JOIN
        '''                  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwPeridosRenovacionImpDebIncidentados() As String
            Get
                Return ResourceManager.GetString("vwPeridosRenovacionImpDebIncidentados", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwPeriodoRenovacionVisRapida  as
        '''
        '''SELECT     dbo.tlPeriodoRenovacionPolizaDN.ID AS id, dbo.tlPolizaDN.NumeroPoliza, dbo.tlTomadorDN.ToSt AS Tomador, dbo.tlRiesgoMotorDN.ToSt AS Riesgo, 
        '''                      dbo.tlPeriodoRenovacionPolizaDN.FCreacion, dbo.tlPeriodoRenovacionPolizaDN.Periodo_FInicio, dbo.tlPeriodoRenovacionPolizaDN.Periodo_FFinal, 
        '''                      dbo.tlPeriodoRenovacionPolizaDN.FechaBaja
        '''FROM         dbo.tlPeriodoRenovacionPolizaDN INNER JOIN
        '''                      dbo [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwPeriodoRenovacionVisRapida() As String
            Get
                Return ResourceManager.GetString("vwPeriodoRenovacionVisRapida", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwPeriodosRenovacionActivoSel as
        '''
        '''SELECT     ID
        '''FROM         dbo.vwPeridosRenovacionAlertados
        '''UNION
        '''SELECT     idPR AS ID
        '''FROM         dbo.vwPeriodosRenovacionXCajonDocVerificables
        '''UNION
        '''SELECT     ID
        '''FROM         dbo.vwPeridosRenovacionImpDebIncidentados.
        '''</summary>
        Friend ReadOnly Property vwPeriodosRenovacionActivoSel() As String
            Get
                Return ResourceManager.GetString("vwPeriodosRenovacionActivoSel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwPeriodosRenovacionXCajonDocVerificables  as SELECT     dbo.tlPeriodoRenovacionPolizaDN.ID AS idPR, dbo.tlPeriodoRenovacionPolizaDN.idPoliza, dbo.tlCajonDocumentoDN.ID AS idCD
        '''FROM         dbo.trtlCajonDocumentoDNHuellasEntidadesReferidasXtlHuellaEntidadReferidaCajonDocumentoDN INNER JOIN
        '''                      dbo.tlCajonDocumentoDN ON 
        '''                      dbo.trtlCajonDocumentoDNHuellasEntidadesReferidasXtlHuellaEntidadReferidaCajonDocumentoDN.idttlCajonDocumentoDN = dbo.tlCajonDocumentoD [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwPeriodosRenovacionXCajonDocVerificables() As String
            Get
                Return ResourceManager.GetString("vwPeriodosRenovacionXCajonDocVerificables", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwPolizasXAlerta as SELECT     dbo.tlPeriodoRenovacionPolizaDN.ID, dbo.tlPolizaDN.NumeroPoliza, dbo.tlPeriodoRenovacionPolizaDN.FCreacion, 
        '''                      dbo.tlPeriodoRenovacionPolizaDN.FechaBaja, dbo.tlPeriodoRenovacionPolizaDN.Periodo_FFinal, dbo.tlPeriodoRenovacionPolizaDN.Periodo_FInicio, 
        '''                      dbo.tlAlertaDN.Atendida, dbo.tlAlertaDN.prioridad, dbo.tlAlertaDN.FEjecProgramada, dbo.tlAlertaDN.Comentario, dbo.tlAlertaDN.idCreador
        '''FROM         dbo.trtlAlertaDNColHEnti [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwPolizasXAlerta() As String
            Get
                Return ResourceManager.GetString("vwPolizasXAlerta", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwPresupActivoPositSel as SELECT     ID
        '''FROM         dbo.vwPresupuestosAlertados
        '''UNION
        '''SELECT     ID
        '''FROM         dbo.vwPresupuestosxCDVerificable.
        '''</summary>
        Friend ReadOnly Property vwPresupActivoPositSel() As String
            Get
                Return ResourceManager.GetString("vwPresupActivoPositSel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwPresupuestos2 as SELECT     dbo.tlPresupuestoDN.ID, dbo.tlMarcaDN.Nombre AS Marca, dbo.tlModeloDN.Nombre AS Modelo, dbo.tlRiesgoMotorDN.Cilindrada, 
        '''                      dbo.tlFuturoTomadorDN.Nombre, 
        '''                      dbo.tlFuturoTomadorDN.Apellido1FuturoTomador, dbo.tlFuturoTomadorDN.Apellido2FuturoTomador, dbo.tlTarifaDN.Importe,
        '''                      dbo.tlFuturoTomadorDN.NIFCIFFuturoTomador AS CifNif, dbo.tlRiesgoMotorDN.NumeroBastidor, dbo.tlRiesgoMotorDN.ValorMatricula AS Matric [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwPresupuestos2() As String
            Get
                Return ResourceManager.GetString("vwPresupuestos2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwPresupuestosAlertados as SELECT   DISTINCT  dbo.tlPresupuestoDN.ID
        '''FROM         dbo.trtlAlertaDNColHEntidadXtlHEDN INNER JOIN
        '''                      dbo.tlAlertaDN ON dbo.trtlAlertaDNColHEntidadXtlHEDN.idttlAlertaDN = dbo.tlAlertaDN.ID INNER JOIN
        '''                      dbo.tlHEDN ON dbo.trtlAlertaDNColHEntidadXtlHEDN.idptlHEDN = dbo.tlHEDN.GUID INNER JOIN
        '''                      dbo.tlPresupuestoDN ON dbo.tlHEDN.GUIDReferida = dbo.tlPresupuestoDN.GUID LEFT OUTER JOIN
        '''                      dbo [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwPresupuestosAlertados() As String
            Get
                Return ResourceManager.GetString("vwPresupuestosAlertados", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwPresupuestosxCDVerificable as SELECT     dbo.tlPresupuestoDN.ID
        '''FROM         dbo.tlPeriodoCoberturaDN RIGHT OUTER JOIN
        '''                      dbo.tlPresupuestoDN INNER JOIN
        '''                      dbo.trtlCajonDocumentoDNHuellasEntidadesReferidasXtlHuellaEntidadReferidaCajonDocumentoDN ON 
        '''                      dbo.tlPresupuestoDN.GUID = dbo.trtlCajonDocumentoDNHuellasEntidadesReferidasXtlHuellaEntidadReferidaCajonDocumentoDN.idptlHuellaEntidadReferidaCajonDocumentoDN
        '''                        [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property vwPresupuestosxCDVerificable() As String
            Get
                Return ResourceManager.GetString("vwPresupuestosxCDVerificable", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to create view vwTomadorEntidadFiscalGen as SELECT     dbo.tlTomadorDN.ID AS idtomador, dbo.tlEntidadFiscalGenericaDN.ValorCifNif, dbo.tlTomadorDN.Baja
        '''FROM         dbo.tlTomadorDN INNER JOIN
        '''                      dbo.tlEntidadFiscalGenericaDN ON dbo.tlTomadorDN.idEntidadFiscalGenerica = dbo.tlEntidadFiscalGenericaDN.ID.
        '''</summary>
        Friend ReadOnly Property vwTomadorEntidadFiscalGen() As String
            Get
                Return ResourceManager.GetString("vwTomadorEntidadFiscalGen", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
