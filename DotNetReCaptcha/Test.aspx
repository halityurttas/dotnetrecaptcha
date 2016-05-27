<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="DotNetReCaptcha.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="g-recaptcha" data-sitekey="6Lc8lwcTAAAAAC-Prj1Py8epgTnWbJhLJxnP3pkI"></div>
    <script src='https://www.google.com/recaptcha/api.js'></script>
    <asp:Button ID="btnsend" runat="server" Text="Gönder" OnClick="btnsend_Click" />
    <asp:Label ID="lblResult" runat="server"></asp:Label>
    </form>
</body>
</html>
