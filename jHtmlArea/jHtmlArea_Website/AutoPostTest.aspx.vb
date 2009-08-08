
Partial Class PostTest
    Inherits System.Web.UI.Page

    Public Sub PostTest_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        txtText.Value = Request("txtText")
    End Sub
End Class
