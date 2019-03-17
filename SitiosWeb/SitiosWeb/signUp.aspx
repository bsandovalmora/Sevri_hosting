<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signUp.aspx.cs" Inherits="SitiosWeb.signUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no" />
		<link rel="stylesheet" href="assets/css/main.css" />
		<noscript><link rel="stylesheet" href="assets/css/noscript.css" /></noscript>
</head>
<body class="is-preload landing">
   
	<form id="form1" runat="server">
   
	<h3>Iniciar Sesi&oacute;on</h3>


		<asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
		<asp:TextBox ID="txtUser" runat="server" Width="683px"></asp:TextBox>
		<p>
			<asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
			<asp:TextBox ID="txtPass" runat="server" Width="686px"></asp:TextBox>
		</p>
			<div class="col-4 col-12-xsmall">
				<asp:Button  class="fit primary" ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingresar" />
			</div>
	</form>


</body>
	<script src="assets/js/jquery.min.js"></script>
			<script src="assets/js/jquery.scrolly.min.js"></script>
			<script src="assets/js/jquery.dropotron.min.js"></script>
			<script src="assets/js/jquery.scrollex.min.js"></script>
			<script src="assets/js/browser.min.js"></script>
			<script src="assets/js/breakpoints.min.js"></script>
			<script src="assets/js/util.js"></script>
			<script src="assets/js/main.js"></script>
</html>
