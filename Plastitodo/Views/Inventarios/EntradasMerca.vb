Imports System.Text
Imports MySql.Data.MySqlClient
Imports Plastitodo.Globales
Imports Plastitodo.conexion
Public Class EntradasMerca
    Dim miDataTable As New DataTable
    Private Sub BGuardardetaentramerca_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub listaprov()
        Dim conexion As New MySqlConnection(ConnectionString2)
        conexion.Open()

        Dim consulta As String
        consulta = "select * from proveedor"
        Dim adaptador = New MySqlDataAdapter(consulta, conexion)
        Dim datos = New DataSet
        datos.Tables.Add("proveedor")
        adaptador.Fill(datos.Tables("proveedor"))
        ComboBoxprovee.DataSource = datos.Tables("proveedor")
        ComboBoxprovee.DisplayMember = "Nombre"
        conexion.Close()

    End Sub



    Private Sub EntradasMerca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaprov()

        'declarar datatable y crear estructura

        miDataTable.Columns.Add("id_producto")
        miDataTable.Columns.Add("producto")
        miDataTable.Columns.Add("precio")
        miDataTable.Columns.Add("cantidad")
        miDataTable.Columns.Add("proveedor")

    End Sub

    'Private Sub listadescrip()
    '    Dim conexion As New MySqlConnection(ConnectionString2)
    '    conexion.Open()


    '    Dim consulta As String
    '    consulta = "select * from catalogo_productos"
    '    Dim adaptador = New MySqlDataAdapter(consulta, conexion)
    '    Dim datos = New DataSet
    '    datos.Tables.Add("catalogo_productos")
    '    adaptador.Fill(datos.Tables("catalogo_productos"))
    '    ComboBoxdescrip.DataSource = datos.Tables("catalogo_productos")
    '    ComboBoxdescrip.DisplayMember = "descripcion"
    '    conexion.Close()
    'End Sub

    Private Sub limpiardatos()
        TextBoxcodigo.Text = String.Empty
        TextBoxprecio.Text = String.Empty
        Tcantidad.Text = String.Empty
        TextBoxproducto.Text = String.Empty
        ComboBoxprovee.Text = String.Empty
    End Sub

    Private Sub BBuscarCodigo_Click_1(sender As Object, e As EventArgs) Handles BBuscarCodigo.Click
        Try
            Dim conexion As New MySqlConnection(ConnectionString2)

            Dim query = "Select descripcion,precio from catalogo_productos where codigo_barras = ?"
            Dim adap As New MySqlDataAdapter(query, conexion)
            adap.SelectCommand.Parameters.AddWithValue("@p1", TextBoxcodigo.Text)

            Dim dt As New DataTable

            adap.Fill(dt)

            If dt.Rows.Count > 0 Then
                TextBoxproducto.Text = dt.Rows(0).Item(0)
                TextBoxprecio.Text = dt.Rows(0).Item(1)
            Else
                MessageBox.Show("No se encontraron coincidencias")
            End If

            conexion.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Buttonlimpiardatos_Click_1(sender As Object, e As EventArgs) Handles Buttonlimpiardatos.Click
        limpiardatos()
    End Sub

    Private Sub BGuardardetaentramerca_Click_1(sender As Object, e As EventArgs) Handles BGuardardetaentramerca.Click
        Dim conexion As New MySqlConnection(ConnectionString2)

        Dim consulta As New StringBuilder
        consulta.Clear()
        consulta.AppendLine("insert into detalle_entrada(id_producto, costo, cantidad,proveedor,usuario)")
        consulta.AppendLine("values ('{TextBoxcodigo.Text}','{TextBoxprecio.Text}',")
        consulta.AppendLine("'{Tcantidad.Text}','{ComboBoxprovee.Text}','{Id_usuario}')")

        Dim COMANDO As New MySqlCommand(consulta.ToString(), conexion)

        conexion.Open()
        COMANDO.ExecuteNonQuery()
        conexion.Close()

        Dim query = "Select * from inventario where codigo_barras = ?"

        Dim adap As New MySqlDataAdapter(query, conexion)
        adap.SelectCommand.Parameters.AddWithValue("@p1", TextBoxcodigo.Text)
        Dim dt As New DataTable
        adap.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim inventarioActual = CInt(dt.Rows(0).Item(1))
            Dim qryUpdate = $"Update inventario SET existencia = {inventarioActual + CInt(Tcantidad.Text)} WHERE codigo_barras = {TextBoxcodigo.Text}"

            Dim cmdUpdate As New MySqlCommand(qryUpdate, conexion)

            conexion.Open()
            cmdUpdate.ExecuteNonQuery()
            conexion.Close()
        Else

            Dim qryInsert = $"INSERT INTO inventario (codigo_barras,existencia,maximo,minimo,reorden,activo) VALUES ({TextBoxcodigo.Text},{Tcantidad.Text},{0},{0},'' ,'' )"

            Dim cmdUpdate As New MySqlCommand(qryInsert, conexion)

            conexion.Open()
            cmdUpdate.ExecuteNonQuery()
            conexion.Close()

        End If

        'agregar un renglón
        'agregar al datatable los datos
        'guardar renglon

        'agregar al datasource del grid el datatable

        Dim Renglon As DataRow = miDataTable.NewRow()
        Renglon("id_producto") = TextBoxcodigo.Text
        Renglon("producto") = TextBoxproducto.Text
        Renglon("costo") = TextBoxprecio.Text
        Renglon("cantidad") = Tcantidad.Text
        Renglon("proveedor") = ComboBoxprovee.Text
        miDataTable.Rows.Add(Renglon)

        Me.DataGridViewdetalleentrada.DataSource = miDataTable
        ' Me.DataGridViewdetalleentrada.DataBind()

        MsgBox("DATOS GUARDADOS CORRECTAMENTE!!")
    End Sub
End Class