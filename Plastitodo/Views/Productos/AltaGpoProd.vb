Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion

Public Class AltaGpoProd
    Public idfam As String = Nothing
    Public sel As String = Nothing

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
            considcat = "SELECT (IFNULL(MAX(Id_categoria),0)+1) AS MaxId FRom catalogacion WHERE Id_familia = @select"
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
    End Sub
End Class