﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_Movi_Cta_x_Subdiario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sel")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Subdiario")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sel")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subdiario")
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ugb_Opciones = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uos_opciones = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.uds_subdiarios = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_subdiarios = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uchk_todos = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uce_nivel = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.uchk_Resumen = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_SinFecha = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Opciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Opciones.SuspendLayout()
        CType(Me.uos_opciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_subdiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_subdiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_nivel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(603, 25)
        Me.ToolStrip1.TabIndex = 203
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_imprimir
        '
        Me.Tool_imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_imprimir.Name = "Tool_imprimir"
        Me.Tool_imprimir.Size = New System.Drawing.Size(65, 22)
        Me.Tool_imprimir.Text = "Imprimir"
        Me.Tool_imprimir.ToolTipText = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ugb_Datos
        '
        Me.ugb_Datos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.uce_Mes)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_Ayo)
        Me.ugb_Datos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Datos.Location = New System.Drawing.Point(12, 28)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(160, 87)
        Me.ugb_Datos.TabIndex = 204
        Me.ugb_Datos.Text = "Periodo"
        '
        'UltraLabel4
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance10
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(6, 59)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel4.TabIndex = 195
        Me.UltraLabel4.Text = "Mes "
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(38, 55)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(110, 21)
        Me.uce_Mes.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 32)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(24, 14)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Año "
        '
        'txt_Ayo
        '
        Me.txt_Ayo.Location = New System.Drawing.Point(38, 28)
        Me.txt_Ayo.Name = "txt_Ayo"
        Me.txt_Ayo.Size = New System.Drawing.Size(62, 21)
        Me.txt_Ayo.TabIndex = 0
        '
        'ugb_Opciones
        '
        Me.ugb_Opciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Opciones.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Opciones.Controls.Add(Me.uchk_Resumen)
        Me.ugb_Opciones.Controls.Add(Me.uchk_SinFecha)
        Me.ugb_Opciones.Controls.Add(Me.UltraLabel2)
        Me.ugb_Opciones.Controls.Add(Me.uce_nivel)
        Me.ugb_Opciones.Controls.Add(Me.uos_opciones)
        Me.ugb_Opciones.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Opciones.Location = New System.Drawing.Point(178, 28)
        Me.ugb_Opciones.Name = "ugb_Opciones"
        Me.ugb_Opciones.Size = New System.Drawing.Size(416, 87)
        Me.ugb_Opciones.TabIndex = 205
        Me.ugb_Opciones.Text = "Opciones"
        '
        'uos_opciones
        '
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.uos_opciones.Appearance = Appearance2
        Me.uos_opciones.BackColor = System.Drawing.Color.Transparent
        Me.uos_opciones.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_opciones.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_opciones.CheckedIndex = 1
        ValueListItem9.DataValue = "0"
        ValueListItem9.DisplayText = "Mensual"
        ValueListItem10.DataValue = "1"
        ValueListItem10.DisplayText = "Acumulado"
        Me.uos_opciones.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem9, ValueListItem10})
        Me.uos_opciones.ItemSpacingHorizontal = 5
        Me.uos_opciones.ItemSpacingVertical = 5
        Me.uos_opciones.Location = New System.Drawing.Point(10, 28)
        Me.uos_opciones.Name = "uos_opciones"
        Me.uos_opciones.Size = New System.Drawing.Size(93, 47)
        Me.uos_opciones.TabIndex = 3
        Me.uos_opciones.Text = "Acumulado"
        '
        'uds_subdiarios
        '
        Me.uds_subdiarios.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Boolean)
        Me.uds_subdiarios.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'ug_subdiarios
        '
        Me.ug_subdiarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_subdiarios.DataSource = Me.uds_subdiarios
        Me.ug_subdiarios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 47
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_subdiarios.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_subdiarios.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_subdiarios.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_subdiarios.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_subdiarios.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_subdiarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_subdiarios.Location = New System.Drawing.Point(12, 144)
        Me.ug_subdiarios.Name = "ug_subdiarios"
        Me.ug_subdiarios.Size = New System.Drawing.Size(582, 168)
        Me.ug_subdiarios.TabIndex = 206
        '
        'uchk_todos
        '
        Me.uchk_todos.Checked = True
        Me.uchk_todos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_todos.Location = New System.Drawing.Point(12, 121)
        Me.uchk_todos.Name = "uchk_todos"
        Me.uchk_todos.Size = New System.Drawing.Size(120, 20)
        Me.uchk_todos.TabIndex = 207
        Me.uchk_todos.Text = "Marcar Todos"
        '
        'uce_nivel
        '
        Me.uce_nivel.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = CType(1, Short)
        ValueListItem1.DisplayText = "01"
        ValueListItem2.DataValue = CType(2, Short)
        ValueListItem2.DisplayText = "02"
        ValueListItem3.DataValue = CType(3, Short)
        ValueListItem3.DisplayText = "03"
        ValueListItem6.DataValue = CType(4, Short)
        ValueListItem6.DisplayText = "04"
        ValueListItem7.DataValue = CType(5, Short)
        ValueListItem7.DisplayText = "05"
        ValueListItem8.DataValue = CType(6, Short)
        ValueListItem8.DisplayText = "06"
        Me.uce_nivel.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3, ValueListItem6, ValueListItem7, ValueListItem8})
        Me.uce_nivel.Location = New System.Drawing.Point(177, 28)
        Me.uce_nivel.Name = "uce_nivel"
        Me.uce_nivel.Size = New System.Drawing.Size(55, 21)
        Me.uce_nivel.TabIndex = 4
        '
        'UltraLabel2
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance11
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(105, 30)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel2.TabIndex = 5
        Me.UltraLabel2.Text = "Nivel de Cta"
        '
        'uchk_Resumen
        '
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Resumen.Appearance = Appearance5
        Me.uchk_Resumen.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Resumen.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Resumen.Location = New System.Drawing.Point(260, 30)
        Me.uchk_Resumen.Name = "uchk_Resumen"
        Me.uchk_Resumen.Size = New System.Drawing.Size(150, 20)
        Me.uchk_Resumen.TabIndex = 7
        Me.uchk_Resumen.Text = "Resumen"
        '
        'uchk_SinFecha
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.uchk_SinFecha.Appearance = Appearance4
        Me.uchk_SinFecha.BackColor = System.Drawing.Color.Transparent
        Me.uchk_SinFecha.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_SinFecha.Location = New System.Drawing.Point(260, 50)
        Me.uchk_SinFecha.Name = "uchk_SinFecha"
        Me.uchk_SinFecha.Size = New System.Drawing.Size(150, 20)
        Me.uchk_SinFecha.TabIndex = 6
        Me.uchk_SinFecha.Text = "Sin Fecha de Impresion"
        '
        'CO_RP_Movi_Cta_x_Subdiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(603, 317)
        Me.Controls.Add(Me.uchk_todos)
        Me.Controls.Add(Me.ug_subdiarios)
        Me.Controls.Add(Me.ugb_Opciones)
        Me.Controls.Add(Me.ugb_Datos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "CO_RP_Movi_Cta_x_Subdiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen por Subdiario / Nivel de Cuenta"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Opciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Opciones.ResumeLayout(False)
        Me.ugb_Opciones.PerformLayout()
        CType(Me.uos_opciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_subdiarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_subdiarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_nivel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ugb_Opciones As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uos_opciones As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents uds_subdiarios As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_subdiarios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uchk_todos As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_nivel As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uchk_Resumen As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_SinFecha As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
