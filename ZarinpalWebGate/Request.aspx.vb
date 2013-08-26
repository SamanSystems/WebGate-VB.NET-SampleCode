Public Class RequestForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click
        System.Net.ServicePointManager.Expect100Continue = False
        Dim Zarp As New zarinpal.PaymentGatewayImplementationService, Authority As String, Status As Integer
        Status = Zarp.PaymentRequest(ZarinpalWebGate.My.MySettings.Default.ZarinpalMerchantCode, CInt(txtAmount.Text), txtDescription.Text, "email@yoursite.com", "09123456789", "http://localhost/verify.aspx", Authority)

        If Status.Equals(100) Then
            Response.Redirect("https://www.zarinpal.com/pg/StartPay/" & Authority)
        Else
            Response.Write("error: " & Status)
        End If
    End Sub
End Class