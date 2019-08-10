Imports System.Text
Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion
Public Class EntradasMerca
    Private Sub BGuardardetaentramerca_Click(sender As Object, e As EventArgs) Handles BGuardardetaentramerca.Click
        Dim conexion As New MySqlConnection(ConnectionString2)

        Dim CONSULTA As New StringBuilder
        CONSULTA.Clear()
        CONSULTA.AppendLine("insert into detalle_entrada(id_producto, costo, cantidad)")
        CONSULTA.AppendLine($"values ('{Tcosto.Text}',")
        CONSULTA.AppendLine($"'{Tcantidad.Text}')")



        Dim COMANDO As New MySqlCommand(CONSULTA.ToString(), conexion)

        conexion.Open()
        COMANDO.ExecuteNonQuery()


        conexion.Close()
        MsgBox("DATOS GUARDADOS CORRECTAMENTE!!")

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

    Private Sub listacodigobarras()
        Dim conexion As New MySqlConnection(ConnectionString2)
        conexion.Open()

        Dim consulta2 As String
        consulta2 = "select * from catalogo_productos"
        Dim adaptador2 = New MySqlDataAdapter(consulta2, conexion)
        Dim datos2 = New DataSet
        datos2.Tables.Add("codigo_barras")
        adaptador2.Fill(datos2.Tables("codigo_barras"))

    End Sub

    Private Sub EntradasMerca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaprov()
        listadescrip()
    End Sub

    Private Sub listadescrip()
        Dim conexion As New MySqlConnection(ConnectionString2)
        conexion.Open()


        Dim consulta As String
        consulta = "select * from catalogo_productos"
        Dim adaptador = New MySqlDataAdapter(consulta, conexion)
        Dim datos = New DataSet
        datos.Tables.Add("catalogo_productos")
        adaptador.Fill(datos.Tables("catalogo_productos"))
        ComboBoxdescrip.DataSource = datos.Tables("catalogo_productos")
        ComboBoxdescrip.DisplayMember = "descripcion"
        conexion.Close()
    End Sub


End Class