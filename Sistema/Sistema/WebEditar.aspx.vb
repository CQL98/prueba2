
Imports CapaEntidad
Imports CapaNegocio
Public Class WebEditar
    Inherits System.Web.UI.Page
    Dim mpContentPlaceHolder As ContentPlaceHolder

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim oCliente As New ClienteCN

        If Not IsPostBack Then

            Dim codigo As String
            codigo = Request.QueryString("codigo")
            Dim ds As New DataSet
            ds = oCliente.Buscar_x_codigo(codigo)
            lblCodigo.Text = codigo
            txtApellido.Text = ds.Tables(0).Rows(0).Item(1)
            txtNombre.Text = ds.Tables(0).Rows(0).Item(2)
            txtDireccion.Text = ds.Tables(0).Rows(0).Item(3)
            txtEmail.Text = ds.Tables(0).Rows(0).Item(4)
            calendar.SelectedDate = ds.Tables(0).Rows(0).Item(5)
            txtTelefono.Text = ds.Tables(0).Rows(0).Item(6)

        End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("WebClientes.aspx")
    End Sub
    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim oCliente As New ClienteCN
        oCliente.Editar(New Cliente(lblCodigo.Text, txtApellido.Text, txtNombre.Text, txtDireccion.Text, txtEmail.Text, calendar.SelectedDate, txtTelefono.Text))
    End Sub
End Class