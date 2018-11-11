
Imports CapaEntidad
Imports CapaNegocio
Public Class WebCliente
    Inherits System.Web.UI.Page
    Dim mpContentPlaceHolder As ContentPlaceHolder

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        mpContentPlaceHolder = CType(Master.FindControl("ContentPlaceHolder2"), ContentPlaceHolder)

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("WebClientes.aspx")
    End Sub
    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim oCliente As New ClienteCN
        'oCliente.Insertar(New Cliente(
        '                  0,
        '                  CType(mpContentPlaceHolder.FindControl("txtApellido"), TextBox).Text,
        '                  CType(mpContentPlaceHolder.FindControl("txtNombre"), TextBox).Text,
        '                  CType(mpContentPlaceHolder.FindControl("txtDireccion"), TextBox).Text,
        '                  CType(mpContentPlaceHolder.FindControl("txtEmail"), TextBox).Text,
        '                  CType(mpContentPlaceHolder.FindControl("calendar"), Calendar).SelectedDate,
        '                  CType(mpContentPlaceHolder.FindControl("txtTelefono"), TextBox).Text))
        oCliente.Insertar(New Cliente(0, txtApellido.Text, txtNombre.Text, txtDireccion.Text, txtEmail.Text, calendar.SelectedDate, txtTelefono.Text))
        txtApellido.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtEmail.Text = ""
        txtTelefono.Text = ""


    End Sub
End Class