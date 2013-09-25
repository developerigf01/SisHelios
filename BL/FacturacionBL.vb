﻿Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.Data

Public Class FacturacionBL


    Public Class SG_FA_TB_CLIENTE_COMUNI
        Inherits ClsBD

        Public Sub Insert(Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_CLIENTE_COMUNI", Entidad.CC_IDCLIENTE, Entidad.CC_IDCOMUNICA, Entidad.CC_DESCRIPCION)
        End Sub

        Public Sub Delete_all_xId(Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_CLIENTE_COMUNI", Entidad.CC_IDCLIENTE)
        End Sub

        Public Function get_Comuninicaciones_xId(Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CLIENTE_COMUNI", Entidad.CC_IDCLIENTE).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_TIPO_COMUNICACION
        Inherits ClsBD

        Public Function getTipos(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_TIPO_COMUN", empresa_).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_CIA_ASEG
        Inherits ClsBD

        Public Function getAseguradoras(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CIA_ASEG_01", empresa_).Tables(0)
        End Function

    End Class


    Public Class SG_FA_TB_TIPO_ARTICULO
        Inherits ClsBD

        Public Function getTipos(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_TIPO_ARTICULO", empresa_).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_DOCU_PAGO
        Inherits ClsBD

        Public Sub Insert(Entidad As BE.FacturacionBE.SG_FA_TB_DOCU_PAGO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_DOCU_PAGO", .DP_CODIGO, .DP_DESCRIPCION, .DP_ABREVIATURA, .DP_CTA_CONTA.PC_NUM_CUENTA, .DP_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Update(Entidad As BE.FacturacionBE.SG_FA_TB_DOCU_PAGO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_DOCU_PAGO", .DP_CODIGO, .DP_DESCRIPCION, .DP_ABREVIATURA, .DP_CTA_CONTA.PC_NUM_CUENTA, .DP_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Delete(Entidad As BE.FacturacionBE.SG_FA_TB_DOCU_PAGO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_DOCU_PAGO", .DP_CODIGO, .DP_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Function get_DocuPagos(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_DOCU_PAGO", empresa_).Tables(0)
        End Function

        Public Function get_DocuPagos_x_Id(Entidad As BE.FacturacionBE.SG_FA_TB_DOCU_PAGO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_DOCU_PAGO", Entidad.DP_CODIGO, Entidad.DP_IDEMPRESA.EM_ID).Tables(0)
        End Function

    End Class


    Public Class SG_FA_TB_PARIDAD
        Inherits ClsBD

        Public Sub Insert(Entidad As BE.FacturacionBE.SG_FA_TB_PARIDAD)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_PARIDAD", .PA_FECHA, .PA_IDMONEDA.MO_ID, .PA_COMPRA, .PA_VENTA, .PA_IDEMPRESA.EM_ID, .PA_USUARIO, .PA_TERMINAL, .PA_FECREG)
            End With
        End Sub

        Public Sub Update(Entidad As BE.FacturacionBE.SG_FA_TB_PARIDAD)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_PARIDAD", .PA_FECHA, .PA_IDMONEDA.MO_ID, .PA_COMPRA, .PA_VENTA, .PA_IDEMPRESA.EM_ID, .PA_USUARIO, .PA_TERMINAL, .PA_FECREG)
            End With
        End Sub

        Public Function get_Pariedad_x_Ayo(Entidad As BE.FacturacionBE.SG_FA_TB_PARIDAD) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PARIDAD", CDate(Entidad.PA_FECHA).Year, Entidad.PA_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Pariedad_x_Fecha(Entidad As BE.FacturacionBE.SG_FA_TB_PARIDAD) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PARIDAD_X_FEC", Entidad.PA_IDEMPRESA.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_MONEDA
        Inherits ClsBD

        Public Function get_Monedas(empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_MONEDA", empresa.EM_ID).Tables(0)
        End Function

        Public Function get_Moneda(Entidad As BE.FacturacionBE.SG_FA_TB_MONEDA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_MONEDA_X_ID", Entidad.MO_ID, Entidad.MO_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Sub Insert(Entidad As BE.FacturacionBE.SG_FA_TB_MONEDA)
            Dim cod_mon_cod As Integer = 0

            If Not Entidad.MO_IDMON_CONTA Is Nothing Then
                cod_mon_cod = Entidad.MO_IDMON_CONTA.MO_CODIGO
            End If

            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_MONEDA", .MO_ID, .MO_DESCRIPCION, .MO_ABREVIATURA, .MO_SIMBOLO, _
                                          IIf(cod_mon_cod = 0, DBNull.Value, cod_mon_cod), _
                                          .MO_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Update(Entidad As BE.FacturacionBE.SG_FA_TB_MONEDA)

            Dim cod_mon_cod As Integer = 0

            If Not Entidad.MO_IDMON_CONTA Is Nothing Then
                cod_mon_cod = Entidad.MO_IDMON_CONTA.MO_CODIGO
            End If

            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_MONEDA", .MO_ID, .MO_DESCRIPCION, .MO_ABREVIATURA, .MO_SIMBOLO, _
                                          IIf(cod_mon_cod = 0, DBNull.Value, cod_mon_cod), _
                                          .MO_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Delete(Entidad As BE.FacturacionBE.SG_FA_TB_MONEDA)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_MONEDA", .MO_ID, .MO_IDEMPRESA)
            End With
        End Sub

    End Class

    Public Class SG_FA_TB_CAJERO
        Inherits ClsBD

        Public Function get_Cajeros(empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CAJERO", empresa.EM_ID).Tables(0)
        End Function

        Public Function get_Cajero(Entidad As BE.FacturacionBE.SG_FA_TB_CAJERO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CAJERO_X_ID", Entidad.CA_ID, Entidad.CA_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Sub Insert(Entidad As BE.FacturacionBE.SG_FA_TB_CAJERO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_CAJERO", .CA_ID, .CA_NOMBRES, .CA_IDUSUARIO.US_ID, .CA_IDEMPRESA.EM_ID, .CA_USUARIO, .CA_TERMINAL, .CA_FECREG, .CA_ESTADO)
            End With
        End Sub

        Public Sub Update(Entidad As BE.FacturacionBE.SG_FA_TB_CAJERO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_CAJERO", .CA_ID, .CA_NOMBRES, .CA_IDUSUARIO.US_ID, .CA_IDEMPRESA.EM_ID, .CA_USUARIO, .CA_TERMINAL, .CA_FECREG, .CA_ESTADO)
            End With
        End Sub

        Public Sub Delete(Entidad As BE.FacturacionBE.SG_FA_TB_CAJERO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_CAJERO", .CA_ID, .CA_IDEMPRESA.EM_ID)
            End With
        End Sub

    End Class

    Public Class SG_FA_TB_DOCUMENTO
        Inherits ClsBD

        Public Sub Insert(entidad As BE.FacturacionBE.SG_FA_TB_DOCUMENTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_DOCUMENTO", .DO_CODIGO, .DO_DESCRIPCION, .DO_ABREVIATURA, .DO_ES_RESTA, .DO_ISTATUS, .DO_CODIGO_SUNAT, .DO_USUARIO, .DO_TERMINAL, .DO_FECREG, .DO_IDEMPRESA.EM_ID, .DO_COD_CONTA)
            End With
        End Sub

        Public Sub Update(entidad As BE.FacturacionBE.SG_FA_TB_DOCUMENTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_DOCUMENTO", .DO_CODIGO, .DO_DESCRIPCION, .DO_ABREVIATURA, .DO_ES_RESTA, .DO_ISTATUS, .DO_CODIGO_SUNAT, .DO_USUARIO, .DO_TERMINAL, .DO_FECREG, .DO_IDEMPRESA.EM_ID, .DO_COD_CONTA)
            End With
        End Sub

        Public Sub Delete(entidad As BE.FacturacionBE.SG_FA_TB_DOCUMENTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_DOCUMENTO", .DO_CODIGO, .DO_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Function get_Documentos(entidad As BE.FacturacionBE.SG_FA_TB_DOCUMENTO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_DOCUMENTO", entidad.DO_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Sub get_Documentos_x_Cod(ByRef entidad As BE.FacturacionBE.SG_FA_TB_DOCUMENTO)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_DOCUMENTO_X_ID", entidad.DO_CODIGO, entidad.DO_IDEMPRESA.EM_ID)
            If drr.HasRows Then
                drr.Read()
                With entidad
                    .DO_DESCRIPCION = drr("DO_DESCRIPCION").ToString
                    .DO_ABREVIATURA = drr("DO_ABREVIATURA").ToString
                    .DO_ES_RESTA = drr("DO_ES_RESTA")
                    .DO_ISTATUS = drr("DO_ISTATUS")
                    .DO_CODIGO_SUNAT = drr("DO_CODIGO_SUNAT").ToString
                    .DO_COD_CONTA = drr("DO_COD_CONTA")
                    '.DO_CODIGO = drr("DO_CODIGO")
                    '.DO_IDEMPRESA = drr("DO_CODIGO")
                End With
            End If
            drr.Close()
            drr = Nothing
        End Sub

    End Class

    Public Class SG_FA_TB_PARAMETROS
        Inherits ClsBD

        Public Function get_Valor(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PARAMETROS) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_VAL_PARA", entidad.AD_TIPO, entidad.AD_NOMBRE, entidad.AD_IDEMPRESA.EM_ID)
        End Function

        Public Function get_Lista_Parametros(empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PARAMETROS", empresa.EM_ID).Tables(0)
        End Function

        Public Sub Insert(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PARAMETROS)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_PARAMETROS", entidad.AD_TIPO, entidad.AD_NOMBRE, entidad.AD_VALOR, entidad.AD_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Update(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PARAMETROS)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_PARAMETROS", entidad.AD_TIPO, entidad.AD_NOMBRE, entidad.AD_VALOR, entidad.AD_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Delete(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PARAMETROS)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_PARAMETROS", entidad.AD_TIPO, entidad.AD_NOMBRE, entidad.AD_IDEMPRESA.EM_ID)
        End Sub

    End Class

    Public Class SG_FA_TB_USU_PTOVTA
        Inherits ClsBD

        Public Sub Insert(entidad As BE.FacturacionBE.SG_FA_TB_USU_PTOVTA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_USU_PTOVTA", entidad.UP_IDUSARIO.US_ID, entidad.UP_IDPTO_VTA.PV_ID, entidad.UP_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Delete(entidad As BE.FacturacionBE.SG_FA_TB_USU_PTOVTA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_USU_PTOVTA", entidad.UP_IDUSARIO.US_ID, entidad.UP_IDPTO_VTA.PV_ID, entidad.UP_IDEMPRESA.EM_ID)
        End Sub

        Public Function get_Lista_PtosVtas_x_Usuario(entidad As BE.FacturacionBE.SG_FA_TB_USU_PTOVTA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_USU_PTOVTA", entidad.UP_IDUSARIO.US_ID, entidad.UP_IDEMPRESA.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_FORMA_PAGO
        Inherits ClsBD

        Public Sub Insert(entidad As BE.FacturacionBE.SG_FA_TB_FORMA_PAGO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_FORMA_PAGO", entidad.FP_ID, entidad.FP_DESCRIPCION, entidad.FP_ES_CREDITO, entidad.FP_DIAS_CREDITO, entidad.FP_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Update(entidad As BE.FacturacionBE.SG_FA_TB_FORMA_PAGO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_FORMA_PAGO", entidad.FP_ID, entidad.FP_DESCRIPCION, entidad.FP_ES_CREDITO, entidad.FP_DIAS_CREDITO, entidad.FP_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Delete(entidad As BE.FacturacionBE.SG_FA_TB_FORMA_PAGO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_FORMA_PAGO", entidad.FP_ID, entidad.FP_IDEMPRESA.EM_ID)
        End Sub

        Public Function get_Lista_FP(empresa_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_FORMA_PAGO", empresa_.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_PTO_VTA_SERIE
        Inherits ClsBD

        Public Sub Insert(entidad As BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_PTO_VTA_SERIE", entidad.PS_IDPUNTOVTA.PV_ID, entidad.PS_SERIE, entidad.PC_IDEMPRESA.EM_ID, entidad.PS_TD.DO_CODIGO)
        End Sub

        Public Sub Delete(entidad As BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_PTO_VTA_SERIE", entidad.PS_IDPUNTOVTA.PV_ID, entidad.PS_SERIE, entidad.PC_IDEMPRESA.EM_ID, entidad.PS_TD.DO_CODIGO)
        End Sub

        Public Function get_Lista_Series(entidad As BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PTO_VTA_SERIE", entidad.PS_IDPUNTOVTA.PV_ID, entidad.PC_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_TD_X_PtoVta(entidad As BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_TD_X_PTO_VTA", entidad.PS_IDPUNTOVTA.PV_ID, entidad.PC_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Serie_x_TipDoc_x_PtoVta(entidad As BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_SERIE_X_TD_X_PV", entidad.PS_IDPUNTOVTA.PV_ID, entidad.PS_TD.DO_CODIGO, entidad.PC_IDEMPRESA.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_PUNTO_VENTA
        Inherits ClsBD

        Public Sub Insert(entidad As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_PUNTO_VENTA", entidad.PV_ID, entidad.PV_DESCRIPCION, entidad.PV_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Update(entidad As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_PUNTO_VENTA", entidad.PV_ID, entidad.PV_DESCRIPCION, entidad.PV_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Delete(entidad As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_PUNTO_VENTA", entidad.PV_ID, entidad.PV_IDEMPRESA.EM_ID)
        End Sub

        Public Function get_Lista_PuntaVentas(empresa_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PUNTO_VENTA", empresa_.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_NUM_COMPRO
        Inherits ClsBD

        Public Sub Insert(entidad As BE.FacturacionBE.SG_FA_TB_NUM_COMPRO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_NUM_COMPRO", entidad.NC_IDTIPO.DO_CODIGO, entidad.NC_SERIE, entidad.NC_NUMERO, entidad.NC_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Update(entidad As BE.FacturacionBE.SG_FA_TB_NUM_COMPRO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_NUM_COMPRO", entidad.NC_IDTIPO.DO_CODIGO, entidad.NC_SERIE, entidad.NC_NUMERO, entidad.NC_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Delete(entidad As BE.FacturacionBE.SG_FA_TB_NUM_COMPRO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_NUM_COMPRO", entidad.NC_IDTIPO.DO_CODIGO, entidad.NC_SERIE, entidad.NC_IDEMPRESA.EM_ID)
        End Sub

        Public Function get_Lista_Numeracion(empresa_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_NUM_COMPRO", empresa_.EM_ID).Tables(0)
        End Function

        Public Function get_Series_xTD(entidad As BE.FacturacionBE.SG_FA_TB_NUM_COMPRO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_SERIES_XTD", entidad.NC_IDTIPO.DO_CODIGO, entidad.NC_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_NumCompro_xTD_SD(entidad As BE.FacturacionBE.SG_FA_TB_NUM_COMPRO) As String
            Dim ult_num As String = String.Empty
            ult_num = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_NUMCOMPRO_XTD_SD", entidad.NC_IDTIPO.DO_CODIGO, entidad.NC_SERIE, entidad.NC_IDEMPRESA.EM_ID)

            ult_num = (CInt(ult_num) + 1).ToString.PadLeft(10, "0")

            Return ult_num

        End Function

    End Class

    Public Class SG_FA_TB_FAMILIA_ARTI
        Inherits ClsBD

        Public Sub Insert(Entidad As BE.FacturacionBE.SG_FA_TB_FAMILIA_ARTI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_FAMILIA_ARTI", Entidad.FA_CODIGO, Entidad.FA_DESCRIPCION, Entidad.FA_IDEMPRESA)
        End Sub

        Public Sub Update(Entidad As BE.FacturacionBE.SG_FA_TB_FAMILIA_ARTI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_FAMILIA_ARTI", Entidad.FA_CODIGO, Entidad.FA_DESCRIPCION, Entidad.FA_IDEMPRESA)
        End Sub

        Public Sub Delete(Entidad As BE.FacturacionBE.SG_FA_TB_FAMILIA_ARTI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_FAMILIA_ARTI", Entidad.FA_CODIGO, Entidad.FA_IDEMPRESA)
        End Sub

        Public Function get_Familias(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_FAMILIA_ARTI", empresa_).Tables(0)
        End Function

        Public Function get_Familias_Combo(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_FAMILIA_ARTI_COMBO", empresa_).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_CATEGORIA_ARTI
        Inherits ClsBD

        Public Sub Insert(Entidad As BE.FacturacionBE.SG_FA_TB_CATEGORIA_ARTI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_CATEGORIA_ARTI", Entidad.CA_CODIGO, Entidad.CA_DESCRIPCION, Entidad.CA_IDFAMILIA, Entidad.CA_IDEMPRESA)
        End Sub

        Public Sub Update(Entidad As BE.FacturacionBE.SG_FA_TB_CATEGORIA_ARTI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_CATEGORIA_ARTI", Entidad.CA_CODIGO, Entidad.CA_DESCRIPCION, Entidad.CA_IDFAMILIA, Entidad.CA_IDEMPRESA)
        End Sub

        Public Sub Delete(Entidad As BE.FacturacionBE.SG_FA_TB_CATEGORIA_ARTI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_CATEGORIA_ARTI", Entidad.CA_CODIGO, Entidad.CA_IDEMPRESA)
        End Sub

        Public Function get_Categorias(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CATEGORIA_ARTI", empresa_).Tables(0)
        End Function

        Public Function get_Categorias_x_Familia(entidad As BE.FacturacionBE.SG_FA_TB_FAMILIA_ARTI) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CATEGORIA_ARTI_X_FAMI", entidad.FA_IDEMPRESA, entidad.FA_CODIGO).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_ARTICULO
        Inherits ClsBD

        Public Sub Insert(Entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_ARTICULO_F", .AR_CODIGO, .AR_CODIGO_ALT, .AR_DESCRIPCION, .AR_PRECIO_VENTA, .AR_IDFAMILIA, .AR_IDCATEGORIA, .AR_NUM_CTA_CONTA, .AR_ESTADO, .AR_IDEMPRESA, .AR_USUARIO, .AR_TERMINAL, .AR_FECREG, .AR_TIPO_ARTI, .AR_INCLUYE_IGV, .AR_ING_RAP, .AR_MON_VTA, .AR_CTRL_STOCK, .AR_ORIGEN)
            End With
        End Sub

        Public Sub Update(Entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_ARTICULO_F", .AR_CODIGO, .AR_CODIGO_ALT, .AR_DESCRIPCION, .AR_PRECIO_VENTA, .AR_IDFAMILIA, .AR_IDCATEGORIA, .AR_NUM_CTA_CONTA, .AR_ESTADO, .AR_IDEMPRESA, .AR_USUARIO, .AR_TERMINAL, .AR_FECREG, .AR_TIPO_ARTI, .AR_INCLUYE_IGV, .AR_ING_RAP, .AR_MON_VTA, .AR_CTRL_STOCK, .AR_ORIGEN)
            End With
        End Sub

        Public Sub Delete(Entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_ARTICULO", .AR_CODIGO, .AR_IDEMPRESA)
            End With
        End Sub

        Public Function get_Articulos_FA(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_01_F", empresa_).Tables(0)
        End Function

        Public Function get_Articulo(entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_X_ID", entidad.AR_CODIGO, entidad.AR_IDEMPRESA).Tables(0)
        End Function

        Public Sub get_Articulo_x_Cod(ByRef entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO)

            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_X_ID", entidad.AR_CODIGO, entidad.AR_IDEMPRESA).Tables(0)

            If dt_tmp.Rows.Count > 0 Then
                With entidad
                    .AR_CODIGO = dt_tmp.Rows(0)("AR_CODIGO").ToString
                    .AR_CODIGO_ALT = dt_tmp(0)("AR_CODIGO_ALT").ToString
                    .AR_DESCRIPCION = dt_tmp(0)("AR_DESCRIPCION").ToString
                    .AR_PRECIO_VENTA = dt_tmp(0)("AR_PRECIO_VENTA")
                    .AR_IDFAMILIA = dt_tmp(0)("AR_IDFAMILIA").ToString
                    .AR_IDCATEGORIA = dt_tmp(0)("AR_IDCATEGORIA").ToString
                    .AR_NUM_CTA_CONTA = dt_tmp(0)("AR_NUM_CTA_CONTA").ToString
                    .AR_ESTADO = dt_tmp(0)("AR_ESTADO")
                    '.AR_IDEMPRESA = dt_tmp(0)("AR_IDEMPRESA")
                    .AR_TIPO_ARTI = dt_tmp(0)("AR_TIPO_ARTI").ToString
                    .AR_INCLUYE_IGV = dt_tmp(0)("AR_INCLUYE_IGV")
                    .AR_ING_RAP = dt_tmp(0)("AR_ING_RAP")
                End With
            End If

            dt_tmp.Dispose()

        End Sub

        Public Sub get_Articulo_IngRapido(ByRef entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO)

            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_INGRAP", entidad.AR_IDEMPRESA).Tables(0)

            If dt_tmp.Rows.Count > 0 Then
                With entidad
                    .AR_CODIGO = dt_tmp.Rows(0)("AR_CODIGO").ToString
                    .AR_CODIGO_ALT = dt_tmp(0)("AR_CODIGO_ALT").ToString
                    .AR_DESCRIPCION = dt_tmp(0)("AR_DESCRIPCION").ToString
                    .AR_PRECIO_VENTA = dt_tmp(0)("AR_PRECIO_VENTA")
                    .AR_IDFAMILIA = dt_tmp(0)("AR_IDFAMILIA").ToString
                    .AR_IDCATEGORIA = dt_tmp(0)("AR_IDCATEGORIA").ToString
                    .AR_NUM_CTA_CONTA = dt_tmp(0)("AR_NUM_CTA_CONTA").ToString
                    .AR_ESTADO = dt_tmp(0)("AR_ESTADO")
                    '.AR_IDEMPRESA = dt_tmp(0)("AR_IDEMPRESA")
                    .AR_TIPO_ARTI = dt_tmp(0)("AR_TIPO_ARTI").ToString
                    .AR_INCLUYE_IGV = dt_tmp(0)("AR_INCLUYE_IGV")
                    .AR_ING_RAP = dt_tmp(0)("AR_ING_RAP")
                End With
            End If

            dt_tmp.Dispose()

        End Sub

        Public Function get_Articulos_Ayuda(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_01", empresa_).Tables(0)
        End Function

        Public Function Existe_Arti_Ingreso_Rap(entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO) As Boolean
            Dim rpta As Boolean = False
            Dim num As Integer = 0

            num = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_NUM_ART_ING_RAP", entidad.AR_CODIGO, entidad.AR_IDEMPRESA)

            If num > 0 Then
                rpta = True
            End If

            Return rpta

        End Function

        Public Function get_Codigo_Articulo_Nuevo(empresa_ As Integer, tipo_ As String) As String
            Dim respuesta As String = String.Empty

            Dim query As String = "SELECT MAX( CAST(SUBSTRING(AR_CODIGO,2,4) AS INT)) FROM SG_FA_TB_ARTICULO WHERE AR_TIPO_ARTI = '" & tipo_ & "' and AR_IDEMPRESA = " & empresa_.ToString
            Dim ult_codigo As String = SqlHelper.ExecuteScalar(Cn, CommandType.Text, query).ToString

            If ult_codigo.Length > 0 Then
                Dim ult_num As Integer = ult_codigo 'ult_codigo.Remove(0, 1)
                Dim letra_articulo As String = tipo_.ToUpper
                respuesta = letra_articulo & (ult_num + 1).ToString.PadLeft(4, "0")
            Else
                respuesta = tipo_ & "0001"
            End If

            Return respuesta

        End Function

    End Class

    Public Class SG_FA_TB_CLIENTE
        Inherits ClsBD

        Public Sub Insert(Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE, ls_comunica As List(Of BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI))

            With Entidad

                If SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_CLIENTE_X_DOC", .CL_NDOC, .CL_IDEMPRESA.EM_ID) > 0 Then
                    Throw New Exception("El Cliente con numero de documento " & .CL_NDOC & " ya se encuentra registrado.")
                    Exit Sub
                End If

                Dim IdCliente As Integer = 0

                IdCliente = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_CLIENTE", .CL_NOMBRE, .CL_TDOC.DI_CODIGO, .CL_NDOC, _
                                          .CL_DIRECCION, .CL_ES_RELACIONADO, .CL_USUARIO, _
                                          .CL_TERMINAL, .CL_FECREG, .CL_IDEMPRESA.EM_ID, .CL_ESTADO, .CL_FICHA_TEC, .CL_UBIGEO)

                If Not ls_comunica Is Nothing Then
                    If ls_comunica.Count > 0 Then
                        Dim x As New SG_FA_TB_CLIENTE_COMUNI

                        'Borramos todo del cliente
                        x.Delete_all_xId(ls_comunica(0))

                        'Grabamos los telefonos,movil's, correos,etc
                        For Each item As BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI In ls_comunica
                            item.CC_IDCLIENTE = IdCliente
                            x.Insert(item)
                        Next

                        x = Nothing
                    End If
                End If



                'si tiene numero de documento lo registramos en contabilidad
                If .CL_NDOC.Length > 0 Then

                    Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                    Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                    anexoBE.AN_IDANEXO = 0
                    anexoBE.AN_DESCRIPCION = .CL_NOMBRE
                    anexoBE.AN_ES_RELACIONADO = .CL_ES_RELACIONADO
                    anexoBE.AN_IDEMPRESA = .CL_IDEMPRESA
                    anexoBE.AN_NUM_DOC = .CL_NDOC
                    anexoBE.AN_PC_FECREG = .CL_FECREG
                    anexoBE.AN_PC_TERMINAL = .CL_TERMINAL
                    anexoBE.AN_PC_USUARIO = .CL_USUARIO
                    anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    anexoBE.AN_TIPO_DOC = New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = Entidad.CL_TDOC.DI_CODIGO}
                    anexoBE.AN_TIPO_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = BE.ContabilidadBE.TipoEmpresa.Natural}

                    anexoBL.Insert_x_Facturacion(anexoBE, IdCliente)

                    anexoBE = Nothing
                    anexoBL = Nothing

                End If

            End With

        End Sub

        Public Sub Update(Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE, ls_comunica As List(Of BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI))
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_CLIENTE", .CL_ID, .CL_NOMBRE, .CL_TDOC.DI_CODIGO, _
                                          .CL_NDOC, .CL_DIRECCION, .CL_ES_RELACIONADO, .CL_USUARIO, .CL_TERMINAL, _
                                          .CL_FECREG, .CL_IDEMPRESA.EM_ID, .CL_ESTADO, .CL_FICHA_TEC, .CL_UBIGEO)


                If ls_comunica.Count > 0 Then
                    Dim x As New SG_FA_TB_CLIENTE_COMUNI

                    'Borramos todo del cliente
                    x.Delete_all_xId(ls_comunica(0))

                    'Grabamos los telefonos,movil's, correos,etc
                    For Each item As BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI In ls_comunica
                        x.Insert(item)
                    Next

                    x = Nothing
                End If


            End With
        End Sub

        Public Sub Delete(Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_CLIENTE", .CL_ID, .CL_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Function get_Clientes(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CLIENTE", empresa_).Tables(0)
        End Function

        Public Sub get_Cliente_x_Id(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_CLIENTE_X_ID", Entidad.CL_ID, Entidad.CL_IDEMPRESA.EM_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .CL_ID = drr("CL_ID")
                    .CL_NOMBRE = drr("CL_NOMBRE").ToString
                    .CL_TDOC = New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = drr("CL_TDOC")}
                    .CL_NDOC = drr("CL_NDOC").ToString
                    .CL_DIRECCION = drr("CL_DIRECCION").ToString
                    .CL_ES_RELACIONADO = drr("CL_ES_RELACIONADO")
                    .CL_UBIGEO = drr("CL_UBIGEO")
                    .CL_FICHA_TEC = drr("CL_FICHA_TEC")
                    .CL_ESTADO = drr("CL_ESTADO")
                    .CL_IDANEX_CONTA = drr("CL_IDANEX_CONTA")
                End With
            End If

            drr.Close()

        End Sub

        Public Sub get_Cliente_x_Ruc(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_CLIENTE_X_RUC", Entidad.CL_NDOC, Entidad.CL_IDEMPRESA.EM_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .CL_ID = drr("CL_ID")
                    .CL_NOMBRE = drr("CL_NOMBRE").ToString
                    .CL_TDOC = New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = drr("CL_TDOC")}
                    .CL_NDOC = drr("CL_NDOC").ToString
                    .CL_DIRECCION = drr("CL_DIRECCION").ToString
                    .CL_ES_RELACIONADO = drr("CL_ES_RELACIONADO")
                    .CL_UBIGEO = drr("CL_UBIGEO")
                    .CL_FICHA_TEC = drr("CL_FICHA_TEC")
                    .CL_ESTADO = drr("CL_ESTADO")
                End With
            End If

            drr.Close()

        End Sub


        Public Function get_Clientes_Ayuda(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CLI_AYUDA", empresa_).Tables(0)
        End Function

        Public Function get_Anexo_Boleta(ByVal empresa As Integer) As List(Of String)
            Dim query As String = "select CL_ID,CL_NDOC,CL_NOMBRE from SG_FA_TB_CLIENTE where CL_NDOC = '00000000001' and CL_IDEMPRESA = " & empresa.ToString
            Dim lista As New List(Of String)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, CommandType.Text, query)

            If drr.HasRows Then
                drr.Read()
                lista.Add(drr("CL_ID"))
                lista.Add(drr("CL_NDOC"))
                lista.Add(drr("CL_NOMBRE"))
            End If

            drr.Close()

            Return lista

        End Function

    End Class

    Public Class SG_FA_TB_COMPROBANTE_C
        Inherits ClsBD

        Public Sub Insert(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C, ByRef numVoucherConta As String)

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                Dim idCabecera As Integer = 0
                Dim cod_Doc_ref As String = String.Empty

                If Not Entidad.CO_TDOC_REF Is Nothing Then
                    cod_Doc_ref = Entidad.CO_TDOC_REF.DO_CODIGO
                End If

                With Entidad
                    idCabecera = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_I_COMPROBANTE_C", .CO_TDOC.DO_CODIGO, _
                                                  .CO_SDOC, .CO_NDOC, CDate(.CO_FEC_EMI).ToShortDateString, CDate(.CO_FEC_VEN).ToShortDateString, .CO_SUBTOTAL, _
                                                  .CO_SUBTOTAL_NA, .CO_IGV, .CO_TOTAL, .CO_IDMONEDA.MO_ID, _
                                                  .CO_TCAM, _
                                                  IIf(cod_Doc_ref = String.Empty, DBNull.Value, cod_Doc_ref), _
                                                  .CO_SDOC_REF, .CO_NDOC_REF, _
                                                  IIf(.CO_FEC_EMI_REF = String.Empty, DBNull.Value, .CO_FEC_EMI_REF), _
                                                  IIf(.CO_FEC_VEN_REF = String.Empty, DBNull.Value, .CO_FEC_VEN_REF), _
                                                  .CO_IDEMPRESA.EM_ID, .CO_USUARIO, _
                                                  .CO_TERMINAL, .CO_FECREG, .CO_IDCLIENTE.CL_ID, .CO_NOTAS, .CO_ESTADO, _
                                                  .CO_IDPTOVTA.PV_ID, .CO_IDFORMA_PAGO.FP_ID, .CO_ES_CONTA_PROVI, .CO_ES_CONTA_CANCE, _
                                                  .CO_IDUSUARIO.US_ID, .CO_IDDOCU_PAGO.DP_CODIGO, .CO_REF_PAGO, .CO_ES_REEMPLA, .CO_DNI, .CO_TASA_IGV)
                End With


                Entidad.CO_ID = idCabecera

                SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_D_COMPROBANTE_D", Entidad.CO_ID)

                For Each deta_compro In Entidad.Detalles

                    With deta_compro
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_I_COMPROBANTE_D", Entidad.CO_ID, .CD_ITEM, _
                                                  .CD_IDARTICULO.AR_CODIGO, .CD_CANT, .CD_PRECIO, .CD_DSCTO, _
                                                  .CD_SUBTOTAL, .CD_INAFECTO, .CD_IDEMPRESA.EM_ID, .CD_IGV, .CD_TOTAL, .CD_INC_IGV)
                    End With

                Next




                'actualizamos el correlativo de la tabla numeracion de comprobantes
                Dim nuevo_num As String = Entidad.CO_NDOC
                Dim numeracionBL As New BL.FacturacionBL.SG_FA_TB_NUM_COMPRO
                Dim numeracionBE As New BE.FacturacionBE.SG_FA_TB_NUM_COMPRO

                numeracionBE.NC_IDTIPO = Entidad.CO_TDOC
                numeracionBE.NC_SERIE = Entidad.CO_SDOC
                numeracionBE.NC_NUMERO = nuevo_num
                numeracionBE.NC_IDEMPRESA = Entidad.CO_IDEMPRESA
                numeracionBL.Update(numeracionBE)

                numeracionBE = Nothing
                numeracionBL = Nothing




                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try



            'CONSULTAMOS LA TABLA DE PARAMETROS PARA VER SI HAY INTERFACE CON CONTABILIDAD
            Dim rpta As String = ""
            Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
            Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS
            paraetrosBE.AD_IDEMPRESA = Entidad.CO_IDEMPRESA
            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "INTER"

            rpta = paraetrosBL.get_Valor(paraetrosBE)


            '_______________________________________________________________________________________________________
            '1 = grabar en conta
            '0 = no grabar en conta

            If rpta = "1" Then


                Dim cuenta12 As String = String.Empty
                Dim cuenta13 As String = String.Empty
                Dim cuenta40 As String = String.Empty

                'buscamos la cuentas contables para el asiento
                paraetrosBE.AD_TIPO = "CONTA"
                paraetrosBE.AD_NOMBRE = "CTA12"
                cuenta12 = paraetrosBL.get_Valor(paraetrosBE)

                paraetrosBE.AD_NOMBRE = "CTA13"
                cuenta13 = paraetrosBL.get_Valor(paraetrosBE)

                If cuenta12 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Clientes' ")
                    Exit Sub
                End If

                paraetrosBE.AD_NOMBRE = "CTA40"
                cuenta40 = paraetrosBL.get_Valor(paraetrosBE)
                If cuenta40 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Impuesto' ")
                    Exit Sub
                End If



                '________________________________________________________________________'CuentasContales


                'Buscamos el codigo de Subdiario
                Dim idsubdiario As String = ""

                paraetrosBE.AD_TIPO = "CONTA"
                paraetrosBE.AD_NOMBRE = "IDSUB"
                idsubdiario = paraetrosBL.get_Valor(paraetrosBE)

                If idsubdiario = String.Empty Then
                    MsgBox("No esta establecido el codigo de subdiario para el asiento contable")
                    Exit Sub
                End If

                '________________________________________________________________________subdiarios

                paraetrosBE = Nothing
                paraetrosBL = Nothing



                '______________________________________________Buscamos el tipo de cambio de conta para las operaciones en dolares

                Dim tipocambioBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
                Dim tipocambioBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO


                tipocambioBE.TC_FECHA = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                tipocambioBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "2"}
                tipocambioBE.TC_IDEMPRESA = Entidad.CO_IDEMPRESA

inicioTC:

                tipocambioBL.getTipoCambio(tipocambioBE)

                If tipocambioBE.TC_VENTA = 0 Then
                    tipocambioBE.TC_FECHA = CDate(tipocambioBE.TC_FECHA).AddDays(-1).ToShortDateString
                    GoTo inicioTC
                End If


                Entidad.CO_TCAM = tipocambioBE.TC_VENTA

                tipocambioBE = Nothing
                tipocambioBL = Nothing



                Dim IdAnexoCliente As Integer = 0
                Dim Descrp_Anexo_Cliente As String = String.Empty
                Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
                Dim E_Ventas As New BE.ContabilidadBE.SG_CO_TB_VENTAS
                Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
                Dim Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)


                'Buscamos el codigo de anexo(ID) 
                Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                Entidad.CO_IDCLIENTE.CL_IDEMPRESA = Entidad.CO_IDEMPRESA
                clienteBL.get_Cliente_x_Id(Entidad.CO_IDCLIENTE)

                anexoBE.AN_IDEMPRESA = Entidad.CO_IDEMPRESA
                anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                anexoBE.AN_NUM_DOC = Entidad.CO_IDCLIENTE.CL_NDOC
                anexoBL.getAnexo_x_Ruc(anexoBE)

                IdAnexoCliente = anexoBE.AN_IDANEXO
                Descrp_Anexo_Cliente = anexoBE.AN_DESCRIPCION.ToString

                With E_Ventas
                    .VE_IDCAB = Nothing
                    .VE_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .VE_ANEXO_ID = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexoCliente}
                    .VE_TIP_DOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC.DO_CODIGO_SUNAT}
                    .VE_SER_DOC = Entidad.CO_SDOC
                    .VE_NUM_DOC = Entidad.CO_NDOC
                    .VE_INDICADOR_DESTINO = "01"
                    .VE_FEC_EMI = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                    .VE_FEC_VEN = CDate(Entidad.CO_FEC_VEN).ToShortDateString
                    .VE_FEC_VOU = CDate(Entidad.CO_FEC_EMI).ToShortDateString

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .VE_TIP_DOC_REF = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC_REF.DO_CODIGO_SUNAT}
                        .VE_SER_DOC_REF = Entidad.CO_SDOC_REF
                        .VE_NUM_DOC_REF = Entidad.CO_NDOC_REF
                        .VE_FEC_EMI_REF = Entidad.CO_FEC_EMI_REF
                    Else
                        .VE_TIP_DOC_REF = Nothing
                        .VE_SER_DOC_REF = String.Empty
                        .VE_NUM_DOC_REF = String.Empty
                        .VE_FEC_EMI_REF = String.Empty
                    End If

                    .VE_TASA_IGV = Entidad.CO_TASA_IGV
                    .VE_MONTO_IGV = Entidad.CO_IGV
                    .VE_VALOR_VENTA = Entidad.CO_SUBTOTAL
                    .VE_PRECIO_VENTA = Entidad.CO_TOTAL

                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .VE_MONTO_IGV = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        .VE_VALOR_VENTA = Math.Round(Entidad.CO_SUBTOTAL * Entidad.CO_TCAM, 2)
                        .VE_PRECIO_VENTA = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                    End If


                    .VE_MONTO_EXONERADO = 0
                    .VE_TASA_ISC = 0
                    .VE_MONTO_ISC = 0
                    .VE_OTROS_TRIBUTOS = 0
                    .VE_VALOR_INAFECTO = 0
                    .VE_DESCUENTO = 0
                    .VE_VALOR_BRUTO = 0
                    .VE_ISTATUS = 1
                    .VE_IDSUBOPE = New BE.ContabilidadBE.SG_CO_TB_SUBOPERACION With {.SO_CODIGO = 6}
                End With

                With E_Cabecera
                    .AC_ID = Entidad.CO_ID
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = idsubdiario}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = CDate(Entidad.CO_FEC_EMI).Year
                    .AC_MES = CDate(Entidad.CO_FEC_EMI).Month
                    .AC_FEC_VOUCHER = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
                    .AC_DEBE = Math.Round(Entidad.CO_TOTAL * IIf(Entidad.CO_IDMONEDA.MO_ID = "01", 1, Entidad.CO_TCAM), 2)
                    .AC_HABER = Math.Round(Entidad.CO_TOTAL * IIf(Entidad.CO_IDMONEDA.MO_ID = "01", 1, Entidad.CO_TCAM), 2)
                    .AC_TC_OPE = Entidad.CO_TCAM
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1

                    If Entidad.CO_TDOC.DO_CODIGO = "01" Then
                        .AC_GLOSA_VOU = Descrp_Anexo_Cliente
                    Else
                        .AC_GLOSA_VOU = Entidad.CO_NOTAS
                    End If

                    .AC_ES_INTERFACE = 0
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = Entidad.CO_USUARIO
                    .AC_TERMINAL = Entidad.CO_TERMINAL
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = Entidad.CO_IDEMPRESA
                End With



                'comenzamos con los detalles

                Dim E_Detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = E_Cabecera
                    .AD_SECUENCIA = 1

                    If anexoBE.AN_ES_RELACIONADO = 1 Then
                        .AD_CUENTA = cuenta13
                    Else
                        .AD_CUENTA = cuenta12
                    End If


                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .AD_IDANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexoCliente}
                    .AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC.DO_CODIGO_SUNAT}
                    .AD_SDOC = Entidad.CO_SDOC
                    .AD_NDOC = Entidad.CO_NDOC
                    .AD_FDOC = Entidad.CO_FEC_EMI
                    .AD_VDOC = Entidad.CO_FEC_VEN
                    .AD_DEBE = 0
                    .AD_HABER = 0

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .AD_HABER = Entidad.CO_TOTAL
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_HABER = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                        End If
                    Else
                        .AD_DEBE = Entidad.CO_TOTAL
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_DEBE = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                        End If
                    End If

                    .AD_MONTO_ORI = Entidad.CO_TOTAL

                    .AD_TCAM = 0
                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .AD_TCAM = Entidad.CO_TCAM
                    End If

                    .AD_PORCE_DESTINO = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = Entidad.CO_NOTAS
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = Entidad.CO_USUARIO
                    .AD_TERMINAL = Entidad.CO_TERMINAL
                    .AD_FECREG = Date.Now

                End With
                Detalles.Add(E_Detalle)

                E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = E_Cabecera
                    .AD_SECUENCIA = 2
                    .AD_CUENTA = cuenta40
                    .AD_TANEXO = Nothing
                    .AD_IDANEXO = Nothing
                    .AD_TDOC = Nothing
                    .AD_SDOC = String.Empty
                    .AD_NDOC = String.Empty
                    .AD_FDOC = String.Empty
                    .AD_VDOC = String.Empty
                    .AD_DEBE = 0
                    .AD_HABER = 0

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .AD_DEBE = Entidad.CO_IGV
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_DEBE = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        End If
                    Else
                        .AD_HABER = Entidad.CO_IGV
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_HABER = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        End If
                    End If

                    .AD_MONTO_ORI = Entidad.CO_IGV
                    .AD_TCAM = 0
                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .AD_TCAM = Entidad.CO_TCAM
                    End If


                    .AD_PORCE_DESTINO = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = Entidad.CO_NOTAS
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = Entidad.CO_USUARIO
                    .AD_TERMINAL = Entidad.CO_TERMINAL
                    .AD_FECREG = Date.Now
                End With
                Detalles.Add(E_Detalle)


                'Aqui hay que darle vuelta al detalle para grabar los detalles de la 70

                Dim drr_Det As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_DET_COMPROBAN", Entidad.CO_ID)
                Dim cta70 As String = String.Empty

                If drr_Det.HasRows Then
                    While drr_Det.Read
                        'Buscamos la cuenta 70 por el codigo del articulo

                        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
                        Dim articuloBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO

                        articuloBE.AR_CODIGO = drr_Det("CD_IDARTICULO")
                        articuloBE.AR_IDEMPRESA = Entidad.CO_IDEMPRESA.EM_ID
                        articuloBL.get_Articulo_x_Cod(articuloBE)

                        cta70 = articuloBE.AR_NUM_CTA_CONTA

                        If cta70 = String.Empty Then
                            MsgBox("La cuenta 70 del articulo " & articuloBE.AR_CODIGO & "-" & articuloBE.AR_DESCRIPCION & " no esta establecida.")
                            cta70 = 701001
                        End If

                        articuloBE = Nothing
                        articuloBL = Nothing


                        E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                        With E_Detalle
                            .AD_IDCAB = E_Cabecera
                            .AD_SECUENCIA = 3
                            .AD_CUENTA = cta70
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing
                            .AD_TDOC = Nothing
                            .AD_SDOC = String.Empty
                            .AD_NDOC = String.Empty
                            .AD_FDOC = String.Empty
                            .AD_VDOC = String.Empty
                            .AD_HABER = 0
                            .AD_DEBE = 0

                            If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                                .AD_DEBE = drr_Det("CD_SUBTOTAL")
                                If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                    .AD_DEBE = Math.Round(drr_Det("CD_SUBTOTAL") * Entidad.CO_TCAM, 2)
                                End If
                            Else
                                .AD_HABER = drr_Det("CD_SUBTOTAL")
                                If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                    .AD_HABER = Math.Round(drr_Det("CD_SUBTOTAL") * Entidad.CO_TCAM, 2)
                                End If
                            End If

                            .AD_MONTO_ORI = drr_Det("CD_SUBTOTAL")
                            .AD_TCAM = 0
                            If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                .AD_TCAM = Entidad.CO_TCAM
                            End If

                            .AD_PORCE_DESTINO = 0
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = Entidad.CO_NOTAS
                            .AD_IDCC = Nothing
                            .AD_ES_DESTINO = 0
                            .AD_USUARIO = Entidad.CO_USUARIO
                            .AD_TERMINAL = Entidad.CO_TERMINAL
                            .AD_FECREG = Date.Now
                        End With
                        Detalles.Add(E_Detalle)

                    End While
                End If

                drr_Det.Close()
                drr_Det = Nothing


                Dim StrVoucher As String = String.Empty
                Try
                    AsientoBL.Insert_Ventas(E_Cabecera, E_Ventas, Detalles, StrVoucher, False, False)
                    numVoucherConta = StrVoucher
                    'actualizamos la cabecera del comprobante
                    SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_EST_CAB_COMPRO", E_Cabecera.AC_ID, StrVoucher, 1, Entidad.CO_ID, Entidad.CO_IDEMPRESA.EM_ID)
                Catch ex As Exception
                    Throw New Exception("Error al intentar grabar en contabilidad.")
                End Try



            End If



        End Sub

        Public Function Existe_Comprobante(entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As Boolean
            Dim int_cantidad As Integer = 0
            Dim rpta As Boolean = False

            int_cantidad = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_NUM_FACTURAS", entidad.CO_TDOC.DO_CODIGO, entidad.CO_SDOC, entidad.CO_NDOC, entidad.CO_IDEMPRESA.EM_ID)

            If int_cantidad > 0 Then
                rpta = True
            End If

            Return rpta

        End Function

        Public Sub Anular(Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_ANULA_COMPRO", Entidad.CO_ID, Entidad.CO_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Anular_En_Contabilidad(Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_ANULA_VOU_VENTASFAC", Entidad.CO_IDVOUCHER, Entidad.CO_IDEMPRESA.EM_ID)
        End Sub

        Public Function get_Comprobante_x_Id(Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPROBANTE", Entidad.CO_ID, Entidad.CO_IDEMPRESA.EM_ID)
        End Function

        Public Function get_Comprobante_x_Num_Doc(Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPROBANTE_02", Entidad.CO_TDOC_REF.DO_CODIGO, Entidad.CO_SDOC_REF, Entidad.CO_NDOC_REF, Entidad.CO_IDEMPRESA.EM_ID)
        End Function

        Public Function get_Lista_Edi_x_Dia(Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_1", Entidad.CO_FEC_EMI, Entidad.CO_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Edi_x_Semana(Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_2", Entidad.CO_FEC_EMI, Entidad.CO_FEC_VEN, Entidad.CO_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Edi_x_Mes(ayo_ As Integer, mes_ As Integer, empresa_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_3", ayo_, mes_, empresa_.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_x_Fecha_SoloActivos(fecha_ As Date, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPROBAN_X_FECHA", fecha_, empresa_).Tables(0)
        End Function

        Public Function get_Lista_x_Fecha_Todo(fecha_ As Date, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPROBAN_X_FECHA_TODO", fecha_, empresa_).Tables(0)
        End Function

        Public Sub Generar_Asiento_Caja(fecha_ As Date, empresa_ As Integer, usuario_ As String, ByRef str_NumVoucherCaja_ As String)

            Dim cuenta12 As String = String.Empty

            'buscamos la cuentas contables para el asiento
            Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
            Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS
            paraetrosBE.AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "CTA12"
            cuenta12 = paraetrosBL.get_Valor(paraetrosBE)

            If cuenta12 = String.Empty Then
                MsgBox("No esta establecido la cuenta contable de 'Clientes' ")
                Exit Sub
            End If


            '________________________________________________________________________'CuentasContales


            'Buscamos el codigo de Subdiario
            Dim IdSubdiario_Caja As String = ""

            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "SUBCA"
            IdSubdiario_Caja = paraetrosBL.get_Valor(paraetrosBE)

            If IdSubdiario_Caja = String.Empty Then
                MsgBox("No esta establecido el codigo de subdiario de Caja para el asiento contable")
                Exit Sub
            End If

            paraetrosBE = Nothing
            paraetrosBL = Nothing

            '________________________________________________________________________subdiarios


            Dim asientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim asientoBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim ls_Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim ls_IDsComprobantes As New List(Of Integer)
            Dim detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim dt_compros As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPROBAN_X_FECHA", fecha_, empresa_).Tables(0)


            Dim monto_total_compro As Double = dt_compros.Compute("sum(CO_TOTAL)", "")
            Dim glosa_compro As String = "CAJA INGRESOS - CAJERO(A) : " & usuario_ & " FECHA : " & fecha_.ToShortDateString


            'Cabecera Asiento
            With asientoBE
                .AC_ID = 0
                .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = IdSubdiario_Caja}
                .AC_NUM_VOUCHER = ""
                .AC_ANHO = fecha_.Year
                .AC_MES = fecha_.Month
                .AC_FEC_VOUCHER = fecha_
                .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                .AC_DEBE = monto_total_compro
                .AC_HABER = monto_total_compro
                .AC_TC_OPE = 0
                .AC_TC_ESPECIAL = 0
                .AC_ESTADO = 1
                .AC_GLOSA_VOU = glosa_compro
                .AC_ES_INTERFACE = 1
                .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, usuario_)
                .AC_TERMINAL = Environment.MachineName
                .AC_FECREG = Now.Date
                .AC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
                .AC_ES_IMPRESO = 0
            End With


            'Limpiamos la Coleccion de Detalles del Comprobante
            ls_Detalles.Clear()

            Dim dc_cuentas As New Dictionary(Of String, Double)
            Dim tc As Double = 0
            Dim mon As String = ""
            Dim total As Double = 0

            For i As Integer = 0 To dt_compros.Rows.Count - 1

                tc = dt_compros.Rows(i)("CO_TCAM")
                mon = dt_compros.Rows(i)("CO_IDMONEDA")
                total = IIf(mon = "01", dt_compros.Rows(i)("CO_TOTAL"), dt_compros.Rows(i)("CO_TOTAL") * tc)

                If dc_cuentas.ContainsKey(dt_compros.Rows(i)("DP_CTA_CONTA")) Then

                    If dt_compros.Rows(i)("DO_CODIGO_SUNAT") = 7 Or dt_compros.Rows(i)("CO_ES_REEMPLA") = 1 Then
                        'dc_cuentas(dt_compros.Rows(i)("DP_CTA_CONTA")) = dc_cuentas(dt_compros.Rows(i)("DP_CTA_CONTA")) - dt_compros.Rows(i)("CO_TOTAL")
                    Else
                        dc_cuentas(dt_compros.Rows(i)("DP_CTA_CONTA")) = dc_cuentas(dt_compros.Rows(i)("DP_CTA_CONTA")) + total
                    End If

                Else
                    dc_cuentas.Add(dt_compros.Rows(i)("DP_CTA_CONTA"), total)
                End If

            Next


            Dim iItem As Integer = 1

            'Cuenta 10 - Caja
            For Each e As KeyValuePair(Of String, Double) In dc_cuentas

                detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                With detalle
                    .AD_IDCAB = asientoBE
                    .AD_SECUENCIA = iItem
                    .AD_CUENTA = e.Key
                    .AD_TANEXO = Nothing
                    .AD_IDANEXO = Nothing
                    .AD_TDOC = Nothing
                    .AD_SDOC = String.Empty
                    .AD_NDOC = String.Empty
                    .AD_FDOC = String.Empty
                    .AD_VDOC = String.Empty
                    .AD_DEBE = e.Value
                    .AD_HABER = 0
                    .AD_MONTO_ORI = e.Value
                    .AD_PORCE_DESTINO = 0
                    .AD_TCAM = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = glosa_compro
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, usuario_)
                    .AD_TERMINAL = Environment.MachineName
                    .AD_FECREG = Date.Now
                    .AD_IDMEDIOPAGO = Nothing
                    .AD_ES_DETRA = 0
                End With
                ls_Detalles.Add(detalle)

                iItem += 1
            Next



         


            'Cuentas 12, FT,BV,NC
            For i As Integer = 0 To dt_compros.Rows.Count - 1

                '__________________________________________________________________________________________________
                '### Buscamos el IdAnexo por Ruc de Cliente
                Dim IdAnexo_Conta As Integer = 0

                Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                anexoBE.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
                anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                anexoBE.AN_NUM_DOC = dt_compros.Rows(i)("CL_NDOC")
                anexoBL.getAnexo_x_Ruc(anexoBE)

                IdAnexo_Conta = anexoBE.AN_IDANEXO

                anexoBE = Nothing
                anexoBL = Nothing
                '__________________________________________________________________________________________________
                '### calculamos el importe en soles si es dolares, el asiento debe estar en soles pero con su 
                '### referencia en dolares

                tc = dt_compros.Rows(i)("CO_TCAM")
                mon = dt_compros.Rows(i)("CO_IDMONEDA")
                total = IIf(mon = "01", dt_compros.Rows(i)("CO_TOTAL"), dt_compros.Rows(i)("CO_TOTAL") * tc)

                '__________________________________________________________________________________________________



                detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                With detalle
                    .AD_IDCAB = asientoBE
                    .AD_SECUENCIA = ls_Detalles.Count + 1
                    .AD_CUENTA = cuenta12

                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .AD_IDANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexo_Conta}
                    .AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = dt_compros.Rows(i)("DO_CODIGO_SUNAT")}

                    .AD_SDOC = dt_compros.Rows(i)("CO_SDOC")
                    .AD_NDOC = dt_compros.Rows(i)("CO_NDOC")
                    .AD_FDOC = dt_compros.Rows(i)("CO_FEC_EMI")
                    .AD_VDOC = dt_compros.Rows(i)("CO_FEC_VEN")

                    If dt_compros.Rows(i)("DO_CODIGO_SUNAT") = 7 Then
                        .AD_DEBE = total
                        .AD_HABER = 0
                    Else
                        .AD_DEBE = 0
                        .AD_HABER = total
                    End If

                    .AD_MONTO_ORI = IIf(mon = "01", total, dt_compros.Rows(i)("CO_TOTAL"))
                    .AD_PORCE_DESTINO = 0
                    .AD_TCAM = IIf(mon = "01", 0, tc)
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = glosa_compro
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, usuario_)
                    .AD_TERMINAL = Environment.MachineName
                    .AD_FECREG = Date.Now
                    .AD_IDMEDIOPAGO = Nothing
                    .AD_ES_DETRA = 0

                    'esto para actualizar la cabecera de comprobantes para saber cual ya se contabilizo
                    ls_IDsComprobantes.Add(dt_compros.Rows(i)("CO_ID"))

                End With
                ls_Detalles.Add(detalle)

            Next
            Dim str_num_voucher As String = ""
            asientoBL.Insert_Caja_Facturacion(asientoBE, ls_Detalles, str_num_voucher, ls_IDsComprobantes)
            str_NumVoucherCaja_ = str_num_voucher

        End Sub

    End Class

    Public Class SG_FA_Reportes
        Inherits ClsBD

        Public Function get_Comprobante(idComprobante_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_REP_01", idComprobante_, empresa_).Tables(0)
        End Function

        Public Function get_Reg_Venta(ayo_ As Integer, mes_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_REGVENTA", ayo_, mes_, empresa_).Tables(0)
        End Function

        Public Function get_Reg_Ventas_x_Dia(fecha_ As Date, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_VENTAS_X_DIA", fecha_.Year, fecha_.Month, fecha_.Day, empresa_).Tables(0)
        End Function

        Public Function get_Reg_Ventas_x_Cliente(idCliente_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_VENTAS_X_CLIENTE", idCliente_, empresa_).Tables(0)
        End Function

        Public Function get_Reg_Ventas_x_Cajero(idCajero_ As String, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_VENTAS_X_CAJERO", idCajero_, empresa_).Tables(0)
        End Function

        Public Function get_Reg_RankingVentas(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_RANKING_VENTAS", empresa_).Tables(0)
        End Function

    End Class

End Class
