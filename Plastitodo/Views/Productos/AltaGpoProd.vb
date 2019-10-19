Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion

Public Class AltaGpoProd
    Public idfam As String = Nothing
    Public sel As String = Nothing

    Function carga_gp()
        'Declaracion de variables para llenar data grid de consulta
        Dim ds As DataSet = New DataSet
        Dim dt As New DataTable()
        Dim da As MySqlDataAdapter
        Dim comm As MySqlCommand
        Dim consulta = "select c.id, c.Gpo_prod as Grupo,cf.nom_familia as Familia,c.Nom_categoria as Categoria
                        from catalogacion c
                        left join catalogacion_familias cf on c.Id_familia = cf.id_familia"

        Try
            'iniciar parametro de conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()

            'iniciar comando para conexion y consulta, servira para el llenado del data grid de edicion
            comm = New MySqlCommand(consulta, con_string)
            da = New MySqlDataAdapter(comm)
            da.Fill(ds)
            'cierra conexion
            con_string.Close()

            'asignar nombre a las columnas del data grid
            dt.Columns.Add("id", GetType(String)) '1
            dt.Columns.Add("Grupo", GetType(String)) '2
            dt.Columns.Add("Familia", GetType(String)) '3
            dt.Columns.Add("Categoria", GetType(String)) '4

            For Each dr As DataRow In ds.Tables(0).Rows
                Dim DataRow As DataRow = dt.NewRow()
                DataRow("id") = dr(0)
                DataRow("Grupo") = dr(1)
                DataRow("Familia") = dr(2)
                DataRow("Categoria") = dr(3)

                dt.Rows.Add(DataRow)

                'Agregar botón Editar
                Dim Editar As New DataGridViewButtonColumn()
                Editar.UseColumnTextForButtonValue = True
                Editar.Text = "Editar"
                Editar.Name = "Editar"          'Agregar nombre a columna
                Editar.HeaderText = "Acciones"
                Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                If Dgv_EditarGP.ColumnCount < 4 Then  'Condición para no desplegar otra columna
                    Dgv_EditarGP.Columns.Add(Editar)
                End If

                Dgv_EditarGP.DataSource = dt
                'Determinamos el alto de las filas
                Dgv_EditarGP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                Dgv_EditarGP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'Configurar aspectos visuales
                Dgv_EditarGP.BackgroundColor = Color.AliceBlue
                Dgv_EditarGP.AllowUserToAddRows = False
                Dgv_EditarGP.ReadOnly = True       'El control DataGridView será de sólo lectura

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de conexión al cargar la consulta de la tabla categorias", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function

    Private Sub AltaGpoProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'bloquear el boton de guardado antes de validar información
        Btn_agregar.Enabled = False
        'cargar el idfamilia vacio - evita que se cargue un error antes de seleccionar algo en el combobox
        txt_idfamilia.Text = ""

        'llenar el combo box para creación de familias
        Dim cons_altagpo As String = Nothing
        Dim datat As New DataTable
        Dim datad As MySqlDataAdapter
        Try
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            cons_altagpo = "SELECT * FROM catalogacion_familias"
            datad = New MySqlDataAdapter(cons_altagpo, con_string)
            datat = New DataTable
            datad.Fill(datat)
            cmbo_nomfam.DataSource = datat
            cmbo_nomfam.DisplayMember = "nom_familia"
            cmbo_nomfam.ValueMember = "id_familia"
            cmbo_nomfam.Text = "Seleccione una familia"
            con_string.Close()
        Catch ex As Exception
            MsgBox("Se genero un error al cargar la consulta familias")
        End Try

        carga_gp()

    End Sub


    Private Sub txt_cat_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cat.LostFocus
        'txt_gpoprod.Text = txt_idfamilia.Text & txt_cat.Text
    End Sub

    Private Sub btn_validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validar.Click

        'extraer el numero maximo de categorias creadas para determinada familia y colocarlo en el campo de texto de categorias
        Try
            Dim considcat As String = Nothing

            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            considcat = "SELECT (IFNULL(MAX(Id_categoria),0)+1) AS MaxId FROM catalogacion WHERE Id_familia = @select"
            cmd = New MySqlCommand(considcat, con_string)
            cmd.Parameters.Add(New MySqlParameter("@select", cmbo_nomfam.SelectedValue)) 'aqui le pasas el parametro de lo que tenga el combobox
            'cmbo_nomfam.SelectedValue pone el valor seleccionado, en este caso el id que se pone cuando cargas el combobox con el valuemember
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    'obtener valores de la consulta
                    txt_cat.Text = dr.Item("MaxId").ToString 'si quieres mostrar el resultado en este textbox
                End While
            End If
            dr.Close()
            con_string.Close()
            Btn_agregar.Enabled = True
            btn_validar.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

        txt_gpoprod.Text = txt_idfamilia.Text & "-" & txt_cat.Text

    End Sub

    Private Sub cmbo_nomfam_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbo_nomfam.SelectedIndexChanged
        ' Referenciando el objeto DataRowView correspondiente
        ' al elemento seleccionado en el control ComboBox.
        If IsNumeric(cmbo_nomfam.SelectedValue) Then
            txt_idfamilia.Text = cmbo_nomfam.SelectedValue.ToString
        Else
            txt_idfamilia.Text = ""
        End If

    End Sub

    Private Sub Btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_agregar.Click
        Dim verif As Boolean
        If (txt_gpoprod.Text IsNot "" And txt_idfamilia.Text IsNot "" And txt_cat.Text IsNot "" And txt_nomcat.Text) Then
            verif = True
        Else
            verif = False
        End If

        If verif = False Then

            Try
                'Abre la conexion a la BD
                con_string = New MySqlConnection
                con_string.ConnectionString = ConnectionString2
                con_string.Open()

                'valores de la tabla catalogacion que seran guardados y se referencian con "@" para guardar
                'posteriormente el contenido de las cajas de texto
                comando = New MySqlCommand("INSERT INTO catalogacion(Gpo_prod, Id_familia, Id_categoria, Nom_categoria)" & Chr(13) &
                                           "VALUES(@Gpo_prod,@Id_familia, @Id_categoria, @Nom_categoria)", con_string)
                comando.Parameters.AddWithValue("@Gpo_prod", txt_gpoprod.Text)
                comando.Parameters.AddWithValue("@Id_familia", txt_idfamilia.Text)
                comando.Parameters.AddWithValue("@Id_categoria", txt_cat.Text)
                comando.Parameters.AddWithValue("@Nom_categoria", txt_nomcat.Text)
                MsgBox("Grupo de productos guardado con exito", vbExclamation)
                comando.ExecuteNonQuery()
                con_string.Close()

                'limpia los datos ingresados para poder dar de alta uno nuevo
                txt_gpoprod.Text = String.Empty
                txt_idfamilia.Text = String.Empty
                txt_cat.Text = String.Empty
                txt_nomcat.Text = String.Empty
                'desactiva el botón de agregar y activa el botón de validar
                Btn_agregar.Enabled = False
                btn_validar.Enabled = True

            Catch ex As Exception
                'En caso de error limpia los datos ingresados y envia mensaje
                MsgBox("No se ha podido guardar, verifique los datos ingresados", vbExclamation)

                txt_gpoprod.Text = String.Empty
                txt_idfamilia.Text = String.Empty
                txt_cat.Text = String.Empty
                txt_nomcat.Text = String.Empty

                Btn_agregar.Enabled = False
                btn_validar.Enabled = True
            End Try
        Else
            MsgBox("No se han llenado todos los campos, verifique la información")
        End If
    End Sub

    Private Sub Dgv_EditarGP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_EditarGP.CellClick
        If e.ColumnIndex <> 0 Then Exit Sub
        Try
            If Dgv_EditarGP.Columns(e.ColumnIndex).Name = "Editar" Then
                Dim id_GpoProd As String
                'para enviar informacion al formulario
                id_GpoProd = Dgv_EditarGP.Rows(e.RowIndex).Cells("id").Value
                'envia datos al formulario
                Dim mostrarform As New EditarGpoProd()
                mostrarform.Obtener_IdGP(id_GpoProd)  'envia el ID de la marca seleccionada, a la funcion publica del formulario de edicion
                mostrarform.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        carga_gp()
    End Sub
End Class