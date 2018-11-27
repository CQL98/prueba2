
Imports CapaEntidad
Imports CapaNegocio
Public Class WebClientes
    Inherits System.Web.UI.Page
    Dim mpContentPlaceHolder As ContentPlaceHolder
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' mpContentPlaceHolder = CType(Master.FindControl("ContentPlaceHolder1"), ContentPlaceHolder)
            'If Not mpContentPlaceHolder Is Nothing Then
            'If Not IsPostBack Then
            mostrar()
            '    End If

            'End If
        End If



    End Sub

    Sub mostrar()
        Try
            Dim oCliente As New ClienteCN
            ' Dim grdCliente As GridView
            'grdCliente = CType(mpContentPlaceHolder.FindControl("grdCliente"), GridView)
            grdCliente.DataSource = oCliente.ListarTodos
            grdCliente.DataBind()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub


    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim oCliente As New ClienteCN
        Dim txtBusca As New TextBox

        'txtBusca = CType(mpContentPlaceHolder.FindControl("txtBuscar"), TextBox)
        ' Dim grdCliente As GridView
        'grdCliente = CType(mpContentPlaceHolder.FindControl("grdCliente"), GridView)
        grdCliente.DataSource = oCliente.Buscar_x_nombre(txtBuscar.Text)
        grdCliente.DataBind()

    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Response.Redirect("WebCliente.aspx")
        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModalx", "$('#myModalx').modal();", True)
    End Sub
    Protected Sub grdCliente_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grdCliente.RowCommand
        If e.CommandName = "Eliminar" Then
            Dim codCliente As String
            codCliente = e.CommandArgument
            Dim oCliente As New ClienteCN
            oCliente.Eliminar(codCliente)
            mostrar()
        End If
        If e.CommandName = "Editar" Then
            Dim codCliente As String
            codCliente = e.CommandArgument
            Response.Redirect("WebEditar.aspx?codigo=" & codCliente & "")
        End If
    End Sub
    Protected Sub calendar_Click(sender As Object, e As EventArgs) Handles calendar.SelectionChanged

        'Response.Redirect("WebCliente.aspx")
        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModalx", "$('#myModalx').modal();", True)
    End Sub
    Protected Sub calendar_VisibleMonthChanged(sender As Object, e As MonthChangedEventArgs) Handles calendar.VisibleMonthChanged
        'Response.Redirect("WebCliente.aspx")
        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModalx", "$('#myModalx').modal();", True)
    End Sub


    Protected Sub grdCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grdCliente.SelectedIndexChanged

    End Sub


    Protected Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim oCliente As New ClienteCN
        oCliente.Insertar(New Cliente(0, txtApellido.Text, txtNombre.Text, txtDireccion.Text, txtEmail.Text, Calendar.SelectedDate, txtTelefono.Text))
        txtApellido.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtEmail.Text = ""
        txtTelefono.Text = ""
        mostrar()
    End Sub

End Class