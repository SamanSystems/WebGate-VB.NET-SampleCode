Public Class VerifyForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not String.IsNullOrEmpty(Request.QueryString("Status")) Then
            If Request.QueryString("Status").Equals("OK") Then
                System.Net.ServicePointManager.Expect100Continue = False
                Dim Zarp As New zarinpal.PaymentGatewayImplementationService, Status As VariantType, Amount As Integer, RefID As UInt64

                Amount = 100
                Status = Zarp.PaymentVerification(ZarinpalWebGate.My.MySettings.Default.ZarinpalMerchantCode, Request.QueryString("Authority"), Amount, RefID)

                If Status = 100 Then
                    Response.Write("Success!! RefId: " & RefID)
                Else
                    Response.Write("Error!! Status: " & Status)
                End If

            Else
                Response.Write("Error! Authority: " & Request.QueryString("Authority") & " Status: " & Request.QueryString("Status"))
            End If
        Else
            Response.Write("Invalid Input")
        End If
    End Sub

End Class