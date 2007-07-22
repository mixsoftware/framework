﻿'The following code was generated by Microsoft Visual Studio 2005.
'The test owner should check each test for validity.
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System
Imports System.Text
Imports System.Collections.Generic
Imports FN.Seguros.Polizas.DN
Imports Framework.DatosNegocio


'''<summary>
'''This is a test class for FN.Seguros.Polizas.DN.PeriodoAnualDN and is intended
'''to contain all FN.Seguros.Polizas.DN.PeriodoAnualDN Unit Tests
'''</summary>
<TestClass()> _
Public Class PeriodoAnualDNTest

    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = value
        End Set
    End Property
#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''A test for EstadoIntegridad(ByRef String)
    '''</summary>
    <TestMethod()> _
    Public Sub EstadoIntegridadTest()
        Dim target As PeriodoRenovacionPolizaDN = New PeriodoRenovacionPolizaDN

        Dim pMensaje As String = String.Empty
        Dim pMensaje_expected As String = String.Empty

        Dim expected As EstadoIntegridadDN
        Dim actual As EstadoIntegridadDN

        Dim pCob1 As New PeriodoCoberturaDN()
        Dim pCob2 As New PeriodoCoberturaDN()
        Dim pCob3 As New PeriodoCoberturaDN()
        Dim pCob4 As New PeriodoCoberturaDN()

        'Caso 1: periodos correctos
        target.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 1, 1), New Date(2007, 12, 31))
        pCob1.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 1, 1), New Date(2007, 1, 31))
        pCob2.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 2, 1), New Date(2007, 2, 28))
        pCob3.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 3, 15), New Date(2007, 4, 15))
        pCob4.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 5, 17), New Date(2007, 5, 18))
        target.ColPeriodosCobertura.Add(pCob1)
        target.ColPeriodosCobertura.Add(pCob2)
        target.ColPeriodosCobertura.Add(pCob3)
        target.ColPeriodosCobertura.Add(pCob4)

        pMensaje_expected = String.Empty
        expected = EstadoIntegridadDN.Consistente

        actual = target.EstadoIntegridad(pMensaje)

        Assert.AreEqual(pMensaje_expected, pMensaje, "pMensaje_EstadoIntegridad_expected was not set correctly.")
        Assert.AreEqual(expected, actual, "FN.Seguros.Polizas.DN.PeriodoAnualDN.EstadoIntegridad did not return the expected" & _
                " value.")
        'Assert.Inconclusive("Verify the correctness of this test method.")

        'Caso 2: periodos incorrectos al no estar contenidos en el periodo anual
        target.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 1, 1), New Date(2007, 12, 31))
        pCob1.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 1, 1), New Date(2007, 1, 31))
        pCob2.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 2, 1), New Date(2007, 2, 28))
        pCob3.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 3, 15), New Date(2007, 4, 15))
        pCob4.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 5, 17), New Date(2008, 1, 1))
        target.ColPeriodosCobertura.Add(pCob1)
        target.ColPeriodosCobertura.Add(pCob2)
        target.ColPeriodosCobertura.Add(pCob3)
        target.ColPeriodosCobertura.Add(pCob4)

        pMensaje_expected = "Los periodos de cobertura deben estar contenidos en el periodo anual"
        expected = EstadoIntegridadDN.Inconsistente

        actual = target.EstadoIntegridad(pMensaje)

        Assert.AreEqual(pMensaje_expected, pMensaje, "pMensaje_EstadoIntegridad_expected was not set correctly.")
        Assert.AreEqual(expected, actual, "FN.Seguros.Polizas.DN.PeriodoAnualDN.EstadoIntegridad did not return the expected" & _
                " value.")
        'Assert.Inconclusive("Verify the correctness of this test method.")


        'Caso 3: periodos incorrectos por solaparse
        target.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 1, 1), New Date(2007, 12, 31))
        pCob1.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 1, 1), New Date(2007, 1, 31))
        pCob2.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 1, 15), New Date(2007, 2, 28))
        pCob3.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 3, 15), New Date(2007, 4, 15))
        pCob4.Periodo = New Framework.DatosNegocio.Localizaciones.Temporales.IntervaloFechasDN(New Date(2007, 4, 1), New Date(2007, 5, 18))
        target.ColPeriodosCobertura.Add(pCob1)
        target.ColPeriodosCobertura.Add(pCob2)
        target.ColPeriodosCobertura.Add(pCob3)
        target.ColPeriodosCobertura.Add(pCob4)

        pMensaje_expected = "Los periodos de cobertura dentro de un periodo anual no pueden solapar"
        expected = EstadoIntegridadDN.Inconsistente

        actual = target.EstadoIntegridad(pMensaje)

        Assert.AreEqual(pMensaje_expected, pMensaje, "pMensaje_EstadoIntegridad_expected was not set correctly.")
        Assert.AreEqual(expected, actual, "FN.Seguros.Polizas.DN.PeriodoAnualDN.EstadoIntegridad did not return the expected" & _
                " value.")
        'Assert.Inconclusive("Verify the correctness of this test method.")


    End Sub

End Class
