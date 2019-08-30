Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion

Public Class EditarProductos
    Dim id_prod As Integer
    Dim idm As Integer = Nothing 'actulizacion del combo de marcas
    Dim idgp As Integer = Nothing 'actulizacion del combo grupo de productos
    Dim idpp As Integer = Nothing 'actulizacion del combo de presentacion de producto
    Dim idprov As Integer = Nothing 'actulizacion del combo de proveedores
    Dim id_CatProd As Integer = Nothing 'guarda el valor del numero de registro obtenido de tabla de catalogo de productos
    Public Sub obtprod(ByVal IdP As String)
        'Para obtener datos del formulario de productos y póder realizar modificación
        id_prod = IdP
    End Sub
    Private Function act_datos()
        Dim ds As DataSet = New DataSet
        Dim datatable As New DataTable()
        Dim datatable2 As New DataTable()
        Dim datatable3 As New DataTable()
        Dim datatable4 As New DataTable()
        Dim da As MySqlDataAdapter
        Dim da2 As MySqlDataAdapter
        Dim da3 As MySqlDataAdapter
        Dim da4 As MySqlDataAdapter
        Dim comm As MySqlCommand
        Dim consulta = "SELECT * FROM catalogo_productos WHERE id = @id_Prod"
        Dim consulta2 = "SELECT * FROM marcas"
        Dim consulta3 = "SELECT * FROM catalogacion"
        Dim consulta4 = "SELECT * FROM presentacion_prod"

        If (id_prod) Then
            Me.Text = "Editar Producto - ID: " & id_prod.ToString
        End If

        Try
            'abrir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'para el llenado del combobox de marcas
            da2 = New MySqlDataAdapter(consulta2, con_string)
            datatable2 = New DataTable
            da2.Fill(datatable2)
            con_string.Close()

            Cbo_Marca.DataSource = datatable2
            Cbo_Marca.DisplayMember = "marca"
            Cbo_Marca.ValueMember = "id"
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "No se pudieron importar los datos desde la tabla Marcas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            'abrir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'para el llenado del combobox de grupo de productos
            da3 = New MySqlDataAdapter(consulta3, con_string)
            datatable3 = New DataTable
            da3.Fill(datatable3)
            con_string.Close()

            Cbo_GpoProd.DataSource = datatable3
            Cbo_GpoProd.DisplayMember = "Nom_categoria"
            Cbo_GpoProd.ValueMember = "id"
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "No se pudieron importar los datos desde la tabla Catalogacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            'abrir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'para el llenado del combobox para la presentacion del articulo
            da4 = New MySqlDataAdapter(consulta4, con_string)
            datatable4 = New DataTable
            da4.Fill(datatable4)
            con_string.Close()

            Cbo_Pres.DataSource = datatable4
            Cbo_Pres.DisplayMember = "presentacion"
            Cbo_Pres.ValueMember = "id_pp"
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "No se pudieron importar los datos desde la tabla Presentacion de producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            'abrir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()

            'iniciar comando para conexion y consulta a partir de los datos obtenidos del formulario de modificar catalogo
            comm = New MySqlCommand(consulta, con_string)
            comm.Parameters.Add(New MySqlParameter("@id_Prod", id_prod))
            da = New MySqlDataAdapter(comm)
            da.Fill(ds)
            con_string.Close()

            For Each dr As DataRow In ds.Tables(0).Rows
                Dim DataRow As DataRow = dt.NewRow()
                Txt_CodBar.Text = dr(1)
                Cbo_Marca.SelectedValue = dr(2)
                Txt_Modelo.Text = dr(3)
                Txt_Desc.Text = dr(4)
                Cbo_Pres.SelectedValue = dr(5)
                Txt_Cto.Text = dr(6)
                Cbo_GpoProd.SelectedValue = dr(7)
                Cbo_Proveedor.SelectedValue = dr(8)
                id_CatProd = dr(0)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de conexión no se pudieron importar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'llenar combobox de proveedor
        Dim cons_prov As String = "SELECT * FROM proveedor"
        Dim da_prov As New MySqlDataAdapter
        Dim dt_prov As New DataTable
        Try
            'iniciar conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'realizar consulta para extraer datos
            da_prov = New MySqlDataAdapter(cons_prov, con_string)
            dt_prov = New DataTable
            da_prov.Fill(dt_prov)
            con_string.Close()
            'llenado de informacion en el combobox presentacion de productos para alta de productos
            Cbo_Proveedor.DataSource = dt_prov
            Cbo_Proveedor.DisplayMember = "Nombre"
            Cbo_Proveedor.ValueMember = "idProveedor"
        Catch ex As Exception
            MsgBox("Error de conexion. No se pudo cargar la tabla presentacion de proveedores", vbCritical)
        End Try
    End Function
    Private Sub EditarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        act_datos()
    End Sub

    Private Sub Cbo_Marca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Marca.SelectedIndexChanged
        If IsNumeric(Cbo_Marca.SelectedValue) Then
            idm = Cbo_Marca.SelectedValue
        End If
    End Sub

    Private Sub Cbo_Pres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Pres.SelectedIndexChanged
        If IsNumeric(Cbo_Pres.SelectedValue) Then
            idpp = Cbo_Pres.SelectedValue
        End If
    End Sub

    Private Sub Cbo_GpoProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_GpoProd.SelectedIndexChanged
        If IsNumeric(Cbo_GpoProd.SelectedValue) Then
            idgp = Cbo_GpoProd.SelectedValue
        End If
    End Sub

    Private Sub Btn_actualizar_Click(sender As Object, e As EventArgs) Handles Btn_actualizar.Click
        Dim actualizar As String = "UPDATE catalogo_productos SET codigo_barras = @cb, marca = @marca, Modelo=@Modelo,descripcion=@descripcion,presentacion=@presentacion,precio=@precio, id_catalogacion=@id_catalogacion, id_prov=@id_prov WHERE id = " & id_prod
        Try
            'Abir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(actualizar, con_string)
            'Pasar parametros
            cmd.Parameters.Add(New MySqlParameter("@cb", Txt_CodBar.Text))
            cmd.Parameters.Add(New MySqlParameter("@marca", idm))
            cmd.Parameters.Add(New MySqlParameter("@Modelo", Txt_Modelo.Text))
            cmd.Parameters.Add(New MySqlParameter("@descripcion", Txt_Desc.Text))
            cmd.Parameters.Add(New MySqlParameter("@presentacion", idpp))
            cmd.Parameters.Add(New MySqlParameter("@precio", Txt_Cto.Text))
            cmd.Parameters.Add(New MySqlParameter("@id_catalogacion", idgp))
            cmd.Parameters.Add(New MySqlParameter("@id_prov", idprov))
            'enviar nuevos datos a la tabla
            cmd.ExecuteNonQuery()
            con_string.Close()
            MsgBox("Registro actualizado")
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo actualizar el registro", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'esta consulta se realiza para guardar la actualizacion de costo en la BD
        'Try
        '    'Se inicializa la conexion a la BD JLCS
        '    con_string = New MySqlConnection
        '    con_string.ConnectionString = ConnectionString2
        '    con_string.Open()
        '    'campos a ingresar en la BD desde el formulario
        '    comando = New MySqlCommand("INSERT INTO historico_costos(Id_Prov, id_catprod, precio_cto)" & Chr(13) &
        '                               "VALUES(@Id_Prov, @id_catprod, @precio_cto)", con_string)
        '    comando.Parameters.AddWithValue("@Id_Prov", idprov)
        '    comando.Parameters.AddWithValue("@id_catprod", id_prod)
        '    comando.Parameters.AddWithValue("@precio_cto", Txt_Cto.Text)
        '    comando.ExecuteNonQuery()
        '    con_string.Close()
        'Catch ex As Exception

        'End Try

        'Llama la funcion para guardar el costo en la tabla de historicos
        GetHistoricoCosto(idprov, id_CatProd, Txt_Cto.Text)

        MsgBox("Producto guardado con exito")

    End Sub

    Private Sub Txt_CodBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_CodBar.KeyPress
        solonumeros(e)
    End Sub

    Private Sub Txt_Cto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Cto.KeyPress
        NumerosyDecimal(Txt_Cto, e)
    End Sub

    Private Sub Cbo_Proveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Proveedor.SelectedIndexChanged
        If IsNumeric(Cbo_Proveedor.SelectedValue) Then
            idprov = Cbo_Proveedor.SelectedValue
        End If
    End Sub
End Class