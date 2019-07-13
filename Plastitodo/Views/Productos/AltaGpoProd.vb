Imports MySql.Data.MySqlClient

Public Class AltaGpoProd


    Private Sub AltaGpoProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'llenar el combo box para creación de familias
        Dim cons_altagpo As String = Nothing
        Dim datat As New DataTable
        Dim datad As MySqlDataAdapter

        cons_altagpo = "SELECT id_familia,nom_familia FROM catalogacion_familias"
        datad = New MySqlDataAdapter(cons_altagpo, con_string)
        datat = New DataTable
        datad.Fill(datat)
        cmbo_nomfam.DataSource = datat
        cmbo_nomfam.DisplayMember = "nom_familia"
    End Sub


    Private Sub txt_cat_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cat.LostFocus
        txt_gpoprod.Text = txt_idfamilia.Text & txt_cat.Text
    End Sub
End Class